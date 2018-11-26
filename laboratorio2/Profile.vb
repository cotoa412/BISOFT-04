Imports System.Data.SqlClient

Public Class Profile
    Dim db As New database

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        Calendario.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs)
        'Horario.Show()
        tiempo.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs)
        Material.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs)
        Cursos.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrar.CheckedChanged
        If CheckBoxMostrar.Checked = True Then
            TextBoxPassword.PasswordChar = ""
        Else
            TextBoxPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim UserName = TextBoxUser.Text
        Dim Name = TextBoxName.Text
        Dim Password = TextBoxPassword.Text
        Dim Email = TextBoxEmail.Text

        Dim insertQuery As String
        insertQuery = "UPDATE [User] SET Name ='" & Name & "', UserName ='" & UserName & "', Password ='" & Password & "', Email ='" & Email & "' WHERE  [UserName]='" & Login.TextBoxUsername.Text & "' AND [Password] ='" & Login.TextBoxPassword.Text & "'"
        db.ExecuteQuery(insertQuery)

        Label5.Text = "Actualizado correctamente"
    End Sub


End Class