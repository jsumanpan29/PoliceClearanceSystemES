<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Validation_ForceValidation
    Inherits MaterialSkin2Framework.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        CrimeID = New DataGridViewTextBoxColumn()
        CrimeCheckBox = New DataGridViewCheckBoxColumn()
        CrimeFname = New DataGridViewTextBoxColumn()
        CrimeMname = New DataGridViewTextBoxColumn()
        CrimeLname = New DataGridViewTextBoxColumn()
        CrimeOffense = New DataGridViewTextBoxColumn()
        CrimeCCNO = New DataGridViewTextBoxColumn()
        CrimeISNO = New DataGridViewTextBoxColumn()
        CrimeRemarks = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label3 = New Label()
        lblNumberRecords = New Label()
        chkRemarks = New CheckBox()
        RichTextBox1 = New RichTextBox()
        chkCriminalRecord = New CheckBox()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin2Framework.Controls.MaterialButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CrimeID, CrimeCheckBox, CrimeFname, CrimeMname, CrimeLname, CrimeOffense, CrimeCCNO, CrimeISNO, CrimeRemarks})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(10, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(789, 213)
        DataGridView1.TabIndex = 0
        ' 
        ' CrimeID
        ' 
        CrimeID.HeaderText = "Column1"
        CrimeID.Name = "CrimeID"
        CrimeID.Visible = False
        ' 
        ' CrimeCheckBox
        ' 
        CrimeCheckBox.HeaderText = ""
        CrimeCheckBox.Name = "CrimeCheckBox"
        CrimeCheckBox.Width = 30
        ' 
        ' CrimeFname
        ' 
        CrimeFname.HeaderText = "  First Name"
        CrimeFname.Name = "CrimeFname"
        ' 
        ' CrimeMname
        ' 
        CrimeMname.HeaderText = "Middle Name"
        CrimeMname.Name = "CrimeMname"
        ' 
        ' CrimeLname
        ' 
        CrimeLname.HeaderText = "   Last Name"
        CrimeLname.Name = "CrimeLname"
        ' 
        ' CrimeOffense
        ' 
        CrimeOffense.HeaderText = " Crime Offense"
        CrimeOffense.Name = "CrimeOffense"
        ' 
        ' CrimeCCNO
        ' 
        CrimeCCNO.HeaderText = "  CC NO."
        CrimeCCNO.Name = "CrimeCCNO"
        ' 
        ' CrimeISNO
        ' 
        CrimeISNO.HeaderText = "  IS NO."
        CrimeISNO.Name = "CrimeISNO"
        ' 
        ' CrimeRemarks
        ' 
        CrimeRemarks.HeaderText = "  Remarks"
        CrimeRemarks.Name = "CrimeRemarks"
        CrimeRemarks.Width = 116
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(63), CByte(83), CByte(181))
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(274, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 30)
        Label1.TabIndex = 52
        Label1.Text = "Record Found in Database"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 17)
        Label3.TabIndex = 58
        Label3.Text = "Records Matched:"
        ' 
        ' lblNumberRecords
        ' 
        lblNumberRecords.AutoSize = True
        lblNumberRecords.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNumberRecords.Location = New Point(118, 96)
        lblNumberRecords.Name = "lblNumberRecords"
        lblNumberRecords.Size = New Size(15, 17)
        lblNumberRecords.TabIndex = 59
        lblNumberRecords.Text = "0"
        ' 
        ' chkRemarks
        ' 
        chkRemarks.AutoSize = True
        chkRemarks.Checked = True
        chkRemarks.CheckState = CheckState.Checked
        chkRemarks.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        chkRemarks.Location = New Point(10, 332)
        chkRemarks.Name = "chkRemarks"
        chkRemarks.Size = New Size(105, 21)
        chkRemarks.TabIndex = 60
        chkRemarks.Text = "Add Remarks"
        chkRemarks.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(12, 356)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(729, 48)
        RichTextBox1.TabIndex = 61
        RichTextBox1.Text = ""
        ' 
        ' chkCriminalRecord
        ' 
        chkCriminalRecord.AutoSize = True
        chkCriminalRecord.Checked = True
        chkCriminalRecord.CheckState = CheckState.Checked
        chkCriminalRecord.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        chkCriminalRecord.Location = New Point(12, 72)
        chkCriminalRecord.Name = "chkCriminalRecord"
        chkCriminalRecord.Size = New Size(142, 21)
        chkCriminalRecord.TabIndex = 62
        chkCriminalRecord.Text = "Set Criminal Record"
        chkCriminalRecord.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        MaterialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialButton1.ForeColor = SystemColors.ControlText
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(747, 356)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MaximumSize = New Size(54, 48)
        MaterialButton1.MinimumSize = New Size(54, 48)
        MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(54, 48)
        MaterialButton1.TabIndex = 64
        MaterialButton1.Text = "Clear"
        MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        MaterialButton2.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(382, 412)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MaximumSize = New Size(75, 26)
        MaterialButton2.MinimumSize = New Size(75, 26)
        MaterialButton2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(75, 26)
        MaterialButton2.TabIndex = 65
        MaterialButton2.Text = "Confirm"
        MaterialButton2.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' Validation_ForceValidation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(816, 449)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(chkCriminalRecord)
        Controls.Add(RichTextBox1)
        Controls.Add(chkRemarks)
        Controls.Add(lblNumberRecords)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Validation_ForceValidation"
        StartPosition = FormStartPosition.CenterScreen
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumberRecords As Label
    Friend WithEvents chkRemarks As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents chkCriminalRecord As CheckBox
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents CrimeID As DataGridViewTextBoxColumn
    Friend WithEvents CrimeCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents CrimeFname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeMname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeLname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeOffense As DataGridViewTextBoxColumn
    Friend WithEvents CrimeCCNO As DataGridViewTextBoxColumn
    Friend WithEvents CrimeISNO As DataGridViewTextBoxColumn
    Friend WithEvents CrimeRemarks As DataGridViewTextBoxColumn
End Class
