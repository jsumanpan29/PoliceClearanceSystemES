<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin))
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        TabPage7 = New TabPage()
        btnCRsSearchRefresh = New MaterialSkin2Framework.Controls.MaterialButton()
        btnCRAdd = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel10 = New Panel()
        dataCR = New MaterialSkin2Framework.Controls.MaterialDataTable()
        dataCriminalRecordsID = New DataGridViewTextBoxColumn()
        dataCriminalRecordsFName = New DataGridViewTextBoxColumn()
        dataCriminalRecordsMName = New DataGridViewTextBoxColumn()
        dataCriminalRecordsLName = New DataGridViewTextBoxColumn()
        dataCriminalRecordsOffense = New DataGridViewTextBoxColumn()
        dataCriminalRecordsCCNo = New DataGridViewTextBoxColumn()
        dataCriminalRecordsISNO = New DataGridViewTextBoxColumn()
        dataCriminalRecordsRemarks = New DataGridViewTextBoxColumn()
        dataCriminalRecordsBtnEdit = New DataGridViewButtonColumn()
        dataCriminalRecordsBtnDelete = New DataGridViewButtonColumn()
        txtCRSearch = New TextBox()
        TabPage3 = New TabPage()
        btnPoliceSearchRefresh = New MaterialSkin2Framework.Controls.MaterialButton()
        btnPoliceAdd = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel7 = New Panel()
        dataPolice = New MaterialSkin2Framework.Controls.MaterialDataTable()
        dataPoliceID = New DataGridViewTextBoxColumn()
        dataPoliceFname = New DataGridViewTextBoxColumn()
        dataPoliceMname = New DataGridViewTextBoxColumn()
        dataPoliceLname = New DataGridViewTextBoxColumn()
        dataPoliceContactNo = New DataGridViewTextBoxColumn()
        dataPoliceRank = New DataGridViewTextBoxColumn()
        dataPolicePosition = New DataGridViewTextBoxColumn()
        dataPoliceBtnEdit = New DataGridViewButtonColumn()
        dataPoliceBtnDelete = New DataGridViewButtonColumn()
        txtPoliceSearch = New TextBox()
        TabPage2 = New TabPage()
        btnUsersSearchRefresh = New MaterialSkin2Framework.Controls.MaterialButton()
        btnUsersAdd = New MaterialSkin2Framework.Controls.MaterialButton()
        MaterialCard1 = New MaterialSkin2Framework.Controls.MaterialCard()
        dataUser = New MaterialSkin2Framework.Controls.MaterialDataTable()
        dataUserID = New DataGridViewTextBoxColumn()
        dataUserUname = New DataGridViewTextBoxColumn()
        dataUserFname = New DataGridViewTextBoxColumn()
        dataUserMname = New DataGridViewTextBoxColumn()
        dataUserLname = New DataGridViewTextBoxColumn()
        dataUserContactNo = New DataGridViewTextBoxColumn()
        dataUserUtype = New DataGridViewTextBoxColumn()
        dataUserBtnEdit = New DataGridViewButtonColumn()
        dataUserBtnDelete = New DataGridViewButtonColumn()
        txtUserSearch = New TextBox()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        MaterialCard4 = New MaterialSkin2Framework.Controls.MaterialCard()
        Panel6 = New Panel()
        Label3 = New Label()
        lblCRCount = New Label()
        MaterialCard2 = New MaterialSkin2Framework.Controls.MaterialCard()
        Panel4 = New Panel()
        Label2 = New Label()
        lblUserCount = New Label()
        MaterialCard3 = New MaterialSkin2Framework.Controls.MaterialCard()
        Panel5 = New Panel()
        Label1 = New Label()
        lblPoliceCount = New Label()
        Panel9 = New Panel()
        Panel8 = New Panel()
        Label4 = New Label()
        TabControl1 = New TabControl()
        dataUserID2 = New DataGridViewTextBoxColumn()
        dataUserUtype2 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        MenuStrip1.SuspendLayout()
        TabPage7.SuspendLayout()
        Panel10.SuspendLayout()
        CType(dataCR, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        Panel7.SuspendLayout()
        CType(dataPolice, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        MaterialCard1.SuspendLayout()
        CType(dataUser, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        MaterialCard4.SuspendLayout()
        MaterialCard2.SuspendLayout()
        MaterialCard3.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(3, 64)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(48, 38)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SettingsToolStripMenuItem, LogoutToolStripMenuItem})
        FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), Image)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Padding = New Padding(10, 7, 10, 7)
        FileToolStripMenuItem.Size = New Size(40, 34)
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), Image)
        SettingsToolStripMenuItem.ImageAlign = ContentAlignment.BottomCenter
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(129, 24)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), Image)
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(129, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' TabPage7
        ' 
        TabPage7.AutoScroll = True
        TabPage7.Controls.Add(btnCRsSearchRefresh)
        TabPage7.Controls.Add(btnCRAdd)
        TabPage7.Controls.Add(Panel10)
        TabPage7.Controls.Add(txtCRSearch)
        TabPage7.Location = New Point(4, 30)
        TabPage7.Name = "TabPage7"
        TabPage7.Size = New Size(971, 475)
        TabPage7.TabIndex = 6
        TabPage7.Text = "Criminal Records"
        TabPage7.UseVisualStyleBackColor = True
        ' 
        ' btnCRsSearchRefresh
        ' 
        btnCRsSearchRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCRsSearchRefresh.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCRsSearchRefresh.Depth = 0
        btnCRsSearchRefresh.HighEmphasis = True
        btnCRsSearchRefresh.Icon = Nothing
        btnCRsSearchRefresh.Location = New Point(955, 5)
        btnCRsSearchRefresh.Margin = New Padding(4, 6, 4, 6)
        btnCRsSearchRefresh.MaximumSize = New Size(75, 30)
        btnCRsSearchRefresh.MinimumSize = New Size(75, 30)
        btnCRsSearchRefresh.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnCRsSearchRefresh.Name = "btnCRsSearchRefresh"
        btnCRsSearchRefresh.NoAccentTextColor = Color.Empty
        btnCRsSearchRefresh.Size = New Size(75, 30)
        btnCRsSearchRefresh.TabIndex = 13
        btnCRsSearchRefresh.Text = "X"
        btnCRsSearchRefresh.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnCRsSearchRefresh.UseAccentColor = False
        btnCRsSearchRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnCRAdd
        ' 
        btnCRAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCRAdd.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCRAdd.Depth = 0
        btnCRAdd.HighEmphasis = True
        btnCRAdd.Icon = Nothing
        btnCRAdd.Location = New Point(966, 446)
        btnCRAdd.Margin = New Padding(4, 6, 4, 6)
        btnCRAdd.MaximumSize = New Size(64, 23)
        btnCRAdd.MinimumSize = New Size(60, 20)
        btnCRAdd.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnCRAdd.Name = "btnCRAdd"
        btnCRAdd.NoAccentTextColor = Color.Empty
        btnCRAdd.Size = New Size(64, 23)
        btnCRAdd.TabIndex = 11
        btnCRAdd.Text = "Add"
        btnCRAdd.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnCRAdd.UseAccentColor = False
        btnCRAdd.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(dataCR)
        Panel10.Location = New Point(3, 40)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1032, 405)
        Panel10.TabIndex = 10
        ' 
        ' dataCR
        ' 
        dataCR.AllowUserToAddRows = False
        dataCR.AllowUserToDeleteRows = False
        dataCR.AllowUserToResizeRows = False
        dataCR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataCR.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dataCR.BorderStyle = BorderStyle.None
        dataCR.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        dataCR.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey800
        dataCR.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle13.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        dataCR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        dataCR.ColumnHeadersHeight = 56
        dataCR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dataCR.Columns.AddRange(New DataGridViewColumn() {dataCriminalRecordsID, dataCriminalRecordsFName, dataCriminalRecordsMName, dataCriminalRecordsLName, dataCriminalRecordsOffense, dataCriminalRecordsCCNo, dataCriminalRecordsISNO, dataCriminalRecordsRemarks, dataCriminalRecordsBtnEdit, dataCriminalRecordsBtnDelete})
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = SystemColors.Window
        DataGridViewCellStyle14.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.False
        dataCR.DefaultCellStyle = DataGridViewCellStyle14
        dataCR.Depth = 0
        dataCR.Dock = DockStyle.Fill
        dataCR.EnableHeadersVisualStyles = False
        dataCR.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        dataCR.GridColor = Color.White
        dataCR.Location = New Point(0, 0)
        dataCR.MouseState = MaterialSkin2Framework.MouseState.HOVER
        dataCR.Name = "dataCR"
        dataCR.ReadOnly = True
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = SystemColors.Control
        DataGridViewCellStyle15.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        DataGridViewCellStyle15.SelectionForeColor = Color.Black
        DataGridViewCellStyle15.WrapMode = DataGridViewTriState.True
        dataCR.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        dataCR.RowHeadersVisible = False
        DataGridViewCellStyle16.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        DataGridViewCellStyle16.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        dataCR.RowsDefaultCellStyle = DataGridViewCellStyle16
        dataCR.RowTemplate.Height = 52
        dataCR.ScrollBars = ScrollBars.None
        dataCR.ShowVerticalScroll = False
        dataCR.Size = New Size(1032, 405)
        dataCR.TabIndex = 8
        ' 
        ' dataCriminalRecordsID
        ' 
        dataCriminalRecordsID.DividerWidth = 1
        dataCriminalRecordsID.FillWeight = 30.3328857F
        dataCriminalRecordsID.HeaderText = "    ID"
        dataCriminalRecordsID.Name = "dataCriminalRecordsID"
        dataCriminalRecordsID.ReadOnly = True
        dataCriminalRecordsID.Resizable = DataGridViewTriState.True
        ' 
        ' dataCriminalRecordsFName
        ' 
        dataCriminalRecordsFName.DividerWidth = 1
        dataCriminalRecordsFName.FillWeight = 60.66577F
        dataCriminalRecordsFName.HeaderText = "   FIRST NAME"
        dataCriminalRecordsFName.Name = "dataCriminalRecordsFName"
        dataCriminalRecordsFName.ReadOnly = True
        ' 
        ' dataCriminalRecordsMName
        ' 
        dataCriminalRecordsMName.DividerWidth = 1
        dataCriminalRecordsMName.FillWeight = 66.7323456F
        dataCriminalRecordsMName.HeaderText = "   MIDDLE NAME"
        dataCriminalRecordsMName.Name = "dataCriminalRecordsMName"
        dataCriminalRecordsMName.ReadOnly = True
        ' 
        ' dataCriminalRecordsLName
        ' 
        dataCriminalRecordsLName.DividerWidth = 1
        dataCriminalRecordsLName.FillWeight = 60.66577F
        dataCriminalRecordsLName.HeaderText = "   LAST NAME"
        dataCriminalRecordsLName.Name = "dataCriminalRecordsLName"
        dataCriminalRecordsLName.ReadOnly = True
        ' 
        ' dataCriminalRecordsOffense
        ' 
        dataCriminalRecordsOffense.DividerWidth = 1
        dataCriminalRecordsOffense.FillWeight = 50F
        dataCriminalRecordsOffense.HeaderText = "CRIME/OFFENSE COMMITTED"
        dataCriminalRecordsOffense.Name = "dataCriminalRecordsOffense"
        dataCriminalRecordsOffense.ReadOnly = True
        ' 
        ' dataCriminalRecordsCCNo
        ' 
        dataCriminalRecordsCCNo.DividerWidth = 1
        dataCriminalRecordsCCNo.FillWeight = 36.3994637F
        dataCriminalRecordsCCNo.HeaderText = "CRIMINAL CASE NO."
        dataCriminalRecordsCCNo.Name = "dataCriminalRecordsCCNo"
        dataCriminalRecordsCCNo.ReadOnly = True
        ' 
        ' dataCriminalRecordsISNO
        ' 
        dataCriminalRecordsISNO.DividerWidth = 1
        dataCriminalRecordsISNO.FillWeight = 40F
        dataCriminalRecordsISNO.HeaderText = " I.S. NO."
        dataCriminalRecordsISNO.Name = "dataCriminalRecordsISNO"
        dataCriminalRecordsISNO.ReadOnly = True
        ' 
        ' dataCriminalRecordsRemarks
        ' 
        dataCriminalRecordsRemarks.DividerWidth = 1
        dataCriminalRecordsRemarks.FillWeight = 50F
        dataCriminalRecordsRemarks.HeaderText = "  REMARKS"
        dataCriminalRecordsRemarks.Name = "dataCriminalRecordsRemarks"
        dataCriminalRecordsRemarks.ReadOnly = True
        ' 
        ' dataCriminalRecordsBtnEdit
        ' 
        dataCriminalRecordsBtnEdit.DividerWidth = 1
        dataCriminalRecordsBtnEdit.FillWeight = 30.3328857F
        dataCriminalRecordsBtnEdit.HeaderText = ""
        dataCriminalRecordsBtnEdit.Name = "dataCriminalRecordsBtnEdit"
        dataCriminalRecordsBtnEdit.ReadOnly = True
        dataCriminalRecordsBtnEdit.Resizable = DataGridViewTriState.True
        dataCriminalRecordsBtnEdit.SortMode = DataGridViewColumnSortMode.Automatic
        dataCriminalRecordsBtnEdit.Text = "Edit"
        dataCriminalRecordsBtnEdit.ToolTipText = "Edit"
        dataCriminalRecordsBtnEdit.UseColumnTextForButtonValue = True
        ' 
        ' dataCriminalRecordsBtnDelete
        ' 
        dataCriminalRecordsBtnDelete.DividerWidth = 1
        dataCriminalRecordsBtnDelete.FillWeight = 30.3328857F
        dataCriminalRecordsBtnDelete.HeaderText = ""
        dataCriminalRecordsBtnDelete.Name = "dataCriminalRecordsBtnDelete"
        dataCriminalRecordsBtnDelete.ReadOnly = True
        dataCriminalRecordsBtnDelete.Resizable = DataGridViewTriState.True
        dataCriminalRecordsBtnDelete.SortMode = DataGridViewColumnSortMode.Automatic
        dataCriminalRecordsBtnDelete.Text = "Delete"
        dataCriminalRecordsBtnDelete.ToolTipText = "Delete"
        dataCriminalRecordsBtnDelete.UseColumnTextForButtonValue = True
        ' 
        ' txtCRSearch
        ' 
        txtCRSearch.Location = New Point(725, 8)
        txtCRSearch.Name = "txtCRSearch"
        txtCRSearch.PlaceholderText = "  Search..."
        txtCRSearch.Size = New Size(226, 29)
        txtCRSearch.TabIndex = 6
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnPoliceSearchRefresh)
        TabPage3.Controls.Add(btnPoliceAdd)
        TabPage3.Controls.Add(Panel7)
        TabPage3.Controls.Add(txtPoliceSearch)
        TabPage3.Location = New Point(4, 30)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(971, 475)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Police"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnPoliceSearchRefresh
        ' 
        btnPoliceSearchRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPoliceSearchRefresh.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPoliceSearchRefresh.Depth = 0
        btnPoliceSearchRefresh.HighEmphasis = True
        btnPoliceSearchRefresh.Icon = Nothing
        btnPoliceSearchRefresh.Location = New Point(955, 5)
        btnPoliceSearchRefresh.Margin = New Padding(4, 6, 4, 6)
        btnPoliceSearchRefresh.MaximumSize = New Size(75, 30)
        btnPoliceSearchRefresh.MinimumSize = New Size(75, 30)
        btnPoliceSearchRefresh.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnPoliceSearchRefresh.Name = "btnPoliceSearchRefresh"
        btnPoliceSearchRefresh.NoAccentTextColor = Color.Empty
        btnPoliceSearchRefresh.Size = New Size(75, 30)
        btnPoliceSearchRefresh.TabIndex = 11
        btnPoliceSearchRefresh.Text = "X"
        btnPoliceSearchRefresh.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnPoliceSearchRefresh.UseAccentColor = False
        btnPoliceSearchRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnPoliceAdd
        ' 
        btnPoliceAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPoliceAdd.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPoliceAdd.Depth = 0
        btnPoliceAdd.HighEmphasis = True
        btnPoliceAdd.Icon = Nothing
        btnPoliceAdd.Location = New Point(954, 434)
        btnPoliceAdd.Margin = New Padding(4, 6, 4, 6)
        btnPoliceAdd.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnPoliceAdd.Name = "btnPoliceAdd"
        btnPoliceAdd.NoAccentTextColor = Color.Empty
        btnPoliceAdd.Size = New Size(64, 36)
        btnPoliceAdd.TabIndex = 10
        btnPoliceAdd.Text = "Add"
        btnPoliceAdd.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnPoliceAdd.UseAccentColor = False
        btnPoliceAdd.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(dataPolice)
        Panel7.Location = New Point(3, 42)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1032, 292)
        Panel7.TabIndex = 9
        ' 
        ' dataPolice
        ' 
        dataPolice.AllowUserToAddRows = False
        dataPolice.AllowUserToDeleteRows = False
        dataPolice.AllowUserToResizeRows = False
        dataPolice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataPolice.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dataPolice.BorderStyle = BorderStyle.None
        dataPolice.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        dataPolice.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey800
        dataPolice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle17.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True
        dataPolice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        dataPolice.ColumnHeadersHeight = 56
        dataPolice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dataPolice.Columns.AddRange(New DataGridViewColumn() {dataPoliceID, dataPoliceFname, dataPoliceMname, dataPoliceLname, dataPoliceContactNo, dataPoliceRank, dataPolicePosition, dataPoliceBtnEdit, dataPoliceBtnDelete})
        DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = SystemColors.Window
        DataGridViewCellStyle18.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        DataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = DataGridViewTriState.False
        dataPolice.DefaultCellStyle = DataGridViewCellStyle18
        dataPolice.Depth = 0
        dataPolice.Dock = DockStyle.Fill
        dataPolice.EnableHeadersVisualStyles = False
        dataPolice.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        dataPolice.GridColor = Color.White
        dataPolice.Location = New Point(0, 0)
        dataPolice.MaximumSize = New Size(1032, 390)
        dataPolice.MinimumSize = New Size(1032, 390)
        dataPolice.MouseState = MaterialSkin2Framework.MouseState.HOVER
        dataPolice.Name = "dataPolice"
        dataPolice.ReadOnly = True
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = SystemColors.Control
        DataGridViewCellStyle19.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        DataGridViewCellStyle19.SelectionForeColor = Color.Black
        DataGridViewCellStyle19.WrapMode = DataGridViewTriState.True
        dataPolice.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        dataPolice.RowHeadersVisible = False
        DataGridViewCellStyle20.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        DataGridViewCellStyle20.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        dataPolice.RowsDefaultCellStyle = DataGridViewCellStyle20
        dataPolice.RowTemplate.Height = 52
        dataPolice.ScrollBars = ScrollBars.None
        dataPolice.ShowVerticalScroll = False
        dataPolice.Size = New Size(1032, 390)
        dataPolice.TabIndex = 8
        ' 
        ' dataPoliceID
        ' 
        dataPoliceID.DividerWidth = 1
        dataPoliceID.FillWeight = 50F
        dataPoliceID.HeaderText = "      ID"
        dataPoliceID.Name = "dataPoliceID"
        dataPoliceID.ReadOnly = True
        dataPoliceID.Resizable = DataGridViewTriState.True
        ' 
        ' dataPoliceFname
        ' 
        dataPoliceFname.DividerWidth = 1
        dataPoliceFname.HeaderText = "    FIRST NAME"
        dataPoliceFname.Name = "dataPoliceFname"
        dataPoliceFname.ReadOnly = True
        ' 
        ' dataPoliceMname
        ' 
        dataPoliceMname.DividerWidth = 1
        dataPoliceMname.FillWeight = 110F
        dataPoliceMname.HeaderText = "     MIDDLE NAME"
        dataPoliceMname.Name = "dataPoliceMname"
        dataPoliceMname.ReadOnly = True
        ' 
        ' dataPoliceLname
        ' 
        dataPoliceLname.DividerWidth = 1
        dataPoliceLname.HeaderText = "     LAST NAME"
        dataPoliceLname.Name = "dataPoliceLname"
        dataPoliceLname.ReadOnly = True
        ' 
        ' dataPoliceContactNo
        ' 
        dataPoliceContactNo.DividerWidth = 1
        dataPoliceContactNo.FillWeight = 80F
        dataPoliceContactNo.HeaderText = "CONTACT NUMBER"
        dataPoliceContactNo.Name = "dataPoliceContactNo"
        dataPoliceContactNo.ReadOnly = True
        ' 
        ' dataPoliceRank
        ' 
        dataPoliceRank.DividerWidth = 1
        dataPoliceRank.FillWeight = 60F
        dataPoliceRank.HeaderText = "    RANK"
        dataPoliceRank.Name = "dataPoliceRank"
        dataPoliceRank.ReadOnly = True
        ' 
        ' dataPolicePosition
        ' 
        dataPolicePosition.DividerWidth = 1
        dataPolicePosition.FillWeight = 80F
        dataPolicePosition.HeaderText = "    POSITION"
        dataPolicePosition.Name = "dataPolicePosition"
        dataPolicePosition.ReadOnly = True
        ' 
        ' dataPoliceBtnEdit
        ' 
        dataPoliceBtnEdit.DividerWidth = 1
        dataPoliceBtnEdit.FillWeight = 50F
        dataPoliceBtnEdit.HeaderText = ""
        dataPoliceBtnEdit.Name = "dataPoliceBtnEdit"
        dataPoliceBtnEdit.ReadOnly = True
        dataPoliceBtnEdit.Resizable = DataGridViewTriState.True
        dataPoliceBtnEdit.SortMode = DataGridViewColumnSortMode.Automatic
        dataPoliceBtnEdit.Text = "Edit"
        dataPoliceBtnEdit.ToolTipText = "Edit"
        dataPoliceBtnEdit.UseColumnTextForButtonValue = True
        ' 
        ' dataPoliceBtnDelete
        ' 
        dataPoliceBtnDelete.DividerWidth = 1
        dataPoliceBtnDelete.FillWeight = 50F
        dataPoliceBtnDelete.HeaderText = ""
        dataPoliceBtnDelete.Name = "dataPoliceBtnDelete"
        dataPoliceBtnDelete.ReadOnly = True
        dataPoliceBtnDelete.Resizable = DataGridViewTriState.True
        dataPoliceBtnDelete.SortMode = DataGridViewColumnSortMode.Automatic
        dataPoliceBtnDelete.Text = "Delete"
        dataPoliceBtnDelete.ToolTipText = "Delete"
        dataPoliceBtnDelete.UseColumnTextForButtonValue = True
        ' 
        ' txtPoliceSearch
        ' 
        txtPoliceSearch.Location = New Point(725, 8)
        txtPoliceSearch.Name = "txtPoliceSearch"
        txtPoliceSearch.PlaceholderText = "  Search..."
        txtPoliceSearch.Size = New Size(226, 29)
        txtPoliceSearch.TabIndex = 6
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnUsersSearchRefresh)
        TabPage2.Controls.Add(btnUsersAdd)
        TabPage2.Controls.Add(MaterialCard1)
        TabPage2.Controls.Add(txtUserSearch)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(971, 475)
        TabPage2.TabIndex = 1
        TabPage2.Text = "User"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnUsersSearchRefresh
        ' 
        btnUsersSearchRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnUsersSearchRefresh.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnUsersSearchRefresh.Depth = 0
        btnUsersSearchRefresh.HighEmphasis = True
        btnUsersSearchRefresh.Icon = Nothing
        btnUsersSearchRefresh.Location = New Point(959, 6)
        btnUsersSearchRefresh.Margin = New Padding(4, 6, 4, 6)
        btnUsersSearchRefresh.MaximumSize = New Size(75, 30)
        btnUsersSearchRefresh.MinimumSize = New Size(75, 30)
        btnUsersSearchRefresh.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnUsersSearchRefresh.Name = "btnUsersSearchRefresh"
        btnUsersSearchRefresh.NoAccentTextColor = Color.Empty
        btnUsersSearchRefresh.Size = New Size(75, 30)
        btnUsersSearchRefresh.TabIndex = 12
        btnUsersSearchRefresh.Text = "X"
        btnUsersSearchRefresh.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnUsersSearchRefresh.UseAccentColor = False
        btnUsersSearchRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnUsersAdd
        ' 
        btnUsersAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnUsersAdd.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnUsersAdd.Depth = 0
        btnUsersAdd.HighEmphasis = True
        btnUsersAdd.Icon = Nothing
        btnUsersAdd.Location = New Point(970, 419)
        btnUsersAdd.Margin = New Padding(4, 6, 4, 6)
        btnUsersAdd.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnUsersAdd.Name = "btnUsersAdd"
        btnUsersAdd.NoAccentTextColor = Color.Empty
        btnUsersAdd.Size = New Size(64, 36)
        btnUsersAdd.TabIndex = 8
        btnUsersAdd.Text = "Add"
        btnUsersAdd.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnUsersAdd.UseAccentColor = False
        btnUsersAdd.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(dataUser)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(0, 39)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(1038, 379)
        MaterialCard1.TabIndex = 7
        ' 
        ' dataUser
        ' 
        dataUser.AllowUserToAddRows = False
        dataUser.AllowUserToDeleteRows = False
        dataUser.AllowUserToResizeRows = False
        dataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataUser.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dataUser.BorderStyle = BorderStyle.None
        dataUser.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        dataUser.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey800
        dataUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle21.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = DataGridViewTriState.True
        dataUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        dataUser.ColumnHeadersHeight = 56
        dataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dataUser.Columns.AddRange(New DataGridViewColumn() {dataUserID, dataUserUname, dataUserFname, dataUserMname, dataUserLname, dataUserContactNo, dataUserUtype, dataUserBtnEdit, dataUserBtnDelete})
        DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = SystemColors.Window
        DataGridViewCellStyle22.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle22.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        DataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = DataGridViewTriState.False
        dataUser.DefaultCellStyle = DataGridViewCellStyle22
        dataUser.Depth = 0
        dataUser.Dock = DockStyle.Fill
        dataUser.EnableHeadersVisualStyles = False
        dataUser.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        dataUser.GridColor = Color.White
        dataUser.Location = New Point(14, 14)
        dataUser.MaximumSize = New Size(1010, 303)
        dataUser.MinimumSize = New Size(1010, 360)
        dataUser.MouseState = MaterialSkin2Framework.MouseState.HOVER
        dataUser.Name = "dataUser"
        dataUser.ReadOnly = True
        dataUser.RightToLeft = RightToLeft.No
        DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = SystemColors.Control
        DataGridViewCellStyle23.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle23.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        DataGridViewCellStyle23.SelectionForeColor = Color.Black
        DataGridViewCellStyle23.WrapMode = DataGridViewTriState.True
        dataUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        dataUser.RowHeadersVisible = False
        DataGridViewCellStyle24.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        DataGridViewCellStyle24.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        dataUser.RowsDefaultCellStyle = DataGridViewCellStyle24
        dataUser.RowTemplate.Height = 52
        dataUser.ScrollBars = ScrollBars.None
        dataUser.ShowVerticalScroll = False
        dataUser.Size = New Size(1010, 360)
        dataUser.TabIndex = 6
        ' 
        ' dataUserID
        ' 
        dataUserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataUserID.DividerWidth = 1
        dataUserID.FillWeight = 57.72114F
        dataUserID.Frozen = True
        dataUserID.HeaderText = "           ID"
        dataUserID.Name = "dataUserID"
        dataUserID.ReadOnly = True
        dataUserID.Resizable = DataGridViewTriState.True
        dataUserID.Width = 109
        ' 
        ' dataUserUname
        ' 
        dataUserUname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataUserUname.DividerWidth = 1
        dataUserUname.FillWeight = 65.18445F
        dataUserUname.Frozen = True
        dataUserUname.HeaderText = "  USERNAME"
        dataUserUname.MinimumWidth = 100
        dataUserUname.Name = "dataUserUname"
        dataUserUname.ReadOnly = True
        dataUserUname.Width = 122
        ' 
        ' dataUserFname
        ' 
        dataUserFname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataUserFname.DividerWidth = 1
        dataUserFname.FillWeight = 71.70289F
        dataUserFname.Frozen = True
        dataUserFname.HeaderText = "   FIRST NAME"
        dataUserFname.Name = "dataUserFname"
        dataUserFname.ReadOnly = True
        dataUserFname.Width = 135
        ' 
        ' dataUserMname
        ' 
        dataUserMname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataUserMname.DividerWidth = 1
        dataUserMname.FillWeight = 80F
        dataUserMname.Frozen = True
        dataUserMname.HeaderText = "   MIDDLE NAME"
        dataUserMname.MinimumWidth = 2
        dataUserMname.Name = "dataUserMname"
        dataUserMname.ReadOnly = True
        dataUserMname.Width = 150
        ' 
        ' dataUserLname
        ' 
        dataUserLname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataUserLname.DividerWidth = 1
        dataUserLname.FillWeight = 68F
        dataUserLname.Frozen = True
        dataUserLname.HeaderText = "  LAST NAME"
        dataUserLname.Name = "dataUserLname"
        dataUserLname.ReadOnly = True
        dataUserLname.Width = 128
        ' 
        ' dataUserContactNo
        ' 
        dataUserContactNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataUserContactNo.DividerWidth = 1
        dataUserContactNo.FillWeight = 71.70289F
        dataUserContactNo.HeaderText = "CONTACT NUMBER"
        dataUserContactNo.Name = "dataUserContactNo"
        dataUserContactNo.ReadOnly = True
        dataUserContactNo.ToolTipText = "CONTACT NUMBER"
        dataUserContactNo.Width = 135
        ' 
        ' dataUserUtype
        ' 
        dataUserUtype.DividerWidth = 1
        dataUserUtype.FillWeight = 57.72114F
        dataUserUtype.HeaderText = "USER ROLE"
        dataUserUtype.Name = "dataUserUtype"
        dataUserUtype.ReadOnly = True
        dataUserUtype.ToolTipText = " "
        ' 
        ' dataUserBtnEdit
        ' 
        dataUserBtnEdit.DividerWidth = 1
        dataUserBtnEdit.FillWeight = 32.5922241F
        dataUserBtnEdit.HeaderText = ""
        dataUserBtnEdit.Name = "dataUserBtnEdit"
        dataUserBtnEdit.ReadOnly = True
        dataUserBtnEdit.Resizable = DataGridViewTriState.True
        dataUserBtnEdit.SortMode = DataGridViewColumnSortMode.Automatic
        dataUserBtnEdit.Text = "Edit"
        dataUserBtnEdit.ToolTipText = "Edit"
        dataUserBtnEdit.UseColumnTextForButtonValue = True
        ' 
        ' dataUserBtnDelete
        ' 
        dataUserBtnDelete.DividerWidth = 1
        dataUserBtnDelete.FillWeight = 32.5922241F
        dataUserBtnDelete.HeaderText = ""
        dataUserBtnDelete.Name = "dataUserBtnDelete"
        dataUserBtnDelete.ReadOnly = True
        dataUserBtnDelete.Resizable = DataGridViewTriState.True
        dataUserBtnDelete.SortMode = DataGridViewColumnSortMode.Automatic
        dataUserBtnDelete.Text = "Delete"
        dataUserBtnDelete.ToolTipText = "Delete"
        dataUserBtnDelete.UseColumnTextForButtonValue = True
        ' 
        ' txtUserSearch
        ' 
        txtUserSearch.Location = New Point(726, 7)
        txtUserSearch.Name = "txtUserSearch"
        txtUserSearch.PlaceholderText = "  Search..."
        txtUserSearch.Size = New Size(226, 29)
        txtUserSearch.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel2)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(Panel9)
        TabPage1.Controls.Add(Panel8)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(971, 475)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(MaterialCard4)
        Panel1.Controls.Add(MaterialCard2)
        Panel1.Controls.Add(MaterialCard3)
        Panel1.Location = New Point(29, 131)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(918, 213)
        Panel1.TabIndex = 13
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.BorderStyle = BorderStyle.FixedSingle
        MaterialCard4.Controls.Add(Panel6)
        MaterialCard4.Controls.Add(Label3)
        MaterialCard4.Controls.Add(lblCRCount)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(618, 11)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(288, 177)
        MaterialCard4.TabIndex = 12
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.BackgroundImageLayout = ImageLayout.Zoom
        Panel6.Location = New Point(35, 36)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(42, 32)
        Panel6.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(81, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 30)
        Label3.TabIndex = 7
        Label3.Text = "Criminal Records"
        ' 
        ' lblCRCount
        ' 
        lblCRCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCRCount.AutoSize = True
        lblCRCount.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblCRCount.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        lblCRCount.Location = New Point(103, 71)
        lblCRCount.Name = "lblCRCount"
        lblCRCount.Size = New Size(80, 65)
        lblCRCount.TabIndex = 5
        lblCRCount.Text = "00"
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.BorderStyle = BorderStyle.FixedSingle
        MaterialCard2.Controls.Add(Panel4)
        MaterialCard2.Controls.Add(Label2)
        MaterialCard2.Controls.Add(lblUserCount)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(11, 11)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(288, 177)
        MaterialCard2.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Zoom
        Panel4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Panel4.Location = New Point(70, 33)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(30, 33)
        Panel4.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(106, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 40)
        Label2.TabIndex = 5
        Label2.Text = "User"
        ' 
        ' lblUserCount
        ' 
        lblUserCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUserCount.AutoSize = True
        lblUserCount.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblUserCount.ForeColor = Color.ForestGreen
        lblUserCount.Location = New Point(106, 71)
        lblUserCount.Name = "lblUserCount"
        lblUserCount.Size = New Size(80, 65)
        lblUserCount.TabIndex = 1
        lblUserCount.Text = "00"
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.BorderStyle = BorderStyle.FixedSingle
        MaterialCard3.Controls.Add(Panel5)
        MaterialCard3.Controls.Add(Label1)
        MaterialCard3.Controls.Add(lblPoliceCount)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(317, 11)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(288, 177)
        MaterialCard3.TabIndex = 11
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Zoom
        Panel5.Location = New Point(58, 36)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(42, 32)
        Panel5.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(97, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 40)
        Label1.TabIndex = 6
        Label1.Text = "Police"
        ' 
        ' lblPoliceCount
        ' 
        lblPoliceCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPoliceCount.AutoSize = True
        lblPoliceCount.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblPoliceCount.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblPoliceCount.Location = New Point(106, 71)
        lblPoliceCount.Name = "lblPoliceCount"
        lblPoliceCount.Size = New Size(80, 65)
        lblPoliceCount.TabIndex = 3
        lblPoliceCount.Text = "00"
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.DimGray
        Panel9.Location = New Point(40, 118)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(895, 4)
        Panel9.TabIndex = 9
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Zoom
        Panel8.Location = New Point(51, 42)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(55, 47)
        Panel8.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label4.Location = New Point(102, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 47)
        Label4.TabIndex = 7
        Label4.Text = "Dashboard"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage7)
        TabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.Location = New Point(13, 105)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(979, 509)
        TabControl1.TabIndex = 0
        ' 
        ' dataUserID2
        ' 
        dataUserID2.HeaderText = "ID"
        dataUserID2.Name = "dataUserID2"
        dataUserID2.ReadOnly = True
        dataUserID2.Width = 40
        ' 
        ' dataUserUtype2
        ' 
        dataUserUtype2.HeaderText = "User Role"
        dataUserUtype2.Name = "dataUserUtype2"
        dataUserUtype2.ReadOnly = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.DimGray
        Panel2.Location = New Point(40, 339)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(895, 4)
        Panel2.TabIndex = 10
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 628)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabPage7.ResumeLayout(False)
        TabPage7.PerformLayout()
        Panel10.ResumeLayout(False)
        CType(dataCR, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(dataPolice, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        MaterialCard1.ResumeLayout(False)
        CType(dataUser, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel1.ResumeLayout(False)
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents btnCRSearchRefresh As Button
    Friend WithEvents txtCRSearch As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtPoliceSearch As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnUserSearchRefresh As Button
    Friend WithEvents txtUserSearch As TextBox
    Friend WithEvents btnUserAdd As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCRCount As Label
    Friend WithEvents lblPoliceCount As Label
    Friend WithEvents lblUserCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dataUserID2 As DataGridViewTextBoxColumn
    Friend WithEvents dataUserUtype2 As DataGridViewTextBoxColumn
    Friend WithEvents dataUser As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents MaterialCard1 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents btnUsersAdd As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents dataPolice As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnPoliceAdd As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnPoliceSearchRefresh As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dataPoliceID As DataGridViewTextBoxColumn
    Friend WithEvents dataPoliceFname As DataGridViewTextBoxColumn
    Friend WithEvents dataPoliceMname As DataGridViewTextBoxColumn
    Friend WithEvents dataPoliceLname As DataGridViewTextBoxColumn
    Friend WithEvents dataPoliceContactNo As DataGridViewTextBoxColumn
    Friend WithEvents dataPoliceRank As DataGridViewTextBoxColumn
    Friend WithEvents dataPolicePosition As DataGridViewTextBoxColumn
    Friend WithEvents dataPoliceBtnEdit As DataGridViewButtonColumn
    Friend WithEvents dataPoliceBtnDelete As DataGridViewButtonColumn
    Friend WithEvents dataUserID As DataGridViewTextBoxColumn
    Friend WithEvents dataUserUname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserFname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserMname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserLname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserContactNo As DataGridViewTextBoxColumn
    Friend WithEvents dataUserUtype As DataGridViewTextBoxColumn
    Friend WithEvents dataUserBtnEdit As DataGridViewButtonColumn
    Friend WithEvents dataUserBtnDelete As DataGridViewButtonColumn
    Friend WithEvents Panel10 As Panel
    Friend WithEvents dataCR As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents btnCRAdd2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnCRAdd As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents dataCriminalRecordsID As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsFName As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsMName As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsLName As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsOffense As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsCCNo As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsISNO As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsRemarks As DataGridViewTextBoxColumn
    Friend WithEvents dataCriminalRecordsBtnEdit As DataGridViewButtonColumn
    Friend WithEvents dataCriminalRecordsBtnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUsersSearchRefresh As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnCRsSearchRefresh As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialCard2 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class

