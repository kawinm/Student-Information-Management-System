﻿Public Class AddProfessorForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Try
            Dim sFirstName As String = FirstNameField.Text
            Dim sLastName As String = LastNameField.Text
            Dim sDept As String = DeptField.Text
            Dim sDoj As String = Doj.Text
            Dim sRegNo As Integer = RegNoField.Text

            Dim profAddDB As New DBConnectionClass

            profAddDB.ProfAdd(sFirstName, sLastName, sDept, sDoj, sRegNo)
            MsgPanel.Show()
        Catch
            ErrorPanel.Show()
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgPanel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorPanel.Hide()
    End Sub
End Class