Imports laboratorio2

Public Class Activities
    Private Id As Integer
    Private Name As String
    Private Date_hours As DateTime
    Private Course As Course

    Public Property Name_Activities As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property Date_hours_Activities As Date
        Get
            Return Date_hours
        End Get
        Set(value As Date)
            Date_hours = value
        End Set
    End Property

    Public Property Course_Activities As Course
        Get
            Return Course
        End Get
        Set(value As Course)
            Course = value
        End Set
    End Property

    Public Property Id_Activities As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
End Class
