Imports System.Data.SqlClient
Public Class Material
    Dim Connection As SqlConnection
    Dim Command As SqlCommand
    Dim Reader As SqlDataReader
    Dim Adapter As SqlDataAdapter
    Dim Document As String
    Dim NameCourse As String
    Dim IdCourse As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        LabelChange.Visible = False
        Dim Open As New OpenFileDialog
        Dim Result As New DialogResult

        Result = Open.ShowDialog
        Document = Open.FileName

        If ComboBoxCourse1.SelectedItem = "" Then

            LabelChange.Text = "Debe seleccionar el curso donde desea agregar el documento"
            LabelChange.ForeColor = Color.Red
            LabelChange.Visible = True

        Else
            Dim CommandInsert As New SqlCommand("INSERT iNTO [Document] (PathDocument,CourseDocument,NameDocument,DescriptionDocument)VALUES(@PathDocument,@CourseDocument,@NameDocument,@DescriptionDocument)", Connection)

            With CommandInsert

                .Parameters.AddWithValue("@PathDocument", Document)
                .Parameters.AddWithValue("@CourseDocument", IdCourse)
                .Parameters.AddWithValue("@NameDocument", "aaaaa")
                .Parameters.AddWithValue("@DescriptionDocument", "aaaaa")

            End With
            Connection.Close()
            Connection.Open()
            CommandInsert.ExecuteNonQuery()

            LabelChange.ForeColor = Color.Green
            LabelChange.Text = "Guardado con éxito"
            LabelChange.Visible = True
            ShowData()
        End If



    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection = New SqlConnection("Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Command = New SqlCommand("Select c.[IdCourse],c.[NameCourse]
	                            	From Course c, CourseUser cu, [User] u
	                            	Where cu.IdCourse = c.IdCourse 
		                            And cu.IdUser=u.Id ", Connection)
        Connection.Open()

        Reader = Command.ExecuteReader

        While Reader.Read()

            ComboBoxCourse1.Items.Add(Reader.Item("NameCourse"))

        End While
        Connection.Close()

    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        Try
            Document = DataGridView1.SelectedCells.Item(0).OwningRow.Cells.Item(0).Value
            Process.Start(Document)
        Catch ex As Exception
            MsgBox("Error al abrir el archivo. " + ex.Message)
        End Try

    End Sub

    Private Sub ComboBoxCourse1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse1.SelectedValueChanged
        ShowData()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        LabelChange.Visible = False

        Document = DataGridView1.SelectedCells.Item(0).OwningRow.Cells.Item(0).Value

        Connection = New SqlConnection("Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Command = New SqlCommand("DELETE FROM [Document] Where [PathDocument]='" & Document & "' And [CourseDocument]='" & IdCourse & "'", Connection)
        Connection.Open()
        Command.ExecuteNonQuery()

        ShowData()
        LabelChange.ForeColor = Color.Green
        LabelChange.Text = "Borrado con éxito"
        LabelChange.Visible = True

    End Sub

    Sub ShowData()
        LabelChange.Visible = False
        NameCourse = ComboBoxCourse1.SelectedItem

        If ComboBoxCourse1.SelectedItem = NameCourse Then

            Connection = New SqlConnection("Data Source=comoquiera.database.windows.net;Initial Catalog=ProjectDB;User ID=Pro;Password=Destiny2!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Command = New SqlCommand("Select c.[IdCourse]
                                    From Course c Where c.NameCourse='" & NameCourse & "'", Connection)

            Connection.Open()
            Reader = Command.ExecuteReader

            Reader.Read()
            IdCourse = Reader.Item("IdCourse")
            Reader.Close()

            Command = New SqlCommand("SELECT d.[PathDocument],c.[NameCourse],d.[NameDocument],d.[DescriptionDocument] FROM [Document]d,[Course]c Where d.[CourseDocument]='" & IdCourse & "'And c.[NameCourse]='" & NameCourse & "'", Connection)

            Dim dt As New DataTable
            Adapter = New SqlDataAdapter(Command)
            Adapter.Fill(dt)
            Command.ExecuteNonQuery()
            DataGridView1.DataSource = dt
            Connection.Close()

        End If


    End Sub
End Class