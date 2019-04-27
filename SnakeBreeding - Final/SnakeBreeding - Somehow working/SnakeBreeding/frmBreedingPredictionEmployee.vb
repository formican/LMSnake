Public Class frmBreedingPredictionEmployee
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim specimenOne As Integer
        Dim specimenTwo As Integer

        specimenOne = CInt(txtSpecimen1.Text)
        specimenTwo = CInt(txtSpecimen2.Text)

        Dim SpecimenOneColor As String
        Dim SpecimenTwoColor As String

        SpecimenOneColor = "Yellow"
        SpecimenTwoColor = "Green"

        If SpecimenOneColor = "Yellow" And SpecimenTwoColor = "Green" Then

            txtProbabilities.Text = "Yellow: 75%" + vbNewLine + "Green 15%" + vbNewLine + "Lime 10%" + vbNewLine + "Albino 5%"

        End If
    End Sub

    Private Sub frmBreedingPredictionEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DatabaseLM1DataSet.Table2)

    End Sub
End Class