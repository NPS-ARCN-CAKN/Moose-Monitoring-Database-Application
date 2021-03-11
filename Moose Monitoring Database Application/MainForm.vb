Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Public Class MainForm

    Dim CurrentSurveyName As String = ""
    Dim CurrentReportCode As Integer = 0
    Dim CurrentDataSource As String = ""

    Private Sub AskToSaveDataset()
        If MooseDataSet.HasChanges = True Then
            If MsgBox("Save?", MsgBoxStyle.YesNo) = vbYes Then
                SaveDataset()
            End If
        End If
    End Sub
    Private Sub SaveDataset()
        Try
            Me.Validate()
            Me.GSPE_SurveysBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MooseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadDataset()
        Try
            AskToSaveDataset()
            'Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE)
            Me.GSPE_SurveysTableAdapter.Fill(Me.MooseDataSet.GSPE_Surveys)

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadQuerySelectorComboBoxes()
        Try
            LoadQuerySelectorComboBox(Me.SelectAQueryToolStripComboBox)
            LoadQuerySelectorComboBox(Me.SelectAResultsPivotDatasourceToolStripComboBox)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GSPE_SurveyGridView.OptionsBehavior.ReadOnly = True

        LoadDataset()

        Me.ValidatedByRepositoryItemComboBox.Items.Add(My.User.Name)
    End Sub



    Private Sub GSPE_SurveysBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles GSPE_SurveysBindingSource.CurrentChanged
        Try

            'load the summary data grid and update the main header
            Dim DR As DataRowView = GSPE_SurveysBindingSource.Current
            If Not DR Is Nothing Then

                'if surveyname is not null
                If Not IsDBNull(DR.Item("SurveyName")) Then

                    'Reassign CurrentSurveyName
                    CurrentSurveyName = DR.Item("SurveyName").trim

                    'load the survey name into the header
                    Me.HeaderLabel.Text = CurrentSurveyName
                    Dim MetadataDT As DataTable = GetDataTable(My.Settings.MooseConnectionString, "SELECT N as RecordCount, [Proportion of records certified] as PctCertified,Report,DeliverableDataset FROM Summary_TotalCountsBySurvey WHERE SurveyName = '" & CurrentSurveyName & "'")
                    If MetadataDT.Rows.Count = 1 Then
                        Me.HeaderLabel.Text = HeaderLabel.Text & " (" & MetadataDT.Rows(0).Item("PctCertified") * 100 & "% certified, " & MetadataDT.Rows(0).Item("RecordCount") & " records)"
                    End If

                    'Add the survey name to the OpenSharedDriveDirectoryToolStripMenuItem context menu strip item
                    Me.OpenSharedDriveDirectoryToolStripMenuItem.Text = "Open " & CurrentSurveyName & " directory (" & CurrentDataSource & ")"

                    'Load the grids with data
                    LoadResultsGrid()
                    LoadResultsPivotGrid()
                Else
                    CurrentSurveyName = ""
                End If

                'if ReportReferenceCode is not null
                If Not IsDBNull(DR.Item("ReportReferenceCode")) Then
                    If IsNumeric(DR.Item("ReportReferenceCode")) = True Then
                        'Reassign CurrentSurveyName
                        CurrentReportCode = CInt(DR.Item("ReportReferenceCode"))
                    Else
                        CurrentReportCode = 0
                    End If
                Else
                        CurrentReportCode = 0
                End If

                'if DataSource is not null
                If Not IsDBNull(DR.Item("DataSource")) Then
                    'Reassign CurrentSurveyName
                    CurrentDataSource = DR.Item("DataSource")
                Else
                    CurrentDataSource = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub




    Private Sub OpenResourcesToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenResourcesToolStripButton.Click
        Try
            Dim DR As DataRowView = GSPE_SurveysBindingSource.Current

            Dim ReportReferenceCode As Integer = 0
            If Not IsDBNull(DR.Item("ReportReferenceCode")) Then ReportReferenceCode = DR.Item("ReportReferenceCode")

            Dim DeliverablesDatasetReferenceCode As Integer = 0
            If Not IsDBNull(DR.Item("DeliverablesDatasetReferenceCode")) Then DeliverablesDatasetReferenceCode = DR.Item("DeliverablesDatasetReferenceCode")

            Dim ProtocolReferenceCode As Integer = 0
            If Not IsDBNull(DR.Item("ProtocolReferenceCode")) Then ProtocolReferenceCode = DR.Item("ProtocolReferenceCode")

            Dim URLPrefix As String = "https://irma.nps.gov/DataStore/Reference/Profile/"

            If Not IsDBNull(ReportReferenceCode) And ReportReferenceCode > 0 Then OpenProcess(URLPrefix & ReportReferenceCode)
            If Not IsDBNull(DeliverablesDatasetReferenceCode) And DeliverablesDatasetReferenceCode > 0 Then OpenProcess(URLPrefix & DeliverablesDatasetReferenceCode)
            If Not IsDBNull(ProtocolReferenceCode) And ProtocolReferenceCode > 0 Then OpenProcess(URLPrefix & ProtocolReferenceCode)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Function GetCurrentSurveyValue(ColumnName As String) As String
        Dim ReturnValue As String = ""
        Try
            Dim DR As DataRowView = GSPE_SurveysBindingSource.Current
            If Not DR Is Nothing Then
                If Not IsDBNull(DR.Item(ColumnName)) Then
                    ReturnValue = DR.Item(ColumnName).ToString
                End If
            End If
        Catch nrefex As System.NullReferenceException
            MsgBox(nrefex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return ReturnValue
    End Function

    Public Sub OpenProcess(ProcessToStart As String)
        Try
            Process.Start(ProcessToStart)
        Catch ex As Exception
            MsgBox(ProcessToStart & " failed. Error:" & ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub CertifySurveyToolStripButton_Click(sender As Object, e As EventArgs) Handles CertifySurveyToolStripButton.Click
        Dim SurveyName As String = GetCurrentSurveyValue("SurveyName")
        If SurveyName.Trim.Length > 0 Then
            Dim CertificationQuery As String = "UPDATE GSPE SET CertificationLevel='Certified',CertifiedBy=Suser_Name(),CertificationDate=GetDate() WHERE SurveyName = '" & SurveyName & "'"
            If MsgBox("Copy certification query (" & CertificationQuery & ") to clipboard?", MsgBoxStyle.YesNo, "Certify this survey") = vbYes Then
                My.Computer.Clipboard.SetText(CertificationQuery)
            End If
        End If
    End Sub

    Private Sub RefreshDatasetToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshDatasetToolStripButton.Click
        LoadDataset()
    End Sub


    Private Sub SelectAResultsPivotDatasourceToolStripButton_Click(sender As Object, e As EventArgs) Handles SelectAResultsPivotDatasourceToolStripButton.Click
        LoadResultsPivotGrid()
    End Sub

    Private Sub LoadResultsGrid()
        Try
            If Me.SelectAQueryToolStripComboBox.Text.Trim.Length > 0 Then
                Dim TableName As String = Me.SelectAQueryToolStripComboBox.Text.Trim
                Dim WhereClause As String = " WHERE SurveyName='" & CurrentSurveyName & "'"
                Dim Sql As String = "SELECT * FROM " & TableName & WhereClause
                Dim DT As DataTable = GetDataTable(My.Settings.MooseConnectionString, Sql)

                'Load the results grid
                With Me.ResultsGridControl
                    .DataSource = DT
                    .MainView.PopulateColumns()
                    .Text = Sql
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadResultsPivotGrid()
        Try
            'see if we have a data source
            If Me.SelectAResultsPivotDatasourceToolStripComboBox.Text.Trim.Length > 0 Then

                'load a data table into the pivot grid
                Dim TableName As String = Me.SelectAResultsPivotDatasourceToolStripComboBox.Text.Trim
                Dim WhereClause As String = " WHERE SurveyName='" & CurrentSurveyName & "'"
                Dim Sql As String = "SELECT * FROM " & TableName & WhereClause
                Dim DT As DataTable = GetDataTable(My.Settings.MooseConnectionString, Sql)

                'load the results pivot grid
                With Me.ResultsPivotGridControl
                    .DataSource = DT
                    .RetrieveFields()
                    .Text = Sql
                End With
            Else
                'no survey selected, clear the grid
                Me.ResultsPivotGridControl.DataSource = Nothing
                Me.ResultsPivotGridControl.RetrieveFields()
            End If

        Catch ex As Exception
            'no survey selected, clear the grid
            Me.ResultsPivotGridControl.DataSource = Nothing
            Me.ResultsPivotGridControl.RetrieveFields()
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub



    Private Sub ExportSurveySummaryToExcelToolStripButton_Click(sender As Object, e As EventArgs)
        SavePivotGridControlToExcel(Me.ResultsPivotGridControl, ExportFormat.xlsx)
    End Sub

    Private Sub GSPEDatasetSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSPEDatasetSummaryToolStripMenuItem.Click
        Dim GSPE_PivotForm As New GSPE_PivotForm
        GSPE_PivotForm.Show()
    End Sub

    Private Sub SurveyResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurveyResultsToolStripMenuItem.Click
        Dim PopulationEstimateAnalyticsForm As New PopulationEstimateAnalyticsForm
        PopulationEstimateAnalyticsForm.Show()
    End Sub

    Private Sub QueryExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueryExplorerToolStripMenuItem.Click
        Dim QueryExplorerForm As New QueryExplorerForm
        QueryExplorerForm.Show()
    End Sub

    Private Sub ExportGridToExcelToolStripButton_Click(sender As Object, e As EventArgs)
        SaveGridControlToExcel(Me.ResultsGridControl, ExportFormat.xlsx)
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GSPE_SurveyGridView.InitNewRow
        Dim MyView As GridView = CType(sender, GridView)
        MyView.SetRowCellValue(e.RowHandle, MyView.Columns("RecordInsertedDate"), Now)
        MyView.SetRowCellValue(e.RowHandle, MyView.Columns("RecordInsertedBy"), My.User.Name)
    End Sub

    Private Sub VGridControl1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GSPE_SurveyVGridControl.MouseDoubleClick
        PrependDateAndNameToDatasetProcessingStepsValue()
    End Sub

    ''' <summary>
    ''' Prepends the current date and user name to the current data processing steps field in the survey vertical grid
    ''' </summary>
    Private Sub PrependDateAndNameToDatasetProcessingStepsValue()
        Try
            'Get a handle on the survey vertical grid control
            Dim VG As VGridControl = GSPE_SurveyVGridControl

            'Get the current text
            Dim CurrentCellValue As String = VG.GetCellValue(VG.FocusedRow, VG.FocusedRecord).ToString

            'If the focused row is the dataset processing steps row then prepend the date and username to the existing text
            If VG.FocusedRow.Name = "rowDatasetProcessingSteps" Then
                Dim NewValue As String = Now & " " & My.User.Name & ": " & vbNewLine & CurrentCellValue
                VG.SetCellValue(VG.FocusedRow, VG.FocusedRecord, NewValue)
            End If

        Catch ex As Exception
            Debug.Print(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub



    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        SavePivotGridControlToExcel(Me.ResultsPivotGridControl, ExportFormat.xlsx)
    End Sub

    Private Sub CommaSeparatedValuesTextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValuesTextFileToolStripMenuItem.Click
        SavePivotGridControlToExcel(Me.ResultsPivotGridControl, ExportFormat.csv)
    End Sub

    Private Sub ExcelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem1.Click
        SaveGridControlToExcel(Me.ResultsGridControl, ExportFormat.xlsx)
    End Sub

    Private Sub CommaSeparatedValuesTextFileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValuesTextFileToolStripMenuItem1.Click
        SaveGridControlToExcel(Me.ResultsGridControl, ExportFormat.csv)
    End Sub

    Private Sub SelectAQueryToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectAQueryToolStripComboBox.SelectedIndexChanged
        LoadResultsGrid()
    End Sub

    Private Sub ExcelToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem2.Click
        SaveGridControlToExcel(Me.GSPE_SurveyGridControl, ExportFormat.xlsx)
    End Sub

    Private Sub CommaSeparatedValuesTextFileToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValuesTextFileToolStripMenuItem2.Click
        SaveGridControlToExcel(Me.GSPE_SurveyGridControl, ExportFormat.csv)
    End Sub

    Private Sub GSPE_SurveyGridControl_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GSPE_SurveyGridControl.MouseDoubleClick
        ' Dim FR As Object = Me.GSPE_SurveyGridView.GetFocusedRow
        Dim DR As DataRow = Me.GSPE_SurveyGridView.GetDataRow(Me.GSPE_SurveyGridView.FocusedRowHandle)

        MsgBox(DR.Item("SurveyName"), Me.GSPE_SurveyGridView.GetFocusedDisplayText)
    End Sub



    Private Sub OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenARCNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Click
        OpenMooseDirectory(IMNetwork.ARCN)
    End Sub

    Private Sub OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCAKNMooseMonitoringSharedDriveDirectoryToolStripMenuItem.Click
        OpenMooseDirectory(IMNetwork.CAKN)
    End Sub

    Private Sub OpenARCNMooseMonitoringDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenARCNMooseMonitoringDirectoryToolStripMenuItem.Click
        OpenMooseDirectory(IMNetwork.ARCN)
    End Sub

    Private Sub OpenCAKNMooseMonitoringDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCAKNMooseMonitoringDirectoryToolStripMenuItem.Click
        OpenMooseDirectory(IMNetwork.CAKN)
    End Sub

    Private Sub OpenReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenReportToolStripMenuItem.Click
        Dim URL As String = ""
        If CurrentReportCode > 0 Then
            Try
                URL = My.Settings.IRMAReferenceLinkPrefix & CurrentReportCode
                Process.Start(URL)
            Catch ex As Exception
                MsgBox("Error: Could not open " & url & ". " & ex.Message & ".  (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
            End Try
        End If
    End Sub



    Private Sub OpenSharedDriveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSharedDriveDirectoryToolStripMenuItem.Click
        Try
            'If the directory exists try to open it
            If My.Computer.FileSystem.DirectoryExists(CurrentDataSource) Then
                Process.Start(CurrentDataSource)
            Else
                MsgBox("Directory " & CurrentDataSource & " for the Survey " & CurrentSurveyName & " does not exist. Modify the directory path in this application's My.Settings property.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub ReadOnlyToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReadOnlyToolStripComboBox.SelectedIndexChanged
        SetReadOnly()
    End Sub

    ''' <summary>
    ''' Sets the GSPE Survey grid readonly parameter based on Me.ReadOnlyToolStripComboBox.Text
    ''' </summary>
    Private Sub SetReadOnly()
        If Me.ReadOnlyToolStripComboBox.Text = "True" Then
            Me.GSPE_SurveyGridView.OptionsBehavior.ReadOnly = True
        Else
            Me.GSPE_SurveyGridView.OptionsBehavior.ReadOnly = False
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveDataset()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AskToSaveDataset()
    End Sub

    Private Sub ValidateThisSurveyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidateThisSurveyToolStripMenuItem.Click
        ValidateSurvey(CurrentSurveyName)
    End Sub

    Private Sub CertifyThisSurveyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertifyThisSurveyToolStripMenuItem.Click
        CertifySurvey(CurrentSurveyName)
    End Sub

    Private Sub SelectAQueryToolStripComboBox_Enter(sender As Object, e As EventArgs) Handles SelectAQueryToolStripComboBox.Enter
        LoadQuerySelectorComboBoxes()
    End Sub

    Private Sub MainForm_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        HelpProvider.SetHelpNavigator(Me, HelpNavigator.TableOfContents)
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        HelpProvider.SetHelpNavigator(Me, HelpNavigator.TableOfContents)
    End Sub
End Class
