<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewSpecimenOwner
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
        Dim Label1 As System.Windows.Forms.Label
        Dim SpecimenIDLabel As System.Windows.Forms.Label
        Dim SpeciesLabel As System.Windows.Forms.Label
        Dim HatchDateLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim NextBreedDateLabel As System.Windows.Forms.Label
        Dim FeedDateLabel As System.Windows.Forms.Label
        Dim MaintDateLabel As System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SpecimenIDTextBox = New System.Windows.Forms.TextBox()
        Me.SpeciesTextBox = New System.Windows.Forms.TextBox()
        Me.HatchDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.NextBreedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FeedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MaintDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnBreedingPrediction = New System.Windows.Forms.Button()
        Me.DatabaseLM1DataSet = New SnakeBreeding.DatabaseLM1DataSet()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table2TableAdapter = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.Table2TableAdapter()
        Me.TableAdapterManager = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.TableAdapterManager()
        Label1 = New System.Windows.Forms.Label()
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 94
        Label1.Text = "Specimen ID:"
        '
        'SpecimenIDLabel
        '
        SpecimenIDLabel.AutoSize = True
        SpecimenIDLabel.Location = New System.Drawing.Point(12, 44)
        SpecimenIDLabel.Name = "SpecimenIDLabel"
        SpecimenIDLabel.Size = New System.Drawing.Size(71, 13)
        SpecimenIDLabel.TabIndex = 75
        SpecimenIDLabel.Text = "Specimen ID:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Location = New System.Drawing.Point(12, 70)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(48, 13)
        SpeciesLabel.TabIndex = 77
        SpeciesLabel.Text = "Species:"
        '
        'HatchDateLabel
        '
        HatchDateLabel.AutoSize = True
        HatchDateLabel.Location = New System.Drawing.Point(12, 97)
        HatchDateLabel.Name = "HatchDateLabel"
        HatchDateLabel.Size = New System.Drawing.Size(65, 13)
        HatchDateLabel.TabIndex = 79
        HatchDateLabel.Text = "Hatch Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(12, 122)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 81
        SexLabel.Text = "Sex:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(12, 148)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 83
        WeightLabel.Text = "Weight:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(12, 174)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 85
        ColorLabel.Text = "Color:"
        '
        'NextBreedDateLabel
        '
        NextBreedDateLabel.AutoSize = True
        NextBreedDateLabel.Location = New System.Drawing.Point(12, 201)
        NextBreedDateLabel.Name = "NextBreedDateLabel"
        NextBreedDateLabel.Size = New System.Drawing.Size(89, 13)
        NextBreedDateLabel.TabIndex = 87
        NextBreedDateLabel.Text = "Next Breed Date:"
        '
        'FeedDateLabel
        '
        FeedDateLabel.AutoSize = True
        FeedDateLabel.Location = New System.Drawing.Point(12, 227)
        FeedDateLabel.Name = "FeedDateLabel"
        FeedDateLabel.Size = New System.Drawing.Size(60, 13)
        FeedDateLabel.TabIndex = 89
        FeedDateLabel.Text = "Feed Date:"
        '
        'MaintDateLabel
        '
        MaintDateLabel.AutoSize = True
        MaintDateLabel.Location = New System.Drawing.Point(12, 253)
        MaintDateLabel.Name = "MaintDateLabel"
        MaintDateLabel.Size = New System.Drawing.Size(62, 13)
        MaintDateLabel.TabIndex = 91
        MaintDateLabel.Text = "Maint Date:"
        '
        'txtSearch
        '
        Me.txtSearch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "SpecimenID", True))
        Me.txtSearch.Location = New System.Drawing.Point(107, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 93
        '
        'SpecimenIDTextBox
        '
        Me.SpecimenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "SpecimenID", True))
        Me.SpecimenIDTextBox.Location = New System.Drawing.Point(107, 41)
        Me.SpecimenIDTextBox.Name = "SpecimenIDTextBox"
        Me.SpecimenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpecimenIDTextBox.TabIndex = 76
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Species", True))
        Me.SpeciesTextBox.Location = New System.Drawing.Point(107, 67)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpeciesTextBox.TabIndex = 78
        '
        'HatchDateDateTimePicker
        '
        Me.HatchDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "HatchDate", True))
        Me.HatchDateDateTimePicker.Location = New System.Drawing.Point(107, 93)
        Me.HatchDateDateTimePicker.Name = "HatchDateDateTimePicker"
        Me.HatchDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HatchDateDateTimePicker.TabIndex = 80
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(107, 119)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SexTextBox.TabIndex = 82
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(107, 145)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 84
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(107, 171)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 86
        '
        'NextBreedDateDateTimePicker
        '
        Me.NextBreedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "NextBreedDate", True))
        Me.NextBreedDateDateTimePicker.Location = New System.Drawing.Point(107, 197)
        Me.NextBreedDateDateTimePicker.Name = "NextBreedDateDateTimePicker"
        Me.NextBreedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.NextBreedDateDateTimePicker.TabIndex = 88
        '
        'FeedDateDateTimePicker
        '
        Me.FeedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "FeedDate", True))
        Me.FeedDateDateTimePicker.Location = New System.Drawing.Point(107, 223)
        Me.FeedDateDateTimePicker.Name = "FeedDateDateTimePicker"
        Me.FeedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FeedDateDateTimePicker.TabIndex = 90
        '
        'MaintDateDateTimePicker
        '
        Me.MaintDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table2BindingSource, "MaintDate", True))
        Me.MaintDateDateTimePicker.Location = New System.Drawing.Point(107, 249)
        Me.MaintDateDateTimePicker.Name = "MaintDateDateTimePicker"
        Me.MaintDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MaintDateDateTimePicker.TabIndex = 92
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(132, 304)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 74
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(188, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 73
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(82, 333)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 72
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnBreedingPrediction
        '
        Me.btnBreedingPrediction.Location = New System.Drawing.Point(107, 275)
        Me.btnBreedingPrediction.Name = "btnBreedingPrediction"
        Me.btnBreedingPrediction.Size = New System.Drawing.Size(125, 23)
        Me.btnBreedingPrediction.TabIndex = 71
        Me.btnBreedingPrediction.Text = "&Breeding Prediction"
        Me.btnBreedingPrediction.UseVisualStyleBackColor = True
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
        'frmViewSpecimenOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 381)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtSearch)
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
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnBreedingPrediction)
        Me.Name = "frmViewSpecimenOwner"
        Me.Text = "frmViewSpecimenOwner"
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents SpecimenIDTextBox As TextBox
    Friend WithEvents SpeciesTextBox As TextBox
    Friend WithEvents HatchDateDateTimePicker As DateTimePicker
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents NextBreedDateDateTimePicker As DateTimePicker
    Friend WithEvents FeedDateDateTimePicker As DateTimePicker
    Friend WithEvents MaintDateDateTimePicker As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnBreedingPrediction As Button
    Friend WithEvents DatabaseLM1DataSet As DatabaseLM1DataSet
    Friend WithEvents Table2BindingSource As BindingSource
    Friend WithEvents Table2TableAdapter As DatabaseLM1DataSetTableAdapters.Table2TableAdapter
    Friend WithEvents TableAdapterManager As DatabaseLM1DataSetTableAdapters.TableAdapterManager
End Class
