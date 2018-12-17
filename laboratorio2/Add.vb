Public Class Add
    Dim db As New database

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDBDataSet2.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.ProjectDBDataSet2.Course)
        'TODO: This line of code loads data into the 'ProjectDBDataSet2.CourseUser' table. You can move, or remove it, as needed.
        Me.CourseUserTableAdapter.Fill(Me.ProjectDBDataSet2.CourseUser)

    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ComboBoxCourse1.Items.Count > 0 Then

        Else
            ComboBox_Course()
        End If

    End Sub
    Public Sub ComboBox_Course()

        Dim rows = db.ReaderQuery("Select c.[NameCourse]
                             	From Course c, CourseUser cu, [User] u
                             	Where cu.IdCourse = c.IdCourse 
                                And cu.IdUser=u.Id And u.UserName='" & Profile.TextBoxUser.Text & "'")

        For Each row As Dictionary(Of String, Object) In rows
            ComboBoxCourse1.Items.Add(row.Item("NameCourse"))
        Next

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Calendario.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBoxCourse1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Or TextBox1.Text = "" Then

            Label6.Text = "Debe llenar los campos"
            Label6.ForeColor = Color.Red
            Label6.Visible = True

        Else

            Dim Prioridad = ComboBox2.SelectedItem
            Dim Fecha = DateTimePicker1.Value.ToString("yyMMdd")
            Dim Desc = TextBox1.Text
            Dim StringCon = "Select cu.IdCourse 
                         From Course c,CourseUser cu,[User] u
                         Where u.Id=cu.IdUser And  cu.IdCourse=c.IdCourse   ANd c.NameCourse='" & ComboBoxCourse1.SelectedItem & "'And u.UserName='" & Profile.TextBoxUser.Text & "'"
            Dim Row = db.ReaderQuery(StringCon)
            Dim Course = Row(0).Item("IdCourse")


            If Course > 0 Then

                db.ExecuteQuery("INSERT INTO [Activity] (NameActivity,Priority,DateHour,Course) VALUES('" & Desc & "','" & Prioridad & "','" & Fecha & "','" & Course & "')")

                Label6.Text = "Guardado"
                Label6.ForeColor = Color.Green
                Label6.Visible = True

                TextBox1.Text = ""
                ComboBoxCourse1.Text = ""
                ComboBox2.Text = ""
            Else

            End If
        End If


    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Label6.Visible = False
    End Sub
End Class