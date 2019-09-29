<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProfessorForm
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
        Me.LastNameField = New System.Windows.Forms.TextBox()
        Me.FirstNameField = New System.Windows.Forms.TextBox()
        Me.DeptField = New System.Windows.Forms.TextBox()
        Me.Doj = New System.Windows.Forms.DateTimePicker()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegNoField = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MsgPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ErrorPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MsgPanel.SuspendLayout()
        Me.ErrorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LastNameField
        '
        Me.LastNameField.Location = New System.Drawing.Point(575, 176)
        Me.LastNameField.Name = "LastNameField"
        Me.LastNameField.Size = New System.Drawing.Size(100, 20)
        Me.LastNameField.TabIndex = 24
        '
        'FirstNameField
        '
        Me.FirstNameField.Location = New System.Drawing.Point(307, 176)
        Me.FirstNameField.Name = "FirstNameField"
        Me.FirstNameField.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameField.TabIndex = 23
        '
        'DeptField
        '
        Me.DeptField.Location = New System.Drawing.Point(307, 246)
        Me.DeptField.Name = "DeptField"
        Me.DeptField.Size = New System.Drawing.Size(100, 20)
        Me.DeptField.TabIndex = 22
        '
        'Doj
        '
        Me.Doj.CustomFormat = "yyyy-MM-dd"
        Me.Doj.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Doj.Location = New System.Drawing.Point(307, 316)
        Me.Doj.Name = "Doj"
        Me.Doj.Size = New System.Drawing.Size(163, 20)
        Me.Doj.TabIndex = 21
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Blue
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(575, 379)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(90, 35)
        Me.AddButton.TabIndex = 16
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(235, 379)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(90, 35)
        Me.BackButton.TabIndex = 15
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'RegNoField
        '
        Me.RegNoField.Location = New System.Drawing.Point(575, 249)
        Me.RegNoField.Name = "RegNoField"
        Me.RegNoField.Size = New System.Drawing.Size(100, 20)
        Me.RegNoField.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(388, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 27)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Add Professor"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-2, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(167, 467)
        Me.FlowLayoutPanel1.TabIndex = 27
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.FlowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.ForeColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(158, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(587, 50)
        Me.FlowLayoutPanel2.TabIndex = 28
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
        'MsgPanel
        '
        Me.MsgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MsgPanel.Controls.Add(Me.Label9)
        Me.MsgPanel.Controls.Add(Me.Button1)
        Me.MsgPanel.Location = New System.Drawing.Point(158, 41)
        Me.MsgPanel.Name = "MsgPanel"
        Me.MsgPanel.Size = New System.Drawing.Size(587, 39)
        Me.MsgPanel.TabIndex = 30
        Me.MsgPanel.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(28, 15, 10, 10)
        Me.Label9.Size = New System.Drawing.Size(230, 43)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Course Added Successfully!"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(546, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(310, 12, 10, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(203, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(475, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(468, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Register No"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(191, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 18)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Date of Joining"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(199, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Department"
        '
        'ErrorPanel
        '
        Me.ErrorPanel.BackColor = System.Drawing.Color.DarkRed
        Me.ErrorPanel.Controls.Add(Me.Label3)
        Me.ErrorPanel.Controls.Add(Me.Button2)
        Me.ErrorPanel.ForeColor = System.Drawing.Color.White
        Me.ErrorPanel.Location = New System.Drawing.Point(158, 437)
        Me.ErrorPanel.Name = "ErrorPanel"
        Me.ErrorPanel.Size = New System.Drawing.Size(587, 30)
        Me.ErrorPanel.TabIndex = 37
        Me.ErrorPanel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(28, 2, 10, 10)
        Me.Label3.Size = New System.Drawing.Size(83, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Error!"
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
        'AddProfessorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.MsgPanel)
        Me.Controls.Add(Me.RegNoField)
        Me.Controls.Add(Me.LastNameField)
        Me.Controls.Add(Me.FirstNameField)
        Me.Controls.Add(Me.DeptField)
        Me.Controls.Add(Me.Doj)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ErrorPanel)
        Me.Name = "AddProfessorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProfessorForm"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.MsgPanel.ResumeLayout(False)
        Me.MsgPanel.PerformLayout()
        Me.ErrorPanel.ResumeLayout(False)
        Me.ErrorPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LastNameField As TextBox
    Friend WithEvents FirstNameField As TextBox
    Friend WithEvents DeptField As TextBox
    Friend WithEvents Doj As DateTimePicker
    Friend WithEvents AddButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RegNoField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents MsgPanel As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ErrorPanel As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
