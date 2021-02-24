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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ArcScaleRange1 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange2 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange3 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Me.colReportReferenceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliverablesDatasetReferenceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProtocolReferenceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MooseDataSet = New Moose_Monitoring_Database_Application.MooseDataSet()
        Me.GSPE_SurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_SurveysTableAdapter = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.GSPE_SurveysTableAdapter()
        Me.TableAdapterManager = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.TableAdapterManager()
        Me.GSPETableAdapter = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.GSPETableAdapter()
        Me.GSPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rowSurveyName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYear = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowParkSubArea = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowConfidenceInterval = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimateUpperCI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPopulationEstimateLowerCI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEstimatedDensity_SqMi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAreaSurveyed_mi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAverageSearchEffort = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPersonnel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowReportReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDeliverablesDatasetReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProtocolReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSurveyDatasetTitle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAbstract = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSummary = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDatasetProcessingSteps = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComments = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProtocolVersion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSurveyName = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colAbstract = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colSummary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colDatasetProcessingSteps = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colRecordInsertedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ResultsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.ResultsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ResultsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ResultsView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ResultsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SelectAQueryToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.LoadQueryResultsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResultsPivotXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ResultsPivotSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ResultsPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ResultsPivotChartControl = New DevExpress.XtraCharts.ChartControl()
        Me.ResultsPivotToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SelectAResultsPivotDatasourceToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SelectAResultsPivotDatasourceToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportSurveySummaryToExcelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.circularGauge12 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.ExcelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
        Me.GSPESurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportGridToExcelToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsXtraTabControl.SuspendLayout()
        Me.ResultsXtraTabPage.SuspendLayout()
        CType(Me.ResultsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsToolStrip.SuspendLayout()
        Me.ResultsPivotXtraTabPage.SuspendLayout()
        CType(Me.ResultsPivotSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsPivotSplitContainer.Panel1.SuspendLayout()
        Me.ResultsPivotSplitContainer.Panel2.SuspendLayout()
        Me.ResultsPivotSplitContainer.SuspendLayout()
        CType(Me.ResultsPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsPivotChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsPivotToolStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circularGauge12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colReportReferenceCode
        '
        Me.colReportReferenceCode.FieldName = "ReportReferenceCode"
        Me.colReportReferenceCode.Name = "colReportReferenceCode"
        Me.colReportReferenceCode.Visible = True
        Me.colReportReferenceCode.VisibleIndex = 14
        Me.colReportReferenceCode.Width = 159
        '
        'colDeliverablesDatasetReferenceCode
        '
        Me.colDeliverablesDatasetReferenceCode.FieldName = "DeliverablesDatasetReferenceCode"
        Me.colDeliverablesDatasetReferenceCode.Name = "colDeliverablesDatasetReferenceCode"
        Me.colDeliverablesDatasetReferenceCode.Visible = True
        Me.colDeliverablesDatasetReferenceCode.VisibleIndex = 15
        Me.colDeliverablesDatasetReferenceCode.Width = 204
        '
        'colProtocolReferenceCode
        '
        Me.colProtocolReferenceCode.FieldName = "ProtocolReferenceCode"
        Me.colProtocolReferenceCode.Name = "colProtocolReferenceCode"
        Me.colProtocolReferenceCode.Visible = True
        Me.colProtocolReferenceCode.VisibleIndex = 16
        Me.colProtocolReferenceCode.Width = 238
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
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.Location = New System.Drawing.Point(0, 70)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.VGridControl1)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainerMain.Size = New System.Drawing.Size(1677, 1138)
        Me.SplitContainerMain.SplitterDistance = 447
        Me.SplitContainerMain.TabIndex = 0
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.VGridControl1.Appearance.RecordValue.Options.UseFont = True
        Me.VGridControl1.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseFont = True
        Me.VGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.VGridControl1.DataSource = Me.GSPE_SurveysBindingSource
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoEdit3, Me.RepositoryItemMemoEdit4, Me.RepositoryItemMemoEdit5})
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSurveyName, Me.rowYear, Me.rowPark, Me.rowParkSubArea, Me.rowStartDate, Me.rowEndDate, Me.rowPopulationEstimate, Me.rowConfidenceInterval, Me.rowPopulationEstimateUpperCI, Me.rowPopulationEstimateLowerCI, Me.rowEstimatedDensity_SqMi, Me.rowAreaSurveyed_mi, Me.rowAverageSearchEffort, Me.rowPersonnel, Me.rowReportReferenceCode, Me.rowDeliverablesDatasetReferenceCode, Me.rowProtocolReferenceCode, Me.rowSurveyDatasetTitle, Me.rowAbstract, Me.rowSummary, Me.rowDatasetProcessingSteps, Me.rowRecordInsertedDate, Me.rowRecordInsertedBy, Me.rowProtocolVersion})
        Me.VGridControl1.Size = New System.Drawing.Size(447, 1138)
        Me.VGridControl1.TabIndex = 0
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
        'rowSurveyName
        '
        Me.rowSurveyName.Height = 42
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
        'rowPopulationEstimate
        '
        Me.rowPopulationEstimate.Name = "rowPopulationEstimate"
        Me.rowPopulationEstimate.Properties.Caption = "Population Estimate"
        Me.rowPopulationEstimate.Properties.FieldName = "PopulationEstimate"
        '
        'rowConfidenceInterval
        '
        Me.rowConfidenceInterval.Name = "rowConfidenceInterval"
        Me.rowConfidenceInterval.Properties.Caption = "Confidence Interval"
        Me.rowConfidenceInterval.Properties.FieldName = "ConfidenceInterval"
        '
        'rowPopulationEstimateUpperCI
        '
        Me.rowPopulationEstimateUpperCI.Name = "rowPopulationEstimateUpperCI"
        Me.rowPopulationEstimateUpperCI.Properties.Caption = "Population Estimate Upper CI"
        Me.rowPopulationEstimateUpperCI.Properties.FieldName = "PopulationEstimateUpperCI"
        '
        'rowPopulationEstimateLowerCI
        '
        Me.rowPopulationEstimateLowerCI.Height = 16
        Me.rowPopulationEstimateLowerCI.Name = "rowPopulationEstimateLowerCI"
        Me.rowPopulationEstimateLowerCI.Properties.Caption = "Population Estimate Lower CI"
        Me.rowPopulationEstimateLowerCI.Properties.FieldName = "PopulationEstimateLowerCI"
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
        'rowPersonnel
        '
        Me.rowPersonnel.Height = 42
        Me.rowPersonnel.Name = "rowPersonnel"
        Me.rowPersonnel.Properties.Caption = "Personnel"
        Me.rowPersonnel.Properties.FieldName = "Personnel"
        Me.rowPersonnel.Properties.RowEdit = Me.RepositoryItemMemoEdit1
        '
        'rowReportReferenceCode
        '
        Me.rowReportReferenceCode.Name = "rowReportReferenceCode"
        Me.rowReportReferenceCode.Properties.Caption = "Report Reference Code"
        Me.rowReportReferenceCode.Properties.FieldName = "ReportReferenceCode"
        '
        'rowDeliverablesDatasetReferenceCode
        '
        Me.rowDeliverablesDatasetReferenceCode.Name = "rowDeliverablesDatasetReferenceCode"
        Me.rowDeliverablesDatasetReferenceCode.Properties.Caption = "Deliverables Dataset Reference Code"
        Me.rowDeliverablesDatasetReferenceCode.Properties.FieldName = "DeliverablesDatasetReferenceCode"
        '
        'rowProtocolReferenceCode
        '
        Me.rowProtocolReferenceCode.Name = "rowProtocolReferenceCode"
        Me.rowProtocolReferenceCode.Properties.Caption = "Protocol Reference Code"
        Me.rowProtocolReferenceCode.Properties.FieldName = "ProtocolReferenceCode"
        '
        'rowSurveyDatasetTitle
        '
        Me.rowSurveyDatasetTitle.Height = 45
        Me.rowSurveyDatasetTitle.Name = "rowSurveyDatasetTitle"
        Me.rowSurveyDatasetTitle.Properties.Caption = "Survey Dataset Title"
        Me.rowSurveyDatasetTitle.Properties.FieldName = "SurveyDatasetTitle"
        '
        'rowAbstract
        '
        Me.rowAbstract.Height = 184
        Me.rowAbstract.Name = "rowAbstract"
        Me.rowAbstract.Properties.Caption = "Abstract"
        Me.rowAbstract.Properties.FieldName = "Abstract"
        Me.rowAbstract.Properties.RowEdit = Me.RepositoryItemMemoEdit2
        '
        'rowSummary
        '
        Me.rowSummary.Height = 202
        Me.rowSummary.Name = "rowSummary"
        Me.rowSummary.Properties.Caption = "Summary"
        Me.rowSummary.Properties.FieldName = "Summary"
        Me.rowSummary.Properties.RowEdit = Me.RepositoryItemMemoEdit3
        '
        'rowDatasetProcessingSteps
        '
        Me.rowDatasetProcessingSteps.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowComments})
        Me.rowDatasetProcessingSteps.Height = 362
        Me.rowDatasetProcessingSteps.Name = "rowDatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.Caption = "Dataset Processing Steps"
        Me.rowDatasetProcessingSteps.Properties.FieldName = "DatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.RowEdit = Me.RepositoryItemMemoEdit4
        '
        'rowComments
        '
        Me.rowComments.Height = 140
        Me.rowComments.Name = "rowComments"
        Me.rowComments.Properties.Caption = "Comments"
        Me.rowComments.Properties.FieldName = "Comments"
        Me.rowComments.Properties.RowEdit = Me.RepositoryItemMemoEdit5
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
        'rowProtocolVersion
        '
        Me.rowProtocolVersion.Name = "rowProtocolVersion"
        Me.rowProtocolVersion.Properties.Caption = "Protocol Version"
        Me.rowProtocolVersion.Properties.FieldName = "ProtocolVersion"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ResultsXtraTabControl)
        Me.SplitContainer2.Size = New System.Drawing.Size(1226, 1138)
        Me.SplitContainer2.SplitterDistance = 360
        Me.SplitContainer2.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.GSPE_SurveysBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit6, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemMemoEdit7, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(1226, 360)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSurveyName, Me.colYear, Me.colPark, Me.colParkSubArea, Me.colStartDate, Me.colEndDate, Me.colPopulationEstimate, Me.colConfidenceInterval, Me.colPopulationEstimateUpperCI, Me.colPopulationEstimateLowerCI, Me.colEstimatedDensity_SqMi, Me.colAreaSurveyed_mi, Me.colAverageSearchEffort, Me.colPersonnel, Me.colReportReferenceCode, Me.colDeliverablesDatasetReferenceCode, Me.colProtocolReferenceCode, Me.colProtocolVersion, Me.colSurveyDatasetTitle, Me.colAbstract, Me.colSummary, Me.colDatasetProcessingSteps, Me.colComments, Me.colRecordInsertedDate, Me.colRecordInsertedBy})
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
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.FormatRules.Add(GridFormatRule3)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSurveyName, DevExpress.Data.ColumnSortOrder.Descending)})
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
        Me.colSurveyName.Width = 299
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 1
        '
        'colPark
        '
        Me.colPark.FieldName = "Park"
        Me.colPark.Name = "colPark"
        Me.colPark.Visible = True
        Me.colPark.VisibleIndex = 2
        '
        'colParkSubArea
        '
        Me.colParkSubArea.FieldName = "ParkSubArea"
        Me.colParkSubArea.Name = "colParkSubArea"
        Me.colParkSubArea.Visible = True
        Me.colParkSubArea.VisibleIndex = 3
        Me.colParkSubArea.Width = 188
        '
        'colStartDate
        '
        Me.colStartDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 4
        Me.colStartDate.Width = 148
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
        Me.colEndDate.VisibleIndex = 5
        Me.colEndDate.Width = 163
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
        Me.colPopulationEstimate.FieldName = "PopulationEstimate"
        Me.colPopulationEstimate.Name = "colPopulationEstimate"
        Me.colPopulationEstimate.Visible = True
        Me.colPopulationEstimate.VisibleIndex = 6
        Me.colPopulationEstimate.Width = 120
        '
        'colConfidenceInterval
        '
        Me.colConfidenceInterval.FieldName = "ConfidenceInterval"
        Me.colConfidenceInterval.Name = "colConfidenceInterval"
        Me.colConfidenceInterval.Visible = True
        Me.colConfidenceInterval.VisibleIndex = 7
        Me.colConfidenceInterval.Width = 156
        '
        'colPopulationEstimateUpperCI
        '
        Me.colPopulationEstimateUpperCI.FieldName = "PopulationEstimateUpperCI"
        Me.colPopulationEstimateUpperCI.Name = "colPopulationEstimateUpperCI"
        Me.colPopulationEstimateUpperCI.Visible = True
        Me.colPopulationEstimateUpperCI.VisibleIndex = 8
        Me.colPopulationEstimateUpperCI.Width = 164
        '
        'colPopulationEstimateLowerCI
        '
        Me.colPopulationEstimateLowerCI.FieldName = "PopulationEstimateLowerCI"
        Me.colPopulationEstimateLowerCI.Name = "colPopulationEstimateLowerCI"
        Me.colPopulationEstimateLowerCI.Visible = True
        Me.colPopulationEstimateLowerCI.VisibleIndex = 9
        Me.colPopulationEstimateLowerCI.Width = 168
        '
        'colEstimatedDensity_SqMi
        '
        Me.colEstimatedDensity_SqMi.FieldName = "EstimatedDensity_SqMi"
        Me.colEstimatedDensity_SqMi.Name = "colEstimatedDensity_SqMi"
        Me.colEstimatedDensity_SqMi.Visible = True
        Me.colEstimatedDensity_SqMi.VisibleIndex = 10
        Me.colEstimatedDensity_SqMi.Width = 159
        '
        'colAreaSurveyed_mi
        '
        Me.colAreaSurveyed_mi.FieldName = "AreaSurveyed_mi"
        Me.colAreaSurveyed_mi.Name = "colAreaSurveyed_mi"
        Me.colAreaSurveyed_mi.Visible = True
        Me.colAreaSurveyed_mi.VisibleIndex = 11
        Me.colAreaSurveyed_mi.Width = 116
        '
        'colAverageSearchEffort
        '
        Me.colAverageSearchEffort.FieldName = "AverageSearchEffort"
        Me.colAverageSearchEffort.Name = "colAverageSearchEffort"
        Me.colAverageSearchEffort.Visible = True
        Me.colAverageSearchEffort.VisibleIndex = 12
        Me.colAverageSearchEffort.Width = 135
        '
        'colPersonnel
        '
        Me.colPersonnel.FieldName = "Personnel"
        Me.colPersonnel.Name = "colPersonnel"
        Me.colPersonnel.Visible = True
        Me.colPersonnel.VisibleIndex = 13
        Me.colPersonnel.Width = 346
        '
        'colProtocolVersion
        '
        Me.colProtocolVersion.FieldName = "ProtocolVersion"
        Me.colProtocolVersion.Name = "colProtocolVersion"
        Me.colProtocolVersion.Visible = True
        Me.colProtocolVersion.VisibleIndex = 23
        Me.colProtocolVersion.Width = 211
        '
        'colSurveyDatasetTitle
        '
        Me.colSurveyDatasetTitle.FieldName = "SurveyDatasetTitle"
        Me.colSurveyDatasetTitle.Name = "colSurveyDatasetTitle"
        Me.colSurveyDatasetTitle.Visible = True
        Me.colSurveyDatasetTitle.VisibleIndex = 17
        Me.colSurveyDatasetTitle.Width = 255
        '
        'colAbstract
        '
        Me.colAbstract.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.colAbstract.FieldName = "Abstract"
        Me.colAbstract.Name = "colAbstract"
        Me.colAbstract.Visible = True
        Me.colAbstract.VisibleIndex = 18
        Me.colAbstract.Width = 357
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'colSummary
        '
        Me.colSummary.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colSummary.FieldName = "Summary"
        Me.colSummary.Name = "colSummary"
        Me.colSummary.Visible = True
        Me.colSummary.VisibleIndex = 19
        Me.colSummary.Width = 279
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'colDatasetProcessingSteps
        '
        Me.colDatasetProcessingSteps.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.colDatasetProcessingSteps.FieldName = "DatasetProcessingSteps"
        Me.colDatasetProcessingSteps.Name = "colDatasetProcessingSteps"
        Me.colDatasetProcessingSteps.Visible = True
        Me.colDatasetProcessingSteps.VisibleIndex = 20
        Me.colDatasetProcessingSteps.Width = 206
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 24
        '
        'colRecordInsertedDate
        '
        Me.colRecordInsertedDate.ColumnEdit = Me.RepositoryItemDateEdit3
        Me.colRecordInsertedDate.FieldName = "RecordInsertedDate"
        Me.colRecordInsertedDate.Name = "colRecordInsertedDate"
        Me.colRecordInsertedDate.OptionsColumn.ReadOnly = True
        Me.colRecordInsertedDate.Visible = True
        Me.colRecordInsertedDate.VisibleIndex = 21
        Me.colRecordInsertedDate.Width = 199
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
        Me.colRecordInsertedBy.FieldName = "RecordInsertedBy"
        Me.colRecordInsertedBy.Name = "colRecordInsertedBy"
        Me.colRecordInsertedBy.OptionsColumn.ReadOnly = True
        Me.colRecordInsertedBy.Visible = True
        Me.colRecordInsertedBy.VisibleIndex = 22
        Me.colRecordInsertedBy.Width = 173
        '
        'RepositoryItemMemoEdit6
        '
        Me.RepositoryItemMemoEdit6.LinesCount = 12
        Me.RepositoryItemMemoEdit6.Name = "RepositoryItemMemoEdit6"
        '
        'RepositoryItemMemoEdit7
        '
        Me.RepositoryItemMemoEdit7.LinesCount = 20
        Me.RepositoryItemMemoEdit7.Name = "RepositoryItemMemoEdit7"
        '
        'ResultsXtraTabControl
        '
        Me.ResultsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ResultsXtraTabControl.Name = "ResultsXtraTabControl"
        Me.ResultsXtraTabControl.SelectedTabPage = Me.ResultsXtraTabPage
        Me.ResultsXtraTabControl.Size = New System.Drawing.Size(1226, 774)
        Me.ResultsXtraTabControl.TabIndex = 5
        Me.ResultsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.ResultsXtraTabPage, Me.ResultsPivotXtraTabPage})
        '
        'ResultsXtraTabPage
        '
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsGridControl)
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsToolStrip)
        Me.ResultsXtraTabPage.Name = "ResultsXtraTabPage"
        Me.ResultsXtraTabPage.Size = New System.Drawing.Size(1224, 749)
        Me.ResultsXtraTabPage.Text = "Results"
        '
        'ResultsGridControl
        '
        Me.ResultsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsGridControl.Location = New System.Drawing.Point(0, 20)
        Me.ResultsGridControl.MainView = Me.ResultsView
        Me.ResultsGridControl.Name = "ResultsGridControl"
        Me.ResultsGridControl.Size = New System.Drawing.Size(979, 579)
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
        Me.ResultsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.SelectAQueryToolStripComboBox, Me.LoadQueryResultsToolStripButton, Me.ToolStripSeparator6, Me.ExportGridToExcelToolStripButton})
        Me.ResultsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ResultsToolStrip.Name = "ResultsToolStrip"
        Me.ResultsToolStrip.Size = New System.Drawing.Size(1224, 25)
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
        Me.SelectAQueryToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SelectAQueryToolStripComboBox.Name = "SelectAQueryToolStripComboBox"
        Me.SelectAQueryToolStripComboBox.Size = New System.Drawing.Size(400, 25)
        '
        'LoadQueryResultsToolStripButton
        '
        Me.LoadQueryResultsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LoadQueryResultsToolStripButton.Image = CType(resources.GetObject("LoadQueryResultsToolStripButton.Image"), System.Drawing.Image)
        Me.LoadQueryResultsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadQueryResultsToolStripButton.Name = "LoadQueryResultsToolStripButton"
        Me.LoadQueryResultsToolStripButton.Size = New System.Drawing.Size(74, 22)
        Me.LoadQueryResultsToolStripButton.Text = "Load results"
        '
        'ResultsPivotXtraTabPage
        '
        Me.ResultsPivotXtraTabPage.Controls.Add(Me.ResultsPivotSplitContainer)
        Me.ResultsPivotXtraTabPage.Controls.Add(Me.ResultsPivotToolStrip)
        Me.ResultsPivotXtraTabPage.Name = "ResultsPivotXtraTabPage"
        Me.ResultsPivotXtraTabPage.Size = New System.Drawing.Size(1224, 749)
        Me.ResultsPivotXtraTabPage.Text = "Analytics"
        '
        'ResultsPivotSplitContainer
        '
        Me.ResultsPivotSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsPivotSplitContainer.Location = New System.Drawing.Point(0, 20)
        Me.ResultsPivotSplitContainer.Name = "ResultsPivotSplitContainer"
        '
        'ResultsPivotSplitContainer.Panel1
        '
        Me.ResultsPivotSplitContainer.Panel1.Controls.Add(Me.ResultsPivotGridControl)
        '
        'ResultsPivotSplitContainer.Panel2
        '
        Me.ResultsPivotSplitContainer.Panel2.Controls.Add(Me.ResultsPivotChartControl)
        Me.ResultsPivotSplitContainer.Size = New System.Drawing.Size(979, 583)
        Me.ResultsPivotSplitContainer.SplitterDistance = 920
        Me.ResultsPivotSplitContainer.TabIndex = 6
        '
        'ResultsPivotGridControl
        '
        Me.ResultsPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsPivotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ResultsPivotGridControl.Name = "ResultsPivotGridControl"
        Me.ResultsPivotGridControl.Size = New System.Drawing.Size(920, 583)
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
        Me.ResultsPivotChartControl.Location = New System.Drawing.Point(0, 0)
        Me.ResultsPivotChartControl.Name = "ResultsPivotChartControl"
        Me.ResultsPivotChartControl.SeriesDataMember = "Series"
        Me.ResultsPivotChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ResultsPivotChartControl.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ResultsPivotChartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.ResultsPivotChartControl.SeriesTemplate.SeriesDataMember = "Series"
        Me.ResultsPivotChartControl.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ResultsPivotChartControl.Size = New System.Drawing.Size(55, 583)
        Me.ResultsPivotChartControl.TabIndex = 5
        '
        'ResultsPivotToolStrip
        '
        Me.ResultsPivotToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ResultsPivotToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.SelectAResultsPivotDatasourceToolStripComboBox, Me.SelectAResultsPivotDatasourceToolStripButton, Me.ToolStripSeparator5, Me.ExportSurveySummaryToExcelToolStripButton})
        Me.ResultsPivotToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ResultsPivotToolStrip.Name = "ResultsPivotToolStrip"
        Me.ResultsPivotToolStrip.Size = New System.Drawing.Size(979, 20)
        Me.ResultsPivotToolStrip.TabIndex = 6
        Me.ResultsPivotToolStrip.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(114, 17)
        Me.ToolStripLabel2.Text = "Select a data source:"
        '
        'SelectAResultsPivotDatasourceToolStripComboBox
        '
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Name = "SelectAResultsPivotDatasourceToolStripComboBox"
        Me.SelectAResultsPivotDatasourceToolStripComboBox.Size = New System.Drawing.Size(121, 20)
        '
        'SelectAResultsPivotDatasourceToolStripButton
        '
        Me.SelectAResultsPivotDatasourceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SelectAResultsPivotDatasourceToolStripButton.Image = CType(resources.GetObject("SelectAResultsPivotDatasourceToolStripButton.Image"), System.Drawing.Image)
        Me.SelectAResultsPivotDatasourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectAResultsPivotDatasourceToolStripButton.Name = "SelectAResultsPivotDatasourceToolStripButton"
        Me.SelectAResultsPivotDatasourceToolStripButton.Size = New System.Drawing.Size(101, 17)
        Me.SelectAResultsPivotDatasourceToolStripButton.Text = "Load data source"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 20)
        '
        'ExportSurveySummaryToExcelToolStripButton
        '
        Me.ExportSurveySummaryToExcelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportSurveySummaryToExcelToolStripButton.Image = CType(resources.GetObject("ExportSurveySummaryToExcelToolStripButton.Image"), System.Drawing.Image)
        Me.ExportSurveySummaryToExcelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportSurveySummaryToExcelToolStripButton.Name = "ExportSurveySummaryToExcelToolStripButton"
        Me.ExportSurveySummaryToExcelToolStripButton.Size = New System.Drawing.Size(96, 17)
        Me.ExportSurveySummaryToExcelToolStripButton.Text = "Export to Excel..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.OpenResourcesToolStripButton, Me.ToolStripSeparator2, Me.CertifySurveyToolStripButton, Me.ToolStripSeparator3, Me.RefreshDatasetToolStripButton, Me.ToolStripSeparator4, Me.AnalyticsToolStripDropDownButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1677, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.AnalyticsToolStripDropDownButton.Size = New System.Drawing.Size(69, 22)
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
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.HeaderLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 25)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1677, 45)
        Me.HeaderPanel.TabIndex = 2
        '
        'HeaderLabel
        '
        Me.HeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HeaderLabel.Location = New System.Drawing.Point(3, 6)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(1674, 71)
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
        'ExcelDataSource1
        '
        Me.ExcelDataSource1.Name = "ExcelDataSource1"
        '
        'GSPESurveysBindingSource
        '
        Me.GSPESurveysBindingSource.DataMember = "GSPE_Surveys"
        Me.GSPESurveysBindingSource.DataSource = Me.MooseDataSet
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ExportGridToExcelToolStripButton
        '
        Me.ExportGridToExcelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportGridToExcelToolStripButton.Image = CType(resources.GetObject("ExportGridToExcelToolStripButton.Image"), System.Drawing.Image)
        Me.ExportGridToExcelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportGridToExcelToolStripButton.Name = "ExportGridToExcelToolStripButton"
        Me.ExportGridToExcelToolStripButton.Size = New System.Drawing.Size(96, 22)
        Me.ExportGridToExcelToolStripButton.Text = "Export to Excel..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1677, 1208)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainForm"
        Me.Text = "Moose"
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit7, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResultsPivotSplitContainer.Panel1.ResumeLayout(False)
        Me.ResultsPivotSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.ResultsPivotSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsPivotSplitContainer.ResumeLayout(False)
        CType(Me.ResultsPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsPivotChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsPivotToolStrip.ResumeLayout(False)
        Me.ResultsPivotToolStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circularGauge12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MooseDataSet As MooseDataSet
    Friend WithEvents GSPE_SurveysBindingSource As BindingSource
    Friend WithEvents GSPE_SurveysTableAdapter As MooseDataSetTableAdapters.GSPE_SurveysTableAdapter
    Friend WithEvents TableAdapterManager As MooseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GSPETableAdapter As MooseDataSetTableAdapters.GSPETableAdapter
    Friend WithEvents GSPEBindingSource As BindingSource
    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rowSurveyName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYear As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPark As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowParkSubArea As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowConfidenceInterval As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimateUpperCI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPopulationEstimateLowerCI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEstimatedDensity_SqMi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAreaSurveyed_mi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAverageSearchEffort As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPersonnel As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowReportReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDeliverablesDatasetReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProtocolReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSurveyDatasetTitle As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAbstract As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSummary As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDatasetProcessingSteps As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComments As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProtocolVersion As DevExpress.XtraVerticalGrid.Rows.EditorRow
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
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ExcelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colAbstract As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSummary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatasetProcessingSteps As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProtocolVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents LoadQueryResultsToolStripButton As ToolStripButton
    Friend WithEvents SelectAQueryToolStripComboBox As ToolStripComboBox
    Friend WithEvents ResultsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents ResultsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ResultsPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ResultsPivotXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ResultsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ResultsView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GSPESurveysBindingSource As BindingSource
    Friend WithEvents ResultsPivotChartControl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ResultsPivotSplitContainer As SplitContainer
    Friend WithEvents ResultsPivotToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents SelectAResultsPivotDatasourceToolStripComboBox As ToolStripComboBox
    Friend WithEvents SelectAResultsPivotDatasourceToolStripButton As ToolStripButton
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ExportSurveySummaryToExcelToolStripButton As ToolStripButton
    Friend WithEvents AnalyticsToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents SurveyResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GSPEDatasetSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueryExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExportGridToExcelToolStripButton As ToolStripButton
End Class
