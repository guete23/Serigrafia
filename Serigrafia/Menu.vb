Public Class Menu
    Dim empresa As String
    Dim nombre As String = "Serigrafia"
    Dim dt As DataTable
    Dim cnn As New SqlClient.SqlConnection()
    Dim contador As Integer
    Dim bien As Boolean
    Dim tipo As String
    Public dia_hoy As Date = Today
    Dim retval As Object
    Dim menus As String
    Dim empres As String
    Dim men As New System.Windows.Forms.MenuItem()
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 50
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim obj As empresas
    Dim r As Point
    Private _mainMenuStrip As Object
    Dim em As New datos_e

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler TextBox1.KeyPress, AddressOf keypressed1
        setea_empresa()
        posiciona_objetos()
        TextBox1.Focus()
    End Sub
    Private Sub posiciona_objetos()
        r.X = l - 250
        r.Y = empre.Location.Y
        empre.Location = r
        r.X = CInt((l / 2) - 280)
        r.Y = CInt((a / 2) - 150)
        PictureBox3.Location = r
        r.X = CInt((l / 2) - 280)
        r.Y = a - 125
        Label3.Location = r
        r.X = CInt((l / 2) - 280)
        r.Y = CInt(a - 250)
        Grupo1.Location = r
        r.X = CInt((l - 300))
        r.Y = CInt(a - 250)
        PictureBox2.Location = r
        r.X = 50
        r.Y = CInt(a - 250)
        PictureBox1.Location = r
    End Sub
    '============================================================================
    '                           password
    '============================================================================
    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(TextBox1.Text) <> "" Then
                bien = True
                busca_clave()
                If bien Then
                    habilita()
                End If
            End If
        End If
    End Sub
    Private Sub busca_clave()
        Dim dr As DataRow
        Dim existe As Boolean = True
        obj = New empresas()
        Dim strSQL As String = "SELECT * FROM SERI00 WHERE CLAVE = '" & TextBox1.Text & "'"
        contador = contador + 1
        obj = New empresas()
        If contador > 3 Then
            End
        End If
        dt = New DataTable()
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            existe = False
            bien = False
            Label3.Text = "Clave Incorrecta !!!!!!.      " + CStr(contador) + "  Intentos "
            TextBox1.Text = ""
        Else
            For Each dr In dt.Rows
                Label3.Text = dr("NOMBRE")
                menus = dr("MENUS")
                obj.usuario = Label3.Text
                obj.clave = TextBox1.Text
                obj.inicial = dr("INICIALES")
                datos_empresa()
                bien = True
            Next
        End If
    End Sub
    Private Sub datos_empresa()
        Dim emp As New DataTable
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM EMPRESAS WHERE EMPRESA = '0'"
        em = New datos_e()
        llena_tablas(emp, strSQL, cnn)
        For Each dr In emp.Rows
            em.direccion = dr("DIRECCION")
            em.nit = dr("NIT")
            em.nombre = "Serigrafía"
            em.representante = dr("REPRESENTANTE")
            em.contador = dr("CONTADOR")
            em.registro = dr("REGISTRO")
        Next
    End Sub
    Private Sub habilita()
        Dim ms As New MenuStrip
        Dim i As Integer
        Dim r As String
        Label5.Visible = True
        TextBox1.Visible = False
        Grupo1.Visible = False
        For i = 1 To Len(menus) Step 2
            r = Mid(menus, i, 2)
            menupr(r)
        Next
        empre.Visible = True
        PictureBox3.Visible = True
        PictureBox2.Visible = True
    End Sub
    Private Sub menupr(ByVal m As String)
        Dim i As Integer
        Dim ms As New ToolStripMenuItem
        Dim r As String = m
        m = Mid(r, 1, 2)
        If m = "00" Then
            For i = 0 To 10
                Try
                    Menudo.Items(i).Visible = True
                Catch ex As Exception
                End Try
            Next
        Else
            Try
                i = CInt(m) - 1
                Menudo.Items(i).Visible = True
            Catch
            End Try
        End If
    End Sub
    Private Sub menusg(ByVal ms As ToolStripMenuItem, ByVal m As String)
        Dim i As Integer
        Dim sg As String = Mid(m, 1, 2)
        Dim tr As String = Mid(m, 3, 2)
        Dim mj As New ToolStripMenuItem
        If sg = "00" Then
            For i = 0 To 5
                Try
                    ms.DropDownItems(i).Visible = True
                    mj = ms.DropDownItems.Item(i)
                    menutr(mj, "00")
                Catch ex As Exception
                End Try
            Next
        Else
            Try
                i = CInt(sg) - 1
                ms.DropDownItems.Item(i).Visible = True
                mj = ms.DropDownItems.Item(i)
                menutr(mj, tr)
            Catch
            End Try
        End If
    End Sub
    Private Sub menutr(ByVal ms As ToolStripMenuItem, ByVal m As String)
        Dim i As Integer
        If m = "00" Then
            For i = 0 To 10
                Try
                    ms.DropDownItems(i).Visible = True
                Catch ex As Exception
                End Try
            Next
        Else
            Try
                i = CInt(m) - 1
                ms.DropDownItems.Item(i).Visible = True
            Catch
            End Try
        End If
    End Sub

    Private Sub m0101_Click(sender As System.Object, e As System.EventArgs) Handles m0101.Click
        Dim forma As New Tablas
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub m0103_Click(sender As System.Object, e As System.EventArgs) Handles m0103.Click
        Dim forma As New Proveedor
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub m0102_Click(sender As System.Object, e As System.EventArgs) Handles m0102.Click
        Dim forma As New Materiales
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub IngresoDePedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IngresoDePedidosToolStripMenuItem.Click
        Dim forma As New Pedidos
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub MantenimientoDePedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantenimientoDePedidosToolStripMenuItem.Click
        Dim forma As New Pedido_mant
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub IngresosPorCompraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IngresosPorCompraToolStripMenuItem.Click
        Dim forma As New Ingresos_compra
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub InventarioDeMateriaesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioDeMateriaesToolStripMenuItem.Click
        Dim forma As New Inventario_Mat
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
        forma.Dispose()
    End Sub

    Private Sub MaestroDeProyectosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaestroDeProyectosToolStripMenuItem.Click
        Dim forma As New Proyectos
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub
    Private Sub AnulaciónDeProyectosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnulaciónDeProyectosToolStripMenuItem.Click
        Dim forma As New Proy_mant
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub AnulaciónDeRecepcionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnulaciónDeRecepcionesToolStripMenuItem.Click
        Dim forma As New Recep_mant
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub AnulaciónDeDespachosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnulaciónDeDespachosToolStripMenuItem.Click
        Dim forma As New Despacho_mant
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub IngresosOtrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IngresosOtrosToolStripMenuItem.Click
        Dim forma As New ingresos_otros
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub SalidasAlInventarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalidasAlInventarioToolStripMenuItem.Click
        Dim forma As New ingresos_otros
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub TablasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TablasToolStripMenuItem.Click
        Dim forma As New Tablas_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub MaestroProveedoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaestroProveedoresToolStripMenuItem.Click
        Dim forma As New Proveedor_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub MaestroDeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaestroDeClientesToolStripMenuItem.Click
        Dim forma As New Clientes
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub MaestroDeClientesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MaestroDeClientesToolStripMenuItem1.Click
        Dim forma As New Clientes_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ConsultaOrdenesDeCompraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaOrdenesDeCompraToolStripMenuItem.Click
        Dim forma As New Pedidos_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ConsultaDeProyectosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeProyectosToolStripMenuItem.Click
        Dim forma As New Proyectos_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub ConsultaDeProyectosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeProyectosToolStripMenuItem1.Click
        Dim forma As New Proyectos_c1_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ConsultaDeRecepcionDePrendasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeRecepcionDePrendasToolStripMenuItem.Click
        Dim forma As New Recepcion_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ConsultaDeDespachoDePrendasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeDespachoDePrendasToolStripMenuItem.Click
        Dim forma As New Despacho_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ConsultaDeMovimientosDeMaterialesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeMovimientosDeMaterialesToolStripMenuItem.Click
        Dim forma As New Inventario_c
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim forma As New Salidas_p
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub RecepciónToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RecepciónToolStripMenuItem1.Click
        Dim forma As New Recepcion
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub CortesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CortesToolStripMenuItem.Click
        Dim forma As New Consulta_cortes
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub DespachosLocalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespachosLocalesToolStripMenuItem.Click
        Dim forma As New Facturacion
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub DespachosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespachosToolStripMenuItem.Click
        Dim forma As New Facturacion_e
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub GeneraFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraFacturaToolStripMenuItem.Click
        Dim forma As New Factura
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub ImprimeFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimeFacturasToolStripMenuItem.Click
        Dim forma As New Factura_d
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub

    Private Sub IngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoToolStripMenuItem.Click
        Dim forma As New Despacho
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.ShowDialog()
    End Sub

    Private Sub ImpresiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónToolStripMenuItem.Click
        Dim forma As New Despacho_r
        forma.Text = forma.Text + "  (" + nombre + ")"
        forma.Size = New Size(l, a)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 100
        forma.ShowDialog()
    End Sub
End Class
