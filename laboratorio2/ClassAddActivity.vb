Imports System.Data.SqlClient
Public Class ClassAddActivity
    Dim Connection As New SqlConnection("Data Source= DESKTOP-NR4PGLT\SQLSERVERME;Initial Catalog=ProjectDB;User ID=sa;Password=123456")
    Dim Command As SqlCommand

    Public Function AddActivity()

        Dim Activity As New Activities
        Dim TheCourse As New Course

        Dim NameActivity As String = "Repasar algebra "
        Dim DateHour As Date = "03/11/19"
        Dim Course As Integer = 4


        Activity.Name_Activities = NameActivity
        Activity.DateHour_Activities = DateHour
        TheCourse.Id_Course = Course


        Command = New SqlCommand("INSERT INTO [Activity] (NameActivity,DateHour,Course) VALUES(@NameActivity,@DateHour,@Course)", Connection)

        With Command

            .Parameters.AddWithValue("@NameActivity", Activity.Name_Activities)
            .Parameters.AddWithValue("@DateHour", Activity.DateHour_Activities)
            .Parameters.AddWithValue("@Course", TheCourse.Id_Course)
        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        Return True

    End Function







End Class
