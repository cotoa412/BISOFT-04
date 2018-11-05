Public Class Calendario
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDay As DateTime
        Dim week, day As Int16
        Dim dateNum As Int32
        Dim DaysInMonth As Integer = Date.DaysInMonth(Now.Year, Now.Month)
        firstDay = New DateTime(Now.Year, Now.Month, 1)
        day = CInt(firstDay.DayOfWeek)

        week = 1
        dateNum = 1

        While dateNum <= DaysInMonth
            Dim label As Label = CType(Me.Controls("d" + CStr(week) + "_" + CStr(day)), Label)
            label.Text = CStr(dateNum)

            dateNum += 1
            day += 1
            If day > 7 Then
                day = 1
                week += 1
            End If
        End While



    End Sub
End Class