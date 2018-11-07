Public Class tiempo
    Dim count = 0


    Private Sub tiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addTimer()
    End Sub

    Private Function addTimer()
        count += 1
        Dim newDatePicker As New DateTimePicker
        newDatePicker.CustomFormat = "hh:mm tt"
        newDatePicker.Name = "time" + CStr(count)
        newDatePicker.Format = DateTimePickerFormat.Custom
        newDatePicker.ShowUpDown = True

        Me.Controls.Add(newDatePicker)
    End Function
End Class