Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Module Utilities

    '''' <summary>
    '''' Returns the current cell value of GridControl.
    '''' </summary>
    '''' <param name="GridControl">GridControl to interrogate.</param>
    '''' <returns></returns>
    'Public Function GetCurrentGridControlCellValue(GC As GridControl) As String
    '    Dim ReturnValue As String = ""
    '    Try
    '        'Get the current text
    '        ReturnValue = GC.GetCellValue(GC.FocusedRow, GC.FocusedRecord).ToString
    '    Catch ex As Exception
    '        MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
    '    End Try
    '    Return ReturnValue
    'End Function

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

    ''' <summary>
    ''' Data export format.
    ''' </summary>
    Enum ExportFormat
        xlsx
        csv
    End Enum

    ''' <summary>
    ''' Saves the immediate contents of GridControl to the format specified by ExportFormat.
    ''' </summary>
    ''' <param name="GridControl">CridControl contents to export.</param>
    ''' <param name="ExportFormat">Export data format.</param>
    Public Sub SaveGridControlToExcel(GridControl As GridControl, ExportFormat As ExportFormat)
        Try
            'Build a save file dialog filter based on ExportFormat
            Dim Filter As String = ""
            If ExportFormat = ExportFormat.csv Then
                Filter = "Comma Separated Values text files (*.csv)|*.csv"
            ElseIf ExportFormat = ExportFormat.xlsx Then
                Filter = "Excel Files (*.xlsx)|*.xlsx"
            End If

            'Open a SaveFileDialog to allow the user to choose an export path.
            Dim SFD As New SaveFileDialog
            With SFD
                .Filter = Filter
                .AddExtension = True
                .DefaultExt = "." & ExportFormat.ToString
                .OverwritePrompt = True
                .Title = "Save results"
                .InitialDirectory = "C:\"
            End With

            'Show the save file dialog and if a path is chosen export the control's data to ExportFormat.
            If SFD.ShowDialog = vbOK Then
                Dim Path As String = SFD.FileName
                If ExportFormat = ExportFormat.xlsx Then
                    GridControl.ExportToXlsx(Path)
                ElseIf ExportFormat = ExportFormat.csv Then
                    GridControl.ExportToCsv(Path)
                End If

                'Ask if the user wants to open the exported file
                If MsgBox("Open the exported spreadsheet?", MsgBoxStyle.YesNo, "Open the exported spreadsheet?") = MsgBoxResult.Yes Then
                    Process.Start(Path)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Saves the immediate contents of GridControl to the format specified by ExportFormat.
    ''' </summary>
    ''' <param name="PivotGridControl">CridControl contents to export.</param>
    ''' <param name="ExportFormat">Export data format.</param>
    Public Sub SavePivotGridControlToExcel(PivotGridControl As PivotGridControl, ExportFormat As ExportFormat)
        Try
            Try
                'Build a save file dialog filter based on ExportFormat
                Dim Filter As String = ""
                If ExportFormat = ExportFormat.csv Then
                    Filter = "Comma Separated Values text files (*.csv)|*.csv"
                ElseIf ExportFormat = ExportFormat.xlsx Then
                    Filter = "Excel Files (*.xlsx)|*.xlsx"
                End If

                'Open a SaveFileDialog to allow the user to choose an export path.
                Dim SFD As New SaveFileDialog
                With SFD
                    .Filter = Filter
                    .AddExtension = True
                    .DefaultExt = "." & ExportFormat.ToString
                    .OverwritePrompt = True
                    .Title = "Save results"
                End With

                'Show the save file dialog and if a path is chosen export the control's data to ExportFormat.
                If SFD.ShowDialog = vbOK Then
                    Dim Path As String = SFD.FileName
                    If ExportFormat = ExportFormat.xlsx Then
                        PivotGridControl.ExportToXlsx(Path)
                    ElseIf ExportFormat = ExportFormat.csv Then
                        PivotGridControl.ExportToCsv(Path)
                    End If

                    'Ask if the user wants to open the exported file
                    If MsgBox("Open the exported spreadsheet?", MsgBoxStyle.YesNo, "Open the exported spreadsheet?") = MsgBoxResult.Yes Then
                        Process.Start(Path)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

End Module
