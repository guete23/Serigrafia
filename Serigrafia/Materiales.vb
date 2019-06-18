Imports C1.Win.C1FlexGrid

Public Class Materiales
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "000000"
    Dim ok As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents correlativo As System.Windows.Forms.Label
    Friend WithEvents prov As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents medida As System.Windows.Forms.ComboBox
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Dim existe As Boolean
    Dim tp As DataTable
    Dim um As DataTable
    Friend WithEvents factor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Dim pr As DataTable
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Materiales))
        Me.g1 = New System.Windows.Forms.Button()
        Me.e1 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.factor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.prov = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.medida = New System.Windows.Forms.ComboBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.correlativo = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.factor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.prov)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.medida)
        Me.GroupBox1.Controls.Add(Me.tipo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.descripcion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 229)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'factor
        '
        Me.factor.BackColor = System.Drawing.Color.LightYellow
        Me.factor.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.factor.ForeColor = System.Drawing.Color.Black
        Me.factor.Location = New System.Drawing.Point(148, 192)
        Me.factor.MaxLength = 11
        Me.factor.Name = "factor"
        Me.factor.Size = New System.Drawing.Size(139, 26)
        Me.factor.TabIndex = 6
        Me.factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 26)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Factor conv.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'codigo
        '
        Me.codigo.BackColor = System.Drawing.Color.LightYellow
        Me.codigo.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.codigo.ForeColor = System.Drawing.Color.Black
        Me.codigo.Location = New System.Drawing.Point(148, 19)
        Me.codigo.MaxLength = 20
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(277, 26)
        Me.codigo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 26)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Código:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prov
        '
        Me.prov.BackColor = System.Drawing.Color.LightYellow
        Me.prov.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prov.FormattingEnabled = True
        Me.prov.Location = New System.Drawing.Point(148, 160)
        Me.prov.Name = "prov"
        Me.prov.Size = New System.Drawing.Size(640, 26)
        Me.prov.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 26)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Proveedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'medida
        '
        Me.medida.BackColor = System.Drawing.Color.LightYellow
        Me.medida.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medida.FormattingEnabled = True
        Me.medida.Location = New System.Drawing.Point(148, 128)
        Me.medida.Name = "medida"
        Me.medida.Size = New System.Drawing.Size(640, 26)
        Me.medida.TabIndex = 4
        '
        'tipo
        '
        Me.tipo.BackColor = System.Drawing.Color.LightYellow
        Me.tipo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.FormattingEnabled = True
        Me.tipo.Location = New System.Drawing.Point(147, 52)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(641, 26)
        Me.tipo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(456, 208)
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
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.LightYellow
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.ForeColor = System.Drawing.Color.Black
        Me.descripcion.Location = New System.Drawing.Point(148, 82)
        Me.descripcion.MaxLength = 100
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(640, 40)
        Me.descripcion.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.descripcion, "Direccion")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 26)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "U. Medida:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 26)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Descripcion:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 26)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Tipo:"
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
        Me.fg.Location = New System.Drawing.Point(8, 283)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(862, 405)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Doble click para eliminar la línea seleccionada.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Correlativo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'correlativo
        '
        Me.correlativo.BackColor = System.Drawing.Color.LightYellow
        Me.correlativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.correlativo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correlativo.ForeColor = System.Drawing.Color.Black
        Me.correlativo.Location = New System.Drawing.Point(155, 7)
        Me.correlativo.Name = "correlativo"
        Me.correlativo.Size = New System.Drawing.Size(108, 28)
        Me.correlativo.TabIndex = 74
        Me.correlativo.Text = " "
        Me.correlativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Materiales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 696)
        Me.Controls.Add(Me.correlativo)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.e1)
        Me.Controls.Add(Me.g1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Materiales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Materiales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler codigo.KeyPress, AddressOf keypressed1
        AddHandler tipo.KeyPress, AddressOf keypressed2
        AddHandler descripcion.KeyPress, AddressOf keypressed3
        AddHandler medida.KeyPress, AddressOf keypressed4
        AddHandler prov.KeyPress, AddressOf keypressed5
        AddHandler factor.KeyPress, AddressOf keypressed6
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
        Dim strSQL As String = "SELECT * FROM SERI01 ORDER BY CODIGO"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CORRELATIVO")
            fg(lineas, 2) = dr("DESCRIPCION")
            lineas = lineas + 1
        Next
        llena_combos_especiales("SERI02", tp, tipo, "DESCRIPCION_MAT")
        llena_combos_especiales("SERI03", um, medida, "DESCRIPCION_MEDIDA")
        llena_combos_especiales("SERI04", pr, prov, "NOMBRE_PROV")
    End Sub

    Private Sub limpia_variables()
        correlativo.Text = "0"
        descripcion.Text = ""
        codigo.Text = ""
        factor.Text = "1.00"
        codigo.Enabled = True
        e1.Visible = False
        setea_grid()
        tipo.Focus()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(codigo.Text) <> "" Then
                tipo.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(tipo.Text) <> "" Then
                descripcion.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descripcion.Text) <> "" Then
                medida.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(medida.Text) <> "" Then
                prov.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Proveedor.Text) <> "" Then
                factor.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(factor.Text) <> "" Then
                g1.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub chequea_encabezado(ByRef ok As Boolean)
        Dim fact As Decimal
        ok = True
        If Trim(codigo.Text) = "" Then
            ok = False
            MsgBox("Por favor revise la Código del Material", MsgBoxStyle.OkOnly, "No puede estar en blanco !!!! ")
            Exit Sub
        End If
        If Trim(descripcion.Text) = "" Then
            ok = False
            MsgBox("Por favor revise la Descripción del Material", MsgBoxStyle.OkOnly, "No puede estar en blanco !!!! ")
            Exit Sub
        End If
        Try
            fact = CDec(factor.Text)
        Catch ex As Exception
            fact = 0
        End Try
        If fact = 0 Then
            ok = False
            MsgBox("El factor no puede ser 0", MsgBoxStyle.OkOnly, "Por favor Revisar !!!! ")
            Exit Sub
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
        Dim strSQL As String = "SELECT * FROM SERI01 LEFT JOIN SERI02 ON SERI01.TIPO = SERI02.TIPO LEFT JOIN SERI03 ON SERI01.U_MEDIDA = SERI03.U_MEDIDA LEFT JOIN SERI04 ON SERI01.PROVEEDOR = SERI04.PROVEEDOR WHERE CORRELATIVO = '" & correlativo.Text & "' "
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            codigo.Text = dr("CODIGO")
            tipo.SelectedIndex = tipo.Items.IndexOf(dr("DESCRIPCION_MAT"))
            descripcion.Text = dr("DESCRIPCION")
            medida.SelectedIndex = medida.Items.IndexOf(dr("DESCRIPCION_MEDIDA"))
            prov.SelectedIndex = prov.Items.IndexOf(dr("NOMBRE_PROV"))
            factor.Text = dr("FACTOR")
            codigo.Enabled = False
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
            If Int(correlativo.Text) <> 0 Then
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
            correlativo.Text = jj
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
        fg(lineas, 1) = correlativo.Text
        fg(lineas, 2) = descripcion.Text
        fg(lineas, 3) = descripcion.Text
    End Sub

    Private Sub tipo_c(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tipo.KeyPress
        AutoCompletar(tipo, e)
    End Sub
    Private Sub medida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles medida.KeyPress
        AutoCompletar(medida, e)
    End Sub
    Private Sub prov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prov.KeyPress
        AutoCompletar(prov, e)
    End Sub


    '=================================================================================
    '                        GRABA PROVEEDORES
    '=================================================================================
    Private Sub graba_proveedor()
        Dim strsql As String
        Dim afectados As Integer
        Dim tip As String = ""
        Dim ume As String = ""
        Dim pro As String = ""

        busca_codigos_especiales(tp, "DESCRIPCION_MAT", tipo.Text, "TIPO", tip, ok)
        busca_codigos_especiales(um, "DESCRIPCION_MEDIDA", medida.Text, "U_MEDIDA", ume, ok)
        busca_codigos_especiales(pr, "NOMBRE_PROV", prov.Text, "PROVEEDOR", pro, ok)

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERI01 SET TIPO  = '" & tip & "'," & _
                                      " DESCRIPCION = '" & UCase(descripcion.Text) & "'," & _
                                      " U_MEDIDA = '" & ume & "'," & _
                                      " PROVEEDOR = '" & pro & "'," & _
                                      " CODIGO = '" & codigo.Text & "', " & _
                                      " FACTOR = '" & factor.Text & "' " & _
                                      " WHERE CORRELATIVO = '" & CInt(correlativo.Text) & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERI01 (CODIGO,TIPO,DESCRIPCION,U_MEDIDA,PROVEEDOR,FACTOR,UNIDADES,COSTO) VALUES ('" & _
                                              UCase(codigo.Text) & "','" & _
                                              tip & "','" & _
                                              UCase(descripcion.Text) & "','" & _
                                              ume & "','" & _
                                              pro & "','" & _
                                              factor.Text & "','0','0')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As SqlClient.SqlException
            Dim err As String
            Try
                If e.Number = 2627 Then
                    err = "Descripcion del  Material ya existe !!!"
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
            strsql = "DELETE SERI01 WHERE CODIGO = '" & CInt(correlativo.Text) & "'"
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
