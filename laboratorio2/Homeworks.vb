Public Class Homeworks
    Private Sub Homeworks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemplatePanel.Controls.Add(TaskName)
        TemplatePanel.Controls.Add(TaskDesc)
        TemplatePanel.Controls.Add(TaskPriority)
        TemplatePanel.Controls.Add(TaskDate)
        TemplatePanel.Hide()
    End Sub

    Private Sub TemplatePanel_Paint(sender As Object, e As PaintEventArgs) Handles TemplatePanel.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TemplatePanel.
    End Sub
End Class