﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recepcion))
        Me.G1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.limpia_todo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.F_pedido = New System.Windows.Forms.Label()
        Me.unidades = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.proy = New System.Windows.Forms.ComboBox()
        Me.cliente = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.recibido = New System.Windows.Forms.TextBox()
        Me.pro = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(802, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(60, 40)
        Me.G1.TabIndex = 77
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.G1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 24)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Descripción:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label6.Location = New System.Drawing.Point(12, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(10, 212)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(920, 448)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 88
        '
        'F_pedido
        '
        Me.F_pedido.BackColor = System.Drawing.Color.White
        Me.F_pedido.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_pedido.Location = New System.Drawing.Point(138, 7)
        Me.F_pedido.Name = "F_pedido"
        Me.F_pedido.Size = New System.Drawing.Size(119, 25)
        Me.F_pedido.TabIndex = 89
        Me.F_pedido.Text = "Label1"
        Me.F_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'unidades
        '
        Me.unidades.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.unidades.Location = New System.Drawing.Point(134, 141)
        Me.unidades.MaxLength = 8
        Me.unidades.Name = "unidades"
        Me.unidades.Size = New System.Drawing.Size(104, 22)
        Me.unidades.TabIndex = 2
        Me.unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 24)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Unidades :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 24)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "O.Prod."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'proy
        '
        Me.proy.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.proy.Items.AddRange(New Object() {"FACTURAR", "ENVIO", "MUESTRA"})
        Me.proy.Location = New System.Drawing.Point(135, 49)
        Me.proy.Name = "proy"
        Me.proy.Size = New System.Drawing.Size(195, 24)
        Me.proy.TabIndex = 1
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cliente.Location = New System.Drawing.Point(135, 79)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(651, 24)
        Me.cliente.TabIndex = 100
        Me.cliente.Text = " "
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.White
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.descripcion.Location = New System.Drawing.Point(135, 109)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(651, 24)
        Me.descripcion.TabIndex = 101
        Me.descripcion.Text = " "
        Me.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Recibido por:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'recibido
        '
        Me.recibido.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.recibido.Location = New System.Drawing.Point(134, 172)
        Me.recibido.MaxLength = 80
        Me.recibido.Name = "recibido"
        Me.recibido.Size = New System.Drawing.Size(652, 22)
        Me.recibido.TabIndex = 3
        '
        'pro
        '
        Me.pro.BackColor = System.Drawing.Color.White
        Me.pro.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.pro.Location = New System.Drawing.Point(816, 81)
        Me.pro.Name = "pro"
        Me.pro.Size = New System.Drawing.Size(112, 24)
        Me.pro.TabIndex = 107
        Me.pro.Text = " "
        Me.pro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pro.Visible = False
        '
        'Recepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 672)
        Me.Controls.Add(Me.pro)
        Me.Controls.Add(Me.recibido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.proy)
        Me.Controls.Add(Me.unidades)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.F_pedido)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.limpia_todo)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recepcion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción de Prendas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents limpia_todo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents F_pedido As System.Windows.Forms.Label
    Friend WithEvents unidades As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents proy As System.Windows.Forms.ComboBox
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents recibido As System.Windows.Forms.TextBox
    Friend WithEvents pro As System.Windows.Forms.Label
End Class
