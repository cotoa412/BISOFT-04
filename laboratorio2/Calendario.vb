﻿Public Class Calendario
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDay As DateTime
        Dim week, day As Int16
        Dim dateNum As Int32
        Dim DaysInMonth As Integer = Date.DaysInMonth(Now.Year, Now.Month)
        firstDay = New DateTime(Now.Year, Now.Month, 1)
        day = CInt(firstDay.DayOfWeek)
        If day = 0 Then day = 7

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

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Profile.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Horario.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Material.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Cursos.Show()
        Me.Close()

    End Sub

    Private Sub d2_3_Click(sender As Object, e As EventArgs) Handles d2_3.Click

    End Sub
End Class