Imports System.Data
Imports System.Data.SqlClient

Public Class ProfDetailsForm

    Dim conn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & "E:\src\windows form project\StudentInformation\StudentInformation\studentinfo.mdf" & ";Integrated Security=True;Connect Timeout=30"
    Dim connection As SqlConnection = New SqlConnection(conn)

    Private Sub ProfDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM [professor]"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        While reader.Read
            Dim regButton As New Button
            regButton.Tag = reader("pId")
            regButton.Text = reader("pRegNo").ToString
            RegNoPanel.Controls.Add(regButton)

            Dim fnButton As New Button
            fnButton.Tag = reader("pId")
            fnButton.Text = reader("pFirstName").ToString
            FirstNamePanel.Controls.Add(fnButton)

            Dim lnButton As New Button
            lnButton.Tag = reader("pId")
            lnButton.Text = reader("pLastName").ToString
            LastNamePanel.Controls.Add(lnButton)

            Dim deptButton As New Button
            deptButton.Tag = reader("pId")
            deptButton.Text = reader("pDept").ToString
            DeptPanel.Controls.Add(deptButton)

            Dim dojButton As New Button
            dojButton.Tag = reader("pId")
            dojButton.Text = reader("pDateOfJoin").ToString
            DojPanel.Controls.Add(dojButton)
        End While

        connection.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class