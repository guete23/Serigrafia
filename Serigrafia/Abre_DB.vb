Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports C1.C1Excel
Module Module1
    Public _styles As Hashtable


    Public Sub empresa(ByRef empresa As String)
        Dim obj As New empresas()
        empresa = obj.numero
    End Sub

    Public Sub alinea_decimal(ByRef valor As String, ByVal t As Integer)
        Dim h As String = "###,###,##0.00"
        Dim sp As String = Space(t)
        Try
            valor = Format(CDec(valor), h)
            valor = Mid(sp, 1, t - valor.Length) + valor
        Catch
        End Try
    End Sub

    Public Sub a_excel(ByVal fg As C1FlexGrid, ByVal path As String, ByRef ok As Boolean)
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveExcel(path, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            ok = False
        End Try
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
        End If
    End Sub
    Public Sub llena_combos(ByVal combo As System.Windows.Forms.ComboBox, ByVal strsql As String, ByVal campo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        llena_tablas(dt, strsql, cnn)
        combo.Items.Clear()
        For Each dr In dt.Rows
            Try
                combo.Items.Add(dr(campo))
            Catch
                combo.Items.Add(dr(0))
            End Try

        Next
        If combo.Items.Count > 0 Then
            combo.SelectedIndex = 0
        End If
    End Sub
    Public Sub llena_combos_0(ByVal combo As System.Windows.Forms.ComboBox, ByVal strsql As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        llena_tablas(dt, strsql, cnn)
        combo.Items.Clear()
        For Each dr In dt.Rows
            combo.Items.Add(dr(0))
        Next
        If combo.Items.Count > 0 Then
            combo.SelectedIndex = 0
        End If
    End Sub


    Public Sub llena_combos1(ByVal combo As System.Windows.Forms.ComboBox, ByVal strsql As String, ByVal campo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        llena_tablas1(dt, strsql)
        combo.Items.Clear()
        For Each dr In dt.Rows
            combo.Items.Add(dr(campo))
        Next
        If combo.Items.Count > 0 Then
            combo.SelectedIndex = 0
        End If
    End Sub
    Public Sub llena_combos2(ByVal combo As System.Windows.Forms.ComboBox, ByVal strsql As String, ByVal campo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        llena_tablas2(dt, strsql)
        combo.Items.Clear()
        For Each dr In dt.Rows
            combo.Items.Add(dr(campo))
        Next
        If combo.Items.Count > 0 Then
            combo.SelectedIndex = 0
        End If
    End Sub

    Public Sub llena_tablas(ByRef dt As DataTable, ByVal strSql As String, ByRef cnn As System.Data.SqlClient.SqlConnection)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim obj As New empresas()
        Dim nombre As String = obj.nombre
        Dim ds As New DataSet()
        cnn = New SqlClient.SqlConnection
        cnn.ConnectionString = obj.constr
        da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
        Try
            da.Fill(ds)
            dt = ds.Tables(0)
        Catch
        End Try
    End Sub

    Public Sub llena_tablas1(ByRef dt As DataTable, ByVal strSql As String)
        Dim cnn As New System.Data.SqlClient.SqlConnection
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet()
        Dim cs As New libjap.util
        cnn = cs.conecta_c
        da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
        Try
            da.Fill(ds)
            dt = ds.Tables(0)
        Catch
        End Try
    End Sub
    Public Sub llena_tablas2(ByRef dt As DataTable, ByVal strSql As String)
        Dim cnn As New System.Data.SqlClient.SqlConnection
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet()
        Dim cs As New libjap.util
        cnn = cs.conecta_z
        da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
        Try
            da.Fill(ds)
            dt = ds.Tables(0)
        Catch
        End Try
    End Sub
    Public Sub llena_tablas_c(ByRef dt As DataTable, ByVal strSql As String, ByRef cnn As System.Data.SqlClient.SqlConnection)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet()
        da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
        Try
            da.Fill(ds)
            dt = ds.Tables(0)
        Catch
        End Try
    End Sub


    Public Sub busca_en_combo(ByRef codigo As Windows.Forms.ComboBox, ByRef e As System.Windows.Forms.KeyEventArgs)
        Dim index As Integer
        Dim actual As String = ""
        Dim found As String = ""

        ' No haga nada si presionan estas teclas
        If e.KeyCode = Keys.Enter Then
            Exit Sub
        End If
        If ((e.KeyCode = Keys.Back) Or _
            (e.KeyCode = Keys.Left) Or _
            (e.KeyCode = Keys.Right) Or _
            (e.KeyCode = Keys.Up) Or _
            (e.KeyCode = Keys.Delete) Or _
            (e.KeyCode = Keys.Down) Or _
            (e.KeyCode = Keys.PageUp) Or _
            (e.KeyCode = Keys.PageDown) Or _
            (e.KeyCode = Keys.Home) Or _
            (e.KeyCode = Keys.End)) Then
            Return
        End If

        ' graba el texto ingresado.
        actual = codigo.Text

        ' encuentra la primera concordancia
        index = codigo.FindString(actual)

        ' recupera el texto de la concordancia
        If (index > -1) Then
            found = codigo.Items(index).ToString()

            ' selecciona el item del combo
            codigo.SelectedIndex = index

            ' Selecciona la porcion del texto que automaticamente fue seleccioanada
            codigo.SelectionStart = actual.Length
            codigo.SelectionLength = found.Length
        End If

    End Sub
    Public Sub AutoCompletar(ByRef cb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim strFindStr As String
        Dim i As Integer = cb.SelectedIndex
        If e.KeyChar = Chr(8) Then  'Backspace
            If cb.SelectionStart <= 1 Then
                cb.SelectionStart = 1
                ' Exit Sub
            End If
            If cb.SelectionLength = 0 Then
                strFindStr = cb.Text.Substring(0, cb.Text.Length - 1)
            Else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1)
            End If
        Else
            If cb.SelectionLength = 0 Then
                strFindStr = cb.Text & e.KeyChar
            Else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart) & e.KeyChar
            End If
        End If

        Dim intIdx As Integer = -1

        ' Search the string in the Combo Box List.
        intIdx = cb.FindString(strFindStr)

        If intIdx <> -1 Then ' String found in the List.
            cb.SelectedText = ""
            cb.SelectedIndex = intIdx
            cb.SelectionStart = strFindStr.Length
            cb.SelectionLength = cb.Text.Length
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub setea_empresa()
        Dim obj As empresas
        Dim cs As New libjap.util
        obj = New empresas()
        obj.numero = "1"
        obj.nombre = "Texsun S.A."
        obj.constr = cs.con_string
        obj.conexion = cs.con_ole
    End Sub

    Public Sub setea_meses(ByRef m() As String)
        m(1) = "ENERO"
        m(2) = "FEBRERO"
        m(3) = "MARZO"
        m(4) = "ABRIL"
        m(5) = "MAYO"
        m(6) = "JUNIO"
        m(7) = "JULIO"
        m(8) = "AGOSTO"
        m(9) = "SEPTIEMBRE"
        m(10) = "OCTUBRE"
        m(11) = "NOVIEMBRE"
        m(12) = "DICIEMBRE"
    End Sub
    Public Function numeros_a_letras(valor As Decimal) As String
        Dim i As Integer
        Dim letras As String = ""
        Dim u(10) As String
        Dim d(10) As String
        Dim c(10) As String
        Dim t(10) As String
        Dim g(10) As String
        Dim u1 As String = "|UN |DOS |TRES |CUATRO |CINCO |SEIS |SIETE |OCHO |NUEVE |"
        Dim d1 As String = "|DIEZ |VEINTE |TREINTA |CUARENTA |CINCUENTA |SESENTA |SETENTA |OCHENTA |NOVENTA |"
        Dim c1 As String = "|CIENTO |DOSCIENTOS |TRESCIENTOS |CUATROCIENTOS |QUINIENTOS |SEISCIENTOS |SETECIENTOS |OCHOCIENTOS |NOVECIENTOS |"
        Dim t1 As String = "DIEZ |ONCE |DOCE |TRECE |CATORCE |QUINCE |DIECISEIS |DIECISIETE |DIECIOCHO |DIECINUEVE |"
        Dim v1 As String = "VEINTE |VEINTIUNO |VEINTIDOS |VEINTITRES |VEINTICUATRO |VEINTICINCO |VEINTISEIS |VEINTISIETE |VEINTIOCHO |VEINTINUEVE |"
        Dim val As String
        Dim dec As String
        Dim b As String = ""
        Dim un As Integer
        Dim de As Integer
        Dim ce As Integer
        val = Format(valor, "000000000.00")
        dec = " CON " & Mid(val, 11) & "/100 "
        valor = CInt(Mid(val, 1, 9))
        letras = ""
        If valor > 0 Then
            For i = 1 To 7 Step 3
                b = Mid(val, i, 3)
                ce = Mid(val, i, 1)
                de = Mid(val, i + 1, 1)
                un = Mid(val, i + 2, 1)
                '============================== CENTENAS ======================
                If ce > 0 Then
                    If b = "100" Then
                        letras = letras + "CIEN "
                    Else
                        letras = letras + val_let(c1, ce)
                    End If
                End If
                '============================== DECENAS ======================
                Select Case de
                    Case 0
                        If un > 0 Then
                            b = val_let(u1, un)
                            If i = 7 And un = 1 Then
                                b = "UNO "
                            End If
                            letras = letras + b
                        End If
                    Case 1
                        letras = letras + val_let(t1, un)
                    Case 2
                        letras = letras + val_let(v1, un)
                    Case 3, 4, 5, 6, 7, 8, 9
                        letras = letras + val_let(d1, de)
                        If un > 0 Then
                            letras = letras + "Y "
                        End If
                        b = val_let(u1, un)
                        If i = 7 And un = 1 Then
                            b = "UNO "
                        End If
                        letras = letras + b
                End Select
                If i = 1 Then
                    Select Case un
                        Case 0
                        Case 1
                            letras = "UN MILLON "
                        Case 2, 3, 4, 5, 6, 7, 8, 9
                            letras = letras + "MILLONES "
                    End Select
                End If
                If i = 4 Then
                    If (ce + de + un) > 0 Then
                        If letras = "UN " Then
                            letras = ""
                        End If
                        letras = letras + "MIL "
                    End If
                    Select Case un
                        Case 0
                        Case 1
                    End Select
                    If un > 0 Then

                    End If
                End If
            Next
            letras = letras + dec
        Else
            letras = "CERO " + dec
        End If
        Return letras
    End Function

    Private Function val_let(n As String, v As Integer) As String
        Dim le As String
        Dim r(9) As String
        le = ""
        Try
            r = Split(n, "|")
            le = r(v)
        Catch
        End Try
        Return le
    End Function


    Public Sub busca_reportes()
        Dim path As String = "c:\Sistemas_Texsun"
        Try
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If
        Catch
        End Try
        Try
            If File.Exists(path + "\conta.xml") Then
                File.Delete(path + "\conta.xml")
            End If
        Catch
        End Try
        Try
            If File.Exists(path + "\reportes.xml") Then
                File.Delete(path + "\reportes.xml")
            End If
        Catch
        End Try
        Try
            FileCopy("\\tecnico\programas\vb2010\Sistemas_Texsun\conta.xml", path + "\conta.xml")
            FileCopy("\\tecnico\programas\vb2010\Sistemas_Texsun\reportes.xml", path + "\reportes.xml")
        Catch ex As Exception
        End Try
    End Sub
    Public Function Validacion_Nit(ByVal NIT As String) As Boolean
        Dim POS As Integer
        Dim Correlativo As String
        Dim DigitoVerificador As String
        Dim Factor As Integer
        Dim Suma As Integer = 0
        Dim Valor As Integer = 0
        Dim X As Integer
        Dim xMOD11 As Double = 0
        Dim S As String = ""
        Validacion_Nit = False
        Try
            POS = NIT.IndexOf("-")
            If POS < 1 Then Exit Function
            Correlativo = NIT.Substring(0, POS)
            DigitoVerificador = NIT.Substring(POS + 1)
            Factor = Correlativo.Length + 1
            For X = 0 To (NIT.IndexOf("-")) - 1
                Valor = Convert.ToInt32(NIT.Substring(X, 1))
                Suma += (Valor * Factor)
                Factor -= 1
            Next
            xMOD11 = (11 - (Suma Mod 11)) Mod 11
            S = Convert.ToString(xMOD11)
            If (xMOD11 = 10 And DigitoVerificador = "K") Or (S = DigitoVerificador) Then
                Validacion_Nit = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function digito_v(ByVal P_Numero_Nit As String)
        Dim P_Separador As String = "-"
        Dim V_Sum As Integer
        Dim V_i As Integer
        Dim r As Integer
        Dim largo As Integer = P_Numero_Nit.IndexOf("-")
        If largo > 0 Then
            P_Numero_Nit = Mid(P_Numero_Nit, 1, largo)
        End If

        If Trim(P_Numero_Nit) = "" Then
            Return ("")
        Else
            V_Sum = 0
            '-- Lectura del NIT de derecha a izquierda
            For V_i = largo To 1 Step -1
                '-- El comando TO_NUMBER convierte un texto que contiene numero a valor numerico
                V_Sum = V_Sum + CInt(Mid(P_Numero_Nit, V_i, 1)) * (largo - V_i + 2)
            Next
            '-- El comando MOD se utiliza para obtener una longitud del numero de NIT
            '-- Ejemplo MOD(764376,11) = 8, o sea, un campo de hasta 8 digitos
            r = (11 - (V_Sum Mod 11)) Mod 11
            If (11 - (V_Sum Mod 11)) Mod 11 = 10 Then
                Return ("K")
            ElseIf (11 - (V_Sum Mod 11)) Mod 11 = 11 Then
                Return ("0")
            Else
                Return (r)
            End If
        End If
        End
    End Function
    Public Sub alinea_entero(ByRef valor As String, ByVal t As Integer)
        Dim h As String = "########0"
        Dim sp As String = Space(t)
        Try
            valor = Format(CDec(valor), h)
            valor = Mid(sp, 1, t - valor.Length) + valor
        Catch
        End Try
    End Sub
    Public Sub alinea_q(ByRef valor As String, ByVal t As Integer)
        Dim h As String = "Q###,###,##0.00"
        Dim sp As String = Space(t)
        Try
            valor = Format(CDec(valor), h)
            valor = Mid(sp, 1, t - valor.Length) + valor
        Catch
        End Try
    End Sub

    Public Sub llena_combos_especiales(ByVal tabla As String, ByRef cu As DataTable, ByRef codigo As ComboBox, ByVal campo As String)
        Dim cnn As New SqlClient.SqlConnection
        cu = New DataTable()
        Dim dr As DataRow
        llena_tablas(cu, "SELECT * FROM " & tabla & " ORDER BY " & campo, cnn)
        codigo.Items.Clear()
        For Each dr In cu.Rows
            Try
                codigo.Items.Add(dr(campo))
            Catch
            End Try
        Next
        If cu.Rows.Count > 0 Then
            codigo.SelectedIndex = 0
        End If
    End Sub
    Public Sub llena_combos_especiales_e(ByVal tabla As String, ByRef cu As DataTable, ByRef codigo As ComboBox, ByVal campo As String, cnn As SqlClient.SqlConnection)
        cu = New DataTable()
        Dim dr As DataRow
        llena_tablas_c(cu, tabla, cnn)
        codigo.Items.Clear()
        For Each dr In cu.Rows
            Try
                codigo.Items.Add(dr(campo))
            Catch
            End Try
        Next
        If cu.Rows.Count > 0 Then
            codigo.SelectedIndex = 0
        End If
    End Sub
    Public Sub busca_codigos_especiales(ByVal cu As DataTable, ByVal campo As String, ByVal condicion As String, ByVal buscar As String, ByRef codigo As String, ByRef ok As Boolean)
        Dim dw As DataRow()
        Dim dr As DataRow
        codigo = ""
        ok = False
        'Try
        dw = cu.Select(campo & "= '" & condicion & "'")

        If dw.Length > 0 Then
            dr = dw(0)
            codigo = dr(buscar)
            ok = True
        End If
        'Catch
        'End Try
    End Sub
    Public Sub busca_codigos_especiales_d(ByVal cu As DataTable, ByVal campo As String, ByVal buscar As String, ByRef dr As DataRow, ByRef ok As Boolean)
        Dim dw As DataRow()
        ok = False
        Try
            dw = cu.Select(campo & "= '" & buscar & "'")
            If dw.Length > 0 Then
                dr = dw(0)
                ok = True
            End If
        Catch
        End Try
    End Sub

    Public Sub tipo_de_cambio(ByVal fecha As Date, ByRef venta As Decimal, ByRef compra As Decimal)
        Dim tc As New DataTable
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection
        venta = 0
        compra = 0
        llena_tablas(tc, "SELECT * FROM BANCO05 WHERE FECHA = '" & Format(fecha, "yyyy-MM-dd") & "'", cnn)
        For Each dr In tc.Rows
            venta = dr("VENTA")
            compra = dr("COMPRA")
        Next
    End Sub

    Public Sub alinea_d(ByRef valor As String, ByVal t As Integer, ByVal c As String)
        Dim h As String = c + "###,###,##0.00"
        Dim sp As String = Space(t)
        Try
            valor = Format(CDec(valor), h)
            valor = Mid(sp, 1, t - valor.Length) + valor
        Catch
        End Try
    End Sub
    Public Sub DrawRoundedRectangle(ByVal objGraphics As Graphics,
                                  ByVal m_intxAxis As Integer,
                                  ByVal m_intyAxis As Integer,
                                  ByVal m_intWidth As Integer,
                                  ByVal m_intHeight As Integer,
                                  ByVal m_diameter As Integer)



        'Dim g As Graphics
        Dim BaseRect As New RectangleF(m_intxAxis, m_intyAxis, m_intWidth,
                                      m_intHeight)
        Dim ArcRect As New RectangleF(BaseRect.Location,
                                  New SizeF(m_diameter, m_diameter))
        'top left Arc
        objGraphics.DrawArc(Pens.Black, ArcRect, 180, 90)
        objGraphics.DrawLine(Pens.Black, m_intxAxis + CInt(m_diameter / 2),
                             m_intyAxis,
                             m_intxAxis + m_intWidth - CInt(m_diameter / 2),
                             m_intyAxis)

        ' top right arc
        ArcRect.X = BaseRect.Right - m_diameter
        objGraphics.DrawArc(Pens.Black, ArcRect, 270, 90)
        objGraphics.DrawLine(Pens.Black, m_intxAxis + m_intWidth,
                             m_intyAxis + CInt(m_diameter / 2),
                             m_intxAxis + m_intWidth,
                             m_intyAxis + m_intHeight - CInt(m_diameter / 2))

        ' bottom right arc
        ArcRect.Y = BaseRect.Bottom - m_diameter
        objGraphics.DrawArc(Pens.Black, ArcRect, 0, 90)
        objGraphics.DrawLine(Pens.Black, m_intxAxis + CInt(m_diameter / 2),
                             m_intyAxis + m_intHeight,
                             m_intxAxis + m_intWidth - CInt(m_diameter / 2),
                             m_intyAxis + m_intHeight)

        ' bottom left arc
        ArcRect.X = BaseRect.Left
        objGraphics.DrawArc(Pens.Black, ArcRect, 90, 90)
        objGraphics.DrawLine(Pens.Black,
                             m_intxAxis, m_intyAxis + CInt(m_diameter / 2),
                             m_intxAxis,
                             m_intyAxis + m_intHeight - CInt(m_diameter / 2))

    End Sub


    Public Function RoundedRec(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer) As System.Drawing.Drawing2D.GraphicsPath
        ' Make and Draw a path.
        Dim graphics_path As New System.Drawing.Drawing2D.GraphicsPath
        graphics_path.AddLine(X + 10, Y, X + Width, Y) 'add the Top line to the path

        'Top Right corner
        Dim tr() As Point = {
            New Point(X + Width, Y),
            New Point((X + Width) + 4, Y + 2),
            New Point((X + Width) + 8, Y + 6),
            New Point((X + Width) + 10, Y + 10)}
        graphics_path.AddCurve(tr)  'Add the Top right curve to the path

        'Bottom right corner
        Dim br() As Point = {
            New Point((X + Width) + 10, Y + Height),
            New Point((X + Width) + 8, (Y + Height) + 4),
            New Point((X + Width) + 4, (Y + Height) + 8),
            New Point(X + Width, (Y + Height) + 10)}
        graphics_path.AddCurve(br)  'Add the Bottom right curve to the path

        'Bottom left corner
        Dim bl() As Point = {
            New Point(X + 10, (Y + Height) + 10),
            New Point(X + 6, (Y + Height) + 8),
            New Point(X + 2, (Y + Height) + 4),
            New Point(X, Y + Height)}
        graphics_path.AddCurve(bl)  'Add the Bottom left curve to the path

        'Top left corner
        Dim tl() As Point = {
           New Point(X, Y + 10),
           New Point(X + 2, Y + 6),
            New Point(X + 6, Y + 2),
           New Point(X + 10, Y)}
        graphics_path.AddCurve(tl)  'add the Top left curve to the path

        Return graphics_path
    End Function
End Module
