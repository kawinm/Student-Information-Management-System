Imports System.Data
Imports System.Data.SqlClient

Public Class StudentDetailsForm

    Dim conn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & "E:\src\windows form project\StudentInformation\StudentInformation\studentinfo.mdf" & ";Integrated Security=True;Connect Timeout=30"
    Dim connection As SqlConnection = New SqlConnection(conn)

    Private Sub DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM [students]"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        While reader.Read
            Dim regButton As New Button
            regButton.Tag = reader("sId")
            regButton.Text = reader("sRegNo").ToString
            RegNoPanel.Controls.Add(regButton)

            Dim fnButton As New Button
            fnButton.Tag = reader("sId")
            fnButton.Text = reader("sFirstName").ToString
            FirstNamePanel.Controls.Add(fnButton)

            Dim lnButton As New Button
            lnButton.Tag = reader("sId")
            lnButton.Text = reader("sLastName").ToString
            LastNamePanel.Controls.Add(lnButton)

            Dim deptButton As New Button
            deptButton.Tag = reader("sId")
            deptButton.Text = reader("sDept").ToString
            DeptPanel.Controls.Add(deptButton)

            Dim semButton As New Button
            semButton.Tag = reader("sId")
            semButton.Text = reader("sSemester").ToString
            SemPanel.Controls.Add(semButton)

            Dim dojButton As New Button
            dojButton.Tag = reader("sId")
            dojButton.Text = reader("sDateOfJoin").ToString
            DojPanel.Controls.Add(dojButton)
        End While

        connection.Close()
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles DeptPanel.Paint

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()

    End Sub
End Class