<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Me.Pedido = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Unidades = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.F_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Codigo = New System.Windows.Forms.ComboBox()
        Me.Desc_Material = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.agrega = New System.Windows.Forms.Button()
        Me.mt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Comentarios = New System.Windows.Forms.TextBox()
        Me.limpia_todo = New System.Windows.Forms.Button()
        Me.moneda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nom_prov = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.F_pedido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.mt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pedido
        '
        Me.Pedido.Enabled = False
        Me.Pedido.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pedido.Location = New System.Drawing.Point(824, 64)
        Me.Pedido.MaxLength = 8
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Size = New System.Drawing.Size(104, 22)
        Me.Pedido.TabIndex = 71
        Me.Pedido.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Precio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Unidades)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Controls.Add(Me.Desc_Material)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Borrar)
        Me.GroupBox1.Controls.Add(Me.agrega)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(10, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 114)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(792, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 89
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Precio
        '
        Me.Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.Location = New System.Drawing.Point(120, 79)
        Me.Precio.MaxLength = 8
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(104, 22)
        Me.Precio.TabIndex = 8
        Me.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Precio U :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Unidades
        '
        Me.Unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidades.Location = New System.Drawing.Point(120, 53)
        Me.Unidades.MaxLength = 8
        Me.Unidades.Name = "Unidades"
        Me.Unidades.Size = New System.Drawing.Size(104, 22)
        Me.Unidades.TabIndex = 7
        Me.Unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Unidades :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'F_entrega
        '
        Me.F_entrega.CalendarMonthBackground = System.Drawing.Color.White
        Me.F_entrega.CalendarTitleForeColor = System.Drawing.Color.White
        Me.F_entrega.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.F_entrega.CustomFormat = "dd/MM/yyyy"
        Me.F_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_entrega.Location = New System.Drawing.Point(130, 36)
        Me.F_entrega.Name = "F_entrega"
        Me.F_entrega.Size = New System.Drawing.Size(104, 22)
        Me.F_entrega.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(120, 24)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(197, 21)
        Me.Codigo.TabIndex = 5
        '
        'Desc_Material
        '
        Me.Desc_Material.BackColor = System.Drawing.Color.White
        Me.Desc_Material.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Desc_Material.Location = New System.Drawing.Point(323, 24)
        Me.Desc_Material.Name = "Desc_Material"
        Me.Desc_Material.Size = New System.Drawing.Size(449, 21)
        Me.Desc_Material.TabIndex = 51
        Me.Desc_Material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 26)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "F. Entrega:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Material"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Borrar
        '
        Me.Borrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Borrar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.ForeColor = System.Drawing.Color.Black
        Me.Borrar.Image = CType(resources.GetObject("Borrar.Image"), System.Drawing.Image)
        Me.Borrar.Location = New System.Drawing.Point(858, 65)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(60, 40)
        Me.Borrar.TabIndex = 21
        Me.Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Borrar.UseVisualStyleBackColor = False
        '
        'agrega
        '
        Me.agrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.agrega.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrega.ForeColor = System.Drawing.Color.Black
        Me.agrega.Image = CType(resources.GetObject("agrega.Image"), System.Drawing.Image)
        Me.agrega.Location = New System.Drawing.Point(792, 65)
        Me.agrega.Name = "agrega"
        Me.agrega.Size = New System.Drawing.Size(60, 40)
        Me.agrega.TabIndex = 11
        Me.agrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.agrega.UseVisualStyleBackColor = False
        '
        'mt
        '
        Me.mt.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.mt.AllowEditing = False
        Me.mt.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.mt.ColumnInfo = resources.GetString("mt.ColumnInfo")
        Me.mt.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.mt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.mt.Location = New System.Drawing.Point(106, 335)
        Me.mt.Name = "mt"
        Me.mt.Rows.DefaultSize = 18
        Me.mt.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.mt.Size = New System.Drawing.Size(199, 216)
        Me.mt.StyleInfo = resources.GetString("mt.StyleInfo")
        Me.mt.TabIndex = 84
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(802, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 77
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Comentario:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Comentarios
        '
        Me.Comentarios.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentarios.Location = New System.Drawing.Point(130, 59)
        Me.Comentarios.MaxLength = 80
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Size = New System.Drawing.Size(624, 22)
        Me.Comentarios.TabIndex = 2
        '
        'limpia_todo
        '
        Me.limpia_todo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.limpia_todo.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpia_todo.ForeColor = System.Drawing.Color.Black
        Me.limpia_todo.Image = CType(resources.GetObject("limpia_todo.Image"), System.Drawing.Image)
        Me.limpia_todo.Location = New System.Drawing.Point(868, 8)
        Me.limpia_todo.Name = "limpia_todo"
        Me.limpia_todo.Size = New System.Drawing.Size(60, 40)
        Me.limpia_todo.TabIndex = 83
        Me.limpia_todo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.limpia_todo.UseVisualStyleBackColor = False
        '
        'moneda
        '
        Me.moneda.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.moneda.Items.AddRange(New Object() {"$", "Q"})
        Me.moneda.Location = New System.Drawing.Point(706, 86)
        Me.moneda.Name = "moneda"
        Me.moneda.Size = New System.Drawing.Size(48, 24)
        Me.moneda.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(18, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Proveedor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nom_prov
        '
        Me.Nom_prov.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_prov.Location = New System.Drawing.Point(130, 83)
        Me.Nom_prov.Name = "Nom_prov"
        Me.Nom_prov.Size = New System.Drawing.Size(456, 24)
        Me.Nom_prov.TabIndex = 3
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(10, 229)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(920, 431)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 88
        '
        'F_pedido
        '
        Me.F_pedido.BackColor = System.Drawing.Color.White
        Me.F_pedido.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_pedido.Location = New System.Drawing.Point(131, 7)
        Me.F_pedido.Name = "F_pedido"
        Me.F_pedido.Size = New System.Drawing.Size(119, 25)
        Me.F_pedido.TabIndex = 89
        Me.F_pedido.Text = "Label1"
        Me.F_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(623, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Moneda:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 672)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.F_pedido)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Pedido)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.F_entrega)
        Me.Controls.Add(Me.mt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Comentarios)
        Me.Controls.Add(Me.limpia_todo)
        Me.Controls.Add(Me.moneda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Nom_prov)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pedidos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Ordenes de Compra"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.mt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fg,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Pedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Precio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Unidades As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents F_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Codigo As System.Windows.Forms.ComboBox
    Friend WithEvents Desc_Material As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents agrega As System.Windows.Forms.Button
    Friend WithEvents mt As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Comentarios As System.Windows.Forms.TextBox
    Friend WithEvents limpia_todo As System.Windows.Forms.Button
    Friend WithEvents moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Nom_prov As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents F_pedido As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
