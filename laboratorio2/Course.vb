Public Class Course


    Private Name As String
    Private Credits As Integer
    Private Hours As New List(Of DateTime)
    Private ProfessorName As String

    Public Property Name1 As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property Credits1 As Integer
        Get
            Return Credits
        End Get
        Set(value As Integer)
            Credits = value
        End Set
    End Property

    Public Property Hours1 As List(Of Date)
        Get
            Return Hours
        End Get
        Set(value As List(Of Date))
            Hours = value
        End Set
    End Property

    Public Property ProfessorName1 As String
        Get
            Return ProfessorName
        End Get
        Set(value As String)
            ProfessorName = value
        End Set
    End Property
End Class

