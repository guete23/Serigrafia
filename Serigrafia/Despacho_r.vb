Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing

Public Class Despacho_r
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strsql As String = ""
    Private WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Dim l As Integer = 1



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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Despacho_r))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(6, 12)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 24
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 679)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 22
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.AutomaticDelay = 5000
        Me.C1SuperTooltip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.C1SuperTooltip1.BorderColor = System.Drawing.SystemColors.Desktop
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1SuperTooltip1.InitialDelay = 500
        Me.C1SuperTooltip1.IsBalloon = True
        Me.C1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.C1SuperTooltip1.RoundedCorners = True
        '
        '_imgList
        '
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        Me._imgList.Images.SetKeyName(0, "preview-icon.gif")
        '
        'Despacho_r
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Despacho_r"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Despacho de Prendas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub PAGOSP10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        llena_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
        fg.Cols(13).DataType = GetType(Image)
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim filter As New ConditionFilter
        Dim filter1 As New ConditionFilter
        strsql = "SELECT * FROM SERI24 LEFT JOIN SERI20 ON SERI24.PROYECTO = SERI20.PROYECTO LEFT JOIN SERI15 ON SERI20.NIT = SERI15.NIT WHERE SERI24.ESTADO <> 'F'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("DESPACHO")
            fg(l, 2) = dr("FECHA_D")
            fg(l, 3) = dr("PROYECTO")
            fg(l, 4) = dr("NOMBRE")
            fg(l, 5) = dr("CORTE")
            fg(l, 6) = dr("CPO")
            fg(l, 7) = dr("ESTILO")
            fg(l, 8) = dr("COLOR")
            fg(l, 9) = dr("PRIMERAS")
            fg(l, 10) = dr("SEGUNDAS")
            fg(l, 11) = fg(l, 9) + fg(l, 10)
            fg(l, 12) = dr("ENTREGADO")
            fg(l, 13) = _imgList.Images(0)
            l = l + 1
        Next dr
        subtotales()
    End Sub
    Private Sub subtotales()
        Dim i As Integer
        Try
            fg.Subtotal(AggregateEnum.Clear)
            For i = 6 To 8
                fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, i, "Gran Total -->")
            Next i
        Catch
        End Try
    End Sub
    Private Sub fg_afterfilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub


    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        If fg.ColSel = 13 Then
            Dim forma As New Doctos_i
            forma.Size = Me.Size
            forma.tipo = "D"
            forma.docto = fg(fg.RowSel, 1)
            forma.ShowDialog()
        End If
    End Sub
End Class
