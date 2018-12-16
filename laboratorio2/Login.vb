Imports System.Data.SqlClient

Public Class Login
    Dim db As New database
    Dim val As Boolean = False
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub


    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click

        Dim Username As String = TextBoxUsername.Text
        Dim Password As String = TextBoxPassword.Text

        If (Password = "" Or Username = "") Then
            LabelError.Text = "Debe llenar todos los campos"
            LabelError.Visible = True

        Else
            Dim selectQuery As String = "SELECT * FROM [User] WHERE username = '" & Username & "'" & " AND password ='" & Password & "'"

            Dim rows = db.ReaderQuery(selectQuery)

            If rows.Count > 0 Then

                Profile.TextBoxUser.Text = rows(0).Item("UserName")
                Profile.TextBoxName.Text = rows(0).Item("Name")
                Profile.TextBoxPassword.Text = rows(0).Item("Password")
                Profile.TextBoxEmail.Text = rows(0).Item("Email")

                Profile.Show()
                Me.Hide()
            Else
                LabelError.Text = "Usuario o contraseña incorrecta"
                LabelError.Visible = True
            End If



        End If



    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub


    Private Sub LabelRecoverPassword_Click(sender As Object, e As EventArgs) Handles LabelRecoverPassword.Click

        RecoverPassword.Show()
        Me.Hide()

    End Sub

    Private Sub LabelRegister_Click(sender As Object, e As EventArgs) Handles LabelRegister.Click
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        Dim Username As String = TextBoxUsername.Text
        Dim Password As String = TextBoxPassword.Text
        If Char.IsLetterOrDigit(e.KeyChar) Then
            LabelError.Visible = False
        End If
        If Asc(e.KeyChar) = 13 Then
            Dim selectQuery As String = "SELECT * FROM [User] WHERE username = '" & Username & "'" & " AND password ='" & Password & "'"

            Dim rows = db.ReaderQuery(selectQuery)

            If rows.Count > 0 Then

                Profile.TextBoxUser.Text = rows(0).Item("UserName")
                Profile.TextBoxName.Text = rows(0).Item("Name")
                Profile.TextBoxPassword.Text = rows(0).Item("Password")
                Profile.TextBoxEmail.Text = rows(0).Item("Email")

                Profile.Show()
                Me.Hide()
            Else
                LabelError.Text = "Usuario o contraseña incorrecta"
                LabelError.Visible = True
            End If
        End If
    End Sub

    Private Sub TextBoxUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUsername.KeyPress
        Dim Username As String = TextBoxUsername.Text
        Dim Password As String = TextBoxPassword.Text
        If Char.IsLetterOrDigit(e.KeyChar) Then
            LabelError.Visible = False
        End If
        If Asc(e.KeyChar) = 13 Then

            Dim selectQuery As String = "SELECT * FROM [User] WHERE username = '" & Username & "'" & " AND password ='" & Password & "'"

            Dim rows = db.ReaderQuery(selectQuery)

            If rows.Count > 0 Then

                Profile.TextBoxUser.Text = rows(0).Item("UserName")
                Profile.TextBoxName.Text = rows(0).Item("Name")
                Profile.TextBoxPassword.Text = rows(0).Item("Password")
                Profile.TextBoxEmail.Text = rows(0).Item("Email")

                Profile.Show()
                Me.Hide()
            Else
                LabelError.Text = "Usuario o contraseña incorrecta"
                LabelError.Visible = True
            End If
        End If
    End Sub

End Class