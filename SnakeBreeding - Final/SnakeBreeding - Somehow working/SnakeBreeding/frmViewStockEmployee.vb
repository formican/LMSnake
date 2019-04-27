Public Class frmViewStockEmployee
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Employee As New frmEmployee
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub frmViewStockOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DatabaseLM1DataSet.Table2)

    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLM1DataSet)

    End Sub
End Class