Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Reporte

    Dim db = New database

    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ProjectDBDataSet2.Activity' table. You can move, or remove it, as needed.
        Me.ActivityTableAdapter2.Fill(Me.ProjectDBDataSet2.Activity)
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFileDialog1 As SaveFileDialog
        saveFileDialog1 = New SaveFileDialog()
        saveFileDialog1.FileName = ""
        saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"
        saveFileDialog1.FileName = ""
        If saveFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = saveFileDialog1.FileName
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Paragraph As New Paragraph
        Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
        PdfFile.AddTitle(TextBox1.Text)
        Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(TextBox2.Text, FileMode.Create))
        PdfFile.Open()
        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Paragraph = New Paragraph(New Chunk(TextBox1.Text, pTitle))
        Paragraph.Alignment = Element.ALIGN_CENTER
        Paragraph.SpacingAfter = 5.0F
        PdfFile.Add(Paragraph)
        Dim PdfTable As New PdfPTable(DataGridView1.Columns.Count)
        PdfTable.TotalWidth = 500.0F
        PdfTable.LockedWidth = True
        Dim widths(0 To DataGridView1.Columns.Count - 1) As Single
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            widths(i) = 1.0F
        Next
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 0
        PdfTable.SpacingBefore = 5.0F
        Dim pdfcell As PdfPCell = New PdfPCell
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            pdfcell = New PdfPCell(New Phrase(New Chunk(DataGridView1.Columns(i).HeaderText, pTable)))
            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            PdfTable.AddCell(pdfcell)
        Next
        For i As Integer = 0 To DataGridView1.Rows.Count - 2
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(DataGridView1(j, i).Value.ToString(), pTable))
                PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
        Next
        PdfFile.Add(PdfTable)
        PdfFile.Close()
        MessageBox.Show("PDF creado")
    End Sub



End Class