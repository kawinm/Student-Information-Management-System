<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataProfessorForm
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
        Me.StudentinfoDataSet3 = New StudentInformation.studentinfoDataSet3()
        Me.ProfessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessorTableAdapter = New StudentInformation.studentinfoDataSet3TableAdapters.professorTableAdapter()
        Me.PRegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMailIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDateOfJoinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDateOfLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(638, 12)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRegNoDataGridViewTextBoxColumn, Me.PFirstNameDataGridViewTextBoxColumn, Me.PLastNameDataGridViewTextBoxColumn, Me.PMailIdDataGridViewTextBoxColumn, Me.PDeptDataGridViewTextBoxColumn, Me.PDateOfJoinDataGridViewTextBoxColumn, Me.PDateOfLeaveDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProfessorBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(26, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(687, 389)
        Me.DataGridView1.TabIndex = 8
        '
        'StudentinfoDataSet3
        '
        Me.StudentinfoDataSet3.DataSetName = "studentinfoDataSet3"
        Me.StudentinfoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfessorBindingSource
        '
        Me.ProfessorBindingSource.DataMember = "professor"
        Me.ProfessorBindingSource.DataSource = Me.StudentinfoDataSet3
        '
        'ProfessorTableAdapter
        '
        Me.ProfessorTableAdapter.ClearBeforeFill = True
        '
        'PRegNoDataGridViewTextBoxColumn
        '
        Me.PRegNoDataGridViewTextBoxColumn.DataPropertyName = "pRegNo"
        Me.PRegNoDataGridViewTextBoxColumn.HeaderText = "pRegNo"
        Me.PRegNoDataGridViewTextBoxColumn.Name = "PRegNoDataGridViewTextBoxColumn"
        '
        'PFirstNameDataGridViewTextBoxColumn
        '
        Me.PFirstNameDataGridViewTextBoxColumn.DataPropertyName = "pFirstName"
        Me.PFirstNameDataGridViewTextBoxColumn.HeaderText = "pFirstName"
        Me.PFirstNameDataGridViewTextBoxColumn.Name = "PFirstNameDataGridViewTextBoxColumn"
        '
        'PLastNameDataGridViewTextBoxColumn
        '
        Me.PLastNameDataGridViewTextBoxColumn.DataPropertyName = "pLastName"
        Me.PLastNameDataGridViewTextBoxColumn.HeaderText = "pLastName"
        Me.PLastNameDataGridViewTextBoxColumn.Name = "PLastNameDataGridViewTextBoxColumn"
        '
        'PMailIdDataGridViewTextBoxColumn
        '
        Me.PMailIdDataGridViewTextBoxColumn.DataPropertyName = "pMailId"
        Me.PMailIdDataGridViewTextBoxColumn.HeaderText = "pMailId"
        Me.PMailIdDataGridViewTextBoxColumn.Name = "PMailIdDataGridViewTextBoxColumn"
        '
        'PDeptDataGridViewTextBoxColumn
        '
        Me.PDeptDataGridViewTextBoxColumn.DataPropertyName = "pDept"
        Me.PDeptDataGridViewTextBoxColumn.HeaderText = "pDept"
        Me.PDeptDataGridViewTextBoxColumn.Name = "PDeptDataGridViewTextBoxColumn"
        '
        'PDateOfJoinDataGridViewTextBoxColumn
        '
        Me.PDateOfJoinDataGridViewTextBoxColumn.DataPropertyName = "pDateOfJoin"
        Me.PDateOfJoinDataGridViewTextBoxColumn.HeaderText = "pDateOfJoin"
        Me.PDateOfJoinDataGridViewTextBoxColumn.Name = "PDateOfJoinDataGridViewTextBoxColumn"
        '
        'PDateOfLeaveDataGridViewTextBoxColumn
        '
        Me.PDateOfLeaveDataGridViewTextBoxColumn.DataPropertyName = "pDateOfLeave"
        Me.PDateOfLeaveDataGridViewTextBoxColumn.HeaderText = "pDateOfLeave"
        Me.PDateOfLeaveDataGridViewTextBoxColumn.Name = "PDateOfLeaveDataGridViewTextBoxColumn"
        '
        'DataProfessorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DataProfessorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataProfessorForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentinfoDataSet3 As studentinfoDataSet3
    Friend WithEvents ProfessorBindingSource As BindingSource
    Friend WithEvents ProfessorTableAdapter As studentinfoDataSet3TableAdapters.professorTableAdapter
    Friend WithEvents PRegNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PMailIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDateOfJoinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDateOfLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
