Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc
Imports System.IO

Public Class DataStudentForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentinfoDataSet4.students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter1.Fill(Me.StudentinfoDataSet4.students)
        'TODO: This line of code loads data into the 'StudentinfoDataSet1.students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.StudentinfoDataSet1.students)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter Filename to create PDF")
            Exit Sub
        Else
            ExportDataToPDFTable()
            MsgBox("PDF Created Successfully")
        End If
    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(DataGridView1.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(DataGridView1.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(DataGridView1.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(DataGridView1.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(DataGridView1.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        Dim dataColumn_6 As New DataColumn(DataGridView1.Columns(5).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_6)
        Dim dataColumn_7 As New DataColumn(DataGridView1.Columns(6).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_7)
        Dim dataColumn_8 As New DataColumn(DataGridView1.Columns(9).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_8)
        Dim dataColumn_9 As New DataColumn(DataGridView1.Columns(10).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_9)
        Dim dataColumn_10 As New DataColumn(DataGridView1.Columns(11).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_10)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(DataGridView1.Columns(0).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(0).Value.ToString()
            dataRow(DataGridView1.Columns(1).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(1).Value.ToString()
            dataRow(DataGridView1.Columns(2).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(2).Value.ToString()
            dataRow(DataGridView1.Columns(3).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(3).Value.ToString()
            dataRow(DataGridView1.Columns(4).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(4).Value.ToString()
            dataRow(DataGridView1.Columns(5).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(5).Value.ToString()
            dataRow(DataGridView1.Columns(6).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(6).Value.ToString()
            dataRow(DataGridView1.Columns(9).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(9).Value.ToString()
            dataRow(DataGridView1.Columns(10).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(10).Value.ToString()
            dataRow(DataGridView1.Columns(11).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(11).Value.ToString()

            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLD, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("GCE Dharmapuri", font12BoldRed))
        doc.Add(p1)
        p1 = New Phrase(New Chunk("Student Informtion", font12BoldRed))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(10)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Register Number", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Name", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Mail Id", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Department", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Semester", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Hosteller", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Address", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Date of Birth", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Father's Name", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Date of Join", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)

        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub

End Class