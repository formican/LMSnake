<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveSpecimen
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
        Me.components = New System.ComponentModel.Container()
        Dim SpecimenIDLabel As System.Windows.Forms.Label
        Dim SpeciesLabel As System.Windows.Forms.Label
        Dim HatchDateLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim NextBreedDateLabel As System.Windows.Forms.Label
        Dim FeedDateLabel As System.Windows.Forms.Label
        Dim MaintDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemoveSpecimen))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DatabaseLM1DataSet = New SnakeBreeding.DatabaseLM1DataSet()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table2TableAdapter = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.Table2TableAdapter()
        Me.TableAdapterManager = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.TableAdapterManager()
        Me.SpecimenIDTextBox = New System.Windows.Forms.TextBox()
        Me.SpeciesTextBox = New System.Windows.Forms.TextBox()
        Me.HatchDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.NextBreedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FeedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MaintDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        SpecimenIDLabel = New System.Windows.Forms.Label()
        SpeciesLabel = New System.Windows.Forms.Label()
        HatchDateLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        NextBreedDateLabel = New System.Windows.Forms.Label()
        FeedDateLabel = New System.Windows.Forms.Label()
        MaintDateLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpecimenIDLabel
        '
        SpecimenIDLabel.AutoSize = True
        SpecimenIDLabel.Location = New System.Drawing.Point(22, 9)
        SpecimenIDLabel.Name = "SpecimenIDLabel"
        SpecimenIDLabel.Size = New System.Drawing.Size(71, 13)
        SpecimenIDLabel.TabIndex = 13
        SpecimenIDLabel.Text = "Specimen ID:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Location = New System.Drawing.Point(22, 35)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(48, 13)
        SpeciesLabel.TabIndex = 15
        SpeciesLabel.Text = "Species:"
        '
        'HatchDateLabel
        '
        HatchDateLabel.AutoSize = True
        HatchDateLabel.Location = New System.Drawing.Point(22, 62)
        HatchDateLabel.Name = "HatchDateLabel"
        HatchDateLabel.Size = New System.Drawing.Size(65, 13)
        HatchDateLabel.TabIndex = 17
        HatchDateLabel.Text = "Hatch Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(22, 87)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 19
        SexLabel.Text = "Sex:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(22, 113)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 21
        WeightLabel.Text = "Weight:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(22, 139)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 23
        ColorLabel.Text = "Color:"
        '
        'NextBreedDateLabel
        '
        NextBreedDateLabel.AutoSize = True
        NextBreedDateLabel.Location = New System.Drawing.Point(22, 166)
        NextBreedDateLabel.Name = "NextBreedDateLabel"
        NextBreedDateLabel.Size = New System.Drawing.Size(89, 13)
        NextBreedDateLabel.TabIndex = 25
        NextBreedDateLabel.Text = "Next Breed Date:"
        '
        'FeedDateLabel
        '
        FeedDateLabel.AutoSize = True
        FeedDateLabel.Location = New System.Drawing.Point(22, 192)
        FeedDateLabel.Name = "FeedDateLabel"
        FeedDateLabel.Size = New System.Drawing.Size(60, 13)
        FeedDateLabel.TabIndex = 27
        FeedDateLabel.Text = "Feed Date:"
        '
        'MaintDateLabel
        '
        MaintDateLabel.AutoSize = True
        MaintDateLabel.Location = New System.Drawing.Point(22, 218)
        MaintDateLabel.Name = "MaintDateLabel"
        MaintDateLabel.Size = New System.Drawing.Size(62, 13)
        MaintDateLabel.TabIndex = 29
        MaintDateLabel.Text = "Maint Date:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(84, 269)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(178, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DatabaseLM1DataSet
        '
        Me.DatabaseLM1DataSet.DataSetName = "DatabaseLM1DataSet"
        Me.DatabaseLM1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.DatabaseLM1DataSet
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Nothing
        Me.TableAdapterManager.Table2TableAdapter = Me.Table2TableAdapter
        Me.TableAdapterManager.UpdateOrder = SnakeBreeding.DatabaseLM1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SpecimenIDTextBox
        '
        Me.SpecimenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "SpecimenID", True))
        Me.SpecimenIDTextBox.Location = New System.Drawing.Point(117, 6)
        Me.SpecimenIDTextBox.Name = "SpecimenIDTextBox"
        Me.SpecimenIDTextBox.ReadOnly = True
        Me.SpecimenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpecimenIDTextBox.TabIndex = 14
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Species", True))
        Me.SpeciesTextBox.Location = New System.Drawing.Point(117, 32)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.ReadOnly = True
        Me.SpeciesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpeciesTextBox.TabIndex = 16
        '
        'HatchDateDateTimePicker
        '
        Me.HatchDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "HatchDate", True))
        Me.HatchDateDateTimePicker.Location = New System.Drawing.Point(117, 58)
        Me.HatchDateDateTimePicker.Name = "HatchDateDateTimePicker"
        Me.HatchDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HatchDateDateTimePicker.TabIndex = 18
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(117, 84)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.ReadOnly = True
        Me.SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SexTextBox.TabIndex = 20
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(117, 110)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.ReadOnly = True
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 22
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(117, 136)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.ReadOnly = True
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 24
        '
        'NextBreedDateDateTimePicker
        '
        Me.NextBreedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "NextBreedDate", True))
        Me.NextBreedDateDateTimePicker.Location = New System.Drawing.Point(117, 162)
        Me.NextBreedDateDateTimePicker.Name = "NextBreedDateDateTimePicker"
        Me.NextBreedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.NextBreedDateDateTimePicker.TabIndex = 26
        '
        'FeedDateDateTimePicker
        '
        Me.FeedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "FeedDate", True))
        Me.FeedDateDateTimePicker.Location = New System.Drawing.Point(117, 188)
        Me.FeedDateDateTimePicker.Name = "FeedDateDateTimePicker"
        Me.FeedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FeedDateDateTimePicker.TabIndex = 28
        '
        'MaintDateDateTimePicker
        '
        Me.MaintDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "MaintDate", True))
        Me.MaintDateDateTimePicker.Location = New System.Drawing.Point(117, 214)
        Me.MaintDateDateTimePicker.Name = "MaintDateDateTimePicker"
        Me.MaintDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MaintDateDateTimePicker.TabIndex = 30
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(25, 240)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 31
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(240, 240)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmRemoveSpecimen
        '
        Me.AcceptButton = Me.btnRemove
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(327, 302)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(SpecimenIDLabel)
        Me.Controls.Add(Me.SpecimenIDTextBox)
        Me.Controls.Add(SpeciesLabel)
        Me.Controls.Add(Me.SpeciesTextBox)
        Me.Controls.Add(HatchDateLabel)
        Me.Controls.Add(Me.HatchDateDateTimePicker)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(NextBreedDateLabel)
        Me.Controls.Add(Me.NextBreedDateDateTimePicker)
        Me.Controls.Add(FeedDateLabel)
        Me.Controls.Add(Me.FeedDateDateTimePicker)
        Me.Controls.Add(MaintDateLabel)
        Me.Controls.Add(Me.MaintDateDateTimePicker)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRemove)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRemoveSpecimen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove Specimen"
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DatabaseLM1DataSet As DatabaseLM1DataSet
    Friend WithEvents Table2BindingSource As BindingSource
    Friend WithEvents Table2TableAdapter As DatabaseLM1DataSetTableAdapters.Table2TableAdapter
    Friend WithEvents TableAdapterManager As DatabaseLM1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SpecimenIDTextBox As TextBox
    Friend WithEvents SpeciesTextBox As TextBox
    Friend WithEvents HatchDateDateTimePicker As DateTimePicker
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents NextBreedDateDateTimePicker As DateTimePicker
    Friend WithEvents FeedDateDateTimePicker As DateTimePicker
    Friend WithEvents MaintDateDateTimePicker As DateTimePicker
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
