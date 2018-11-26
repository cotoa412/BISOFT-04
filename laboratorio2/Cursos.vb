Public Class Cursos
    Dim db As New database
    Dim dbId As New database
    Dim dbIdCor As New database
    Dim dbInsert As New database
    Dim IdUser As Integer
    Dim IdCour As Integer
    Dim _Course As New Course


    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ShowList()




    End Sub

    Public Sub ShowList()

        Dim Rows = db.ReaderQuery("Select c.NameCourse From Course c,[User] u,CourseUser cu Where u.UserName='" & Profile.TextBoxUser.Text & "' AND u.Password='" & Profile.TextBoxPassword.Text & "' And cu.IdUser=u.Id And cu.IdCourse=c.IdCourse")
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

        If TextBoxCredits.Text = "" Or TextBoxNameCourse.Text = "" Then
            Label5.Text = "Debe llenar los campos"
            Label5.ForeColor = Color.Red
            Label5.Visible = True
        Else
            _Course.Name_Course = TextBoxNameCourse.Text
            _Course.Credits_Course = Integer.Parse(TextBoxCredits.Text)
            db.ExecuteQuery("Insert INTO Course (NameCourse,Credit) VALUES('" & _Course.Name_Course & "','" & _Course.Credits_Course & "')")

            Dim Row_Id_User = dbId.ReaderQuery("SELECT [Id] From [User] Where UserName='" & Profile.TextBoxUser.Text & "' AND Password='" & Profile.TextBoxPassword.Text & "'")
            IdUser = Row_Id_User(0).Item("Id")
            Dim Row_Id_Course = dbIdCor.ReaderQuery("Select IdCourse From Course Where NameCourse='" & _Course.Name_Course & "' And Credit='" & _Course.Credits_Course & "'")
            IdCour = Row_Id_Course(0).Item("IdCourse")
            Dim Row_Insert = dbInsert.ExecuteQuery("Insert INTO CourseUser (IdCourse,IdUser) VALUES('" & IdCour & "','" & IdUser & "')")

            TextBoxCredits.Text = ""
            TextBoxNameCourse.Text = ""
            Label5.Visible = False
        End If
        ListBox1.Items.Clear()
        Material.ComboBoxCourse1.Items.Clear()
        Material.ComboBox_Course()
        ShowList()

    End Sub

    Public Sub SelectId()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Course As String = ListBox1.SelectedItem.ToString

        db.ExecuteQuery("DELETE FROM Course Where [NameCourse]='" & Course & "'")
        dbInsert.ExecuteQuery("DELETE FROM CourseUser Where IdCourse='" & IdCour & "' AND IdUser='" & IdUser & "'")
        Material.ComboBoxCourse1.Items.Clear()
        Material.ComboBoxCourse1.Text = ""
        Material.ComboBox_Course()
        Material.DataGridView1.DataSource = Nothing
        ListBox1.Items.Clear()
        ShowList()



    End Sub
End Class