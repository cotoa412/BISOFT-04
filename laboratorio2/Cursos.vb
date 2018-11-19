Public Class Cursos
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
        Cursos.Show()
        Me.Hide()

    End Sub
End Class