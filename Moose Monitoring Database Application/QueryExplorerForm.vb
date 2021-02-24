Public Class QueryExplorerForm
    Private Sub QueryExplorerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuerySelectorComboBox(Me.DataSourceToolStripComboBox)
    End Sub

    Private Sub DataSourceToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataSourceToolStripComboBox.SelectedIndexChanged
        LoadGridControl()
        LoadPivotGrid()
    End Sub

    Private Sub LoadPivotGrid()
        Try
            'clear the pivot grid
            Me.DataPivotGridControl.DataSource = Nothing
            Me.DataPivotGridControl.RetrieveFields()


            'see if we have a data source
            If Me.DataSourceToolStripComboBox.Text.Trim.Length > 0 Then

                'load a data table into the pivot grid
                Dim TableName As String = Me.DataSourceToolStripComboBox.Text.Trim
                Dim Sql As String = "SELECT * FROM " & TableName
                Dim DT As DataTable = GetDataTable(My.Settings.MooseConnectionString, Sql)

                'load the results pivot grid
                With Me.DataPivotGridControl
                    .DataSource = DT
                    .RetrieveFields()
                    .Text = Sql
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadGridControl()
        Try
            If Me.DataSourceToolStripComboBox.Text.Trim.Length > 0 Then
                Dim TableName As String = Me.DataSourceToolStripComboBox.Text.Trim
                Dim Sql As String = "SELECT * FROM " & TableName
                Dim DT As DataTable = GetDataTable(My.Settings.MooseConnectionString, Sql)

                'Load the results grid
                With Me.DataGridControl
                    .DataSource = DT
                    .MainView.PopulateColumns()
                    .Text = Sql
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


End Class