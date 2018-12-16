Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Registro
    Dim db = New database
    Dim dbValidation As New database
    Dim User As New User
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click

        User.Email_User = TextBoxEmail.Text
        User.Name_User = TextBoxName.Text
        User.Username_User = TextBoxUsername.Text
        User.Password_User = TextBoxPassword.Text

        If (User.Name_User = "" Or User.Password_User = "" Or User.Username_User = "" Or User.Email_User = "") Then

            LabelError.Text = "Debe llenar todos los campos"
            LabelError.Visible = True

        Else

            Dim Row = dbValidation.ReaderQuery("Select UserName From [User] Where UserName='" & User.Username_User & "'")


            If Row.Count > 0 Then
                LabelError.Text = "Nombre de usuario no disponible"
                LabelError.ForeColor = Color.Red
                LabelError.Visible = True
            ElseIf validar_Mail(LCase(TextBoxEmail.Text)) = False Then
                LabelError.Text = "Correo en formato no válido"
                LabelError.ForeColor = Color.Red
                LabelError.Visible = True
            Else
                Dim insertQuery As String = "INSERT INTO [User] (Name,Username,Password,Email) VALUES('" & User.Name_User & "','" & User.Username_User & "','" & User.Password_User & "','" & User.Email_User & "')"
                db.ExecuteQuery(insertQuery)
                MsgBox("Registro Completado", MsgBoxStyle.MsgBoxRight, "Registro")
                Me.Close()
                Login.Show()
            End If



        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub


    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            LabelError.Visible = False
        End If
    End Sub

    Private Sub TextBoxUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            LabelError.Visible = False
        End If
    End Sub

    Private Sub TextBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxName.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            LabelError.Visible = False
        End If
    End Sub

    Private Sub TextBoxEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEmail.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            LabelError.Visible = False
        End If
    End Sub
End Class