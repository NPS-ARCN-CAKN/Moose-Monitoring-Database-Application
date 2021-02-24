Public Class GSPE_PivotForm
    Private Sub GSPE_PivotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MooseDataSet.GSPE' table. You can move, or remove it, as needed.
        Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE)

        'LoadDataSourceSelectorComboBox()

    End Sub

    'Private Sub LoadDataSourceSelectorComboBox()
    '    LoadQuerySelectorComboBox(Me.QuerySelectorToolStripComboBox)
    'End Sub

    'Private Sub QuerySelectorToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuerySelectorToolStripComboBox.SelectedIndexChanged
    '    Try
    '        'clear the pivot grid
    '        Me.GSPEPivotGridControl.DataSource = Nothing
    '        Me.GSPEPivotGridControl.RetrieveFields()

    '        'see if we have a data source
    '        If Me.QuerySelectorToolStripComboBox.Text.Trim.Length > 0 Then

    '            'load a data table into the pivot grid
    '            Dim TableName As String = Me.QuerySelectorToolStripComboBox.Text.Trim
    '            Dim Sql As String = "SELECT * FROM " & TableName
    '            Dim DT As DataTable = GetDataTable(My.Settings.MooseConnectionString, Sql)

    '            'load the results pivot grid
    '            With Me.GSPEPivotGridControl
    '                .DataSource = DT
    '                .RetrieveFields()
    '                .Text = Sql
    '            End With
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
    '    End Try
    'End Sub
End Class