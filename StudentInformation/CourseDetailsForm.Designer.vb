<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseDetailsForm
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
        Me.TypePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CNamePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CCodePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TypePanel.SuspendLayout()
        Me.CNamePanel.SuspendLayout()
        Me.RegPanel.SuspendLayout()
        Me.CCodePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TypePanel
        '
        Me.TypePanel.AutoScroll = True
        Me.TypePanel.Controls.Add(Me.Label5)
        Me.TypePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.TypePanel.Location = New System.Drawing.Point(551, 43)
        Me.TypePanel.Name = "TypePanel"
        Me.TypePanel.Size = New System.Drawing.Size(92, 395)
        Me.TypePanel.TabIndex = 10
        Me.TypePanel.WrapContents = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Type"
        '
        'CNamePanel
        '
        Me.CNamePanel.AutoScroll = True
        Me.CNamePanel.AutoSize = True
        Me.CNamePanel.Controls.Add(Me.Label2)
        Me.CNamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CNamePanel.Location = New System.Drawing.Point(214, 43)
        Me.CNamePanel.Name = "CNamePanel"
        Me.CNamePanel.Size = New System.Drawing.Size(174, 395)
        Me.CNamePanel.TabIndex = 8
        Me.CNamePanel.WrapContents = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Name"
        '
        'RegPanel
        '
        Me.RegPanel.AutoScroll = True
        Me.RegPanel.Controls.Add(Me.Label4)
        Me.RegPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RegPanel.Location = New System.Drawing.Point(404, 43)
        Me.RegPanel.Name = "RegPanel"
        Me.RegPanel.Size = New System.Drawing.Size(115, 395)
        Me.RegPanel.TabIndex = 7
        Me.RegPanel.WrapContents = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Regulation"
        '
        'CCodePanel
        '
        Me.CCodePanel.AutoScroll = True
        Me.CCodePanel.Controls.Add(Me.Label1)
        Me.CCodePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CCodePanel.Location = New System.Drawing.Point(47, 43)
        Me.CCodePanel.Name = "CCodePanel"
        Me.CCodePanel.Size = New System.Drawing.Size(149, 395)
        Me.CCodePanel.TabIndex = 6
        Me.CCodePanel.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code"
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(622, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 11
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CourseDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.TypePanel)
        Me.Controls.Add(Me.CNamePanel)
        Me.Controls.Add(Me.RegPanel)
        Me.Controls.Add(Me.CCodePanel)
        Me.Name = "CourseDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CourseDetailsForm"
        Me.TypePanel.ResumeLayout(False)
        Me.TypePanel.PerformLayout()
        Me.CNamePanel.ResumeLayout(False)
        Me.CNamePanel.PerformLayout()
        Me.RegPanel.ResumeLayout(False)
        Me.RegPanel.PerformLayout()
        Me.CCodePanel.ResumeLayout(False)
        Me.CCodePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TypePanel As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents CNamePanel As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents RegPanel As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents CCodePanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
End Class
