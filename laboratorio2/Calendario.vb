Public Class Calendario
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDay As DateTime
        firstDay = New DateTime(Now.Year, Now.Month, 1)
        Label1.Text = Date.Today.DayOfWeek.ToString()

    End Sub
End Class