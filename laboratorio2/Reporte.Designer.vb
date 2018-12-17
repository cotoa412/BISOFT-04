<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProjectDBDataSet = New laboratorio2.ProjectDBDataSet()
        Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityTableAdapter = New laboratorio2.ProjectDBDataSetTableAdapters.ActivityTableAdapter()
        Me.ProjectDBDataSet1 = New laboratorio2.ProjectDBDataSet1()
        Me.ActivityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityTableAdapter1 = New laboratorio2.ProjectDBDataSet1TableAdapters.ActivityTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateHourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDBDataSet2 = New laboratorio2.ProjectDBDataSet2()
        Me.ActivityTableAdapter2 = New laboratorio2.ProjectDBDataSet2TableAdapters.ActivityTableAdapter()
        Me.CustomMenuStrip1 = New laboratorio2.CustomMenuStrip()
        CType(Me.ProjectDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 303)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 303)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Crear Pdf"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titulo del archivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 274)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ubicacion del archivo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 63)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(151, 271)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(290, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reporte"
        '
        'ProjectDBDataSet
        '
        Me.ProjectDBDataSet.DataSetName = "ProjectDBDataSet"
        Me.ProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivityBindingSource
        '
        Me.ActivityBindingSource.DataMember = "Activity"
        Me.ActivityBindingSource.DataSource = Me.ProjectDBDataSet
        '
        'ActivityTableAdapter
        '
        Me.ActivityTableAdapter.ClearBeforeFill = True
        '
        'ProjectDBDataSet1
        '
        Me.ProjectDBDataSet1.DataSetName = "ProjectDBDataSet1"
        Me.ProjectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivityBindingSource1
        '
        Me.ActivityBindingSource1.DataMember = "Activity"
        Me.ActivityBindingSource1.DataSource = Me.ProjectDBDataSet1
        '
        'ActivityTableAdapter1
        '
        Me.ActivityTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdActivityDataGridViewTextBoxColumn, Me.NameActivityDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.DateHourDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ActivityBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(151, 102)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(407, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'IdActivityDataGridViewTextBoxColumn
        '
        Me.IdActivityDataGridViewTextBoxColumn.DataPropertyName = "IdActivity"
        Me.IdActivityDataGridViewTextBoxColumn.HeaderText = "IdActivity"
        Me.IdActivityDataGridViewTextBoxColumn.Name = "IdActivityDataGridViewTextBoxColumn"
        Me.IdActivityDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdActivityDataGridViewTextBoxColumn.Visible = False
        '
        'NameActivityDataGridViewTextBoxColumn
        '
        Me.NameActivityDataGridViewTextBoxColumn.DataPropertyName = "NameActivity"
        Me.NameActivityDataGridViewTextBoxColumn.HeaderText = "Nombre de Actividad"
        Me.NameActivityDataGridViewTextBoxColumn.Name = "NameActivityDataGridViewTextBoxColumn"
        Me.NameActivityDataGridViewTextBoxColumn.Width = 120
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Prioridad"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.Width = 73
        '
        'DateHourDataGridViewTextBoxColumn
        '
        Me.DateHourDataGridViewTextBoxColumn.DataPropertyName = "DateHour"
        Me.DateHourDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.DateHourDataGridViewTextBoxColumn.Name = "DateHourDataGridViewTextBoxColumn"
        Me.DateHourDataGridViewTextBoxColumn.Width = 62
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Curso"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.Width = 59
        '
        'ActivityBindingSource2
        '
        Me.ActivityBindingSource2.DataMember = "Activity"
        Me.ActivityBindingSource2.DataSource = Me.ProjectDBDataSet2
        '
        'ProjectDBDataSet2
        '
        Me.ProjectDBDataSet2.DataSetName = "ProjectDBDataSet2"
        Me.ProjectDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivityTableAdapter2
        '
        Me.ActivityTableAdapter2.ClearBeforeFill = True
        '
        'CustomMenuStrip1
        '
        Me.CustomMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CustomMenuStrip1.Name = "CustomMenuStrip1"
        Me.CustomMenuStrip1.Size = New System.Drawing.Size(626, 25)
        Me.CustomMenuStrip1.TabIndex = 8
        Me.CustomMenuStrip1.Text = "CustomMenuStrip1"
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 366)
        Me.Controls.Add(Me.CustomMenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        CType(Me.ProjectDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProjectDBDataSet As ProjectDBDataSet
    Friend WithEvents ActivityBindingSource As BindingSource
    Friend WithEvents ActivityTableAdapter As ProjectDBDataSetTableAdapters.ActivityTableAdapter
    Friend WithEvents ProjectDBDataSet1 As ProjectDBDataSet1
    Friend WithEvents ActivityBindingSource1 As BindingSource
    Friend WithEvents ActivityTableAdapter1 As ProjectDBDataSet1TableAdapters.ActivityTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDBDataSet2 As ProjectDBDataSet2
    Friend WithEvents ActivityBindingSource2 As BindingSource
    Friend WithEvents ActivityTableAdapter2 As ProjectDBDataSet2TableAdapters.ActivityTableAdapter
    Friend WithEvents CustomMenuStrip1 As CustomMenuStrip
    Friend WithEvents IdActivityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameActivityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateHourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
