Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Este es un comentario
        Dim Username As String
        Dim Password As String

        Username = "Jorge"
        Password = "123"

        Dim UsernameIn, PasswordIn As String
        UsernameIn = UserTextBox.Text
        PasswordIn = PasswordTextBox.Text

        If UsernameIn.ToLower().Equals(Username.ToLower()) Then
            If PasswordIn.Equals(Password) Then
                Home.Show()
                Me.Hide()
            Else
                MsgBox("Contraseña Incorrecta")
            End If
        Else
            MsgBox("Usuario Incorrecto")
        End If
    End Sub
End Class
