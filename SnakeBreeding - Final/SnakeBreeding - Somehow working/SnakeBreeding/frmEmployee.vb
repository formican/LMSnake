Public Class frmEmployee
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Welcome As New frmWelcome
        Welcome.Show()
        Me.Hide()
    End Sub



    Private Sub btnViewStock_Click(sender As Object, e As EventArgs) Handles btnViewStock.Click
        Dim ViewStock As New frmViewStockEmployee
        ViewStock.Show()
        Me.Hide()
    End Sub
End Class