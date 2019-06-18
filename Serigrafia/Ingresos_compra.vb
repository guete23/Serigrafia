Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Ingresos_compra
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fecha As System.Windows.Forms.Label
    Dim strsql As String
    Dim venta As Decimal
    Dim compra As Decimal
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents envio As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresos_compra))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.envio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pedido = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fecha = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Orden de Compra:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(384, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(432, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 46
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(384, 8)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(35, 35)
        Me.GRABA.TabIndex = 47
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'envio
        '
        Me.envio.BackColor = System.Drawing.Color.White
        Me.envio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.envio.Location = New System.Drawing.Point(196, 40)
        Me.envio.MaxLength = 12
        Me.envio.Name = "envio"
        Me.envio.Size = New System.Drawing.Size(152, 22)
        Me.envio.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.envio, "Correlativo de Entradas")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Pedido
        '
        Me.Pedido.Location = New System.Drawing.Point(196, 8)
        Me.Pedido.MaxDropDownItems = 10
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Size = New System.Drawing.Size(152, 24)
        Me.Pedido.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 24)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "No. de Envío:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(11, 101)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(961, 555)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 89
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(197, 66)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(119, 25)
        Me.fecha.TabIndex = 90
        Me.fecha.Text = " "
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ingreso_compra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 668)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.envio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GRABA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_compra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Materiales por Compra"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Pedido.KeyPress, AddressOf keypressed1
        AddHandler envio.KeyPress, AddressOf keypressed2
        fecha.Text = Format(Today, "dd/MM/yyyy")
        limpia_variables()
        llena_pedidos()
        tipo_de_cambio(Today, venta, compra)
        If venta = 0 Then
            MsgBox("Aún no se tiene el dato del Tipo de Cambio para el día de hoy.", MsgBoxStyle.Critical, "Llamar a Contabilidad")
            Close()
        End If
        Pedido.Focus()
    End Sub

    Private Sub limpia_variables()
        llena_pedidos()
        Pedido.Enabled = True
        envio.Text = ""
        envio.Enabled = False
        Button1.Visible = True
        CANCELA.Visible = False
        GRABA.Visible = False
        setea_grid()
        Pedido.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_Grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer = 1
        Dim strsql As String = "SELECT SERI01.CODIGO,DESCRIPCION,(SERI11.UNIDADES*FACTOR) AS PEDIDAS, RECIBIDAS, (SERI11.COSTO/FACTOR) AS COSTOS,MONEDA FROM SERI11 LEFT JOIN SERI01 ON SERI11.CODIGO = SERI01.CODIGO LEFT JOIN SERI10 ON SERI11.PEDIDO = SERI10.PEDIDO WHERE SERI11.PEDIDO = '" & Pedido.Text & "' AND SERI11.UNIDADES > RECIBIDAS"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(i, 1) = dr("CODIGO")
            fg(i, 2) = dr("DESCRIPCION")
            fg(i, 3) = dr("PEDIDAS")
            fg(i, 4) = dr("RECIBIDAS")
            fg(i, 5) = fg(i, 3) - fg(i, 4)
            fg(i, 6) = dr("COSTOS")
            If dr("MONEDA") = "Q" Then
                fg(i, 6) = fg(i, 6) / venta
            End If
            i = i + 1
        Next
        For i = 1 To 4
            fg.Cols(i).AllowEditing = False
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        setea_grid()
        llena_Grid()
        Pedido.Enabled = False
        envio.Enabled = True
        Button1.Visible = False
        CANCELA.Visible = True
        GRABA.Visible = True
        envio.Focus()
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Cancelar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Cancela Cambios !!!")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_antes_de_Grabar()
            llena_pedidos()
        End If
    End Sub

    Private Sub revisa_antes_de_Grabar()
        Dim bien As Boolean = True
        If Trim(envio.Text) = "" Then
            MsgBox("Aun no ha ingresado el Número del Envío !!!!", MsgBoxStyle.OkOnly, "Por favor Revise !!!")
            Exit Sub
        End If
        Revisa_detalle(bien)
        If bien Then
            actualiza_datos()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim lin As Integer = fg.RowSel
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Eliminar esta Linea?  ", MsgBoxStyle.YesNo, "Revise bien Antes de Eliminar !!!")
        If seguro = MsgBoxResult.Yes Then
            Try
                fg.Rows.Remove(lin)
            Catch
            End Try
        End If
    End Sub

    Private Sub Revisa_detalle(ByRef bien As Boolean)
        Dim i As Integer
        Dim codigo As String
        Dim c As Integer
        For i = 1 To fg.Rows.Count - 1
            codigo = fg(i, 1)
            If fg(i, 5) > 0 Then
                c = c + 1
            End If
            If fg(i, 5) > (fg(i, 3) - fg(i, 4)) Then
                MsgBox("Las unidades ingresadas, son mayores a las (Pedias - Recibidas) en el código : " + codigo, MsgBoxStyle.OkOnly, "Por favor Revise !!!")
                bien = False
                Exit Sub
            End If
        Next
        If c = 0 Then
            bien = False
            MsgBox("Aun no ha ingresado unidades para actualizar", MsgBoxStyle.OkOnly, "Por favor Revise !!!")
            Exit Sub
        End If
    End Sub

    '=============================== ACTUALIZA BASE DE DATOS ===============================
    Private Sub actualiza_datos()
        Dim i As Integer
        Dim codigo As String
        Dim unidades As Decimal
        Dim costo As Decimal
        Dim pedi As String = "ORDEN DE COMPRA: " + Pedido.Text
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim entrada As String
        Dim factura As String = ""
        'asigna_correlativo()

        Dim afectados As Integer
        Dim strSQL As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            comando.CommandText = "SELECT CORR FROM SERI99 WHERE TIPO = '1'"
            entrada = comando.ExecuteScalar
            entrada = entrada + 1


            '============== Correlativo  =======================
            strSQL = "UPDATE SERI99 SET CORR = '" & entrada & "' WHERE TIPO = '1'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            '============== Encabezado =======================
            entrada = Format(CInt(entrada), "0000000000")
            strSQL = "INSERT INTO SERI05 (T_MOVTO,DOCTO, FECHA, DESCRIPCION) " & _
                     "VALUES ( '1','" & entrada & "','" & fechas & "','" & pedi & "')"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                If fg(i, 5) > 0 Then
                    codigo = fg(i, 1)
                    unidades = fg(i, 5)
                    costo = fg(i, 6)
                    '========== Detalle ==========================
                    strSQL = "INSERT INTO SERI06 (T_MOVTO,DOCTO,CODIGO,LINEA,FECHA,PEDIDO, UNIDADES, COSTO,ENVIO,PROYECTO,FACTURA,PAGADA) " & _
                                "VALUES ( '1','" & entrada & "','" & _
                                 codigo & "','" & _
                                 i & "','" & _
                                 fechas & "','" & _
                                 Pedido.Text & "','" & _
                                 unidades & "','" & _
                                 costo & "','" & _
                                 envio.Text & "','0','" & _
                                 factura & "','N')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()

                    '========== Actualiza Maestro ===========
                    Try
                        strSQL = "UPDATE SERI01 SET COSTO = ((UNIDADES * COSTO) + (" & unidades * costo & "))/ (UNIDADES + " & unidades & "), UNIDADES = UNIDADES + " & unidades & " WHERE CODIGO = '" & codigo & "'"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()
                    Catch
                        strSQL = "UPDATE SERI01 SET COSTO = 0 , UNIDADES = UNIDADES + " & unidades & " WHERE CODIGO = '" & codigo & "'"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()
                    End Try


                    '========== Actualiza Pedidos ===========
                    strSQL = "UPDATE SERI11 SET RECIBIDAS = RECIBIDAS + " & unidades & " WHERE PEDIDO = ' " & Pedido.Text & "' AND CODIGO = '" & codigo & "'"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

            '========== Actualiza Pedidos Cerrados ===========
            strSQL = "UPDATE SERI11 SET STATUS = 'C' WHERE (UNIDADES = RECIBIDAS OR UNIDADES < RECIBIDAS)  AND STATUS = 'A'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            limpia_variables()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub llena_pedidos()
        strsql = "SELECT DISTINCT PEDIDO FROM SERI11 WHERE STATUS = 'A' "
        llena_combos(Pedido, strsql, "PEDIDO")
    End Sub

    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs)
        ' validate amounts
        If fg.Cols(e.Col).DataType Is GetType(Decimal) Then
            Try
                Dim dec As Decimal = Decimal.Parse(fg.Editor.Text())
                If dec < 0 Then
                    MessageBox.Show("Por favor ingrese un valor Positivo")
                    e.Cancel = True
                End If
                If e.Col = 7 And dec = 0 Then
                    MessageBox.Show("El costo no puede ser 0.")
                    e.Cancel = True
                End If
            Catch
                MessageBox.Show("El valor ingresado no es decimal")
                e.Cancel = True
            End Try
        End If
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Pedido.Text) <> "" Then
                Button1.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            If Trim(envio.Text) <> "" Then
                fg.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Fecha.Focus()
        End If
    End Sub 'keypressed

    Private Sub envio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles envio.Leave
        If Trim(envio.Text) = "" Then
            MsgBox("Aun no ha ingresado el Número de Envío", MsgBoxStyle.OkOnly, "Por favor Revise !!!")
            envio.Focus()
        End If
    End Sub

    Private Sub criterio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pedido.KeyPress
        AutoCompletar(Pedido, e)
    End Sub
End Class
