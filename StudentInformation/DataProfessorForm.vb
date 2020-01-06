Public Class DataProfessorForm
    Private Sub DataProfessorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentinfoDataSet3.professor' table. You can move, or remove it, as needed.
        Me.ProfessorTableAdapter.Fill(Me.StudentinfoDataSet3.professor)

    End Sub
End Class