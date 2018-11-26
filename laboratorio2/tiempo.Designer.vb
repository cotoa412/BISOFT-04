<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tiempo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hoursLabel = New System.Windows.Forms.Label()
        Me.CustomMenuStrip1 = New laboratorio2.CustomMenuStrip()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(318, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Añadir otro Horario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(318, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(318, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 54)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(315, 175)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 13)
        Me.status.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Horas Recomendadas:"
        '
        'hoursLabel
        '
        Me.hoursLabel.AutoSize = True
        Me.hoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursLabel.Location = New System.Drawing.Point(374, 247)
        Me.hoursLabel.Name = "hoursLabel"
        Me.hoursLabel.Size = New System.Drawing.Size(0, 13)
        Me.hoursLabel.TabIndex = 7
        Me.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomMenuStrip1
        '
        Me.CustomMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CustomMenuStrip1.Name = "CustomMenuStrip1"
        Me.CustomMenuStrip1.Size = New System.Drawing.Size(452, 25)
        Me.CustomMenuStrip1.TabIndex = 8
        Me.CustomMenuStrip1.Text = "CustomMenuStrip1"
        '
        'tiempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 450)
        Me.Controls.Add(Me.CustomMenuStrip1)
        Me.Controls.Add(Me.hoursLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tiempo"
        Me.Text = "tiempo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents status As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hoursLabel As Label
    Friend WithEvents CustomMenuStrip1 As CustomMenuStrip
End Class
