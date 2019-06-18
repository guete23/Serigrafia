Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Factura
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim cnn As SqlClient.SqlConnection
    Dim dr As DataRow
    Dim fecha As String
    Dim fecha1 As String
    Dim fechac As String
    Dim l As Integer = 1
    Dim factura As Integer
    Friend WithEvents fg As C1FlexGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents empre As ComboBox
    Friend WithEvents Button2 As Button
    Dim client As String

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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.empre = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(363, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 40)
        Me.Button2.TabIndex = 125
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 68)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(982, 606)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 39)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'empre
        '
        Me.empre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empre.FormattingEnabled = True
        Me.empre.Items.AddRange(New Object() {"JT", "ZUNTEX"})
        Me.empre.Location = New System.Drawing.Point(102, 21)
        Me.empre.Name = "empre"
        Me.empre.Size = New System.Drawing.Size(219, 24)
        Me.empre.TabIndex = 123
        '
        'Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.empre)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Factura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion de Serigrafia"
        Me.ToolTip1.SetToolTip(Me, "Control de Cortes")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empre.SelectedIndex = 0
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim i As Integer = 1
        Dim strSQL As String = "SELECT * FROM SERI24 LEFT JOIN SERI20 ON SERI24.PROYECTO = SERI20.PROYECTO WHERE SERI24.ESTADO = 'A' AND NIT  = '" & empre.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(i, 1) = dr("CORTE")
            fg(i, 2) = dr("DESPACHO")
            fg(i, 3) = dr("FECHA_D")
            fg(i, 4) = dr("CPO")
            fg(i, 5) = dr("ESTILO")
            fg(i, 6) = dr("COLOR")
            fg(i, 7) = dr("DESCRIPCION_P")
            fg(i, 8) = dr("PRIMERAS") + dr("SEGUNDAS")
            fg(i, 9) = dr("PRECIO_P")
            fg(i, 10) = fg(i, 8) * fg(i, 9)
            fg(i, 11) = True
            fg(i, 12) = dr("PROYECTO")
            i = i + 1
        Next

    End Sub

    Private Sub empre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles empre.SelectedIndexChanged
        setea_fg()
        llena_fg()
        If empre.SelectedIndex = 0 Then
            client = "1"
        Else
            client = "3"
        End If
    End Sub
    Private Sub empre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles empre.KeyPress
        AutoCompletar(empre, e)
    End Sub

    ' =======================================================================================================================================
    ' =               
    ' =                                      ACTUALIZA LA BASE DE DATOS
    ' =
    ' =======================================================================================================================================
    Private Sub graba_datos(ByRef ok As Boolean)
        Dim usuario As String
        Dim obj As New empresas
        Dim afectados As Integer
        Dim l As Integer = 1
        Dim strsql As String
        Dim factur As String = ""
        usuario = obj.usuario

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            strsql = "INSERT INTO SERI_FAC01 (NIT,FECHA,USUARIO,VALOR_TOTAL) " &
                             " VALUES ('" & empre.Text & "',GETDATE(),'" & usuario & "','" & total_factura() & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            comando.CommandText = "SELECT @@IDENTITY AS TEMPVALUE"
            factura = comando.ExecuteScalar

            factur = "SERI-" + Format(factura, "000000")
            strsql = "INSERT INTO FACTURAS(CLIENTE,FACTURA,FECHA,FECHA_V,DESCRIPCION,VALOR,SALDO) " &
                             " VALUES ('" & client & "','" &
                                            factur & "',GETDATE(),GETDATE(),'SERVICIO DE SERIGRAFIA','" &
                                            total_factura() & "','" &
                                            total_factura() & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For l = 1 To fg.Rows.Count - 1
                If fg(l, 11) = True Then
                    strsql = "INSERT INTO SERI_FAC02 (FACTURA,DESPACHO,FECHA,UNIDADES,VALOR_U,VALOR_T) " &
                           " VALUES ('" & factura & "','" & fg(l, 2) & "',GETDATE(),'" & fg(l, 8) & "','" & fg(l, 9) & "','" & fg(l, 10) & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    strsql = "UPDATE SERI20 SET ESTADO ='F' WHERE PROYECTO = '" & fg(l, 12) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    strsql = "UPDATE SERI24 SET ESTADO ='F' WHERE PROYECTO = '" & fg(l, 12) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

            transaccion.Commit()
            ok = True
        Catch e As Exception
            Try
                MsgBox("Error al momento de grabar. " + e.Message, MsgBoxStyle.Critical, "Por favor revise.")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Esta Completamente Seguro de Generar Factura?  ", MsgBoxStyle.YesNo, "Generación de Facturas")
        If seguro = MsgBoxResult.Yes Then
            procesa()
        End If
    End Sub

    Private Sub procesa()
        Dim ok As Boolean
        graba_datos(ok)
        Close()
    End Sub
    Private Function total_factura() As Decimal
        Dim total As Decimal
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 11) = True Then
                total = total + fg(i, 10)
            End If
        Next
        Return total
    End Function
End Class



