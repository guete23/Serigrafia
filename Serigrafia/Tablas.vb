Imports C1.Win.C1FlexGrid

Public Class Tablas
    Inherits System.Windows.Forms.Form
    Dim fila As Integer
    Dim codigo As String
    Dim lineas As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents tipo As System.Windows.Forms.TextBox
    Friend WithEvents e1 As System.Windows.Forms.Button
    Friend WithEvents e2 As System.Windows.Forms.Button
    Friend WithEvents medida As System.Windows.Forms.TextBox
    Friend WithEvents r2 As System.Windows.Forms.Button
    Friend WithEvents g2 As System.Windows.Forms.Button
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents descrip_med As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents descrip_mat As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents r1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tablas))
        Me.tc = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.e1 = New System.Windows.Forms.Button()
        Me.tipo = New System.Windows.Forms.TextBox()
        Me.r1 = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.descrip_mat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.e2 = New System.Windows.Forms.Button()
        Me.medida = New System.Windows.Forms.TextBox()
        Me.r2 = New System.Windows.Forms.Button()
        Me.g2 = New System.Windows.Forms.Button()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.descrip_med = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.tc.Size = New System.Drawing.Size(778, 560)
        Me.tc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.e1)
        Me.TabPage1.Controls.Add(Me.tipo)
        Me.TabPage1.Controls.Add(Me.r1)
        Me.TabPage1.Controls.Add(Me.G1)
        Me.TabPage1.Controls.Add(Me.fg)
        Me.TabPage1.Controls.Add(Me.descrip_mat)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(770, 531)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tipos Mat."
        Me.ToolTip1.SetToolTip(Me.TabPage1, "Tipos de Materiales")
        '
        'e1
        '
        Me.e1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1.ForeColor = System.Drawing.Color.Black
        Me.e1.Image = CType(resources.GetObject("e1.Image"), System.Drawing.Image)
        Me.e1.Location = New System.Drawing.Point(592, 8)
        Me.e1.Name = "e1"
        Me.e1.Size = New System.Drawing.Size(50, 35)
        Me.e1.TabIndex = 67
        Me.e1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.e1, "Presione este Boton para Borrar el  Cliente .")
        Me.e1.UseVisualStyleBackColor = False
        Me.e1.Visible = False
        '
        'tipo
        '
        Me.tipo.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.Location = New System.Drawing.Point(506, 13)
        Me.tipo.MaxLength = 50
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(80, 24)
        Me.tipo.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.tipo, "Tipo de Cobro")
        Me.tipo.Visible = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(704, 8)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(50, 35)
        Me.r1.TabIndex = 7
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r1, "Cancela Operación")
        Me.r1.UseVisualStyleBackColor = False
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(648, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(50, 35)
        Me.G1.TabIndex = 6
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar / Actualizar el  Cliente.")
        Me.G1.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(0, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(763, 471)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Doble click para eliminar la línea seleccionada.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'descrip_mat
        '
        Me.descrip_mat.BackColor = System.Drawing.Color.White
        Me.descrip_mat.Location = New System.Drawing.Point(128, 11)
        Me.descrip_mat.MaxLength = 40
        Me.descrip_mat.Name = "descrip_mat"
        Me.descrip_mat.Size = New System.Drawing.Size(359, 22)
        Me.descrip_mat.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.descrip_mat, "Tipo de Material")
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.e2)
        Me.TabPage2.Controls.Add(Me.medida)
        Me.TabPage2.Controls.Add(Me.r2)
        Me.TabPage2.Controls.Add(Me.g2)
        Me.TabPage2.Controls.Add(Me.jg)
        Me.TabPage2.Controls.Add(Me.descrip_med)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(770, 531)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Unidad Medida"
        '
        'e2
        '
        Me.e2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2.ForeColor = System.Drawing.Color.Black
        Me.e2.Image = CType(resources.GetObject("e2.Image"), System.Drawing.Image)
        Me.e2.Location = New System.Drawing.Point(487, 9)
        Me.e2.Name = "e2"
        Me.e2.Size = New System.Drawing.Size(50, 35)
        Me.e2.TabIndex = 74
        Me.e2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.e2, "Presione este Boton para Borrar el  Cliente .")
        Me.e2.UseVisualStyleBackColor = False
        Me.e2.Visible = False
        '
        'medida
        '
        Me.medida.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medida.Location = New System.Drawing.Point(687, 14)
        Me.medida.MaxLength = 50
        Me.medida.Name = "medida"
        Me.medida.Size = New System.Drawing.Size(80, 24)
        Me.medida.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.medida, "Tipo de Cobro")
        Me.medida.Visible = False
        '
        'r2
        '
        Me.r2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.ForeColor = System.Drawing.Color.Black
        Me.r2.Image = CType(resources.GetObject("r2.Image"), System.Drawing.Image)
        Me.r2.Location = New System.Drawing.Point(599, 9)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(50, 35)
        Me.r2.TabIndex = 71
        Me.r2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r2, "Cancela Operación")
        Me.r2.UseVisualStyleBackColor = False
        '
        'g2
        '
        Me.g2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g2.ForeColor = System.Drawing.Color.Black
        Me.g2.Image = CType(resources.GetObject("g2.Image"), System.Drawing.Image)
        Me.g2.Location = New System.Drawing.Point(543, 9)
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(50, 35)
        Me.g2.TabIndex = 70
        Me.g2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.g2, "Presione este Boton para Grabar / Actualizar el  Cliente.")
        Me.g2.UseVisualStyleBackColor = False
        '
        'jg
        '
        Me.jg.AllowEditing = False
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(4, 50)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 17
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(763, 471)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.jg, "Presione Doble click para eliminar la línea seleccionada.")
        '
        'descrip_med
        '
        Me.descrip_med.BackColor = System.Drawing.Color.White
        Me.descrip_med.Location = New System.Drawing.Point(132, 12)
        Me.descrip_med.MaxLength = 40
        Me.descrip_med.Name = "descrip_med"
        Me.descrip_med.Size = New System.Drawing.Size(272, 22)
        Me.descrip_med.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.descrip_med, "Unidad de Medida.")
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Descripción"
        '
        'Tablas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 572)
        Me.Controls.Add(Me.tc)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tablas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablas del Sistema"
        Me.tc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tablas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler descrip_mat.KeyPress, AddressOf keypressed1
        AddHandler descrip_med.KeyPress, AddressOf keypressed2
        limpia_variables()
        setea_fg()
        setea_jg()
   
    End Sub

    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc.Click
        Select Case tc.SelectedIndex
            Case 0
                limpia_variables()
            Case 1
                limpia_variables1()
        End Select
    End Sub

    Private Sub setea_fg()
        fg.Rows(0).Height = 30
        tipo.Text = "00000"
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

    Private Sub busca_tipo_material(tipo As Integer, ByRef descripcion As String, ByRef ok As Boolean)
        Dim cnn As New SqlClient.SqlConnection
        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM SERI02 WHERE TIPO = '" & tipo & "'"
        llena_tablas(dt, strSQL, cnn)
        ok = False
        If dt.Rows.Count > 0 Then
            For Each dr In dt.Rows
                descripcion = dr("DESCRIPCION_MAT")
                ok = True
            Next
        Else
            descripcion = ""
        End If
    End Sub

    Private Sub limpia_variables()
        descrip_mat.Text = ""
        descrip_mat.Focus()
        e1.Visible = False
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descrip_mat.Text) <> "" Then
                G1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub CA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        limpia_variables()
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        If Trim(descrip_mat.Text) = "" Then
            mensaje("Por favor ingrese el tipo de Material !!!")
            Exit Sub
        End If
        graba_tipo_material()
        setea_fg()
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox(var, MsgBoxStyle.Exclamation, "REVISE LOS DATOS!!!! ")
    End Sub


    Private Sub e1_Click_1(sender As System.Object, e As System.EventArgs) Handles e1.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_tipo_material()
            setea_fg()
            limpia_variables()
        End If
    End Sub

    '=================================================================================
    '                        GRABA DATOS TIPOS
    '=================================================================================
    Private Sub graba_tipo_material()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERI02 SET DESCRIPCION_MAT  = '" & UCase(descrip_mat.Text) & "' WHERE TIPO = '" & CInt(tipo.Text) & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERI02 (DESCRIPCION_MAT) VALUES ('" & _
                                              UCase(descrip_mat.Text) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As SqlClient.SqlException
            Dim err As String
            Try
                If e.Number = 2627 Then
                    err = "Tipo de Material ya existe !!!"
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
    '                        GRABA DATOS TIPOS
    '=================================================================================
    Private Sub elimina_tipo_material()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SERI02 WHERE TIPO = '" & CInt(tipo.Text) & "'"
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

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        Dim ok As Boolean
        If fil > 0 And fil < fg.Rows.Count Then
            tipo.Text = fg(fil, 1)
            descrip_mat.Text = fg(fil, 2)
            busca_tipo_material(tipo.Text, descrip_mat.Text, ok)
            If ok Then
                e1.Visible = True
                descrip_mat.Focus()
            End If
        End If
    End Sub
    '=================================================================================
    '
    '============================ UNIDAD DE MEDIDA ===================================
    Private Sub setea_jg()
        jg.Rows(0).Height = 30
        medida.Text = "00000"
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

    Private Sub busca_unidad_medida(medida As Integer, ByRef descripcion As String, ByRef ok As Boolean)
        Dim cnn As New SqlClient.SqlConnection
        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM SERI03 WHERE U_MEDIDA = '" & medida & "'"
        llena_tablas(dt, strSQL, cnn)
        ok = False
        If dt.Rows.Count > 0 Then
            For Each dr In dt.Rows
                descripcion = dr("DESCRIPCION_MEDIDA")
                ok = True
            Next
        Else
            descripcion = ""
        End If
    End Sub

    Private Sub limpia_variables1()
        descrip_med.Text = ""
        e2.Visible = False
        descrip_med.Focus()
    End Sub

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descrip_med.Text) <> "" Then
                g2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub r2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r2.Click
        limpia_variables()
    End Sub

    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g2.Click
        If Trim(descrip_med.Text) = "" Then
            mensaje("Por favor ingrese la descripción de la Unidad de Medida !!!")
            Exit Sub
        End If
        graba_unidad_medida()
        setea_jg()
        limpia_variables1()
    End Sub

    Private Sub e2_Click_1(sender As System.Object, e As System.EventArgs) Handles e2.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_unidad_medida()
            setea_jg()
            limpia_variables()
        End If
    End Sub

    '=================================================================================
    '                        GRABA DATOS TIPOS
    '=================================================================================
    Private Sub graba_unidad_medida()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERI03 SET DESCRIPCION_MEDIDA  = '" & UCase(descrip_med.Text) & "' WHERE U_MEDIDA = '" & CInt(medida.Text) & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERI03 (DESCRIPCION_MEDIDA) VALUES ('" & _
                                              UCase(descrip_med.Text) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As SqlClient.SqlException
            Dim err As String
            Try
                If e.Number = 2627 Then
                    err = "Unidad de medida ya existente !!!"
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
    '                        ELIMINA UNIDAD_MEDIDA
    '=================================================================================
    Private Sub elimina_unidad_medida()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SERI03 WHERE U_MEDIDA = '" & CInt(medida.Text) & "'"
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

    Private Sub JG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jg.Click
        fila = jg.RowSel
        seleccion1(fila)
    End Sub

    Private Sub seleccion1(ByVal fil As Integer)
        Dim ok As Boolean
        If fil > 0 And fil < jg.Rows.Count Then
            medida.Text = jg(fil, 1)
            descrip_med.Text = jg(fil, 2)
            busca_unidad_medida(medida.Text, descrip_med.Text, ok)
            If ok Then
                e2.Visible = True
            End If
            descrip_med.Focus()
        End If
    End Sub


End Class
