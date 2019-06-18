Imports System.Drawing.Printing
Imports System.IO
Public Class Factura_i
    Public factura As String
    Private printFont As Font
    Dim tamano_papel As PaperSize
    Dim pagina As Integer
    Dim logofont, logofont0, nitfont, venfont, headfont, tablefont, titlefont, emprefont, subrayado, printo, facfont, dfont, dfont1, tf As Font
    Dim blackPen As New Pen(Color.Black, 1)
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Dim trows As Integer
    Dim tleer As Integer = 0
    Dim ok As Boolean
    Dim sp As String = Space(140)
    Dim ano As String = ""
    Dim mes As String = ""
    Dim peri As String = ""
    Dim empre As String = ""
    Dim empresa_e As New empresas()
    Dim tb As New DataTable
    Dim tl(5) As Decimal
    Dim R As Rectangle
    Dim h As String = "#######0.00"
    Dim tolpa As Integer = 1
    Dim cae1 As String
    Dim cae2 As String
    Dim m As String
    Dim Impritot As Boolean = False

    Private Sub FAEC11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proceso()
    End Sub
    Private Sub setea_pagina()
        R = New Rectangle(20, 100, 1060, 50)
    End Sub
    Private Sub proceso()
        Dim paginas As Decimal = 0
        Dim strsql As String = "SELECT * FROM SERI_FAC02 LEFT JOIN SERI_FAC01 ON SERI_FAC02.FACTURA = SERI_FAC01.FACTURA LEFT JOIN SERI24 ON SERI_FAC02.DESPACHO = SERI24.DESPACHO LEFT JOIN SERI20 ON SERI24.PROYECTO = SERI20.PROYECTO  WHERE SERI_FAC02.FACTURA = '" & factura & "'"
        llena_tablas(dt, strsql, cnn)
        paginas = dt.Rows.Count / 47
        tolpa = Fix(paginas)
        paginas = paginas - tolpa
        If paginas > 0 Then
            tolpa = tolpa + 1
        End If
        Printing()
        Cursor = Cursors.Default
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 180
        Dim yPos As Single = 360
        Dim count As Integer = 3
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing
        Dim linea1 As String = ""
        Dim mbi As String = ""
        Dim mse As String = ""
        Dim ibi As String = ""
        Dim ise As String = ""
        Dim tipo As Integer = 0
        Dim total As String
        Dim tipc As Decimal = 0

        logofont0 = New Font("Arial", 13, FontStyle.Bold Or FontStyle.Italic)
        logofont = New Font("Times New Roman", 9, FontStyle.Italic)
        nitfont = New Font("Times New Roman", 10, FontStyle.Bold)
        headfont = New Font("Microsoft Sans Serif", 13, FontStyle.Bold)
        venfont = New Font("Arial", 9, FontStyle.Bold)
        printFont = New Font("Lucida console", 9, FontStyle.Regular)
        titlefont = New Font("Arial", 10, FontStyle.Bold)
        subrayado = New Font("Lucida console", 12, FontStyle.Bold Or FontStyle.Underline)
        dfont = New Font("Lucida console", 6, FontStyle.Regular)
        dfont1 = New Font("Lucida console", 5, FontStyle.Regular)
        tf = New Font("Lucida console", 7, FontStyle.Bold)
        printo = New Font("Lucida console", 8, FontStyle.Bold)
        facfont = New Font("Arial", 13, FontStyle.Bold)

        encabezados(ev)

        '================================ DETALLE ======================================
        ' Lineas de Detalle
        While tleer < trows
            If count < 48 Then 'lineasPorPagina
                Try
                    dr = dt.Rows(tleer)
                    tleer = tleer + 1
                    detalle1(ev, yPos)

                    yPos = yPos + 15
                    count = count + 1
                Catch
                    ev.HasMorePages = False
                    Exit While
                End Try
            Else
                ev.HasMorePages = True
                Exit Sub
            End If
        End While
        '============================= TOTALES ========================================================
        ' rectangulo(15, 1020, 500, 50, ev)
        'yPos = 850
        If count > 40 Then

            If Not Impritot Then
                Impritot = True
                ev.HasMorePages = True
                Exit Sub

            Else
                ev.HasMorePages = False

            End If
        End If


        ev.Graphics.DrawPath(Pens.Black, RoundedRec(675, yPos + 30, 130, 80))
        ev.Graphics.DrawString("TOTAL FACTURA:", venfont, Brushes.Black, 560, yPos + 67, New StringFormat())
        total = dr("VALOR_TOTAL")
        alinea_d(total, 17, "$")
        ev.Graphics.DrawString(total, printo, Brushes.Black, 670, yPos + 70, New StringFormat())
        total = numeros_a_letras(dr("VALOR_TOTAL"))
        ev.Graphics.DrawString("TOTAL : " + total, printo, Brushes.Black, 20, yPos + 130, New StringFormat())

        re_inicializa()
    End Sub

    Private Sub re_inicializa()
        pagina = 0
        tleer = 0
    End Sub
    '=================================== ENCABEZADOS ===============================
    Private Sub encabezados(ByVal ev As PrintPageEventArgs)
        pagina = pagina + 1
        Dim line As String = ""
        Dim factura As String = ""
        Dim fechas As String = ""
        Dim consig As String = ""
        Dim vende As String = ""
        Dim dir1 As String = ""
        Dim dir2 As String = ""
        Dim dr As DataRow
        Try
            dr = dt.Rows(0)
            factura = "SERI-" + Format(dr("FACTURA"), "000000")
            fechas = Format(dr("FECHA"), "dd/MMM/yyyy")
        Catch ex As Exception
            dr = Nothing
        End Try

        ' ==================== LOGO 
        ev.Graphics.DrawImage(Image.FromFile("C:\facturacion\logo.bmp"), 15, 10)
        ev.Graphics.DrawString("TEXSUN SOCIEDAD ANONIMA", logofont0, Brushes.Black, 9, 110, New StringFormat())
        ev.Graphics.DrawString("17 Avenida. 40-76 Zona 12", logofont, Brushes.Black, 65, 130, New StringFormat())
        ev.Graphics.DrawString("Tel.: PBX: 2429-3467 -  Fax: 24293499", logofont, Brushes.Black, 38, 145, New StringFormat())
        ev.Graphics.DrawString("Guatemala, Guatemala, C.A", logofont, Brushes.Black, 60, 157, New StringFormat())
        ev.Graphics.DrawString("Pagina " + CStr(pagina) + " de " + CStr(tolpa), nitfont, Brushes.Black, 720, 190, New StringFormat())
        ev.Graphics.DrawString("FACTURA DE SERIGRAFIA ", headfont, Brushes.Black, 580, 85, New StringFormat())
        ev.Graphics.DrawString("No.  :", nitfont, Brushes.Black, 580, 115, New StringFormat())
        ev.Graphics.DrawString(factura, nitfont, Brushes.Black, 640, 115, New StringFormat())
        ev.Graphics.DrawString("Fecha :   ", nitfont, Brushes.Black, 580, 130, New StringFormat())
        ev.Graphics.DrawString(fechas, nitfont, Brushes.Black, 640, 130, New StringFormat())
        ev.Graphics.DrawString("Cliente   : ", venfont, Brushes.Black, 25, 245, New StringFormat())
        ev.Graphics.DrawString(dr("NIT"), printo, Brushes.Black, 125, 247, New StringFormat())
        ev.Graphics.DrawString("", printo, Brushes.Black, 125, 267, New StringFormat())
        ev.Graphics.DrawPath(Pens.Black, RoundedRec(15, 210, 805, 75))
        ev.Graphics.DrawPath(Pens.Black, RoundedRec(15, 310, 805, 35))
        line = "    CORTE   CPO         ESTILO        COLOR            DESCRIPCION       UNIDADES   VALOR U.   VALOR T."
        ev.Graphics.DrawString(line, printFont, Brushes.Black, 1, 328, New StringFormat())

    End Sub
    Private Sub rectangulo(x As Integer, y As Integer, al As Integer, an As Integer, ByRef ev As PrintPageEventArgs)
        Dim rect As New Rectangle(x, y, al, an)
        Dim blueBrush As New SolidBrush(Color.Gainsboro)

        ev.Graphics.FillRectangle(blueBrush, rect)
        ev.Graphics.DrawRectangle(Pens.Black, rect)

    End Sub
    '=================================== DETALLE ======================================
    Private Sub detalle1(ByVal ev As PrintPageEventArgs, ypos As Integer)
        Dim descripcion As String = "SERVICIO DE SERIGRAFIA"
        Dim total As String = dr("VALOR_T")
        Dim v_unitario As String = dr("VALOR_U")
        Dim cantidad As String = dr("UNIDADES")
        Dim corte As String = dr("CORTE")
        Dim cpo As String = dr("CPO")
        Dim estilo As String = dr("ESTILO")
        Dim colo As String = dr("COLOR")
        alinea_d(total, 17, m)
        alinea_d(v_unitario, 17, m)
        alinea_entero(cantidad, 5)
        descripcion = Mid("  " + descripcion + sp + sp + sp, 1, 298)
        ev.Graphics.DrawString(corte, dfont, Brushes.Black, 30, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(cpo, dfont1, Brushes.Black, 95, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(estilo, dfont1, Brushes.Black, 190, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(colo, dfont1, Brushes.Black, 295, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(descripcion, dfont, Brushes.Black, 415, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(cantidad, dfont, Brushes.Black, 600, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(v_unitario, dfont, Brushes.Black, 620, ypos + 10, New StringFormat())
        ev.Graphics.DrawString(total, dfont, Brushes.Black, 705, ypos + 10, New StringFormat())
        ypos = ypos + 15
    End Sub
    Private Function alinea(ByVal dato As String, ByVal l As Integer) As String
        dato = dato + sp
        dato = Mid(dato, 1, l)
        alinea = dato
        Return alinea
    End Function

    Public Sub Printing()
        pagina = 0
        trows = dt.Rows.Count
        Try
            printFont = New Font("Courier New", 10)
            Dim pd As New PrintDocument()
            AddHandler pd.PrintPage, AddressOf pd_PrintPage
            tamano_papel = New PaperSize("carta", 850, 1100)
            pd.DefaultPageSettings.PaperSize = tamano_papel
            pd.DefaultPageSettings.Landscape = False
            pd.DefaultPageSettings.Margins.Bottom = 20
            pd.DefaultPageSettings.Margins.Left = 10
            pd.DefaultPageSettings.Margins.Right = 10
            ' Imprime documento
            C1PrintPreviewControl1.Document = pd
        Catch
        End Try
    End Sub


    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        proceso()
    End Sub
End Class