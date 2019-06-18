Imports C1.Win.C1FlexGrid

Public Class Salidas_p
    Inherits System.Windows.Forms.Form
    Dim lineas As Integer
    Dim actual As Integer
    Dim tipo_movto As Integer = 1
    Dim Bien As Boolean
    Dim choice As String
    Dim H As String = "##,###,##0.00"
    Dim existe As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim co As New DataTable()
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Dim tp As New DataTable
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents tipo As System.Windows.Forms.Label
    Dim h1 As String = "######0.0000"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents desc_material As System.Windows.Forms.Label
    Friend WithEvents unidades As System.Windows.Forms.TextBox
    Friend WithEvents borra As System.Windows.Forms.Button
    Friend WithEvents But_Agrega As System.Windows.Forms.Button
    Friend WithEvents But_graba As System.Windows.Forms.Button
    Friend WithEvents cod As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salidas_p))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.proyecto = New System.Windows.Forms.ComboBox()
        Me.But_Agrega = New System.Windows.Forms.Button()
        Me.borra = New System.Windows.Forms.Button()
        Me.unidades = New System.Windows.Forms.TextBox()
        Me.desc_material = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cod = New System.Windows.Forms.ComboBox()
        Me.But_graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Salida:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha del Movimiento:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.White
        Me.descripcion.Location = New System.Drawing.Point(176, 69)
        Me.descripcion.MaxLength = 50
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(520, 22)
        Me.descripcion.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.proyecto)
        Me.GroupBox1.Controls.Add(Me.But_Agrega)
        Me.GroupBox1.Controls.Add(Me.borra)
        Me.GroupBox1.Controls.Add(Me.unidades)
        Me.GroupBox1.Controls.Add(Me.desc_material)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cod)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 119)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Proyecto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'proyecto
        '
        Me.proyecto.BackColor = System.Drawing.Color.White
        Me.proyecto.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.proyecto.ItemHeight = 16
        Me.proyecto.Items.AddRange(New Object() {"00000"})
        Me.proyecto.Location = New System.Drawing.Point(168, 21)
        Me.proyecto.MaxDropDownItems = 15
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Size = New System.Drawing.Size(144, 24)
        Me.proyecto.TabIndex = 25
        '
        'But_Agrega
        '
        Me.But_Agrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_Agrega.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Agrega.ForeColor = System.Drawing.Color.Black
        Me.But_Agrega.Image = CType(resources.GetObject("But_Agrega.Image"), System.Drawing.Image)
        Me.But_Agrega.Location = New System.Drawing.Point(848, 23)
        Me.But_Agrega.Name = "But_Agrega"
        Me.But_Agrega.Size = New System.Drawing.Size(60, 40)
        Me.But_Agrega.TabIndex = 24
        Me.But_Agrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_Agrega.UseVisualStyleBackColor = False
        '
        'borra
        '
        Me.borra.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.borra.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borra.ForeColor = System.Drawing.Color.Black
        Me.borra.Image = CType(resources.GetObject("borra.Image"), System.Drawing.Image)
        Me.borra.Location = New System.Drawing.Point(782, 23)
        Me.borra.Name = "borra"
        Me.borra.Size = New System.Drawing.Size(60, 40)
        Me.borra.TabIndex = 23
        Me.borra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.borra.UseVisualStyleBackColor = False
        Me.borra.Visible = False
        '
        'unidades
        '
        Me.unidades.BackColor = System.Drawing.Color.White
        Me.unidades.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.unidades.Location = New System.Drawing.Point(168, 85)
        Me.unidades.MaxLength = 12
        Me.unidades.Name = "unidades"
        Me.unidades.Size = New System.Drawing.Size(104, 22)
        Me.unidades.TabIndex = 5
        Me.unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'desc_material
        '
        Me.desc_material.BackColor = System.Drawing.Color.White
        Me.desc_material.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desc_material.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_material.Location = New System.Drawing.Point(318, 53)
        Me.desc_material.Name = "desc_material"
        Me.desc_material.Size = New System.Drawing.Size(424, 24)
        Me.desc_material.TabIndex = 5
        Me.desc_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Unidades:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Codigo del Material:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cod
        '
        Me.cod.BackColor = System.Drawing.Color.White
        Me.cod.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cod.Location = New System.Drawing.Point(168, 53)
        Me.cod.MaxDropDownItems = 15
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(144, 24)
        Me.cod.TabIndex = 4
        '
        'But_graba
        '
        Me.But_graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_graba.ForeColor = System.Drawing.Color.Black
        Me.But_graba.Image = CType(resources.GetObject("But_graba.Image"), System.Drawing.Image)
        Me.But_graba.Location = New System.Drawing.Point(856, 16)
        Me.But_graba.Name = "But_graba"
        Me.But_graba.Size = New System.Drawing.Size(60, 40)
        Me.But_graba.TabIndex = 24
        Me.But_graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 233)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(920, 363)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(176, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 22)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = " "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tipo
        '
        Me.tipo.BackColor = System.Drawing.Color.White
        Me.tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tipo.Location = New System.Drawing.Point(176, 9)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(194, 22)
        Me.tipo.TabIndex = 91
        Me.tipo.Text = " Salida por Producción"
        Me.tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Salidas_p
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 608)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.But_graba)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Salidas_p"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas por Producción"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler descripcion.KeyPress, AddressOf keypressed2
        AddHandler cod.KeyPress, AddressOf keypressed3
        AddHandler unidades.KeyPress, AddressOf keypressed4
        llena_combos_especiales("SERI01", tp, cod, "CODIGO")
        Label8.Text = Format(Today, "dd/MM/yyyy")
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        descripcion.Text = ""
        unidades.Text = ""
        borra.Visible = False
        'llena_combos(proyecto, "SELECT PROYECTO FROM SERI20 WHERE ESTADO = 'A'", "PROYECTO")
        proyecto.SelectedIndex = 0
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            descripcion.Focus()
        End If
    End Sub 'keypressed


    Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descripcion.Text) <> "" Then
                tipo.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed2a(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(tipo.Text) <> "" Then
                cod.Focus()
            End If
        End If
    End Sub 'keypressed
    Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cod.Text) <> "" Then
                unidades.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(unidades.Text) <> "" Then
                If IsNumeric(unidades.Text) Then
                    But_Agrega.Focus()
                Else
                    MsgBox("Por favor Ingrese el numero de Unidades ", MsgBoxStyle.OkOnly, "Dato no valido !!!")
                End If
            End If
        End If
    End Sub 'keypressed

    Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            But_Agrega.Focus()
        End If
    End Sub 'keypressed

    Private Sub But_Agrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Agrega.Click
        Dim ok As Boolean
        Dim l As Integer
        busca_linea(Trim(cod.Text), l)
        chequea_datos(ok)
        If ok Then
            If l = -1 Then
                agrega_linea()
            Else
                cambia_linea()
            End If
        End If
        unidades.Text = ""
        cod.Focus()
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
    End Sub

    Private Sub busca_linea(ByVal busca As String, ByRef l As Integer)
        busca = Trim(cod.Text)
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
        fg(l, 1) = cod.Text
        fg(l, 2) = Desc_Material.Text
        fg(l, 3) = unidades.Text
    End Sub

    Private Sub But_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borra.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_linea()
            borra.Visible = False
        End If
    End Sub

    Private Sub elimina_linea()
        Dim l As Integer
        busca_linea(Trim(cod.Text), l)
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
            cod.SelectedIndex = cod.Items.IndexOf(Trim(fg(l, 1)))
            unidades.Text = Format(fg(l, 3), h1)
            borra.Visible = True
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


    '=====================================================================================
    '                                  DETALLE
    '=====================================================================================
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
    End Sub


    Private Sub But_graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_graba.Click
        If fg.Rows.Count = 1 Then
            MsgBox("Aun no ha Ingresado Materiales", MsgBoxStyle.Critical, "No se puede actualizar")
            Exit Sub
        End If
        If descripcion.Text = "" Then
            descripcion.Text = "S/D"
        End If
        actualiza_datos()
    End Sub
    '=============================== ACTUALIZA BASE DE DATOS ===============================
    Private Sub actualiza_datos()
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Antes de proceder a Grabar primero debe revisar todos los datos detallamente." + vbLf + "Está Seguro de querer grabar los Datos?  ", MsgBoxStyle.YesNo, "Actualizando Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_registros()
            limpia_variables()
            setea_grid()
        End If

    End Sub


    Private Sub cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cod.KeyPress
        AutoCompletar(cod, e)
    End Sub
    ' ==================================================================================================
    '                                      ACTUALIZA BASE DE DATOS                                    ==
    ' ==================================================================================================
    Private Sub graba_registros()
        Dim i As Integer
        Dim codigo As String
        Dim unidades As Decimal
        Dim costo As Decimal
        Dim pedi As String = "00000"
        Dim fechas As String = Format(Today, "yyyy-MM-dd")
        Dim salida As String
        Dim envio As String = "00000"
        Dim factura As String = ""
        Dim tmov As String = 4
        Dim empre As New empresas
        cnn.ConnectionString = empre.constr

        Dim afectados As Integer
        Dim strSQL As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try


            comando.CommandText = "SELECT CORR FROM SERI99 WHERE TIPO = '" & tmov & "'"
            salida = comando.ExecuteScalar
            salida = salida + 1


            '============== Correlativo  =======================
            strSQL = "UPDATE SERI99 SET CORR = '" & salida & "' WHERE TIPO = '" & tmov & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            '============== Encabezado =======================
            salida = Format(CInt(salida), "0000000000")
            strSQL = "INSERT INTO SERI05 (T_MOVTO,DOCTO, FECHA, DESCRIPCION) " & _
                     "VALUES ( '" & tmov & "','" & salida & "','" & fechas & "','" & pedi & "')"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                If fg(i, 3) > 0 Then
                    codigo = fg(i, 1)
                    unidades = fg(i, 3)

                    comando.CommandText = "SELECT COSTO FROM SERI01 WHERE CODIGO = '" & fg(i, 1) & "'"
                    costo = comando.ExecuteScalar

                    '========== Detalle ==========================
                    strSQL = "INSERT INTO SERI06 (T_MOVTO,DOCTO,CODIGO,LINEA,FECHA,PEDIDO, UNIDADES, COSTO,ENVIO,PROYECTO,FACTURA,PAGADA) " & _
                                "VALUES ( '4','" & salida & "','" & _
                                 codigo & "','" & _
                                 i & "','" & _
                                 fechas & "','" & _
                                 pedi & "','" & _
                                 unidades & "','" & _
                                 costo & "','" & _
                                 envio & "','" & _
                                 proyecto.Text & "','" & _
                                 factura & "','N')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()

                    '========== Actualiza Maestro ===========
                    strSQL = "UPDATE SERI01 SET UNIDADES = UNIDADES - " & unidades & " WHERE CODIGO = '" & codigo & "'"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

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

    Private Sub cod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cod.SelectedIndexChanged
        Dim ok As Boolean
        busca_codigos_especiales(tp, "CODIGO", cod.Text, "DESCRIPCION", desc_material.Text, ok)
    End Sub
    Private Sub Codigo_Salida(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cod.Leave
        Dim l As Integer = fg.FindRow(cod.Text, 1, 1, True)
        If l > 0 Then
            selecciona_linea(l)
        End If
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        Dim l As Integer = fg.FindRow(fg(fg.RowSel, 1), 1, 1, True)
        If l > 0 Then
            selecciona_linea(l)
            borra.Visible = True
        End If
    End Sub

    Private Sub descripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles descripcion.Leave
        descripcion.Text = UCase(descripcion.Text)
    End Sub
End Class

