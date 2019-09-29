Imports System.Data
Imports System.Data.SqlClient

Public Class CourseDetailsForm

    Dim conn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & "E:\src\windows form project\StudentInformation\StudentInformation\studentinfo.mdf" & ";Integrated Security=True;Connect Timeout=30"
    Dim connection As SqlConnection = New SqlConnection(conn)

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CourseDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM [course]"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        While reader.Read
            Dim regButton As New Button
            regButton.Tag = reader("cId")
            regButton.Text = reader("cCode").ToString
            CCodePanel.Controls.Add(regButton)

            Dim fnButton As New Button
            fnButton.Tag = reader("cId")
            fnButton.Text = reader("cName").ToString
            CNamePanel.Controls.Add(fnButton)

            Dim lnButton As New Button
            lnButton.Tag = reader("cId")
            lnButton.Text = reader("cRegulation").ToString
            RegPanel.Controls.Add(lnButton)

            Dim deptButton As New Button
            deptButton.Tag = reader("cId")
            deptButton.Text = reader("cType").ToString
            TypePanel.Controls.Add(deptButton)

        End While

        connection.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class