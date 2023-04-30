<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clerk2
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
        btnClear_Cancel = New Button()
        btnAdd_Save = New Button()
        cbPoliceCertify = New ComboBox()
        Label22 = New Label()
        cbPoliceVerify = New ComboBox()
        Label21 = New Label()
        btnSignature = New Button()
        Label20 = New Label()
        btnThumbmark = New Button()
        Label19 = New Label()
        btnCamera = New Button()
        Label18 = New Label()
        Label16 = New Label()
        txtORAmount = New TextBox()
        txtORNo = New TextBox()
        Label17 = New Label()
        dtClearanceDate = New DateTimePicker()
        Label15 = New Label()
        txtContactNo = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        txtCTCIssueAt = New TextBox()
        Label10 = New Label()
        dtCTCIssueDate = New DateTimePicker()
        txtCTCNo = New TextBox()
        Label11 = New Label()
        cbPurpose = New ComboBox()
        Label9 = New Label()
        txtNationality = New TextBox()
        Label8 = New Label()
        txtHeight = New TextBox()
        rbFemale = New RadioButton()
        rbMale = New RadioButton()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        dtBirthDate = New DateTimePicker()
        txtBirthPlace = New TextBox()
        Label4 = New Label()
        cbCivilStatus = New ComboBox()
        Label3 = New Label()
        cbBarangay = New ComboBox()
        cbZone = New ComboBox()
        Label2 = New Label()
        txtClearanceMname = New TextBox()
        txtClearanceFname = New TextBox()
        Label14 = New Label()
        txtClearanceLname = New TextBox()
        txtClearanceNo = New TextBox()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnApplicantPendingSearchCancel = New Button()
        txtApplicantPendingSearch = New TextBox()
        dataApplicantPending = New DataGridView()
        dataPendingClearanceID = New DataGridViewTextBoxColumn()
        dataPendingClearanceNo = New DataGridViewTextBoxColumn()
        dataPendingClearanceFname = New DataGridViewTextBoxColumn()
        dataPendingClearanceMname = New DataGridViewTextBoxColumn()
        dataPendingClearanceLname = New DataGridViewTextBoxColumn()
        dataPendingClearanceStatus = New DataGridViewTextBoxColumn()
        dataPendingClearanceEdit = New DataGridViewButtonColumn()
        dataPendingClearanceSetBtn = New DataGridViewButtonColumn()
        dataPendingClearanceDelete = New DataGridViewButtonColumn()
        TabPage2 = New TabPage()
        dataApplicantCompleted = New DataGridView()
        dataCompletedClearanceID = New DataGridViewTextBoxColumn()
        dataCompletedClearanceNo = New DataGridViewTextBoxColumn()
        dataCompletedClearanceFname = New DataGridViewTextBoxColumn()
        dataCompletedClearanceMname = New DataGridViewTextBoxColumn()
        dataCompletedClearanceLname = New DataGridViewTextBoxColumn()
        dataCompletedClearanceStatus = New DataGridViewTextBoxColumn()
        dataCompletedClearancePrint = New DataGridViewButtonColumn()
        btnApplicantCompletedSearchCancel = New Button()
        txtApplicantCompletedSearch = New TextBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dataApplicantPending, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dataApplicantCompleted, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClear_Cancel
        ' 
        btnClear_Cancel.Location = New Point(159, 553)
        btnClear_Cancel.Name = "btnClear_Cancel"
        btnClear_Cancel.Size = New Size(132, 23)
        btnClear_Cancel.TabIndex = 135
        btnClear_Cancel.Text = "Clear"
        btnClear_Cancel.UseVisualStyleBackColor = True
        ' 
        ' btnAdd_Save
        ' 
        btnAdd_Save.Location = New Point(17, 553)
        btnAdd_Save.Name = "btnAdd_Save"
        btnAdd_Save.Size = New Size(132, 23)
        btnAdd_Save.TabIndex = 134
        btnAdd_Save.Text = "Add"
        btnAdd_Save.UseVisualStyleBackColor = True
        ' 
        ' cbPoliceCertify
        ' 
        cbPoliceCertify.FormattingEnabled = True
        cbPoliceCertify.Location = New Point(17, 514)
        cbPoliceCertify.Name = "cbPoliceCertify"
        cbPoliceCertify.Size = New Size(471, 23)
        cbPoliceCertify.TabIndex = 139
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(17, 496)
        Label22.Name = "Label22"
        Label22.Size = New Size(68, 15)
        Label22.TabIndex = 138
        Label22.Text = "Certified By"
        ' 
        ' cbPoliceVerify
        ' 
        cbPoliceVerify.FormattingEnabled = True
        cbPoliceVerify.Location = New Point(17, 465)
        cbPoliceVerify.Name = "cbPoliceVerify"
        cbPoliceVerify.Size = New Size(471, 23)
        cbPoliceVerify.TabIndex = 137
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(17, 449)
        Label21.Name = "Label21"
        Label21.Size = New Size(62, 15)
        Label21.TabIndex = 136
        Label21.Text = "Verified By"
        ' 
        ' btnSignature
        ' 
        btnSignature.Location = New Point(569, 612)
        btnSignature.Name = "btnSignature"
        btnSignature.Size = New Size(75, 23)
        btnSignature.TabIndex = 133
        btnSignature.Text = "Upload"
        btnSignature.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(576, 438)
        Label20.Name = "Label20"
        Label20.Size = New Size(57, 15)
        Label20.TabIndex = 132
        Label20.Text = "Signature"
        ' 
        ' btnThumbmark
        ' 
        btnThumbmark.Location = New Point(569, 405)
        btnThumbmark.Name = "btnThumbmark"
        btnThumbmark.Size = New Size(75, 23)
        btnThumbmark.TabIndex = 130
        btnThumbmark.Text = "Upload"
        btnThumbmark.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(561, 231)
        Label19.Name = "Label19"
        Label19.Size = New Size(85, 15)
        Label19.TabIndex = 129
        Label19.Text = "R. Thumbmark"
        ' 
        ' btnCamera
        ' 
        btnCamera.Location = New Point(569, 201)
        btnCamera.Name = "btnCamera"
        btnCamera.Size = New Size(75, 23)
        btnCamera.TabIndex = 127
        btnCamera.Text = "Upload"
        btnCamera.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(581, 27)
        Label18.Name = "Label18"
        Label18.Size = New Size(48, 15)
        Label18.TabIndex = 126
        Label18.Text = "Camera"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(258, 345)
        Label16.Name = "Label16"
        Label16.Size = New Size(51, 15)
        Label16.TabIndex = 125
        Label16.Text = "Amount"
        ' 
        ' txtORAmount
        ' 
        txtORAmount.Location = New Point(258, 363)
        txtORAmount.Name = "txtORAmount"
        txtORAmount.Size = New Size(230, 23)
        txtORAmount.TabIndex = 124
        ' 
        ' txtORNo
        ' 
        txtORNo.Location = New Point(258, 316)
        txtORNo.Name = "txtORNo"
        txtORNo.Size = New Size(230, 23)
        txtORNo.TabIndex = 123
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(258, 298)
        Label17.Name = "Label17"
        Label17.Size = New Size(70, 15)
        Label17.TabIndex = 122
        Label17.Text = "OR Number"
        ' 
        ' dtClearanceDate
        ' 
        dtClearanceDate.Enabled = False
        dtClearanceDate.Format = DateTimePickerFormat.Short
        dtClearanceDate.Location = New Point(389, 30)
        dtClearanceDate.Name = "dtClearanceDate"
        dtClearanceDate.Size = New Size(99, 23)
        dtClearanceDate.TabIndex = 121
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(349, 33)
        Label15.Name = "Label15"
        Label15.Size = New Size(34, 15)
        Label15.TabIndex = 120
        Label15.Text = "Date:"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(335, 219)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(153, 23)
        txtContactNo.TabIndex = 118
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(335, 203)
        Label13.Name = "Label13"
        Label13.Size = New Size(96, 15)
        Label13.TabIndex = 117
        Label13.Text = "Contact Number"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 392)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 15)
        Label12.TabIndex = 116
        Label12.Text = "Issued At"
        ' 
        ' txtCTCIssueAt
        ' 
        txtCTCIssueAt.Location = New Point(17, 410)
        txtCTCIssueAt.Name = "txtCTCIssueAt"
        txtCTCIssueAt.Size = New Size(230, 23)
        txtCTCIssueAt.TabIndex = 115
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 345)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 15)
        Label10.TabIndex = 114
        Label10.Text = "Issued On"
        ' 
        ' dtCTCIssueDate
        ' 
        dtCTCIssueDate.Format = DateTimePickerFormat.Short
        dtCTCIssueDate.Location = New Point(17, 363)
        dtCTCIssueDate.Name = "dtCTCIssueDate"
        dtCTCIssueDate.Size = New Size(230, 23)
        dtCTCIssueDate.TabIndex = 113
        ' 
        ' txtCTCNo
        ' 
        txtCTCNo.Location = New Point(17, 319)
        txtCTCNo.Name = "txtCTCNo"
        txtCTCNo.Size = New Size(230, 23)
        txtCTCNo.TabIndex = 112
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(17, 301)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 15)
        Label11.TabIndex = 111
        Label11.Text = "CTC Number"
        ' 
        ' cbPurpose
        ' 
        cbPurpose.FormattingEnabled = True
        cbPurpose.Location = New Point(17, 269)
        cbPurpose.Name = "cbPurpose"
        cbPurpose.Size = New Size(471, 23)
        cbPurpose.TabIndex = 110
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 253)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 15)
        Label9.TabIndex = 109
        Label9.Text = "Purpose"
        ' 
        ' txtNationality
        ' 
        txtNationality.Location = New Point(224, 219)
        txtNationality.Name = "txtNationality"
        txtNationality.Size = New Size(105, 23)
        txtNationality.TabIndex = 108
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(226, 203)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 107
        Label8.Text = "Nationality"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(140, 219)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(78, 23)
        txtHeight.TabIndex = 106
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(74, 221)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(63, 19)
        rbFemale.TabIndex = 105
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(17, 221)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(51, 19)
        rbMale.TabIndex = 104
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(140, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 103
        Label7.Text = "Height(ft)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 15)
        Label6.TabIndex = 102
        Label6.Text = "Sex"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(335, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 101
        Label5.Text = "Date of Birth"
        ' 
        ' dtBirthDate
        ' 
        dtBirthDate.Format = DateTimePickerFormat.Short
        dtBirthDate.Location = New Point(335, 177)
        dtBirthDate.Name = "dtBirthDate"
        dtBirthDate.Size = New Size(153, 23)
        dtBirthDate.TabIndex = 100
        ' 
        ' txtBirthPlace
        ' 
        txtBirthPlace.Location = New Point(17, 177)
        txtBirthPlace.Name = "txtBirthPlace"
        txtBirthPlace.Size = New Size(274, 23)
        txtBirthPlace.TabIndex = 99
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 98
        Label4.Text = "Place of Birth"
        ' 
        ' cbCivilStatus
        ' 
        cbCivilStatus.FormattingEnabled = True
        cbCivilStatus.Location = New Point(335, 133)
        cbCivilStatus.Name = "cbCivilStatus"
        cbCivilStatus.Size = New Size(153, 23)
        cbCivilStatus.TabIndex = 97
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(335, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 96
        Label3.Text = "Civil Status"
        ' 
        ' cbBarangay
        ' 
        cbBarangay.FormattingEnabled = True
        cbBarangay.Location = New Point(88, 133)
        cbBarangay.Name = "cbBarangay"
        cbBarangay.Size = New Size(203, 23)
        cbBarangay.TabIndex = 95
        ' 
        ' cbZone
        ' 
        cbZone.FormattingEnabled = True
        cbZone.Location = New Point(17, 133)
        cbZone.Name = "cbZone"
        cbZone.Size = New Size(68, 23)
        cbZone.TabIndex = 94
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 15)
        Label2.TabIndex = 93
        Label2.Text = "Address(Zone, Barangay)"
        ' 
        ' txtClearanceMname
        ' 
        txtClearanceMname.Location = New Point(335, 84)
        txtClearanceMname.Name = "txtClearanceMname"
        txtClearanceMname.Size = New Size(153, 23)
        txtClearanceMname.TabIndex = 92
        ' 
        ' txtClearanceFname
        ' 
        txtClearanceFname.Location = New Point(176, 84)
        txtClearanceFname.Name = "txtClearanceFname"
        txtClearanceFname.Size = New Size(153, 23)
        txtClearanceFname.TabIndex = 91
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(17, 66)
        Label14.Name = "Label14"
        Label14.Size = New Size(262, 15)
        Label14.TabIndex = 90
        Label14.Text = "Full Name(Last name, First name, Middle Name)"
        ' 
        ' txtClearanceLname
        ' 
        txtClearanceLname.Location = New Point(17, 84)
        txtClearanceLname.Name = "txtClearanceLname"
        txtClearanceLname.Size = New Size(153, 23)
        txtClearanceLname.TabIndex = 89
        ' 
        ' txtClearanceNo
        ' 
        txtClearanceNo.Location = New Point(104, 27)
        txtClearanceNo.Name = "txtClearanceNo"
        txtClearanceNo.Size = New Size(77, 23)
        txtClearanceNo.TabIndex = 88
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 87
        Label1.Text = "Clearance No."
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(710, 27)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(788, 579)
        TabControl1.TabIndex = 140
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnApplicantPendingSearchCancel)
        TabPage1.Controls.Add(txtApplicantPendingSearch)
        TabPage1.Controls.Add(dataApplicantPending)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(780, 551)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Pending"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnApplicantPendingSearchCancel
        ' 
        btnApplicantPendingSearchCancel.Location = New Point(702, 6)
        btnApplicantPendingSearchCancel.Name = "btnApplicantPendingSearchCancel"
        btnApplicantPendingSearchCancel.Size = New Size(75, 23)
        btnApplicantPendingSearchCancel.TabIndex = 144
        btnApplicantPendingSearchCancel.Text = "x"
        btnApplicantPendingSearchCancel.UseVisualStyleBackColor = True
        ' 
        ' txtApplicantPendingSearch
        ' 
        txtApplicantPendingSearch.Location = New Point(447, 6)
        txtApplicantPendingSearch.Name = "txtApplicantPendingSearch"
        txtApplicantPendingSearch.Size = New Size(249, 23)
        txtApplicantPendingSearch.TabIndex = 143
        ' 
        ' dataApplicantPending
        ' 
        dataApplicantPending.AllowUserToAddRows = False
        dataApplicantPending.AllowUserToDeleteRows = False
        dataApplicantPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataApplicantPending.Columns.AddRange(New DataGridViewColumn() {dataPendingClearanceID, dataPendingClearanceNo, dataPendingClearanceFname, dataPendingClearanceMname, dataPendingClearanceLname, dataPendingClearanceStatus, dataPendingClearanceEdit, dataPendingClearanceSetBtn, dataPendingClearanceDelete})
        dataApplicantPending.Location = New Point(4, 35)
        dataApplicantPending.Name = "dataApplicantPending"
        dataApplicantPending.ReadOnly = True
        dataApplicantPending.RowTemplate.Height = 25
        dataApplicantPending.Size = New Size(773, 514)
        dataApplicantPending.TabIndex = 142
        ' 
        ' dataPendingClearanceID
        ' 
        dataPendingClearanceID.HeaderText = "ClearanceID"
        dataPendingClearanceID.Name = "dataPendingClearanceID"
        dataPendingClearanceID.ReadOnly = True
        ' 
        ' dataPendingClearanceNo
        ' 
        dataPendingClearanceNo.HeaderText = "Clearance Number"
        dataPendingClearanceNo.Name = "dataPendingClearanceNo"
        dataPendingClearanceNo.ReadOnly = True
        ' 
        ' dataPendingClearanceFname
        ' 
        dataPendingClearanceFname.HeaderText = "First Name"
        dataPendingClearanceFname.Name = "dataPendingClearanceFname"
        dataPendingClearanceFname.ReadOnly = True
        ' 
        ' dataPendingClearanceMname
        ' 
        dataPendingClearanceMname.HeaderText = "Middle Name"
        dataPendingClearanceMname.Name = "dataPendingClearanceMname"
        dataPendingClearanceMname.ReadOnly = True
        ' 
        ' dataPendingClearanceLname
        ' 
        dataPendingClearanceLname.HeaderText = "Last Name"
        dataPendingClearanceLname.Name = "dataPendingClearanceLname"
        dataPendingClearanceLname.ReadOnly = True
        ' 
        ' dataPendingClearanceStatus
        ' 
        dataPendingClearanceStatus.HeaderText = "Status"
        dataPendingClearanceStatus.Name = "dataPendingClearanceStatus"
        dataPendingClearanceStatus.ReadOnly = True
        ' 
        ' dataPendingClearanceEdit
        ' 
        dataPendingClearanceEdit.HeaderText = ""
        dataPendingClearanceEdit.Name = "dataPendingClearanceEdit"
        dataPendingClearanceEdit.ReadOnly = True
        dataPendingClearanceEdit.Text = "Edit"
        dataPendingClearanceEdit.UseColumnTextForButtonValue = True
        ' 
        ' dataPendingClearanceSetBtn
        ' 
        dataPendingClearanceSetBtn.HeaderText = ""
        dataPendingClearanceSetBtn.Name = "dataPendingClearanceSetBtn"
        dataPendingClearanceSetBtn.ReadOnly = True
        dataPendingClearanceSetBtn.Text = ""
        ' 
        ' dataPendingClearanceDelete
        ' 
        dataPendingClearanceDelete.HeaderText = ""
        dataPendingClearanceDelete.Name = "dataPendingClearanceDelete"
        dataPendingClearanceDelete.ReadOnly = True
        dataPendingClearanceDelete.Text = "Delete"
        dataPendingClearanceDelete.UseColumnTextForButtonValue = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dataApplicantCompleted)
        TabPage2.Controls.Add(btnApplicantCompletedSearchCancel)
        TabPage2.Controls.Add(txtApplicantCompletedSearch)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(780, 551)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Completed"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dataApplicantCompleted
        ' 
        dataApplicantCompleted.AllowUserToAddRows = False
        dataApplicantCompleted.AllowUserToDeleteRows = False
        dataApplicantCompleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataApplicantCompleted.Columns.AddRange(New DataGridViewColumn() {dataCompletedClearanceID, dataCompletedClearanceNo, dataCompletedClearanceFname, dataCompletedClearanceMname, dataCompletedClearanceLname, dataCompletedClearanceStatus, dataCompletedClearancePrint})
        dataApplicantCompleted.Location = New Point(4, 37)
        dataApplicantCompleted.Name = "dataApplicantCompleted"
        dataApplicantCompleted.ReadOnly = True
        dataApplicantCompleted.RowTemplate.Height = 25
        dataApplicantCompleted.Size = New Size(773, 514)
        dataApplicantCompleted.TabIndex = 150
        ' 
        ' dataCompletedClearanceID
        ' 
        dataCompletedClearanceID.HeaderText = "ClearanceID"
        dataCompletedClearanceID.Name = "dataCompletedClearanceID"
        dataCompletedClearanceID.ReadOnly = True
        ' 
        ' dataCompletedClearanceNo
        ' 
        dataCompletedClearanceNo.HeaderText = "Clearance Number"
        dataCompletedClearanceNo.Name = "dataCompletedClearanceNo"
        dataCompletedClearanceNo.ReadOnly = True
        ' 
        ' dataCompletedClearanceFname
        ' 
        dataCompletedClearanceFname.HeaderText = "First Name"
        dataCompletedClearanceFname.Name = "dataCompletedClearanceFname"
        dataCompletedClearanceFname.ReadOnly = True
        ' 
        ' dataCompletedClearanceMname
        ' 
        dataCompletedClearanceMname.HeaderText = "Middle Name"
        dataCompletedClearanceMname.Name = "dataCompletedClearanceMname"
        dataCompletedClearanceMname.ReadOnly = True
        ' 
        ' dataCompletedClearanceLname
        ' 
        dataCompletedClearanceLname.HeaderText = "Last Name"
        dataCompletedClearanceLname.Name = "dataCompletedClearanceLname"
        dataCompletedClearanceLname.ReadOnly = True
        ' 
        ' dataCompletedClearanceStatus
        ' 
        dataCompletedClearanceStatus.HeaderText = "Status"
        dataCompletedClearanceStatus.Name = "dataCompletedClearanceStatus"
        dataCompletedClearanceStatus.ReadOnly = True
        ' 
        ' dataCompletedClearancePrint
        ' 
        dataCompletedClearancePrint.HeaderText = ""
        dataCompletedClearancePrint.Name = "dataCompletedClearancePrint"
        dataCompletedClearancePrint.ReadOnly = True
        dataCompletedClearancePrint.Text = "Print"
        dataCompletedClearancePrint.UseColumnTextForButtonValue = True
        ' 
        ' btnApplicantCompletedSearchCancel
        ' 
        btnApplicantCompletedSearchCancel.Location = New Point(702, 5)
        btnApplicantCompletedSearchCancel.Name = "btnApplicantCompletedSearchCancel"
        btnApplicantCompletedSearchCancel.Size = New Size(75, 23)
        btnApplicantCompletedSearchCancel.TabIndex = 147
        btnApplicantCompletedSearchCancel.Text = "x"
        btnApplicantCompletedSearchCancel.UseVisualStyleBackColor = True
        ' 
        ' txtApplicantCompletedSearch
        ' 
        txtApplicantCompletedSearch.Location = New Point(447, 5)
        txtApplicantCompletedSearch.Name = "txtApplicantCompletedSearch"
        txtApplicantCompletedSearch.Size = New Size(249, 23)
        txtApplicantCompletedSearch.TabIndex = 146
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1370, 24)
        MenuStrip1.TabIndex = 141
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReportToolStripMenuItem, LogoutToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(112, 22)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(112, 22)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(530, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 142
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(530, 249)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 150)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 143
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(530, 456)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(150, 150)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 144
        PictureBox3.TabStop = False
        ' 
        ' Clerk2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 641)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(btnClear_Cancel)
        Controls.Add(btnAdd_Save)
        Controls.Add(cbPoliceCertify)
        Controls.Add(Label22)
        Controls.Add(cbPoliceVerify)
        Controls.Add(Label21)
        Controls.Add(btnSignature)
        Controls.Add(Label20)
        Controls.Add(btnThumbmark)
        Controls.Add(Label19)
        Controls.Add(btnCamera)
        Controls.Add(Label18)
        Controls.Add(Label16)
        Controls.Add(txtORAmount)
        Controls.Add(txtORNo)
        Controls.Add(Label17)
        Controls.Add(dtClearanceDate)
        Controls.Add(Label15)
        Controls.Add(txtContactNo)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(txtCTCIssueAt)
        Controls.Add(Label10)
        Controls.Add(dtCTCIssueDate)
        Controls.Add(txtCTCNo)
        Controls.Add(Label11)
        Controls.Add(cbPurpose)
        Controls.Add(Label9)
        Controls.Add(txtNationality)
        Controls.Add(Label8)
        Controls.Add(txtHeight)
        Controls.Add(rbFemale)
        Controls.Add(rbMale)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(dtBirthDate)
        Controls.Add(txtBirthPlace)
        Controls.Add(Label4)
        Controls.Add(cbCivilStatus)
        Controls.Add(Label3)
        Controls.Add(cbBarangay)
        Controls.Add(cbZone)
        Controls.Add(Label2)
        Controls.Add(txtClearanceMname)
        Controls.Add(txtClearanceFname)
        Controls.Add(Label14)
        Controls.Add(txtClearanceLname)
        Controls.Add(txtClearanceNo)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Clerk2"
        Text = "Clerk"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dataApplicantPending, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dataApplicantCompleted, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
