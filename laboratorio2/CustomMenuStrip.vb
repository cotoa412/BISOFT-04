Public Class CustomMenuStrip
    Inherits System.Windows.Forms.ToolStrip

    Friend WithEvents ToolStripLabel1 As ToolStripLabel

    Friend WithEvents ToolStripLabel2 As ToolStripLabel

    Friend WithEvents ToolStripLabel3 As ToolStripLabel

    Friend WithEvents ToolStripLabel4 As ToolStripLabel

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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripLabel2.Text = "Calendario"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripLabel3.Text = "Horario"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripLabel4.Text = "Material"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripLabel5.Text = "Cursos"
        '
        'CustomMenuStrip
        '
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripLabel5})
        Me.ResumeLayout(False)

    End Sub
End Class
