Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing

Public Class Despacho_mant
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strsql As String = ""
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents unidades As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents despacho As System.Windows.Forms.Label
    Friend WithEvents malo As System.Windows.Forms.Button
    Friend WithEvents motivo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents proyecto As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Despacho_mant))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.proyecto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.motivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.malo = New System.Windows.Forms.Button()
        Me.unidades = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.despacho = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(12, 3)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 24
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1181, 461)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.proyecto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.motivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.malo)
        Me.GroupBox1.Controls.Add(Me.unidades)
        Me.GroupBox1.Controls.Add(Me.cliente)
        Me.GroupBox1.Controls.Add(Me.descripcion)
        Me.GroupBox1.Controls.Add(Me.despacho)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 470)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1165, 222)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'proyecto
        '
        Me.proyecto.BackColor = System.Drawing.Color.White
        Me.proyecto.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.proyecto.Location = New System.Drawing.Point(186, 63)
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Size = New System.Drawing.Size(175, 24)
        Me.proyecto.TabIndex = 111
        Me.proyecto.Text = " "
        Me.proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 24)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "O.Prod."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'motivo
        '
        Me.motivo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.motivo.Location = New System.Drawing.Point(186, 183)
        Me.motivo.MaxLength = 100
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(722, 22)
        Me.motivo.TabIndex = 109
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 24)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Motivo Anulación:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'malo
        '
        Me.malo.BackColor = System.Drawing.Color.White
        Me.malo.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malo.ForeColor = System.Drawing.Color.Black
        Me.malo.Image = CType(resources.GetObject("malo.Image"), System.Drawing.Image)
        Me.malo.Location = New System.Drawing.Point(992, 44)
        Me.malo.Name = "malo"
        Me.malo.Size = New System.Drawing.Size(80, 69)
        Me.malo.TabIndex = 107
        Me.malo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.malo.UseVisualStyleBackColor = False
        '
        'unidades
        '
        Me.unidades.BackColor = System.Drawing.Color.White
        Me.unidades.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.unidades.Location = New System.Drawing.Point(186, 153)
        Me.unidades.Name = "unidades"
        Me.unidades.Size = New System.Drawing.Size(175, 24)
        Me.unidades.TabIndex = 106
        Me.unidades.Text = " "
        Me.unidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cliente.Location = New System.Drawing.Point(186, 123)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(550, 24)
        Me.cliente.TabIndex = 105
        Me.cliente.Text = " "
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.White
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.descripcion.Location = New System.Drawing.Point(186, 93)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(550, 24)
        Me.descripcion.TabIndex = 104
        Me.descripcion.Text = " "
        Me.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'despacho
        '
        Me.despacho.BackColor = System.Drawing.Color.White
        Me.despacho.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.despacho.Location = New System.Drawing.Point(186, 23)
        Me.despacho.Name = "despacho"
        Me.despacho.Size = New System.Drawing.Size(175, 24)
        Me.despacho.TabIndex = 103
        Me.despacho.Text = " "
        Me.despacho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Unidades"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Descripción:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(22, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 24)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Despacho:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Despacho_mant
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 709)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Despacho_mant"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anulación de Despachos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Pedido_mant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
        proyecto.Text = ""
        despacho.Text = ""
        descripcion.Text = ""
        cliente.Text = ""
        unidades.Text = ""
        motivo.Text = ""
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim filter As New ConditionFilter
        Dim filter1 As New ConditionFilter
        strsql = "SELECT * FROM SERI24 LEFT JOIN SERI20 ON SERI24.PROYECTO = SERI20.PROYECTO JOIN SERI15 ON SERI20.NIT = SERI15.NIT WHERE SERI24.ESTADO = 'A'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("DESPACHO")
            fg(l, 2) = dr("PROYECTO")
            fg(l, 3) = dr("DESCRIPCION_P")
            fg(l, 4) = dr("NOMBRE")
            fg(l, 5) = dr("UNIDADES")
            l = l + 1
        Next dr
    End Sub

    '=================================================================================
    '                        ACTUALIZA DESPACHO
    '=================================================================================
    Private Sub actualiza_proyecto()
        Dim strsql As String
        Dim afectados As Integer
        Dim empre As New empresas
        Dim usuario As String = empre.usuario

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERI24 SET ESTADO  = 'X' , PRIMERAS = 0, SEGUNDAS = 0 WHERE DESPACHO = " & CInt(despacho.Text)
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO SERI25 (PROCESO,DOCTO,FECHA,MOTIVO,USUARIO) VALUES ('D','" & despacho.Text & "','" & Now & "','" & motivo.Text & "','" & usuario & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            MsgBox("Proyecto actualizado Correctamente. ", MsgBoxStyle.Information, "Anulación de Proyectos")

        Catch e As SqlClient.SqlException
            Dim err As String
            Try
                err = "La actualizacion de datos falló."
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


    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.CellChanged
        llena_datos()
    End Sub

    Private Sub llena_datos()
        Dim f As Integer = fg.RowSel
        Try
            despacho.Text = Format(fg(f, 1), "00000000")
            proyecto.Text = Format(fg(f, 2), "00000000")
            descripcion.Text = fg(f, 3)
            cliente.Text = fg(f, 4)
            unidades.Text = Format(fg(f, 5), "#####0")
            motivo.Text = ""
        Catch
        End Try
    End Sub

    Private Sub malo_Click(sender As System.Object, e As System.EventArgs) Handles malo.Click
        Dim seguro As MsgBoxResult
        If Trim(motivo.Text) = "" Then
            MsgBox("Aún no ha ingresado el Motivo de la Anulación.", MsgBoxStyle.Critical, "Motivo invalido.")
            Exit Sub
        End If
        Try
            If CInt(despacho.Text) > 0 Then
                seguro = MsgBox("Está completamente SEGURO de querer anular el Proyecto? ", MsgBoxStyle.YesNo, "Actualizando Datos !!!")
                If seguro = MsgBoxResult.Yes Then
                    actualiza_proyecto()
                    setea_grid()
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub fg_Click_1(sender As System.Object, e As System.EventArgs) Handles fg.Click
        llena_datos()
    End Sub
    Private Sub fg_Change(sender As System.Object, e As System.EventArgs) Handles fg.AfterRowColChange
        llena_datos()
    End Sub
End Class
