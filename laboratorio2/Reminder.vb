Public Class Reminder
    Dim db As New database
    Dim Fecha As DateTime
    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Label_Change()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Calendario.Show()
    End Sub
End Class