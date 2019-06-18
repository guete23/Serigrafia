<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proyectos_c
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proyectos_c))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.proyecto = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.cobro = New System.Windows.Forms.Label()
        Me.fentrega = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.Label()
        Me.cb = New System.Windows.Forms.Label()
        Me.unidades = New System.Windows.Forms.Label()
        Me.rg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.estado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.corte = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.cpos = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.rg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(589, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 24)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Cobro:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'proyecto
        '
        Me.proyecto.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.proyecto.Items.AddRange(New Object() {"FACTURAR", "ENVIO", "MUESTRA"})
        Me.proyecto.Location = New System.Drawing.Point(134, 14)
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Size = New System.Drawing.Size(116, 24)
        Me.proyecto.TabIndex = 105
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(589, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 24)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "Charge Back:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Precio U :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(13, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 24)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Unidades :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fecha.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(131, 54)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(119, 24)
        Me.fecha.TabIndex = 110
        Me.fecha.Text = " "
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(589, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "F. Entrega:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Descripción:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cliente.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(131, 87)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(907, 24)
        Me.cliente.TabIndex = 116
        Me.cliente.Text = " "
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "O.Prod.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.White
        Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(131, 115)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(907, 51)
        Me.descripcion.TabIndex = 117
        Me.descripcion.Text = " "
        '
        'cobro
        '
        Me.cobro.BackColor = System.Drawing.Color.White
        Me.cobro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cobro.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobro.Location = New System.Drawing.Point(716, 202)
        Me.cobro.Name = "cobro"
        Me.cobro.Size = New System.Drawing.Size(209, 24)
        Me.cobro.TabIndex = 118
        Me.cobro.Text = " "
        Me.cobro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fentrega
        '
        Me.fentrega.BackColor = System.Drawing.Color.White
        Me.fentrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fentrega.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fentrega.Location = New System.Drawing.Point(716, 54)
        Me.fentrega.Name = "fentrega"
        Me.fentrega.Size = New System.Drawing.Size(119, 24)
        Me.fentrega.TabIndex = 119
        Me.fentrega.Text = " "
        Me.fentrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'precio
        '
        Me.precio.BackColor = System.Drawing.Color.White
        Me.precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.precio.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio.Location = New System.Drawing.Point(131, 202)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(119, 24)
        Me.precio.TabIndex = 120
        Me.precio.Text = " "
        Me.precio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb
        '
        Me.cb.BackColor = System.Drawing.Color.White
        Me.cb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cb.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb.Location = New System.Drawing.Point(716, 172)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(119, 24)
        Me.cb.TabIndex = 121
        Me.cb.Text = " "
        Me.cb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'unidades
        '
        Me.unidades.BackColor = System.Drawing.Color.White
        Me.unidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.unidades.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unidades.Location = New System.Drawing.Point(131, 172)
        Me.unidades.Name = "unidades"
        Me.unidades.Size = New System.Drawing.Size(119, 24)
        Me.unidades.TabIndex = 122
        Me.unidades.Text = " "
        Me.unidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rg
        '
        Me.rg.AllowEditing = False
        Me.rg.ColumnInfo = resources.GetString("rg.ColumnInfo")
        Me.rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.rg.Location = New System.Drawing.Point(12, 462)
        Me.rg.Name = "rg"
        Me.rg.Rows.DefaultSize = 19
        Me.rg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.rg.Size = New System.Drawing.Size(575, 186)
        Me.rg.StyleInfo = resources.GetString("rg.StyleInfo")
        Me.rg.TabIndex = 124
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 447)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 16)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "RECEPCIONES"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(589, 448)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = " DESPACHOS"
        '
        'dg
        '
        Me.dg.ColumnInfo = resources.GetString("dg.ColumnInfo")
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.dg.Location = New System.Drawing.Point(593, 462)
        Me.dg.Name = "dg"
        Me.dg.Rows.DefaultSize = 19
        Me.dg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dg.Size = New System.Drawing.Size(588, 186)
        Me.dg.StyleInfo = resources.GetString("dg.StyleInfo")
        Me.dg.TabIndex = 129
        '
        'estado
        '
        Me.estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estado.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.Location = New System.Drawing.Point(592, 16)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(243, 24)
        Me.estado.TabIndex = 130
        Me.estado.Text = " "
        Me.estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.colo)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.estilo)
        Me.GroupBox1.Controls.Add(Me.estil)
        Me.GroupBox1.Controls.Add(Me.cpo)
        Me.GroupBox1.Controls.Add(Me.cpos)
        Me.GroupBox1.Controls.Add(Me.corte)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1169, 188)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.corte.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.Location = New System.Drawing.Point(124, 31)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(363, 24)
        Me.corte.TabIndex = 118
        Me.corte.Text = " "
        Me.corte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Corte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cpo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(124, 68)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(363, 24)
        Me.cpo.TabIndex = 120
        Me.cpo.Text = " "
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpos
        '
        Me.cpos.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpos.ForeColor = System.Drawing.Color.White
        Me.cpos.Location = New System.Drawing.Point(6, 66)
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(104, 24)
        Me.cpos.TabIndex = 119
        Me.cpos.Text = "CPO:"
        Me.cpos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estilo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.Location = New System.Drawing.Point(124, 105)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(363, 24)
        Me.estilo.TabIndex = 122
        Me.estilo.Text = " "
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.estil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estil.ForeColor = System.Drawing.Color.White
        Me.estil.Location = New System.Drawing.Point(6, 103)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(104, 24)
        Me.estil.TabIndex = 121
        Me.estil.Text = "Estilo:"
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colo.Location = New System.Drawing.Point(124, 143)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(363, 24)
        Me.colo.TabIndex = 124
        Me.colo.Text = " "
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(6, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 24)
        Me.Label19.TabIndex = 123
        Me.Label19.Text = "Color:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Proyectos_c
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 672)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.rg)
        Me.Controls.Add(Me.unidades)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.fentrega)
        Me.Controls.Add(Me.cobro)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.proyecto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Proyectos_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Ordenes de Producción"
        CType(Me.rg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents cobro As System.Windows.Forms.Label
    Friend WithEvents fentrega As System.Windows.Forms.Label
    Friend WithEvents precio As System.Windows.Forms.Label
    Friend WithEvents cb As System.Windows.Forms.Label
    Friend WithEvents unidades As System.Windows.Forms.Label
    Friend WithEvents rg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents estado As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents colo As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents estilo As Label
    Friend WithEvents estil As Label
    Friend WithEvents cpo As Label
    Friend WithEvents cpos As Label
    Friend WithEvents corte As Label
    Friend WithEvents Label7 As Label
End Class
