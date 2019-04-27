Public Class frmScheduleOwner
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim ViewSpecimen As New frmViewSpecimenOwner
        ViewSpecimen.Show()
        Me.Hide()
    End Sub
End Class