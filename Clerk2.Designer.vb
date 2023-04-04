<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clerk2
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
        Me.btnClear_Cancel = New System.Windows.Forms.Button()
        Me.btnAdd_Save = New System.Windows.Forms.Button()
        Me.cbPoliceCertify = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbPoliceVerify = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSignature = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnThumbmark = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtORAmount = New System.Windows.Forms.TextBox()
        Me.txtORNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtClearanceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCTCIssueAt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtCTCIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCTCNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbPurpose = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbBarangay = New System.Windows.Forms.ComboBox()
        Me.cbZone = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClearanceMname = New System.Windows.Forms.TextBox()
        Me.txtClearanceFname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtClearanceLname = New System.Windows.Forms.TextBox()
        Me.txtClearanceNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkbValidated = New System.Windows.Forms.CheckBox()
        Me.chkbPaid = New System.Windows.Forms.CheckBox()
        Me.chkbPending = New System.Windows.Forms.CheckBox()
        Me.chkbAll = New System.Windows.Forms.CheckBox()
        Me.btnApplicantPendingSearchCancel = New System.Windows.Forms.Button()
        Me.txtApplicantPendingSearch = New System.Windows.Forms.TextBox()
        Me.dataApplicantPending = New System.Windows.Forms.DataGridView()
        Me.dataPendingClearanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPendingClearanceEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataPendingClearanceSetBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataPendingClearanceDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dataApplicantCompleted = New System.Windows.Forms.DataGridView()
        Me.dataCompletedClearanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearanceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCompletedClearancePrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnApplicantCompletedSearchCancel = New System.Windows.Forms.Button()
        Me.txtApplicantCompletedSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dataApplicantPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataApplicantCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear_Cancel
        '
        Me.btnClear_Cancel.Location = New System.Drawing.Point(159, 553)
        Me.btnClear_Cancel.Name = "btnClear_Cancel"
        Me.btnClear_Cancel.Size = New System.Drawing.Size(132, 23)
        Me.btnClear_Cancel.TabIndex = 135
        Me.btnClear_Cancel.Text = "Clear"
        Me.btnClear_Cancel.UseVisualStyleBackColor = True
        '
        'btnAdd_Save
        '
        Me.btnAdd_Save.Location = New System.Drawing.Point(17, 553)
        Me.btnAdd_Save.Name = "btnAdd_Save"
        Me.btnAdd_Save.Size = New System.Drawing.Size(132, 23)
        Me.btnAdd_Save.TabIndex = 134
        Me.btnAdd_Save.Text = "Add"
        Me.btnAdd_Save.UseVisualStyleBackColor = True
        '
        'cbPoliceCertify
        '
        Me.cbPoliceCertify.FormattingEnabled = True
        Me.cbPoliceCertify.Location = New System.Drawing.Point(17, 514)
        Me.cbPoliceCertify.Name = "cbPoliceCertify"
        Me.cbPoliceCertify.Size = New System.Drawing.Size(471, 23)
        Me.cbPoliceCertify.TabIndex = 139
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 496)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "Certified By"
        '
        'cbPoliceVerify
        '
        Me.cbPoliceVerify.FormattingEnabled = True
        Me.cbPoliceVerify.Location = New System.Drawing.Point(17, 465)
        Me.cbPoliceVerify.Name = "cbPoliceVerify"
        Me.cbPoliceVerify.Size = New System.Drawing.Size(471, 23)
        Me.cbPoliceVerify.TabIndex = 137
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 449)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 15)
        Me.Label21.TabIndex = 136
        Me.Label21.Text = "Verified By"
        '
        'btnSignature
        '
        Me.btnSignature.Location = New System.Drawing.Point(569, 612)
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(75, 23)
        Me.btnSignature.TabIndex = 133
        Me.btnSignature.Text = "Upload"
        Me.btnSignature.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(576, 438)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 15)
        Me.Label20.TabIndex = 132
        Me.Label20.Text = "Signature"
        '
        'btnThumbmark
        '
        Me.btnThumbmark.Location = New System.Drawing.Point(569, 405)
        Me.btnThumbmark.Name = "btnThumbmark"
        Me.btnThumbmark.Size = New System.Drawing.Size(75, 23)
        Me.btnThumbmark.TabIndex = 130
        Me.btnThumbmark.Text = "Upload"
        Me.btnThumbmark.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(561, 231)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 15)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "R. Thumbmark"
        '
        'btnCamera
        '
        Me.btnCamera.Location = New System.Drawing.Point(569, 201)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(75, 23)
        Me.btnCamera.TabIndex = 127
        Me.btnCamera.Text = "Upload"
        Me.btnCamera.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(581, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 15)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Camera"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(258, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 15)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Amount"
        '
        'txtORAmount
        '
        Me.txtORAmount.Location = New System.Drawing.Point(258, 363)
        Me.txtORAmount.Name = "txtORAmount"
        Me.txtORAmount.Size = New System.Drawing.Size(230, 23)
        Me.txtORAmount.TabIndex = 124
        '
        'txtORNo
        '
        Me.txtORNo.Location = New System.Drawing.Point(258, 316)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Size = New System.Drawing.Size(230, 23)
        Me.txtORNo.TabIndex = 123
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(258, 298)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 15)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "OR Number"
        '
        'dtClearanceDate
        '
        Me.dtClearanceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtClearanceDate.Location = New System.Drawing.Point(389, 30)
        Me.dtClearanceDate.Name = "dtClearanceDate"
        Me.dtClearanceDate.Size = New System.Drawing.Size(99, 23)
        Me.dtClearanceDate.TabIndex = 121
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(349, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Date:"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(335, 219)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(153, 23)
        Me.txtContactNo.TabIndex = 118
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(335, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 15)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Contact Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 392)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Issued At"
        '
        'txtCTCIssueAt
        '
        Me.txtCTCIssueAt.Location = New System.Drawing.Point(17, 410)
        Me.txtCTCIssueAt.Name = "txtCTCIssueAt"
        Me.txtCTCIssueAt.Size = New System.Drawing.Size(230, 23)
        Me.txtCTCIssueAt.TabIndex = 115
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Issued On"
        '
        'dtCTCIssueDate
        '
        Me.dtCTCIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCTCIssueDate.Location = New System.Drawing.Point(17, 363)
        Me.dtCTCIssueDate.Name = "dtCTCIssueDate"
        Me.dtCTCIssueDate.Size = New System.Drawing.Size(230, 23)
        Me.dtCTCIssueDate.TabIndex = 113
        '
        'txtCTCNo
        '
        Me.txtCTCNo.Location = New System.Drawing.Point(17, 319)
        Me.txtCTCNo.Name = "txtCTCNo"
        Me.txtCTCNo.Size = New System.Drawing.Size(230, 23)
        Me.txtCTCNo.TabIndex = 112
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 15)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "CTC Number"
        '
        'cbPurpose
        '
        Me.cbPurpose.FormattingEnabled = True
        Me.cbPurpose.Location = New System.Drawing.Point(17, 269)
        Me.cbPurpose.Name = "cbPurpose"
        Me.cbPurpose.Size = New System.Drawing.Size(471, 23)
        Me.cbPurpose.TabIndex = 110
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Purpose"
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(224, 219)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(105, 23)
        Me.txtNationality.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Nationality"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(140, 219)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(78, 23)
        Me.txtHeight.TabIndex = 106
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(74, 221)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 19)
        Me.rbFemale.TabIndex = 105
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(17, 221)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(51, 19)
        Me.rbMale.TabIndex = 104
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Height(ft)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 15)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Date of Birth"
        '
        'dtBirthDate
        '
        Me.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthDate.Location = New System.Drawing.Point(335, 177)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(153, 23)
        Me.dtBirthDate.TabIndex = 100
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Location = New System.Drawing.Point(17, 177)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(274, 23)
        Me.txtBirthPlace.TabIndex = 99
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Place of Birth"
        '
        'cbCivilStatus
        '
        Me.cbCivilStatus.FormattingEnabled = True
        Me.cbCivilStatus.Location = New System.Drawing.Point(335, 133)
        Me.cbCivilStatus.Name = "cbCivilStatus"
        Me.cbCivilStatus.Size = New System.Drawing.Size(153, 23)
        Me.cbCivilStatus.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Civil Status"
        '
        'cbBarangay
        '
        Me.cbBarangay.FormattingEnabled = True
        Me.cbBarangay.Location = New System.Drawing.Point(88, 133)
        Me.cbBarangay.Name = "cbBarangay"
        Me.cbBarangay.Size = New System.Drawing.Size(203, 23)
        Me.cbBarangay.TabIndex = 95
        '
        'cbZone
        '
        Me.cbZone.FormattingEnabled = True
        Me.cbZone.Location = New System.Drawing.Point(17, 133)
        Me.cbZone.Name = "cbZone"
        Me.cbZone.Size = New System.Drawing.Size(68, 23)
        Me.cbZone.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Address(Zone, Barangay)"
        '
        'txtClearanceMname
        '
        Me.txtClearanceMname.Location = New System.Drawing.Point(335, 84)
        Me.txtClearanceMname.Name = "txtClearanceMname"
        Me.txtClearanceMname.Size = New System.Drawing.Size(153, 23)
        Me.txtClearanceMname.TabIndex = 92
        '
        'txtClearanceFname
        '
        Me.txtClearanceFname.Location = New System.Drawing.Point(176, 84)
        Me.txtClearanceFname.Name = "txtClearanceFname"
        Me.txtClearanceFname.Size = New System.Drawing.Size(153, 23)
        Me.txtClearanceFname.TabIndex = 91
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(262, 15)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Full Name(Last name, First name, Middle Name)"
        '
        'txtClearanceLname
        '
        Me.txtClearanceLname.Location = New System.Drawing.Point(17, 84)
        Me.txtClearanceLname.Name = "txtClearanceLname"
        Me.txtClearanceLname.Size = New System.Drawing.Size(153, 23)
        Me.txtClearanceLname.TabIndex = 89
        '
        'txtClearanceNo
        '
        Me.txtClearanceNo.Location = New System.Drawing.Point(104, 27)
        Me.txtClearanceNo.Name = "txtClearanceNo"
        Me.txtClearanceNo.Size = New System.Drawing.Size(77, 23)
        Me.txtClearanceNo.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Clearance No."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(710, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(788, 617)
        Me.TabControl1.TabIndex = 140
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkbValidated)
        Me.TabPage1.Controls.Add(Me.chkbPaid)
        Me.TabPage1.Controls.Add(Me.chkbPending)
        Me.TabPage1.Controls.Add(Me.chkbAll)
        Me.TabPage1.Controls.Add(Me.btnApplicantPendingSearchCancel)
        Me.TabPage1.Controls.Add(Me.txtApplicantPendingSearch)
        Me.TabPage1.Controls.Add(Me.dataApplicantPending)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(780, 589)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pending"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkbValidated
        '
        Me.chkbValidated.AutoSize = True
        Me.chkbValidated.Location = New System.Drawing.Point(183, 9)
        Me.chkbValidated.Name = "chkbValidated"
        Me.chkbValidated.Size = New System.Drawing.Size(74, 19)
        Me.chkbValidated.TabIndex = 148
        Me.chkbValidated.Text = "Validated"
        Me.chkbValidated.UseVisualStyleBackColor = True
        '
        'chkbPaid
        '
        Me.chkbPaid.AutoSize = True
        Me.chkbPaid.Location = New System.Drawing.Point(128, 9)
        Me.chkbPaid.Name = "chkbPaid"
        Me.chkbPaid.Size = New System.Drawing.Size(49, 19)
        Me.chkbPaid.TabIndex = 147
        Me.chkbPaid.Text = "Paid"
        Me.chkbPaid.UseVisualStyleBackColor = True
        '
        'chkbPending
        '
        Me.chkbPending.AutoSize = True
        Me.chkbPending.Location = New System.Drawing.Point(52, 9)
        Me.chkbPending.Name = "chkbPending"
        Me.chkbPending.Size = New System.Drawing.Size(70, 19)
        Me.chkbPending.TabIndex = 146
        Me.chkbPending.Text = "Pending"
        Me.chkbPending.UseVisualStyleBackColor = True
        '
        'chkbAll
        '
        Me.chkbAll.AutoSize = True
        Me.chkbAll.Location = New System.Drawing.Point(6, 9)
        Me.chkbAll.Name = "chkbAll"
        Me.chkbAll.Size = New System.Drawing.Size(40, 19)
        Me.chkbAll.TabIndex = 145
        Me.chkbAll.Text = "All"
        Me.chkbAll.UseVisualStyleBackColor = True
        '
        'btnApplicantPendingSearchCancel
        '
        Me.btnApplicantPendingSearchCancel.Location = New System.Drawing.Point(702, 6)
        Me.btnApplicantPendingSearchCancel.Name = "btnApplicantPendingSearchCancel"
        Me.btnApplicantPendingSearchCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantPendingSearchCancel.TabIndex = 144
        Me.btnApplicantPendingSearchCancel.Text = "x"
        Me.btnApplicantPendingSearchCancel.UseVisualStyleBackColor = True
        '
        'txtApplicantPendingSearch
        '
        Me.txtApplicantPendingSearch.Location = New System.Drawing.Point(447, 6)
        Me.txtApplicantPendingSearch.Name = "txtApplicantPendingSearch"
        Me.txtApplicantPendingSearch.Size = New System.Drawing.Size(249, 23)
        Me.txtApplicantPendingSearch.TabIndex = 143
        '
        'dataApplicantPending
        '
        Me.dataApplicantPending.AllowUserToAddRows = False
        Me.dataApplicantPending.AllowUserToDeleteRows = False
        Me.dataApplicantPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicantPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataPendingClearanceID, Me.dataPendingClearanceNo, Me.dataPendingClearanceFname, Me.dataPendingClearanceMname, Me.dataPendingClearanceLname, Me.dataPendingClearanceStatus, Me.dataPendingClearanceEdit, Me.dataPendingClearanceSetBtn, Me.dataPendingClearanceDelete})
        Me.dataApplicantPending.Location = New System.Drawing.Point(4, 35)
        Me.dataApplicantPending.Name = "dataApplicantPending"
        Me.dataApplicantPending.ReadOnly = True
        Me.dataApplicantPending.RowTemplate.Height = 25
        Me.dataApplicantPending.Size = New System.Drawing.Size(773, 514)
        Me.dataApplicantPending.TabIndex = 142
        '
        'dataPendingClearanceID
        '
        Me.dataPendingClearanceID.HeaderText = "ClearanceID"
        Me.dataPendingClearanceID.Name = "dataPendingClearanceID"
        Me.dataPendingClearanceID.ReadOnly = True
        '
        'dataPendingClearanceNo
        '
        Me.dataPendingClearanceNo.HeaderText = "Clearance Number"
        Me.dataPendingClearanceNo.Name = "dataPendingClearanceNo"
        Me.dataPendingClearanceNo.ReadOnly = True
        '
        'dataPendingClearanceFname
        '
        Me.dataPendingClearanceFname.HeaderText = "First Name"
        Me.dataPendingClearanceFname.Name = "dataPendingClearanceFname"
        Me.dataPendingClearanceFname.ReadOnly = True
        '
        'dataPendingClearanceMname
        '
        Me.dataPendingClearanceMname.HeaderText = "Middle Name"
        Me.dataPendingClearanceMname.Name = "dataPendingClearanceMname"
        Me.dataPendingClearanceMname.ReadOnly = True
        '
        'dataPendingClearanceLname
        '
        Me.dataPendingClearanceLname.HeaderText = "Last Name"
        Me.dataPendingClearanceLname.Name = "dataPendingClearanceLname"
        Me.dataPendingClearanceLname.ReadOnly = True
        '
        'dataPendingClearanceStatus
        '
        Me.dataPendingClearanceStatus.HeaderText = "Status"
        Me.dataPendingClearanceStatus.Name = "dataPendingClearanceStatus"
        Me.dataPendingClearanceStatus.ReadOnly = True
        '
        'dataPendingClearanceEdit
        '
        Me.dataPendingClearanceEdit.HeaderText = ""
        Me.dataPendingClearanceEdit.Name = "dataPendingClearanceEdit"
        Me.dataPendingClearanceEdit.ReadOnly = True
        Me.dataPendingClearanceEdit.Text = "Edit"
        Me.dataPendingClearanceEdit.UseColumnTextForButtonValue = True
        '
        'dataPendingClearanceSetBtn
        '
        Me.dataPendingClearanceSetBtn.HeaderText = ""
        Me.dataPendingClearanceSetBtn.Name = "dataPendingClearanceSetBtn"
        Me.dataPendingClearanceSetBtn.ReadOnly = True
        Me.dataPendingClearanceSetBtn.Text = ""
        '
        'dataPendingClearanceDelete
        '
        Me.dataPendingClearanceDelete.HeaderText = ""
        Me.dataPendingClearanceDelete.Name = "dataPendingClearanceDelete"
        Me.dataPendingClearanceDelete.ReadOnly = True
        Me.dataPendingClearanceDelete.Text = "Delete"
        Me.dataPendingClearanceDelete.UseColumnTextForButtonValue = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dataApplicantCompleted)
        Me.TabPage2.Controls.Add(Me.btnApplicantCompletedSearchCancel)
        Me.TabPage2.Controls.Add(Me.txtApplicantCompletedSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(780, 589)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Completed"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dataApplicantCompleted
        '
        Me.dataApplicantCompleted.AllowUserToAddRows = False
        Me.dataApplicantCompleted.AllowUserToDeleteRows = False
        Me.dataApplicantCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicantCompleted.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataCompletedClearanceID, Me.dataCompletedClearanceNo, Me.dataCompletedClearanceFname, Me.dataCompletedClearanceMname, Me.dataCompletedClearanceLname, Me.dataCompletedClearanceStatus, Me.dataCompletedClearancePrint})
        Me.dataApplicantCompleted.Location = New System.Drawing.Point(4, 37)
        Me.dataApplicantCompleted.Name = "dataApplicantCompleted"
        Me.dataApplicantCompleted.ReadOnly = True
        Me.dataApplicantCompleted.RowTemplate.Height = 25
        Me.dataApplicantCompleted.Size = New System.Drawing.Size(773, 514)
        Me.dataApplicantCompleted.TabIndex = 150
        '
        'dataCompletedClearanceID
        '
        Me.dataCompletedClearanceID.HeaderText = "ClearanceID"
        Me.dataCompletedClearanceID.Name = "dataCompletedClearanceID"
        Me.dataCompletedClearanceID.ReadOnly = True
        '
        'dataCompletedClearanceNo
        '
        Me.dataCompletedClearanceNo.HeaderText = "Clearance Number"
        Me.dataCompletedClearanceNo.Name = "dataCompletedClearanceNo"
        Me.dataCompletedClearanceNo.ReadOnly = True
        '
        'dataCompletedClearanceFname
        '
        Me.dataCompletedClearanceFname.HeaderText = "First Name"
        Me.dataCompletedClearanceFname.Name = "dataCompletedClearanceFname"
        Me.dataCompletedClearanceFname.ReadOnly = True
        '
        'dataCompletedClearanceMname
        '
        Me.dataCompletedClearanceMname.HeaderText = "Middle Name"
        Me.dataCompletedClearanceMname.Name = "dataCompletedClearanceMname"
        Me.dataCompletedClearanceMname.ReadOnly = True
        '
        'dataCompletedClearanceLname
        '
        Me.dataCompletedClearanceLname.HeaderText = "Last Name"
        Me.dataCompletedClearanceLname.Name = "dataCompletedClearanceLname"
        Me.dataCompletedClearanceLname.ReadOnly = True
        '
        'dataCompletedClearanceStatus
        '
        Me.dataCompletedClearanceStatus.HeaderText = "Status"
        Me.dataCompletedClearanceStatus.Name = "dataCompletedClearanceStatus"
        Me.dataCompletedClearanceStatus.ReadOnly = True
        '
        'dataCompletedClearancePrint
        '
        Me.dataCompletedClearancePrint.HeaderText = ""
        Me.dataCompletedClearancePrint.Name = "dataCompletedClearancePrint"
        Me.dataCompletedClearancePrint.ReadOnly = True
        Me.dataCompletedClearancePrint.Text = "Print"
        Me.dataCompletedClearancePrint.UseColumnTextForButtonValue = True
        '
        'btnApplicantCompletedSearchCancel
        '
        Me.btnApplicantCompletedSearchCancel.Location = New System.Drawing.Point(702, 5)
        Me.btnApplicantCompletedSearchCancel.Name = "btnApplicantCompletedSearchCancel"
        Me.btnApplicantCompletedSearchCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantCompletedSearchCancel.TabIndex = 147
        Me.btnApplicantCompletedSearchCancel.Text = "x"
        Me.btnApplicantCompletedSearchCancel.UseVisualStyleBackColor = True
        '
        'txtApplicantCompletedSearch
        '
        Me.txtApplicantCompletedSearch.Location = New System.Drawing.Point(447, 5)
        Me.txtApplicantCompletedSearch.Name = "txtApplicantCompletedSearch"
        Me.txtApplicantCompletedSearch.Size = New System.Drawing.Size(249, 23)
        Me.txtApplicantCompletedSearch.TabIndex = 146
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1510, 24)
        Me.MenuStrip1.TabIndex = 141
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(530, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 142
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(530, 249)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 143
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(530, 456)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 144
        Me.PictureBox3.TabStop = False
        '
        'Clerk2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 679)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnClear_Cancel)
        Me.Controls.Add(Me.btnAdd_Save)
        Me.Controls.Add(Me.cbPoliceCertify)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbPoliceVerify)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnSignature)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnThumbmark)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtORAmount)
        Me.Controls.Add(Me.txtORNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtClearanceDate)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCTCIssueAt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtCTCIssueDate)
        Me.Controls.Add(Me.txtCTCNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbPurpose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtBirthDate)
        Me.Controls.Add(Me.txtBirthPlace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbCivilStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBarangay)
        Me.Controls.Add(Me.cbZone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClearanceMname)
        Me.Controls.Add(Me.txtClearanceFname)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtClearanceLname)
        Me.Controls.Add(Me.txtClearanceNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Clerk2"
        Me.Text = "Clerk"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dataApplicantPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataApplicantCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear_Cancel As Button
    Friend WithEvents btnAdd_Save As Button
    Friend WithEvents cbPoliceCertify As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbPoliceVerify As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnSignature As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents btnThumbmark As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents btnCamera As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtORAmount As TextBox
    Friend WithEvents txtORNo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtClearanceDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCTCIssueAt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtCTCIssueDate As DateTimePicker
    Friend WithEvents txtCTCNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbPurpose As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbBarangay As ComboBox
    Friend WithEvents cbZone As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClearanceMname As TextBox
    Friend WithEvents txtClearanceFname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtClearanceLname As TextBox
    Friend WithEvents txtClearanceNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnApplicantPendingSearchCancel As Button
    Friend WithEvents txtApplicantPendingSearch As TextBox
    Friend WithEvents dataApplicantPending As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnApplicantCompletedSearchCancel As Button
    Friend WithEvents txtApplicantCompletedSearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataApplicantCompleted As DataGridView
    Friend WithEvents chkbAll As CheckBox
    Friend WithEvents chkbPending As CheckBox
    Friend WithEvents chkbPaid As CheckBox
    Friend WithEvents chkbValidated As CheckBox
    Friend WithEvents dataPendingClearanceID As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceNo As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceFname As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceMname As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceLname As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceStatus As DataGridViewTextBoxColumn
    Friend WithEvents dataPendingClearanceEdit As DataGridViewButtonColumn
    Friend WithEvents dataPendingClearanceSetBtn As DataGridViewButtonColumn
    Friend WithEvents dataPendingClearanceDelete As DataGridViewButtonColumn
    Friend WithEvents dataCompletedClearanceID As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceNo As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceFname As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceMname As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceLname As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearanceStatus As DataGridViewTextBoxColumn
    Friend WithEvents dataCompletedClearancePrint As DataGridViewButtonColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
