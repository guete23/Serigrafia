Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing

Public Class Tablas_c
    Inherits System.Windows.Forms.Form
    Dim fila As Integer
    Dim codigo As String
    Dim lineas As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Dim dr As DataRow
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
    Friend WithEvents tc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tablas_c))
        Me.tc = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc
        '
        Me.tc.Controls.Add(Me.TabPage1)
        Me.tc.Controls.Add(Me.TabPage2)
        Me.tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.Location = New System.Drawing.Point(0, 0)
        Me.tc.Name = "tc"
        Me.tc.SelectedIndex = 0
        Me.tc.ShowToolTips = True
        Me.tc.Size = New System.Drawing.Size(889, 588)
        Me.tc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.fg)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(881, 559)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tipos Materiales"
        Me.ToolTip1.SetToolTip(Me.TabPage1, "Tipos de Materiales")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(0, 46)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(878, 497)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Doble click para eliminar la línea seleccionada.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.jg)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(881, 559)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Unidad Medida"
        '
        'jg
        '
        Me.jg.AllowEditing = False
        Me.jg.AllowFiltering = True
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.jg.Location = New System.Drawing.Point(4, 50)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 17
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(867, 506)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.jg, "Presione Doble click para eliminar la línea seleccionada.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(783, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 40)
        Me.Button2.TabIndex = 46
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(794, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 73
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tablas_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 589)
        Me.Controls.Add(Me.tc)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tablas_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Tablas del Sistema"
        Me.tc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tablas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_fg()
        setea_jg()
    End Sub

    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc.Click
        Select Case tc.SelectedIndex
            Case 0
                setea_fg()
            Case 1
                setea_jg()
        End Select
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_tipo_material()
    End Sub

    Private Sub llena_tipo_material()
        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM SERI02 ORDER BY TIPO"
        llena_tablas(dt, strSQL, cnn)
        lineas = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("TIPO")
            fg(lineas, 2) = dr("DESCRIPCION_MAT")
            lineas = lineas + 1
        Next
    End Sub

    '=================================================================================
    '
    '============================ UNIDAD DE MEDIDA ===================================
    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
        llena_unidad_medida()
    End Sub

    Private Sub llena_unidad_medida()
        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM SERI03 ORDER BY U_MEDIDA"
        llena_tablas(dt, strSQL, cnn)
        lineas = 1
        jg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            jg(lineas, 1) = dr("U_MEDIDA")
            jg(lineas, 2) = dr("DESCRIPCION_MEDIDA")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PRINT_FG()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        mal = obj.nombre + "  Listado de Tipos de Material"
        fecha = Format(Today, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Serigrafia", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + "  al  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub Print_jg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        mal = obj.nombre + "  Listado de Unidades de Media"
        fecha = Format(Today, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        jg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        jg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        jg.PrintGrid("Serigrafia", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + "  al  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Print_jg()
    End Sub
End Class
