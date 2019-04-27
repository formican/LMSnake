<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreedingPredictionEmployee
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
        Me.txtProbabilities = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSpecimen2 = New System.Windows.Forms.TextBox()
        Me.txtSpecimen1 = New System.Windows.Forms.TextBox()
        Me.lblSpecimenTwo = New System.Windows.Forms.Label()
        Me.lblSpecimenOne = New System.Windows.Forms.Label()
        Me.DatabaseLM1DataSet = New SnakeBreeding.DatabaseLM1DataSet()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table2TableAdapter = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.Table2TableAdapter()
        Me.TableAdapterManager = New SnakeBreeding.DatabaseLM1DataSetTableAdapters.TableAdapterManager()
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProbabilities
        '
        Me.txtProbabilities.Location = New System.Drawing.Point(137, 104)
        Me.txtProbabilities.Multiline = True
        Me.txtProbabilities.Name = "txtProbabilities"
        Me.txtProbabilities.Size = New System.Drawing.Size(128, 90)
        Me.txtProbabilities.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Generate Morph Probabilities"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSpecimen2
        '
        Me.txtSpecimen2.Location = New System.Drawing.Point(169, 24)
        Me.txtSpecimen2.Name = "txtSpecimen2"
        Me.txtSpecimen2.Size = New System.Drawing.Size(100, 20)
        Me.txtSpecimen2.TabIndex = 9
        '
        'txtSpecimen1
        '
        Me.txtSpecimen1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "SpecimenID", True))
        Me.txtSpecimen1.Location = New System.Drawing.Point(169, 60)
        Me.txtSpecimen1.Name = "txtSpecimen1"
        Me.txtSpecimen1.Size = New System.Drawing.Size(100, 20)
        Me.txtSpecimen1.TabIndex = 8
        '
        'lblSpecimenTwo
        '
        Me.lblSpecimenTwo.AutoSize = True
        Me.lblSpecimenTwo.Location = New System.Drawing.Point(10, 63)
        Me.lblSpecimenTwo.Name = "lblSpecimenTwo"
        Me.lblSpecimenTwo.Size = New System.Drawing.Size(149, 13)
        Me.lblSpecimenTwo.TabIndex = 7
        Me.lblSpecimenTwo.Text = "Enter the second specimen #:"
        '
        'lblSpecimenOne
        '
        Me.lblSpecimenOne.AutoSize = True
        Me.lblSpecimenOne.Location = New System.Drawing.Point(29, 27)
        Me.lblSpecimenOne.Name = "lblSpecimenOne"
        Me.lblSpecimenOne.Size = New System.Drawing.Size(130, 13)
        Me.lblSpecimenOne.TabIndex = 6
        Me.lblSpecimenOne.Text = "Enter the first specimen #:"
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
        'frmBreedingPredictionEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 207)
        Me.Controls.Add(Me.txtProbabilities)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSpecimen2)
        Me.Controls.Add(Me.txtSpecimen1)
        Me.Controls.Add(Me.lblSpecimenTwo)
        Me.Controls.Add(Me.lblSpecimenOne)
        Me.Name = "frmBreedingPredictionEmployee"
        Me.Text = "frmBreedingPrediction"
        CType(Me.DatabaseLM1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProbabilities As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSpecimen2 As TextBox
    Friend WithEvents txtSpecimen1 As TextBox
    Friend WithEvents lblSpecimenTwo As Label
    Friend WithEvents lblSpecimenOne As Label
    Friend WithEvents DatabaseLM1DataSet As DatabaseLM1DataSet
    Friend WithEvents Table2BindingSource As BindingSource
    Friend WithEvents Table2TableAdapter As DatabaseLM1DataSetTableAdapters.Table2TableAdapter
    Friend WithEvents TableAdapterManager As DatabaseLM1DataSetTableAdapters.TableAdapterManager
End Class
