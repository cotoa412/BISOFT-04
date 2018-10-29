Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class RecoverPassword
    Dim Command As SqlCommand
    Dim Connection As SqlConnection
    Dim Password_RecoverPassword As String
    Dim Email_RecoverPassword As String
    Dim Cond As Boolean
    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click

        Dim UserName_RecoverPassword = TextBoxUser.Text

        If UserName_RecoverPassword = "" Then

            MsgBox("Debe ingresar los datos solicitados")

        Else
            Connection = New SqlConnection("Data Source=DESKTOP-NR4PGLT\SQLSERVERME;Initial Catalog=ProjectDB;User ID=sa;Password=123456")
            Command = New SqlCommand("Select [Password],[Email] From [User] Where [UserName]='" & UserName_RecoverPassword.ToString & "'", Connection)
            Dim reader As SqlDataReader
            Connection.Open()

            reader = Command.ExecuteReader

            If reader.HasRows Then

                reader.Read()
                Password_RecoverPassword = reader.GetString(0)
                Email_RecoverPassword = reader.GetString(1)
                Cond = True

            Else

                Cond = False

            End If



            If Cond = True Then
                Dim Mail As New MailMessage
                Try

                    Mail.From = New MailAddress("parapropruebas@gmail.com")
                    Mail.To.Add(Email_RecoverPassword.ToString)
                    Mail.Subject = ("Recuperación de contraseña")
                    Mail.Body = ("Su contraseña es: " & Password_RecoverPassword.ToString)

                    Dim Server As New SmtpClient("smtp.gmail.com")
                    Server.Port = 587
                    Server.EnableSsl = True
                    Server.Credentials = New System.Net.NetworkCredential("parapropruebas@gmail.com", "123456pruebas")
                    Server.Send(Mail)
                    MsgBox("Se ha enviado la contraseña a tu correo")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Usuario no registrado")
            End If

        End If



    End Sub

    Private Sub RecoverPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class