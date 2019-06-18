<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura_i
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura_i))
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.AvailablePreviewActions = CType(((((((((((((C1.Win.C1Preview.C1PreviewActionFlags.Print Or C1.Win.C1Preview.C1PreviewActionFlags.GoFirst) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoPrev) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoLast) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.GoPage) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryNext) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.HistoryPrev) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomIn) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOut) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomFactor) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomInTool) _
            Or C1.Win.C1Preview.C1PreviewActionFlags.ZoomOutTool), C1.Win.C1Preview.C1PreviewActionFlags)
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.OutlineView
        '
        Me.C1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView"
        Me.C1PrintPreviewControl1.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.C1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.ShowRulers = C1.Win.C1Preview.ShowRulersFlags.None
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize
        '
        'C1PrintPreviewControl1.PreviewTextSearchPanel
        '
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        '
        'C1PrintPreviewControl1.ThumbnailView
        '
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView"
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 613)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(984, 686)
        Me.C1PrintPreviewControl1.TabIndex = 5
        Me.C1PrintPreviewControl1.Text = "-"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Name = "btnFileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ToolTipText = "Save File"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Name = "lblOfPages"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Size = New System.Drawing.Size(27, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Tag = "C1PreviewActionEnum.GoPageCount"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Text = "of 0"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Name = "lblPage"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Size = New System.Drawing.Size(33, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Tag = "C1PreviewActionEnum.GoPageLabel"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Text = "Page"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Checked = True
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.ToolTipText = "Single Page View"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ToolTipText = "Find Text"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Checked = True
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Visible = False
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Name = "dropZoomFactor"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Size = New System.Drawing.Size(13, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Tag = "C1PreviewActionEnum.ZoomFactor"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipToolZoomIn = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipToolZoomOut = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Size = New System.Drawing.Size(67, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Size = New System.Drawing.Size(67, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool, Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool})
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool"
        '
        'FAEC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 686)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAEC11"
        Me.ShowInTaskbar = False
        Me.Text = "Impresión de Facturas Comerciales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
End Class
