<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewSpecimenEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim Label1 As System.Windows.Forms.Label
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
        SpecimenIDLabel = New System.Windows.Forms.Label()
        SpeciesLabel = New System.Windows.Forms.Label()
        HatchDateLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        NextBreedDateLabel = New System.Windows.Forms.Label()
        FeedDateLabel = New System.Windows.Forms.Label()
        MaintDateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpecimenIDLabel
        '
        SpecimenIDLabel.AutoSize = True
        SpecimenIDLabel.Location = New System.Drawing.Point(16, 50)
        SpecimenIDLabel.Name = "SpecimenIDLabel"
        SpecimenIDLabel.Size = New System.Drawing.Size(71, 13)
        SpecimenIDLabel.TabIndex = 51
        SpecimenIDLabel.Text = "Specimen ID:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Location = New System.Drawing.Point(16, 76)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(48, 13)
        SpeciesLabel.TabIndex = 53
        SpeciesLabel.Text = "Species:"
        '
        'HatchDateLabel
        '
        HatchDateLabel.AutoSize = True
        HatchDateLabel.Location = New System.Drawing.Point(16, 103)
        HatchDateLabel.Name = "HatchDateLabel"
        HatchDateLabel.Size = New System.Drawing.Size(65, 13)
        HatchDateLabel.TabIndex = 55
        HatchDateLabel.Text = "Hatch Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(16, 128)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 57
        SexLabel.Text = "Sex:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(16, 154)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 59
        WeightLabel.Text = "Weight:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(16, 180)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 61
        ColorLabel.Text = "Color:"
        '
        'NextBreedDateLabel
        '
        NextBreedDateLabel.AutoSize = True
        NextBreedDateLabel.Location = New System.Drawing.Point(16, 207)
        NextBreedDateLabel.Name = "NextBreedDateLabel"
        NextBreedDateLabel.Size = New System.Drawing.Size(89, 13)
        NextBreedDateLabel.TabIndex = 63
        NextBreedDateLabel.Text = "Next Breed Date:"
        '
        'FeedDateLabel
        '
        FeedDateLabel.AutoSize = True
        FeedDateLabel.Location = New System.Drawing.Point(16, 233)
        FeedDateLabel.Name = "FeedDateLabel"
        FeedDateLabel.Size = New System.Drawing.Size(60, 13)
        FeedDateLabel.TabIndex = 65
        FeedDateLabel.Text = "Feed Date:"
        '
        'MaintDateLabel
        '
        MaintDateLabel.AutoSize = True
        MaintDateLabel.Location = New System.Drawing.Point(16, 259)
        MaintDateLabel.Name = "MaintDateLabel"
        MaintDateLabel.Size = New System.Drawing.Size(62, 13)
        MaintDateLabel.TabIndex = 67
        MaintDateLabel.Text = "Maint Date:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(111, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 69
        '
        'SpecimenIDTextBox
        '
        Me.SpecimenIDTextBox.Location = New System.Drawing.Point(111, 47)
        Me.SpecimenIDTextBox.Name = "SpecimenIDTextBox"
        Me.SpecimenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpecimenIDTextBox.TabIndex = 52
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.Location = New System.Drawing.Point(111, 73)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpeciesTextBox.TabIndex = 54
        '
        'HatchDateDateTimePicker
        '
        Me.HatchDateDateTimePicker.Location = New System.Drawing.Point(111, 99)
        Me.HatchDateDateTimePicker.Name = "HatchDateDateTimePicker"
        Me.HatchDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HatchDateDateTimePicker.TabIndex = 56
        '
        'SexTextBox
        '
        Me.SexTextBox.Location = New System.Drawing.Point(111, 125)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SexTextBox.TabIndex = 58
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(111, 151)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 60
        '
        'ColorTextBox
        '
        Me.ColorTextBox.Location = New System.Drawing.Point(111, 177)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 62
        '
        'NextBreedDateDateTimePicker
        '
        Me.NextBreedDateDateTimePicker.Location = New System.Drawing.Point(111, 203)
        Me.NextBreedDateDateTimePicker.Name = "NextBreedDateDateTimePicker"
        Me.NextBreedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.NextBreedDateDateTimePicker.TabIndex = 64
        '
        'FeedDateDateTimePicker
        '
        Me.FeedDateDateTimePicker.Location = New System.Drawing.Point(111, 229)
        Me.FeedDateDateTimePicker.Name = "FeedDateDateTimePicker"
        Me.FeedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FeedDateDateTimePicker.TabIndex = 66
        '
        'MaintDateDateTimePicker
        '
        Me.MaintDateDateTimePicker.Location = New System.Drawing.Point(111, 255)
        Me.MaintDateDateTimePicker.Name = "MaintDateDateTimePicker"
        Me.MaintDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MaintDateDateTimePicker.TabIndex = 68
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(136, 310)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 50
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(192, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 49
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(86, 339)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 48
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnBreedingPrediction
        '
        Me.btnBreedingPrediction.Location = New System.Drawing.Point(111, 281)
        Me.btnBreedingPrediction.Name = "btnBreedingPrediction"
        Me.btnBreedingPrediction.Size = New System.Drawing.Size(125, 23)
        Me.btnBreedingPrediction.TabIndex = 46
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 70
        Label1.Text = "Specimen ID:"
        '
        'frmViewSpecimenEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 373)
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
        Me.Name = "frmViewSpecimenEmployee"
        Me.Text = "frmViewSpecimenEmployee"
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
