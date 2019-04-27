<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.btnViewStock = New System.Windows.Forms.Button()
        Me.btnViewSpecimen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewStock
        '
        Me.btnViewStock.Location = New System.Drawing.Point(21, 29)
        Me.btnViewStock.Name = "btnViewStock"
        Me.btnViewStock.Size = New System.Drawing.Size(93, 23)
        Me.btnViewStock.TabIndex = 0
        Me.btnViewStock.Text = "View S&tock"
        Me.btnViewStock.UseVisualStyleBackColor = True
        '
        'btnViewSpecimen
        '
        Me.btnViewSpecimen.Location = New System.Drawing.Point(131, 29)
        Me.btnViewSpecimen.Name = "btnViewSpecimen"
        Me.btnViewSpecimen.Size = New System.Drawing.Size(96, 23)
        Me.btnViewSpecimen.TabIndex = 1
        Me.btnViewSpecimen.Text = "View S&pecimen"
        Me.btnViewSpecimen.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(81, 73)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(254, 115)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewSpecimen)
        Me.Controls.Add(Me.btnViewStock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewStock As Button
    Friend WithEvents btnViewSpecimen As Button
    Friend WithEvents btnExit As Button
End Class
