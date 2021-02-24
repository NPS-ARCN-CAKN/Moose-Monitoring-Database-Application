Imports System.Data.SqlClient

Public Class MainForm

    Dim CurrentSurveyName As String = ""
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
        LoadDataset()

        LoadQuerySelectorComboBoxes()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        AskToSaveDataset()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AskToSaveDataset()
    End Sub

    Private Sub GSPE_SurveysBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles GSPE_SurveysBindingSource.CurrentChanged
        Try

            'load the summary data grid
            'Me.ResultsDataGridView.DataSource = Nothing
            Dim DR As DataRowView = GSPE_SurveysBindingSource.Current
            If Not DR Is Nothing Then
                'Dim SurveyName As String = DR.Item("SurveyName")
                If Not IsDBNull(DR.Item("SurveyName")) And DR.Item("SurveyName").Trim.Length > 0 Then

                    'Reassign CurrentSurveyName
                    CurrentSurveyName = DR.Item("SurveyName").trim

                    'load the survey name into the header
                    Me.HeaderLabel.Text = CurrentSurveyName
                    Dim MetadataDT As DataTable = GetDataTable(My.Settings.MooseConnectionString, "SELECT N as RecordCount, [Proportion of records certified] as PctCertified,Report,DeliverableDataset FROM Summary_TotalCountsBySurvey WHERE SurveyName = '" & CurrentSurveyName & "'")
                    If MetadataDT.Rows.Count = 1 Then
                        Me.HeaderLabel.Text = HeaderLabel.Text & " (" & MetadataDT.Rows(0).Item("PctCertified") * 100 & "% certified, " & MetadataDT.Rows(0).Item("RecordCount") & " records)"
                    End If


                    'Load the grids with data
                    LoadResultsGrid()
                    LoadResultsPivotGrid()
                Else
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try


        'Build up a moose survey object

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
            ReturnValue = DR.Item(ColumnName).ToString
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

    Private Sub LoadQueryResultsToolStripButton_Click(sender As Object, e As EventArgs) Handles LoadQueryResultsToolStripButton.Click
        LoadResultsGrid()
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



    Private Sub ExportSurveySummaryToExcelToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportSurveySummaryToExcelToolStripButton.Click
        Me.ResultsPivotGridControl.ExportToXlsx("C:\temp\zTemp.xlsx")
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

    Private Sub ExportGridToExcelToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportGridToExcelToolStripButton.Click
        SaveResultsToExcel(Me.ResultsGridControl)
    End Sub
End Class
