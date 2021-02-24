Public Class PopulationEstimateAnalyticsForm
    Private Sub PopulationEstimateAnalyticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MooseDataSet.GSPE_Surveys' table. You can move, or remove it, as needed.
        Me.GSPE_SurveysTableAdapter.Fill(Me.MooseDataSet.GSPE_Surveys)
        'TODO: This line of code loads data into the 'MooseDataSet.GSPE' table. You can move, or remove it, as needed.
        'Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE)

    End Sub
End Class