Imports laboratorio2

Public Class Activities
    Private Name As String
    Private Date_hours As DateTime
    Private Course As Course

    Public Property Name1 As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property Date_hours1 As Date
        Get
            Return Date_hours
        End Get
        Set(value As Date)
            Date_hours = value
        End Set
    End Property

    Public Property Course1 As Course
        Get
            Return Course
        End Get
        Set(value As Course)
            Course = value
        End Set
    End Property
End Class
