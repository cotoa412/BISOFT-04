<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelChange = New System.Windows.Forms.Label()
        Me.PanelRemider = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelShowReminder = New System.Windows.Forms.Label()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.LabelPriority = New System.Windows.Forms.Label()
        Me.PanelRemider.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recordatorios"
        '
        'LabelChange
        '
        Me.LabelChange.AutoSize = True
        Me.LabelChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChange.Location = New System.Drawing.Point(350, 95)
        Me.LabelChange.Name = "LabelChange"
        Me.LabelChange.Size = New System.Drawing.Size(57, 20)
        Me.LabelChange.TabIndex = 1
        Me.LabelChange.Text = "Label2"
        Me.LabelChange.Visible = False
        '
        'PanelRemider
        '
        Me.PanelRemider.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PanelRemider.Controls.Add(Me.LabelPriority)
        Me.PanelRemider.Controls.Add(Me.LabelCourse)
        Me.PanelRemider.Controls.Add(Me.LabelShowReminder)
        Me.PanelRemider.Controls.Add(Me.Label4)
        Me.PanelRemider.Controls.Add(Me.Label3)
        Me.PanelRemider.Controls.Add(Me.Label2)
        Me.PanelRemider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRemider.Location = New System.Drawing.Point(51, 156)
        Me.PanelRemider.Name = "PanelRemider"
        Me.PanelRemider.Size = New System.Drawing.Size(267, 129)
        Me.PanelRemider.TabIndex = 2
        Me.PanelRemider.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Recordatorio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Curso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Prioridad:"
        '
        'LabelShowReminder
        '
        Me.LabelShowReminder.AutoSize = True
        Me.LabelShowReminder.Location = New System.Drawing.Point(16, 39)
        Me.LabelShowReminder.Name = "LabelShowReminder"
        Me.LabelShowReminder.Size = New System.Drawing.Size(39, 13)
        Me.LabelShowReminder.TabIndex = 3
        Me.LabelShowReminder.Text = "Label5"
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Location = New System.Drawing.Point(16, 92)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(39, 13)
        Me.LabelCourse.TabIndex = 4
        Me.LabelCourse.Text = "Label6"
        '
        'LabelPriority
        '
        Me.LabelPriority.AutoSize = True
        Me.LabelPriority.Location = New System.Drawing.Point(194, 39)
        Me.LabelPriority.Name = "LabelPriority"
        Me.LabelPriority.Size = New System.Drawing.Size(39, 13)
        Me.LabelPriority.TabIndex = 5
        Me.LabelPriority.Text = "Label7"
        '
        'Reminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelRemider)
        Me.Controls.Add(Me.LabelChange)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reminder"
        Me.Text = "Reminder"
        Me.PanelRemider.ResumeLayout(False)
        Me.PanelRemider.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelChange As Label
    Friend WithEvents PanelRemider As Panel
    Friend WithEvents LabelPriority As Label
    Friend WithEvents LabelCourse As Label
    Friend WithEvents LabelShowReminder As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
