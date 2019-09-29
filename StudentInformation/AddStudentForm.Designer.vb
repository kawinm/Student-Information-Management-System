<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudentForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Doj = New System.Windows.Forms.DateTimePicker()
        Me.DeptField = New System.Windows.Forms.TextBox()
        Me.FirstNameField = New System.Windows.Forms.TextBox()
        Me.LastNameField = New System.Windows.Forms.TextBox()
        Me.SemField = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RegNoField = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MsgPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MsgPanel.SuspendLayout()
        Me.ErrorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(205, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(478, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(205, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date of Joining"
        '
        'Doj
        '
        Me.Doj.CalendarForeColor = System.Drawing.Color.White
        Me.Doj.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Doj.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Doj.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Doj.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Doj.CustomFormat = "yyyy-MM-dd"
        Me.Doj.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Doj.Location = New System.Drawing.Point(320, 336)
        Me.Doj.Name = "Doj"
        Me.Doj.Size = New System.Drawing.Size(193, 20)
        Me.Doj.TabIndex = 8
        '
        'DeptField
        '
        Me.DeptField.Location = New System.Drawing.Point(320, 268)
        Me.DeptField.Name = "DeptField"
        Me.DeptField.Size = New System.Drawing.Size(110, 20)
        Me.DeptField.TabIndex = 9
        '
        'FirstNameField
        '
        Me.FirstNameField.Location = New System.Drawing.Point(320, 154)
        Me.FirstNameField.Name = "FirstNameField"
        Me.FirstNameField.Size = New System.Drawing.Size(110, 20)
        Me.FirstNameField.TabIndex = 10
        '
        'LastNameField
        '
        Me.LastNameField.Location = New System.Drawing.Point(574, 151)
        Me.LastNameField.Name = "LastNameField"
        Me.LastNameField.Size = New System.Drawing.Size(117, 20)
        Me.LastNameField.TabIndex = 11
        '
        'SemField
        '
        Me.SemField.Location = New System.Drawing.Point(574, 268)
        Me.SemField.Name = "SemField"
        Me.SemField.Size = New System.Drawing.Size(117, 20)
        Me.SemField.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(205, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Register No"
        '
        'RegNoField
        '
        Me.RegNoField.Location = New System.Drawing.Point(320, 211)
        Me.RegNoField.Name = "RegNoField"
        Me.RegNoField.Size = New System.Drawing.Size(110, 20)
        Me.RegNoField.TabIndex = 14
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.FlowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.ForeColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(163, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(578, 50)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(10, 7, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(557, 36)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "  Government College of Engineering, Dharmapuri"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-3, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(170, 467)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'MsgPanel
        '
        Me.MsgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MsgPanel.Controls.Add(Me.Label9)
        Me.MsgPanel.Controls.Add(Me.Button1)
        Me.MsgPanel.Location = New System.Drawing.Point(163, 41)
        Me.MsgPanel.Name = "MsgPanel"
        Me.MsgPanel.Size = New System.Drawing.Size(578, 39)
        Me.MsgPanel.TabIndex = 17
        Me.MsgPanel.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(28, 13, 10, 10)
        Me.Label9.Size = New System.Drawing.Size(231, 41)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Student Added Successfully!"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(537, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(300, 11, 10, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Blue
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(551, 383)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(90, 35)
        Me.AddButton.TabIndex = 18
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(268, 383)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(90, 35)
        Me.BackButton.TabIndex = 19
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(209, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(478, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(390, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 27)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Add Student"
        '
        'ErrorPanel
        '
        Me.ErrorPanel.BackColor = System.Drawing.Color.DarkRed
        Me.ErrorPanel.Controls.Add(Me.Label11)
        Me.ErrorPanel.Controls.Add(Me.Button2)
        Me.ErrorPanel.ForeColor = System.Drawing.Color.White
        Me.ErrorPanel.Location = New System.Drawing.Point(163, 437)
        Me.ErrorPanel.Name = "ErrorPanel"
        Me.ErrorPanel.Size = New System.Drawing.Size(578, 30)
        Me.ErrorPanel.TabIndex = 38
        Me.ErrorPanel.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(28, 2, 10, 10)
        Me.Label11.Size = New System.Drawing.Size(83, 30)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Error!"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(539, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(450, 2, 10, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.RegNoField)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SemField)
        Me.Controls.Add(Me.LastNameField)
        Me.Controls.Add(Me.FirstNameField)
        Me.Controls.Add(Me.DeptField)
        Me.Controls.Add(Me.Doj)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MsgPanel)
        Me.Controls.Add(Me.ErrorPanel)
        Me.Name = "AddStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStudentForm"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.MsgPanel.ResumeLayout(False)
        Me.MsgPanel.PerformLayout()
        Me.ErrorPanel.ResumeLayout(False)
        Me.ErrorPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Doj As DateTimePicker
    Friend WithEvents DeptField As TextBox
    Friend WithEvents FirstNameField As TextBox
    Friend WithEvents LastNameField As TextBox
    Friend WithEvents SemField As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RegNoField As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MsgPanel As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorPanel As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
End Class
