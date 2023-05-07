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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Dim DataGridViewCellStyle121 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle122 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle123 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle124 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle125 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle126 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle127 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle128 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle129 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle130 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle131 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle132 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.MaterialCard6 = New MaterialSkin2Framework.Controls.MaterialCard()
        Me.dataCR = New MaterialSkin2Framework.Controls.MaterialDataTable()
        Me.dataCriminalRecordsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsOffense = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsCCNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsISNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCriminalRecordsBtnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataCriminalRecordsBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCRsSearchRefresh = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.btnCRAdd = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.txtCRSearch = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialCard5 = New MaterialSkin2Framework.Controls.MaterialCard()
        Me.dataPolice = New MaterialSkin2Framework.Controls.MaterialDataTable()
        Me.dataPoliceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPoliceFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPoliceMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPoliceLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPoliceContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPoliceRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPolicePosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPoliceBtnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataPoliceBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPoliceSearchRefresh = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.btnPoliceAdd = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.txtPoliceSearch = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialCard1 = New MaterialSkin2Framework.Controls.MaterialCard()
        Me.dataUser = New MaterialSkin2Framework.Controls.MaterialDataTable()
        Me.dataUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserUname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserUtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserBtnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataUserBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUsersSearchRefresh = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.btnUsersAdd = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.txtUserSearch = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialCard4 = New MaterialSkin2Framework.Controls.MaterialCard()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCRCount = New System.Windows.Forms.Label()
        Me.MaterialCard3 = New MaterialSkin2Framework.Controls.MaterialCard()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPoliceCount = New System.Windows.Forms.Label()
        Me.MaterialCard2 = New MaterialSkin2Framework.Controls.MaterialCard()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUserCount = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.dataUserID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserUtype2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        CType(Me.dataCR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.MaterialCard5.SuspendLayout()
        CType(Me.dataPolice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.dataUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 64)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(48, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 34)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Controls.Add(Me.MaterialCard6)
        Me.TabPage7.Controls.Add(Me.btnCRsSearchRefresh)
        Me.TabPage7.Controls.Add(Me.btnCRAdd)
        Me.TabPage7.Controls.Add(Me.txtCRSearch)
        Me.TabPage7.Location = New System.Drawing.Point(4, 30)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1223, 475)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Criminal Records"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'MaterialCard6
        '
        Me.MaterialCard6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.dataCR)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(14, 45)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(1202, 380)
        Me.MaterialCard6.TabIndex = 12
        '
        'dataCR
        '
        Me.dataCR.AllowUserToAddRows = False
        Me.dataCR.AllowUserToDeleteRows = False
        Me.dataCR.AllowUserToResizeRows = False
        Me.dataCR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataCR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataCR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataCR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dataCR.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey800
        Me.dataCR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle121.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle121.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle121.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle121.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle121.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle121.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle121.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle121
        Me.dataCR.ColumnHeadersHeight = 56
        Me.dataCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataCR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataCriminalRecordsID, Me.dataCriminalRecordsFName, Me.dataCriminalRecordsMName, Me.dataCriminalRecordsLName, Me.dataCriminalRecordsOffense, Me.dataCriminalRecordsCCNo, Me.dataCriminalRecordsISNO, Me.dataCriminalRecordsRemarks, Me.dataCriminalRecordsBtnEdit, Me.dataCriminalRecordsBtnDelete})
        DataGridViewCellStyle122.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle122.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle122.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle122.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle122.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle122.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle122.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCR.DefaultCellStyle = DataGridViewCellStyle122
        Me.dataCR.Depth = 0
        Me.dataCR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataCR.EnableHeadersVisualStyles = False
        Me.dataCR.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataCR.GridColor = System.Drawing.Color.White
        Me.dataCR.Location = New System.Drawing.Point(14, 14)
        Me.dataCR.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.dataCR.Name = "dataCR"
        Me.dataCR.ReadOnly = True
        DataGridViewCellStyle123.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle123.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle123.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle123.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle123.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle123.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle123.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCR.RowHeadersDefaultCellStyle = DataGridViewCellStyle123
        Me.dataCR.RowHeadersVisible = False
        DataGridViewCellStyle124.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle124.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dataCR.RowsDefaultCellStyle = DataGridViewCellStyle124
        Me.dataCR.RowTemplate.Height = 52
        Me.dataCR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataCR.ShowVerticalScroll = False
        Me.dataCR.Size = New System.Drawing.Size(1174, 352)
        Me.dataCR.TabIndex = 8
        '
        'dataCriminalRecordsID
        '
        Me.dataCriminalRecordsID.DividerWidth = 1
        Me.dataCriminalRecordsID.FillWeight = 30.33289!
        Me.dataCriminalRecordsID.HeaderText = "ID"
        Me.dataCriminalRecordsID.Name = "dataCriminalRecordsID"
        Me.dataCriminalRecordsID.ReadOnly = True
        Me.dataCriminalRecordsID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dataCriminalRecordsFName
        '
        Me.dataCriminalRecordsFName.DividerWidth = 1
        Me.dataCriminalRecordsFName.FillWeight = 60.66577!
        Me.dataCriminalRecordsFName.HeaderText = "FIRST NAME"
        Me.dataCriminalRecordsFName.Name = "dataCriminalRecordsFName"
        Me.dataCriminalRecordsFName.ReadOnly = True
        '
        'dataCriminalRecordsMName
        '
        Me.dataCriminalRecordsMName.DividerWidth = 1
        Me.dataCriminalRecordsMName.FillWeight = 66.73235!
        Me.dataCriminalRecordsMName.HeaderText = "MIDDLE NAME"
        Me.dataCriminalRecordsMName.Name = "dataCriminalRecordsMName"
        Me.dataCriminalRecordsMName.ReadOnly = True
        '
        'dataCriminalRecordsLName
        '
        Me.dataCriminalRecordsLName.DividerWidth = 1
        Me.dataCriminalRecordsLName.FillWeight = 60.66577!
        Me.dataCriminalRecordsLName.HeaderText = "LAST NAME"
        Me.dataCriminalRecordsLName.Name = "dataCriminalRecordsLName"
        Me.dataCriminalRecordsLName.ReadOnly = True
        '
        'dataCriminalRecordsOffense
        '
        Me.dataCriminalRecordsOffense.DividerWidth = 1
        Me.dataCriminalRecordsOffense.FillWeight = 50.0!
        Me.dataCriminalRecordsOffense.HeaderText = "CRIME/OFFENSE COMMITTED"
        Me.dataCriminalRecordsOffense.Name = "dataCriminalRecordsOffense"
        Me.dataCriminalRecordsOffense.ReadOnly = True
        '
        'dataCriminalRecordsCCNo
        '
        Me.dataCriminalRecordsCCNo.DividerWidth = 1
        Me.dataCriminalRecordsCCNo.FillWeight = 36.39946!
        Me.dataCriminalRecordsCCNo.HeaderText = "CRIMINAL CASE NO."
        Me.dataCriminalRecordsCCNo.Name = "dataCriminalRecordsCCNo"
        Me.dataCriminalRecordsCCNo.ReadOnly = True
        '
        'dataCriminalRecordsISNO
        '
        Me.dataCriminalRecordsISNO.DividerWidth = 1
        Me.dataCriminalRecordsISNO.FillWeight = 40.0!
        Me.dataCriminalRecordsISNO.HeaderText = " I.S. NO."
        Me.dataCriminalRecordsISNO.Name = "dataCriminalRecordsISNO"
        Me.dataCriminalRecordsISNO.ReadOnly = True
        '
        'dataCriminalRecordsRemarks
        '
        Me.dataCriminalRecordsRemarks.DividerWidth = 1
        Me.dataCriminalRecordsRemarks.FillWeight = 50.0!
        Me.dataCriminalRecordsRemarks.HeaderText = "REMARKS"
        Me.dataCriminalRecordsRemarks.Name = "dataCriminalRecordsRemarks"
        Me.dataCriminalRecordsRemarks.ReadOnly = True
        '
        'dataCriminalRecordsBtnEdit
        '
        Me.dataCriminalRecordsBtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataCriminalRecordsBtnEdit.DividerWidth = 1
        Me.dataCriminalRecordsBtnEdit.FillWeight = 30.33289!
        Me.dataCriminalRecordsBtnEdit.HeaderText = ""
        Me.dataCriminalRecordsBtnEdit.Name = "dataCriminalRecordsBtnEdit"
        Me.dataCriminalRecordsBtnEdit.ReadOnly = True
        Me.dataCriminalRecordsBtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCriminalRecordsBtnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataCriminalRecordsBtnEdit.Text = "Edit"
        Me.dataCriminalRecordsBtnEdit.ToolTipText = "Edit"
        Me.dataCriminalRecordsBtnEdit.UseColumnTextForButtonValue = True
        Me.dataCriminalRecordsBtnEdit.Width = 78
        '
        'dataCriminalRecordsBtnDelete
        '
        Me.dataCriminalRecordsBtnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataCriminalRecordsBtnDelete.DividerWidth = 1
        Me.dataCriminalRecordsBtnDelete.FillWeight = 30.33289!
        Me.dataCriminalRecordsBtnDelete.HeaderText = ""
        Me.dataCriminalRecordsBtnDelete.Name = "dataCriminalRecordsBtnDelete"
        Me.dataCriminalRecordsBtnDelete.ReadOnly = True
        Me.dataCriminalRecordsBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCriminalRecordsBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataCriminalRecordsBtnDelete.Text = "Delete"
        Me.dataCriminalRecordsBtnDelete.ToolTipText = "Delete"
        Me.dataCriminalRecordsBtnDelete.UseColumnTextForButtonValue = True
        Me.dataCriminalRecordsBtnDelete.Width = 78
        '
        'btnCRsSearchRefresh
        '
        Me.btnCRsSearchRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCRsSearchRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCRsSearchRefresh.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.btnCRsSearchRefresh.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnCRsSearchRefresh.Depth = 0
        Me.btnCRsSearchRefresh.HighEmphasis = True
        Me.btnCRsSearchRefresh.Icon = CType(resources.GetObject("btnCRsSearchRefresh.Icon"), System.Drawing.Image)
        Me.btnCRsSearchRefresh.Location = New System.Drawing.Point(1122, 4)
        Me.btnCRsSearchRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCRsSearchRefresh.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnCRsSearchRefresh.Name = "btnCRsSearchRefresh"
        Me.btnCRsSearchRefresh.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnCRsSearchRefresh.Size = New System.Drawing.Size(94, 36)
        Me.btnCRsSearchRefresh.TabIndex = 3
        Me.btnCRsSearchRefresh.Text = "Clear"
        Me.btnCRsSearchRefresh.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCRsSearchRefresh.UseAccentColor = False
        Me.btnCRsSearchRefresh.UseVisualStyleBackColor = True
        '
        'btnCRAdd
        '
        Me.btnCRAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCRAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCRAdd.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnCRAdd.Depth = 0
        Me.btnCRAdd.HighEmphasis = True
        Me.btnCRAdd.Icon = Nothing
        Me.btnCRAdd.Location = New System.Drawing.Point(1152, 434)
        Me.btnCRAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCRAdd.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnCRAdd.Name = "btnCRAdd"
        Me.btnCRAdd.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnCRAdd.Size = New System.Drawing.Size(64, 36)
        Me.btnCRAdd.TabIndex = 11
        Me.btnCRAdd.Text = "Add"
        Me.btnCRAdd.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCRAdd.UseAccentColor = False
        Me.btnCRAdd.UseVisualStyleBackColor = True
        '
        'txtCRSearch
        '
        Me.txtCRSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCRSearch.Location = New System.Drawing.Point(889, 7)
        Me.txtCRSearch.MaximumSize = New System.Drawing.Size(226, 29)
        Me.txtCRSearch.MinimumSize = New System.Drawing.Size(226, 29)
        Me.txtCRSearch.Name = "txtCRSearch"
        Me.txtCRSearch.PlaceholderText = "  Search..."
        Me.txtCRSearch.Size = New System.Drawing.Size(226, 29)
        Me.txtCRSearch.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MaterialCard5)
        Me.TabPage3.Controls.Add(Me.btnPoliceSearchRefresh)
        Me.TabPage3.Controls.Add(Me.btnPoliceAdd)
        Me.TabPage3.Controls.Add(Me.txtPoliceSearch)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1223, 475)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Police"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MaterialCard5
        '
        Me.MaterialCard5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.dataPolice)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(14, 45)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.Size = New System.Drawing.Size(1202, 380)
        Me.MaterialCard5.TabIndex = 12
        '
        'dataPolice
        '
        Me.dataPolice.AllowUserToAddRows = False
        Me.dataPolice.AllowUserToDeleteRows = False
        Me.dataPolice.AllowUserToResizeRows = False
        Me.dataPolice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataPolice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataPolice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataPolice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dataPolice.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey800
        Me.dataPolice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle125.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle125.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle125.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle125.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle125.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle125.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle125.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataPolice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle125
        Me.dataPolice.ColumnHeadersHeight = 56
        Me.dataPolice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataPolice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataPoliceID, Me.dataPoliceFname, Me.dataPoliceMname, Me.dataPoliceLname, Me.dataPoliceContactNo, Me.dataPoliceRank, Me.dataPolicePosition, Me.dataPoliceBtnEdit, Me.dataPoliceBtnDelete})
        DataGridViewCellStyle126.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle126.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle126.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle126.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle126.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle126.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle126.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataPolice.DefaultCellStyle = DataGridViewCellStyle126
        Me.dataPolice.Depth = 0
        Me.dataPolice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataPolice.EnableHeadersVisualStyles = False
        Me.dataPolice.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataPolice.GridColor = System.Drawing.Color.White
        Me.dataPolice.Location = New System.Drawing.Point(14, 14)
        Me.dataPolice.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.dataPolice.Name = "dataPolice"
        Me.dataPolice.ReadOnly = True
        DataGridViewCellStyle127.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle127.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle127.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle127.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle127.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle127.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle127.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataPolice.RowHeadersDefaultCellStyle = DataGridViewCellStyle127
        Me.dataPolice.RowHeadersVisible = False
        DataGridViewCellStyle128.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle128.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dataPolice.RowsDefaultCellStyle = DataGridViewCellStyle128
        Me.dataPolice.RowTemplate.Height = 52
        Me.dataPolice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataPolice.ShowVerticalScroll = False
        Me.dataPolice.Size = New System.Drawing.Size(1174, 352)
        Me.dataPolice.TabIndex = 11
        '
        'dataPoliceID
        '
        Me.dataPoliceID.DividerWidth = 1
        Me.dataPoliceID.FillWeight = 50.0!
        Me.dataPoliceID.HeaderText = "ID"
        Me.dataPoliceID.Name = "dataPoliceID"
        Me.dataPoliceID.ReadOnly = True
        Me.dataPoliceID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dataPoliceFname
        '
        Me.dataPoliceFname.DividerWidth = 1
        Me.dataPoliceFname.HeaderText = "FIRST NAME"
        Me.dataPoliceFname.Name = "dataPoliceFname"
        Me.dataPoliceFname.ReadOnly = True
        '
        'dataPoliceMname
        '
        Me.dataPoliceMname.DividerWidth = 1
        Me.dataPoliceMname.FillWeight = 110.0!
        Me.dataPoliceMname.HeaderText = "MIDDLE NAME"
        Me.dataPoliceMname.Name = "dataPoliceMname"
        Me.dataPoliceMname.ReadOnly = True
        '
        'dataPoliceLname
        '
        Me.dataPoliceLname.DividerWidth = 1
        Me.dataPoliceLname.HeaderText = "LAST NAME"
        Me.dataPoliceLname.Name = "dataPoliceLname"
        Me.dataPoliceLname.ReadOnly = True
        '
        'dataPoliceContactNo
        '
        Me.dataPoliceContactNo.DividerWidth = 1
        Me.dataPoliceContactNo.FillWeight = 80.0!
        Me.dataPoliceContactNo.HeaderText = "CONTACT NUMBER"
        Me.dataPoliceContactNo.Name = "dataPoliceContactNo"
        Me.dataPoliceContactNo.ReadOnly = True
        '
        'dataPoliceRank
        '
        Me.dataPoliceRank.DividerWidth = 1
        Me.dataPoliceRank.FillWeight = 60.0!
        Me.dataPoliceRank.HeaderText = "RANK"
        Me.dataPoliceRank.Name = "dataPoliceRank"
        Me.dataPoliceRank.ReadOnly = True
        '
        'dataPolicePosition
        '
        Me.dataPolicePosition.DividerWidth = 1
        Me.dataPolicePosition.FillWeight = 80.0!
        Me.dataPolicePosition.HeaderText = "POSITION"
        Me.dataPolicePosition.Name = "dataPolicePosition"
        Me.dataPolicePosition.ReadOnly = True
        '
        'dataPoliceBtnEdit
        '
        Me.dataPoliceBtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataPoliceBtnEdit.DividerWidth = 1
        Me.dataPoliceBtnEdit.FillWeight = 50.0!
        Me.dataPoliceBtnEdit.HeaderText = ""
        Me.dataPoliceBtnEdit.Name = "dataPoliceBtnEdit"
        Me.dataPoliceBtnEdit.ReadOnly = True
        Me.dataPoliceBtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataPoliceBtnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataPoliceBtnEdit.Text = "Edit"
        Me.dataPoliceBtnEdit.ToolTipText = "Edit"
        Me.dataPoliceBtnEdit.UseColumnTextForButtonValue = True
        Me.dataPoliceBtnEdit.Width = 87
        '
        'dataPoliceBtnDelete
        '
        Me.dataPoliceBtnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataPoliceBtnDelete.DividerWidth = 1
        Me.dataPoliceBtnDelete.FillWeight = 50.0!
        Me.dataPoliceBtnDelete.HeaderText = ""
        Me.dataPoliceBtnDelete.Name = "dataPoliceBtnDelete"
        Me.dataPoliceBtnDelete.ReadOnly = True
        Me.dataPoliceBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataPoliceBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataPoliceBtnDelete.Text = "Delete"
        Me.dataPoliceBtnDelete.ToolTipText = "Delete"
        Me.dataPoliceBtnDelete.UseColumnTextForButtonValue = True
        Me.dataPoliceBtnDelete.Width = 86
        '
        'btnPoliceSearchRefresh
        '
        Me.btnPoliceSearchRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPoliceSearchRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPoliceSearchRefresh.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.btnPoliceSearchRefresh.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnPoliceSearchRefresh.Depth = 0
        Me.btnPoliceSearchRefresh.HighEmphasis = True
        Me.btnPoliceSearchRefresh.Icon = CType(resources.GetObject("btnPoliceSearchRefresh.Icon"), System.Drawing.Image)
        Me.btnPoliceSearchRefresh.Location = New System.Drawing.Point(1122, 4)
        Me.btnPoliceSearchRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPoliceSearchRefresh.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnPoliceSearchRefresh.Name = "btnPoliceSearchRefresh"
        Me.btnPoliceSearchRefresh.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPoliceSearchRefresh.Size = New System.Drawing.Size(94, 36)
        Me.btnPoliceSearchRefresh.TabIndex = 2
        Me.btnPoliceSearchRefresh.Text = "Clear"
        Me.btnPoliceSearchRefresh.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPoliceSearchRefresh.UseAccentColor = False
        Me.btnPoliceSearchRefresh.UseVisualStyleBackColor = True
        '
        'btnPoliceAdd
        '
        Me.btnPoliceAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPoliceAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPoliceAdd.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnPoliceAdd.Depth = 0
        Me.btnPoliceAdd.HighEmphasis = True
        Me.btnPoliceAdd.Icon = Nothing
        Me.btnPoliceAdd.Location = New System.Drawing.Point(1152, 434)
        Me.btnPoliceAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPoliceAdd.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnPoliceAdd.Name = "btnPoliceAdd"
        Me.btnPoliceAdd.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPoliceAdd.Size = New System.Drawing.Size(64, 36)
        Me.btnPoliceAdd.TabIndex = 10
        Me.btnPoliceAdd.Text = "Add"
        Me.btnPoliceAdd.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnPoliceAdd.UseAccentColor = False
        Me.btnPoliceAdd.UseVisualStyleBackColor = True
        '
        'txtPoliceSearch
        '
        Me.txtPoliceSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPoliceSearch.Location = New System.Drawing.Point(889, 7)
        Me.txtPoliceSearch.MaximumSize = New System.Drawing.Size(226, 29)
        Me.txtPoliceSearch.MinimumSize = New System.Drawing.Size(226, 29)
        Me.txtPoliceSearch.Name = "txtPoliceSearch"
        Me.txtPoliceSearch.PlaceholderText = "  Search..."
        Me.txtPoliceSearch.Size = New System.Drawing.Size(226, 29)
        Me.txtPoliceSearch.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MaterialCard1)
        Me.TabPage2.Controls.Add(Me.btnUsersSearchRefresh)
        Me.TabPage2.Controls.Add(Me.btnUsersAdd)
        Me.TabPage2.Controls.Add(Me.txtUserSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1223, 475)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.dataUser)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(14, 45)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(1202, 380)
        Me.MaterialCard1.TabIndex = 9
        '
        'dataUser
        '
        Me.dataUser.AllowUserToAddRows = False
        Me.dataUser.AllowUserToDeleteRows = False
        Me.dataUser.AllowUserToResizeRows = False
        Me.dataUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dataUser.CellSelectionPrimaryColor = MaterialSkin2Framework.Primary.Grey800
        Me.dataUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle129.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle129.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle129.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle129.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle129.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle129.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle129.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle129
        Me.dataUser.ColumnHeadersHeight = 56
        Me.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataUserID, Me.dataUserUname, Me.dataUserFname, Me.dataUserMname, Me.dataUserLname, Me.dataUserContactNo, Me.dataUserUtype, Me.dataUserBtnEdit, Me.dataUserBtnDelete})
        DataGridViewCellStyle130.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle130.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle130.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle130.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle130.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle130.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle130.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataUser.DefaultCellStyle = DataGridViewCellStyle130
        Me.dataUser.Depth = 0
        Me.dataUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataUser.EnableHeadersVisualStyles = False
        Me.dataUser.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataUser.GridColor = System.Drawing.Color.White
        Me.dataUser.Location = New System.Drawing.Point(14, 14)
        Me.dataUser.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.dataUser.Name = "dataUser"
        Me.dataUser.ReadOnly = True
        Me.dataUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle131.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle131.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle131.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle131.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle131.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle131.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle131.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle131
        Me.dataUser.RowHeadersVisible = False
        DataGridViewCellStyle132.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle132.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dataUser.RowsDefaultCellStyle = DataGridViewCellStyle132
        Me.dataUser.RowTemplate.Height = 52
        Me.dataUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataUser.ShowVerticalScroll = False
        Me.dataUser.Size = New System.Drawing.Size(1174, 352)
        Me.dataUser.TabIndex = 3
        '
        'dataUserID
        '
        Me.dataUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataUserID.DividerWidth = 1
        Me.dataUserID.FillWeight = 57.72114!
        Me.dataUserID.Frozen = True
        Me.dataUserID.HeaderText = "ID"
        Me.dataUserID.Name = "dataUserID"
        Me.dataUserID.ReadOnly = True
        Me.dataUserID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUserID.Width = 109
        '
        'dataUserUname
        '
        Me.dataUserUname.DividerWidth = 1
        Me.dataUserUname.FillWeight = 65.18445!
        Me.dataUserUname.HeaderText = "USERNAME"
        Me.dataUserUname.MinimumWidth = 100
        Me.dataUserUname.Name = "dataUserUname"
        Me.dataUserUname.ReadOnly = True
        '
        'dataUserFname
        '
        Me.dataUserFname.DividerWidth = 1
        Me.dataUserFname.FillWeight = 71.70289!
        Me.dataUserFname.HeaderText = "FIRST NAME"
        Me.dataUserFname.Name = "dataUserFname"
        Me.dataUserFname.ReadOnly = True
        '
        'dataUserMname
        '
        Me.dataUserMname.DividerWidth = 1
        Me.dataUserMname.FillWeight = 80.0!
        Me.dataUserMname.HeaderText = "MIDDLE NAME"
        Me.dataUserMname.MinimumWidth = 2
        Me.dataUserMname.Name = "dataUserMname"
        Me.dataUserMname.ReadOnly = True
        '
        'dataUserLname
        '
        Me.dataUserLname.DividerWidth = 1
        Me.dataUserLname.FillWeight = 68.0!
        Me.dataUserLname.HeaderText = "LAST NAME"
        Me.dataUserLname.Name = "dataUserLname"
        Me.dataUserLname.ReadOnly = True
        '
        'dataUserContactNo
        '
        Me.dataUserContactNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataUserContactNo.DividerWidth = 1
        Me.dataUserContactNo.FillWeight = 71.70289!
        Me.dataUserContactNo.HeaderText = "CONTACT NUMBER"
        Me.dataUserContactNo.Name = "dataUserContactNo"
        Me.dataUserContactNo.ReadOnly = True
        Me.dataUserContactNo.ToolTipText = "CONTACT NUMBER"
        Me.dataUserContactNo.Width = 135
        '
        'dataUserUtype
        '
        Me.dataUserUtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataUserUtype.DividerWidth = 1
        Me.dataUserUtype.FillWeight = 57.72114!
        Me.dataUserUtype.HeaderText = "USER ROLE"
        Me.dataUserUtype.Name = "dataUserUtype"
        Me.dataUserUtype.ReadOnly = True
        Me.dataUserUtype.ToolTipText = " "
        Me.dataUserUtype.Width = 186
        '
        'dataUserBtnEdit
        '
        Me.dataUserBtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataUserBtnEdit.DividerWidth = 1
        Me.dataUserBtnEdit.FillWeight = 32.59222!
        Me.dataUserBtnEdit.HeaderText = ""
        Me.dataUserBtnEdit.Name = "dataUserBtnEdit"
        Me.dataUserBtnEdit.ReadOnly = True
        Me.dataUserBtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUserBtnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataUserBtnEdit.Text = "Edit"
        Me.dataUserBtnEdit.ToolTipText = "Edit"
        Me.dataUserBtnEdit.UseColumnTextForButtonValue = True
        Me.dataUserBtnEdit.Width = 104
        '
        'dataUserBtnDelete
        '
        Me.dataUserBtnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataUserBtnDelete.DividerWidth = 1
        Me.dataUserBtnDelete.FillWeight = 32.59222!
        Me.dataUserBtnDelete.HeaderText = ""
        Me.dataUserBtnDelete.Name = "dataUserBtnDelete"
        Me.dataUserBtnDelete.ReadOnly = True
        Me.dataUserBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUserBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataUserBtnDelete.Text = "Delete"
        Me.dataUserBtnDelete.ToolTipText = "Delete"
        Me.dataUserBtnDelete.UseColumnTextForButtonValue = True
        Me.dataUserBtnDelete.Width = 105
        '
        'btnUsersSearchRefresh
        '
        Me.btnUsersSearchRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsersSearchRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUsersSearchRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUsersSearchRefresh.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.btnUsersSearchRefresh.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUsersSearchRefresh.Depth = 0
        Me.btnUsersSearchRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsersSearchRefresh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUsersSearchRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUsersSearchRefresh.HighEmphasis = True
        Me.btnUsersSearchRefresh.Icon = CType(resources.GetObject("btnUsersSearchRefresh.Icon"), System.Drawing.Image)
        Me.btnUsersSearchRefresh.Location = New System.Drawing.Point(1122, 4)
        Me.btnUsersSearchRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsersSearchRefresh.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnUsersSearchRefresh.Name = "btnUsersSearchRefresh"
        Me.btnUsersSearchRefresh.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUsersSearchRefresh.Size = New System.Drawing.Size(94, 36)
        Me.btnUsersSearchRefresh.TabIndex = 2
        Me.btnUsersSearchRefresh.Text = "Clear"
        Me.btnUsersSearchRefresh.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUsersSearchRefresh.UseAccentColor = False
        Me.btnUsersSearchRefresh.UseVisualStyleBackColor = True
        '
        'btnUsersAdd
        '
        Me.btnUsersAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsersAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUsersAdd.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUsersAdd.Depth = 0
        Me.btnUsersAdd.HighEmphasis = True
        Me.btnUsersAdd.Icon = Nothing
        Me.btnUsersAdd.Location = New System.Drawing.Point(1152, 434)
        Me.btnUsersAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUsersAdd.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnUsersAdd.Name = "btnUsersAdd"
        Me.btnUsersAdd.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUsersAdd.Size = New System.Drawing.Size(64, 36)
        Me.btnUsersAdd.TabIndex = 8
        Me.btnUsersAdd.Text = "Add"
        Me.btnUsersAdd.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUsersAdd.UseAccentColor = False
        Me.btnUsersAdd.UseVisualStyleBackColor = True
        '
        'txtUserSearch
        '
        Me.txtUserSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserSearch.Location = New System.Drawing.Point(889, 7)
        Me.txtUserSearch.MaximumSize = New System.Drawing.Size(226, 29)
        Me.txtUserSearch.MinimumSize = New System.Drawing.Size(226, 29)
        Me.txtUserSearch.Name = "txtUserSearch"
        Me.txtUserSearch.PlaceholderText = "  Search..."
        Me.txtUserSearch.Size = New System.Drawing.Size(226, 29)
        Me.txtUserSearch.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1223, 475)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(36, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1160, 4)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.MaterialCard4)
        Me.Panel1.Controls.Add(Me.MaterialCard3)
        Me.Panel1.Controls.Add(Me.MaterialCard2)
        Me.Panel1.Location = New System.Drawing.Point(29, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 209)
        Me.Panel1.TabIndex = 13
        '
        'MaterialCard4
        '
        Me.MaterialCard4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaterialCard4.Controls.Add(Me.Panel6)
        Me.MaterialCard4.Controls.Add(Me.Label3)
        Me.MaterialCard4.Controls.Add(Me.lblCRCount)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(848, 14)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(20, 14, 20, 14)
        Me.MaterialCard4.MinimumSize = New System.Drawing.Size(288, 177)
        Me.MaterialCard4.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialCard4.Size = New System.Drawing.Size(297, 177)
        Me.MaterialCard4.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel6.Location = New System.Drawing.Point(44, 36)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(42, 32)
        Me.Panel6.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(90, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Criminal Records"
        '
        'lblCRCount
        '
        Me.lblCRCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCRCount.AutoSize = True
        Me.lblCRCount.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCRCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCRCount.Location = New System.Drawing.Point(112, 71)
        Me.lblCRCount.Name = "lblCRCount"
        Me.lblCRCount.Size = New System.Drawing.Size(80, 65)
        Me.lblCRCount.TabIndex = 5
        Me.lblCRCount.Text = "00"
        '
        'MaterialCard3
        '
        Me.MaterialCard3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaterialCard3.Controls.Add(Me.Panel5)
        Me.MaterialCard3.Controls.Add(Me.Label1)
        Me.MaterialCard3.Controls.Add(Me.lblPoliceCount)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(440, 14)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MaximumSize = New System.Drawing.Size(288, 177)
        Me.MaterialCard3.MinimumSize = New System.Drawing.Size(288, 177)
        Me.MaterialCard3.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(288, 177)
        Me.MaterialCard3.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(58, 36)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(42, 32)
        Me.Panel5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(97, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Police"
        '
        'lblPoliceCount
        '
        Me.lblPoliceCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoliceCount.AutoSize = True
        Me.lblPoliceCount.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPoliceCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPoliceCount.Location = New System.Drawing.Point(106, 71)
        Me.lblPoliceCount.Name = "lblPoliceCount"
        Me.lblPoliceCount.Size = New System.Drawing.Size(80, 65)
        Me.lblPoliceCount.TabIndex = 3
        Me.lblPoliceCount.Text = "00"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaterialCard2.Controls.Add(Me.Panel4)
        Me.MaterialCard2.Controls.Add(Me.Label2)
        Me.MaterialCard2.Controls.Add(Me.lblUserCount)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(33, 14)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MaximumSize = New System.Drawing.Size(288, 177)
        Me.MaterialCard2.MinimumSize = New System.Drawing.Size(288, 177)
        Me.MaterialCard2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(288, 177)
        Me.MaterialCard2.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel4.Location = New System.Drawing.Point(70, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(30, 33)
        Me.Panel4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(106, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 40)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User"
        '
        'lblUserCount
        '
        Me.lblUserCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserCount.AutoSize = True
        Me.lblUserCount.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUserCount.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblUserCount.Location = New System.Drawing.Point(106, 71)
        Me.lblUserCount.Name = "lblUserCount"
        Me.lblUserCount.Size = New System.Drawing.Size(80, 65)
        Me.lblUserCount.TabIndex = 1
        Me.lblUserCount.Text = "00"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.DimGray
        Me.Panel9.Location = New System.Drawing.Point(36, 118)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1160, 4)
        Me.Panel9.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel8.Location = New System.Drawing.Point(51, 42)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(55, 47)
        Me.Panel8.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(102, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 47)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dashboard"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(13, 105)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1231, 509)
        Me.TabControl1.TabIndex = 1
        '
        'dataUserID2
        '
        Me.dataUserID2.HeaderText = "ID"
        Me.dataUserID2.Name = "dataUserID2"
        Me.dataUserID2.ReadOnly = True
        Me.dataUserID2.Width = 40
        '
        'dataUserUtype2
        '
        Me.dataUserUtype2.HeaderText = "User Role"
        Me.dataUserUtype2.Name = "dataUserUtype2"
        Me.dataUserUtype2.ReadOnly = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 620)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.MaterialCard6.ResumeLayout(False)
        CType(Me.dataCR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.MaterialCard5.ResumeLayout(False)
        CType(Me.dataPolice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.dataUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnUsersAdd As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnPoliceAdd As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnPoliceSearchRefresh As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dataCR As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents btnCRAdd2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnCRAdd As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnUsersSearchRefresh As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents btnCRsSearchRefresh As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialCard2 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dataPolice As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents dataUser As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents MaterialCard5 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents MaterialCard1 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents MaterialCard6 As MaterialSkin2Framework.Controls.MaterialCard
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
End Class

