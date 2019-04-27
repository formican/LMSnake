Public Class frmOwnerAuthentication
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim Owner As New frmOwner
        Owner.Show()
        Me.Hide()
    End Sub

End Class