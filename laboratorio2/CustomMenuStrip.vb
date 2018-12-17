Public Class CustomMenuStrip
    Inherits System.Windows.Forms.ToolStrip

    Friend WithEvents ToolStripLabel1 As ToolStripLabel

    Friend WithEvents ToolStripLabel2 As ToolStripLabel

    Friend WithEvents ToolStripLabel3 As ToolStripLabel

    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
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
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.SuspendLayout()
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Perfil"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(81, 20)
        Me.ToolStripLabel2.Text = "Calendario"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripLabel3.Text = "Horario"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(64, 20)
        Me.ToolStripLabel4.Text = "Material"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripLabel5.Text = "Cursos"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripLabel6.Text = "Tiempo"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(62, 20)
        Me.ToolStripLabel7.Text = "Reporte"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripLabel8.Text = "Salir"
        '
        'CustomMenuStrip
        '
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.ToolStripLabel6, Me.ToolStripLabel7, Me.ToolStripSeparator1, Me.ToolStripLabel8})
        Me.ResumeLayout(False)

    End Sub
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        Material.Hide()
        Horario.Hide()
        Calendario.Hide()
        Cursos.Hide()
        tiempo.Hide()
        Reporte.Hide()
        Profile.Show()

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        Cursos.Hide()
        tiempo.Hide()
        Reporte.Hide()
        Calendario.Show()

    End Sub

    Private Sub ToolStripLabel3_Click_1(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click

        Horario.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Cursos.Hide()
        tiempo.Hide()
        Reporte.Hide()


    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click

        Material.Show()
        Calendario.Hide()
        Profile.Hide()
        Horario.Hide()
        Cursos.Hide()
        tiempo.Hide()
        Reporte.Hide()


    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click


        Cursos.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        tiempo.Hide()
        Reporte.Hide()


    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click

        tiempo.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        Cursos.Hide()
        Reporte.Hide()


    End Sub
    Private Sub ToolStripLabel7_Click(sender As Object, e As EventArgs) Handles ToolStripLabel7.Click

        Reporte.Show()
        Calendario.Hide()
        Profile.Hide()
        Material.Hide()
        Horario.Hide()
        tiempo.Hide()
        Cursos.Hide()


    End Sub
    Private Sub ToolStripLabel8_Click(sender As Object, e As EventArgs) Handles ToolStripLabel8.Click

        Login.TextBoxUsername.Text = ""
        Login.TextBoxPassword.Text = ""
        Login.Show()
        Calendario.Close()
        Profile.Close()
        Material.Close()
        Horario.Close()
        tiempo.Close()
        Cursos.Close()
        Reporte.Close()

    End Sub
End Class
