Public Class Proyectos_c9

    Dim cnn As New SqlClient.SqlConnection
    Dim h As String = "###,###,##0.00"
    Private Sub Proyectos_c_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llena_datos_generales()
        setea_fg()
        setea_rg()
        setea_dg()
    End Sub

    Private Sub llena_datos_generales()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim tf As String
        Dim esta As String
        Dim strsql As String = "SELECT * FROM SERI20 LEFT JOIN SERI15 ON SERI20.NIT = SERI15.NIT WHERE PROYECTO = '" & proyecto.Text & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            fecha.Text = Format(dr("FECHA_P"), "dd/MM/yyyy")
            fentrega.Text = Format(dr("FECHA_EP"), "dd/MM/yyyy")
            cliente.Text = dr("NOMBRE")
            descripcion.Text = dr("DESCRIPCION_P")
            unidades.Text = Format(dr("UNIDADES"), h)
            precio.Text = Format(dr("PRECIO_P"), h)
            cb.Text = dr("VALOR_CB")
            tf = dr("FACTURAR")
            If tf = "F" Then
                cobro.Text = "FACTURA CONTABLE"
            ElseIf tf = "E" Then
                cobro.Text = "ENVIO"
            ElseIf tf = "M" Then
                cobro.Text = "MUESTRAS / NO FACTURAR"
            End If
            esta = dr("ESTADO")
            If esta = "A" Then
                estado.Text = "EN PROCESO"
            ElseIf esta = "F" Then
                estado.Text = "FACTURADO"
            ElseIf esta = "X" Then
                estado.Text = "ANULADO"
            End If
        Next

    End Sub


    Private Sub setea_fg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM SERI21 LEFT JOIN SERI01 ON SERI21.CODIGO = SERI01.CODIGO LEFT JOIN SERI02 ON SERI01.TIPO = SERI02.TIPO  WHERE PROYECTO = '" & proyecto.Text & "'"
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CODIGO")
            fg(l, 2) = dr("DESCRIPCION")
            fg(l, 3) = dr("DESCRIPCION_MAT")
            fg(l, 4) = dr("UNIDADES")
            l = l + 1
        Next
    End Sub

    Private Sub setea_rg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM SERI23 WHERE PROYECTO = '" & proyecto.Text & "'"
        rg.Rows.Count = 1
        rg.Rows(0).Height = 30
        llena_tablas(dt, strsql, cnn)
        rg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            rg(l, 1) = dr("RECEP")
            rg(l, 2) = dr("FECHA_R")
            rg(l, 3) = dr("UNIDADES")
            rg(l, 4) = dr("RECIBIDO")
            l = l + 1
        Next
    End Sub

    Private Sub setea_dg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM SERI24 WHERE PROYECTO = '" & proyecto.Text & "'"
        dg.Rows.Count = 1
        dg.Rows(0).Height = 30
        llena_tablas(dt, strsql, cnn)
        dg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            dg(l, 1) = dr("DESPACHO")
            dg(l, 2) = dr("FECHA_D")
            dg(l, 3) = dr("PRIMERAS")
            dg(l, 4) = dr("SEGUNDAS")
            dg(l, 5) = dr("ENTREGADO")
            l = l + 1
        Next
    End Sub
End Class