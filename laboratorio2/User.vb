Public Class User
    Private name As String
    Private username As String
    Private email As String
    Private password As String
    Private courses As New List(Of Course)
    Private schedule As Schedule

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Password1 As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property Courses1 As List(Of Course)
        Get
            Return courses
        End Get
        Set(value As List(Of Course))
            courses = value
        End Set
    End Property

    Public Property Schedule1 As Schedule
        Get
            Return schedule
        End Get
        Set(value As Schedule)
            schedule = value
        End Set
    End Property
End Class
