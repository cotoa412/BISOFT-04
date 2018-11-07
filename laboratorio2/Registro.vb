Imports System.Data.SqlClient

Public Class Registro
    Dim User As New User
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click

        User.Email_User = TextBoxEmail.Text
        User.Name_User = TextBoxName.Text
        User.Username_User = TextBoxUsername.Text
        User.Password_User = TextBoxPassword.Text

        If (User.Name_User = "" Or User.Password_User = "" Or User.Username_User = "" Or User.Email_User = "") Then

            LabelError.Text = "Debe llenar todos los campos"
            LabelError.Visible = True

        Else
            Dim connection As New SqlConnection
            Dim command As New SqlCommand

            Dim connectionString As String = "Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

            connection = New SqlConnection(connectionString)
            Dim insertQuery As String
            insertQuery = "INSERT INTO [User] (Name,Username,Password,Email) VALUES(@Name,@UserName,@Password,@Email)"
            command = New SqlCommand(insertQuery, connection)

            With command

                .Parameters.AddWithValue("@Name", User.Name_User)
                .Parameters.AddWithValue("@UserName", User.Username_User)
                .Parameters.AddWithValue("@Password", User.Password_User)
                .Parameters.AddWithValue("@Email", User.Email_User)
            End With

            connection.Open()
            command.ExecuteNonQuery()
            command.Dispose()
            MsgBox("Registro Completado", MsgBoxStyle.MsgBoxRight, "Registro")
            connection.Close()


            Me.Close()
            Login.Show()
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class