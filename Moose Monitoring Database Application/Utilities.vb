Imports System.Data.SqlClient
Imports DevExpress.XtraGrid

Module Utilities

    ''' <summary>
    ''' Loads all available queries in the Moose database into QuerySelectorComboBox.
    ''' </summary>
    ''' <param name="QuerySelectorComboBox">ToolStripComboBox into which to load available database queries.</param>
    Public Sub LoadQuerySelectorComboBox(QuerySelectorComboBox As ToolStripComboBox)
        Try
            'clear the query selector combo boxes
            QuerySelectorComboBox.Items.Clear()
            QuerySelectorComboBox.Items.Add("")

            'Get a list of tables and queries to load into the queries selector combo box
            Dim QueriesDataTable As DataTable = GetDataTable(My.Settings.MooseConnectionString, "SELECT [Table],TableDescription,SelectQuery from DatabaseTableDescriptions ORDER BY [Table]")
            For Each QueryRow As DataRow In QueriesDataTable.Rows
                QuerySelectorComboBox.Items.Add(QueryRow.Item("Table"))
            Next
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

    Public Sub SaveResultsToExcel(ResultsGridControl As GridControl)
        Try
            Dim SFD As New SaveFileDialog
            With SFD
                .Filter = "Excel Files (*.xlsx)|*.xlsx"
                .AddExtension = True
                .DefaultExt = ".xlsx"
                .OverwritePrompt = True
                .Title = "Save results"
            End With
            If SFD.ShowDialog = vbOK Then
                Dim Path As String = SFD.FileName
                ResultsGridControl.ExportToXlsx(Path)
                If MsgBox("Open the exported spreadsheet?", MsgBoxStyle.YesNo, "Open the exported spreadsheet?") = MsgBoxResult.Yes Then
                    Process.Start(Path)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

End Module
