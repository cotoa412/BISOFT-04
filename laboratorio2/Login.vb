Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click

        Dim Username As String = TextBoxUsername.Text
        Dim Password As String = TextBoxPassword.Text
        Dim connection As New SqlConnection
        Dim command As New SqlCommand

        If (Password = "" Or Username = "") Then
            LabelError.Text = "Debe llenar todos los campos"
            LabelError.Visible = True

        Else

            Dim connectionString As String = "Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

            connection = New SqlConnection(connectionString)

            Dim selectQuery As String
            selectQuery = "SELECT * FROM [User] WHERE username = '" & Username & "'" & " AND password ='" & Password & "'"
            command = New SqlCommand(selectQuery, connection)

            connection.Open()

            Dim reader As SqlDataReader = command.ExecuteReader

            If reader.HasRows Then
                Profile.Show()
                Me.Hide()

            Else
                LabelError.Text = "El Usuario No Existe"
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
End Class