<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleOwner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleOwner))
        Me.lblSpecimenNumber = New System.Windows.Forms.Label()
        Me.txtSpecimenNumber = New System.Windows.Forms.TextBox()
        Me.chkFeeding = New System.Windows.Forms.CheckBox()
        Me.chkMaintenance = New System.Windows.Forms.CheckBox()
        Me.lblCompletedFeeding = New System.Windows.Forms.Label()
        Me.lblCompletedMaintenance = New System.Windows.Forms.Label()
        Me.txtFeedingDate = New System.Windows.Forms.TextBox()
        Me.txtMaintenanceDate = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSpecimenNumber
        '
        Me.lblSpecimenNumber.AutoSize = True
        Me.lblSpecimenNumber.Location = New System.Drawing.Point(32, 26)
        Me.lblSpecimenNumber.Name = "lblSpecimenNumber"
        Me.lblSpecimenNumber.Size = New System.Drawing.Size(67, 13)
        Me.lblSpecimenNumber.TabIndex = 0
        Me.lblSpecimenNumber.Text = "Specimen #:"
        '
        'txtSpecimenNumber
        '
        Me.txtSpecimenNumber.Location = New System.Drawing.Point(105, 23)
        Me.txtSpecimenNumber.Name = "txtSpecimenNumber"
        Me.txtSpecimenNumber.Size = New System.Drawing.Size(247, 20)
        Me.txtSpecimenNumber.TabIndex = 1
        '
        'chkFeeding
        '
        Me.chkFeeding.AutoSize = True
        Me.chkFeeding.Location = New System.Drawing.Point(35, 75)
        Me.chkFeeding.Name = "chkFeeding"
        Me.chkFeeding.Size = New System.Drawing.Size(64, 17)
        Me.chkFeeding.TabIndex = 2
        Me.chkFeeding.Text = "Feeding"
        Me.chkFeeding.UseVisualStyleBackColor = True
        '
        'chkMaintenance
        '
        Me.chkMaintenance.AutoSize = True
        Me.chkMaintenance.Location = New System.Drawing.Point(35, 124)
        Me.chkMaintenance.Name = "chkMaintenance"
        Me.chkMaintenance.Size = New System.Drawing.Size(88, 17)
        Me.chkMaintenance.TabIndex = 3
        Me.chkMaintenance.Text = "Maintenance"
        Me.chkMaintenance.UseVisualStyleBackColor = True
        '
        'lblCompletedFeeding
        '
        Me.lblCompletedFeeding.AutoSize = True
        Me.lblCompletedFeeding.Location = New System.Drawing.Point(133, 76)
        Me.lblCompletedFeeding.Name = "lblCompletedFeeding"
        Me.lblCompletedFeeding.Size = New System.Drawing.Size(113, 13)
        Me.lblCompletedFeeding.TabIndex = 4
        Me.lblCompletedFeeding.Text = "Date to be Completed:"
        '
        'lblCompletedMaintenance
        '
        Me.lblCompletedMaintenance.AutoSize = True
        Me.lblCompletedMaintenance.Location = New System.Drawing.Point(133, 125)
        Me.lblCompletedMaintenance.Name = "lblCompletedMaintenance"
        Me.lblCompletedMaintenance.Size = New System.Drawing.Size(113, 13)
        Me.lblCompletedMaintenance.TabIndex = 5
        Me.lblCompletedMaintenance.Text = "Date to be Completed:"
        '
        'txtFeedingDate
        '
        Me.txtFeedingDate.Location = New System.Drawing.Point(252, 73)
        Me.txtFeedingDate.Name = "txtFeedingDate"
        Me.txtFeedingDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFeedingDate.TabIndex = 6
        '
        'txtMaintenanceDate
        '
        Me.txtMaintenanceDate.Location = New System.Drawing.Point(252, 122)
        Me.txtMaintenanceDate.Name = "txtMaintenanceDate"
        Me.txtMaintenanceDate.Size = New System.Drawing.Size(100, 20)
        Me.txtMaintenanceDate.TabIndex = 7
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(35, 162)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(277, 260)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(277, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmScheduleOwner
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(363, 341)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.txtMaintenanceDate)
        Me.Controls.Add(Me.txtFeedingDate)
        Me.Controls.Add(Me.lblCompletedMaintenance)
        Me.Controls.Add(Me.lblCompletedFeeding)
        Me.Controls.Add(Me.chkMaintenance)
        Me.Controls.Add(Me.chkFeeding)
        Me.Controls.Add(Me.txtSpecimenNumber)
        Me.Controls.Add(Me.lblSpecimenNumber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScheduleOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScheduleOwner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpecimenNumber As Label
    Friend WithEvents txtSpecimenNumber As TextBox
    Friend WithEvents chkFeeding As CheckBox
    Friend WithEvents chkMaintenance As CheckBox
    Friend WithEvents lblCompletedFeeding As Label
    Friend WithEvents lblCompletedMaintenance As Label
    Friend WithEvents txtFeedingDate As TextBox
    Friend WithEvents txtMaintenanceDate As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
End Class
