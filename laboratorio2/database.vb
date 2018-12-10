Option Strict Off
Imports System.Data.SqlClient


Public Class database
    '' Private connectionString = ¨stringLocal¨
    Private connectionString = "Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Private connection As SqlConnection


    Private Function Connect()
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            Return connection

        Catch ex As Exception

            MsgBox("Error al conectar con la base de datos" & vbCrLf & ex.Message)
            Return False

        End Try
    End Function

    Public Function ExecuteQuery(commandString As String)
        Dim command = New SqlCommand(commandString, Connect())
        command.ExecuteNonQuery()

        Disconnect()
    End Function

    Public Function ReaderQuery(commandString As String)
        Dim command = New SqlCommand(commandString, Connect())
        Dim dr = command.ExecuteReader()


        Dim list As New List(Of Dictionary(Of String, Object))
        Dim columns = New List(Of String)
        Dim index = 0

        While index < dr.FieldCount
            columns.Add(dr.GetName(index))
            index += 1
        End While

        While dr.Read()
            Dim row As New Dictionary(Of String, Object)

            For Each column In columns
                row.Add(column, dr.Item(column))
            Next
            list.Add(row)
        End While

        Disconnect()
        Return list
    End Function

    Public Function AdapterQuery(commandString As String)
        Dim dt As New DataTable
        Dim Adapter As SqlDataAdapter
        Dim command = New SqlCommand(commandString, Connect())

        Adapter = New SqlDataAdapter(Command)
        Adapter.Fill(dt)
        command.ExecuteNonQuery()

        Disconnect()
        Return dt
    End Function

    Public Function Disconnect()

        Try

            If connection.State = ConnectionState.Open Then

                connection.Close()
                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function '''




End Class
