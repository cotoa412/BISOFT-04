Imports System.Data.SqlClient

Public Class Profile
    Dim db As New database

    Private Sub Mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrar.CheckedChanged
        If CheckBoxMostrar.Checked = True Then
            TextBoxPassword.PasswordChar = ""
        Else
            TextBoxPassword.PasswordChar = "*"
        End If
    End Sub



    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim UserName = TextBoxUser.Text
        Dim Name = TextBoxName.Text
        Dim Password = TextBoxPassword.Text
        Dim Email = TextBoxEmail.Text

        Dim insertQuery As String
        insertQuery = "UPDATE [User] SET Name ='" & Name & "', UserName ='" & UserName & "', Password ='" & Password & "', Email ='" & Email & "' WHERE  [UserName]='" & Login.TextBoxUsername.Text & "' AND [Password] ='" & Login.TextBoxPassword.Text & "'"
        db.ExecuteQuery(insertQuery)
        Label5.Visible = True
        Label5.Text = "Actualizado correctamente"
    End Sub

    Private Sub ButtonSave_MouseLeave(sender As Object, e As EventArgs) Handles ButtonSave.MouseLeave
        Label5.Visible = False
    End Sub
End Class