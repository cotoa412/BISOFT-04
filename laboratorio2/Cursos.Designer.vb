<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cursos
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCredits = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAddCourse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNameCourse = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomMenuStrip1 = New laboratorio2.CustomMenuStrip()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 93)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(318, 104)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(417, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Créditos:"
        '
        'TextBoxCredits
        '
        Me.TextBoxCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCredits.Location = New System.Drawing.Point(546, 151)
        Me.TextBoxCredits.Name = "TextBoxCredits"
        Me.TextBoxCredits.Size = New System.Drawing.Size(105, 26)
        Me.TextBoxCredits.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estudio recomendado: x horas"
        '
        'ButtonAddCourse
        '
        Me.ButtonAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCourse.Location = New System.Drawing.Point(125, 226)
        Me.ButtonAddCourse.Name = "ButtonAddCourse"
        Me.ButtonAddCourse.Size = New System.Drawing.Size(163, 32)
        Me.ButtonAddCourse.TabIndex = 4
        Me.ButtonAddCourse.Text = "Agregar Curso"
        Me.ButtonAddCourse.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cursos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre del Curso:"
        '
        'TextBoxNameCourse
        '
        Me.TextBoxNameCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNameCourse.Location = New System.Drawing.Point(495, 122)
        Me.TextBoxNameCourse.Name = "TextBoxNameCourse"
        Me.TextBoxNameCourse.Size = New System.Drawing.Size(156, 26)
        Me.TextBoxNameCourse.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(353, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'CustomMenuStrip1
        '
        Me.CustomMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CustomMenuStrip1.Name = "CustomMenuStrip1"
        Me.CustomMenuStrip1.Size = New System.Drawing.Size(663, 25)
        Me.CustomMenuStrip1.TabIndex = 13
        Me.CustomMenuStrip1.Text = "CustomMenuStrip1"
        '
        'Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 303)
        Me.Controls.Add(Me.CustomMenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxNameCourse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonAddCourse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCredits)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Cursos"
        Me.Text = "Cursos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCredits As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAddCourse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNameCourse As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CustomMenuStrip1 As CustomMenuStrip
End Class
