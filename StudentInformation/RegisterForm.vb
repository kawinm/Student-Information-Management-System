Public Class RegisterForm
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstNameField.TextChanged

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Try
            Dim uFirstName As String = FirstNameField.Text
            Dim uLastName As String = LastNameField.Text
            Dim uMail As String = MailIdField.Text
            Dim uPassword As String = PasswordField.Text
            Dim uRole As String = RoleField.Text

            Dim registerDB As New DBConnectionClass

            registerDB.Register(uFirstName, uLastName, uMail, uPassword, uRole)
        Catch
            ErrorPanel.Show()
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorPanel.Hide()

    End Sub
End Class