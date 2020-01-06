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
        Me.FirstNameField = New System.Windows.Forms.TextBox()
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AddressField = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FatherNameFIeld = New System.Windows.Forms.TextBox()
        Me.EmailField = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PincodeField = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DistrictField = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Dob = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MsgPanel.SuspendLayout()
        Me.ErrorPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(215, 505)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(623, 511)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(583, 574)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 22)
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
        Me.Doj.Location = New System.Drawing.Point(719, 574)
        Me.Doj.Name = "Doj"
        Me.Doj.Size = New System.Drawing.Size(214, 20)
        Me.Doj.TabIndex = 8
        '
        'FirstNameField
        '
        Me.FirstNameField.Location = New System.Drawing.Point(328, 172)
        Me.FirstNameField.Name = "FirstNameField"
        Me.FirstNameField.Size = New System.Drawing.Size(216, 20)
        Me.FirstNameField.TabIndex = 10
        '
        'SemField
        '
        Me.SemField.Location = New System.Drawing.Point(721, 509)
        Me.SemField.Name = "SemField"
        Me.SemField.Size = New System.Drawing.Size(214, 20)
        Me.SemField.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(213, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Register No"
        '
        'RegNoField
        '
        Me.RegNoField.Location = New System.Drawing.Point(328, 233)
        Me.RegNoField.Name = "RegNoField"
        Me.RegNoField.Size = New System.Drawing.Size(216, 20)
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
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(823, 50)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(100, 0, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(10, 7, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(557, 36)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "  Government College of Engineering, Dharmapuri"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-3, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(170, 720)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'MsgPanel
        '
        Me.MsgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MsgPanel.Controls.Add(Me.Label9)
        Me.MsgPanel.Controls.Add(Me.Button1)
        Me.MsgPanel.Location = New System.Drawing.Point(163, 41)
        Me.MsgPanel.Name = "MsgPanel"
        Me.MsgPanel.Size = New System.Drawing.Size(823, 45)
        Me.MsgPanel.TabIndex = 17
        Me.MsgPanel.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(28, 13, 10, 10)
        Me.Label9.Size = New System.Drawing.Size(288, 47)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Student Added Successfully!"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(779, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(485, 11, 10, 10)
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
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(827, 631)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(110, 42)
        Me.AddButton.TabIndex = 18
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(233, 631)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(110, 42)
        Me.BackButton.TabIndex = 19
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(185, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 22)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Student's Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(236, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(517, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 31)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Add Student"
        '
        'ErrorPanel
        '
        Me.ErrorPanel.BackColor = System.Drawing.Color.DarkRed
        Me.ErrorPanel.Controls.Add(Me.Label11)
        Me.ErrorPanel.Controls.Add(Me.Button2)
        Me.ErrorPanel.ForeColor = System.Drawing.Color.White
        Me.ErrorPanel.Location = New System.Drawing.Point(163, 676)
        Me.ErrorPanel.Name = "ErrorPanel"
        Me.ErrorPanel.Size = New System.Drawing.Size(823, 45)
        Me.ErrorPanel.TabIndex = 38
        Me.ErrorPanel.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(28, 2, 10, 10)
        Me.Label11.Size = New System.Drawing.Size(95, 36)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Error!"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(781, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(680, 2, 10, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 28)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CSE", "CIVIL", "ECE", "EEE", "MECH"})
        Me.ComboBox1.Location = New System.Drawing.Point(330, 508)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox1.TabIndex = 39
        '
        'AddressField
        '
        Me.AddressField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressField.Location = New System.Drawing.Point(330, 352)
        Me.AddressField.Name = "AddressField"
        Me.AddressField.Size = New System.Drawing.Size(214, 113)
        Me.AddressField.TabIndex = 42
        Me.AddressField.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(590, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 22)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Father's Name"
        '
        'FatherNameFIeld
        '
        Me.FatherNameFIeld.Location = New System.Drawing.Point(723, 290)
        Me.FatherNameFIeld.Name = "FatherNameFIeld"
        Me.FatherNameFIeld.Size = New System.Drawing.Size(214, 20)
        Me.FatherNameFIeld.TabIndex = 43
        '
        'EmailField
        '
        Me.EmailField.Location = New System.Drawing.Point(721, 348)
        Me.EmailField.Name = "EmailField"
        Me.EmailField.Size = New System.Drawing.Size(216, 20)
        Me.EmailField.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(635, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 22)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Email Id"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label15.Location = New System.Drawing.Point(208, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 22)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Date of Birth"
        '
        'PincodeField
        '
        Me.PincodeField.Location = New System.Drawing.Point(719, 448)
        Me.PincodeField.Name = "PincodeField"
        Me.PincodeField.Size = New System.Drawing.Size(216, 20)
        Me.PincodeField.TabIndex = 52
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label16.Location = New System.Drawing.Point(633, 450)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 22)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Pincode"
        '
        'DistrictField
        '
        Me.DistrictField.Location = New System.Drawing.Point(721, 402)
        Me.DistrictField.Name = "DistrictField"
        Me.DistrictField.Size = New System.Drawing.Size(216, 20)
        Me.DistrictField.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label17.Location = New System.Drawing.Point(641, 402)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 22)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "District"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"YES", "NO"})
        Me.ComboBox2.Location = New System.Drawing.Point(328, 571)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox2.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label18.Location = New System.Drawing.Point(231, 569)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 22)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Hosteller"
        '
        'Dob
        '
        Me.Dob.CalendarForeColor = System.Drawing.Color.White
        Me.Dob.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Dob.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Dob.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Dob.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Dob.CustomFormat = "yyyy-MM-dd"
        Me.Dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dob.Location = New System.Drawing.Point(328, 294)
        Me.Dob.Name = "Dob"
        Me.Dob.Size = New System.Drawing.Size(214, 20)
        Me.Dob.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(784, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 180)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(679, 230)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 42)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(698, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 22)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Photo"
        '
        'AddStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Dob)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PincodeField)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DistrictField)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.EmailField)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.FatherNameFIeld)
        Me.Controls.Add(Me.AddressField)
        Me.Controls.Add(Me.ComboBox1)
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
        Me.Controls.Add(Me.FirstNameField)
        Me.Controls.Add(Me.Doj)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MsgPanel)
        Me.Controls.Add(Me.ErrorPanel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "AddStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStudentForm"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.MsgPanel.ResumeLayout(False)
        Me.MsgPanel.PerformLayout()
        Me.ErrorPanel.ResumeLayout(False)
        Me.ErrorPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Doj As DateTimePicker
    Friend WithEvents FirstNameField As TextBox
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AddressField As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents FatherNameFIeld As TextBox
    Friend WithEvents EmailField As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PincodeField As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DistrictField As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Dob As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label12 As Label
End Class
