Imports System.Data.SqlClient
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Auth
Imports Microsoft.WindowsAzure.Storage.Blob
Imports System.IO


Public Class Material

    Dim Document As String
    Dim NameCourse As String
    Dim IdCourse As Integer
    Dim NameDocument As String
    Dim Description As String
    Dim IdDocument As Integer
    Dim db = New database
    Private m_csa_storageAccount As CloudStorageAccount

    Public ReadOnly Property Csa_storageAccount() As CloudStorageAccount
        Get
            If m_csa_storageAccount Is Nothing Then
                Dim strAccount As String = "concinnity"
                Dim strKey As String = "tPeyMjjE7X2dvJKure3NnDLoOnnHw9Ogzis4a4Sjc8LUXpLM5nbhPjRNUufA6iCHsIyEkphs9oxVKgE9kVcEtg=="

                Dim credential As New StorageCredentials(strAccount, strKey)
                m_csa_storageAccount = New CloudStorageAccount(credential, True)
            End If
            Return m_csa_storageAccount
        End Get
    End Property

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click

        Dim Open As New OpenFileDialog
        Dim Result As New DialogResult

        Result = Open.ShowDialog
        Document = Open.FileName

        If ComboBoxCourse1.SelectedItem = "" Then

            LabelChange.Text = "Debe seleccionar el curso donde desea agregar el documento"
            LabelChange.ForeColor = Color.Red
            LabelChange.Visible = True

        Else

            NameDocument = InputBox("Nombre el archivo", "Nombre")
            Description = InputBox("Agrege una descripción", "Descripción")
            Dim sc As StorageCredentials = New StorageCredentials("concinnity", "tPeyMjjE7X2dvJKure3NnDLoOnnHw9Ogzis4a4Sjc8LUXpLM5nbhPjRNUufA6iCHsIyEkphs9oxVKgE9kVcEtg==")
            Dim storageAccount As CloudStorageAccount = New CloudStorageAccount(sc, True)
            Dim blobclient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
            Dim container As CloudBlobContainer = blobclient.GetContainerReference("proyecto1")
            Dim blockblob = container.GetBlockBlobReference(Document)
            Await blockblob.UploadFromFileAsync(Document)
            Dim CommandInsert As String = "INSERT iNTO [Document] (Ubicación,Curso,Nombre,Descripción) VALUES ('" & Document & "','" & IdCourse & "','" & NameDocument & "','" & Description & "')"
            db.ExecuteQuery(CommandInsert)
            LabelChange.ForeColor = Color.Green
            LabelChange.Text = "Guardado con éxito"
            LabelChange.Visible = True
            ShowData()

        End If



    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox_Course()

    End Sub
    Public Sub ComboBox_Course()
        Dim rows = db.ReaderQuery("Select c.[IdCourse],c.[NameCourse]
                             	From Course c, CourseUser cu, [User] u
                             	Where cu.IdCourse = c.IdCourse 
                                And cu.IdUser=u.Id")

        For Each row As Dictionary(Of String, Object) In rows
            ComboBoxCourse1.Items.Add(row.Item("NameCourse"))
        Next
    End Sub
    Private Async Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click

        Try
            Document = DataGridView1.SelectedCells.Item(0).OwningRow.Cells.Item(0).Value
            Dim sc As StorageCredentials = New StorageCredentials("concinnity", "tPeyMjjE7X2dvJKure3NnDLoOnnHw9Ogzis4a4Sjc8LUXpLM5nbhPjRNUufA6iCHsIyEkphs9oxVKgE9kVcEtg==")
            Dim storageAccount As CloudStorageAccount = New CloudStorageAccount(sc, True)
            Dim blobclient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
            Dim container As CloudBlobContainer = blobclient.GetContainerReference("proyecto1")
            Dim blockblob = container.GetBlockBlobReference(Document)
            Dim saveDialog1 As SaveFileDialog
            saveDialog1 = New SaveFileDialog()
            saveDialog1.CreatePrompt = True
            saveDialog1.FileName = "TestDocument"
            saveDialog1.Filter = "Text File (*.txt)|*.txt|Doc File (*.docx)|*.docx|Image (*.jpg)|*.jpg|All Files (*.*)|*.*"
            Await blockblob.DownloadToFileAsync(saveDialog1.FileName, FileMode.Create)
            Process.Start(saveDialog1.FileName)

        Catch ex As Exception
            MsgBox("Error al abrir el archivo. " + ex.Message)
        End Try
        'Dim save As New SaveFileDialog
        ' Dim Result As New DialogResult
        'Document = DataGridView1.SelectedCells.Item(0).OwningRow.Cells.Item(0).Value

    End Sub

    Private Sub ComboBoxCourse1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse1.SelectedValueChanged
        ShowData()
        ShowIdDocument()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        LabelChange.Visible = False

        Document = DataGridView1.SelectedCells.Item(0).OwningRow.Cells.Item(0).Value

        db.ExecuteQuery("DELETE FROM [Document] Where [Ubicación]='" & Document & "' And [Curso]='" & IdCourse & "'")



        ShowData()
        LabelChange.ForeColor = Color.Green
        LabelChange.Text = "Borrado con éxito"
        LabelChange.Visible = True
    End Sub

    Sub ShowData()
        LabelChange.Visible = False
        NameCourse = ComboBoxCourse1.SelectedItem

        If ComboBoxCourse1.SelectedItem = NameCourse Then
            Dim rows = db.ReaderQuery("Select c.[IdCourse]
                                    From Course c Where c.NameCourse='" & NameCourse & "'")
            IdCourse = rows(0).Item("IdCourse")

            DataGridView1.DataSource = db.AdapterQuery("SELECT d.[Ubicación],c.[NameCourse],d.[Nombre],d.[Descripción] FROM [Document]d,[Course]c Where d.[Curso]='" & IdCourse & "'And c.[NameCourse]='" & NameCourse & "'")
        End If


    End Sub

    Sub ShowIdDocument()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Calendario.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Horario.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Cursos.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Profile.Show()
        Me.Hide()
    End Sub

End Class