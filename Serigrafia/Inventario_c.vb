Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing

Public Class Inventario_c
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strsql As String = ""
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents criterio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.ComboBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Dim l As Integer = 1
    Dim op As String = "T_MOVTO|SERI06.CODIGO|NOMBRE|FECHA|ENVIO|PROYECTO|"
    Dim o() As String = Split(op, "|")


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_c))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.criterio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.ComboBox()
        Me.sigue = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
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
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(6, 44)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 24
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 647)
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
        Me.C1SuperTooltip1.RoundedCorners = True
        '
        'criterio
        '
        Me.criterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.criterio.FormattingEnabled = True
        Me.criterio.Items.AddRange(New Object() {"TIPO MOVTO", "CODIGO", "FECHA", "PROYECTO", "ENVIO"})
        Me.criterio.Location = New System.Drawing.Point(95, 8)
        Me.criterio.Name = "criterio"
        Me.criterio.Size = New System.Drawing.Size(181, 28)
        Me.criterio.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 44)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Criterio:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.FormattingEnabled = True
        Me.nombre.Items.AddRange(New Object() {"FACTURA", "FECHA", "EMBARQUE", "CPO", "ESTILO", "COLOR"})
        Me.nombre.Location = New System.Drawing.Point(296, 8)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(379, 28)
        Me.nombre.TabIndex = 118
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(704, 3)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 119
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(770, 3)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 120
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        '_imgList
        '
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        Me._imgList.Images.SetKeyName(0, "preview-icon.gif")
        '
        'Inventario_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.criterio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Datos del Inventario"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub PAGOSP10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        criterio.SelectedIndex = 0
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim filter As New ConditionFilter
        Dim filter1 As New ConditionFilter
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("DESCRIPCION_M")
            fg(l, 2) = dr("FECHA")
            fg(l, 3) = dr("DOCTO")
            fg(l, 4) = dr("CODIGO")
            fg(l, 5) = dr("DESCRIPCION")
            fg(l, 6) = dr("UNIDADES")
            fg(l, 7) = dr("COSTO")
            fg(l, 8) = fg(l, 6) * fg(l, 7)
            fg(l, 9) = dr("ENVIO")
            fg(l, 10) = dr("PROYECTO")
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

    Private Sub criterio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles criterio.SelectedIndexChanged
        Dim crit As String = criterio.Text
        nombre.Items.Clear()
        Select Case criterio.SelectedIndex
            Case 0
                strsql = "SELECT DESCRIPCION_M FROM SERI98"
            Case 1
                strsql = "SELECT DISTINCT CODIGO FROM SERI06 ORDER BY CODIGO"
            Case 2
                strsql = "SELECT DISTINCT CONVERT(VARCHAR(7), FECHA, 120) AS FECHA FROM SERI06 "
            Case 3
                strsql = "SELECT DISTINCT PROYECTO FROM SERI06 ORDER BY PROYECTO "
            Case 4
                strsql = "SELECT DISTINCT ENVIO FROM SERI06 ORDER BY ENVIO "
        End Select
        llena_combos(nombre, strsql, "0")
    End Sub

    Private Sub criterio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles criterio.KeyPress
        AutoCompletar(criterio, e)
    End Sub

    Private Sub nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
        AutoCompletar(nombre, e)
    End Sub

    Private Sub sigue_Click_1(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        sigue.Visible = False
        R1.Visible = True
        criterio.Enabled = False
        nombre.Enabled = False
        procesa()
    End Sub

    Private Sub procesa()
        Dim busca As String = o(criterio.SelectedIndex) & " =  '" & nombre.Text & "'"
        If criterio.SelectedIndex = 0 Then
            busca = "SERI06.T_MOVTO = '" & nombre.SelectedIndex + 1 & "'"
        End If
        If criterio.SelectedIndex = 2 Then
            busca = "YEAR(FECHA) = '" & Mid(nombre.Text, 1, 4) & "' AND MONTH(FECHA) = '" & Mid(nombre.Text, 6) & "'"
        End If
        strsql = "SELECT * FROM SERI06 LEFT JOIN SERI01 ON SERI06.CODIGO = SERI01.CODIGO LEFT JOIN SERI98 ON SERI06.T_MOVTO = SERI98.T_MOVTO WHERE " & busca
        llena_grid()
    End Sub

    Private Sub R1_Click(sender As System.Object, e As System.EventArgs) Handles R1.Click
        setea_grid()
        R1.Visible = False
        sigue.Visible = True
        criterio.Enabled = True
        nombre.Enabled = True
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        If fg.ColSel = 8 Then
            Dim forma As New Doctos_i
            forma.tipo = "R"
            forma.docto = fg(fg.RowSel, 1)
            forma.ShowDialog()
        End If
    End Sub

End Class
