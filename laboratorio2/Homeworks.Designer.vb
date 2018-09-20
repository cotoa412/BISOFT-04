<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homeworks
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
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TemplatePanel = New System.Windows.Forms.Panel()
        Me.TaskName = New System.Windows.Forms.TextBox()
        Me.TaskDesc = New System.Windows.Forms.TextBox()
        Me.TaskPriority = New System.Windows.Forms.ComboBox()
        Me.TaskDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TemplatePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.AdministratToolStripMenuItem, Me.PendientesToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar Tarea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TemplatePanel
        '
        Me.TemplatePanel.Controls.Add(Me.Label1)
        Me.TemplatePanel.Controls.Add(Me.TaskDate)
        Me.TemplatePanel.Controls.Add(Me.TaskPriority)
        Me.TemplatePanel.Controls.Add(Me.TaskDesc)
        Me.TemplatePanel.Controls.Add(Me.TaskName)
        Me.TemplatePanel.Location = New System.Drawing.Point(12, 49)
        Me.TemplatePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TemplatePanel.Name = "TemplatePanel"
        Me.TemplatePanel.Size = New System.Drawing.Size(776, 45)
        Me.TemplatePanel.TabIndex = 3
        '
        'TaskName
        '
        Me.TaskName.Location = New System.Drawing.Point(17, 16)
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Size = New System.Drawing.Size(133, 20)
        Me.TaskName.TabIndex = 0
        '
        'TaskDesc
        '
        Me.TaskDesc.Location = New System.Drawing.Point(176, 16)
        Me.TaskDesc.Name = "TaskDesc"
        Me.TaskDesc.Size = New System.Drawing.Size(329, 20)
        Me.TaskDesc.TabIndex = 1
        '
        'TaskPriority
        '
        Me.TaskPriority.FormattingEnabled = True
        Me.TaskPriority.Location = New System.Drawing.Point(523, 16)
        Me.TaskPriority.Name = "TaskPriority"
        Me.TaskPriority.Size = New System.Drawing.Size(121, 21)
        Me.TaskPriority.TabIndex = 2
        '
        'TaskDate
        '
        Me.TaskDate.Location = New System.Drawing.Point(662, 16)
        Me.TaskDate.Name = "TaskDate"
        Me.TaskDate.Size = New System.Drawing.Size(104, 20)
        Me.TaskDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, -21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Homeworks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TemplatePanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Homeworks"
        Me.Text = "Homeworks"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TemplatePanel.ResumeLayout(False)
        Me.TemplatePanel.PerformLayout()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents TemplatePanel As Panel
    Friend WithEvents TaskDate As DateTimePicker
    Friend WithEvents TaskPriority As ComboBox
    Friend WithEvents TaskDesc As TextBox
    Friend WithEvents TaskName As TextBox
    Friend WithEvents Label1 As Label
End Class
