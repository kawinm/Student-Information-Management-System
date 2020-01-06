Public Class DataCourseForm
    Private Sub DataCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentinfoDataSet2.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.StudentinfoDataSet2.course)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class