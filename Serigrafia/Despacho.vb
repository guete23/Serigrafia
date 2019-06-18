Public Class Despacho
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
    Dim despacho As Integer
    Dim llena_proy As String = "SELECT PROYECTO FROM SERI20 WHERE ESTADO = 'A'"
    Private Sub Pedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler proy.KeyPress, AddressOf keypressed1
        AddHandler primeras.KeyPress, AddressOf keypressed2
        AddHandler segundas.KeyPress, AddressOf keypressed3
        AddHandler entregado.KeyPress, AddressOf keypressed4
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
        Dim strsql As String = "SELECT * FROM SERI24 LEFT JOIN SERI20 ON SERI24.PROYECTO = SERI20.PROYECTO WHERE SERI24.ESTADO = 'A' "
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("DESPACHO")
            fg(l, 2) = dr("PROYECTO")
            fg(l, 3) = dr("DESCRIPCION_P")
            fg(l, 4) = dr("ENTREGADO")
            fg(l, 5) = dr("PRIMERAS")
            fg(l, 6) = dr("SEGUNDAS")
            l = l + 1
        Next
    End Sub

    Private Sub limpia_variables()
        llena_combos(proy, llena_proy, "PROYECTO")
        entregado.Text = ""
        primeras.Text = "0"
        segundas.Text = "0"
        setea_grid()
        proy.Focus()
    End Sub
    Private Sub PROY_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles proy.SelectedIndexChanged
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * , (SELECT SUM(UNIDADES) FROM SERI23 WHERE SERI20.PROYECTO = SERI23.PROYECTO) AS RECIBIDAS , (SELECT SUM(PRIMERAS) FROM SERI24 WHERE SERI20.PROYECTO = SERI24.PROYECTO) AS PRIME, (SELECT SUM(SEGUNDAS) FROM SERI24 WHERE SERI20.PROYECTO = SERI24.PROYECTO) AS SEGUN FROM SERI20 LEFT JOIN SERI15 ON SERI20.NIT = SERI15.NIT  WHERE PROYECTO = '" & proy.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            cliente.Text = dr("NOMBRE")
            descripcion.Text = dr("DESCRIPCION_P")
            Try
                reci.Text = dr("RECIBIDAS")
            Catch
            End Try
            Try
                pria.Text = dr("PRIME")
            Catch ex As Exception
                pria.Text = "0"
            End Try
            Try
                sega.Text = dr("SEGUN")
            Catch ex As Exception
                sega.Text = "0"
            End Try
            bala.Text = reci.Text - pria.Text - sega.Text
        End If
    End Sub
    Private Sub blanquea()
        reci.Text = "0"
        pria.Text = "0"
        sega.Text = "0"
        bala.Text = "0"
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(proy.Text) <> "" Then
                primeras.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim uni As Integer
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                uni = CInt(primeras.Text)
                If uni > 0 Then
                    segundas.Focus()
                End If
            Catch ex As Exception
                primeras.Text = "0"
            End Try
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim uni As Integer
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                uni = CInt(segundas.Text)
                If uni > 0 Then
                    entregado.Focus()
                End If
            Catch ex As Exception
                segundas.Text = "0"
            End Try
        End If
    End Sub 'keypressed
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(entregado.Text) <> "" Then
                G1.Focus()
            End If
        End If
    End Sub 'keypressed

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
    Private Sub imprime_despacho()
        Dim forma As New Doctos_i
        forma.tipo = "D"
        forma.docto = despacho
        forma.ShowDialog()
    End Sub

    Private Sub proy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles proy.KeyPress
        AutoCompletar(proy, e)
    End Sub


    Private Sub chequea_proyecto(ByRef ok As Boolean)
        Dim uni As Decimal
        ok = True
        If Trim(entregado.Text) = "" Then
            MsgBox("Debe ingresar el nombre de la persona que efectuó el despacho de las prendas.", MsgBoxStyle.Critical, "Receptor inválido")
            ok = False
            Exit Sub
        End If
        Try
            uni = CDec(primeras.Text)
        Catch ex As Exception
            uni = 0
            primeras.Text = "0"
        End Try
        Try
            uni = CDec(segundas.Text)
        Catch ex As Exception
            segundas.Text = "0"
        End Try
        If (primeras.Text + segundas.Text) < 1 Then
            MsgBox("Antes de Grabar debe ingresar el número de Primeras y Segundas producias.", MsgBoxStyle.Critical, "Por favor revise !!!!")
            ok = False
        End If
        uni = CInt(primeras.Text) + CInt(segundas.Text)
        If uni > CInt(bala.Text) Then
            MsgBox("No puede producir más de lo que recibió en el proyecto.", MsgBoxStyle.Critical, "Por favor revise !!!!")
            ok = False
        End If
    End Sub

    '=================================================================================
    '                        GRABA DESPACHOS
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

        Try
            strsql = "INSERT INTO SERI24 (PROYECTO,FECHA_D,PRIMERAS,SEGUNDAS,ENTREGADO,ESTADO) " & _
                             " VALUES ('" & proy.Text & "','" & fecha1 & "','" & primeras.Text & "','" & segundas.Text & "','" & entregado.Text & "','A')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()


            comando.CommandText = "SELECT @@IDENTITY AS TEMPVALUE"
            despacho = comando.ExecuteScalar

            transaccion.Commit()
            MsgBox("Ha Creado satisfactoriamente el Despacho No: " + Format(Despacho, "000000"), MsgBoxStyle.Information, "Creación de Despachos.")
            imprime_despacho()
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