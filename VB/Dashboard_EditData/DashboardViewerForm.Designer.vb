Namespace Dashboard_EditData
    Partial Public Class DashboardViewerForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DashboardViewerForm))
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 3
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl1.Size = New System.Drawing.Size(877, 143)
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Edit Underlying Data"
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.ImageUri.Uri = "Edit"
            Me.barButtonItem1.Name = "barButtonItem1"
            Me.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Reload Data"
            Me.barButtonItem2.Glyph = (DirectCast(resources.GetObject("barButtonItem2.Glyph"), System.Drawing.Image))
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.Name = "barButtonItem2"
            Me.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            ' 
            ' dashboardViewer1
            ' 
            Me.dashboardViewer1.DashboardSource = "..\..\Data\Dashboard.xml"
            Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardViewer1.Location = New System.Drawing.Point(0, 143)
            Me.dashboardViewer1.Name = "dashboardViewer1"
            Me.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = (CByte(0))
            Me.dashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
            Me.dashboardViewer1.Size = New System.Drawing.Size(877, 379)
            Me.dashboardViewer1.TabIndex = 1
            ' 
            ' DashboardViewerForm
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(877, 522)
            Me.Controls.Add(Me.dashboardViewer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "DashboardViewerForm"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Dashboard Viewer"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

