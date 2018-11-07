Imports System.Data.SqlClient

Public Class Profile
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Calendario.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Horario.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        Material.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
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

        Dim connection As New SqlConnection
        Dim command As New SqlCommand

        Dim connectionString As String = "Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        connection = New SqlConnection(connectionString)
        Dim insertQuery As String
        insertQuery = "UPDATE [User] SET Name = @Name, UserName = @UserName, Password = @Password, Email = @Email WHERE  username = '" & UserName & "'" & " AND password ='" & Password & "'"
        command = New SqlCommand(insertQuery, connection)

        With command
            .Parameters.AddWithValue("@Name", Name)
            .Parameters.AddWithValue("@UserName", UserName)
            .Parameters.AddWithValue("@Password", Password)
            .Parameters.AddWithValue("@Email", Email)
        End With

        connection.Open()
        command.ExecuteNonQuery()
        command.Dispose()
        connection.Close()
    End Sub
End Class