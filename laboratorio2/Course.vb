Public Class Course

    Private Id As Integer
    Private Name As String
    Private Credits As Integer
    Private Hours As New List(Of DateTime)
    Private ProfessorName As String

    Public Property Name_Course As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property Credits_Course As Integer
        Get
            Return Credits
        End Get
        Set(value As Integer)
            Credits = value
        End Set
    End Property

    Public Property Hours_Course As List(Of Date)
        Get
            Return Hours
        End Get
        Set(value As List(Of Date))
            Hours = value
        End Set
    End Property

    Public Property ProfessorName_Course As String
        Get
            Return ProfessorName
        End Get
        Set(value As String)
            ProfessorName = value
        End Set
    End Property
End Class

