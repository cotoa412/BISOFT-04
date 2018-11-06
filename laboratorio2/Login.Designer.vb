<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.LabelRecoverPassword = New System.Windows.Forms.Label()
        Me.LabelRegister = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(145, 33)
        Me.TextBoxUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(181, 22)
        Me.TextBoxUsername.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(145, 78)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(181, 22)
        Me.TextBoxPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'ButtonAccept
        '
        Me.ButtonAccept.Location = New System.Drawing.Point(56, 128)
        Me.ButtonAccept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(100, 28)
        Me.ButtonAccept.TabIndex = 5
        Me.ButtonAccept.Text = "Ingresar"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(212, 128)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LabelRecoverPassword
        '
        Me.LabelRecoverPassword.AutoSize = True
        Me.LabelRecoverPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecoverPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelRecoverPassword.Location = New System.Drawing.Point(16, 169)
        Me.LabelRecoverPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRecoverPassword.Name = "LabelRecoverPassword"
        Me.LabelRecoverPassword.Size = New System.Drawing.Size(164, 18)
        Me.LabelRecoverPassword.TabIndex = 8
        Me.LabelRecoverPassword.Text = "¿Olvidó su contraseña?"
        '
        'LabelRegister
        '
        Me.LabelRegister.AutoSize = True
        Me.LabelRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegister.Location = New System.Drawing.Point(224, 169)
        Me.LabelRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRegister.Name = "LabelRegister"
        Me.LabelRegister.Size = New System.Drawing.Size(68, 18)
        Me.LabelRegister.TabIndex = 9
        Me.LabelRegister.Text = "Registrar"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(141, 108)
        Me.LabelError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(75, 17)
        Me.LabelError.TabIndex = 10
        Me.LabelError.Text = "LabelError"
        Me.LabelError.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelError.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 198)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.LabelRegister)
        Me.Controls.Add(Me.LabelRecoverPassword)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAccept)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAccept As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents LabelRecoverPassword As Label
    Friend WithEvents LabelRegister As Label
    Friend WithEvents LabelError As Label
End Class
