<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOwner))
        Me.btnAddSpecimen = New System.Windows.Forms.Button()
        Me.btnViewStock = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnViewSpecimen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnChangePasswords = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddSpecimen
        '
        Me.btnAddSpecimen.Location = New System.Drawing.Point(12, 12)
        Me.btnAddSpecimen.Name = "btnAddSpecimen"
        Me.btnAddSpecimen.Size = New System.Drawing.Size(92, 23)
        Me.btnAddSpecimen.TabIndex = 0
        Me.btnAddSpecimen.Text = "&Add Specimen"
        Me.btnAddSpecimen.UseVisualStyleBackColor = True
        '
        'btnViewStock
        '
        Me.btnViewStock.Location = New System.Drawing.Point(126, 12)
        Me.btnViewStock.Name = "btnViewStock"
        Me.btnViewStock.Size = New System.Drawing.Size(92, 23)
        Me.btnViewStock.TabIndex = 1
        Me.btnViewStock.Text = "View S&tock"
        Me.btnViewStock.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 55)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(92, 34)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "&Remove Specimen"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnViewSpecimen
        '
        Me.btnViewSpecimen.Location = New System.Drawing.Point(126, 61)
        Me.btnViewSpecimen.Name = "btnViewSpecimen"
        Me.btnViewSpecimen.Size = New System.Drawing.Size(92, 23)
        Me.btnViewSpecimen.TabIndex = 3
        Me.btnViewSpecimen.Text = "View S&pecimen"
        Me.btnViewSpecimen.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(78, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnChangePasswords
        '
        Me.btnChangePasswords.Location = New System.Drawing.Point(68, 99)
        Me.btnChangePasswords.Name = "btnChangePasswords"
        Me.btnChangePasswords.Size = New System.Drawing.Size(96, 35)
        Me.btnChangePasswords.TabIndex = 5
        Me.btnChangePasswords.Text = "Add or Modify Users"
        Me.btnChangePasswords.UseVisualStyleBackColor = True
        '
        'frmOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(233, 182)
        Me.Controls.Add(Me.btnChangePasswords)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewSpecimen)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnViewStock)
        Me.Controls.Add(Me.btnAddSpecimen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Owner"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddSpecimen As Button
    Friend WithEvents btnViewStock As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnViewSpecimen As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnChangePasswords As Button
End Class
