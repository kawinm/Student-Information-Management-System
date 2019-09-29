Imports System.Data
Imports System.Data.SqlClient

Public Class DBConnectionClass

    Dim conn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & "E:\src\windows form project\StudentInformation\StudentInformation\studentinfo.mdf" & ";Integrated Security=True;Connect Timeout=30"
    Dim connection As SqlConnection = New SqlConnection(conn)

    Public Sub Login(uMail As String, uPassword As String)

        Dim sql As String = "SELECT uPassword FROM [users] WHERE uMailId = @uMail"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@uMail", uMail)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        If reader.Read Then
            Console.Write(reader("uPassword").ToString)
            If reader("uPassword").ToString = uPassword Then
                MainForm.Show()
                LoginForm.Hide()
            Else
                LoginForm.Show()
            End If
        Else
            LoginForm.Show()
        End If


        connection.Close()
    End Sub

    Public Sub Register(uFirstName As String, uLastName As String, uMail As String, uPassword As String, uRole As String)

        Dim sql As String = "INSERT INTO [users] ([uFirstName], [uLastName], [uMailId], [uPassword], [uRole]) VALUES (@uFirstName, @uLastName, @uMail, @uPassword, @uRole)"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        cmd.Parameters.AddWithValue("@uFirstName", uFirstName)
        cmd.Parameters.AddWithValue("@uLastName", uLastName)
        cmd.Parameters.AddWithValue("@uMail", uMail)
        cmd.Parameters.AddWithValue("@uPassword", uPassword)
        cmd.Parameters.AddWithValue("@uRole", uRole)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        LoginForm.Show()
        RegisterForm.Hide()

    End Sub

    Public Sub StudentAdd(sFirstName As String, sLastName As String, sDept As String, sSem As Integer, sDoj As String, sRegNo As Integer)

        Dim sql As String = "INSERT INTO [students] ([sFirstName], [sLastName], [sDept], [sSemester], [sDateOfJoin], [sRegNo]) VALUES (@sFirstName, @sLastName, @sDept, @sSem, @sDoj, @sRegNo)"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        cmd.Parameters.AddWithValue("@sFirstName", sFirstName)
        cmd.Parameters.AddWithValue("@sLastName", sLastName)
        cmd.Parameters.AddWithValue("@sDept", sDept)
        cmd.Parameters.AddWithValue("@sSem", sSem)
        cmd.Parameters.AddWithValue("@sDoj", sDoj)
        cmd.Parameters.AddWithValue("@sRegNo", sRegNo)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub CourseAdd(cName As String, cCode As String, cReg As String, courseType As Integer)

        Dim sql As String = "INSERT INTO [course] ([cName], [cCode], [cRegulation], [cType]) VALUES (@cName, @cCode, @cReg, @courseType)"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        cmd.Parameters.AddWithValue("@cName", cName)
        cmd.Parameters.AddWithValue("@cCode", cCode)
        cmd.Parameters.AddWithValue("@cReg", cReg)
        cmd.Parameters.AddWithValue("@courseType", courseType)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub ProfAdd(sFirstName As String, sLastName As String, sDept As String, sDoj As String, sRegNo As Integer)

        Dim sql As String = "INSERT INTO [professor] ([pFirstName], [pLastName], [pDept], [pDateOfJoin], [pRegNo]) VALUES (@sFirstName, @sLastName, @sDept, @sDoj, @sRegNo)"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)

        cmd.Parameters.AddWithValue("@sFirstName", sFirstName)
        cmd.Parameters.AddWithValue("@sLastName", sLastName)
        cmd.Parameters.AddWithValue("@sDept", sDept)
        cmd.Parameters.AddWithValue("@sDoj", sDoj)
        cmd.Parameters.AddWithValue("@sRegNo", sRegNo)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        MsgBox("Professor Added Successfully")
    End Sub

    Public Sub Internal(sRegNo As Integer, cCode As String, pRegNo As Integer, mark As Integer, semNo As Integer, intNo As Integer)

        Dim sql As String = "SELECT sId FROM [students] WHERE sRegNo = @sRegNo"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@sRegNo", sRegNo)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        Dim sid As Integer = -1
        Dim cid As Integer = -1
        Dim pid As Integer = -1
        If reader.Read Then
            sid = reader("sId")
        End If

        connection.Close()

        sql = "SELECT cId FROM [course] WHERE cCode = @cCode"
        Dim cmd1 As SqlCommand = New SqlCommand(sql, connection)
        cmd1.Parameters.AddWithValue("@cCode", cCode)

        connection.Open()
        Dim reader1 As SqlDataReader = cmd1.ExecuteReader

        If reader1.Read Then
            cid = reader1("cId")
        End If

        connection.Close()

        sql = "SELECT pId FROM [professor] WHERE pRegNo = @pRegNo"
        Dim cmd2 As SqlCommand = New SqlCommand(sql, connection)
        cmd2.Parameters.AddWithValue("@pRegNo", pRegNo)

        connection.Open()
        Dim reader2 As SqlDataReader = cmd2.ExecuteReader

        If reader2.Read Then
            pid = reader2("pId")
        End If

        connection.Close()

        Dim sql1 As String = "INSERT INTO [internals] ([sId], [pId], [cId], [mark], [semNo], [iNo]) VALUES (@sId, @pId, @cId, @mark, @semNo, @iNo)"
        Dim cmd5 As SqlCommand = New SqlCommand(sql1, connection)

        cmd5.Parameters.AddWithValue("@sId", sid)
        cmd5.Parameters.AddWithValue("@pId", pid)
        cmd5.Parameters.AddWithValue("@cId", cid)
        cmd5.Parameters.AddWithValue("@mark", mark)
        cmd5.Parameters.AddWithValue("@semNo", semNo)
        cmd5.Parameters.AddWithValue("@iNo", intNo)

        connection.Open()
        cmd5.ExecuteNonQuery()
        connection.Close()

        MsgBox("Internal Mark Added Successfully")
    End Sub

    Public Sub Mark(sRegNo As Integer, cCode As String, mark As Integer, semNo As Integer)

        Dim sql As String = "SELECT sId FROM [students] WHERE sRegNo = @sRegNo"
        Dim cmd As SqlCommand = New SqlCommand(sql, connection)
        cmd.Parameters.AddWithValue("@sRegNo", sRegNo)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        Dim sid As Integer = -1
        Dim cid As Integer = -1
        If reader.Read Then
            sid = reader("sId")
        End If

        connection.Close()

        sql = "SELECT cId FROM [course] WHERE cCode = @cCode"
        Dim cmd1 As SqlCommand = New SqlCommand(sql, connection)
        cmd1.Parameters.AddWithValue("@cCode", cCode)

        connection.Open()
        Dim reader1 As SqlDataReader = cmd1.ExecuteReader

        If reader1.Read Then
            cid = reader1("cId")
        End If

        connection.Close()

        Dim sql1 As String = "INSERT INTO [marks] ([sId], [cId], [mark], [semNo]) VALUES (@sId, @cId, @mark, @semNo)"
        Dim cmd5 As SqlCommand = New SqlCommand(sql1, connection)

        cmd5.Parameters.AddWithValue("@sId", sid)
        cmd5.Parameters.AddWithValue("@cId", cid)
        cmd5.Parameters.AddWithValue("@mark", mark)
        cmd5.Parameters.AddWithValue("@semNo", semNo)

        connection.Open()
        cmd5.ExecuteNonQuery()
        connection.Close()

        MsgBox("Mark Added Successfully")
    End Sub

End Class
