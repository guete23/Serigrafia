<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proyectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proyectos))
        Me.proyecto = New System.Windows.Forms.TextBox()
        Me.F_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.limpia_todo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.F_pedido = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unip = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cba = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cobro = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.estilo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.val = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'proyecto
        '
        Me.proyecto.Enabled = False
        Me.proyecto.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proyecto.Location = New System.Drawing.Point(824, 177)
        Me.proyecto.MaxLength = 8
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Size = New System.Drawing.Size(104, 22)
        Me.proyecto.TabIndex = 71
        Me.proyecto.Visible = False
        '
        'F_entrega
        '
        Me.F_entrega.CalendarMonthBackground = System.Drawing.Color.White
        Me.F_entrega.CalendarTitleForeColor = System.Drawing.Color.White
        Me.F_entrega.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.F_entrega.CustomFormat = "dd/MM/yyyy"
        Me.F_entrega.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.F_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_entrega.Location = New System.Drawing.Point(132, 254)
        Me.F_entrega.Name = "F_entrega"
        Me.F_entrega.Size = New System.Drawing.Size(135, 22)
        Me.F_entrega.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "F. Entrega:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(18, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Descripción:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(130, 76)
        Me.descripcion.MaxLength = 150
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(652, 47)
        Me.descripcion.TabIndex = 2
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(130, 46)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(652, 24)
        Me.cliente.TabIndex = 1
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(21, 373)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(920, 242)
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(687, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Precio U :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'unip
        '
        Me.unip.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.unip.Location = New System.Drawing.Point(132, 282)
        Me.unip.MaxLength = 8
        Me.unip.Name = "unip"
        Me.unip.Size = New System.Drawing.Size(104, 22)
        Me.unip.TabIndex = 5
        Me.unip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 24)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Unidades :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cba
        '
        Me.cba.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cba.Location = New System.Drawing.Point(132, 313)
        Me.cba.MaxLength = 8
        Me.cba.Name = "cba"
        Me.cba.Size = New System.Drawing.Size(104, 22)
        Me.cba.TabIndex = 7
        Me.cba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 24)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Charge Back:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(22, 343)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 24)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "Cobro:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cobro
        '
        Me.cobro.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cobro.Items.AddRange(New Object() {"FACTURAR", "ENVIO", "MUESTRA"})
        Me.cobro.Location = New System.Drawing.Point(132, 343)
        Me.cobro.Name = "cobro"
        Me.cobro.Size = New System.Drawing.Size(195, 24)
        Me.cobro.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Corte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'corte
        '
        Me.corte.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.corte.Items.AddRange(New Object() {"FACTURAR", "ENVIO", "MUESTRA"})
        Me.corte.Location = New System.Drawing.Point(130, 133)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(195, 24)
        Me.corte.TabIndex = 3
        '
        'estilo
        '
        Me.estilo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.estilo.Location = New System.Drawing.Point(132, 195)
        Me.estilo.MaxLength = 20
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(195, 22)
        Me.estilo.TabIndex = 102
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(20, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 24)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Estilo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cpo.Location = New System.Drawing.Point(132, 164)
        Me.cpo.MaxLength = 20
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(195, 22)
        Me.cpo.TabIndex = 101
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(20, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 24)
        Me.Label14.TabIndex = 103
        Me.Label14.Text = "CPO:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.colo.Location = New System.Drawing.Point(132, 223)
        Me.colo.MaxLength = 25
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(195, 22)
        Me.colo.TabIndex = 105
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(20, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 24)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Color:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'val
        '
        Me.val.BackColor = System.Drawing.Color.White
        Me.val.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.val.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val.ForeColor = System.Drawing.Color.Black
        Me.val.Location = New System.Drawing.Point(799, 345)
        Me.val.Name = "val"
        Me.val.Size = New System.Drawing.Size(104, 22)
        Me.val.TabIndex = 108
        Me.val.Text = " "
        Me.val.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Proyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 634)
        Me.Controls.Add(Me.val)
        Me.Controls.Add(Me.colo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.cobro)
        Me.Controls.Add(Me.cba)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.unip)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.F_pedido)
        Me.Controls.Add(Me.proyecto)
        Me.Controls.Add(Me.F_entrega)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.limpia_todo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Proyectos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de Producción"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents proyecto As System.Windows.Forms.TextBox
    Friend WithEvents F_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents limpia_todo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents F_pedido As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents unip As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cba As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cobro As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    Friend WithEvents estilo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cpo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents colo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents val As Label
End Class
