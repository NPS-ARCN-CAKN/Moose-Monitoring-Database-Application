Public Class MooseSurvey

    Private SurveyNameValue As String
    Public Property SurveyName() As String
        Get
            Return SurveyNameValue
        End Get
        Set(ByVal value As String)
            SurveyNameValue = value
        End Set
    End Property

    Private IsCertifiedValue As Boolean
    Public Property IsCertified() As Boolean
        Get
            Return IsCertifiedValue
        End Get
        Set(ByVal value As Boolean)
            IsCertifiedValue = value
        End Set
    End Property

    Private RecordCountValue As Integer
    Public Property RecordCount() As Integer
        Get
            Return RecordCountValue
        End Get
        Set(ByVal value As Integer)
            RecordCountValue = value
        End Set
    End Property

    Private ReportCodeValue As Integer
    Public Property ReportCode() As Integer
        Get
            Return ReportCodeValue
        End Get
        Set(ByVal value As Integer)
            ReportCodeValue = value
        End Set
    End Property

    Private DeliverablesCodeValue As Integer
    Public Property DeliverablesCode() As Integer
        Get
            Return DeliverablesCodeValue
        End Get
        Set(ByVal value As Integer)
            DeliverablesCodeValue = value
        End Set
    End Property

    Private PopulationEstimateValue As Integer
    Public Property PopulationEstimate() As Integer
        Get
            Return PopulationEstimateValue
        End Get
        Set(ByVal value As Integer)
            PopulationEstimateValue = value
        End Set
    End Property

    Private PercentCertifiedValue As Integer
    Public Property PercentCertified() As Integer
        Get
            Return PercentCertifiedValue
        End Get
        Set(ByVal value As Integer)
            PercentCertifiedValue = value
        End Set
    End Property

    Private DatasetProcessingStepsValue As String
    Public Property DatasetProcessingSteps() As String
        Get
            Return DatasetProcessingStepsValue
        End Get
        Set(ByVal value As String)
            DatasetProcessingStepsValue = value
        End Set
    End Property

End Class
