Public Class frmEmployeeAuthentication
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim Empleyee As New frmEmployee
        frmEmployee.Show()
        Me.Hide()
    End Sub
End Class