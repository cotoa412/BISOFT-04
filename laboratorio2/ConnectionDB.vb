Imports System.Data.SqlClient
Public Class ConnectionDB

    Protected Connection As SqlConnection

    Public Function Connect()

        Try

            Connection = New SqlConnection("Data Source=SP-LAB9-17;Initial Catalog=ProjectDB;User ID=sa;Password=123456 ")
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
