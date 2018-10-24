Imports laboratorio2

Public Class Schedule

    Private Id As Integer
    Private Activities As New List(Of Activities)

    Public Property Id_Schedule As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property Activities_Schedule As List(Of Activities)
        Get
            Return Activities
        End Get
        Set(value As List(Of Activities))
            Activities = value
        End Set
    End Property
End Class
