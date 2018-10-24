Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click
        Dim Username As String = TextBoxUsername.Text
        Dim Password As String = TextBoxPassword.Text
        Dim connection As New SqlConnection
        Dim command As New SqlCommand

        Dim connectionString As String = "Data Source= SP-LAB9-16;Initial Catalog=ProjectDB;User ID=sa;Password=123456"

        connection = New SqlConnection(connectionString)

        Dim selectQuery As String
        selectQuery = "SELECT * FROM Profile WHERE username = '" & Username & "'" & " AND password ='" & Password & "'"
        command = New SqlCommand(selectQuery, connection)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader

        If reader.HasRows Then
            Me.Close()


        Else
            MsgBox("Usuario o contraseña incorrecta.")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Me.Close()
        Registro.Show()
    End Sub
End Class