Public Class frmWelcome
    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        Dim Owner As New frmOwnerAuthentication
        Owner.Show()
        Me.Hide()
    End Sub

    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click
        Dim Employee As New frmEmployeeAuthentication
        Employee.Show()
        Me.Hide()
    End Sub
End Class
