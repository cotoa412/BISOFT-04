﻿Public Class CustomMenuStrip
    Inherits System.Windows.Forms.ToolStrip

    Friend WithEvents ToolStripLabel1 As ToolStripLabel

    Friend WithEvents ToolStripLabel2 As ToolStripLabel

    Friend WithEvents ToolStripLabel3 As ToolStripLabel

    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.SuspendLayout()
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel1.Text = "Perfil"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(64, 15)
        Me.ToolStripLabel2.Text = "Calendario"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(47, 15)
        Me.ToolStripLabel3.Text = "Horario"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(50, 15)
        Me.ToolStripLabel4.Text = "Material"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(43, 15)
        Me.ToolStripLabel5.Text = "Cursos"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripLabel6.Text = "Tiempo"
        '
        'CustomMenuStrip
        '
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.ToolStripLabel6})
        Me.ResumeLayout(False)

    End Sub
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Profile.Show()
        Material.Hide()
        Horario.Hide()
        Calendario.Hide()
        Cursos.Hide()
        tiempo.Hide()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Calendario.Show()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        Cursos.Hide()
        tiempo.Hide()

    End Sub

    Private Sub ToolStripLabel3_Click_1(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click

        Horario.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Cursos.Hide()
        tiempo.Hide()

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click

        Material.Show()
        Calendario.Hide()
        Profile.Hide()
        Horario.Hide()
        Cursos.Hide()


    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click

        Cursos.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        tiempo.Hide()

    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click


        tiempo.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        Cursos.Hide()

    End Sub
End Class
