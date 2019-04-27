Public Class frmViewSpecimenOwner
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Owner As New frmOwner
        Owner.Show()
        Me.Hide()
    End Sub

    Private Sub btnMF_Click(sender As Object, e As EventArgs)
        Dim Schedule As New frmScheduleOwner
        Schedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtSearch.Text

    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLM1DataSet)

    End Sub

    Private Sub frmViewSpecimenOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DatabaseLM1DataSet.Table2)
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DatabaseLM1DataSet.Table2)
        'TODO: This line of code loads data into the 'DatabaseLM1DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.DatabaseLM1DataSet.Table2)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.Table2BindingSource.Filter = "SpecimenID ='" & txtSearch.Text & "'"
    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLM1DataSet)

    End Sub
End Class