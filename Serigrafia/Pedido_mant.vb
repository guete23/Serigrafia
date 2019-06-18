Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing

Public Class Pedido_mant
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strsql As String = ""
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents orden As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedido_mant))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.orden = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(5, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 24
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1181, 647)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 22
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'orden
        '
        Me.orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orden.FormattingEnabled = True
        Me.orden.Items.AddRange(New Object() {"FACTURA_NO", "FECHA", "PROVEEDOR", "TIPO"})
        Me.orden.Location = New System.Drawing.Point(125, 8)
        Me.orden.Name = "orden"
        Me.orden.Size = New System.Drawing.Size(162, 28)
        Me.orden.TabIndex = 116
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
        Me.Label1.Text = "Orden No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_imgList
        '
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        Me._imgList.Images.SetKeyName(0, "preview-icon.gif")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1032, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 121
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Pedido_mant
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 709)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.orden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pedido_mant"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Ordenes de Compra"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Pedido_mant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_ordenes()
    End Sub

    Private Sub llena_ordenes()
        strsql = "SELECT DISTINCT PEDIDO FROM SERI11 WHERE STATUS = 'A' ORDER BY PEDIDO DESC"
        llena_combos(orden, strsql, "PEDIDO")
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim filter As New ConditionFilter
        Dim filter1 As New ConditionFilter
        strsql = "SELECT * FROM SERI11 LEFT JOIN SERI10 ON SERI11.PEDIDO = SERI10.PEDIDO LEFT JOIN SERI01 ON SERI11.CODIGO = SERI01.CODIGO LEFT JOIN SERI04 ON SERI10.PROVEEDOR = SERI04.PROVEEDOR WHERE SERI11.PEDIDO = '" & orden.Text & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CODIGO")
            fg(l, 2) = dr("DESCRIPCION")
            fg(l, 3) = dr("NOMBRE_PROV")
            fg(l, 4) = dr("FECHA")
            fg(l, 5) = dr("UNIDADES")
            fg(l, 6) = dr("RECIBIDAS")
            fg(l, 7) = dr("COSTO")
            fg(l, 8) = fg(l, 5) * fg(l, 6)
            fg(l, 9) = dr("MONEDA")
            fg(l, 10) = dr("STATUS")
            l = l + 1
        Next dr
    End Sub

    Private Sub criterio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles orden.KeyPress
        AutoCompletar(orden, e)
    End Sub

    Private Sub orden_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles orden.SelectedIndexChanged
        setea_grid()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim seguro As MsgBoxResult
        Dim l As Integer = fg.Rows.Count - 1
        If l > 0 Then
            seguro = MsgBox("Antes de proceder a Grabar primero debe revisar todos los datos detallamente." + vbLf + "Una vez actualizado no se pueden hacer cambios a la Orden de Compra." + vbLf + "Está Seguro de querer grabar los Datos?  ", MsgBoxStyle.YesNo, "Actualizando Datos !!!")
            If seguro = MsgBoxResult.Yes Then
                actualiza_orden()
                llena_ordenes()
            End If
        End If
    End Sub
    '=================================================================================
    '                        ACTUALIZA ORDENES
    '=================================================================================
    Private Sub actualiza_orden()
        Dim strsql As String
        Dim afectados As Integer
        Dim i As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                strsql = "UPDATE SERI11 SET STATUS  = '" & fg(i, 10) & "' " & _
                                          " WHERE PEDIDO = '" & orden.Text & "' AND CODIGO = '" & fg(i, 1) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()
            MsgBox("Orden de Compra actualizada Correctamente. ", MsgBoxStyle.Information, "Datos Actualizados")

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

   
End Class
