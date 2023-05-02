<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cashier))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        chbAll = New CheckBox()
        MaterialCard1 = New MaterialSkin2Framework.Controls.MaterialCard()
        DataGridView1 = New MaterialSkin2Framework.Controls.MaterialDataTable()
        ClearanceCheckBox = New DataGridViewCheckBoxColumn()
        ClearanceID = New DataGridViewTextBoxColumn()
        ClearanceNo = New DataGridViewTextBoxColumn()
        ClearanceFname = New DataGridViewTextBoxColumn()
        ClearanceMname = New DataGridViewTextBoxColumn()
        ClearanceLname = New DataGridViewTextBoxColumn()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin2Framework.Controls.MaterialButton()
        MenuStrip1.SuspendLayout()
        MaterialCard1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(3, 64)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1039, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        FileToolStripMenuItem.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(44, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), Image)
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(118, 22)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(678, 94)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "  Search..."
        TextBox1.Size = New Size(279, 28)
        TextBox1.TabIndex = 3
        ' 
        ' chbAll
        ' 
        chbAll.AutoSize = True
        chbAll.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        chbAll.Location = New Point(15, 98)
        chbAll.Name = "chbAll"
        chbAll.Size = New Size(79, 21)
        chbAll.TabIndex = 145
        chbAll.Text = "Select All"
        chbAll.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(DataGridView1)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(15, 125)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(1027, 319)
        MaterialCard1.TabIndex = 146
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 56
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ClearanceCheckBox, ClearanceID, ClearanceNo, ClearanceFname, ClearanceMname, ClearanceLname})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(25), CByte(118), CByte(210))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Depth = 0
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridView1.GridColor = Color.FromArgb(CByte(239), CByte(239), CByte(239))
        DataGridView1.Location = New Point(14, 14)
        DataGridView1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowTemplate.Height = 52
        DataGridView1.ScrollBars = ScrollBars.None
        DataGridView1.ShowVerticalScroll = False
        DataGridView1.Size = New Size(999, 291)
        DataGridView1.TabIndex = 0
        ' 
        ' ClearanceCheckBox
        ' 
        ClearanceCheckBox.DividerWidth = 1
        ClearanceCheckBox.FillWeight = 40F
        ClearanceCheckBox.HeaderText = ""
        ClearanceCheckBox.Name = "ClearanceCheckBox"
        ClearanceCheckBox.Resizable = DataGridViewTriState.True
        ' 
        ' ClearanceID
        ' 
        ClearanceID.DividerWidth = 1
        ClearanceID.HeaderText = "    Clearance ID"
        ClearanceID.Name = "ClearanceID"
        ' 
        ' ClearanceNo
        ' 
        ClearanceNo.DividerWidth = 1
        ClearanceNo.HeaderText = "    Clearance Number"
        ClearanceNo.Name = "ClearanceNo"
        ' 
        ' ClearanceFname
        ' 
        ClearanceFname.DividerWidth = 1
        ClearanceFname.HeaderText = "    First Name"
        ClearanceFname.Name = "ClearanceFname"
        ' 
        ' ClearanceMname
        ' 
        ClearanceMname.DividerWidth = 1
        ClearanceMname.HeaderText = "   Middle Name"
        ClearanceMname.Name = "ClearanceMname"
        ' 
        ' ClearanceLname
        ' 
        ClearanceLname.DividerWidth = 1
        ClearanceLname.HeaderText = "   Last Name"
        ClearanceLname.Name = "ClearanceLname"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = CType(resources.GetObject("MaterialButton1.Icon"), Image)
        MaterialButton1.Location = New Point(964, 94)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MaximumSize = New Size(64, 28)
        MaterialButton1.MinimumSize = New Size(64, 28)
        MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(64, 28)
        MaterialButton1.TabIndex = 147
        MaterialButton1.Text = "Clear"
        MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(947, 454)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MaximumSize = New Size(81, 30)
        MaterialButton2.MinimumSize = New Size(81, 33)
        MaterialButton2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(81, 33)
        MaterialButton2.TabIndex = 148
        MaterialButton2.Text = "Confirm"
        MaterialButton2.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' Cashier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1045, 496)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialCard1)
        Controls.Add(chbAll)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Cashier"
        PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cashier"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        MaterialCard1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents chbAll As CheckBox
    Friend WithEvents MaterialCard1 As MaterialSkin2Framework.Controls.MaterialCard
    Friend WithEvents DataGridView1 As MaterialSkin2Framework.Controls.MaterialDataTable
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents ClearanceCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents ClearanceID As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceNo As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceFname As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceMname As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceLname As DataGridViewTextBoxColumn
End Class
