Imports System.Data.SqlClient
Public Class ConnectionDB

    Public connection As SqlConnection

    Public Function Connect()

        Try

            Connection = New SqlConnection("Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=********;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Connection.Open()
            Return Connection
            Return True

        Catch ex As Exception

            MsgBox("Error al conectar con la base de datos" & vbCrLf & ex.Message)
            Return False

        End Try

    End Function

    Public Function Disconnect()

        Try

            If Connection.State = ConnectionState.Open Then

                Connection.Close()
                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function




End Class
