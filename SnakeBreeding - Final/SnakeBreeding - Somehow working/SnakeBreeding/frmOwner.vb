Public Class frmOwner
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Welcome As New frmWelcome
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewSpecimen_Click(sender As Object, e As EventArgs) Handles btnViewSpecimen.Click
        Dim ViewSpecimen As New frmViewSpecimenOwner
        ViewSpecimen.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddSpecimen_Click(sender As Object, e As EventArgs) Handles btnAddSpecimen.Click
        Dim AddSpecimen As New frmAddSpecimen
        AddSpecimen.Show()
        Me.Hide()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim remove As New frmRemoveSpecimen
        remove.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewStock_Click(sender As Object, e As EventArgs) Handles btnViewStock.Click
        Dim ViewStock As New frmViewStockOwner
        ViewStock.Show()
        Me.Hide()
    End Sub

    Private Sub btnChangePasswords_Click(sender As Object, e As EventArgs) Handles btnChangePasswords.Click
        Dim Users As New frmUsers
        Users.Show()
        Me.Hide()
    End Sub
End Class