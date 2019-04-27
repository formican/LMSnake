Public Class frmAddSpecimen
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Owner As New frmOwner
        Owner.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Table2BindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DatabaseLM1DataSet)
            MsgBox("Success")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLM1DataSet)

    End Sub

    Private Sub frmAddSpecimen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.

        Table2BindingSource.AddNew()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Table2BindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Table2BindingSource.MoveNext()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Table2BindingSource.AddNew()
    End Sub

    Private Sub btnMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        If radMale.Checked Then
            txtSex.Text = radMale.Text
        End If
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        If radFemale.Checked Then
            txtSex.Text = radFemale.Text
        End If
    End Sub
End Class