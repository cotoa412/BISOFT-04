Public Class Cursos
    Dim db As New database
    Dim _Course As New Course
    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Calendario.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Horario.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLabel3_Click_1(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Material.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Profile.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click

        Me.Hide()

    End Sub

    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ShowList()




    End Sub

    Public Sub ShowList()

        Dim Rows = db.ReaderQuery("Select c.NameCourse From Course c,[User] u Where u.UserName='" & Login.TextBoxUsername.Text & "' AND u.Password='" & Login.TextBoxPassword.Text & "'")
        Dim Num1 As Integer = 0
        For Each Item In Rows

            ListBox1.Items.Add(Rows(Num1).Item("NameCourse"))
            Num1 += 1

        Next
    End Sub


    Public Sub OnlyNum(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCredits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCredits.KeyPress
        OnlyNum(e)
    End Sub

    Private Sub ButtonAddCourse_Click(sender As Object, e As EventArgs) Handles ButtonAddCourse.Click

        _Course.Name_Course = TextBoxNameCourse.Text
        _Course.Credits_Course = Integer.Parse(TextBoxCredits.Text)
        If TextBoxCredits.Text = "" Then

            MsgBox("Debe agregar Créditos")

        End If
        db.ExecuteQuery("Insert INTO Course (NameCourse,Credit) VALUES('" & _Course.Name_Course & "','" & _Course.Credits_Course & "')")
        TextBoxCredits.Text = ""
        TextBoxNameCourse.Text = ""
        ListBox1.Items.Clear()
        ShowList()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Course As String = ListBox1.SelectedItem.ToString

        db.ExecuteQuery("DELETE FROM Course Where [NameCourse]='" & Course & "'")

        ListBox1.Items.Clear()
        ShowList()



    End Sub
End Class