Public Class Add
    Dim db = New database
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
End Class