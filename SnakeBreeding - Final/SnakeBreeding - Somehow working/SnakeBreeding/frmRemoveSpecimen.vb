Public Class frmRemoveSpecimen
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Table2BindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(DatabaseLM1DataSet)
        MsgBox("Deleted")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Owner As New frmOwner
        Owner.Show()
        Me.Hide()

    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLM1DataSet)

    End Sub

    Private Sub frmRemoveSpecimen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DatabaseLM1DataSet.Table2)

    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Table2BindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Table2BindingSource.MoveNext()
    End Sub
End Class