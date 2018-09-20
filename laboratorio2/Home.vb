Public Class Home
    Private Sub AdministratToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministratToolStripMenuItem.Click

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLabel.Text = "Bienvenido, " & Form1.UserTextBox.Text
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilToolStripMenuItem.Click
        Me.Hide()
        Profile.Show()
    End Sub

    Private Sub TareasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TareasToolStripMenuItem.Click
        Me.Hide()
        Homeworks.Show()
    End Sub
End Class