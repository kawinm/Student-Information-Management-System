Public Class AddStudentForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgPanel.Hide()
    End Sub

    Private Sub AddButton_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click

        Try
            Dim sFirstName As String = FirstNameField.Text
            Dim sFatherName As String = FatherNameFIeld.Text
            Dim sRegNo As Integer = RegNoField.Text
            Dim sDob As String = Dob.Text
            Dim sEmail As String = EmailField.Text
            Dim sAddress As String = AddressField.Text
            Dim sDistrict As String = DistrictField.Text
            Dim sPincode As Integer = PincodeField.Text
            Dim sSem As Integer = SemField.Text
            Dim sDoj As String = Doj.Text
            Dim sDept As String = ComboBox1.Text
            Dim sHosteller As String = ComboBox2.Text

            Dim filename As String = sFirstName + sFatherName + ".jpg"
            Dim FileSize As Integer

            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()

            FileSize = mstream.Length
            mstream.Close()

            Dim studentAddDB As New DBConnectionClass

            studentAddDB.StudentAdd(sFirstName, sFatherName, sRegNo, sDob, sEmail, sAddress, sDistrict, sPincode, sSem, sDoj, sDept, sHosteller, FileSize, arrImage)

            MsgPanel.Show()
        Catch
            ErrorPanel.Show()
        End Try

    End Sub

    Private Sub BackButton_Click_1(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorPanel.Hide()

    End Sub

    Private Sub AddStudentForm_Load(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class