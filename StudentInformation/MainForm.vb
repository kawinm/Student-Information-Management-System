Public Class MainForm
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub SDButton_Click(sender As Object, e As EventArgs) Handles SDButton.Click
        StudentDetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ASButton_Click(sender As Object, e As EventArgs) Handles ASButton.Click
        AddStudentForm.Show()
        Me.Hide()
    End Sub

    Private Sub ACButton_Click(sender As Object, e As EventArgs) Handles ACButton.Click
        Me.Hide()
        AddCourseForm.Show()
    End Sub

    Private Sub APButton_Click(sender As Object, e As EventArgs) Handles APButton.Click
        Me.Hide()
        AddProfessorForm.Show()
    End Sub

    Private Sub AIButton_Click(sender As Object, e As EventArgs) Handles AIButton.Click
        Me.Hide()
        AddInternalForm.Show()
    End Sub

    Private Sub AMButton_Click(sender As Object, e As EventArgs) Handles AMButton.Click
        Me.Hide()
        AddMarkForm.Show()
    End Sub

    Private Sub CDButton_Click(sender As Object, e As EventArgs) Handles CDButton.Click
        CourseDetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub PDButton_Click(sender As Object, e As EventArgs) Handles PDButton.Click
        ProfDetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class