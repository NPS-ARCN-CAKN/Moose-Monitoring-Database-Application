<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryExplorerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QueryExplorerToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SelectADataSourceToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DataTabPage = New System.Windows.Forms.TabPage()
        Me.DataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PivotTabPage = New System.Windows.Forms.TabPage()
        Me.DataPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.DataSourceToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.QueryExplorerToolStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.DataTabPage.SuspendLayout()
        CType(Me.DataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PivotTabPage.SuspendLayout()
        CType(Me.DataPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QueryExplorerToolStrip
        '
        Me.QueryExplorerToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.QueryExplorerToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectADataSourceToolStripLabel, Me.DataSourceToolStripComboBox})
        Me.QueryExplorerToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.QueryExplorerToolStrip.Name = "QueryExplorerToolStrip"
        Me.QueryExplorerToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.QueryExplorerToolStrip.TabIndex = 0
        Me.QueryExplorerToolStrip.Text = "ToolStrip1"
        '
        'SelectADataSourceToolStripLabel
        '
        Me.SelectADataSourceToolStripLabel.Name = "SelectADataSourceToolStripLabel"
        Me.SelectADataSourceToolStripLabel.Size = New System.Drawing.Size(114, 22)
        Me.SelectADataSourceToolStripLabel.Text = "Select a data source:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DataTabPage)
        Me.TabControl1.Controls.Add(Me.PivotTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 425)
        Me.TabControl1.TabIndex = 1
        '
        'DataTabPage
        '
        Me.DataTabPage.Controls.Add(Me.DataGridControl)
        Me.DataTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DataTabPage.Name = "DataTabPage"
        Me.DataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTabPage.Size = New System.Drawing.Size(792, 399)
        Me.DataTabPage.TabIndex = 0
        Me.DataTabPage.Text = "Data"
        Me.DataTabPage.UseVisualStyleBackColor = True
        '
        'DataGridControl
        '
        Me.DataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridControl.Location = New System.Drawing.Point(3, 3)
        Me.DataGridControl.MainView = Me.GridView1
        Me.DataGridControl.Name = "DataGridControl"
        Me.DataGridControl.Size = New System.Drawing.Size(786, 393)
        Me.DataGridControl.TabIndex = 0
        Me.DataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DataGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'PivotTabPage
        '
        Me.PivotTabPage.Controls.Add(Me.DataPivotGridControl)
        Me.PivotTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PivotTabPage.Name = "PivotTabPage"
        Me.PivotTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PivotTabPage.Size = New System.Drawing.Size(792, 399)
        Me.PivotTabPage.TabIndex = 1
        Me.PivotTabPage.Text = "Pivot"
        Me.PivotTabPage.UseVisualStyleBackColor = True
        '
        'DataPivotGridControl
        '
        Me.DataPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPivotGridControl.Location = New System.Drawing.Point(3, 3)
        Me.DataPivotGridControl.Name = "DataPivotGridControl"
        Me.DataPivotGridControl.Size = New System.Drawing.Size(786, 393)
        Me.DataPivotGridControl.TabIndex = 0
        '
        'DataSourceToolStripComboBox
        '
        Me.DataSourceToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DataSourceToolStripComboBox.Name = "DataSourceToolStripComboBox"
        Me.DataSourceToolStripComboBox.Size = New System.Drawing.Size(256, 25)
        '
        'QueryExplorerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.QueryExplorerToolStrip)
        Me.Name = "QueryExplorerForm"
        Me.Text = "QueryExplorerForm"
        Me.QueryExplorerToolStrip.ResumeLayout(False)
        Me.QueryExplorerToolStrip.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.DataTabPage.ResumeLayout(False)
        CType(Me.DataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PivotTabPage.ResumeLayout(False)
        CType(Me.DataPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QueryExplorerToolStrip As ToolStrip
    Friend WithEvents SelectADataSourceToolStripLabel As ToolStripLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DataTabPage As TabPage
    Friend WithEvents DataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PivotTabPage As TabPage
    Friend WithEvents DataPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DataSourceToolStripComboBox As ToolStripComboBox
End Class
