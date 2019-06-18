Imports C1.Win.C1FlexGrid

Public Class Proveedor
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "000000"
    Dim ok As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents codigo As System.Windows.Forms.Label
    Dim existe As Boolean
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
    Friend WithEvents g1 As System.Windows.Forms.Button
    Friend WithEvents e1 As System.Windows.Forms.Button
    Friend WithEvents r1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Contacto As System.Windows.Forms.TextBox
    Friend WithEvents nit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.g1 = New System.Windows.Forms.Button()
        Me.e1 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nit = New System.Windows.Forms.TextBox()
        Me.Contacto = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g1
        '
        Me.g1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g1.ForeColor = System.Drawing.Color.Black
        Me.g1.Image = CType(resources.GetObject("g1.Image"), System.Drawing.Image)
        Me.g1.Location = New System.Drawing.Point(766, 8)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(50, 35)
        Me.g1.TabIndex = 8
        Me.g1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.g1, "Presione este Boton para Grabar o Actualizar los Datos del Proveedor")
        Me.g1.UseVisualStyleBackColor = False
        '
        'e1
        '
        Me.e1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1.ForeColor = System.Drawing.Color.Black
        Me.e1.Image = CType(resources.GetObject("e1.Image"), System.Drawing.Image)
        Me.e1.Location = New System.Drawing.Point(710, 8)
        Me.e1.Name = "e1"
        Me.e1.Size = New System.Drawing.Size(50, 35)
        Me.e1.TabIndex = 21
        Me.e1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.e1, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.e1.UseVisualStyleBackColor = False
        Me.e1.Visible = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(822, 7)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(50, 35)
        Me.r1.TabIndex = 19
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.r1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.nit)
        Me.GroupBox1.Controls.Add(Me.Contacto)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 210)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(432, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 24)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = " "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = " "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nit
        '
        Me.nit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nit.ForeColor = System.Drawing.Color.Black
        Me.nit.Location = New System.Drawing.Point(147, 174)
        Me.nit.MaxLength = 20
        Me.nit.Name = "nit"
        Me.nit.Size = New System.Drawing.Size(241, 22)
        Me.nit.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.nit, "Numero de días promedio que se tardan en producir - importar los Materiales ")
        '
        'Contacto
        '
        Me.Contacto.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contacto.ForeColor = System.Drawing.Color.Black
        Me.Contacto.Location = New System.Drawing.Point(149, 141)
        Me.Contacto.MaxLength = 30
        Me.Contacto.Name = "Contacto"
        Me.Contacto.Size = New System.Drawing.Size(638, 22)
        Me.Contacto.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Contacto, "Contacto")
        '
        'Telefono
        '
        Me.Telefono.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.ForeColor = System.Drawing.Color.Black
        Me.Telefono.Location = New System.Drawing.Point(147, 110)
        Me.Telefono.MaxLength = 20
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(241, 22)
        Me.Telefono.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Telefono, "Telefonos,  Fax")
        '
        'Direccion
        '
        Me.Direccion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.ForeColor = System.Drawing.Color.Black
        Me.Direccion.Location = New System.Drawing.Point(147, 54)
        Me.Direccion.MaxLength = 100
        Me.Direccion.Multiline = True
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(640, 40)
        Me.Direccion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Direccion, "Direccion")
        '
        'Nombre
        '
        Me.Nombre.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.Color.Black
        Me.Nombre.Location = New System.Drawing.Point(147, 22)
        Me.Nombre.MaxLength = 80
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(640, 22)
        Me.Nombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Nombre, "Nombre del Proveedor")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Nit:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Teléfono:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Contacto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Dirección:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 264)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(862, 424)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Doble click para eliminar la línea seleccionada.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'codigo
        '
        Me.codigo.BackColor = System.Drawing.Color.White
        Me.codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.codigo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo.ForeColor = System.Drawing.Color.Black
        Me.codigo.Location = New System.Drawing.Point(155, 14)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(108, 28)
        Me.codigo.TabIndex = 74
        Me.codigo.Text = " "
        Me.codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Proveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 696)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.e1)
        Me.Controls.Add(Me.g1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proveedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Nombre.KeyPress, AddressOf keypressed2
        AddHandler Direccion.KeyPress, AddressOf keypressed3
        AddHandler Telefono.KeyPress, AddressOf keypressed4
        AddHandler Contacto.KeyPress, AddressOf keypressed5
        AddHandler nit.KeyPress, AddressOf keypressed6
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM SERI04 ORDER BY PROVEEDOR"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("PROVEEDOR")
            fg(lineas, 2) = dr("NOMBRE_PROV")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub limpia_variables()
        codigo.Text = "0"
        Nombre.Text = ""
        Direccion.Text = ""
        Telefono.Text = ""
        Contacto.Text = ""
        nit.Text = "C/F"
        e1.Visible = False
        setea_grid()
        Nombre.Focus()
    End Sub

    '================================== HANDLERS ================================

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Nombre.Text) <> "" Then
                Direccion.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Direccion.Text) <> "" Then
                Telefono.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Telefono.Text) <> "" Then
                Contacto.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Contacto.Text) <> "" Then
                nit.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(nit.Text) <> "" Then
                g1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub chequea_encabezado(ByRef ok As Boolean)
        ok = True
        If Trim(Nombre.Text) = "" Then
            ok = False
            MsgBox("Por favor revise Nombre ", MsgBoxStyle.OkOnly, "No puede estar en blanco !!!! ")
            Exit Sub
        End If
        If Trim(Direccion.Text) = "" Then
            ok = False
            MsgBox("Por favor revise Direccion ", MsgBoxStyle.OkOnly, "No puede estar en blanco !!!! ")
            Exit Sub
        End If
        If Trim(Telefono.Text) = "" Then
            ok = False
            MsgBox("Por favor revise Telefono ", MsgBoxStyle.OkOnly, "No puede estar en blanco !!!! ")
            Exit Sub
        End If
        If Trim(Contacto.Text) = "" Then
            ok = False
            MsgBox("Por favor revise Contacto ", MsgBoxStyle.OkOnly, "No puede estar en blanco !!!! ")
            Exit Sub
        End If
        If nit.Text <> "C/F" Then
            ok = Validacion_Nit(nit.Text)
            If Not ok Then
                MsgBox("NIT incorrecto ", MsgBoxStyle.OkOnly, "Por favor revise !!!! ")
            End If
        End If
    End Sub

    Private Sub r1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub lee_registro()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM SERI04 WHERE PROVEEDOR = '" & codigo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            Nombre.Text = dr("NOMBRE_PROV")
            Direccion.Text = dr("DIRECCION")
            Telefono.Text = dr("TELEFONO")
            Contacto.Text = dr("CONTACTO")
            nit.Text = dr("NIT")
            e1.Visible = True
        Next
    End Sub

    Private Sub g1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g1.Click
        Dim ok As Boolean
        chequea_encabezado(ok)
        If ok Then
            graba_proveedor()
            limpia_variables()
        End If
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e1.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            If Int(Codigo.Text) <> 0 Then
                elimina_proveedor()
                elimina_linea()
            End If
        End If
        limpia_variables()
    End Sub
    Private Sub seleccion(ByVal fil As Integer)
        Dim jj As String
        If fil > 0 And fil < fg.Rows.Count Then
            jj = fg(fil, 1)
            codigo.Text = jj
            lee_registro()
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    Private Sub agrega_linea()
        Dim lin As Integer = fg.Rows.Count
        fg.Rows.Count = lin + 1
        llena_lineas(lin)
        fg.Sort(SortFlags.Descending, 1)
    End Sub

    Private Sub elimina_linea()
        Dim lin As Integer = fg.RowSel
        fg.Rows.Remove(lin)
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer = fg.RowSel
        llena_lineas(lin)
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        fg(lineas, 1) = Codigo.Text
        fg(lineas, 2) = Nombre.Text
        fg(lineas, 3) = Direccion.Text
        fg(lineas, 4) = Telefono.Text
        fg(lineas, 5) = Contacto.Text
        fg(lineas, 6) = nit.Text
    End Sub


    '=================================================================================
    '                        GRABA PROVEEDORES
    '=================================================================================
    Private Sub graba_proveedor()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERI04 SET NOMBRE_PROV  = '" & UCase(Nombre.Text) & "'," & _
                                      " NIT = '" & nit.Text & "'," & _
                                      " DIRECCION = '" & UCase(Direccion.Text) & "'," & _
                                      " TELEFONO = '" & UCase(Telefono.Text) & "'," & _
                                      " CONTACTO = '" & UCase(Contacto.Text) & "'" & _
                                      " WHERE PROVEEDOR = '" & CInt(codigo.Text) & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERI04 (NOMBRE_PROV,NIT,DIRECCION,TELEFONO,CONTACTO) VALUES ('" & _
                                              UCase(Nombre.Text) & "','" & _
                                              UCase(nit.Text) & "','" & _
                                              UCase(Direccion.Text) & "','" & _
                                              UCase(Telefono.Text) & "','" & _
                                              UCase(Contacto.Text) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

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
    '=================================================================================
    '                        ELIMINA PROVEEDORES
    '=================================================================================
    Private Sub elimina_proveedor()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SERI04 WHERE PROVEEDOR = '" & CInt(codigo.Text) & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub fg_Click_1(sender As System.Object, e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub


End Class
