<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctos_i
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctos_i))
        Me.C1flx = New C1.Win.FlexViewer.C1FlexViewer()
        Me.C1r = New C1.Win.FlexReport.C1FlexReport()
        CType(Me.C1flx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1flx
        '
        Me.C1flx.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.C1flx.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.C1flx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1flx.Location = New System.Drawing.Point(0, 0)
        Me.C1flx.Name = "C1flx"
        Me.C1flx.Size = New System.Drawing.Size(856, 638)
        Me.C1flx.TabIndex = 8
        '
        'C1r
        '
        Me.C1r.ReportDefinition = resources.GetString("C1r.ReportDefinition")
        Me.C1r.ReportName = "C1FlexReport1"
        '
        'Doctos_i
        '
        Me.ClientSize = New System.Drawing.Size(856, 638)
        Me.Controls.Add(Me.C1flx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Doctos_i"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprime Documentos"
        CType(Me.C1flx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1flx As C1.Win.FlexViewer.C1FlexViewer
    Friend WithEvents C1r As C1.Win.FlexReport.C1FlexReport
End Class
