Imports System.Globalization

Public Class tiempo
    Dim count = 0
    Dim db As New database
    Dim cultureDays As String() = CultureInfo.CurrentCulture.DateTimeFormat.DayNames
    Dim dayList As String() = CultureInfo.CurrentCulture.DateTimeFormat.DayNames

    Private Sub tiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dayList = dayList.Skip(1).ToArray()
        dayList = dayList.Concat({cultureDays.First()}).ToArray
        addTimer(1)
        Dim data = db.ReaderQuery("SELECT SUM(Hours) as Hours FROM Course,CourseUser WHERE CourseUser.idUser=1 AND CourseUser.IdCourse=Course.IdCourse")
        hoursLabel.Text = Str(data(0).Item("Hours"))

        If ComboBoxCourse_Time.Items.Count > 0 Then

        Else
            ComboBox_Time()
        End If



    End Sub
    Private Sub ComboBox_Time()
        Dim rows = db.ReaderQuery("Select c.[NameCourse]
                             	From Course c, CourseUser cu, [User] u
                             	Where cu.IdCourse = c.IdCourse 
                                And cu.IdUser=u.Id And u.UserName='" & Profile.TextBoxUser.Text & "'")

        For Each row As Dictionary(Of String, Object) In rows
            ComboBoxCourse_Time.Items.Add(row.Item("NameCourse"))
        Next
    End Sub



    Private Function addTimer(ammount As Int32)
        For i = 1 To ammount
            Dim newComboBox As New ComboBox
            newComboBox.Name = "day" + CStr(count)
            newComboBox.Location = New Point(33, 85 + (40 * count))
            newComboBox.Size = New Size(75, 20)
            newComboBox.Items.AddRange(dayList)

            Dim newDatePicker As New DateTimePicker
            newDatePicker.CustomFormat = "hh:mm tt"
            newDatePicker.Name = "timeStart" + CStr(count)
            newDatePicker.Format = DateTimePickerFormat.Custom
            newDatePicker.ShowUpDown = True
            newDatePicker.Location = New Point(128, 85 + (40 * count))
            newDatePicker.Size = New Size(75, 20)

            Dim newDatePicker2 As New DateTimePicker
            newDatePicker2.CustomFormat = "hh:mm tt"
            newDatePicker2.Name = "timeEnd" + CStr(count)
            newDatePicker2.Format = DateTimePickerFormat.Custom
            newDatePicker2.ShowUpDown = True
            newDatePicker2.Location = New Point(223, 85 + (40 * count))
            newDatePicker2.Size = New Size(75, 20)

            Me.Controls.Add(newDatePicker)
            Me.Controls.Add(newDatePicker2)
            Me.Controls.Add(newComboBox)
            count += 1
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addTimer(1)
        'While True
        '   addTimer(1)
        'End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetAll(Me, GetType(DateTimePicker)).ToList.ForEach(
            Sub(c)
                Me.Controls.Remove(c)
            End Sub)
        count = 0
        GetAll(Me, GetType(ComboBox)).ToList.ForEach(
            Sub(c)
                Me.Controls.Remove(c)
            End Sub)
        count = 0
        addTimer(1)
    End Sub

    Private Function GetAll(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Return controls.SelectMany(
            Function(ctrl) GetAll(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result = 0
        For i = 0 To count - 1
            Dim time1 As DateTime = CType(Me.Controls("timeStart" + CStr(i)), DateTimePicker).Value
            Dim time2 As DateTime = CType(Me.Controls("timeEnd" + CStr(i)), DateTimePicker).Value
            Dim ts = time2 - time1
            result += ts.TotalHours
        Next

        'If result < CInt(hoursLabel.Text) Then
        'status.ForeColor = Color.Red
        'status.Text = "Horas insuficientes"
        'Else
        'status.ForeColor = Color.Green
        'status.Text = "Guardado con éxito"
        'End If

        ' Dim Rows = db.ExecuteQuery("Select cu.IdUser From [CourseUser]cu,[User]u Where Username=" & Profile.TextBoxUser.Text & " u.Id=cu.IdUser")

        'Dim User = Rows.Item("IdUser")
        'Dim Course = Rows.Item("IdCourse")
        'Dim Desc = "Repaso " & ComboBoxCourse_Time.SelectedItem

        'Dim Rows_Acitvity = db.ExecuteQuery("INSERT INTO [AcitvityHorario] (User,Desc) Values (" & User & "," & Desc & ")")


    End Sub

End Class