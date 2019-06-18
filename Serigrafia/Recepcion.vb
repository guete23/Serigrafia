Public Class Recepcion
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
    Dim recepcion As Integer
    Dim llena_proy As String = "SELECT PROYECTO FROM SERI20 WHERE ESTADO = 'A'"
    Private Sub Pedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler proy.KeyPress, AddressOf keypressed1
        AddHandler unidades.KeyPress, AddressOf keypressed2
        AddHandler recibido.KeyPress, AddressOf keypressed3
        Dim obj As empresas
        obj = New empresas()
        usuario_sistema = obj.usuario
        F_pedido.Text = Format(Today, "dd/MM/yyyy")
        limpia_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM SERI23 LEFT JOIN SERI20 ON SERI23.PROYECTO = SERI20.PROYECTO WHERE SERI23.ESTADO = 'A' "
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("RECEP")
            fg(l, 2) = dr("PROYECTO")
            fg(l, 3) = dr("DESCRIPCION_P")
            fg(l, 4) = dr("RECIBIDO")
            fg(l, 5) = dr("UNIDADES")
            l = l + 1
        Next
    End Sub

    Private Sub limpia_variables()
        llena_combos(proy, llena_proy, "PROYECTO")
        recibido.Text = ""
        unidades.Text = "0"
        setea_grid()
        proy.Focus()
    End Sub
    Private Sub cobro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles proy.SelectedIndexChanged
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM SERI20 LEFT JOIN SERI15 ON SERI20.NIT = SERI15.NIT WHERE PROYECTO = '" & proy.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            cliente.Text = dr("NOMBRE")
            descripcion.Text = dr("DESCRIPCION_P")
        End If
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(proy.Text) <> "" Then
                unidades.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim uni As Integer
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                uni = CInt(unidades.Text)
                If uni > 0 Then
                    recibido.Focus()
                End If
            Catch ex As Exception
                unidades.Text = "0"
            End Try
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(recibido.Text) <> "" Then
                g1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub chequea_datos(ByRef ok As Boolean)
        ok = True
        If Trim(unidades.Text) = "" Then
            ok = False
        End If
        If IsNumeric(unidades.Text) = True Then
            If CDec(unidades.Text) > 0 Then
                unidades.Text = Format(CDec(unidades.Text), h1)
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean
        chequea_proyecto(ok)
        If ok Then
            seguro = MsgBox("Antes de proceder a Grabar primero debe revisar todos los datos detallamente." + vbLf + "Una vez actualizada la Recepción no se pueden efectuar cambios. " + vbLf + "Está Seguro de querer grabar los Datos?  ", MsgBoxStyle.YesNo, "Actualizando Datos !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_rececpciones()
                setea_grid()
                limpia_variables()
            End If
        End If

    End Sub
    Private Sub imprime_recepcion()
        Dim forma As New Doctos_i
        forma.tipo = "R"
        forma.docto = recepcion
        forma.ShowDialog()
    End Sub

    Private Sub proy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles proy.KeyPress
        AutoCompletar(proy, e)
    End Sub


    Private Sub chequea_proyecto(ByRef ok As Boolean)
        Dim uni As Decimal
        ok = True
        If Trim(recibido.Text) = "" Then
            MsgBox("Debe ingresar el nombre de la persona que efectuó la recepción de las prendas.", MsgBoxStyle.Critical, "Receptor inválido")
            ok = False
            Exit Sub
        End If
        Try
            uni = CDec(unidades.Text)
        Catch ex As Exception
            uni = 0
            unidades.Text = "0"
        End Try
        If uni < 0.0001 Then
            MsgBox("Las unidades del Proyecto no pueden ser O o negativas.", MsgBoxStyle.Critical, "Por favor revise !!!!")
            ok = False
        End If
    End Sub

    '=================================================================================
    '                        GRABA RECEPCIONES
    '=================================================================================
    Private Sub graba_rececpciones()
        Dim strsql As String
        Dim afectados As Integer
        Dim fecha1 As String = Mid(F_pedido.Text, 7, 4) + "-" + Mid(F_pedido.Text, 4, 2) + "-" + Mid(F_pedido.Text, 1, 2)

        Dim usuario As String = ""

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
            strsql = "INSERT INTO SERI23 (PROYECTO,FECHA_R,UNIDADES,RECIBIDO,ESTADO) " & _
                             " VALUES ('" & proy.Text & "','" & fecha1 & "','" & unidades.Text & "','" & recibido.Text & "','A')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()


            comando.CommandText = "SELECT @@IDENTITY AS TEMPVALUE"
            recepcion = comando.ExecuteScalar

            transaccion.Commit()
            MsgBox("Ha Creado satisfactoriamente la Recepción No: " + Format(recepcion, "000000"), MsgBoxStyle.Information, "Creación de Recepción de Mercadería.")
            imprime_recepcion()

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