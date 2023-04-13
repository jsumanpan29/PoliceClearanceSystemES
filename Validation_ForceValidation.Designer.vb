<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Validation_ForceValidation
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CrimeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CrimeFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeOffense = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeCCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeISNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrimeRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumberRecords = New System.Windows.Forms.Label()
        Me.chkRemarks = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.chkCriminalRecord = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CrimeID, Me.CrimeCheckBox, Me.CrimeFname, Me.CrimeMname, Me.CrimeLname, Me.CrimeOffense, Me.CrimeCCNO, Me.CrimeISNO, Me.CrimeRemarks})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(792, 213)
        Me.DataGridView1.TabIndex = 0
        '
        'CrimeID
        '
        Me.CrimeID.HeaderText = "Column1"
        Me.CrimeID.Name = "CrimeID"
        Me.CrimeID.Visible = False
        '
        'CrimeCheckBox
        '
        Me.CrimeCheckBox.HeaderText = ""
        Me.CrimeCheckBox.Name = "CrimeCheckBox"
        Me.CrimeCheckBox.Width = 30
        '
        'CrimeFname
        '
        Me.CrimeFname.HeaderText = "First Name"
        Me.CrimeFname.Name = "CrimeFname"
        Me.CrimeFname.ReadOnly = True
        '
        'CrimeMname
        '
        Me.CrimeMname.HeaderText = "Middle Name"
        Me.CrimeMname.Name = "CrimeMname"
        Me.CrimeMname.ReadOnly = True
        '
        'CrimeLname
        '
        Me.CrimeLname.HeaderText = "Last Name"
        Me.CrimeLname.Name = "CrimeLname"
        Me.CrimeLname.ReadOnly = True
        '
        'CrimeOffense
        '
        Me.CrimeOffense.HeaderText = "Crime Offense"
        Me.CrimeOffense.Name = "CrimeOffense"
        Me.CrimeOffense.ReadOnly = True
        '
        'CrimeCCNO
        '
        Me.CrimeCCNO.HeaderText = "CC NO."
        Me.CrimeCCNO.Name = "CrimeCCNO"
        Me.CrimeCCNO.ReadOnly = True
        '
        'CrimeISNO
        '
        Me.CrimeISNO.HeaderText = "IS NO."
        Me.CrimeISNO.Name = "CrimeISNO"
        Me.CrimeISNO.ReadOnly = True
        '
        'CrimeRemarks
        '
        Me.CrimeRemarks.HeaderText = "Remarks"
        Me.CrimeRemarks.Name = "CrimeRemarks"
        Me.CrimeRemarks.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(394, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 32)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "HIT!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Records Matched:"
        '
        'lblNumberRecords
        '
        Me.lblNumberRecords.AutoSize = True
        Me.lblNumberRecords.Location = New System.Drawing.Point(120, 80)
        Me.lblNumberRecords.Name = "lblNumberRecords"
        Me.lblNumberRecords.Size = New System.Drawing.Size(13, 15)
        Me.lblNumberRecords.TabIndex = 59
        Me.lblNumberRecords.Text = "0"
        '
        'chkRemarks
        '
        Me.chkRemarks.AutoSize = True
        Me.chkRemarks.Checked = True
        Me.chkRemarks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRemarks.Location = New System.Drawing.Point(12, 317)
        Me.chkRemarks.Name = "chkRemarks"
        Me.chkRemarks.Size = New System.Drawing.Size(96, 19)
        Me.chkRemarks.TabIndex = 60
        Me.chkRemarks.Text = "Add Remarks"
        Me.chkRemarks.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 342)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(732, 48)
        Me.RichTextBox1.TabIndex = 61
        Me.RichTextBox1.Text = ""
        '
        'chkCriminalRecord
        '
        Me.chkCriminalRecord.AutoSize = True
        Me.chkCriminalRecord.Checked = True
        Me.chkCriminalRecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCriminalRecord.Location = New System.Drawing.Point(12, 58)
        Me.chkCriminalRecord.Name = "chkCriminalRecord"
        Me.chkCriminalRecord.Size = New System.Drawing.Size(130, 19)
        Me.chkCriminalRecord.TabIndex = 62
        Me.chkCriminalRecord.Text = "Set Criminal Record"
        Me.chkCriminalRecord.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(750, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 48)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Validation_ForceValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 424)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkCriminalRecord)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.chkRemarks)
        Me.Controls.Add(Me.lblNumberRecords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Validation_ForceValidation"
        Me.Text = "Validation_Hit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumberRecords As Label
    Friend WithEvents chkRemarks As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents chkCriminalRecord As CheckBox
    Friend WithEvents CrimeID As DataGridViewTextBoxColumn
    Friend WithEvents CrimeCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents CrimeFname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeMname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeLname As DataGridViewTextBoxColumn
    Friend WithEvents CrimeOffense As DataGridViewTextBoxColumn
    Friend WithEvents CrimeCCNO As DataGridViewTextBoxColumn
    Friend WithEvents CrimeISNO As DataGridViewTextBoxColumn
    Friend WithEvents CrimeRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
