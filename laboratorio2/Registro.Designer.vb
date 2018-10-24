<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Registro"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(104, 61)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxEmail.TabIndex = 5
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(104, 100)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxName.TabIndex = 6
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(104, 145)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxUsername.TabIndex = 7
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(104, 189)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxPassword.TabIndex = 8
        '
        'ButtonAccept
        '
        Me.ButtonAccept.Location = New System.Drawing.Point(43, 232)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAccept.TabIndex = 9
        Me.ButtonAccept.Text = "Aceptar"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(145, 232)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 10
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 279)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAccept)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonAccept As Button
    Friend WithEvents ButtonCancel As Button
End Class
