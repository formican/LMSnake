<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSpecimen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSpecimen))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DatabaseLM1DataSet = New SnakeBreeding.DatabaseLM1DataSet()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table2TableAdapter = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.Table2TableAdapter()
        Me.TableAdapterManager = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.TableAdapterManager()
        Me.SpecimenIDTextBox = New System.Windows.Forms.TextBox()
        Me.SpeciesTextBox = New System.Windows.Forms.TextBox()
        Me.HatchDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.NextBreedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FeedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MaintDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
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
        SpecimenIDLabel.Location = New System.Drawing.Point(26, 9)
        SpecimenIDLabel.Name = "SpecimenIDLabel"
        SpecimenIDLabel.Size = New System.Drawing.Size(71, 13)
        SpecimenIDLabel.TabIndex = 9
        SpecimenIDLabel.Text = "Specimen ID:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Location = New System.Drawing.Point(26, 35)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(48, 13)
        SpeciesLabel.TabIndex = 11
        SpeciesLabel.Text = "Species:"
        '
        'HatchDateLabel
        '
        HatchDateLabel.AutoSize = True
        HatchDateLabel.Location = New System.Drawing.Point(26, 62)
        HatchDateLabel.Name = "HatchDateLabel"
        HatchDateLabel.Size = New System.Drawing.Size(65, 13)
        HatchDateLabel.TabIndex = 13
        HatchDateLabel.Text = "Hatch Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(26, 87)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 15
        SexLabel.Text = "Sex:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(26, 113)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 17
        WeightLabel.Text = "Weight:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(26, 139)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 19
        ColorLabel.Text = "Color:"
        '
        'NextBreedDateLabel
        '
        NextBreedDateLabel.AutoSize = True
        NextBreedDateLabel.Location = New System.Drawing.Point(26, 166)
        NextBreedDateLabel.Name = "NextBreedDateLabel"
        NextBreedDateLabel.Size = New System.Drawing.Size(89, 13)
        NextBreedDateLabel.TabIndex = 21
        NextBreedDateLabel.Text = "Next Breed Date:"
        '
        'FeedDateLabel
        '
        FeedDateLabel.AutoSize = True
        FeedDateLabel.Location = New System.Drawing.Point(26, 192)
        FeedDateLabel.Name = "FeedDateLabel"
        FeedDateLabel.Size = New System.Drawing.Size(60, 13)
        FeedDateLabel.TabIndex = 23
        FeedDateLabel.Text = "Feed Date:"
        '
        'MaintDateLabel
        '
        MaintDateLabel.AutoSize = True
        MaintDateLabel.Location = New System.Drawing.Point(26, 218)
        MaintDateLabel.Name = "MaintDateLabel"
        MaintDateLabel.Size = New System.Drawing.Size(62, 13)
        MaintDateLabel.TabIndex = 25
        MaintDateLabel.Text = "Maint Date:"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(135, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(92, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        Me.SpecimenIDTextBox.Location = New System.Drawing.Point(121, 6)
        Me.SpecimenIDTextBox.Name = "SpecimenIDTextBox"
        Me.SpecimenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpecimenIDTextBox.TabIndex = 10
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Species", True))
        Me.SpeciesTextBox.Location = New System.Drawing.Point(121, 32)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpeciesTextBox.TabIndex = 12
        '
        'HatchDateDateTimePicker
        '
        Me.HatchDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "HatchDate", True))
        Me.HatchDateDateTimePicker.Location = New System.Drawing.Point(121, 58)
        Me.HatchDateDateTimePicker.Name = "HatchDateDateTimePicker"
        Me.HatchDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HatchDateDateTimePicker.TabIndex = 14
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Sex", True))
        Me.txtSex.Location = New System.Drawing.Point(121, 84)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.ReadOnly = True
        Me.txtSex.Size = New System.Drawing.Size(74, 20)
        Me.txtSex.TabIndex = 16
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(121, 110)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 18
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(121, 136)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 20
        '
        'NextBreedDateDateTimePicker
        '
        Me.NextBreedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "NextBreedDate", True))
        Me.NextBreedDateDateTimePicker.Location = New System.Drawing.Point(121, 162)
        Me.NextBreedDateDateTimePicker.Name = "NextBreedDateDateTimePicker"
        Me.NextBreedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.NextBreedDateDateTimePicker.TabIndex = 22
        '
        'FeedDateDateTimePicker
        '
        Me.FeedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "FeedDate", True))
        Me.FeedDateDateTimePicker.Location = New System.Drawing.Point(121, 188)
        Me.FeedDateDateTimePicker.Name = "FeedDateDateTimePicker"
        Me.FeedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FeedDateDateTimePicker.TabIndex = 24
        '
        'MaintDateDateTimePicker
        '
        Me.MaintDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "MaintDate", True))
        Me.MaintDateDateTimePicker.Location = New System.Drawing.Point(121, 214)
        Me.MaintDateDateTimePicker.Name = "MaintDateDateTimePicker"
        Me.MaintDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MaintDateDateTimePicker.TabIndex = 26
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(11, 254)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 27
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(254, 254)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 28
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(173, 254)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 29
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(201, 87)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 30
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(254, 87)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 31
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'frmAddSpecimen
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(337, 317)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(SpecimenIDLabel)
        Me.Controls.Add(Me.SpecimenIDTextBox)
        Me.Controls.Add(SpeciesLabel)
        Me.Controls.Add(Me.SpeciesTextBox)
        Me.Controls.Add(HatchDateLabel)
        Me.Controls.Add(Me.HatchDateDateTimePicker)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.txtSex)
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
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddSpecimen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Specimen"
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DatabaseLM1DataSet As DatabaseLM1DataSet
    Friend WithEvents Table2BindingSource As BindingSource
    Friend WithEvents Table2TableAdapter As DatabaseLM1DataSetTableAdapters.Table2TableAdapter
    Friend WithEvents TableAdapterManager As DatabaseLM1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SpecimenIDTextBox As TextBox
    Friend WithEvents SpeciesTextBox As TextBox
    Friend WithEvents HatchDateDateTimePicker As DateTimePicker
    Friend WithEvents txtSex As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents NextBreedDateDateTimePicker As DateTimePicker
    Friend WithEvents FeedDateDateTimePicker As DateTimePicker
    Friend WithEvents MaintDateDateTimePicker As DateTimePicker
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
End Class
