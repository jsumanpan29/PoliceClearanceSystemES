Imports MaterialSkin2Framework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clerk2
    'Inherits System.Windows.Forms.Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Clerk2))
        cbPoliceCertify = New ComboBox()
        Label22 = New Label()
        cbPoliceVerify = New ComboBox()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
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
        Panel3 = New Panel()
        btnClear_Cancel = New MaterialButton()
        Panel1 = New Panel()
        btnAdd_Saved = New MaterialButton()
        Panel2 = New Panel()
        MaterialButton1 = New MaterialButton()
        Panel4 = New Panel()
        MaterialButton2 = New MaterialButton()
        Panel5 = New Panel()
        MaterialButton3 = New MaterialButton()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dataApplicantPending, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dataApplicantCompleted, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbPoliceCertify
        ' 
        cbPoliceCertify.FormattingEnabled = True
        cbPoliceCertify.Location = New Point(15, 580)
        cbPoliceCertify.Name = "cbPoliceCertify"
        cbPoliceCertify.Size = New Size(471, 23)
        cbPoliceCertify.TabIndex = 22
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(15, 562)
        Label22.Name = "Label22"
        Label22.Size = New Size(68, 15)
        Label22.TabIndex = 138
        Label22.Text = "Certified By"
        ' 
        ' cbPoliceVerify
        ' 
        cbPoliceVerify.FormattingEnabled = True
        cbPoliceVerify.Location = New Point(15, 531)
        cbPoliceVerify.Name = "cbPoliceVerify"
        cbPoliceVerify.Size = New Size(471, 23)
        cbPoliceVerify.TabIndex = 21
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(15, 515)
        Label21.Name = "Label21"
        Label21.Size = New Size(62, 15)
        Label21.TabIndex = 136
        Label21.Text = "Verified By"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(566, 511)
        Label20.Name = "Label20"
        Label20.Size = New Size(76, 20)
        Label20.TabIndex = 132
        Label20.Text = "Signature"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(548, 303)
        Label19.Name = "Label19"
        Label19.Size = New Size(113, 20)
        Label19.TabIndex = 129
        Label19.Text = "R. Thumbmark"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(574, 94)
        Label18.Name = "Label18"
        Label18.Size = New Size(62, 20)
        Label18.TabIndex = 126
        Label18.Text = "Camera"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(256, 411)
        Label16.Name = "Label16"
        Label16.Size = New Size(51, 15)
        Label16.TabIndex = 125
        Label16.Text = "Amount"
        ' 
        ' txtORAmount
        ' 
        txtORAmount.Location = New Point(256, 429)
        txtORAmount.Name = "txtORAmount"
        txtORAmount.Size = New Size(230, 23)
        txtORAmount.TabIndex = 19
        ' 
        ' txtORNo
        ' 
        txtORNo.Location = New Point(256, 382)
        txtORNo.Name = "txtORNo"
        txtORNo.Size = New Size(230, 23)
        txtORNo.TabIndex = 17
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(256, 364)
        Label17.Name = "Label17"
        Label17.Size = New Size(70, 15)
        Label17.TabIndex = 122
        Label17.Text = "OR Number"
        ' 
        ' dtClearanceDate
        ' 
        dtClearanceDate.Enabled = False
        dtClearanceDate.Format = DateTimePickerFormat.Short
        dtClearanceDate.Location = New Point(387, 96)
        dtClearanceDate.Name = "dtClearanceDate"
        dtClearanceDate.Size = New Size(99, 23)
        dtClearanceDate.TabIndex = 121
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(347, 99)
        Label15.Name = "Label15"
        Label15.Size = New Size(34, 15)
        Label15.TabIndex = 120
        Label15.Text = "Date:"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(333, 285)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(153, 23)
        txtContactNo.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(333, 269)
        Label13.Name = "Label13"
        Label13.Size = New Size(96, 15)
        Label13.TabIndex = 117
        Label13.Text = "Contact Number"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(15, 458)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 15)
        Label12.TabIndex = 116
        Label12.Text = "Issued At"
        ' 
        ' txtCTCIssueAt
        ' 
        txtCTCIssueAt.Location = New Point(15, 476)
        txtCTCIssueAt.Name = "txtCTCIssueAt"
        txtCTCIssueAt.Size = New Size(230, 23)
        txtCTCIssueAt.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(15, 411)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 15)
        Label10.TabIndex = 114
        Label10.Text = "Issued On"
        ' 
        ' dtCTCIssueDate
        ' 
        dtCTCIssueDate.Format = DateTimePickerFormat.Short
        dtCTCIssueDate.Location = New Point(15, 429)
        dtCTCIssueDate.Name = "dtCTCIssueDate"
        dtCTCIssueDate.Size = New Size(230, 23)
        dtCTCIssueDate.TabIndex = 18
        ' 
        ' txtCTCNo
        ' 
        txtCTCNo.Location = New Point(15, 385)
        txtCTCNo.Name = "txtCTCNo"
        txtCTCNo.Size = New Size(230, 23)
        txtCTCNo.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(15, 367)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 15)
        Label11.TabIndex = 111
        Label11.Text = "CTC Number"
        ' 
        ' cbPurpose
        ' 
        cbPurpose.FormattingEnabled = True
        cbPurpose.Location = New Point(15, 335)
        cbPurpose.Name = "cbPurpose"
        cbPurpose.Size = New Size(471, 23)
        cbPurpose.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(15, 319)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 15)
        Label9.TabIndex = 109
        Label9.Text = "Purpose"
        ' 
        ' txtNationality
        ' 
        txtNationality.Location = New Point(222, 285)
        txtNationality.Name = "txtNationality"
        txtNationality.Size = New Size(105, 23)
        txtNationality.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(224, 269)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 107
        Label8.Text = "Nationality"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(138, 285)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(78, 23)
        txtHeight.TabIndex = 12
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(72, 287)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(63, 19)
        rbFemale.TabIndex = 11
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(15, 287)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(51, 19)
        rbMale.TabIndex = 10
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(138, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 103
        Label7.Text = "Height(ft)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 269)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 15)
        Label6.TabIndex = 102
        Label6.Text = "Sex"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(333, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 101
        Label5.Text = "Date of Birth"
        ' 
        ' dtBirthDate
        ' 
        dtBirthDate.Format = DateTimePickerFormat.Short
        dtBirthDate.Location = New Point(333, 243)
        dtBirthDate.Name = "dtBirthDate"
        dtBirthDate.Size = New Size(153, 23)
        dtBirthDate.TabIndex = 9
        ' 
        ' txtBirthPlace
        ' 
        txtBirthPlace.Location = New Point(15, 243)
        txtBirthPlace.Name = "txtBirthPlace"
        txtBirthPlace.Size = New Size(274, 23)
        txtBirthPlace.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 98
        Label4.Text = "Place of Birth"
        ' 
        ' cbCivilStatus
        ' 
        cbCivilStatus.FormattingEnabled = True
        cbCivilStatus.Location = New Point(333, 199)
        cbCivilStatus.Name = "cbCivilStatus"
        cbCivilStatus.Size = New Size(153, 23)
        cbCivilStatus.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(333, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 96
        Label3.Text = "Civil Status"
        ' 
        ' cbBarangay
        ' 
        cbBarangay.FormattingEnabled = True
        cbBarangay.Location = New Point(86, 199)
        cbBarangay.Name = "cbBarangay"
        cbBarangay.Size = New Size(203, 23)
        cbBarangay.TabIndex = 6
        ' 
        ' cbZone
        ' 
        cbZone.FormattingEnabled = True
        cbZone.Location = New Point(15, 199)
        cbZone.Name = "cbZone"
        cbZone.Size = New Size(68, 23)
        cbZone.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 15)
        Label2.TabIndex = 93
        Label2.Text = "Address(Zone, Barangay)"
        ' 
        ' txtClearanceMname
        ' 
        txtClearanceMname.Location = New Point(333, 150)
        txtClearanceMname.Name = "txtClearanceMname"
        txtClearanceMname.Size = New Size(153, 23)
        txtClearanceMname.TabIndex = 4
        ' 
        ' txtClearanceFname
        ' 
        txtClearanceFname.Location = New Point(174, 150)
        txtClearanceFname.Name = "txtClearanceFname"
        txtClearanceFname.Size = New Size(153, 23)
        txtClearanceFname.TabIndex = 3
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(15, 132)
        Label14.Name = "Label14"
        Label14.Size = New Size(262, 15)
        Label14.TabIndex = 90
        Label14.Text = "Full Name(Last name, First name, Middle Name)"
        ' 
        ' txtClearanceLname
        ' 
        txtClearanceLname.Location = New Point(15, 150)
        txtClearanceLname.Name = "txtClearanceLname"
        txtClearanceLname.Size = New Size(153, 23)
        txtClearanceLname.TabIndex = 2
        ' 
        ' txtClearanceNo
        ' 
        txtClearanceNo.Location = New Point(102, 95)
        txtClearanceNo.Name = "txtClearanceNo"
        txtClearanceNo.Size = New Size(95, 23)
        txtClearanceNo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 87
        Label1.Text = "Clearance No."
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(708, 93)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(788, 579)
        TabControl1.TabIndex = 1
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
        btnApplicantPendingSearchCancel.Location = New Point(702, 18)
        btnApplicantPendingSearchCancel.Name = "btnApplicantPendingSearchCancel"
        btnApplicantPendingSearchCancel.Size = New Size(75, 23)
        btnApplicantPendingSearchCancel.TabIndex = 144
        btnApplicantPendingSearchCancel.Text = "x"
        btnApplicantPendingSearchCancel.UseVisualStyleBackColor = True
        ' 
        ' txtApplicantPendingSearch
        ' 
        txtApplicantPendingSearch.Location = New Point(447, 18)
        txtApplicantPendingSearch.Name = "txtApplicantPendingSearch"
        txtApplicantPendingSearch.Size = New Size(249, 23)
        txtApplicantPendingSearch.TabIndex = 2
        ' 
        ' dataApplicantPending
        ' 
        dataApplicantPending.AllowUserToAddRows = False
        dataApplicantPending.AllowUserToDeleteRows = False
        dataApplicantPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataApplicantPending.Columns.AddRange(New DataGridViewColumn() {dataPendingClearanceID, dataPendingClearanceNo, dataPendingClearanceFname, dataPendingClearanceMname, dataPendingClearanceLname, dataPendingClearanceStatus, dataPendingClearanceEdit, dataPendingClearanceSetBtn, dataPendingClearanceDelete})
        dataApplicantPending.Location = New Point(4, 49)
        dataApplicantPending.Name = "dataApplicantPending"
        dataApplicantPending.ReadOnly = True
        dataApplicantPending.RowTemplate.Height = 25
        dataApplicantPending.Size = New Size(773, 501)
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
        dataApplicantCompleted.Location = New Point(4, 49)
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
        btnApplicantCompletedSearchCancel.Location = New Point(702, 17)
        btnApplicantCompletedSearchCancel.Name = "btnApplicantCompletedSearchCancel"
        btnApplicantCompletedSearchCancel.Size = New Size(75, 23)
        btnApplicantCompletedSearchCancel.TabIndex = 147
        btnApplicantCompletedSearchCancel.Text = "x"
        btnApplicantCompletedSearchCancel.UseVisualStyleBackColor = True
        ' 
        ' txtApplicantCompletedSearch
        ' 
        txtApplicantCompletedSearch.Location = New Point(447, 18)
        txtApplicantCompletedSearch.Name = "txtApplicantCompletedSearch"
        txtApplicantCompletedSearch.Size = New Size(249, 23)
        txtApplicantCompletedSearch.TabIndex = 146
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(3, 64)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1364, 28)
        MenuStrip1.TabIndex = 141
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReportToolStripMenuItem, LogoutToolStripMenuItem})
        FileToolStripMenuItem.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(44, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), Image)
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(125, 24)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), Image)
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(125, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(528, 118)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 142
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(528, 326)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 150)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 143
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(528, 533)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(150, 150)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 144
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel3.Controls.Add(btnClear_Cancel)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(246, 622)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(132, 25)
        Panel3.TabIndex = 146
        ' 
        ' btnClear_Cancel
        ' 
        btnClear_Cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear_Cancel.Density = MaterialButton.MaterialButtonDensity.Default
        btnClear_Cancel.Depth = 0
        btnClear_Cancel.HighEmphasis = False
        btnClear_Cancel.Icon = Nothing
        btnClear_Cancel.Location = New Point(0, 0)
        btnClear_Cancel.Margin = New Padding(4, 6, 4, 6)
        btnClear_Cancel.MaximumSize = New Size(132, 25)
        btnClear_Cancel.MinimumSize = New Size(132, 25)
        btnClear_Cancel.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnClear_Cancel.Name = "btnClear_Cancel"
        btnClear_Cancel.NoAccentTextColor = Color.Empty
        btnClear_Cancel.Size = New Size(132, 25)
        btnClear_Cancel.TabIndex = 55
        btnClear_Cancel.Text = "Clear"
        btnClear_Cancel.Type = MaterialButton.MaterialButtonType.Text
        btnClear_Cancel.UseAccentColor = False
        btnClear_Cancel.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(btnAdd_Saved)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(84, 622)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(132, 25)
        Panel1.TabIndex = 145
        ' 
        ' btnAdd_Saved
        ' 
        btnAdd_Saved.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAdd_Saved.BackColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        btnAdd_Saved.Density = MaterialButton.MaterialButtonDensity.Default
        btnAdd_Saved.Depth = 0
        btnAdd_Saved.DrawShadows = False
        btnAdd_Saved.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        btnAdd_Saved.FlatAppearance.MouseDownBackColor = Color.Silver
        btnAdd_Saved.FlatAppearance.MouseOverBackColor = Color.Silver
        btnAdd_Saved.FlatStyle = FlatStyle.Flat
        btnAdd_Saved.ForeColor = Color.White
        btnAdd_Saved.HighEmphasis = False
        btnAdd_Saved.Icon = Nothing
        btnAdd_Saved.Location = New Point(0, 0)
        btnAdd_Saved.Margin = New Padding(4, 6, 4, 6)
        btnAdd_Saved.MaximumSize = New Size(132, 25)
        btnAdd_Saved.MinimumSize = New Size(132, 25)
        btnAdd_Saved.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnAdd_Saved.Name = "btnAdd_Saved"
        btnAdd_Saved.NoAccentTextColor = Color.Empty
        btnAdd_Saved.Size = New Size(132, 25)
        btnAdd_Saved.TabIndex = 53
        btnAdd_Saved.Text = "Add"
        btnAdd_Saved.Type = MaterialButton.MaterialButtonType.Outlined
        btnAdd_Saved.UseAccentColor = False
        btnAdd_Saved.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(MaterialButton1)
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(567, 275)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(75, 23)
        Panel2.TabIndex = 146
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.BackColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton1.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal
        MaterialButton1.Density = MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.DrawShadows = False
        MaterialButton1.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton1.FlatAppearance.MouseDownBackColor = Color.Silver
        MaterialButton1.FlatAppearance.MouseOverBackColor = Color.Silver
        MaterialButton1.FlatStyle = FlatStyle.Flat
        MaterialButton1.ForeColor = Color.White
        MaterialButton1.HighEmphasis = False
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(0, 0)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MaximumSize = New Size(75, 23)
        MaterialButton1.MinimumSize = New Size(75, 23)
        MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(75, 23)
        MaterialButton1.TabIndex = 53
        MaterialButton1.Text = "Upload"
        MaterialButton1.Type = MaterialButton.MaterialButtonType.Outlined
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.WhiteSmoke
        Panel4.Controls.Add(MaterialButton2)
        Panel4.ForeColor = Color.White
        Panel4.Location = New Point(567, 482)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(75, 23)
        Panel4.TabIndex = 147
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.BackColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton2.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal
        MaterialButton2.Density = MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.DrawShadows = False
        MaterialButton2.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton2.FlatAppearance.MouseDownBackColor = Color.Silver
        MaterialButton2.FlatAppearance.MouseOverBackColor = Color.Silver
        MaterialButton2.FlatStyle = FlatStyle.Flat
        MaterialButton2.ForeColor = Color.White
        MaterialButton2.HighEmphasis = False
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(0, 0)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MaximumSize = New Size(75, 23)
        MaterialButton2.MinimumSize = New Size(75, 23)
        MaterialButton2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(75, 23)
        MaterialButton2.TabIndex = 53
        MaterialButton2.Text = "Upload"
        MaterialButton2.Type = MaterialButton.MaterialButtonType.Outlined
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.WhiteSmoke
        Panel5.Controls.Add(MaterialButton3)
        Panel5.ForeColor = Color.White
        Panel5.Location = New Point(567, 691)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(75, 23)
        Panel5.TabIndex = 148
        ' 
        ' MaterialButton3
        ' 
        MaterialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton3.BackColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton3.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal
        MaterialButton3.Density = MaterialButton.MaterialButtonDensity.Default
        MaterialButton3.Depth = 0
        MaterialButton3.DrawShadows = False
        MaterialButton3.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton3.FlatAppearance.MouseDownBackColor = Color.Silver
        MaterialButton3.FlatAppearance.MouseOverBackColor = Color.Silver
        MaterialButton3.FlatStyle = FlatStyle.Flat
        MaterialButton3.ForeColor = Color.White
        MaterialButton3.HighEmphasis = False
        MaterialButton3.Icon = Nothing
        MaterialButton3.Location = New Point(0, 0)
        MaterialButton3.Margin = New Padding(4, 6, 4, 6)
        MaterialButton3.MaximumSize = New Size(75, 23)
        MaterialButton3.MinimumSize = New Size(75, 23)
        MaterialButton3.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton3.Name = "MaterialButton3"
        MaterialButton3.NoAccentTextColor = Color.Empty
        MaterialButton3.Size = New Size(75, 23)
        MaterialButton3.TabIndex = 149
        MaterialButton3.Text = "Upload"
        MaterialButton3.Type = MaterialButton.MaterialButtonType.Outlined
        MaterialButton3.UseAccentColor = False
        MaterialButton3.UseVisualStyleBackColor = False
        ' 
        ' Clerk2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 734)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(cbPoliceCertify)
        Controls.Add(Label22)
        Controls.Add(cbPoliceVerify)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
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
        PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
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
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cbPoliceCertify As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbPoliceVerify As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClear_Cancel As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd_Saved As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents MaterialButton3 As MaterialSkin2Framework.Controls.MaterialButton
End Class
