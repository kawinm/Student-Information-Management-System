Public Class AddMarkForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Try
            Dim sRegNo As Integer = SRegNoField.Text
            Dim cCode As String = CCodeField.Text
            Dim mark As Integer = MarkField.Text
            Dim semNo As Integer = SemNoField.Text

            Dim markAddDB As New DBConnectionClass

            markAddDB.Mark(sRegNo, cCode, mark, semNo)
            MsgPanel.Show()
        Catch
            ErrorPanel.Show()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgPanel.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorPanel.Hide()
    End Sub
End Class