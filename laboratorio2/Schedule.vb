Public Class Schedule
    Private Id As Integer
    Private Activities As Activities


    Public Property Activities_Schedule As Activities
        Get
            Return Activities
        End Get
        Set(value As Activities)
            Activities = value
        End Set
    End Property

    Public Property Id_Schedule As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
End Class
