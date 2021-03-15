<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ArcScaleRange1 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange2 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange3 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim OverlappedRangeBarSeriesView1 As DevExpress.XtraCharts.OverlappedRangeBarSeriesView = New DevExpress.XtraCharts.OverlappedRangeBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.colReportReferenceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliverablesDatasetReferenceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProtocolReferenceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ValidatedDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colSurveyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MooseDataSet = New Moose_Monitoring_Database_Application.MooseDataSet()
        Me.GSPE_SurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_SurveysTableAdapter = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.GSPE_SurveysTableAdapter()
        Me.TableAdapterManager = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.TableAdapterManager()
        Me.GSPETableAdapter = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.GSPETableAdapter()
        Me.GSPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_SurveyGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GSPE_SurveyContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSharedDriveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenARCNMooseMonitoringDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCAKNMooseMonitoringDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidateThisSurveyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertifyThisSurveyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GSPE_SurveyGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParkSubArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colPopulationEstimate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConfidenceInterval = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPopulationEstimateUpperCI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPopulationEstimateLowerCI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedDensity_SqMi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAreaSurveyed_mi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAverageSearchEffort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonnel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProtocolVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSurveyDatasetTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colRecordInsertedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeasonGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.DatasourceGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MethodologyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ValidatedByColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ValidatedByRepositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ReportLinkGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BullCowGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CalfCowGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CalfAdultGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NetworkGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NetworkRepositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemMemoEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemMemoEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.ResultsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.ResultsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ResultsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ResultsView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ResultsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SelectAQueryToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportGridControlToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExcelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValuesTextFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsPivotXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ResultsPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ResultsPivotChartControl = New DevExpress.XtraCharts.ChartControl()
        Me.ResultsPivotToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SelectAResultsPivotDatasourceToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SelectAResultsPivotDatasourceToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportPivotGridContentsToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValuesTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GSPE_SurveyVGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.ValidatedDateRepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.DatasetProcessingStepsRepositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.SummaryRepositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.AbstractRepositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.CommentsRepositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rowSurveyName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYear = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSeason = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowParkSubArea = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMethodology = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.StatisticsCategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowPopulationEstimate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimateLowerCI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimateUpperCI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowConfidenceInterval = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCalfCowRatio90 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.CalfAdultrow = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBullCowRatio90 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstimatedDensity_SqMi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAreaSurveyed_mi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAverageSearchEffort = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.OnlineResourcesCategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowProtocolReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProtocolVersion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDeliverablesDatasetReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowReportReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowReportLink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPersonnel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAbstract = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSummary = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDatasetProcessingSteps = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSurveyDatasetTitle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComments = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.MetadataCategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowRecordInsertedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowValidatedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowValidatedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDataSource = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ReadOnlyToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ReadOnlyToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenResourcesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CertifySurveyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshDatasetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnalyticsToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SurveyResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GSPEDatasetSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueryExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportSurveyDataToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExcelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValuesTextFileToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DigitalResourcesToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.circularGauge12 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.GSPESurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerBottom = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.ResultsDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.GSPE_SurveyDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.ChartDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer2 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GSPE_SurveysChartControl = New DevExpress.XtraCharts.ChartControl()
        Me.GSPESurveysBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_SurveyGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GSPE_SurveyContextMenuStrip.SuspendLayout()
        CType(Me.GSPE_SurveyGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidatedByRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetworkRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsXtraTabControl.SuspendLayout()
        Me.ResultsXtraTabPage.SuspendLayout()
        CType(Me.ResultsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsToolStrip.SuspendLayout()
        Me.ResultsPivotXtraTabPage.SuspendLayout()
        CType(Me.ResultsPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsPivotChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsPivotToolStrip.SuspendLayout()
        CType(Me.GSPE_SurveyVGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidatedDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidatedDateRepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetProcessingStepsRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SummaryRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbstractRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circularGauge12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerBottom.SuspendLayout()
        Me.ResultsDockPanel.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        Me.hideContainerLeft.SuspendLayout()
        Me.GSPE_SurveyDockPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.hideContainerRight.SuspendLayout()
        Me.ChartDockPanel.SuspendLayout()
        Me.ControlContainer2.SuspendLayout()
        CType(Me.GSPE_SurveysChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPESurveysBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colReportReferenceCode
        '
        Me.colReportReferenceCode.FieldName = "ReportReferenceCode"
        Me.colReportReferenceCode.Name = "colReportReferenceCode"
        Me.colReportReferenceCode.Visible = True
        Me.colReportReferenceCode.VisibleIndex = 6
        Me.colReportReferenceCode.Width = 137
        '
        'colDeliverablesDatasetReferenceCode
        '
        Me.colDeliverablesDatasetReferenceCode.FieldName = "DeliverablesDatasetReferenceCode"
        Me.colDeliverablesDatasetReferenceCode.Name = "colDeliverablesDatasetReferenceCode"
        Me.colDeliverablesDatasetReferenceCode.Visible = True
        Me.colDeliverablesDatasetReferenceCode.VisibleIndex = 7
        Me.colDeliverablesDatasetReferenceCode.Width = 203
        '
        'colProtocolReferenceCode
        '
        Me.colProtocolReferenceCode.FieldName = "ProtocolReferenceCode"
        Me.colProtocolReferenceCode.Name = "colProtocolReferenceCode"
        Me.colProtocolReferenceCode.Visible = True
        Me.colProtocolReferenceCode.VisibleIndex = 25
        Me.colProtocolReferenceCode.Width = 143
        '
        'ValidatedDateGridColumn
        '
        Me.ValidatedDateGridColumn.AppearanceCell.ForeColor = System.Drawing.Color.Gray
        Me.ValidatedDateGridColumn.AppearanceCell.Options.UseForeColor = True
        Me.ValidatedDateGridColumn.Caption = "Validation date"
        Me.ValidatedDateGridColumn.ColumnEdit = Me.RepositoryItemDateEdit4
        Me.ValidatedDateGridColumn.FieldName = "ValidatedDate"
        Me.ValidatedDateGridColumn.Name = "ValidatedDateGridColumn"
        Me.ValidatedDateGridColumn.Visible = True
        Me.ValidatedDateGridColumn.VisibleIndex = 29
        Me.ValidatedDateGridColumn.Width = 94
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'colSurveyName
        '
        Me.colSurveyName.FieldName = "SurveyName"
        Me.colSurveyName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colSurveyName.Name = "colSurveyName"
        Me.colSurveyName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colSurveyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SurveyName", "{0}")})
        Me.colSurveyName.Visible = True
        Me.colSurveyName.VisibleIndex = 0
        Me.colSurveyName.Width = 335
        '
        'MooseDataSet
        '
        Me.MooseDataSet.DataSetName = "MooseDataSet"
        Me.MooseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSPE_SurveysBindingSource
        '
        Me.GSPE_SurveysBindingSource.DataMember = "GSPE_Surveys"
        Me.GSPE_SurveysBindingSource.DataSource = Me.MooseDataSet
        '
        'GSPE_SurveysTableAdapter
        '
        Me.GSPE_SurveysTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GSPE_SurveysTableAdapter = Me.GSPE_SurveysTableAdapter
        Me.TableAdapterManager.GSPETableAdapter = Me.GSPETableAdapter
        Me.TableAdapterManager.UpdateOrder = Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GSPETableAdapter
        '
        Me.GSPETableAdapter.ClearBeforeFill = True
        '
        'GSPEBindingSource
        '
        Me.GSPEBindingSource.DataMember = "FK_GSPE_GSPE_Surveys1"
        Me.GSPEBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPE_SurveyGridControl
        '
        Me.GSPE_SurveyGridControl.ContextMenuStrip = Me.GSPE_SurveyContextMenuStrip
        Me.GSPE_SurveyGridControl.DataSource = Me.GSPE_SurveysBindingSource
        Me.GSPE_SurveyGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GSPE_SurveyGridControl.EmbeddedNavigator.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "SurveyName", True))
        Me.HelpProvider.SetHelpNavigator(Me.GSPE_SurveyGridControl, System.Windows.Forms.HelpNavigator.TableOfContents)
        GridLevelNode1.RelationName = "FK_GSPE_GSPE_Surveys1"
        Me.GSPE_SurveyGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GSPE_SurveyGridControl.Location = New System.Drawing.Point(21, 86)
        Me.GSPE_SurveyGridControl.MainView = Me.GSPE_SurveyGridView
        Me.GSPE_SurveyGridControl.Name = "GSPE_SurveyGridControl"
        Me.GSPE_SurveyGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit6, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit7, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemDateEdit4, Me.ValidatedByRepositoryItemComboBox, Me.NetworkRepositoryItemComboBox})
        Me.HelpProvider.SetShowHelp(Me.GSPE_SurveyGridControl, True)
        Me.GSPE_SurveyGridControl.Size = New System.Drawing.Size(1635, 954)
        Me.GSPE_SurveyGridControl.TabIndex = 2
        Me.GSPE_SurveyGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GSPE_SurveyGridView, Me.LayoutView1})
        '
        'GSPE_SurveyContextMenuStrip
        '
        Me.GSPE_SurveyContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GSPE_SurveyContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenReportToolStripMenuItem, Me.OpenSharedDriveDirectoryToolStripMenuItem, Me.OpenARCNMooseMonitoringDirectoryToolStripMenuItem, Me.OpenCAKNMooseMonitoringDirectoryToolStripMenuItem, Me.ValidateThisSurveyToolStripMenuItem, Me.CertifyThisSurveyToolStripMenuItem})
        Me.GSPE_SurveyContextMenuStrip.Name = "ContextMenuStrip"
        Me.GSPE_SurveyContextMenuStrip.Size = New System.Drawing.Size(300, 136)
        '
        'OpenReportToolStripMenuItem
        '
        Me.OpenReportToolStripMenuItem.Name = "OpenReportToolStripMenuItem"
        Me.OpenReportToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.OpenReportToolStripMenuItem.Text = "Open report..."
        '
        'OpenSharedDriveDirectoryToolStripMenuItem
        '
        Me.OpenSharedDriveDirectoryToolStripMenuItem.Name = "OpenSharedDriveDirectoryToolStripMenuItem"
        Me.OpenSharedDriveDirectoryToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.OpenSharedDriveDirectoryToolStripMenuItem.Text = "Open Survey directory..."
        '
        'OpenARCNMooseMonitoringDirectoryToolStripMenuItem
        '
        Me.OpenARCNMooseMonitoringDirectoryToolStripMenuItem.Name = "OpenARCNMooseMonitoringDirectoryToolStripMenuItem"
        Me.OpenARCNMooseMonitoringDirectoryToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.OpenARCNMooseMonitoringDirectoryToolStripMenuItem.Text = "Open ARCN moose monitoring directory..."
        '
        'OpenCAKNMooseMonitoringDirectoryToolStripMenuItem
        '
        Me.OpenCAKNMooseMonitoringDirectoryToolStripMenuItem.Name = "OpenCAKNMooseMonitoringDirectoryToolStripMenuItem"
        Me.OpenCAKNMooseMonitoringDirectoryToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.OpenCAKNMooseMonitoringDirectoryToolStripMenuItem.Text = "Open CAKN moose monitoring directory..."
        '
        'ValidateThisSurveyToolStripMenuItem
        '
        Me.ValidateThisSurveyToolStripMenuItem.Name = "ValidateThisSurveyToolStripMenuItem"
        Me.ValidateThisSurveyToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ValidateThisSurveyToolStripMenuItem.Text = "Validate this survey..."
        '
        'CertifyThisSurveyToolStripMenuItem
        '
        Me.CertifyThisSurveyToolStripMenuItem.Name = "CertifyThisSurveyToolStripMenuItem"
        Me.CertifyThisSurveyToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.CertifyThisSurveyToolStripMenuItem.Text = "Certify this survey..."
        '
        'GSPE_SurveyGridView
        '
        Me.GSPE_SurveyGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSurveyName, Me.colYear, Me.colPark, Me.colParkSubArea, Me.colStartDate, Me.colEndDate, Me.colPopulationEstimate, Me.colConfidenceInterval, Me.colPopulationEstimateUpperCI, Me.colPopulationEstimateLowerCI, Me.colEstimatedDensity_SqMi, Me.colAreaSurveyed_mi, Me.colAverageSearchEffort, Me.colPersonnel, Me.colReportReferenceCode, Me.colDeliverablesDatasetReferenceCode, Me.colProtocolReferenceCode, Me.colProtocolVersion, Me.colSurveyDatasetTitle, Me.colRecordInsertedDate, Me.colRecordInsertedBy, Me.SeasonGridColumn, Me.DatasourceGridColumn, Me.MethodologyGridColumn, Me.ValidatedDateGridColumn, Me.ValidatedByColumn, Me.ReportLinkGridColumn, Me.BullCowGridColumn, Me.CalfCowGridColumn, Me.CalfAdultGridColumn, Me.NetworkGridColumn})
        GridFormatRule1.Column = Me.colReportReferenceCode
        GridFormatRule1.Name = "ReportReferenceCode_NULL_Format"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue1.Value1 = "0"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colDeliverablesDatasetReferenceCode
        GridFormatRule2.ColumnApplyTo = Me.colDeliverablesDatasetReferenceCode
        GridFormatRule2.Name = "DeliverablesNULLFormat"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue2.Value1 = "0"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.colProtocolReferenceCode
        GridFormatRule3.Name = "ProtocolNULLFormat"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue3.Value1 = "0"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.ValidatedDateGridColumn
        GridFormatRule4.ColumnApplyTo = Me.colSurveyName
        GridFormatRule4.Name = "ValidatedFormat"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue4.Value1 = New Date(1900, 3, 2, 12, 14, 13, 0)
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule1)
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule2)
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule3)
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule4)
        Me.GSPE_SurveyGridView.GridControl = Me.GSPE_SurveyGridControl
        Me.GSPE_SurveyGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "PopulationEstimate", Nothing, "(Population Estimate: AVG={0:0.##})")})
        Me.GSPE_SurveyGridView.Name = "GSPE_SurveyGridView"
        Me.GSPE_SurveyGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GSPE_SurveyGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GSPE_SurveyGridView.OptionsView.ColumnAutoWidth = False
        Me.GSPE_SurveyGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GSPE_SurveyGridView.OptionsView.ShowFooter = True
        Me.GSPE_SurveyGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ValidatedDateGridColumn, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSurveyName, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 1
        Me.colYear.Width = 45
        '
        'colPark
        '
        Me.colPark.FieldName = "Park"
        Me.colPark.Name = "colPark"
        Me.colPark.Visible = True
        Me.colPark.VisibleIndex = 3
        Me.colPark.Width = 44
        '
        'colParkSubArea
        '
        Me.colParkSubArea.FieldName = "ParkSubArea"
        Me.colParkSubArea.Name = "colParkSubArea"
        Me.colParkSubArea.Visible = True
        Me.colParkSubArea.VisibleIndex = 5
        Me.colParkSubArea.Width = 91
        '
        'colStartDate
        '
        Me.colStartDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 17
        Me.colStartDate.Width = 73
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colEndDate
        '
        Me.colEndDate.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 18
        Me.colEndDate.Width = 67
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'colPopulationEstimate
        '
        Me.colPopulationEstimate.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colPopulationEstimate.AppearanceCell.Options.UseBackColor = True
        Me.colPopulationEstimate.FieldName = "PopulationEstimate"
        Me.colPopulationEstimate.Name = "colPopulationEstimate"
        Me.colPopulationEstimate.Visible = True
        Me.colPopulationEstimate.VisibleIndex = 8
        Me.colPopulationEstimate.Width = 117
        '
        'colConfidenceInterval
        '
        Me.colConfidenceInterval.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colConfidenceInterval.AppearanceCell.Options.UseBackColor = True
        Me.colConfidenceInterval.FieldName = "ConfidenceInterval"
        Me.colConfidenceInterval.Name = "colConfidenceInterval"
        Me.colConfidenceInterval.Visible = True
        Me.colConfidenceInterval.VisibleIndex = 11
        Me.colConfidenceInterval.Width = 118
        '
        'colPopulationEstimateUpperCI
        '
        Me.colPopulationEstimateUpperCI.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colPopulationEstimateUpperCI.AppearanceCell.Options.UseBackColor = True
        Me.colPopulationEstimateUpperCI.FieldName = "PopulationEstimateUpperCI"
        Me.colPopulationEstimateUpperCI.Name = "colPopulationEstimateUpperCI"
        Me.colPopulationEstimateUpperCI.Visible = True
        Me.colPopulationEstimateUpperCI.VisibleIndex = 10
        Me.colPopulationEstimateUpperCI.Width = 163
        '
        'colPopulationEstimateLowerCI
        '
        Me.colPopulationEstimateLowerCI.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colPopulationEstimateLowerCI.AppearanceCell.Options.UseBackColor = True
        Me.colPopulationEstimateLowerCI.FieldName = "PopulationEstimateLowerCI"
        Me.colPopulationEstimateLowerCI.Name = "colPopulationEstimateLowerCI"
        Me.colPopulationEstimateLowerCI.Visible = True
        Me.colPopulationEstimateLowerCI.VisibleIndex = 9
        Me.colPopulationEstimateLowerCI.Width = 163
        '
        'colEstimatedDensity_SqMi
        '
        Me.colEstimatedDensity_SqMi.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colEstimatedDensity_SqMi.AppearanceCell.Options.UseBackColor = True
        Me.colEstimatedDensity_SqMi.FieldName = "EstimatedDensity_SqMi"
        Me.colEstimatedDensity_SqMi.Name = "colEstimatedDensity_SqMi"
        Me.colEstimatedDensity_SqMi.Visible = True
        Me.colEstimatedDensity_SqMi.VisibleIndex = 13
        Me.colEstimatedDensity_SqMi.Width = 140
        '
        'colAreaSurveyed_mi
        '
        Me.colAreaSurveyed_mi.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colAreaSurveyed_mi.AppearanceCell.Options.UseBackColor = True
        Me.colAreaSurveyed_mi.FieldName = "AreaSurveyed_mi"
        Me.colAreaSurveyed_mi.Name = "colAreaSurveyed_mi"
        Me.colAreaSurveyed_mi.Visible = True
        Me.colAreaSurveyed_mi.VisibleIndex = 12
        Me.colAreaSurveyed_mi.Width = 111
        '
        'colAverageSearchEffort
        '
        Me.colAverageSearchEffort.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colAverageSearchEffort.AppearanceCell.Options.UseBackColor = True
        Me.colAverageSearchEffort.FieldName = "AverageSearchEffort"
        Me.colAverageSearchEffort.Name = "colAverageSearchEffort"
        Me.colAverageSearchEffort.Visible = True
        Me.colAverageSearchEffort.VisibleIndex = 20
        Me.colAverageSearchEffort.Width = 131
        '
        'colPersonnel
        '
        Me.colPersonnel.FieldName = "Personnel"
        Me.colPersonnel.Name = "colPersonnel"
        Me.colPersonnel.Visible = True
        Me.colPersonnel.VisibleIndex = 21
        Me.colPersonnel.Width = 70
        '
        'colProtocolVersion
        '
        Me.colProtocolVersion.FieldName = "ProtocolVersion"
        Me.colProtocolVersion.Name = "colProtocolVersion"
        Me.colProtocolVersion.Visible = True
        Me.colProtocolVersion.VisibleIndex = 24
        Me.colProtocolVersion.Width = 100
        '
        'colSurveyDatasetTitle
        '
        Me.colSurveyDatasetTitle.FieldName = "SurveyDatasetTitle"
        Me.colSurveyDatasetTitle.Name = "colSurveyDatasetTitle"
        Me.colSurveyDatasetTitle.Visible = True
        Me.colSurveyDatasetTitle.VisibleIndex = 26
        Me.colSurveyDatasetTitle.Width = 121
        '
        'colRecordInsertedDate
        '
        Me.colRecordInsertedDate.AppearanceCell.ForeColor = System.Drawing.Color.Gray
        Me.colRecordInsertedDate.AppearanceCell.Options.UseForeColor = True
        Me.colRecordInsertedDate.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.colRecordInsertedDate.FieldName = "RecordInsertedDate"
        Me.colRecordInsertedDate.Name = "colRecordInsertedDate"
        Me.colRecordInsertedDate.OptionsColumn.ReadOnly = True
        Me.colRecordInsertedDate.Visible = True
        Me.colRecordInsertedDate.VisibleIndex = 27
        Me.colRecordInsertedDate.Width = 127
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'colRecordInsertedBy
        '
        Me.colRecordInsertedBy.AppearanceCell.ForeColor = System.Drawing.Color.Gray
        Me.colRecordInsertedBy.AppearanceCell.Options.UseForeColor = True
        Me.colRecordInsertedBy.FieldName = "RecordInsertedBy"
        Me.colRecordInsertedBy.Name = "colRecordInsertedBy"
        Me.colRecordInsertedBy.OptionsColumn.ReadOnly = True
        Me.colRecordInsertedBy.Visible = True
        Me.colRecordInsertedBy.VisibleIndex = 28
        Me.colRecordInsertedBy.Width = 116
        '
        'SeasonGridColumn
        '
        Me.SeasonGridColumn.Caption = "Season"
        Me.SeasonGridColumn.ColumnEdit = Me.RepositoryItemComboBox1
        Me.SeasonGridColumn.FieldName = "Season"
        Me.SeasonGridColumn.Name = "SeasonGridColumn"
        Me.SeasonGridColumn.OptionsEditForm.Caption = "Season"
        Me.SeasonGridColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.SeasonGridColumn.Visible = True
        Me.SeasonGridColumn.VisibleIndex = 4
        Me.SeasonGridColumn.Width = 58
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Spring", "Fall"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'DatasourceGridColumn
        '
        Me.DatasourceGridColumn.Caption = "Data Source"
        Me.DatasourceGridColumn.FieldName = "DataSource"
        Me.DatasourceGridColumn.Name = "DatasourceGridColumn"
        Me.DatasourceGridColumn.ToolTip = "Path to the directory or file from which the data was imported."
        Me.DatasourceGridColumn.Visible = True
        Me.DatasourceGridColumn.VisibleIndex = 23
        Me.DatasourceGridColumn.Width = 374
        '
        'MethodologyGridColumn
        '
        Me.MethodologyGridColumn.Caption = "Methodology"
        Me.MethodologyGridColumn.ColumnEdit = Me.RepositoryItemComboBox2
        Me.MethodologyGridColumn.FieldName = "Methodology"
        Me.MethodologyGridColumn.Name = "MethodologyGridColumn"
        Me.MethodologyGridColumn.Visible = True
        Me.MethodologyGridColumn.VisibleIndex = 19
        Me.MethodologyGridColumn.Width = 85
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"Gasaway", "GSPE"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'ValidatedByColumn
        '
        Me.ValidatedByColumn.AppearanceCell.ForeColor = System.Drawing.Color.Gray
        Me.ValidatedByColumn.AppearanceCell.Options.UseForeColor = True
        Me.ValidatedByColumn.Caption = "Validated by"
        Me.ValidatedByColumn.ColumnEdit = Me.ValidatedByRepositoryItemComboBox
        Me.ValidatedByColumn.FieldName = "ValidatedBy"
        Me.ValidatedByColumn.Name = "ValidatedByColumn"
        Me.ValidatedByColumn.Visible = True
        Me.ValidatedByColumn.VisibleIndex = 30
        Me.ValidatedByColumn.Width = 82
        '
        'ValidatedByRepositoryItemComboBox
        '
        Me.ValidatedByRepositoryItemComboBox.AutoHeight = False
        Me.ValidatedByRepositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ValidatedByRepositoryItemComboBox.Name = "ValidatedByRepositoryItemComboBox"
        '
        'ReportLinkGridColumn
        '
        Me.ReportLinkGridColumn.Caption = "Report link"
        Me.ReportLinkGridColumn.Name = "ReportLinkGridColumn"
        Me.ReportLinkGridColumn.Visible = True
        Me.ReportLinkGridColumn.VisibleIndex = 22
        Me.ReportLinkGridColumn.Width = 74
        '
        'BullCowGridColumn
        '
        Me.BullCowGridColumn.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.BullCowGridColumn.AppearanceCell.Options.UseBackColor = True
        Me.BullCowGridColumn.Caption = "Bull:Cow"
        Me.BullCowGridColumn.FieldName = "BullCowRatio90"
        Me.BullCowGridColumn.Name = "BullCowGridColumn"
        Me.BullCowGridColumn.Visible = True
        Me.BullCowGridColumn.VisibleIndex = 16
        Me.BullCowGridColumn.Width = 64
        '
        'CalfCowGridColumn
        '
        Me.CalfCowGridColumn.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.CalfCowGridColumn.AppearanceCell.Options.UseBackColor = True
        Me.CalfCowGridColumn.Caption = "Calf:Cow"
        Me.CalfCowGridColumn.FieldName = "CalfCowRatio90"
        Me.CalfCowGridColumn.Name = "CalfCowGridColumn"
        Me.CalfCowGridColumn.Visible = True
        Me.CalfCowGridColumn.VisibleIndex = 14
        Me.CalfCowGridColumn.Width = 67
        '
        'CalfAdultGridColumn
        '
        Me.CalfAdultGridColumn.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.CalfAdultGridColumn.AppearanceCell.Options.UseBackColor = True
        Me.CalfAdultGridColumn.Caption = "Calf:Adult"
        Me.CalfAdultGridColumn.FieldName = "CalfAdultRatio90"
        Me.CalfAdultGridColumn.Name = "CalfAdultGridColumn"
        Me.CalfAdultGridColumn.Visible = True
        Me.CalfAdultGridColumn.VisibleIndex = 15
        '
        'NetworkGridColumn
        '
        Me.NetworkGridColumn.Caption = "I&M Network"
        Me.NetworkGridColumn.ColumnEdit = Me.NetworkRepositoryItemComboBox
        Me.NetworkGridColumn.FieldName = "Network"
        Me.NetworkGridColumn.Name = "NetworkGridColumn"
        Me.NetworkGridColumn.Visible = True
        Me.NetworkGridColumn.VisibleIndex = 2
        '
        'NetworkRepositoryItemComboBox
        '
        Me.NetworkRepositoryItemComboBox.AutoHeight = False
        Me.NetworkRepositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NetworkRepositoryItemComboBox.Items.AddRange(New Object() {"", "ARCN", "CAKN"})
        Me.NetworkRepositoryItemComboBox.Name = "NetworkRepositoryItemComboBox"
        '
        'RepositoryItemMemoEdit6
        '
        Me.RepositoryItemMemoEdit6.LinesCount = 12
        Me.RepositoryItemMemoEdit6.Name = "RepositoryItemMemoEdit6"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemMemoEdit7
        '
        Me.RepositoryItemMemoEdit7.LinesCount = 20
        Me.RepositoryItemMemoEdit7.Name = "RepositoryItemMemoEdit7"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.GSPE_SurveyGridControl
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Nothing
        '
        'ResultsXtraTabControl
        '
        Me.ResultsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ResultsXtraTabControl.Name = "ResultsXtraTabControl"
        Me.ResultsXtraTabControl.SelectedTabPage = Me.ResultsXtraTabPage
        Me.ResultsXtraTabControl.Size = New System.Drawing.Size(1629, 463)
        Me.ResultsXtraTabControl.TabIndex = 5
        Me.ResultsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.ResultsXtraTabPage, Me.ResultsPivotXtraTabPage})
        '
        'ResultsXtraTabPage
        '
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsGridControl)
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsToolStrip)
        Me.ResultsXtraTabPage.Name = "ResultsXtraTabPage"
        Me.ResultsXtraTabPage.Size = New System.Drawing.Size(1627, 438)
        Me.ResultsXtraTabPage.Text = "Results"
        '
        'ResultsGridControl
        '
        Me.ResultsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ResultsGridControl.MainView = Me.ResultsView
        Me.ResultsGridControl.Name = "ResultsGridControl"
        Me.ResultsGridControl.Size = New System.Drawing.Size(1627, 413)
        Me.ResultsGridControl.TabIndex = 0
        Me.ResultsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ResultsView})
        '
        'ResultsView
        '
        Me.ResultsView.GridControl = Me.ResultsGridControl
        Me.ResultsView.Name = "ResultsView"
        Me.ResultsView.OptionsView.ColumnAutoWidth = False
        Me.ResultsView.OptionsView.ShowFooter = True
        '
        'ResultsToolStrip
        '
        Me.ResultsToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ResultsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.SelectAQueryToolStripComboBox, Me.ToolStripSeparator6, Me.ExportGridControlToolStripDropDownButton})
        Me.ResultsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ResultsToolStrip.Name = "ResultsToolStrip"
        Me.ResultsToolStrip.Size = New System.Drawing.Size(1627, 25)
        Me.ResultsToolStrip.TabIndex = 3
        Me.ResultsToolStrip.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel1.Text = "Select a data source:"
        '
        'SelectAQueryToolStripComboBox
        '
        Me.SelectAQueryToolStripComboBox.Name = "SelectAQueryToolStripComboBox"
        Me.SelectAQueryToolStripComboBox.Size = New System.Drawing.Size(400, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ExportGridControlToolStripDropDownButton
        '
        Me.ExportGridControlToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportGridControlToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem1, Me.CommaSeparatedValuesTextFileToolStripMenuItem1})
        Me.ExportGridControlToolStripDropDownButton.Image = CType(resources.GetObject("ExportGridControlToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.ExportGridControlToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportGridControlToolStripDropDownButton.Name = "ExportGridControlToolStripDropDownButton"
        Me.ExportGridControlToolStripDropDownButton.Size = New System.Drawing.Size(94, 22)
        Me.ExportGridControlToolStripDropDownButton.Text = "Export dataset"
        '
        'ExcelToolStripMenuItem1
        '
        Me.ExcelToolStripMenuItem1.Name = "ExcelToolStripMenuItem1"
        Me.ExcelToolStripMenuItem1.Size = New System.Drawing.Size(257, 22)
        Me.ExcelToolStripMenuItem1.Text = "Excel..."
        '
        'CommaSeparatedValuesTextFileToolStripMenuItem1
        '
        Me.CommaSeparatedValuesTextFileToolStripMenuItem1.Name = "CommaSeparatedValuesTextFileToolStripMenuItem1"
        Me.CommaSeparatedValuesTextFileToolStripMenuItem1.Size = New System.Drawing.Size(257, 22)
        Me.CommaSeparatedValuesTextFileToolStripMenuItem1.Text = "Comma separated values text file..."
        '
        'ResultsPivotXtraTabPage
        '
        Me.ResultsPivotXtraTabPage.Controls.Add(Me.ResultsPivotGridControl)
        Me.ResultsPivotXtraTabPage.Controls.Add(Me.ResultsPivotChartControl)
        Me.ResultsPivotXtraTabPage.Controls.Add(Me.ResultsPivotToolStrip)
        Me.ResultsPivotXtraTabPage.Name = "ResultsPivotXtraTabPage"
        Me.ResultsPivotXtraTabPage.Size = New System.Drawing.Size(1627, 438)
        Me.ResultsPivotXtraTabPage.Text = "Analytics"
        '
        'ResultsPivotGridControl
        '
        Me.ResultsPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsPivotGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ResultsPivotGridControl.Name = "ResultsPivotGridControl"
        Me.ResultsPivotGridControl.Size = New System.Drawing.Size(1627, 413)
        Me.ResultsPivotGridControl.TabIndex = 4
        '
        'ResultsPivotChartControl
        '
        Me.ResultsPivotChartControl.DataSource = Me.ResultsPivotGridControl
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ResultsPivotChartControl.Diagram = XyDiagram1
        Me.ResultsPivotChartControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsPivotChartControl.Legend.MaxHorizontalPercentage = 30.0R
        Me.ResultsPivotChartControl.Legend.Name = "Default Legend"
        Me.ResultsPivotChartControl.Location = New System.Drawing.Point(0, 25)
        Me.ResultsPivotChartControl.Name = "ResultsPivotChartControl"
        Me.ResultsPivotChartControl.SeriesDataMember = "Series"
        Me.ResultsPivotChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ResultsPivotChartControl.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ResultsPivotChartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.ResultsPivotChartControl.SeriesTemplate.SeriesDataMember = "Series"
        Me.ResultsPivotChartControl.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ResultsPivotChartControl.Size = New System.Drawing.Size(1627, 413)
        Me.ResultsPivotChartControl.TabIndex = 5
        '
        'ResultsPivotToolStrip
        '
        Me.ResultsPivotToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ResultsPivotToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.SelectAResultsPivotDatasourceToolStripComboBox, Me.SelectAResultsPivotDatasourceToolStripButton, Me.ToolStripSeparator5, Me.ExportPivotGridContentsToolStripDropDownButton})
        Me.ResultsPivotToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ResultsPivotToolStrip.Name = "ResultsPivotToolStrip"
        Me.ResultsPivotToolStrip.Size = New System.Drawing.Size(1627, 25)
        Me.ResultsPivotToolStrip.TabIndex = 6
        Me.ResultsPivotToolStrip.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel2.Text = "Select a data source:"
        '
        'SelectAResultsPivotDatasourceToolStripComboBox
        '
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Name = "SelectAResultsPivotDatasourceToolStripComboBox"
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'SelectAResultsPivotDatasourceToolStripButton
        '
        Me.SelectAResultsPivotDatasourceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SelectAResultsPivotDatasourceToolStripButton.Image = CType(resources.GetObject("SelectAResultsPivotDatasourceToolStripButton.Image"), System.Drawing.Image)
        Me.SelectAResultsPivotDatasourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectAResultsPivotDatasourceToolStripButton.Name = "SelectAResultsPivotDatasourceToolStripButton"
        Me.SelectAResultsPivotDatasourceToolStripButton.Size = New System.Drawing.Size(101, 22)
        Me.SelectAResultsPivotDatasourceToolStripButton.Text = "Load data source"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ExportPivotGridContentsToolStripDropDownButton
        '
        Me.ExportPivotGridContentsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportPivotGridContentsToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.CommaSeparatedValuesTextFileToolStripMenuItem})
        Me.ExportPivotGridContentsToolStripDropDownButton.Image = CType(resources.GetObject("ExportPivotGridContentsToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.ExportPivotGridContentsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportPivotGridContentsToolStripDropDownButton.Name = "ExportPivotGridContentsToolStripDropDownButton"
        Me.ExportPivotGridContentsToolStripDropDownButton.Size = New System.Drawing.Size(106, 22)
        Me.ExportPivotGridContentsToolStripDropDownButton.Text = "Export summary"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel..."
        '
        'CommaSeparatedValuesTextFileToolStripMenuItem
        '
        Me.CommaSeparatedValuesTextFileToolStripMenuItem.Name = "CommaSeparatedValuesTextFileToolStripMenuItem"
        Me.CommaSeparatedValuesTextFileToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CommaSeparatedValuesTextFileToolStripMenuItem.Text = "Comma separated values text file..."
        '
        'GSPE_SurveyVGridControl
        '
        Me.GSPE_SurveyVGridControl.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GSPE_SurveyVGridControl.Appearance.RecordValue.Options.UseFont = True
        Me.GSPE_SurveyVGridControl.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GSPE_SurveyVGridControl.Appearance.RowHeaderPanel.Options.UseFont = True
        Me.GSPE_SurveyVGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GSPE_SurveyVGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.GSPE_SurveyVGridControl.DataSource = Me.GSPE_SurveysBindingSource
        Me.GSPE_SurveyVGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GSPE_SurveyVGridControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSPE_SurveyVGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.GSPE_SurveyVGridControl.Location = New System.Drawing.Point(0, 0)
        Me.GSPE_SurveyVGridControl.Name = "GSPE_SurveyVGridControl"
        Me.GSPE_SurveyVGridControl.RecordWidth = 135
        Me.GSPE_SurveyVGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5, Me.RepositoryItemDateEdit5, Me.ValidatedDateRepositoryItemDateEdit, Me.DatasetProcessingStepsRepositoryItemMemoEdit, Me.SummaryRepositoryItemMemoEdit, Me.AbstractRepositoryItemMemoEdit, Me.CommentsRepositoryItemMemoEdit})
        Me.GSPE_SurveyVGridControl.RowHeaderWidth = 65
        Me.GSPE_SurveyVGridControl.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSurveyName, Me.rowYear, Me.rowSeason, Me.rowPark, Me.rowParkSubArea, Me.rowMethodology, Me.rowStartDate, Me.rowEndDate, Me.StatisticsCategory, Me.OnlineResourcesCategory, Me.rowPersonnel, Me.rowAbstract, Me.rowSummary, Me.rowDatasetProcessingSteps, Me.rowSurveyDatasetTitle, Me.rowComments, Me.MetadataCategory})
        Me.GSPE_SurveyVGridControl.Size = New System.Drawing.Size(593, 1011)
        Me.GSPE_SurveyVGridControl.TabIndex = 0
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'RepositoryItemMemoEdit5
        '
        Me.RepositoryItemMemoEdit5.Name = "RepositoryItemMemoEdit5"
        '
        'RepositoryItemDateEdit5
        '
        Me.RepositoryItemDateEdit5.AutoHeight = False
        Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
        '
        'ValidatedDateRepositoryItemDateEdit
        '
        Me.ValidatedDateRepositoryItemDateEdit.AutoHeight = False
        Me.ValidatedDateRepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ValidatedDateRepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ValidatedDateRepositoryItemDateEdit.Name = "ValidatedDateRepositoryItemDateEdit"
        '
        'DatasetProcessingStepsRepositoryItemMemoEdit
        '
        Me.DatasetProcessingStepsRepositoryItemMemoEdit.LinesCount = 20
        Me.DatasetProcessingStepsRepositoryItemMemoEdit.Name = "DatasetProcessingStepsRepositoryItemMemoEdit"
        '
        'SummaryRepositoryItemMemoEdit
        '
        Me.SummaryRepositoryItemMemoEdit.LinesCount = 20
        Me.SummaryRepositoryItemMemoEdit.Name = "SummaryRepositoryItemMemoEdit"
        '
        'AbstractRepositoryItemMemoEdit
        '
        Me.AbstractRepositoryItemMemoEdit.LinesCount = 20
        Me.AbstractRepositoryItemMemoEdit.Name = "AbstractRepositoryItemMemoEdit"
        '
        'CommentsRepositoryItemMemoEdit
        '
        Me.CommentsRepositoryItemMemoEdit.LinesCount = 20
        Me.CommentsRepositoryItemMemoEdit.Name = "CommentsRepositoryItemMemoEdit"
        '
        'rowSurveyName
        '
        Me.rowSurveyName.Name = "rowSurveyName"
        Me.rowSurveyName.Properties.Caption = "Survey Name"
        Me.rowSurveyName.Properties.FieldName = "SurveyName"
        '
        'rowYear
        '
        Me.rowYear.Name = "rowYear"
        Me.rowYear.Properties.Caption = "Year"
        Me.rowYear.Properties.FieldName = "Year"
        '
        'rowSeason
        '
        Me.rowSeason.Name = "rowSeason"
        Me.rowSeason.Properties.Caption = "Season"
        Me.rowSeason.Properties.FieldName = "Season"
        '
        'rowPark
        '
        Me.rowPark.Name = "rowPark"
        Me.rowPark.Properties.Caption = "Park"
        Me.rowPark.Properties.FieldName = "Park"
        '
        'rowParkSubArea
        '
        Me.rowParkSubArea.Name = "rowParkSubArea"
        Me.rowParkSubArea.Properties.Caption = "Park Sub Area"
        Me.rowParkSubArea.Properties.FieldName = "ParkSubArea"
        '
        'rowMethodology
        '
        Me.rowMethodology.Name = "rowMethodology"
        Me.rowMethodology.Properties.Caption = "Methodology"
        Me.rowMethodology.Properties.FieldName = "Methodology"
        '
        'rowStartDate
        '
        Me.rowStartDate.Name = "rowStartDate"
        Me.rowStartDate.Properties.Caption = "Start Date"
        Me.rowStartDate.Properties.FieldName = "StartDate"
        '
        'rowEndDate
        '
        Me.rowEndDate.Name = "rowEndDate"
        Me.rowEndDate.Properties.Caption = "End Date"
        Me.rowEndDate.Properties.FieldName = "EndDate"
        '
        'StatisticsCategory
        '
        Me.StatisticsCategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowPopulationEstimate, Me.rowPopulationEstimateLowerCI, Me.rowPopulationEstimateUpperCI, Me.rowConfidenceInterval, Me.rowCalfCowRatio90, Me.CalfAdultrow, Me.rowBullCowRatio90, Me.rowEstimatedDensity_SqMi, Me.rowAreaSurveyed_mi, Me.rowAverageSearchEffort})
        Me.StatisticsCategory.Name = "StatisticsCategory"
        Me.StatisticsCategory.Properties.Caption = "Statistics"
        '
        'rowPopulationEstimate
        '
        Me.rowPopulationEstimate.Name = "rowPopulationEstimate"
        Me.rowPopulationEstimate.Properties.Caption = "Population Estimate"
        Me.rowPopulationEstimate.Properties.FieldName = "PopulationEstimate"
        '
        'rowPopulationEstimateLowerCI
        '
        Me.rowPopulationEstimateLowerCI.Name = "rowPopulationEstimateLowerCI"
        Me.rowPopulationEstimateLowerCI.Properties.Caption = "Population Estimate Lower CI"
        Me.rowPopulationEstimateLowerCI.Properties.FieldName = "PopulationEstimateLowerCI"
        '
        'rowPopulationEstimateUpperCI
        '
        Me.rowPopulationEstimateUpperCI.Name = "rowPopulationEstimateUpperCI"
        Me.rowPopulationEstimateUpperCI.Properties.Caption = "Population Estimate Upper CI"
        Me.rowPopulationEstimateUpperCI.Properties.FieldName = "PopulationEstimateUpperCI"
        '
        'rowConfidenceInterval
        '
        Me.rowConfidenceInterval.Name = "rowConfidenceInterval"
        Me.rowConfidenceInterval.Properties.Caption = "Confidence Interval"
        Me.rowConfidenceInterval.Properties.FieldName = "ConfidenceInterval"
        '
        'rowCalfCowRatio90
        '
        Me.rowCalfCowRatio90.Name = "rowCalfCowRatio90"
        Me.rowCalfCowRatio90.Properties.Caption = "Calf Cow Ratio90"
        Me.rowCalfCowRatio90.Properties.FieldName = "CalfCowRatio90"
        '
        'CalfAdultrow
        '
        Me.CalfAdultrow.Name = "CalfAdultrow"
        Me.CalfAdultrow.Properties.Caption = "Calf:Adult"
        Me.CalfAdultrow.Properties.FieldName = "CalfAdultRatio90"
        '
        'rowBullCowRatio90
        '
        Me.rowBullCowRatio90.Name = "rowBullCowRatio90"
        Me.rowBullCowRatio90.Properties.Caption = "Bull Cow Ratio90"
        Me.rowBullCowRatio90.Properties.FieldName = "BullCowRatio90"
        '
        'rowEstimatedDensity_SqMi
        '
        Me.rowEstimatedDensity_SqMi.Name = "rowEstimatedDensity_SqMi"
        Me.rowEstimatedDensity_SqMi.Properties.Caption = "Estimated Density_Sq Mi"
        Me.rowEstimatedDensity_SqMi.Properties.FieldName = "EstimatedDensity_SqMi"
        '
        'rowAreaSurveyed_mi
        '
        Me.rowAreaSurveyed_mi.Name = "rowAreaSurveyed_mi"
        Me.rowAreaSurveyed_mi.Properties.Caption = "Area Surveyed_mi"
        Me.rowAreaSurveyed_mi.Properties.FieldName = "AreaSurveyed_mi"
        '
        'rowAverageSearchEffort
        '
        Me.rowAverageSearchEffort.Name = "rowAverageSearchEffort"
        Me.rowAverageSearchEffort.Properties.Caption = "Average Search Effort"
        Me.rowAverageSearchEffort.Properties.FieldName = "AverageSearchEffort"
        '
        'OnlineResourcesCategory
        '
        Me.OnlineResourcesCategory.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.OnlineResourcesCategory.AppearanceHeader.Options.UseFont = True
        Me.OnlineResourcesCategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowProtocolReferenceCode, Me.rowProtocolVersion, Me.rowDeliverablesDatasetReferenceCode, Me.rowReportReferenceCode, Me.rowReportLink})
        Me.OnlineResourcesCategory.Name = "OnlineResourcesCategory"
        Me.OnlineResourcesCategory.Properties.Caption = "Online resources"
        '
        'rowProtocolReferenceCode
        '
        Me.rowProtocolReferenceCode.Name = "rowProtocolReferenceCode"
        Me.rowProtocolReferenceCode.Properties.Caption = "Protocol Reference Code"
        Me.rowProtocolReferenceCode.Properties.FieldName = "ProtocolReferenceCode"
        '
        'rowProtocolVersion
        '
        Me.rowProtocolVersion.Name = "rowProtocolVersion"
        Me.rowProtocolVersion.Properties.Caption = "Protocol Version"
        Me.rowProtocolVersion.Properties.FieldName = "ProtocolVersion"
        '
        'rowDeliverablesDatasetReferenceCode
        '
        Me.rowDeliverablesDatasetReferenceCode.Name = "rowDeliverablesDatasetReferenceCode"
        Me.rowDeliverablesDatasetReferenceCode.Properties.Caption = "Deliverables Dataset Reference Code"
        Me.rowDeliverablesDatasetReferenceCode.Properties.FieldName = "DeliverablesDatasetReferenceCode"
        '
        'rowReportReferenceCode
        '
        Me.rowReportReferenceCode.Name = "rowReportReferenceCode"
        Me.rowReportReferenceCode.Properties.Caption = "Report Reference Code"
        Me.rowReportReferenceCode.Properties.FieldName = "ReportReferenceCode"
        '
        'rowReportLink
        '
        Me.rowReportLink.Height = 47
        Me.rowReportLink.Name = "rowReportLink"
        Me.rowReportLink.Properties.Caption = "Report Link"
        Me.rowReportLink.Properties.FieldName = "ReportLink"
        '
        'rowPersonnel
        '
        Me.rowPersonnel.Height = 48
        Me.rowPersonnel.Name = "rowPersonnel"
        Me.rowPersonnel.Properties.Caption = "Personnel"
        Me.rowPersonnel.Properties.FieldName = "Personnel"
        '
        'rowAbstract
        '
        Me.rowAbstract.AppearanceCell.Options.UseTextOptions = True
        Me.rowAbstract.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowAbstract.Height = 127
        Me.rowAbstract.Name = "rowAbstract"
        Me.rowAbstract.Properties.Caption = "Abstract"
        Me.rowAbstract.Properties.FieldName = "Abstract"
        Me.rowAbstract.Properties.RowEdit = Me.AbstractRepositoryItemMemoEdit
        '
        'rowSummary
        '
        Me.rowSummary.AppearanceCell.Options.UseTextOptions = True
        Me.rowSummary.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowSummary.Height = 194
        Me.rowSummary.Name = "rowSummary"
        Me.rowSummary.Properties.Caption = "Summary"
        Me.rowSummary.Properties.FieldName = "Summary"
        Me.rowSummary.Properties.RowEdit = Me.SummaryRepositoryItemMemoEdit
        '
        'rowDatasetProcessingSteps
        '
        Me.rowDatasetProcessingSteps.AppearanceCell.Options.UseTextOptions = True
        Me.rowDatasetProcessingSteps.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowDatasetProcessingSteps.Height = 135
        Me.rowDatasetProcessingSteps.Name = "rowDatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.Caption = "Dataset Processing Steps"
        Me.rowDatasetProcessingSteps.Properties.FieldName = "DatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.RowEdit = Me.DatasetProcessingStepsRepositoryItemMemoEdit
        '
        'rowSurveyDatasetTitle
        '
        Me.rowSurveyDatasetTitle.Name = "rowSurveyDatasetTitle"
        Me.rowSurveyDatasetTitle.Properties.Caption = "Survey Dataset Title"
        Me.rowSurveyDatasetTitle.Properties.FieldName = "SurveyDatasetTitle"
        '
        'rowComments
        '
        Me.rowComments.AppearanceCell.Options.UseTextOptions = True
        Me.rowComments.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowComments.Height = 125
        Me.rowComments.Name = "rowComments"
        Me.rowComments.Properties.Caption = "Comments"
        Me.rowComments.Properties.FieldName = "Comments"
        Me.rowComments.Properties.RowEdit = Me.CommentsRepositoryItemMemoEdit
        '
        'MetadataCategory
        '
        Me.MetadataCategory.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MetadataCategory.AppearanceHeader.Options.UseFont = True
        Me.MetadataCategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowRecordInsertedDate, Me.rowRecordInsertedBy, Me.rowValidatedBy, Me.rowValidatedDate, Me.rowDataSource})
        Me.MetadataCategory.Name = "MetadataCategory"
        Me.MetadataCategory.Properties.Caption = "Metadata"
        '
        'rowRecordInsertedDate
        '
        Me.rowRecordInsertedDate.Name = "rowRecordInsertedDate"
        Me.rowRecordInsertedDate.Properties.Caption = "Record Inserted Date"
        Me.rowRecordInsertedDate.Properties.FieldName = "RecordInsertedDate"
        '
        'rowRecordInsertedBy
        '
        Me.rowRecordInsertedBy.Name = "rowRecordInsertedBy"
        Me.rowRecordInsertedBy.Properties.Caption = "Record Inserted By"
        Me.rowRecordInsertedBy.Properties.FieldName = "RecordInsertedBy"
        '
        'rowValidatedBy
        '
        Me.rowValidatedBy.Name = "rowValidatedBy"
        Me.rowValidatedBy.Properties.Caption = "Validated By"
        Me.rowValidatedBy.Properties.FieldName = "ValidatedBy"
        '
        'rowValidatedDate
        '
        Me.rowValidatedDate.Name = "rowValidatedDate"
        Me.rowValidatedDate.Properties.Caption = "Validated Date"
        Me.rowValidatedDate.Properties.FieldName = "ValidatedDate"
        Me.rowValidatedDate.Properties.RowEdit = Me.ValidatedDateRepositoryItemDateEdit
        '
        'rowDataSource
        '
        Me.rowDataSource.Name = "rowDataSource"
        Me.rowDataSource.Properties.Caption = "Data Source"
        Me.rowDataSource.Properties.FieldName = "DataSource"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadOnlyToolStripLabel, Me.ReadOnlyToolStripComboBox, Me.ToolStripSeparator10, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.OpenResourcesToolStripButton, Me.ToolStripSeparator2, Me.CertifySurveyToolStripButton, Me.ToolStripSeparator3, Me.RefreshDatasetToolStripButton, Me.ToolStripSeparator4, Me.AnalyticsToolStripDropDownButton, Me.ToolStripSeparator7, Me.ExportSurveyDataToolStripDropDownButton, Me.ToolStripSeparator8, Me.DigitalResourcesToolStripDropDownButton, Me.ToolStripSeparator9, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(21, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1635, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ReadOnlyToolStripLabel
        '
        Me.ReadOnlyToolStripLabel.Name = "ReadOnlyToolStripLabel"
        Me.ReadOnlyToolStripLabel.Size = New System.Drawing.Size(62, 22)
        Me.ReadOnlyToolStripLabel.Text = "Read only:"
        '
        'ReadOnlyToolStripComboBox
        '
        Me.ReadOnlyToolStripComboBox.Items.AddRange(New Object() {"False", "True"})
        Me.ReadOnlyToolStripComboBox.Name = "ReadOnlyToolStripComboBox"
        Me.ReadOnlyToolStripComboBox.Size = New System.Drawing.Size(75, 25)
        Me.ReadOnlyToolStripComboBox.Text = "True"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'OpenResourcesToolStripButton
        '
        Me.OpenResourcesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenResourcesToolStripButton.Image = CType(resources.GetObject("OpenResourcesToolStripButton.Image"), System.Drawing.Image)
        Me.OpenResourcesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenResourcesToolStripButton.Name = "OpenResourcesToolStripButton"
        Me.OpenResourcesToolStripButton.Size = New System.Drawing.Size(138, 22)
        Me.OpenResourcesToolStripButton.Text = "Open digital resources..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CertifySurveyToolStripButton
        '
        Me.CertifySurveyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CertifySurveyToolStripButton.Image = CType(resources.GetObject("CertifySurveyToolStripButton.Image"), System.Drawing.Image)
        Me.CertifySurveyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CertifySurveyToolStripButton.Name = "CertifySurveyToolStripButton"
        Me.CertifySurveyToolStripButton.Size = New System.Drawing.Size(144, 22)
        Me.CertifySurveyToolStripButton.Text = "Certify the current survey"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshDatasetToolStripButton
        '
        Me.RefreshDatasetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RefreshDatasetToolStripButton.Image = CType(resources.GetObject("RefreshDatasetToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshDatasetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshDatasetToolStripButton.Name = "RefreshDatasetToolStripButton"
        Me.RefreshDatasetToolStripButton.Size = New System.Drawing.Size(91, 22)
        Me.RefreshDatasetToolStripButton.Text = "Refresh dataset"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'AnalyticsToolStripDropDownButton
        '
        Me.AnalyticsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AnalyticsToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SurveyResultsToolStripMenuItem, Me.GSPEDatasetSummaryToolStripMenuItem, Me.QueryExplorerToolStripMenuItem})
        Me.AnalyticsToolStripDropDownButton.Image = CType(resources.GetObject("AnalyticsToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.AnalyticsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AnalyticsToolStripDropDownButton.Name = "AnalyticsToolStripDropDownButton"
        Me.AnalyticsToolStripDropDownButton.Size = New System.Drawing.Size(68, 22)
        Me.AnalyticsToolStripDropDownButton.Text = "Analytics"
        '
        'SurveyResultsToolStripMenuItem
        '
        Me.SurveyResultsToolStripMenuItem.Name = "SurveyResultsToolStripMenuItem"
        Me.SurveyResultsToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.SurveyResultsToolStripMenuItem.Text = "Summarize population estimates..."
        '
        'GSPEDatasetSummaryToolStripMenuItem
        '
        Me.GSPEDatasetSummaryToolStripMenuItem.Name = "GSPEDatasetSummaryToolStripMenuItem"
        Me.GSPEDatasetSummaryToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.GSPEDatasetSummaryToolStripMenuItem.Text = "Summarize GSPE dataset results...."
        '
        'QueryExplorerToolStripMenuItem
        '
        Me.QueryExplorerToolStripMenuItem.Name = "QueryExplorerToolStripMenuItem"
        Me.QueryExplorerToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.QueryExplorerToolStripMenuItem.Text = "Query explorer..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ExportSurveyDataToolStripDropDownButton
        '
        Me.ExportSurveyDataToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportSurveyDataToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem2, Me.CommaSeparatedValuesTextFileToolStripMenuItem2})
        Me.ExportSurveyDataToolStripDropDownButton.Image = CType(resources.GetObject("ExportSurveyDataToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.ExportSurveyDataToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportSurveyDataToolStripDropDownButton.Name = "ExportSurveyDataToolStripDropDownButton"
        Me.ExportSurveyDataToolStripDropDownButton.Size = New System.Drawing.Size(79, 22)
        Me.ExportSurveyDataToolStripDropDownButton.Text = "Export data"
        '
        'ExcelToolStripMenuItem2
        '
        Me.ExcelToolStripMenuItem2.Name = "ExcelToolStripMenuItem2"
        Me.ExcelToolStripMenuItem2.Size = New System.Drawing.Size(257, 22)
        Me.ExcelToolStripMenuItem2.Text = "Excel..."
        '
        'CommaSeparatedValuesTextFileToolStripMenuItem2
        '
        Me.CommaSeparatedValuesTextFileToolStripMenuItem2.Name = "CommaSeparatedValuesTextFileToolStripMenuItem2"
        Me.CommaSeparatedValuesTextFileToolStripMenuItem2.Size = New System.Drawing.Size(257, 22)
        Me.CommaSeparatedValuesTextFileToolStripMenuItem2.Text = "Comma separated values text file..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'DigitalResourcesToolStripDropDownButton
        '
        Me.DigitalResourcesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DigitalResourcesToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem, Me.OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem})
        Me.DigitalResourcesToolStripDropDownButton.Image = CType(resources.GetObject("DigitalResourcesToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.DigitalResourcesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DigitalResourcesToolStripDropDownButton.Name = "DigitalResourcesToolStripDropDownButton"
        Me.DigitalResourcesToolStripDropDownButton.Size = New System.Drawing.Size(107, 22)
        Me.DigitalResourcesToolStripDropDownButton.Text = "Digital resources"
        '
        'OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem
        '
        Me.OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Name = "OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem"
        Me.OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Text = "Open ARCN moose monitoring shared drive directory..."
        '
        'OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem
        '
        Me.OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Name = "OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem"
        Me.OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Text = "Open CAKN moose monitoring shared drive directory..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(59, 22)
        Me.HelpToolStripButton.Text = "Help (F1)"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.HeaderLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(21, 25)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1635, 61)
        Me.HeaderPanel.TabIndex = 2
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HeaderLabel.Location = New System.Drawing.Point(3, 6)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(1632, 74)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "HeaderLabel"
        '
        'ArcScaleNeedleComponent1
        '
        Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleNeedleComponent1.EndOffset = 8.0!
        Me.ArcScaleNeedleComponent1.Name = "needle"
        Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
        Me.ArcScaleNeedleComponent1.StartOffset = -6.0!
        Me.ArcScaleNeedleComponent1.ZOrder = -50
        '
        'ArcScaleComponent1
        '
        Me.ArcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
        Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent1.EndAngle = 60.0!
        ScaleLabel1.FormatString = ""
        ScaleLabel1.Name = "Label0"
        ScaleLabel1.Text = "{0}% certified"
        Me.ArcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel1})
        Me.ArcScaleComponent1.MajorTickmark.AllowTickOverlap = True
        Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -2.0!
        Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
        Me.ArcScaleComponent1.MajorTickmark.TextOffset = 18.0!
        Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent1.MaxValue = 100.0!
        Me.ArcScaleComponent1.MinorTickCount = 4
        Me.ArcScaleComponent1.MinorTickmark.ShapeOffset = 4.0!
        Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
        Me.ArcScaleComponent1.MinorTickmark.ShowTick = False
        Me.ArcScaleComponent1.Name = "scale1"
        ArcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9BBB59")
        ArcScaleRange1.EndThickness = 22.0!
        ArcScaleRange1.EndValue = 33.0!
        ArcScaleRange1.Name = "Range0"
        ArcScaleRange1.ShapeOffset = -4.0!
        ArcScaleRange1.StartThickness = 22.0!
        ArcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F4F56B")
        ArcScaleRange2.EndThickness = 22.0!
        ArcScaleRange2.EndValue = 66.0!
        ArcScaleRange2.Name = "Range1"
        ArcScaleRange2.ShapeOffset = -4.0!
        ArcScaleRange2.StartThickness = 22.0!
        ArcScaleRange2.StartValue = 33.0!
        ArcScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141")
        ArcScaleRange3.EndThickness = 22.0!
        ArcScaleRange3.EndValue = 100.0!
        ArcScaleRange3.Name = "Range2"
        ArcScaleRange3.ShapeOffset = -4.0!
        ArcScaleRange3.StartThickness = 22.0!
        ArcScaleRange3.StartValue = 66.0!
        Me.ArcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange1, ArcScaleRange2, ArcScaleRange3})
        Me.ArcScaleComponent1.StartAngle = -240.0!
        Me.ArcScaleComponent1.Value = 32.0!
        '
        'ArcScaleBackgroundLayerComponent1
        '
        Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleBackgroundLayerComponent1.Name = "bg"
        Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style27
        Me.ArcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(200.0!, 200.0!)
        Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'circularGauge12
        '
        Me.circularGauge12.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
        Me.circularGauge12.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent1})
        Me.circularGauge12.Bounds = New System.Drawing.Rectangle(6, 6, 111, 338)
        Me.circularGauge12.Name = "circularGauge12"
        Me.circularGauge12.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent1})
        Me.circularGauge12.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent1})
        '
        'ArcScaleRangeBarComponent1
        '
        Me.ArcScaleRangeBarComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleRangeBarComponent1.Name = "circularGauge12_RangeBar1"
        Me.ArcScaleRangeBarComponent1.ZOrder = -10
        '
        'GSPESurveysBindingSource
        '
        Me.GSPESurveysBindingSource.DataMember = "GSPE_Surveys"
        Me.GSPESurveysBindingSource.DataSource = Me.MooseDataSet
        '
        'MainDockManager
        '
        Me.MainDockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerBottom, Me.hideContainerLeft, Me.hideContainerRight})
        Me.MainDockManager.Form = Me
        Me.MainDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'hideContainerBottom
        '
        Me.hideContainerBottom.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerBottom.Controls.Add(Me.ResultsDockPanel)
        Me.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hideContainerBottom.Location = New System.Drawing.Point(21, 1040)
        Me.hideContainerBottom.Name = "hideContainerBottom"
        Me.hideContainerBottom.Size = New System.Drawing.Size(1635, 21)
        '
        'ResultsDockPanel
        '
        Me.ResultsDockPanel.Controls.Add(Me.ControlContainer1)
        Me.ResultsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.ResultsDockPanel.ID = New System.Guid("24e5cfc2-7b7f-4d74-a4d7-1e3391728b0b")
        Me.ResultsDockPanel.Location = New System.Drawing.Point(17, 438)
        Me.ResultsDockPanel.Name = "ResultsDockPanel"
        Me.ResultsDockPanel.Options.ShowCloseButton = False
        Me.ResultsDockPanel.OriginalSize = New System.Drawing.Size(200, 493)
        Me.ResultsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.ResultsDockPanel.SavedIndex = 1
        Me.ResultsDockPanel.Size = New System.Drawing.Size(1635, 493)
        Me.ResultsDockPanel.Text = "Results and analytics"
        Me.ResultsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.ResultsXtraTabControl)
        Me.ControlContainer1.Location = New System.Drawing.Point(3, 27)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(1629, 463)
        Me.ControlContainer1.TabIndex = 0
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerLeft.Controls.Add(Me.GSPE_SurveyDockPanel)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 0)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(21, 1061)
        '
        'GSPE_SurveyDockPanel
        '
        Me.GSPE_SurveyDockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.GSPE_SurveyDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.GSPE_SurveyDockPanel.ID = New System.Guid("7deb0775-2796-40ba-9ca1-5db2af94e419")
        Me.GSPE_SurveyDockPanel.Location = New System.Drawing.Point(17, 0)
        Me.GSPE_SurveyDockPanel.Name = "GSPE_SurveyDockPanel"
        Me.GSPE_SurveyDockPanel.OriginalSize = New System.Drawing.Size(600, 200)
        Me.GSPE_SurveyDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.GSPE_SurveyDockPanel.SavedIndex = 0
        Me.GSPE_SurveyDockPanel.Size = New System.Drawing.Size(600, 1040)
        Me.GSPE_SurveyDockPanel.Text = "Survey details"
        Me.GSPE_SurveyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GSPE_SurveyVGridControl)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(593, 1011)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerRight.Controls.Add(Me.ChartDockPanel)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(1656, 0)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(21, 1061)
        '
        'ChartDockPanel
        '
        Me.ChartDockPanel.Controls.Add(Me.ControlContainer2)
        Me.ChartDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.ChartDockPanel.ID = New System.Guid("93af393c-f2d8-47fa-b617-c92fc161dc19")
        Me.ChartDockPanel.Location = New System.Drawing.Point(227, 0)
        Me.ChartDockPanel.Name = "ChartDockPanel"
        Me.ChartDockPanel.Options.ShowCloseButton = False
        Me.ChartDockPanel.OriginalSize = New System.Drawing.Size(1372, 200)
        Me.ChartDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.ChartDockPanel.SavedIndex = 0
        Me.ChartDockPanel.Size = New System.Drawing.Size(1372, 1040)
        Me.ChartDockPanel.Text = "Population estimate"
        Me.ChartDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer2
        '
        Me.ControlContainer2.Controls.Add(Me.GSPE_SurveysChartControl)
        Me.ControlContainer2.Location = New System.Drawing.Point(4, 26)
        Me.ControlContainer2.Name = "ControlContainer2"
        Me.ControlContainer2.Size = New System.Drawing.Size(1365, 1011)
        Me.ControlContainer2.TabIndex = 0
        '
        'GSPE_SurveysChartControl
        '
        Me.GSPE_SurveysChartControl.DataSource = Me.GSPESurveysBindingSource
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.EnableAxisXScrolling = True
        XyDiagram2.EnableAxisXZooming = True
        XyDiagram2.EnableAxisYScrolling = True
        XyDiagram2.EnableAxisYZooming = True
        Me.GSPE_SurveysChartControl.Diagram = XyDiagram2
        Me.GSPE_SurveysChartControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GSPE_SurveysChartControl.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBoxAndMarker
        Me.GSPE_SurveysChartControl.Legend.MaxHorizontalPercentage = 30.0R
        Me.GSPE_SurveysChartControl.Legend.Name = "Default Legend"
        Me.GSPE_SurveysChartControl.Legend.Title.Text = "Park/Sub area"
        Me.GSPE_SurveysChartControl.Legend.Title.Visible = True
        Me.GSPE_SurveysChartControl.Location = New System.Drawing.Point(0, 0)
        Me.GSPE_SurveysChartControl.Name = "GSPE_SurveysChartControl"
        Me.GSPE_SurveysChartControl.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Multiple
        Me.GSPE_SurveysChartControl.SeriesDataMember = "ParkSubArea"
        Me.GSPE_SurveysChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.GSPE_SurveysChartControl.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.GSPE_SurveysChartControl.SeriesTemplate.ArgumentDataMember = "Year"
        Me.GSPE_SurveysChartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Me.GSPE_SurveysChartControl.SeriesTemplate.FilterString = "[PopulationEstimate] > 0"
        Me.GSPE_SurveysChartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.GSPE_SurveysChartControl.SeriesTemplate.SeriesDataMember = "ParkSubArea"
        Me.GSPE_SurveysChartControl.SeriesTemplate.ValueDataMembersSerializable = "PopulationEstimateLowerCI;PopulationEstimateUpperCI"
        Me.GSPE_SurveysChartControl.SeriesTemplate.View = OverlappedRangeBarSeriesView1
        Me.GSPE_SurveysChartControl.Size = New System.Drawing.Size(1365, 1011)
        Me.GSPE_SurveysChartControl.TabIndex = 0
        ChartTitle1.Text = "Moose Monitoring"
        Me.GSPE_SurveysChartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'GSPESurveysBindingSource1
        '
        Me.GSPESurveysBindingSource1.DataMember = "GSPE_Surveys"
        Me.GSPESurveysBindingSource1.DataSource = Me.MooseDataSet
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "C:\Work\Code\Moose Monitoring Database Application\Moose Monitoring Database Appl" &
    "ication\Moose Monitoring Database Application.chm"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1677, 1061)
        Me.Controls.Add(Me.GSPE_SurveyGridControl)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.hideContainerBottom)
        Me.Controls.Add(Me.hideContainerLeft)
        Me.Controls.Add(Me.hideContainerRight)
        Me.HelpButton = True
        Me.HelpProvider.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "MainForm"
        Me.HelpProvider.SetShowHelp(Me, True)
        Me.Text = "Moose"
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveyGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GSPE_SurveyContextMenuStrip.ResumeLayout(False)
        CType(Me.GSPE_SurveyGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidatedByRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetworkRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsXtraTabControl.ResumeLayout(False)
        Me.ResultsXtraTabPage.ResumeLayout(False)
        Me.ResultsXtraTabPage.PerformLayout()
        CType(Me.ResultsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsToolStrip.ResumeLayout(False)
        Me.ResultsToolStrip.PerformLayout()
        Me.ResultsPivotXtraTabPage.ResumeLayout(False)
        Me.ResultsPivotXtraTabPage.PerformLayout()
        CType(Me.ResultsPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsPivotChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsPivotToolStrip.ResumeLayout(False)
        Me.ResultsPivotToolStrip.PerformLayout()
        CType(Me.GSPE_SurveyVGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidatedDateRepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidatedDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetProcessingStepsRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SummaryRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbstractRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circularGauge12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerBottom.ResumeLayout(False)
        Me.ResultsDockPanel.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        Me.hideContainerLeft.ResumeLayout(False)
        Me.GSPE_SurveyDockPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.hideContainerRight.ResumeLayout(False)
        Me.ChartDockPanel.ResumeLayout(False)
        Me.ControlContainer2.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveysChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPESurveysBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MooseDataSet As MooseDataSet
    Friend WithEvents GSPE_SurveysBindingSource As BindingSource
    Friend WithEvents GSPE_SurveysTableAdapter As MooseDataSetTableAdapters.GSPE_SurveysTableAdapter
    Friend WithEvents TableAdapterManager As MooseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GSPETableAdapter As MooseDataSetTableAdapters.GSPETableAdapter
    Friend WithEvents GSPEBindingSource As BindingSource
    Friend WithEvents GSPE_SurveyVGridControl As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenResourcesToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CertifySurveyToolStripButton As ToolStripButton
    Friend WithEvents HeaderLabel As Label
    Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Friend WithEvents circularGauge12 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents GSPE_SurveyGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GSPE_SurveyGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSurveyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParkSubArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPopulationEstimate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConfidenceInterval As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPopulationEstimateUpperCI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPopulationEstimateLowerCI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedDensity_SqMi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAreaSurveyed_mi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAverageSearchEffort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonnel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportReferenceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliverablesDatasetReferenceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProtocolReferenceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurveyDatasetTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProtocolVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RefreshDatasetToolStripButton As ToolStripButton
    Friend WithEvents ResultsToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents SelectAQueryToolStripComboBox As ToolStripComboBox
    Friend WithEvents ResultsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents ResultsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ResultsPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ResultsPivotXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ResultsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ResultsView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GSPESurveysBindingSource As BindingSource
    Friend WithEvents ResultsPivotChartControl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AnalyticsToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents SurveyResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GSPEDatasetSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueryExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SeasonGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DatasourceGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents MethodologyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ValidatedDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ValidatedByColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportLinkGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ValidatedByRepositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BullCowGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CalfCowGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ValidatedDateRepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DatasetProcessingStepsRepositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents SummaryRepositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents AbstractRepositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents CommentsRepositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents CalfAdultGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResultsPivotToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents SelectAResultsPivotDatasourceToolStripComboBox As ToolStripComboBox
    Friend WithEvents SelectAResultsPivotDatasourceToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ExportPivotGridContentsToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesTextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportGridControlToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents ExcelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesTextFileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ExportSurveyDataToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents ExcelToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesTextFileToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents NetworkGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NetworkRepositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MainDockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents GSPE_SurveyDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents hideContainerBottom As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents ResultsDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents ChartDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer2 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GSPE_SurveysChartControl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GSPESurveysBindingSource1 As BindingSource
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents rowSurveyName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYear As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSeason As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPark As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowParkSubArea As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMethodology As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents StatisticsCategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowPopulationEstimate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimateLowerCI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimateUpperCI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowConfidenceInterval As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCalfCowRatio90 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents CalfAdultrow As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBullCowRatio90 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstimatedDensity_SqMi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAreaSurveyed_mi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAverageSearchEffort As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents OnlineResourcesCategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowProtocolReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProtocolVersion As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDeliverablesDatasetReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowReportReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowReportLink As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPersonnel As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAbstract As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSummary As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDatasetProcessingSteps As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSurveyDatasetTitle As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComments As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents MetadataCategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowRecordInsertedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowValidatedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowValidatedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDataSource As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents GSPE_SurveyContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents DigitalResourcesToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSharedDriveDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenARCNMooseMonitoringDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenCAKNMooseMonitoringDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ReadOnlyToolStripLabel As ToolStripLabel
    Friend WithEvents ReadOnlyToolStripComboBox As ToolStripComboBox
    Friend WithEvents ValidateThisSurveyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertifyThisSurveyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider As HelpProvider
    Friend WithEvents HelpToolStripButton As ToolStripButton
End Class
