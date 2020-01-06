<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataCourseForm
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentinfoDataSet2 = New StudentInformation.studentinfoDataSet2()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter = New StudentInformation.studentinfoDataSet2TableAdapters.courseTableAdapter()
        Me.CNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRegulationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(636, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 9
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNameDataGridViewTextBoxColumn, Me.CCodeDataGridViewTextBoxColumn, Me.CRegulationDataGridViewTextBoxColumn, Me.CTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CourseBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(24, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(687, 389)
        Me.DataGridView1.TabIndex = 8
        '
        'StudentinfoDataSet2
        '
        Me.StudentinfoDataSet2.DataSetName = "studentinfoDataSet2"
        Me.StudentinfoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "course"
        Me.CourseBindingSource.DataSource = Me.StudentinfoDataSet2
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'CNameDataGridViewTextBoxColumn
        '
        Me.CNameDataGridViewTextBoxColumn.DataPropertyName = "cName"
        Me.CNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.CNameDataGridViewTextBoxColumn.Name = "CNameDataGridViewTextBoxColumn"
        '
        'CCodeDataGridViewTextBoxColumn
        '
        Me.CCodeDataGridViewTextBoxColumn.DataPropertyName = "cCode"
        Me.CCodeDataGridViewTextBoxColumn.HeaderText = "Course Code"
        Me.CCodeDataGridViewTextBoxColumn.Name = "CCodeDataGridViewTextBoxColumn"
        '
        'CRegulationDataGridViewTextBoxColumn
        '
        Me.CRegulationDataGridViewTextBoxColumn.DataPropertyName = "cRegulation"
        Me.CRegulationDataGridViewTextBoxColumn.HeaderText = "Regulation"
        Me.CRegulationDataGridViewTextBoxColumn.Name = "CRegulationDataGridViewTextBoxColumn"
        '
        'CTypeDataGridViewTextBoxColumn
        '
        Me.CTypeDataGridViewTextBoxColumn.DataPropertyName = "cType"
        Me.CTypeDataGridViewTextBoxColumn.HeaderText = "Course Type"
        Me.CTypeDataGridViewTextBoxColumn.Name = "CTypeDataGridViewTextBoxColumn"
        '
        'DataCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DataCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataCourseForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentinfoDataSet2 As studentinfoDataSet2
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As studentinfoDataSet2TableAdapters.courseTableAdapter
    Friend WithEvents CNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CRegulationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
