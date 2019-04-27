Public Class frmUsers
    Dim Username As String
    Dim Password As String


    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLM1DataSet)

    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DatabaseLM1DataSet.Table1)

    End Sub

    Private Sub radEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles radEmployee.CheckedChanged
        If radEmployee.Checked Then
            txtType.Text = radEmployee.Text
        End If
    End Sub

    Private Sub radOwner_CheckedChanged(sender As Object, e As EventArgs) Handles radOwner.CheckedChanged
        If radOwner.Checked Then
            txtType.Text = radOwner.Text
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Table1BindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DatabaseLM1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error: Fill all fields")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Table1BindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DatabaseLM1DataSet)
        MsgBox("Success")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class