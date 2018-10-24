Imports System.Data.SqlClient

Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click
        Dim User As New User
        User.Email1 = TextBoxEmail.Text
        User.Name1 = TextBoxName.Text
        User.Username1 = TextBoxUsername.Text
        User.Password1 = TextBoxPassword.Text

        Dim connection As New SqlConnection
        Dim command As New SqlCommand

        Dim connectionString As String = "Data Source= SP-LAB9-16;Initial Catalog=ProjectDB;User ID=sa;Password=123456"

        connection = New SqlConnection(connectionString)
        Dim insertQuery As String
        insertQuery = "INSERT INTO Profile (user) VALUES(@user)"
        command = New SqlCommand(insertQuery, connection)

        With command
            .Parameters.AddWithValue("@user", User)
        End With

        connection.Open()
        command.ExecuteNonQuery()
        command.Dispose()
        connection.Close()
        MsgBox("Perfil creado")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class