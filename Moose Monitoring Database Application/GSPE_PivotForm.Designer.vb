<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GSPE_PivotForm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.QuerySelectorToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.GSPEPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.GSPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MooseDataSet = New Moose_Monitoring_Database_Application.MooseDataSet()
        Me.fieldPark1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSurveyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSurveyYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSeason1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStartDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStopDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIntID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRand1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFiringOrder1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSelected1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCounted1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStrat1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStratMoose1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStratTracks1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStratHab1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSearchMin1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDateCounted1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPercNotFlown1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldXCOORD1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYCOORD1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAreaSqMi1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldADULT1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULL30401 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULL30501 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULL30601 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULL41501 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULLALL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULLGT501 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULLGT601 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULLGTE501 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULLLT301 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBULLLT501 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALF1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOW1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOWW01 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOWW11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOWW21 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOWW31 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLGBULL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMEDBULL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMEDLBULL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSMBULL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUNKNOWN1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYBULLALL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYBULLGTSF1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYBULLSF1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMOOSE1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldComments1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSourceFilename1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRecordInsertedDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRecordInsertedBy1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCertificationDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCertifiedBy1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCertificationLevel1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldExclude1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGMU1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPilot1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStratName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSubArea1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GSPETableAdapter = New Moose_Monitoring_Database_Application.MooseDataSetTableAdapters.GSPETableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GSPEPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.QuerySelectorToolStripComboBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1545, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel1.Text = "Select a data source:"
        '
        'QuerySelectorToolStripComboBox
        '
        Me.QuerySelectorToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QuerySelectorToolStripComboBox.Name = "QuerySelectorToolStripComboBox"
        Me.QuerySelectorToolStripComboBox.Size = New System.Drawing.Size(320, 25)
        '
        'GSPEPivotGridControl
        '
        Me.GSPEPivotGridControl.DataSource = Me.GSPEBindingSource
        Me.GSPEPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GSPEPivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldPark1, Me.fieldSurveyName1, Me.fieldSurveyYear1, Me.fieldSeason1, Me.fieldID1, Me.fieldStartDate1, Me.fieldStopDate1, Me.fieldIntID1, Me.fieldRand1, Me.fieldFiringOrder1, Me.fieldSelected1, Me.fieldCounted1, Me.fieldStrat1, Me.fieldStratMoose1, Me.fieldStratTracks1, Me.fieldStratHab1, Me.fieldSearchMin1, Me.fieldDateCounted1, Me.fieldPercNotFlown1, Me.fieldXCOORD1, Me.fieldYCOORD1, Me.fieldAreaSqMi1, Me.fieldADULT1, Me.fieldBULL30401, Me.fieldBULL30501, Me.fieldBULL30601, Me.fieldBULL41501, Me.fieldBULLALL1, Me.fieldBULLGT501, Me.fieldBULLGT601, Me.fieldBULLGTE501, Me.fieldBULLLT301, Me.fieldBULLLT501, Me.fieldCALF1, Me.fieldCOW1, Me.fieldCOWW01, Me.fieldCOWW11, Me.fieldCOWW21, Me.fieldCOWW31, Me.fieldLGBULL1, Me.fieldMEDBULL1, Me.fieldMEDLBULL1, Me.fieldSMBULL1, Me.fieldUNKNOWN1, Me.fieldYBULLALL1, Me.fieldYBULLGTSF1, Me.fieldYBULLSF1, Me.fieldMOOSE1, Me.fieldComments1, Me.fieldSourceFilename1, Me.fieldRecordInsertedDate1, Me.fieldRecordInsertedBy1, Me.fieldCertificationDate1, Me.fieldCertifiedBy1, Me.fieldCertificationLevel1, Me.fieldExclude1, Me.fieldGMU1, Me.fieldPilot1, Me.fieldStratName1, Me.fieldSubArea1})
        Me.GSPEPivotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.GSPEPivotGridControl.Name = "GSPEPivotGridControl"
        Me.GSPEPivotGridControl.Size = New System.Drawing.Size(1545, 725)
        Me.GSPEPivotGridControl.TabIndex = 1
        '
        'GSPEBindingSource
        '
        Me.GSPEBindingSource.DataMember = "GSPE"
        Me.GSPEBindingSource.DataSource = Me.MooseDataSet
        '
        'MooseDataSet
        '
        Me.MooseDataSet.DataSetName = "MooseDataSet"
        Me.MooseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldPark1
        '
        Me.fieldPark1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPark1.AreaIndex = 0
        Me.fieldPark1.Caption = "Park"
        Me.fieldPark1.FieldName = "Park"
        Me.fieldPark1.Name = "fieldPark1"
        Me.fieldPark1.Width = 180
        '
        'fieldSurveyName1
        '
        Me.fieldSurveyName1.AreaIndex = 0
        Me.fieldSurveyName1.Caption = "Survey Name"
        Me.fieldSurveyName1.FieldName = "SurveyName"
        Me.fieldSurveyName1.Name = "fieldSurveyName1"
        '
        'fieldSurveyYear1
        '
        Me.fieldSurveyYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSurveyYear1.AreaIndex = 1
        Me.fieldSurveyYear1.Caption = "Survey Year"
        Me.fieldSurveyYear1.FieldName = "SurveyYear"
        Me.fieldSurveyYear1.Name = "fieldSurveyYear1"
        '
        'fieldSeason1
        '
        Me.fieldSeason1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSeason1.AreaIndex = 2
        Me.fieldSeason1.Caption = "Season"
        Me.fieldSeason1.FieldName = "Season"
        Me.fieldSeason1.Name = "fieldSeason1"
        '
        'fieldID1
        '
        Me.fieldID1.AreaIndex = 1
        Me.fieldID1.Caption = "ID"
        Me.fieldID1.FieldName = "ID"
        Me.fieldID1.Name = "fieldID1"
        '
        'fieldStartDate1
        '
        Me.fieldStartDate1.AreaIndex = 2
        Me.fieldStartDate1.Caption = "StartDate"
        Me.fieldStartDate1.FieldName = "StartDate"
        Me.fieldStartDate1.Name = "fieldStartDate1"
        '
        'fieldStopDate1
        '
        Me.fieldStopDate1.AreaIndex = 3
        Me.fieldStopDate1.Caption = "StopDate"
        Me.fieldStopDate1.FieldName = "StopDate"
        Me.fieldStopDate1.Name = "fieldStopDate1"
        '
        'fieldIntID1
        '
        Me.fieldIntID1.AreaIndex = 4
        Me.fieldIntID1.Caption = "Int ID"
        Me.fieldIntID1.FieldName = "IntID"
        Me.fieldIntID1.Name = "fieldIntID1"
        '
        'fieldRand1
        '
        Me.fieldRand1.AreaIndex = 5
        Me.fieldRand1.Caption = "Rand"
        Me.fieldRand1.FieldName = "Rand"
        Me.fieldRand1.Name = "fieldRand1"
        '
        'fieldFiringOrder1
        '
        Me.fieldFiringOrder1.AreaIndex = 6
        Me.fieldFiringOrder1.Caption = "Firing Order"
        Me.fieldFiringOrder1.FieldName = "FiringOrder"
        Me.fieldFiringOrder1.Name = "fieldFiringOrder1"
        '
        'fieldSelected1
        '
        Me.fieldSelected1.AreaIndex = 7
        Me.fieldSelected1.Caption = "Selected"
        Me.fieldSelected1.FieldName = "Selected"
        Me.fieldSelected1.Name = "fieldSelected1"
        '
        'fieldCounted1
        '
        Me.fieldCounted1.AreaIndex = 8
        Me.fieldCounted1.Caption = "Counted"
        Me.fieldCounted1.FieldName = "Counted"
        Me.fieldCounted1.Name = "fieldCounted1"
        '
        'fieldStrat1
        '
        Me.fieldStrat1.AreaIndex = 9
        Me.fieldStrat1.Caption = "Strat"
        Me.fieldStrat1.FieldName = "Strat"
        Me.fieldStrat1.Name = "fieldStrat1"
        '
        'fieldStratMoose1
        '
        Me.fieldStratMoose1.AreaIndex = 10
        Me.fieldStratMoose1.Caption = "Strat Moose"
        Me.fieldStratMoose1.FieldName = "StratMoose"
        Me.fieldStratMoose1.Name = "fieldStratMoose1"
        '
        'fieldStratTracks1
        '
        Me.fieldStratTracks1.AreaIndex = 11
        Me.fieldStratTracks1.Caption = "Strat Tracks"
        Me.fieldStratTracks1.FieldName = "StratTracks"
        Me.fieldStratTracks1.Name = "fieldStratTracks1"
        '
        'fieldStratHab1
        '
        Me.fieldStratHab1.AreaIndex = 12
        Me.fieldStratHab1.Caption = "Strat Hab"
        Me.fieldStratHab1.FieldName = "StratHab"
        Me.fieldStratHab1.Name = "fieldStratHab1"
        '
        'fieldSearchMin1
        '
        Me.fieldSearchMin1.AreaIndex = 13
        Me.fieldSearchMin1.Caption = "Search Min"
        Me.fieldSearchMin1.FieldName = "SearchMin"
        Me.fieldSearchMin1.Name = "fieldSearchMin1"
        '
        'fieldDateCounted1
        '
        Me.fieldDateCounted1.AreaIndex = 14
        Me.fieldDateCounted1.Caption = "DateCounted"
        Me.fieldDateCounted1.FieldName = "DateCounted"
        Me.fieldDateCounted1.Name = "fieldDateCounted1"
        '
        'fieldPercNotFlown1
        '
        Me.fieldPercNotFlown1.AreaIndex = 15
        Me.fieldPercNotFlown1.Caption = "Perc_Not_Flown"
        Me.fieldPercNotFlown1.FieldName = "Perc_Not_Flown"
        Me.fieldPercNotFlown1.Name = "fieldPercNotFlown1"
        '
        'fieldXCOORD1
        '
        Me.fieldXCOORD1.AreaIndex = 16
        Me.fieldXCOORD1.Caption = "X_COORD"
        Me.fieldXCOORD1.FieldName = "X_COORD"
        Me.fieldXCOORD1.Name = "fieldXCOORD1"
        '
        'fieldYCOORD1
        '
        Me.fieldYCOORD1.AreaIndex = 17
        Me.fieldYCOORD1.Caption = "Y_COORD"
        Me.fieldYCOORD1.FieldName = "Y_COORD"
        Me.fieldYCOORD1.Name = "fieldYCOORD1"
        '
        'fieldAreaSqMi1
        '
        Me.fieldAreaSqMi1.AreaIndex = 18
        Me.fieldAreaSqMi1.Caption = "Area_Sq Mi"
        Me.fieldAreaSqMi1.FieldName = "Area_SqMi"
        Me.fieldAreaSqMi1.Name = "fieldAreaSqMi1"
        '
        'fieldADULT1
        '
        Me.fieldADULT1.AreaIndex = 19
        Me.fieldADULT1.Caption = "ADULT"
        Me.fieldADULT1.FieldName = "ADULT"
        Me.fieldADULT1.Name = "fieldADULT1"
        '
        'fieldBULL30401
        '
        Me.fieldBULL30401.AreaIndex = 20
        Me.fieldBULL30401.Caption = "BULL_30_40"
        Me.fieldBULL30401.FieldName = "BULL_30_40"
        Me.fieldBULL30401.Name = "fieldBULL30401"
        '
        'fieldBULL30501
        '
        Me.fieldBULL30501.AreaIndex = 21
        Me.fieldBULL30501.Caption = "BULL_30_50"
        Me.fieldBULL30501.FieldName = "BULL_30_50"
        Me.fieldBULL30501.Name = "fieldBULL30501"
        '
        'fieldBULL30601
        '
        Me.fieldBULL30601.AreaIndex = 22
        Me.fieldBULL30601.Caption = "BULL_30_60"
        Me.fieldBULL30601.FieldName = "BULL_30_60"
        Me.fieldBULL30601.Name = "fieldBULL30601"
        '
        'fieldBULL41501
        '
        Me.fieldBULL41501.AreaIndex = 23
        Me.fieldBULL41501.Caption = "BULL_41_50"
        Me.fieldBULL41501.FieldName = "BULL_41_50"
        Me.fieldBULL41501.Name = "fieldBULL41501"
        '
        'fieldBULLALL1
        '
        Me.fieldBULLALL1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBULLALL1.AreaIndex = 9
        Me.fieldBULLALL1.Caption = "BULL_ALL"
        Me.fieldBULLALL1.FieldName = "BULL_ALL"
        Me.fieldBULLALL1.Name = "fieldBULLALL1"
        '
        'fieldBULLGT501
        '
        Me.fieldBULLGT501.AreaIndex = 24
        Me.fieldBULLGT501.Caption = "BULL_GT_50"
        Me.fieldBULLGT501.FieldName = "BULL_GT_50"
        Me.fieldBULLGT501.Name = "fieldBULLGT501"
        '
        'fieldBULLGT601
        '
        Me.fieldBULLGT601.AreaIndex = 25
        Me.fieldBULLGT601.Caption = "BULL_GT_60"
        Me.fieldBULLGT601.FieldName = "BULL_GT_60"
        Me.fieldBULLGT601.Name = "fieldBULLGT601"
        '
        'fieldBULLGTE501
        '
        Me.fieldBULLGTE501.AreaIndex = 26
        Me.fieldBULLGTE501.Caption = "BULL_GTE_50"
        Me.fieldBULLGTE501.FieldName = "BULL_GTE_50"
        Me.fieldBULLGTE501.Name = "fieldBULLGTE501"
        '
        'fieldBULLLT301
        '
        Me.fieldBULLLT301.AreaIndex = 27
        Me.fieldBULLLT301.Caption = "BULL_LT_30"
        Me.fieldBULLLT301.FieldName = "BULL_LT_30"
        Me.fieldBULLLT301.Name = "fieldBULLLT301"
        '
        'fieldBULLLT501
        '
        Me.fieldBULLLT501.AreaIndex = 28
        Me.fieldBULLLT501.Caption = "BULL_LT_50"
        Me.fieldBULLLT501.FieldName = "BULL_LT_50"
        Me.fieldBULLLT501.Name = "fieldBULLLT501"
        '
        'fieldCALF1
        '
        Me.fieldCALF1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCALF1.AreaIndex = 0
        Me.fieldCALF1.Caption = "CALF"
        Me.fieldCALF1.FieldName = "CALF"
        Me.fieldCALF1.Name = "fieldCALF1"
        '
        'fieldCOW1
        '
        Me.fieldCOW1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCOW1.AreaIndex = 5
        Me.fieldCOW1.Caption = "COW"
        Me.fieldCOW1.FieldName = "COW"
        Me.fieldCOW1.Name = "fieldCOW1"
        '
        'fieldCOWW01
        '
        Me.fieldCOWW01.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCOWW01.AreaIndex = 1
        Me.fieldCOWW01.Caption = "COW_W_0"
        Me.fieldCOWW01.FieldName = "COW_W_0"
        Me.fieldCOWW01.Name = "fieldCOWW01"
        '
        'fieldCOWW11
        '
        Me.fieldCOWW11.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCOWW11.AreaIndex = 2
        Me.fieldCOWW11.Caption = "COW_W_1"
        Me.fieldCOWW11.FieldName = "COW_W_1"
        Me.fieldCOWW11.Name = "fieldCOWW11"
        '
        'fieldCOWW21
        '
        Me.fieldCOWW21.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCOWW21.AreaIndex = 3
        Me.fieldCOWW21.Caption = "COW_W_2"
        Me.fieldCOWW21.FieldName = "COW_W_2"
        Me.fieldCOWW21.Name = "fieldCOWW21"
        '
        'fieldCOWW31
        '
        Me.fieldCOWW31.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCOWW31.AreaIndex = 4
        Me.fieldCOWW31.Caption = "COW_W_3"
        Me.fieldCOWW31.FieldName = "COW_W_3"
        Me.fieldCOWW31.Name = "fieldCOWW31"
        '
        'fieldLGBULL1
        '
        Me.fieldLGBULL1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldLGBULL1.AreaIndex = 8
        Me.fieldLGBULL1.Caption = "LG_BULL"
        Me.fieldLGBULL1.FieldName = "LG_BULL"
        Me.fieldLGBULL1.Name = "fieldLGBULL1"
        '
        'fieldMEDBULL1
        '
        Me.fieldMEDBULL1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMEDBULL1.AreaIndex = 7
        Me.fieldMEDBULL1.Caption = "MED_BULL"
        Me.fieldMEDBULL1.FieldName = "MED_BULL"
        Me.fieldMEDBULL1.Name = "fieldMEDBULL1"
        '
        'fieldMEDLBULL1
        '
        Me.fieldMEDLBULL1.AreaIndex = 29
        Me.fieldMEDLBULL1.Caption = "MED_L_BULL"
        Me.fieldMEDLBULL1.FieldName = "MED_L_BULL"
        Me.fieldMEDLBULL1.Name = "fieldMEDLBULL1"
        '
        'fieldSMBULL1
        '
        Me.fieldSMBULL1.AreaIndex = 30
        Me.fieldSMBULL1.Caption = "SM_BULL"
        Me.fieldSMBULL1.FieldName = "SM_BULL"
        Me.fieldSMBULL1.Name = "fieldSMBULL1"
        '
        'fieldUNKNOWN1
        '
        Me.fieldUNKNOWN1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldUNKNOWN1.AreaIndex = 11
        Me.fieldUNKNOWN1.Caption = "UNKNOWN"
        Me.fieldUNKNOWN1.FieldName = "UNKNOWN"
        Me.fieldUNKNOWN1.Name = "fieldUNKNOWN1"
        '
        'fieldYBULLALL1
        '
        Me.fieldYBULLALL1.AreaIndex = 31
        Me.fieldYBULLALL1.Caption = "YBULL_ALL"
        Me.fieldYBULLALL1.FieldName = "YBULL_ALL"
        Me.fieldYBULLALL1.Name = "fieldYBULLALL1"
        '
        'fieldYBULLGTSF1
        '
        Me.fieldYBULLGTSF1.AreaIndex = 32
        Me.fieldYBULLGTSF1.Caption = "YBULL_GTSF"
        Me.fieldYBULLGTSF1.FieldName = "YBULL_GTSF"
        Me.fieldYBULLGTSF1.Name = "fieldYBULLGTSF1"
        '
        'fieldYBULLSF1
        '
        Me.fieldYBULLSF1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldYBULLSF1.AreaIndex = 6
        Me.fieldYBULLSF1.Caption = "YBULL_SF"
        Me.fieldYBULLSF1.FieldName = "YBULL_SF"
        Me.fieldYBULLSF1.Name = "fieldYBULLSF1"
        '
        'fieldMOOSE1
        '
        Me.fieldMOOSE1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMOOSE1.AreaIndex = 10
        Me.fieldMOOSE1.Caption = "MOOSE"
        Me.fieldMOOSE1.FieldName = "MOOSE"
        Me.fieldMOOSE1.Name = "fieldMOOSE1"
        '
        'fieldComments1
        '
        Me.fieldComments1.AreaIndex = 33
        Me.fieldComments1.Caption = "Comments"
        Me.fieldComments1.FieldName = "Comments"
        Me.fieldComments1.Name = "fieldComments1"
        '
        'fieldSourceFilename1
        '
        Me.fieldSourceFilename1.AreaIndex = 34
        Me.fieldSourceFilename1.Caption = "Source Filename"
        Me.fieldSourceFilename1.FieldName = "SourceFilename"
        Me.fieldSourceFilename1.Name = "fieldSourceFilename1"
        '
        'fieldRecordInsertedDate1
        '
        Me.fieldRecordInsertedDate1.AreaIndex = 35
        Me.fieldRecordInsertedDate1.Caption = "RecordInsertedDate"
        Me.fieldRecordInsertedDate1.FieldName = "RecordInsertedDate"
        Me.fieldRecordInsertedDate1.Name = "fieldRecordInsertedDate1"
        '
        'fieldRecordInsertedBy1
        '
        Me.fieldRecordInsertedBy1.AreaIndex = 36
        Me.fieldRecordInsertedBy1.Caption = "Record Inserted By"
        Me.fieldRecordInsertedBy1.FieldName = "RecordInsertedBy"
        Me.fieldRecordInsertedBy1.Name = "fieldRecordInsertedBy1"
        '
        'fieldCertificationDate1
        '
        Me.fieldCertificationDate1.AreaIndex = 37
        Me.fieldCertificationDate1.Caption = "CertificationDate"
        Me.fieldCertificationDate1.FieldName = "CertificationDate"
        Me.fieldCertificationDate1.Name = "fieldCertificationDate1"
        '
        'fieldCertifiedBy1
        '
        Me.fieldCertifiedBy1.AreaIndex = 38
        Me.fieldCertifiedBy1.Caption = "Certified By"
        Me.fieldCertifiedBy1.FieldName = "CertifiedBy"
        Me.fieldCertifiedBy1.Name = "fieldCertifiedBy1"
        '
        'fieldCertificationLevel1
        '
        Me.fieldCertificationLevel1.AreaIndex = 39
        Me.fieldCertificationLevel1.Caption = "Certification Level"
        Me.fieldCertificationLevel1.FieldName = "CertificationLevel"
        Me.fieldCertificationLevel1.Name = "fieldCertificationLevel1"
        '
        'fieldExclude1
        '
        Me.fieldExclude1.AreaIndex = 40
        Me.fieldExclude1.Caption = "Exclude"
        Me.fieldExclude1.FieldName = "Exclude"
        Me.fieldExclude1.Name = "fieldExclude1"
        '
        'fieldGMU1
        '
        Me.fieldGMU1.AreaIndex = 41
        Me.fieldGMU1.Caption = "GMU"
        Me.fieldGMU1.FieldName = "GMU"
        Me.fieldGMU1.Name = "fieldGMU1"
        '
        'fieldPilot1
        '
        Me.fieldPilot1.AreaIndex = 42
        Me.fieldPilot1.Caption = "Pilot"
        Me.fieldPilot1.FieldName = "Pilot"
        Me.fieldPilot1.Name = "fieldPilot1"
        '
        'fieldStratName1
        '
        Me.fieldStratName1.AreaIndex = 43
        Me.fieldStratName1.Caption = "Strat Name"
        Me.fieldStratName1.FieldName = "StratName"
        Me.fieldStratName1.Name = "fieldStratName1"
        '
        'fieldSubArea1
        '
        Me.fieldSubArea1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSubArea1.AreaIndex = 3
        Me.fieldSubArea1.Caption = "Sub Area"
        Me.fieldSubArea1.FieldName = "SubArea"
        Me.fieldSubArea1.Name = "fieldSubArea1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GSPEPivotGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1545, 1119)
        Me.SplitContainer1.SplitterDistance = 725
        Me.SplitContainer1.TabIndex = 2
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.GSPETableAdapter
        Me.ChartControl1.DataSource = Me.GSPEPivotGridControl
        XyDiagram1.AxisX.Title.Text = "Park Survey Year Season Sub Area"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Title.Text = "CALF COW_W_0 COW_W_1 COW_W_2 COW_W_3 COW YBULL_SF MED_BULL LG_BULL BULL_ALL MOOSE" &
    " UNKNOWN"
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
        Me.ChartControl1.Size = New System.Drawing.Size(1545, 390)
        Me.ChartControl1.TabIndex = 0
        '
        'GSPETableAdapter
        '
        Me.GSPETableAdapter.ClearBeforeFill = True
        '
        'GSPE_PivotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 1144)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "GSPE_PivotForm"
        Me.Text = "GSPE_PivotForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GSPEPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GSPEPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents MooseDataSet As MooseDataSet
    Friend WithEvents GSPEBindingSource As BindingSource
    Friend WithEvents GSPETableAdapter As MooseDataSetTableAdapters.GSPETableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents fieldPark1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSurveyName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSurveyYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSeason1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStartDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStopDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIntID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRand1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFiringOrder1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSelected1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCounted1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStrat1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStratMoose1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStratTracks1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStratHab1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSearchMin1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDateCounted1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPercNotFlown1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldXCOORD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYCOORD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAreaSqMi1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldADULT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULL30401 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULL30501 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULL30601 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULL41501 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULLALL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULLGT501 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULLGT601 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULLGTE501 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULLLT301 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBULLLT501 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOW1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOWW01 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOWW11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOWW21 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOWW31 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLGBULL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMEDBULL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMEDLBULL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSMBULL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUNKNOWN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYBULLALL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYBULLGTSF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYBULLSF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMOOSE1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldComments1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSourceFilename1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRecordInsertedDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRecordInsertedBy1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCertificationDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCertifiedBy1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCertificationLevel1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldExclude1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGMU1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPilot1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStratName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSubArea1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents QuerySelectorToolStripComboBox As ToolStripComboBox
End Class
