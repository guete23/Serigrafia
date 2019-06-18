Public Class Pedidos
    Dim h As String = "#######0.00"
    Dim h1 As String = "######0.0000"
    Dim ok As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection
    Dim dr As DataRow()
    Dim pd1 As System.Drawing.Printing.PrintDocument
    Dim usuario_sistema As String
    Dim pr As New DataTable
    Dim tp As New DataTable
    Dim pedido_actual As String
    Private Sub Pedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler F_pedido.KeyPress, AddressOf keypressed1
        AddHandler Comentarios.KeyPress, AddressOf keypressed2
        AddHandler Codigo.KeyPress, AddressOf keypressed4
        AddHandler Nom_prov.KeyPress, AddressOf keypressed5
        AddHandler F_entrega.KeyPress, AddressOf keypressed6
        AddHandler Unidades.KeyPress, AddressOf keypressed7
        AddHandler Precio.KeyPress, AddressOf keypressed8
        AddHandler moneda.KeyPress, AddressOf keypressed10
        Dim obj As empresas
        obj = New empresas()
        usuario_sistema = obj.usuario
        F_pedido.Text = Format(Today, "dd/MM/yyyy")
        llena_combos_especiales("SERI01", tp, Codigo, "CODIGO")
        llena_combos_especiales("SERI04", pr, Nom_prov, "NOMBRE_PROV")
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub limpia_variables()
        Pedido.Text = ""
        Comentarios.Text = "S/C"
        Unidades.Text = "0"
        Precio.Text = "0"
        moneda.SelectedIndex = 0
        If Codigo.Items.Count > 0 Then
            Codigo.SelectedIndex = 0
        End If
        F_entrega.Focus()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(F_pedido.Text) <> "" Then
                Comentarios.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Comentarios.Text) <> "" Then
                Nom_prov.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Codigo.Text) <> "" Then
                Unidades.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Nom_prov.Text) <> "" Then
                moneda.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(F_entrega.Text) <> "" Then
                Comentarios.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Unidades.Text) <> "" Then
                If IsNumeric(Unidades.Text) = True Then
                    If CDec(Unidades.Text) > 0 Then
                        Precio.Focus()
                    End If
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Precio.Text) <> "" Then
                If IsNumeric(Precio.Text) = True Then
                    If CDec(Precio.Text) > 0 Then
                        agrega.Focus()
                    End If
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed10(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(moneda.Text) <> "" Then
                Codigo.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        Dim l As Integer
        busca_linea(fg.RowSel, l)
        If l > 0 Then
            selecciona_linea(l)
        End If
    End Sub

    Private Sub agrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agrega.Click
        Dim ok As Boolean
        Dim l As Integer
        busca_linea(Trim(Codigo.Text), l)
        chequea_datos(ok)
        If ok Then
            If l = -1 Then
                agrega_linea()
            Else
                cambia_linea()
            End If
        End If
        Unidades.Text = ""
        Precio.Text = ""
        Codigo.Focus()
    End Sub

    Private Sub chequea_datos(ByRef ok As Boolean)
        ok = True
        If Trim(Unidades.Text) = "" Then
            ok = False
        End If
        If IsNumeric(Unidades.Text) = True Then
            If CDec(Unidades.Text) > 0 Then
                Unidades.Text = Format(CDec(Unidades.Text), h1)
            Else
                ok = False
            End If
        Else
            ok = False
        End If
        If Not ok Then
            MsgBox("Unidades es un Campo Numérico, no nulo", MsgBoxStyle.Critical, "Unidades Incorrectas")
            Exit Sub
        End If
        If IsNumeric(Precio.Text) = True Then
            If CDec(Precio.Text) > 0 Then
                Precio.Text = Format(CDec(Precio.Text), h1)
            Else
                ok = False
            End If
        Else
            ok = False
        End If
        If Not ok Then
            MsgBox("Precio es un Campo Numérico, no nulo", MsgBoxStyle.Critical, "Precio Incorrecto")
            Exit Sub
        End If
    End Sub

    Private Sub busca_linea(ByVal busca As String, ByRef l As Integer)
        busca = Trim(Codigo.Text)
        l = fg.FindRow(busca, 1, 1, True)
    End Sub

    Private Sub agrega_linea()
        Dim l As Integer = fg.Rows.Count
        fg.Rows.Count = l + 1
        asigna_valores(l)
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer = fg.RowSel
        asigna_valores(lin)
    End Sub

    Private Sub asigna_valores(ByVal l As Integer)
        fg(l, 1) = Codigo.Text
        fg(l, 2) = Desc_Material.Text
        fg(l, 3) = F_entrega.Text
        fg(l, 4) = Unidades.Text
        fg(l, 5) = Precio.Text
        fg(l, 6) = fg(l, 4) * fg(l, 5)
    End Sub

    Private Sub borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_linea()
        End If
    End Sub

    Private Sub elimina_linea()
        Dim l As Integer
        busca_linea(Trim(Codigo.Text), l)
        If l > 0 Then
            Try
                fg.Rows.Remove(l)
            Catch
            End Try
        End If
    End Sub

    Private Sub selecciona_linea(ByVal l As Integer)
        l = fg.RowSel
        Try
            Codigo.SelectedIndex = Codigo.Items.IndexOf(Trim(fg(l, 1)))
            F_entrega.Text = fg(l, 3)
            Unidades.Text = Format(fg(l, 4), h1)
            Precio.Text = Format(fg(l, 5), h1)
        Catch
        End Try
    End Sub
    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            If fg.Row > 1 Then
                selecciona_linea(fg.Row - 1)
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If fg.Row < fg.Rows.Count Then
                selecciona_linea(fg.Row + 1)
            End If
        End If
    End Sub

    Private Sub limpia_todo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpia_todo.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Borrar sin Actualizar?  ", MsgBoxStyle.YesNo, "Limpiando Variables !!!")
        If seguro = MsgBoxResult.Yes Then
            setea_grid()
            limpia_variables()
        End If
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Antes de proceder a Grabar primero debe revisar todos los datos detallamente." + vbLf + "Una vez actualizado no se pueden hacer cambios a la Orden de Compra." + vbLf + "Está Seguro de querer grabar los Datos?  ", MsgBoxStyle.YesNo, "Actualizando Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_pedidos()
            imprime_pedidos()
            setea_grid()
            limpia_variables()
        End If
    End Sub

    Private Sub Codigo_Salida(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codigo.Leave
        Dim l As Integer = fg.FindRow(Codigo.Text, 1, 1, True)
        If l > 0 Then
            selecciona_linea(l)
        End If
    End Sub

    Private Sub Codigo_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codigo.SelectedIndexChanged
        busca_codigos_especiales(tp, "CODIGO", Codigo.Text, "DESCRIPCION", Desc_Material.Text, ok)
    End Sub

    Private Sub Nom_prov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nom_prov.SelectedIndexChanged
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            fg(i, 4) = Nom_prov.Text
        Next
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim forma As New Busca_mat()
        forma.ShowDialog()
        If forma.selec <> "" Then
            Codigo.SelectedIndex = Codigo.Items.IndexOf(Trim(forma.selec))
        Else
            Codigo.SelectedIndex = 0
        End If
        Unidades.Text = ""
        Precio.Text = ""
        Unidades.Focus()
    End Sub
    Private Sub moneda_c(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles moneda.KeyPress
        AutoCompletar(moneda, e)
    End Sub
    Private Sub codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Codigo.KeyPress
        AutoCompletar(Codigo, e)
    End Sub
    Private Sub prov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_prov.KeyPress
        AutoCompletar(Nom_prov, e)
    End Sub

    Private Sub imprime_pedidos()
        Dim forma As New Doctos_i
        forma.tipo = "P"
        forma.docto = pedido_actual
        forma.ShowDialog()
    End Sub
    '=================================================================================
    '                        GRABA PEDIDOS
    '=================================================================================
    Private Sub graba_pedidos()
        Dim strsql As String
        Dim afectados As Integer
        Dim fecha1 As String = Mid(F_pedido.Text, 7, 4) + "-" + Mid(F_pedido.Text, 4, 2) + "-" + Mid(F_pedido.Text, 1, 2)
        Dim fentrega As String = Format(F_entrega.Value, "yyyy-MM-dd")
        Dim prov As Integer
        Dim usuario As String = ""
        Dim pedido As Integer

        busca_codigos_especiales(pr, "NOMBRE_PROV", Nom_prov.Text, "PROVEEDOR", prov, ok)
        Dim obj As New empresas
        cnn.ConnectionString = obj.constr
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        'strsql = "	DECLARE @id_pedido int	" & vbLf & _
        '         "	SELECT @id_pedido = SCOPE_IDENTITY()" & vbLf & _
        Try
            strsql = "INSERT INTO SERI10 (FECHA,F_ENTREGA,COMENTARIOS,MONEDA,PROVEEDOR,USUARIO) " & _
                             " VALUES ('" & fecha1 & "','" & fentrega & "','" & Comentarios.Text & "','" & moneda.Text & "','" & prov & "','" & usuario_sistema & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            comando.CommandText = "SELECT @@IDENTITY AS TEMPVALUE"
            pedido = comando.ExecuteScalar
            pedido_actual = pedido

            For i = 1 To fg.Rows.Count - 1
                strsql = "INSERT INTO SERI11 (PEDIDO,CODIGO,UNIDADES,COSTO,RECIBIDAS,COMENTARIOS,STATUS) " & _
                                       "VALUES ('" & pedido & "','" & fg(i, 1) & "','" & fg(i, 4) & "','" & fg(i, 5) & "','0',' ','A')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()
            MsgBox("Ha Creado satisfactoriamente la Orden de Compra No: " + Format(pedido, "000000"), MsgBoxStyle.Information, "Creación de Orden de Compra.")
        Catch e As SqlClient.SqlException
            Dim err As String
            Try
                If e.Number = 2627 Then
                    err = "Tipo de Material ya existe !!!"
                Else
                    err = "La actualizacion de datos falló."
                End If
                MsgBox(err, MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

  
End Class