Public Class Proyectos
    Dim h As String = "#######0.00"
    Dim h1 As String = "######0.0000"
    Dim ok As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection
    Dim dr As DataRow()
    Dim pd1 As System.Drawing.Printing.PrintDocument
    Dim usuario_sistema As String
    Dim cl As New DataTable
    Dim tp As New DataTable
    Dim pedido_actual As String
    Dim co As New DataTable
    Dim obj As empresas
    Dim uni_corte As Integer
    Private Sub Pedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler descripcion.KeyPress, AddressOf keypressed2
        AddHandler F_entrega.KeyPress, AddressOf keypressed3
        AddHandler corte.KeyPress, AddressOf keypressed2A
        AddHandler cpo.KeyPress, AddressOf keypressed2B
        AddHandler estilo.KeyPress, AddressOf keypressed2C
        AddHandler colo.KeyPress, AddressOf keypressed2D
        AddHandler unip.KeyPress, AddressOf keypressed4
        AddHandler cba.KeyPress, AddressOf keypressed6
        AddHandler cobro.KeyPress, AddressOf keypressed7
        obj = New empresas()
        usuario_sistema = obj.usuario
        F_pedido.Text = Format(Today, "dd/MM/yyyy")
        llena_combos_especiales("SERI15", cl, cliente, "NOMBRE")
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Rows.Count = 10
    End Sub

    Private Sub limpia_variables()
        proyecto.Text = ""
        descripcion.Text = "SERVICIO DE SERIGRAFIA"
        unip.Text = "0"
        val.Text = "0"
        cba.Text = "0"
        cpo.Enabled = True
        estilo.Enabled = True
        colo.Enabled = True
        Try
            cobro.SelectedIndex = 0
        Catch ex As Exception
        End Try
        '     F_entrega.Focus()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                descripcion.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descripcion.Text) <> "" Then
                corte.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed2A(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If corte.Text = "00000" Then
                cpo.Focus()
            Else
                F_entrega.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2B(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            estilo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed2C(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            colo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed2D(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                F_entrega.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(F_entrega.Text) <> "" Then
                unip.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(unip.Text) <> "" Then
                If IsNumeric(unip.Text) = True Then
                    If CDec(unip.Text) > 0 Then
                        cba.Focus()
                    End If
                End If
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            cobro.Focus()
        End If
    End Sub 'keypressed
    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            fg.Focus()
        End If
    End Sub 'keypressed
    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.CellChanged
        Dim l As Integer
        Dim vtot As Decimal = 0
        val.Text = ""
        For l = 1 To fg.Rows.Count - 1
            If fg(l, 1) <> "" And fg(l, 2) > 0 Then
                vtot = vtot + fg(l, 2)
            End If
        Next
        val.Text = vtot
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
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim seguro As MsgBoxResult
        Dim uni As Integer
        Dim pr As String = ""
        seguro = MsgBox("Antes de proceder a Grabar primero debe revisar todos los datos detallamente." + vbLf + "Una vez actualizado el Proyecto no se pueden efectuar cambios. " + vbLf + "Está Seguro de querer grabar los Datos?  ", MsgBoxStyle.YesNo, "Actualizando Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            If CDec(unip.Text) = 0 Then
                MsgBox("Debe ingresar el Número de Unidades", MsgBoxStyle.Critical, "Por favor revise !!")
                Exit Sub
            End If
            If CDec(val.Text) = 0 Then
                MsgBox("Debe ingresar el Valor del Unitario del Proyecto.", MsgBoxStyle.Critical, "Por favor revise !!")
                Exit Sub
            End If
            If corte.Text <> "00000" And CInt(corte.Text) < 6090 Then
                uni = chequea_corte(corte.Text, pr)
                uni = uni + CInt(unip.Text)
                If uni > uni_corte Then
                    MsgBox("La suma de unidades en los Proyectos de este corte superan a las unidades del Corte." + vbLf + pr, MsgBoxStyle.Critical, "Por favor Revise !!!")
                    ok = False
                Else
                    ok = True
                End If
            Else
                ok = True
            End If
            If ok Then
                graba_orden_produccion()
                setea_grid()
                limpia_variables()
            End If
        End If
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    Private Sub cobros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobro.KeyPress
        AutoCompletar(cobro, e)
    End Sub
    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub

    Private Sub chequea_proyecto(ByRef ok As Boolean)
        Dim uni As Decimal
        ok = True
        If Trim(descripcion.Text) = "" Then
            MsgBox("Debe ingresar la Descripción del Proyecto", MsgBoxStyle.Critical, "Descripción Erronea")
            ok = False
            Exit Sub
        End If
        Try
            uni = CDec(unip.Text)
        Catch ex As Exception
            uni = 0
            unip.Text = "0"
        End Try
        If uni < 1 Then
            MsgBox("Las unidades del Proyecto no pueden ser O o negativas.", MsgBoxStyle.Critical, "Por favor revise !!!!")
            ok = False
        End If
    End Sub

    '=================================================================================
    '                        GRABA PEDIDOS
    '=================================================================================
    Private Sub graba_orden_produccion()
        Dim strsql As String
        Dim afectados As Integer
        Dim fecha1 As String = Mid(F_pedido.Text, 7, 4) + "-" + Mid(F_pedido.Text, 4, 2) + "-" + Mid(F_pedido.Text, 1, 2)
        Dim fentrega As String = Format(F_entrega.Value, "yyyy-MM-dd")
        Dim nit As String = ""
        Dim usuario As String = ""
        Dim proyecto As Integer
        Dim fac As String = Mid(cobro.Text, 1, 1)

        busca_codigos_especiales(cl, "NOMBRE", cliente.Text, "NIT", nit, ok)

        cnn.ConnectionString = obj.constr
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion


        Try
            strsql = "INSERT INTO SERI20 (NIT,FECHA_P,DESCRIPCION_P,FECHA_EP,CORTE,UNIDADES,PRECIO_P,VALOR_CB,FACTURAR,ESTADO,CPO,ESTILO,COLOR) " &
                             " VALUES ('" & nit & "','" & fecha1 & "','" & descripcion.Text & "','" & fentrega & "','" & corte.Text & "','" & unip.Text & "','" & val.Text & "','" & cba.Text & "','" & fac & "','A','" & cpo.Text & "','" & estilo.Text & "','" & colo.Text & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            comando.CommandText = "SELECT @@IDENTITY AS TEMPVALUE"
            proyecto = comando.ExecuteScalar

            For i = 1 To fg.Rows.Count - 1
                If fg(i, 1) <> "" And fg(i, 2) > 0 Then
                    strsql = "INSERT INTO SERI20H (PROYECTO,HIT,VALOR) " &
                                       "VALUES ('" & proyecto & "','" & fg(i, 1) & "','" & fg(i, 2) & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

            transaccion.Commit()
            MsgBox("Ha Creado satisfactoriamente la Orden de Producción No: " + Format(proyecto, "000000"), MsgBoxStyle.Information, "Creación de Orden de Compra.")
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

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        Dim cs As New libjap.util
        Dim cnn1 As New SqlClient.SqlConnection
        Dim strsql As String = "SELECT * FROM CORTES LEFT JOIN ESTILOS ON CORTES.CLIENTE = ESTILOS.CLIENTE AND CORTES.ESTILO=ESTILOS.ESTILO WHERE  TOTAL > 0 AND O3 = 1 AND (GETDATE() - FPROD) < 365 ORDER BY CORTES.CORTE"
        If cliente.Text = "JT" Then
            cnn1 = cs.conecta_c
            llena_combos_especiales_e(strsql, co, corte, "CORTE", cnn1)
            Try
                corte.SelectedIndex = 0
            Catch ex As Exception

            End Try
        ElseIf cliente.Text = "ZUNTEX" Then
            cnn1 = cs.conecta_z
            llena_combos_especiales_e(strsql, co, corte, "CORTE", cnn1)
            Try
                corte.SelectedIndex = 0
            Catch ex As Exception

            End Try
        Else
            corte.Items.Clear()
            corte.Items.Add("00000")
            limpia_variables()

            Try
                corte.SelectedIndex = 0
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub corte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles corte.SelectedIndexChanged
        Dim dr As DataRow = Nothing
        Dim ok As Boolean
        busca_codigos_especiales_d(co, "CORTE", corte.Text, dr, ok)
        If corte.Text <> "00000" Then
            cpo.Text = dr("CPO")
            estilo.Text = dr("ESTILO")
            colo.Text = dr("COLOR")
            unip.Text = dr("TOTAL")
            uni_corte = dr("TOTAL")
            cpo.Enabled = False
            estilo.Enabled = False
            colo.Enabled = False
            cambia_color(cpo)
            cambia_color(estilo)
            cambia_color(colo)
        Else
            cpo.Text = ""
            estilo.Text = ""
            colo.Text = ""
        End If
    End Sub

    Private Sub cambia_color(ByRef objeto As TextBox)
        objeto.BackColor = Color.White
        objeto.ForeColor = Color.Black
    End Sub

    Private Function chequea_corte(ByVal corte As String, ByRef pr As String) As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim uni As Integer
        pr = ""
        llena_tablas(dt, "SELECT * FROM SERI20 WHERE CORTE = '" & corte & "'", cnn)
        For Each dr In dt.Rows
            pr = pr + CStr(dr("PROYECTO")) + " "
            uni = uni + dr("UNIDADES")
        Next
        Return uni
    End Function

End Class