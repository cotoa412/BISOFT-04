Imports System.ComponentModel
Imports System.Reflection

Public Class Calendario
    Dim db As New database
    Dim Month As Int16 = Date.Now.Month
    Dim Count_Date As Integer


    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Calendario_Change()

        Count_Date = Date.Now.Month
        Label9.Text = MonthName(Count_Date) & " " & "2018"

    End Sub
    Private Function GetAll(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Return controls.SelectMany(
            Function(ctrl) GetAll(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
    End Function

    Private Sub HandleClick(sender As Label, e As EventArgs)

        GetAll(Reminder, GetType(Panel)).ToList.ForEach(
            Sub(c)
                Reminder.Controls.Remove(c)
            End Sub)

        Dim LabelDate As String = sender.Text

        Reminder.LabelChange.Text = "Recordatorios del " & LabelDate.ToString & "/" & Month & "/" & Date.Now.Year
        Reminder.LabelChange.Visible = True


        Dim Rows = db.ReaderQuery("Select a.NameActivity,c.NameCourse,a.[Priority]
                                   From Activity a,CourseUser cu, [User] us, Course c
                                    Where a.DateHour='" & Date.Now.Year & "-" & Month & "-" & LabelDate & "'
                                     and a.Course=cu.IdCourse
                                     and cu.IdUser=us.Id
                                     and c.IdCourse=cu.IdCourse
                                    and us.UserName='" & Profile.TextBoxUser.Text & "'")
        If Rows.Count > 0 Then

            Dim Num As Integer = 0
            Dim NumR As Integer = 0
            Dim NumC As Integer = 0

            For Each Item In Rows

                If NumR > 0 And NumC = 0 Then

                    Reminder.Size = New Size(837, Reminder.Size.Height + 130)

                End If

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
                LbelNameActivity.ForeColor = SystemColors.ControlLightLight
                LbelNameActivity.Visible = True
                PanelReminder.Controls.Add(LbelNameActivity)

                LabelChangeReminder.Text = Rows(Num).Item("NameActivity")
                LabelChangeReminder.Location = New Point(16, 39)
                LabelChangePriority.AutoSize = True
                LabelChangeReminder.ForeColor = SystemColors.ControlLightLight
                LabelChangeReminder.Visible = True
                PanelReminder.Controls.Add(LabelChangeReminder)

                LbelCourse.Text = "Curso"
                LbelCourse.Location = New Point(3, 63)
                LbelCourse.Size = New Size(55, 20)
                LbelCourse.Font = New Font(LbelCourse.Font, FontStyle.Bold)
                LbelCourse.ForeColor = SystemColors.ControlLightLight
                LbelCourse.Visible = True
                PanelReminder.Controls.Add(LbelCourse)

                LabelChangeCourse.Text = Rows(Num).Item("NameCourse")
                LabelChangeCourse.Location = New Point(16, 92)
                LabelChangePriority.AutoSize = True
                LabelChangeCourse.ForeColor = SystemColors.ControlLightLight
                LabelChangeCourse.Visible = True
                PanelReminder.Controls.Add(LabelChangeCourse)

                LbelPriority.Text = "Prioridad"
                LbelPriority.Location = New Point(179, 10)
                LbelPriority.Size = New Size(75, 20)
                LbelPriority.Font = New Font(LbelCourse.Font, FontStyle.Bold)
                LbelPriority.ForeColor = SystemColors.ControlLightLight
                LbelPriority.Visible = True
                PanelReminder.Controls.Add(LbelPriority)

                LabelChangePriority.Text = Rows(Num).Item("Priority")
                LabelChangePriority.Location = New Point(194, 39)
                LabelChangePriority.AutoSize = True
                LabelChangePriority.ForeColor = SystemColors.ControlLightLight
                LabelChangePriority.Visible = True
                PanelReminder.Controls.Add(LabelChangePriority)

                PanelReminder.Location = New Point(12 + (270 * NumC), 135 + (130 * NumR))
                PanelReminder.Size = New Size(260, 120)
                PanelReminder.BorderStyle = BorderStyle.FixedSingle
                PanelReminder.BackColor = SystemColors.HotTrack
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

                If NumC = 2 Then

                    NumR += 1
                    NumC = 0

                Else
                    NumC += 1
                End If

            Next

            Reminder.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Count_Date += 1
        Label9.Text = MonthName(Count_Date) & " " & "2018"
        Clear_Labels()
        Month += 1
        Calendario_Change()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Count_Date -= 1
        Label9.Text = MonthName(Count_Date) & " " & "2018"
        Clear_Labels()
        Month -= 1
        Calendario_Change()

    End Sub
    Private Sub Calendario_Change()

        Dim firstDay As DateTime
        Dim week, day As Int16
        Dim dateNum As New Int32
        Dim DaysInMonth As Integer = Date.DaysInMonth(Now.Year, Month)
        firstDay = New DateTime(Now.Year, Month, 1)
        day = CInt(firstDay.DayOfWeek)
        If day = 0 Then day = 7

        week = 1
        dateNum = 1

        While dateNum <= DaysInMonth

            Dim label As Label = CType(PanelCalendar.Controls("d" + CStr(week) + "_" + CStr(day)), Label)
            label.Text = CStr(dateNum)

            dateNum += 1
            day += 1

            If day > 7 Then
                day = 1
                week += 1
            End If

            RemoveClickEvent(label)
            AddHandler label.Click, AddressOf HandleClick

        End While

    End Sub

    Private Sub RemoveClickEvent(b As Control)

        Dim f1 As FieldInfo = GetType(Control).GetField("EventClick", BindingFlags.Static Or BindingFlags.NonPublic)
        Dim obj As Object = f1.GetValue(b)
        Dim pi As PropertyInfo = b.GetType().GetProperty("Events", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim list As EventHandlerList = DirectCast(pi.GetValue(b, Nothing), EventHandlerList)
        list.RemoveHandler(obj, list(obj))

    End Sub


    Private Sub Clear_Labels()

        Dim firstDay As DateTime
        Dim week, day As Int16
        Dim dateNum As New Int32
        Dim DaysInMonth As Integer = Date.DaysInMonth(Now.Year, Month)
        firstDay = New DateTime(Now.Year, Month, 1)
        day = CInt(firstDay.DayOfWeek)
        If day = 0 Then day = 7

        week = 1
        dateNum = 1

        While dateNum <= DaysInMonth

            Dim label As Label = CType(PanelCalendar.Controls("d" + CStr(week) + "_" + CStr(day)), Label)
            label.Text = ""

            dateNum += 1
            day += 1

            If day > 7 Then
                day = 1
                week += 1
            End If
            RemoveClickEvent(label)

        End While

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Reporte.Hide()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        tiempo.Hide()
        Cursos.Hide()
        Login.TextBoxUsername.Text = ""
        Login.TextBoxPassword.Text = ""
        Login.Show()
    End Sub


End Class