Public Class User
    Private id As String
    Private name As String
    Private username As String
    Private email As String
    Private password As String
    Private courses As New List(Of Course)
    Private schedule As Schedule

    Public Property Id_User As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property Name_User As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Username_User As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Email_User As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Password_User As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property Courses_User As List(Of Course)
        Get
            Return courses
        End Get
        Set(value As List(Of Course))
            courses = value
        End Set
    End Property

    Public Property Schedule_User As Schedule
        Get
            Return schedule
        End Get
        Set(value As Schedule)
            schedule = value
        End Set
    End Property
End Class
