Imports System.Data.SqlClient

Public Class Form1

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

    Private Sub LoadSelectAQueryComboBox()
        Try
            Me.SelectAQueryToolStripComboBox.Items.Clear()
            Me.SelectAQueryToolStripComboBox.Items.Add("")

            'Get a list of tables and queries to load into the queries selector combo box
            Dim QueriesDataTable As DataTable = GetDataTable(My.Settings.MooseConnectionString, "SELECT [Table],TableDescription,SelectQuery from DatabaseTableDescriptions ORDER BY [Table]")
            For Each QueryRow As DataRow In QueriesDataTable.Rows
                Me.SelectAQueryToolStripComboBox.Items.Add(QueryRow.Item("Table"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataset()

        LoadSelectAQueryComboBox()
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

                    LoadResultsGrid()
                Else
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


    ''' <summary>
    ''' Runs the query in Sql against a database using ConnectionString and returns the results as a DataTable
    ''' </summary>
    ''' <param name="ConnectionString"></param>
    ''' <param name="Sql"></param>
    ''' <returns>DataTable</returns>
    Public Function GetDataTable(ConnectionString As String, Sql As String) As DataTable

        'the DataTable to return
        Dim MyDataTable As New DataTable
        Try
            'make a SqlConnection using the supplied ConnectionString 
            Dim MySqlConnection As New SqlConnection(ConnectionString)
            Using MySqlConnection
                'make a query using the supplied Sql
                Dim MySqlCommand As SqlCommand = New SqlCommand(Sql, MySqlConnection)

                'open the connection
                MySqlConnection.Open()

                'create a DataReader and execute the SqlCommand
                Dim MyDataReader As SqlDataReader = MySqlCommand.ExecuteReader()

                'load the reader into the datatable
                MyDataTable.Load(MyDataReader)

                'clean up
                MyDataReader.Close()
                MySqlConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Error: Query on " & ConnectionString & " failed. " & ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try

        'return the datatable
        Return MyDataTable
    End Function

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

    Private Sub LoadResultsGrid()
        Try
            If Me.SelectAQueryToolStripComboBox.Text.Trim.Length > 0 Then
                Dim TableName As String = Me.SelectAQueryToolStripComboBox.Text.Trim
                Dim WhereClause As String = " WHERE SurveyName='" & CurrentSurveyName & "'"
                Dim Sql As String = "SELECT * FROM " & TableName & WhereClause
                Debug.Print(Sql)
                Dim DT As DataTable = GetDataTable(My.Settings.MooseConnectionString, Sql)

                'Load the results grid
                With Me.ResultsGridControl
                    .DataSource = DT
                    .RefreshDataSource()
                    .DefaultView.ViewCaption = Sql
                End With

                'load the results pivot grid
                With Me.ResultsPivotGridControl
                    .DataSource = DT
                    '.RefreshData()
                    .RetrieveFields()
                    .Text = Sql
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub
End Class
