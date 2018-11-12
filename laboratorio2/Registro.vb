Imports System.Data.SqlClient

Public Class Registro
    Dim db = New database

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

            Dim insertQuery As String = "INSERT INTO [User] (Name,Username,Password,Email) VALUES('" & User.Name_User & "','" & User.Username_User & "','" & User.Password_User & "','" & User.Email_User & "')"

            db.ExecuteQuery(insertQuery)
            MsgBox("Registro Completado", MsgBoxStyle.MsgBoxRight, "Registro")
            Me.Close()
            Login.Show()
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class