<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopulationEstimateAnalyticsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GSPE_SummaryPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.MooseDataSet = New Moose_Monitoring_Database_Application.MooseDataSet()
        Me.GSPESurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_SurveysTableAdapter = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.GSPE_SurveysTableAdapter()
        Me.fieldSurveyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPark1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldParkSubArea1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStartDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEndDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPopulationEstimate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldConfidenceInterval1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPopulationEstimateUpperCI1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPopulationEstimateLowerCI1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEstimatedDensitySqMi1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAreaSurveyedmi1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAverageSearchEffort1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPersonnel1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldReportReferenceCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDeliverablesDatasetReferenceCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProtocolReferenceCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSurveyDatasetTitle1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAbstract1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSummary1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDatasetProcessingSteps1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRecordInsertedDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRecordInsertedBy1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProtocolVersion1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldComments1 = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GSPE_SummaryPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GSPE_SummaryPivotGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1277, 807)
        Me.SplitContainer1.SplitterDistance = 621
        Me.SplitContainer1.TabIndex = 0
        '
        'GSPE_SummaryPivotGridControl
        '
        Me.GSPE_SummaryPivotGridControl.DataSource = Me.GSPESurveysBindingSource
        Me.GSPE_SummaryPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GSPE_SummaryPivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSurveyName1, Me.fieldYear1, Me.fieldPark1, Me.fieldParkSubArea1, Me.fieldStartDate1, Me.fieldEndDate1, Me.fieldPopulationEstimate1, Me.fieldConfidenceInterval1, Me.fieldPopulationEstimateUpperCI1, Me.fieldPopulationEstimateLowerCI1, Me.fieldEstimatedDensitySqMi1, Me.fieldAreaSurveyedmi1, Me.fieldAverageSearchEffort1, Me.fieldPersonnel1, Me.fieldReportReferenceCode1, Me.fieldDeliverablesDatasetReferenceCode1, Me.fieldProtocolReferenceCode1, Me.fieldSurveyDatasetTitle1, Me.fieldAbstract1, Me.fieldSummary1, Me.fieldDatasetProcessingSteps1, Me.fieldRecordInsertedDate1, Me.fieldRecordInsertedBy1, Me.fieldProtocolVersion1, Me.fieldComments1})
        Me.GSPE_SummaryPivotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.GSPE_SummaryPivotGridControl.Name = "GSPE_SummaryPivotGridControl"
        Me.GSPE_SummaryPivotGridControl.Size = New System.Drawing.Size(1277, 621)
        Me.GSPE_SummaryPivotGridControl.TabIndex = 0
        '
        'ChartControl1
        '
        Me.ChartControl1.DataSource = Me.GSPE_SummaryPivotGridControl
        XyDiagram1.AxisX.Title.Text = "Park Year Park Sub Area"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Title.Text = "Population Estimate Population Estimate Lower CI Population Estimate Upper CI Con" &
    "fidence Interval Area Surveyed_mi Average Search Effort Estimated Density_Sq Mi"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.ChartControl1.SeriesTemplate.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.SeriesTemplate.View = LineSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(1277, 182)
        Me.ChartControl1.TabIndex = 0
        '
        'MooseDataSet
        '
        Me.MooseDataSet.DataSetName = "MooseDataSet"
        Me.MooseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSPESurveysBindingSource
        '
        Me.GSPESurveysBindingSource.DataMember = "GSPE_Surveys"
        Me.GSPESurveysBindingSource.DataSource = Me.MooseDataSet
        '
        'GSPE_SurveysTableAdapter
        '
        Me.GSPE_SurveysTableAdapter.ClearBeforeFill = True
        '
        'fieldSurveyName1
        '
        Me.fieldSurveyName1.AreaIndex = 0
        Me.fieldSurveyName1.Caption = "Survey Name"
        Me.fieldSurveyName1.FieldName = "SurveyName"
        Me.fieldSurveyName1.Name = "fieldSurveyName1"
        '
        'fieldYear1
        '
        Me.fieldYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldYear1.AreaIndex = 1
        Me.fieldYear1.Caption = "Year"
        Me.fieldYear1.FieldName = "Year"
        Me.fieldYear1.Name = "fieldYear1"
        '
        'fieldPark1
        '
        Me.fieldPark1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPark1.AreaIndex = 0
        Me.fieldPark1.Caption = "Park"
        Me.fieldPark1.FieldName = "Park"
        Me.fieldPark1.Name = "fieldPark1"
        Me.fieldPark1.Width = 232
        '
        'fieldParkSubArea1
        '
        Me.fieldParkSubArea1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldParkSubArea1.AreaIndex = 2
        Me.fieldParkSubArea1.Caption = "Park Sub Area"
        Me.fieldParkSubArea1.FieldName = "ParkSubArea"
        Me.fieldParkSubArea1.Name = "fieldParkSubArea1"
        '
        'fieldStartDate1
        '
        Me.fieldStartDate1.AreaIndex = 1
        Me.fieldStartDate1.Caption = "StartDate"
        Me.fieldStartDate1.FieldName = "StartDate"
        Me.fieldStartDate1.Name = "fieldStartDate1"
        '
        'fieldEndDate1
        '
        Me.fieldEndDate1.AreaIndex = 2
        Me.fieldEndDate1.Caption = "EndDate"
        Me.fieldEndDate1.FieldName = "EndDate"
        Me.fieldEndDate1.Name = "fieldEndDate1"
        '
        'fieldPopulationEstimate1
        '
        Me.fieldPopulationEstimate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPopulationEstimate1.AreaIndex = 0
        Me.fieldPopulationEstimate1.Caption = "Population Estimate"
        Me.fieldPopulationEstimate1.FieldName = "PopulationEstimate"
        Me.fieldPopulationEstimate1.Name = "fieldPopulationEstimate1"
        Me.fieldPopulationEstimate1.Width = 103
        '
        'fieldConfidenceInterval1
        '
        Me.fieldConfidenceInterval1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldConfidenceInterval1.AreaIndex = 3
        Me.fieldConfidenceInterval1.Caption = "Confidence Interval"
        Me.fieldConfidenceInterval1.FieldName = "ConfidenceInterval"
        Me.fieldConfidenceInterval1.Name = "fieldConfidenceInterval1"
        '
        'fieldPopulationEstimateUpperCI1
        '
        Me.fieldPopulationEstimateUpperCI1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPopulationEstimateUpperCI1.AreaIndex = 2
        Me.fieldPopulationEstimateUpperCI1.Caption = "Population Estimate Upper CI"
        Me.fieldPopulationEstimateUpperCI1.FieldName = "PopulationEstimateUpperCI"
        Me.fieldPopulationEstimateUpperCI1.Name = "fieldPopulationEstimateUpperCI1"
        Me.fieldPopulationEstimateUpperCI1.Width = 163
        '
        'fieldPopulationEstimateLowerCI1
        '
        Me.fieldPopulationEstimateLowerCI1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPopulationEstimateLowerCI1.AreaIndex = 1
        Me.fieldPopulationEstimateLowerCI1.Caption = "Population Estimate Lower CI"
        Me.fieldPopulationEstimateLowerCI1.FieldName = "PopulationEstimateLowerCI"
        Me.fieldPopulationEstimateLowerCI1.Name = "fieldPopulationEstimateLowerCI1"
        Me.fieldPopulationEstimateLowerCI1.Width = 149
        '
        'fieldEstimatedDensitySqMi1
        '
        Me.fieldEstimatedDensitySqMi1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEstimatedDensitySqMi1.AreaIndex = 6
        Me.fieldEstimatedDensitySqMi1.Caption = "Estimated Density_Sq Mi"
        Me.fieldEstimatedDensitySqMi1.FieldName = "EstimatedDensity_SqMi"
        Me.fieldEstimatedDensitySqMi1.Name = "fieldEstimatedDensitySqMi1"
        '
        'fieldAreaSurveyedmi1
        '
        Me.fieldAreaSurveyedmi1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAreaSurveyedmi1.AreaIndex = 4
        Me.fieldAreaSurveyedmi1.Caption = "Area Surveyed_mi"
        Me.fieldAreaSurveyedmi1.FieldName = "AreaSurveyed_mi"
        Me.fieldAreaSurveyedmi1.Name = "fieldAreaSurveyedmi1"
        '
        'fieldAverageSearchEffort1
        '
        Me.fieldAverageSearchEffort1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAverageSearchEffort1.AreaIndex = 5
        Me.fieldAverageSearchEffort1.Caption = "Average Search Effort"
        Me.fieldAverageSearchEffort1.FieldName = "AverageSearchEffort"
        Me.fieldAverageSearchEffort1.Name = "fieldAverageSearchEffort1"
        '
        'fieldPersonnel1
        '
        Me.fieldPersonnel1.AreaIndex = 3
        Me.fieldPersonnel1.Caption = "Personnel"
        Me.fieldPersonnel1.FieldName = "Personnel"
        Me.fieldPersonnel1.Name = "fieldPersonnel1"
        '
        'fieldReportReferenceCode1
        '
        Me.fieldReportReferenceCode1.AreaIndex = 4
        Me.fieldReportReferenceCode1.Caption = "Report Reference Code"
        Me.fieldReportReferenceCode1.FieldName = "ReportReferenceCode"
        Me.fieldReportReferenceCode1.Name = "fieldReportReferenceCode1"
        '
        'fieldDeliverablesDatasetReferenceCode1
        '
        Me.fieldDeliverablesDatasetReferenceCode1.AreaIndex = 5
        Me.fieldDeliverablesDatasetReferenceCode1.Caption = "Deliverables Dataset Reference Code"
        Me.fieldDeliverablesDatasetReferenceCode1.FieldName = "DeliverablesDatasetReferenceCode"
        Me.fieldDeliverablesDatasetReferenceCode1.Name = "fieldDeliverablesDatasetReferenceCode1"
        '
        'fieldProtocolReferenceCode1
        '
        Me.fieldProtocolReferenceCode1.AreaIndex = 6
        Me.fieldProtocolReferenceCode1.Caption = "Protocol Reference Code"
        Me.fieldProtocolReferenceCode1.FieldName = "ProtocolReferenceCode"
        Me.fieldProtocolReferenceCode1.Name = "fieldProtocolReferenceCode1"
        '
        'fieldSurveyDatasetTitle1
        '
        Me.fieldSurveyDatasetTitle1.AreaIndex = 7
        Me.fieldSurveyDatasetTitle1.Caption = "Survey Dataset Title"
        Me.fieldSurveyDatasetTitle1.FieldName = "SurveyDatasetTitle"
        Me.fieldSurveyDatasetTitle1.Name = "fieldSurveyDatasetTitle1"
        '
        'fieldAbstract1
        '
        Me.fieldAbstract1.AreaIndex = 8
        Me.fieldAbstract1.Caption = "Abstract"
        Me.fieldAbstract1.FieldName = "Abstract"
        Me.fieldAbstract1.Name = "fieldAbstract1"
        '
        'fieldSummary1
        '
        Me.fieldSummary1.AreaIndex = 9
        Me.fieldSummary1.Caption = "Summary"
        Me.fieldSummary1.FieldName = "Summary"
        Me.fieldSummary1.Name = "fieldSummary1"
        '
        'fieldDatasetProcessingSteps1
        '
        Me.fieldDatasetProcessingSteps1.AreaIndex = 10
        Me.fieldDatasetProcessingSteps1.Caption = "Dataset Processing Steps"
        Me.fieldDatasetProcessingSteps1.FieldName = "DatasetProcessingSteps"
        Me.fieldDatasetProcessingSteps1.Name = "fieldDatasetProcessingSteps1"
        '
        'fieldRecordInsertedDate1
        '
        Me.fieldRecordInsertedDate1.AreaIndex = 11
        Me.fieldRecordInsertedDate1.Caption = "RecordInsertedDate"
        Me.fieldRecordInsertedDate1.FieldName = "RecordInsertedDate"
        Me.fieldRecordInsertedDate1.Name = "fieldRecordInsertedDate1"
        '
        'fieldRecordInsertedBy1
        '
        Me.fieldRecordInsertedBy1.AreaIndex = 12
        Me.fieldRecordInsertedBy1.Caption = "Record Inserted By"
        Me.fieldRecordInsertedBy1.FieldName = "RecordInsertedBy"
        Me.fieldRecordInsertedBy1.Name = "fieldRecordInsertedBy1"
        '
        'fieldProtocolVersion1
        '
        Me.fieldProtocolVersion1.AreaIndex = 13
        Me.fieldProtocolVersion1.Caption = "Protocol Version"
        Me.fieldProtocolVersion1.FieldName = "ProtocolVersion"
        Me.fieldProtocolVersion1.Name = "fieldProtocolVersion1"
        '
        'fieldComments1
        '
        Me.fieldComments1.AreaIndex = 14
        Me.fieldComments1.Caption = "Comments"
        Me.fieldComments1.FieldName = "Comments"
        Me.fieldComments1.Name = "fieldComments1"
        '
        'PopulationEstimateAnalyticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 807)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PopulationEstimateAnalyticsForm"
        Me.Text = "PopulationEstimateAnalyticsForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GSPE_SummaryPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GSPE_SummaryPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents MooseDataSet As MooseDataSet
    Friend WithEvents GSPESurveysBindingSource As BindingSource
    Friend WithEvents GSPE_SurveysTableAdapter As MooseDataSetTableAdapters.GSPE_SurveysTableAdapter
    Friend WithEvents fieldSurveyName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPark1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldParkSubArea1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStartDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEndDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPopulationEstimate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldConfidenceInterval1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPopulationEstimateUpperCI1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPopulationEstimateLowerCI1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEstimatedDensitySqMi1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAreaSurveyedmi1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAverageSearchEffort1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPersonnel1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldReportReferenceCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDeliverablesDatasetReferenceCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProtocolReferenceCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSurveyDatasetTitle1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAbstract1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSummary1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDatasetProcessingSteps1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRecordInsertedDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRecordInsertedBy1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProtocolVersion1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldComments1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
