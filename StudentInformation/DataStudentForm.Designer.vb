<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataStudentForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentinfoDataSet1 = New StudentInformation.studentinfoDataSet1()
        Me.StudentsTableAdapter = New StudentInformation.studentinfoDataSet1TableAdapters.studentsTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StudentinfoDataSet4 = New StudentInformation.studentinfoDataSet4()
        Me.StudentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter1 = New StudentInformation.studentinfoDataSet4TableAdapters.studentsTableAdapter()
        Me.sRegNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sMailId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sSemester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hosteller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.district = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pincode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fatherName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sDateOfJoin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sPhoto = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sRegNo, Me.sName, Me.sMailId, Me.sDept, Me.sSemester, Me.hosteller, Me.sAddress, Me.district, Me.pincode, Me.dob, Me.fatherName, Me.sDateOfJoin, Me.sPhoto})
        Me.DataGridView1.DataSource = Me.StudentsBindingSource1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(26, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(933, 603)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "students"
        Me.StudentsBindingSource.DataSource = Me.StudentinfoDataSet1
        '
        'StudentinfoDataSet1
        '
        Me.StudentinfoDataSet1.DataSetName = "studentinfoDataSet1"
        Me.StudentinfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(26, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(868, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Download Pdf"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentinfoDataSet4
        '
        Me.StudentinfoDataSet4.DataSetName = "studentinfoDataSet4"
        Me.StudentinfoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource1
        '
        Me.StudentsBindingSource1.DataMember = "students"
        Me.StudentsBindingSource1.DataSource = Me.StudentinfoDataSet4
        '
        'StudentsTableAdapter1
        '
        Me.StudentsTableAdapter1.ClearBeforeFill = True
        '
        'sRegNo
        '
        Me.sRegNo.DataPropertyName = "sRegNo"
        Me.sRegNo.HeaderText = "Register Number"
        Me.sRegNo.Name = "sRegNo"
        Me.sRegNo.ReadOnly = True
        '
        'sName
        '
        Me.sName.DataPropertyName = "sName"
        Me.sName.HeaderText = "Name"
        Me.sName.Name = "sName"
        Me.sName.ReadOnly = True
        '
        'sMailId
        '
        Me.sMailId.DataPropertyName = "sMailId"
        Me.sMailId.HeaderText = "Mail Id"
        Me.sMailId.Name = "sMailId"
        Me.sMailId.ReadOnly = True
        '
        'sDept
        '
        Me.sDept.DataPropertyName = "sDept"
        Me.sDept.HeaderText = "Department"
        Me.sDept.Name = "sDept"
        Me.sDept.ReadOnly = True
        '
        'sSemester
        '
        Me.sSemester.DataPropertyName = "sSemester"
        Me.sSemester.HeaderText = "Semester"
        Me.sSemester.Name = "sSemester"
        Me.sSemester.ReadOnly = True
        '
        'hosteller
        '
        Me.hosteller.DataPropertyName = "hosteller"
        Me.hosteller.HeaderText = "Hosteller"
        Me.hosteller.Name = "hosteller"
        Me.hosteller.ReadOnly = True
        '
        'sAddress
        '
        Me.sAddress.DataPropertyName = "sAddress"
        Me.sAddress.HeaderText = "Address"
        Me.sAddress.Name = "sAddress"
        Me.sAddress.ReadOnly = True
        '
        'district
        '
        Me.district.DataPropertyName = "district"
        Me.district.HeaderText = "District"
        Me.district.Name = "district"
        Me.district.ReadOnly = True
        '
        'pincode
        '
        Me.pincode.DataPropertyName = "pincode"
        Me.pincode.HeaderText = "Pincode"
        Me.pincode.Name = "pincode"
        Me.pincode.ReadOnly = True
        '
        'dob
        '
        Me.dob.DataPropertyName = "dob"
        Me.dob.HeaderText = "Date of Birth"
        Me.dob.Name = "dob"
        Me.dob.ReadOnly = True
        '
        'fatherName
        '
        Me.fatherName.DataPropertyName = "fatherName"
        Me.fatherName.HeaderText = "Father Name"
        Me.fatherName.Name = "fatherName"
        Me.fatherName.ReadOnly = True
        '
        'sDateOfJoin
        '
        Me.sDateOfJoin.DataPropertyName = "sDateOfJoin"
        Me.sDateOfJoin.HeaderText = "Date Of Join"
        Me.sDateOfJoin.Name = "sDateOfJoin"
        Me.sDateOfJoin.ReadOnly = True
        '
        'sPhoto
        '
        Me.sPhoto.DataPropertyName = "sPhoto"
        Me.sPhoto.HeaderText = "Photo"
        Me.sPhoto.Name = "sPhoto"
        Me.sPhoto.ReadOnly = True
        '
        'DataStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DataStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentinfoDataSet1 As studentinfoDataSet1
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As studentinfoDataSet1TableAdapters.studentsTableAdapter
    Friend WithEvents BackButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents StudentinfoDataSet4 As studentinfoDataSet4
    Friend WithEvents StudentsBindingSource1 As BindingSource
    Friend WithEvents StudentsTableAdapter1 As studentinfoDataSet4TableAdapters.studentsTableAdapter
    Friend WithEvents sRegNo As DataGridViewTextBoxColumn
    Friend WithEvents sName As DataGridViewTextBoxColumn
    Friend WithEvents sMailId As DataGridViewTextBoxColumn
    Friend WithEvents sDept As DataGridViewTextBoxColumn
    Friend WithEvents sSemester As DataGridViewTextBoxColumn
    Friend WithEvents hosteller As DataGridViewTextBoxColumn
    Friend WithEvents sAddress As DataGridViewTextBoxColumn
    Friend WithEvents district As DataGridViewTextBoxColumn
    Friend WithEvents pincode As DataGridViewTextBoxColumn
    Friend WithEvents dob As DataGridViewTextBoxColumn
    Friend WithEvents fatherName As DataGridViewTextBoxColumn
    Friend WithEvents sDateOfJoin As DataGridViewTextBoxColumn
    Friend WithEvents sPhoto As DataGridViewImageColumn
End Class
