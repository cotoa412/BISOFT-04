<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratToolStripMenuItem, Me.PendientesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(293, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
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
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 161)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña: "
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(101, 251)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(175, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 340)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Profile"
        Me.Text = "Profile"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
