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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue6 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue7 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule8 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue8 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim OverlappedRangeBarSeriesView2 As DevExpress.XtraCharts.OverlappedRangeBarSeriesView = New DevExpress.XtraCharts.OverlappedRangeBarSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim ScaleLabel2 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ArcScaleRange4 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange5 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange6 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportPivotGridContentsToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValuesTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.GSPE_SurveysChartControl = New DevExpress.XtraCharts.ChartControl()
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
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ReadOnlyToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ReadOnlyToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.EstimatesDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer3 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.EstimatesVGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.MethodologyRepositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.rowSurveyName1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMethodology1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimate1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimateUpperCI1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimateLowerCI1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowConfidenceInterval1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAreaSurveyed_mi1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstimatedDensity_SqMi1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAverageSearchEffort1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBullCowRatio901 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCalfCowRatio901 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCalfAdultRatio90 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.MSChartDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PopulationEstimateChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer4 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
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
        Me.rowComments = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSurveyDatasetTitle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.MetadataCategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowDataSource = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowValidatedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowValidatedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
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
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsPivotToolStrip.SuspendLayout()
        Me.ChartXtraTabPage.SuspendLayout()
        CType(Me.GSPE_SurveysChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedRangeBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MainToolStrip.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circularGauge12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerBottom.SuspendLayout()
        Me.ResultsDockPanel.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        Me.hideContainerLeft.SuspendLayout()
        Me.GSPE_SurveyDockPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.hideContainerRight.SuspendLayout()
        Me.ChartDockPanel.SuspendLayout()
        Me.EstimatesDockPanel.SuspendLayout()
        Me.ControlContainer3.SuspendLayout()
        CType(Me.EstimatesVGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MethodologyRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSChartDockPanel.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.PopulationEstimateChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
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
        GridLevelNode2.RelationName = "FK_GSPE_GSPE_Surveys1"
        Me.GSPE_SurveyGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GSPE_SurveyGridControl.Location = New System.Drawing.Point(17, 68)
        Me.GSPE_SurveyGridControl.MainView = Me.GSPE_SurveyGridView
        Me.GSPE_SurveyGridControl.Name = "GSPE_SurveyGridControl"
        Me.GSPE_SurveyGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit6, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit7, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemDateEdit4, Me.ValidatedByRepositoryItemComboBox, Me.NetworkRepositoryItemComboBox})
        Me.HelpProvider.SetShowHelp(Me.GSPE_SurveyGridControl, True)
        Me.GSPE_SurveyGridControl.Size = New System.Drawing.Size(2062, 1241)
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
        GridFormatRule5.Column = Me.colReportReferenceCode
        GridFormatRule5.Name = "ReportReferenceCode_NULL_Format"
        FormatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue5.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue5.Value1 = "0"
        GridFormatRule5.Rule = FormatConditionRuleValue5
        GridFormatRule6.Column = Me.colDeliverablesDatasetReferenceCode
        GridFormatRule6.ColumnApplyTo = Me.colDeliverablesDatasetReferenceCode
        GridFormatRule6.Name = "DeliverablesNULLFormat"
        FormatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue6.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue6.Value1 = "0"
        GridFormatRule6.Rule = FormatConditionRuleValue6
        GridFormatRule7.Column = Me.colProtocolReferenceCode
        GridFormatRule7.Name = "ProtocolNULLFormat"
        FormatConditionRuleValue7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue7.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue7.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue7.Value1 = "0"
        GridFormatRule7.Rule = FormatConditionRuleValue7
        GridFormatRule8.Column = Me.ValidatedDateGridColumn
        GridFormatRule8.ColumnApplyTo = Me.colSurveyName
        GridFormatRule8.Name = "ValidatedFormat"
        FormatConditionRuleValue8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue8.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue8.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue8.Value1 = New Date(1900, 3, 2, 12, 14, 13, 0)
        GridFormatRule8.Rule = FormatConditionRuleValue8
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule5)
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule6)
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule7)
        Me.GSPE_SurveyGridView.FormatRules.Add(GridFormatRule8)
        Me.GSPE_SurveyGridView.GridControl = Me.GSPE_SurveyGridControl
        Me.GSPE_SurveyGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "PopulationEstimate", Nothing, "(Population Estimate: AVG={0:0.##})")})
        Me.GSPE_SurveyGridView.Name = "GSPE_SurveyGridView"
        Me.GSPE_SurveyGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GSPE_SurveyGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GSPE_SurveyGridView.OptionsView.ColumnAutoWidth = False
        Me.GSPE_SurveyGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GSPE_SurveyGridView.OptionsView.ShowFooter = True
        Me.GSPE_SurveyGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSurveyName, DevExpress.Data.ColumnSortOrder.Descending)})
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
        Me.ResultsXtraTabControl.Size = New System.Drawing.Size(1629, 571)
        Me.ResultsXtraTabControl.TabIndex = 5
        Me.ResultsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.ResultsXtraTabPage, Me.ResultsPivotXtraTabPage, Me.ChartXtraTabPage})
        '
        'ResultsXtraTabPage
        '
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsGridControl)
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsToolStrip)
        Me.ResultsXtraTabPage.Name = "ResultsXtraTabPage"
        Me.ResultsXtraTabPage.Size = New System.Drawing.Size(1627, 546)
        Me.ResultsXtraTabPage.Text = "Data and queries viewer"
        '
        'ResultsGridControl
        '
        Me.ResultsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ResultsGridControl.MainView = Me.ResultsView
        Me.ResultsGridControl.Name = "ResultsGridControl"
        Me.ResultsGridControl.Size = New System.Drawing.Size(1627, 521)
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripLabel1.Text = "Request a data table or query results:"
        '
        'SelectAQueryToolStripComboBox
        '
        Me.SelectAQueryToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.ExportGridControlToolStripDropDownButton.Size = New System.Drawing.Size(95, 22)
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
        Me.ResultsPivotXtraTabPage.Size = New System.Drawing.Size(1627, 546)
        Me.ResultsPivotXtraTabPage.Text = "Pivot chart builder"
        '
        'ResultsPivotGridControl
        '
        Me.ResultsPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsPivotGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ResultsPivotGridControl.Name = "ResultsPivotGridControl"
        Me.ResultsPivotGridControl.Size = New System.Drawing.Size(1627, 521)
        Me.ResultsPivotGridControl.TabIndex = 4
        '
        'ResultsPivotChartControl
        '
        Me.ResultsPivotChartControl.DataSource = Me.ResultsPivotGridControl
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        Me.ResultsPivotChartControl.Diagram = XyDiagram3
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
        Me.ResultsPivotChartControl.Size = New System.Drawing.Size(1627, 521)
        Me.ResultsPivotChartControl.TabIndex = 5
        '
        'ResultsPivotToolStrip
        '
        Me.ResultsPivotToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ResultsPivotToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.SelectAResultsPivotDatasourceToolStripComboBox, Me.ToolStripSeparator5, Me.ExportPivotGridContentsToolStripDropDownButton})
        Me.ResultsPivotToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ResultsPivotToolStrip.Name = "ResultsPivotToolStrip"
        Me.ResultsPivotToolStrip.Size = New System.Drawing.Size(1627, 25)
        Me.ResultsPivotToolStrip.TabIndex = 6
        Me.ResultsPivotToolStrip.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripLabel2.Text = "Request a data table or query results:"
        '
        'SelectAResultsPivotDatasourceToolStripComboBox
        '
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Name = "SelectAResultsPivotDatasourceToolStripComboBox"
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Size = New System.Drawing.Size(121, 25)
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
        Me.ExportPivotGridContentsToolStripDropDownButton.Size = New System.Drawing.Size(107, 22)
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
        'ChartXtraTabPage
        '
        Me.ChartXtraTabPage.Controls.Add(Me.GSPE_SurveysChartControl)
        Me.ChartXtraTabPage.Name = "ChartXtraTabPage"
        Me.ChartXtraTabPage.Size = New System.Drawing.Size(1627, 546)
        Me.ChartXtraTabPage.Text = "Population estimate chart"
        '
        'GSPE_SurveysChartControl
        '
        Me.GSPE_SurveysChartControl.DataSource = Me.GSPE_SurveysBindingSource
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram4.EnableAxisXScrolling = True
        XyDiagram4.EnableAxisXZooming = True
        XyDiagram4.EnableAxisYScrolling = True
        XyDiagram4.EnableAxisYZooming = True
        Me.GSPE_SurveysChartControl.Diagram = XyDiagram4
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
        Me.GSPE_SurveysChartControl.SeriesTemplate.View = OverlappedRangeBarSeriesView2
        Me.GSPE_SurveysChartControl.Size = New System.Drawing.Size(1627, 546)
        Me.GSPE_SurveysChartControl.TabIndex = 1
        ChartTitle2.Text = "Moose Monitoring"
        Me.GSPE_SurveysChartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'GSPE_SurveyVGridControl
        '
        Me.GSPE_SurveyVGridControl.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GSPE_SurveyVGridControl.Appearance.RecordValue.Options.UseFont = True
        Me.GSPE_SurveyVGridControl.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.GSPE_SurveyVGridControl.Appearance.RowHeaderPanel.Options.UseFont = True
        Me.GSPE_SurveyVGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GSPE_SurveyVGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.GSPE_SurveyVGridControl.DataSource = Me.GSPE_SurveysBindingSource
        Me.GSPE_SurveyVGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GSPE_SurveyVGridControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSPE_SurveyVGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.GSPE_SurveyVGridControl.Location = New System.Drawing.Point(0, 0)
        Me.GSPE_SurveyVGridControl.Name = "GSPE_SurveyVGridControl"
        Me.GSPE_SurveyVGridControl.RecordWidth = 135
        Me.GSPE_SurveyVGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5, Me.RepositoryItemDateEdit5, Me.ValidatedDateRepositoryItemDateEdit, Me.DatasetProcessingStepsRepositoryItemMemoEdit, Me.SummaryRepositoryItemMemoEdit, Me.AbstractRepositoryItemMemoEdit, Me.CommentsRepositoryItemMemoEdit})
        Me.GSPE_SurveyVGridControl.RowHeaderWidth = 65
        Me.GSPE_SurveyVGridControl.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSurveyName, Me.rowYear, Me.rowSeason, Me.rowPark, Me.rowParkSubArea, Me.rowMethodology, Me.rowStartDate, Me.rowEndDate, Me.StatisticsCategory, Me.OnlineResourcesCategory, Me.rowPersonnel, Me.rowAbstract, Me.rowSummary, Me.rowDatasetProcessingSteps, Me.rowComments, Me.rowSurveyDatasetTitle, Me.MetadataCategory})
        Me.GSPE_SurveyVGridControl.Size = New System.Drawing.Size(593, 1276)
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
        'MainToolStrip
        '
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadOnlyToolStripLabel, Me.ReadOnlyToolStripComboBox, Me.ToolStripSeparator10, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.RefreshDatasetToolStripButton, Me.ToolStripSeparator4, Me.AnalyticsToolStripDropDownButton, Me.ToolStripSeparator7, Me.ExportSurveyDataToolStripDropDownButton, Me.ToolStripSeparator8, Me.DigitalResourcesToolStripDropDownButton, Me.ToolStripSeparator9, Me.HelpToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(17, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(2062, 25)
        Me.MainToolStrip.TabIndex = 1
        Me.MainToolStrip.Text = "Survey:"
        '
        'ReadOnlyToolStripLabel
        '
        Me.ReadOnlyToolStripLabel.Name = "ReadOnlyToolStripLabel"
        Me.ReadOnlyToolStripLabel.Size = New System.Drawing.Size(62, 22)
        Me.ReadOnlyToolStripLabel.Text = "Read only:"
        '
        'ReadOnlyToolStripComboBox
        '
        Me.ReadOnlyToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.DigitalResourcesToolStripDropDownButton.Size = New System.Drawing.Size(155, 22)
        Me.DigitalResourcesToolStripDropDownButton.Text = "I&M Network shared drives"
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
        Me.HeaderPanel.Location = New System.Drawing.Point(17, 25)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(2062, 43)
        Me.HeaderPanel.TabIndex = 2
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HeaderLabel.Location = New System.Drawing.Point(3, 6)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(2059, 74)
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
        ScaleLabel2.FormatString = ""
        ScaleLabel2.Name = "Label0"
        ScaleLabel2.Text = "{0}% certified"
        Me.ArcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel2})
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
        ArcScaleRange4.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9BBB59")
        ArcScaleRange4.EndThickness = 22.0!
        ArcScaleRange4.EndValue = 33.0!
        ArcScaleRange4.Name = "Range0"
        ArcScaleRange4.ShapeOffset = -4.0!
        ArcScaleRange4.StartThickness = 22.0!
        ArcScaleRange5.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F4F56B")
        ArcScaleRange5.EndThickness = 22.0!
        ArcScaleRange5.EndValue = 66.0!
        ArcScaleRange5.Name = "Range1"
        ArcScaleRange5.ShapeOffset = -4.0!
        ArcScaleRange5.StartThickness = 22.0!
        ArcScaleRange5.StartValue = 33.0!
        ArcScaleRange6.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141")
        ArcScaleRange6.EndThickness = 22.0!
        ArcScaleRange6.EndValue = 100.0!
        ArcScaleRange6.Name = "Range2"
        ArcScaleRange6.ShapeOffset = -4.0!
        ArcScaleRange6.StartThickness = 22.0!
        ArcScaleRange6.StartValue = 66.0!
        Me.ArcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange4, ArcScaleRange5, ArcScaleRange6})
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
        'MainDockManager
        '
        Me.MainDockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerBottom, Me.hideContainerLeft, Me.hideContainerRight})
        Me.MainDockManager.Form = Me
        Me.MainDockManager.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.MainDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'hideContainerBottom
        '
        Me.hideContainerBottom.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerBottom.Controls.Add(Me.ResultsDockPanel)
        Me.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hideContainerBottom.Location = New System.Drawing.Point(17, 1309)
        Me.hideContainerBottom.Name = "hideContainerBottom"
        Me.hideContainerBottom.Size = New System.Drawing.Size(2062, 17)
        '
        'ResultsDockPanel
        '
        Me.ResultsDockPanel.Controls.Add(Me.ControlContainer1)
        Me.ResultsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.ResultsDockPanel.ID = New System.Guid("24e5cfc2-7b7f-4d74-a4d7-1e3391728b0b")
        Me.ResultsDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.ResultsDockPanel.Name = "ResultsDockPanel"
        Me.ResultsDockPanel.Options.ShowCloseButton = False
        Me.ResultsDockPanel.OriginalSize = New System.Drawing.Size(200, 601)
        Me.ResultsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.ResultsDockPanel.SavedIndex = 1
        Me.ResultsDockPanel.Size = New System.Drawing.Size(1635, 601)
        Me.ResultsDockPanel.Text = "Results and analytics"
        Me.ResultsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.ResultsXtraTabControl)
        Me.ControlContainer1.Location = New System.Drawing.Point(3, 27)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(1629, 571)
        Me.ControlContainer1.TabIndex = 0
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerLeft.Controls.Add(Me.GSPE_SurveyDockPanel)
        Me.hideContainerLeft.Controls.Add(Me.EstimatesDockPanel)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 0)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(17, 1326)
        '
        'GSPE_SurveyDockPanel
        '
        Me.GSPE_SurveyDockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.GSPE_SurveyDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.GSPE_SurveyDockPanel.ID = New System.Guid("7deb0775-2796-40ba-9ca1-5db2af94e419")
        Me.GSPE_SurveyDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.GSPE_SurveyDockPanel.Name = "GSPE_SurveyDockPanel"
        Me.GSPE_SurveyDockPanel.OriginalSize = New System.Drawing.Size(600, 200)
        Me.GSPE_SurveyDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.GSPE_SurveyDockPanel.SavedIndex = 0
        Me.GSPE_SurveyDockPanel.Size = New System.Drawing.Size(600, 1305)
        Me.GSPE_SurveyDockPanel.Text = "Survey details"
        Me.GSPE_SurveyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GSPE_SurveyVGridControl)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(593, 1276)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.SystemColors.Control
        Me.hideContainerRight.Controls.Add(Me.ChartDockPanel)
        Me.hideContainerRight.Controls.Add(Me.MSChartDockPanel)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(2079, 0)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(17, 1326)
        '
        'ChartDockPanel
        '
        Me.ChartDockPanel.Controls.Add(Me.ControlContainer2)
        Me.ChartDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.ChartDockPanel.ID = New System.Guid("93af393c-f2d8-47fa-b617-c92fc161dc19")
        Me.ChartDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.ChartDockPanel.Name = "ChartDockPanel"
        Me.ChartDockPanel.Options.ShowCloseButton = False
        Me.ChartDockPanel.OriginalSize = New System.Drawing.Size(1372, 200)
        Me.ChartDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.ChartDockPanel.SavedIndex = 0
        Me.ChartDockPanel.Size = New System.Drawing.Size(1372, 1040)
        Me.ChartDockPanel.Text = "Population estimate chart"
        Me.ChartDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer2
        '
        Me.ControlContainer2.Location = New System.Drawing.Point(4, 26)
        Me.ControlContainer2.Name = "ControlContainer2"
        Me.ControlContainer2.Size = New System.Drawing.Size(1365, 1011)
        Me.ControlContainer2.TabIndex = 0
        '
        'EstimatesDockPanel
        '
        Me.EstimatesDockPanel.Controls.Add(Me.ControlContainer3)
        Me.EstimatesDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.EstimatesDockPanel.ID = New System.Guid("44b4ab5a-e5e9-443c-8ed2-8ef5f96e5c54")
        Me.EstimatesDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.EstimatesDockPanel.Name = "EstimatesDockPanel"
        Me.EstimatesDockPanel.OriginalSize = New System.Drawing.Size(257, 200)
        Me.EstimatesDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.EstimatesDockPanel.SavedIndex = 0
        Me.EstimatesDockPanel.Size = New System.Drawing.Size(257, 1305)
        Me.EstimatesDockPanel.Text = "Estimates"
        Me.EstimatesDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer3
        '
        Me.ControlContainer3.Controls.Add(Me.EstimatesVGridControl)
        Me.ControlContainer3.Location = New System.Drawing.Point(3, 26)
        Me.ControlContainer3.Name = "ControlContainer3"
        Me.ControlContainer3.Size = New System.Drawing.Size(250, 1276)
        Me.ControlContainer3.TabIndex = 0
        '
        'EstimatesVGridControl
        '
        Me.EstimatesVGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.EstimatesVGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.EstimatesVGridControl.DataSource = Me.GSPE_SurveysBindingSource
        Me.EstimatesVGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EstimatesVGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.EstimatesVGridControl.Location = New System.Drawing.Point(0, 0)
        Me.EstimatesVGridControl.Name = "EstimatesVGridControl"
        Me.EstimatesVGridControl.RecordWidth = 59
        Me.EstimatesVGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.MethodologyRepositoryItemComboBox})
        Me.EstimatesVGridControl.RowHeaderWidth = 141
        Me.EstimatesVGridControl.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSurveyName1, Me.rowMethodology1, Me.rowPopulationEstimate1, Me.rowPopulationEstimateUpperCI1, Me.rowPopulationEstimateLowerCI1, Me.rowConfidenceInterval1, Me.rowAreaSurveyed_mi1, Me.rowEstimatedDensity_SqMi1, Me.rowAverageSearchEffort1, Me.rowBullCowRatio901, Me.rowCalfCowRatio901, Me.rowCalfAdultRatio90})
        Me.EstimatesVGridControl.Size = New System.Drawing.Size(250, 1276)
        Me.EstimatesVGridControl.TabIndex = 0
        '
        'MethodologyRepositoryItemComboBox
        '
        Me.MethodologyRepositoryItemComboBox.AutoHeight = False
        Me.MethodologyRepositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MethodologyRepositoryItemComboBox.Items.AddRange(New Object() {"", "GSPE", "Gasaway"})
        Me.MethodologyRepositoryItemComboBox.Name = "MethodologyRepositoryItemComboBox"
        '
        'rowSurveyName1
        '
        Me.rowSurveyName1.Name = "rowSurveyName1"
        Me.rowSurveyName1.Properties.AllowEdit = False
        Me.rowSurveyName1.Properties.Caption = "Survey Name"
        Me.rowSurveyName1.Properties.FieldName = "SurveyName"
        '
        'rowMethodology1
        '
        Me.rowMethodology1.Name = "rowMethodology1"
        Me.rowMethodology1.Properties.Caption = "Methodology"
        Me.rowMethodology1.Properties.FieldName = "Methodology"
        Me.rowMethodology1.Properties.RowEdit = Me.MethodologyRepositoryItemComboBox
        '
        'rowPopulationEstimate1
        '
        Me.rowPopulationEstimate1.Name = "rowPopulationEstimate1"
        Me.rowPopulationEstimate1.Properties.Caption = "Population Estimate"
        Me.rowPopulationEstimate1.Properties.FieldName = "PopulationEstimate"
        '
        'rowPopulationEstimateUpperCI1
        '
        Me.rowPopulationEstimateUpperCI1.Name = "rowPopulationEstimateUpperCI1"
        Me.rowPopulationEstimateUpperCI1.Properties.Caption = "Population Estimate Upper CI"
        Me.rowPopulationEstimateUpperCI1.Properties.FieldName = "PopulationEstimateUpperCI"
        '
        'rowPopulationEstimateLowerCI1
        '
        Me.rowPopulationEstimateLowerCI1.Name = "rowPopulationEstimateLowerCI1"
        Me.rowPopulationEstimateLowerCI1.Properties.Caption = "Population Estimate Lower CI"
        Me.rowPopulationEstimateLowerCI1.Properties.FieldName = "PopulationEstimateLowerCI"
        '
        'rowConfidenceInterval1
        '
        Me.rowConfidenceInterval1.Name = "rowConfidenceInterval1"
        Me.rowConfidenceInterval1.Properties.Caption = "Confidence Interval"
        Me.rowConfidenceInterval1.Properties.FieldName = "ConfidenceInterval"
        '
        'rowAreaSurveyed_mi1
        '
        Me.rowAreaSurveyed_mi1.Name = "rowAreaSurveyed_mi1"
        Me.rowAreaSurveyed_mi1.Properties.Caption = "Area Surveyed_mi"
        Me.rowAreaSurveyed_mi1.Properties.FieldName = "AreaSurveyed_mi"
        '
        'rowEstimatedDensity_SqMi1
        '
        Me.rowEstimatedDensity_SqMi1.Name = "rowEstimatedDensity_SqMi1"
        Me.rowEstimatedDensity_SqMi1.Properties.Caption = "Estimated Density_Sq Mi"
        Me.rowEstimatedDensity_SqMi1.Properties.FieldName = "EstimatedDensity_SqMi"
        '
        'rowAverageSearchEffort1
        '
        Me.rowAverageSearchEffort1.Name = "rowAverageSearchEffort1"
        Me.rowAverageSearchEffort1.Properties.Caption = "Average Search Effort"
        Me.rowAverageSearchEffort1.Properties.FieldName = "AverageSearchEffort"
        '
        'rowBullCowRatio901
        '
        Me.rowBullCowRatio901.Name = "rowBullCowRatio901"
        Me.rowBullCowRatio901.Properties.Caption = "Bull Cow Ratio90"
        Me.rowBullCowRatio901.Properties.FieldName = "BullCowRatio90"
        '
        'rowCalfCowRatio901
        '
        Me.rowCalfCowRatio901.Name = "rowCalfCowRatio901"
        Me.rowCalfCowRatio901.Properties.Caption = "Calf Cow Ratio90"
        Me.rowCalfCowRatio901.Properties.FieldName = "CalfCowRatio90"
        '
        'rowCalfAdultRatio90
        '
        Me.rowCalfAdultRatio90.Name = "rowCalfAdultRatio90"
        Me.rowCalfAdultRatio90.Properties.Caption = "Calf Adult Ratio90"
        Me.rowCalfAdultRatio90.Properties.FieldName = "CalfAdultRatio90"
        '
        'MSChartDockPanel
        '
        Me.MSChartDockPanel.Controls.Add(Me.DockPanel3_Container)
        Me.MSChartDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.MSChartDockPanel.ID = New System.Guid("fce63231-255d-4afa-bd92-40e4bffe83bd")
        Me.MSChartDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.MSChartDockPanel.Name = "MSChartDockPanel"
        Me.MSChartDockPanel.OriginalSize = New System.Drawing.Size(970, 200)
        Me.MSChartDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.MSChartDockPanel.SavedIndex = 0
        Me.MSChartDockPanel.Size = New System.Drawing.Size(970, 1305)
        Me.MSChartDockPanel.Text = "Chart"
        Me.MSChartDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.PopulationEstimateChart)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(963, 1276)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'PopulationEstimateChart
        '
        ChartArea2.Name = "PopulationEstimateChartArea"
        Me.PopulationEstimateChart.ChartAreas.Add(ChartArea2)
        Me.PopulationEstimateChart.DataSource = Me.GSPE_SurveysBindingSource
        Me.PopulationEstimateChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.PopulationEstimateChart.Legends.Add(Legend2)
        Me.PopulationEstimateChart.Location = New System.Drawing.Point(0, 0)
        Me.PopulationEstimateChart.Name = "PopulationEstimateChart"
        Series2.ChartArea = "PopulationEstimateChartArea"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.LegendText = "Population estimate"
        Series2.Name = "PopulationEstimateSeries"
        Series2.XValueMember = "Year"
        Series2.YValueMembers = "PopulationEstimate, PopulationEstimateUpperCI, PopulationEstimateLowerCI"
        Series2.YValuesPerPoint = 4
        Me.PopulationEstimateChart.Series.Add(Series2)
        Me.PopulationEstimateChart.Size = New System.Drawing.Size(963, 1276)
        Me.PopulationEstimateChart.TabIndex = 0
        Me.PopulationEstimateChart.Text = "Moose Monitoring Population Estimate"
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.ControlContainer4)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("59e0e582-a614-42a3-a364-072261f18655")
        Me.DockPanel1.Location = New System.Drawing.Point(1456, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(200, 1040)
        Me.DockPanel1.Text = "DockPanel1"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer4
        '
        Me.ControlContainer4.Location = New System.Drawing.Point(4, 26)
        Me.ControlContainer4.Name = "ControlContainer4"
        Me.ControlContainer4.Size = New System.Drawing.Size(193, 1011)
        Me.ControlContainer4.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("5071d43f-197c-4c89-8037-0544d721bfd2")
        Me.DockPanel2.Location = New System.Drawing.Point(1456, 0)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.SavedIndex = 0
        Me.DockPanel2.Size = New System.Drawing.Size(200, 1040)
        Me.DockPanel2.Text = "DockPanel2"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 1011)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "C:\Work\Code\Moose Monitoring Database Application\Moose Monitoring Database Appl" &
    "ication\Moose Monitoring Database Application.chm"
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
        Me.rowSummary.Height = 390
        Me.rowSummary.Name = "rowSummary"
        Me.rowSummary.Properties.Caption = "Summary"
        Me.rowSummary.Properties.FieldName = "Summary"
        Me.rowSummary.Properties.RowEdit = Me.SummaryRepositoryItemMemoEdit
        '
        'rowDatasetProcessingSteps
        '
        Me.rowDatasetProcessingSteps.AppearanceCell.Options.UseTextOptions = True
        Me.rowDatasetProcessingSteps.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowDatasetProcessingSteps.Height = 471
        Me.rowDatasetProcessingSteps.Name = "rowDatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.Caption = "Dataset Processing Steps"
        Me.rowDatasetProcessingSteps.Properties.FieldName = "DatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.RowEdit = Me.DatasetProcessingStepsRepositoryItemMemoEdit
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
        'rowSurveyDatasetTitle
        '
        Me.rowSurveyDatasetTitle.Name = "rowSurveyDatasetTitle"
        Me.rowSurveyDatasetTitle.Properties.Caption = "Survey Dataset Title"
        Me.rowSurveyDatasetTitle.Properties.FieldName = "SurveyDatasetTitle"
        '
        'MetadataCategory
        '
        Me.MetadataCategory.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MetadataCategory.AppearanceHeader.Options.UseFont = True
        Me.MetadataCategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowDataSource, Me.rowRecordInsertedDate, Me.rowRecordInsertedBy, Me.rowValidatedBy, Me.rowValidatedDate})
        Me.MetadataCategory.Name = "MetadataCategory"
        Me.MetadataCategory.Properties.Caption = "Metadata"
        '
        'rowDataSource
        '
        Me.rowDataSource.Name = "rowDataSource"
        Me.rowDataSource.Properties.Caption = "Data Source"
        Me.rowDataSource.Properties.FieldName = "DataSource"
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2096, 1326)
        Me.Controls.Add(Me.GSPE_SurveyGridControl)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.MainToolStrip)
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
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsPivotChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsPivotToolStrip.ResumeLayout(False)
        Me.ResultsPivotToolStrip.PerformLayout()
        Me.ChartXtraTabPage.ResumeLayout(False)
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedRangeBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveysChartControl, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circularGauge12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerBottom.ResumeLayout(False)
        Me.ResultsDockPanel.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        Me.hideContainerLeft.ResumeLayout(False)
        Me.GSPE_SurveyDockPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.hideContainerRight.ResumeLayout(False)
        Me.ChartDockPanel.ResumeLayout(False)
        Me.EstimatesDockPanel.ResumeLayout(False)
        Me.ControlContainer3.ResumeLayout(False)
        CType(Me.EstimatesVGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MethodologyRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSChartDockPanel.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.PopulationEstimateChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
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
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
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
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
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
    Friend WithEvents EstimatesDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer3 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EstimatesVGridControl As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents MethodologyRepositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rowSurveyName1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMethodology1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimate1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimateUpperCI1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimateLowerCI1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowConfidenceInterval1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAreaSurveyed_mi1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstimatedDensity_SqMi1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAverageSearchEffort1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBullCowRatio901 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCalfCowRatio901 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCalfAdultRatio90 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer4 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents MSChartDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PopulationEstimateChart As DataVisualization.Charting.Chart
    Friend WithEvents ChartXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GSPE_SurveysChartControl As DevExpress.XtraCharts.ChartControl
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
    Friend WithEvents rowComments As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSurveyDatasetTitle As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents MetadataCategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowDataSource As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowValidatedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowValidatedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class
