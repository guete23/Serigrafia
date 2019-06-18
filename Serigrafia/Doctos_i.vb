Imports System.Drawing.Printing
Imports System.IO
Imports C1.Win.FlexReport
Imports C1.C1Pdf
Public Class Doctos_i
    Dim empre As New empresas
    Public docto As String
    Public tipo As String
    Dim cnn As New SqlClient.SqlConnection
    Dim pdffilter As New C1.Win.C1Document.Export.PdfFilter()

    Private Sub Doctos_i_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pdffilter.ShowOptions = False
        If tipo = "P" Then
            imprime_pedidos()
        ElseIf tipo = "R" Then
            imprime_recepcion()
        ElseIf tipo = "D" Then
            imprime_despacho()
        End If
    End Sub
    '==============================================================================
    '            IMPRESION DE LOS PEDIDOS
    '==============================================================================
    Private Sub imprime_pedidos()
        Dim dt As New DataTable
        Dim obj As empresas
        Dim empresa As String
        Dim empr As String
        llena_tablas(dt, "SELECT * FROM SERI11 LEFT JOIN SERI10 ON SERI11.PEDIDO = SERI10.PEDIDO LEFT JOIN SERI01 ON SERI11.CODIGO = SERI01.CODIGO LEFT JOIN  SERI04 ON SERI10.PROVEEDOR = SERI04.PROVEEDOR WHERE SERI11.PEDIDO = '" & docto & "'", cnn)
        Try
            Try
                obj = New empresas()
                empresa = obj.nombre
                empr = Mid(empresa, 1, 2) + "-"
                ' load report
                C1r.Load("C:\serigrafia\serigra.flxr", "OC")
                C1r.DataSource.Recordset = dt
                C1r.Render()
                C1flx.DocumentSource = C1r
            Catch
            End Try
            pdffilter.FileName = "c:\reportes\Orden_" & docto & ".pdf"
            C1r.RenderToFilter(pdffilter)
        Catch
        End Try
    End Sub

    Private Sub imprime_recepcion()
        Dim obj As empresas
        Dim empresa As String
        Dim empr As String
        Try
            Try
                obj = New empresas()
                empresa = obj.nombre
                empr = Mid(empresa, 1, 2) + "-"
                ' load report
                C1r.Load("C:\serigrafia\serigra.flxr", "Recepcion")
                C1r.DataSource.ConnectionString = obj.conexion
                C1r.DataSource.RecordSource = "SELECT * FROM SERI23 LEFT JOIN SERI20 ON SERI23.PROYECTO = SERI20.PROYECTO LEFT JOIN SERI15 ON SERI20.NIT = SERI15.NIT WHERE RECEP = '" & docto & "'"
                C1r.Render()
                C1flx.DocumentSource = C1r
            Catch
            End Try
            pdffilter.FileName = "c:\reportes\Recepcion_" & docto & ".pdf"
            C1r.RenderToFilter(pdffilter)
        Catch
        End Try
    End Sub

    Private Sub imprime_despacho()
        Dim obj As empresas
        Dim empresa As String
        Dim empr As String
        Try
            Try
                obj = New empresas()
                empresa = obj.nombre
                empr = Mid(empresa, 1, 2) + "-"
                ' load report
                C1r.Load("C:\serigrafia\serigra.xml", "Despacho")
                C1r.DataSource.ConnectionString = obj.conexion
                C1r.DataSource.RecordSource = "SELECT * FROM SERI24 LEFT JOIN SERI20 ON SERI24.PROYECTO = SERI20.PROYECTO LEFT JOIN SERI15 ON SERI20.NIT = SERI15.NIT WHERE DESPACHO = '" & docto & "'"
                C1r.Render()
                C1flx.DocumentSource = C1r
            Catch
            End Try
            pdffilter.FileName = "c:\reportes\Despacho_" & docto & ".pdf"
            C1r.RenderToFilter(pdffilter)
        Catch
        End Try
    End Sub

   
End Class