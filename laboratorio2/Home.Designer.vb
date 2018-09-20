<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.AdministratToolStripMenuItem, Me.PendientesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministratToolStripMenuItem
        '
        Me.AdministratToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosToolStripMenuItem, Me.TareasToolStripMenuItem, Me.ContactosToolStripMenuItem})
        Me.AdministratToolStripMenuItem.Name = "AdministratToolStripMenuItem"
        Me.AdministratToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AdministratToolStripMenuItem.Text = "Administrar"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'TareasToolStripMenuItem
        '
        Me.TareasToolStripMenuItem.Name = "TareasToolStripMenuItem"
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TareasToolStripMenuItem.Text = "Tareas"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'PendientesToolStripMenuItem
        '
        Me.PendientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TareasToolStripMenuItem1, Me.ProyectosToolStripMenuItem, Me.PruebasToolStripMenuItem})
        Me.PendientesToolStripMenuItem.Name = "PendientesToolStripMenuItem"
        Me.PendientesToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PendientesToolStripMenuItem.Text = "Pendientes"
        '
        'TareasToolStripMenuItem1
        '
        Me.TareasToolStripMenuItem1.Name = "TareasToolStripMenuItem1"
        Me.TareasToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.TareasToolStripMenuItem1.Text = "Tareas"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'PruebasToolStripMenuItem
        '
        Me.PruebasToolStripMenuItem.Name = "PruebasToolStripMenuItem"
        Me.PruebasToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PruebasToolStripMenuItem.Text = "Pruebas"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(329, 104)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(120, 39)
        Me.WelcomeLabel.TabIndex = 1
        Me.WelcomeLabel.Text = "Label1"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WelcomeLabel As Label
End Class
