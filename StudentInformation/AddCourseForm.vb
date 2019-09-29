Public Class AddCourseForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Try
            Dim cName As String = CNameField.Text
            Dim cCode As String = CCodeField.Text
            Dim cReg As String = CRegulationField.Text
            Dim courseType As Integer = CTypeField.Text

            Dim courseAddDB As New DBConnectionClass

            courseAddDB.CourseAdd(cName, cCode, cReg, courseType)
            MsgPanel.Show()
        Catch
            ErrorPanel.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgPanel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorPanel.Hide()
    End Sub
End Class