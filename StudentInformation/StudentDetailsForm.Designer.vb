<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDetailsForm
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
        Me.RegNoPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeptPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FirstNamePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DojPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SemPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LastNamePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RegNoPanel.SuspendLayout()
        Me.DeptPanel.SuspendLayout()
        Me.FirstNamePanel.SuspendLayout()
        Me.DojPanel.SuspendLayout()
        Me.SemPanel.SuspendLayout()
        Me.LastNamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegNoPanel
        '
        Me.RegNoPanel.AutoScroll = True
        Me.RegNoPanel.Controls.Add(Me.Label1)
        Me.RegNoPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RegNoPanel.Location = New System.Drawing.Point(12, 34)
        Me.RegNoPanel.Name = "RegNoPanel"
        Me.RegNoPanel.Size = New System.Drawing.Size(158, 419)
        Me.RegNoPanel.TabIndex = 0
        Me.RegNoPanel.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reg No"
        '
        'DeptPanel
        '
        Me.DeptPanel.AutoScroll = True
        Me.DeptPanel.Controls.Add(Me.Label4)
        Me.DeptPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.DeptPanel.Location = New System.Drawing.Point(473, 34)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(114, 419)
        Me.DeptPanel.TabIndex = 1
        Me.DeptPanel.WrapContents = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dept"
        '
        'FirstNamePanel
        '
        Me.FirstNamePanel.AutoScroll = True
        Me.FirstNamePanel.AutoSize = True
        Me.FirstNamePanel.Controls.Add(Me.Label2)
        Me.FirstNamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FirstNamePanel.Location = New System.Drawing.Point(155, 34)
        Me.FirstNamePanel.Name = "FirstNamePanel"
        Me.FirstNamePanel.Size = New System.Drawing.Size(181, 419)
        Me.FirstNamePanel.TabIndex = 2
        Me.FirstNamePanel.WrapContents = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'DojPanel
        '
        Me.DojPanel.AutoScroll = True
        Me.DojPanel.Controls.Add(Me.Label6)
        Me.DojPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.DojPanel.Location = New System.Drawing.Point(633, 34)
        Me.DojPanel.Name = "DojPanel"
        Me.DojPanel.Size = New System.Drawing.Size(89, 419)
        Me.DojPanel.TabIndex = 3
        Me.DojPanel.WrapContents = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Doj"
        '
        'SemPanel
        '
        Me.SemPanel.AutoScroll = True
        Me.SemPanel.Controls.Add(Me.Label5)
        Me.SemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.SemPanel.Location = New System.Drawing.Point(580, 34)
        Me.SemPanel.Name = "SemPanel"
        Me.SemPanel.Size = New System.Drawing.Size(61, 419)
        Me.SemPanel.TabIndex = 4
        Me.SemPanel.WrapContents = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sem"
        '
        'LastNamePanel
        '
        Me.LastNamePanel.AutoScroll = True
        Me.LastNamePanel.Controls.Add(Me.Label3)
        Me.LastNamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.LastNamePanel.Location = New System.Drawing.Point(324, 34)
        Me.LastNamePanel.Name = "LastNamePanel"
        Me.LastNamePanel.Size = New System.Drawing.Size(158, 419)
        Me.LastNamePanel.TabIndex = 5
        Me.LastNamePanel.WrapContents = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name"
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(633, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 6
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'StudentDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.LastNamePanel)
        Me.Controls.Add(Me.SemPanel)
        Me.Controls.Add(Me.DojPanel)
        Me.Controls.Add(Me.FirstNamePanel)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.RegNoPanel)
        Me.Name = "StudentDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetailsForm"
        Me.RegNoPanel.ResumeLayout(False)
        Me.RegNoPanel.PerformLayout()
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        Me.FirstNamePanel.ResumeLayout(False)
        Me.FirstNamePanel.PerformLayout()
        Me.DojPanel.ResumeLayout(False)
        Me.DojPanel.PerformLayout()
        Me.SemPanel.ResumeLayout(False)
        Me.SemPanel.PerformLayout()
        Me.LastNamePanel.ResumeLayout(False)
        Me.LastNamePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegNoPanel As FlowLayoutPanel
    Friend WithEvents DeptPanel As FlowLayoutPanel
    Friend WithEvents FirstNamePanel As FlowLayoutPanel
    Friend WithEvents DojPanel As FlowLayoutPanel
    Friend WithEvents SemPanel As FlowLayoutPanel
    Friend WithEvents LastNamePanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackButton As Button
End Class
