<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecoverPassword
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ingrese su nombre de usuario:"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUser.Location = New System.Drawing.Point(12, 82)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxUser.TabIndex = 1
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfirm.Location = New System.Drawing.Point(92, 131)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(80, 31)
        Me.ButtonConfirm.TabIndex = 2
        Me.ButtonConfirm.Text = "Confirmar"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'RecoverPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 282)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RecoverPassword"
        Me.Text = "RecoverPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents ButtonConfirm As Button
End Class
