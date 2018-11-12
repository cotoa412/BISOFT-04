Imports System.Data.SqlClient
Public Class ClassAddActivity
    Dim db As New database

    Public Function AddActivity()

        Dim Activity As New Activities
        Dim TheCourse As New Course

        Dim NameActivity As String = "Repasar algebra "
        Dim DateHour As Date = "03/11/19"
        Dim Course As Integer = 4


        Activity.Name_Activities = NameActivity
        Activity.DateHour_Activities = DateHour
        TheCourse.Id_Course = Course


        db.ExecuteQuery("INSERT INTO [Activity] (NameActivity,DateHour,Course) VALUES('" & Activity.Name_Activities & "','" & Activity.DateHour_Activities & "','" & TheCourse.Id_Course & "')")

        Return True

    End Function







End Class
