Public Class Calendario
    Dim db As New database
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDay As DateTime
        Dim week, day As Int16
        Dim dateNum As Int32
        Dim DaysInMonth As Integer = Date.DaysInMonth(Now.Year, Now.Month)
        firstDay = New DateTime(Now.Year, Now.Month, 1)
        day = CInt(firstDay.DayOfWeek)
        If day = 0 Then day = 7

        week = 1
        dateNum = 1

        While dateNum <= DaysInMonth
            Dim label As Label = CType(Me.Controls("d" + CStr(week) + "_" + CStr(day)), Label)
            label.Text = CStr(dateNum)

            dateNum += 1
            day += 1
            If day > 7 Then
                day = 1
                week += 1
            End If
        End While

        GetAll(Me, GetType(Label)).ToList.ForEach(
        Sub(c)
            AddHandler c.Click, AddressOf HandleClick
        End Sub)

    End Sub
    Private Function GetAll(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Return controls.SelectMany(
            Function(ctrl) GetAll(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
    End Function

    Private Sub HandleClick(sender As Label, e As EventArgs)
        Dim LabelDate As String = sender.Text
        Reminder.LabelChange.Text = "Recordatorios del " & LabelDate.ToString & "/" & Date.Now.Month & "/" & Date.Now.Year
        Reminder.LabelChange.Visible = True


        Dim Rows = db.ReaderQuery("Select a.NameActivity,c.NameCourse,a.[Priority]
                                   From Activity a,CourseUser cu, [User] us, Course c
                                    Where a.DateHour='" & Date.Now.Year & "-" & Date.Now.Month & "-" & LabelDate & "'
                                     and a.Course=cu.IdCourse
                                     and cu.IdUser=us.Id
                                     and c.IdCourse=cu.IdCourse")
        Dim Num As Integer = 0
        Dim NumR As Integer = 0
        Dim NumC As Integer = 0

        For Each Item In Rows

            Dim PanelReminder As New Panel
            Dim LbelNameActivity As New Label
            Dim LbelCourse As New Label
            Dim LbelPriority As New Label
            Dim LabelChangeReminder As New Label
            Dim LabelChangePriority As New Label
            Dim LabelChangeCourse As New Label

            LbelNameActivity.Text = "Recordatorio"
            LbelNameActivity.Location = New Point(3, 10)
            LbelNameActivity.Size = New Size(105, 20)
            LbelNameActivity.Font = New Font(LbelCourse.Font, FontStyle.Bold)
            LbelNameActivity.Visible = True
            PanelReminder.Controls.Add(LbelNameActivity)

            LabelChangeReminder.Text = Rows(Num).Item("NameActivity")
            LabelChangeReminder.Location = New Point(16, 39)
            LabelChangePriority.AutoSize = True
            LabelChangeReminder.Visible = True
            PanelReminder.Controls.Add(LabelChangeReminder)

            LbelCourse.Text = "Course"
            LbelCourse.Location = New Point(3, 63)
            LbelCourse.Size = New Size(55, 20)
            LbelCourse.Font = New Font(LbelCourse.Font, FontStyle.Bold)
            LbelCourse.Visible = True
            PanelReminder.Controls.Add(LbelCourse)

            LabelChangeCourse.Text = Rows(Num).Item("NameCourse")
            LabelChangeCourse.Location = New Point(16, 92)
            LabelChangePriority.AutoSize = True
            LabelChangeCourse.Visible = True
            PanelReminder.Controls.Add(LabelChangeCourse)

            LbelPriority.Text = "Prioridad"
            LbelPriority.Location = New Point(179, 10)
            LbelPriority.Size = New Size(75, 20)
            LbelPriority.Font = New Font(LbelCourse.Font, FontStyle.Bold)
            LbelPriority.Visible = True
            PanelReminder.Controls.Add(LbelPriority)

            LabelChangePriority.Text = Rows(Num).Item("Priority")
            LabelChangePriority.Location = New Point(194, 39)
            LabelChangePriority.AutoSize = True
            LabelChangePriority.Visible = True
            PanelReminder.Controls.Add(LabelChangePriority)

            PanelReminder.Location = New Point(12 + (270 * NumC), 135 + (130 * NumR))
            PanelReminder.Size = New Size(260, 120)
            PanelReminder.BorderStyle = BorderStyle.FixedSingle
            PanelReminder.BackColor = Color.Gray
            PanelReminder.Visible = True
            Reminder.Controls.Add(PanelReminder)




            LbelNameActivity.Name = "LbelNameActivity" & Num
            LbelCourse.Name = "LbelCourse" & Num
            LbelPriority.Name = "LbelPriority" & Num
            PanelReminder.Name = "PanelRemin" & Num
            LabelChangeReminder.Name = "LabelChangeReminder" & Num
            LabelChangePriority.Name = "LabelChangePriority" & Num
            LabelChangeCourse.Name = "LabelChangeCourse" & Num
            Num += 1
            NumC += 1
            If NumC = 3 Then

                NumR += 1
                NumC = 0

            End If
        Next

        Reminder.Show()

    End Sub
    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Profile.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Horario.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Material.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Cursos.Show()
        Me.Close()

    End Sub

End Class