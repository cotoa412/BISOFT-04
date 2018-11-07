﻿Imports System.Data.SqlClient
Public Class Material
    Dim Document As String
    Dim NameCourse As String
    Dim IdCourse As Integer
    Dim db = New database

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
            Dim CommandInsert As New SqlCommand("INSERT iNTO [Document] (IdDocument,CourseDocument,NameDocument,DescriptionDocument)VALUES(@IdDocument,@CourseDocument,@NameDocument,@DescriptionDocument)")

            With CommandInsert

                .Parameters.AddWithValue("@PathDocument", Document)
                .Parameters.AddWithValue("@CourseDocument", IdCourse)
                .Parameters.AddWithValue("@NameDocument", "aaaaa")
                .Parameters.AddWithValue("@DescriptionDocument", "aaaaa")

            End With
            CommandInsert.ExecuteNonQuery()

            LabelChange.ForeColor = Color.Green
            LabelChange.Text = "Guardado con éxito"
            LabelChange.Visible = True
            ShowData()
        End If



    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rows = db.ReaderQuery("Select c.[IdCourse],c.[NameCourse]
                             	From Course c, CourseUser cu, [User] u
                             	Where cu.IdCourse = c.IdCourse 
                              And cu.IdUser=u.Id")
        For Each row As Dictionary(Of String, Object) In rows
            ComboBoxCourse1.Items.Add(row.Item("NameCourse"))
        Next
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

        db.ExecuteQuery("DELETE FROM [Document] Where [IdDocument]='" & Document & "' And [CourseDocument]='" & IdCourse & "'")

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

            DataGridView1.DataSource = db.AdapterQuery("SELECT d.[IdDocument],c.[NameCourse],d.[NameDocument],d.[DescriptionDocument] FROM [Document]d,[Course]c Where d.[CourseDocument]='" & IdCourse & "'And c.[NameCourse]='" & NameCourse & "'")
        End If


    End Sub
End Class