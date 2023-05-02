<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Police
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Police))
        txtMname = New TextBox()
        txtFname = New TextBox()
        txtLname = New TextBox()
        cbRank = New ComboBox()
        Label4 = New Label()
        txtContactNo = New TextBox()
        Label13 = New Label()
        cbPosition = New ComboBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        Panel8 = New Panel()
        Panel1 = New Panel()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel3 = New Panel()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel4 = New Panel()
        MaterialButton3 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel6 = New Panel()
        MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Label1 = New Label()
        Panel5 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtMname
        ' 
        txtMname.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMname.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtMname.Location = New Point(245, 144)
        txtMname.MaximumSize = New Size(197, 25)
        txtMname.MinimumSize = New Size(197, 25)
        txtMname.Multiline = True
        txtMname.Name = "txtMname"
        txtMname.PlaceholderText = " Middle Name*"
        txtMname.Size = New Size(197, 25)
        txtMname.TabIndex = 11
        ' 
        ' txtFname
        ' 
        txtFname.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFname.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFname.Location = New Point(245, 89)
        txtFname.Margin = New Padding(10)
        txtFname.MaximumSize = New Size(197, 25)
        txtFname.MinimumSize = New Size(197, 25)
        txtFname.Multiline = True
        txtFname.Name = "txtFname"
        txtFname.PlaceholderText = " First Name*"
        txtFname.Size = New Size(197, 25)
        txtFname.TabIndex = 10
        ' 
        ' txtLname
        ' 
        txtLname.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtLname.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLname.Location = New Point(245, 194)
        txtLname.MaximumSize = New Size(197, 25)
        txtLname.MinimumSize = New Size(197, 25)
        txtLname.Multiline = True
        txtLname.Name = "txtLname"
        txtLname.PlaceholderText = " Last Name*"
        txtLname.Size = New Size(197, 25)
        txtLname.TabIndex = 8
        ' 
        ' cbRank
        ' 
        cbRank.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbRank.FormattingEnabled = True
        cbRank.Location = New Point(245, 294)
        cbRank.MaximumSize = New Size(197, 0)
        cbRank.MinimumSize = New Size(197, 0)
        cbRank.Name = "cbRank"
        cbRank.Size = New Size(197, 23)
        cbRank.TabIndex = 44
        cbRank.Tag = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(245, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 17)
        Label4.TabIndex = 43
        Label4.Text = "Rank"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtContactNo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtContactNo.Location = New Point(245, 245)
        txtContactNo.MaximumSize = New Size(197, 25)
        txtContactNo.MinimumSize = New Size(197, 25)
        txtContactNo.Multiline = True
        txtContactNo.Name = "txtContactNo"
        txtContactNo.PlaceholderText = " Contact #"
        txtContactNo.Size = New Size(197, 25)
        txtContactNo.TabIndex = 42
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(245, 225)
        Label13.Name = "Label13"
        Label13.Size = New Size(109, 17)
        Label13.TabIndex = 41
        Label13.Text = "Contact Number"
        ' 
        ' cbPosition
        ' 
        cbPosition.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbPosition.FormattingEnabled = True
        cbPosition.Location = New Point(245, 340)
        cbPosition.MaximumSize = New Size(197, 0)
        cbPosition.MinimumSize = New Size(197, 0)
        cbPosition.Name = "cbPosition"
        cbPosition.Size = New Size(197, 23)
        cbPosition.TabIndex = 46
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(245, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 17)
        Label2.TabIndex = 45
        Label2.Text = "Position"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Location = New Point(20, 82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(190, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(37, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 50
        Label3.Text = "Police Signature"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(245, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 17)
        Label5.TabIndex = 52
        Label5.Text = "Middle Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(245, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 17)
        Label6.TabIndex = 53
        Label6.Text = "Last Name"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.AutoSize = True
        Panel2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Panel8)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(463, 51)
        Panel2.TabIndex = 54
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(173, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 30)
        Label7.TabIndex = 46
        Label7.Text = "Add Police"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Zoom
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(18, 8)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(50, 40)
        Panel8.TabIndex = 60
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(MaterialButton1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(135, 398)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 33)
        Panel1.TabIndex = 55
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.BackColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
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
        MaterialButton1.MaximumSize = New Size(75, 33)
        MaterialButton1.MinimumSize = New Size(75, 33)
        MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(75, 33)
        MaterialButton1.TabIndex = 53
        MaterialButton1.Text = "Save"
        MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel3.Controls.Add(CancelButton)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(261, 398)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 33)
        Panel3.TabIndex = 56
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CancelButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        CancelButton.Depth = 0
        CancelButton.HighEmphasis = False
        CancelButton.Icon = Nothing
        CancelButton.Location = New Point(0, 0)
        CancelButton.Margin = New Padding(4, 6, 4, 6)
        CancelButton.MaximumSize = New Size(75, 33)
        CancelButton.MinimumSize = New Size(75, 33)
        CancelButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        CancelButton.Name = "CancelButton"
        CancelButton.NoAccentTextColor = Color.Empty
        CancelButton.Size = New Size(75, 33)
        CancelButton.TabIndex = 55
        CancelButton.Text = "Cancel"
        CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        CancelButton.UseAccentColor = False
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel4.Controls.Add(MaterialButton3)
        Panel4.Location = New Point(80, 303)
        Panel4.MaximumSize = New Size(73, 26)
        Panel4.MinimumSize = New Size(73, 26)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(73, 26)
        Panel4.TabIndex = 58
        ' 
        ' MaterialButton3
        ' 
        MaterialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton3.BackColor = Color.FromArgb(CByte(13), CByte(86), CByte(147))
        MaterialButton3.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
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
        MaterialButton3.MaximumSize = New Size(73, 26)
        MaterialButton3.MinimumSize = New Size(73, 26)
        MaterialButton3.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton3.Name = "MaterialButton3"
        MaterialButton3.NoAccentTextColor = Color.Empty
        MaterialButton3.Size = New Size(73, 26)
        MaterialButton3.TabIndex = 54
        MaterialButton3.Text = "Upload"
        MaterialButton3.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        MaterialButton3.UseAccentColor = False
        MaterialButton3.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel6.AutoSize = True
        Panel6.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel6.Controls.Add(Label3)
        Panel6.Location = New Point(20, 253)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(190, 38)
        Panel6.TabIndex = 56
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-1, 386)
        MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(463, 3)
        MaterialDivider1.TabIndex = 59
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' MaterialDivider2
        ' 
        MaterialDivider2.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider2.Depth = 0
        MaterialDivider2.Location = New Point(17, 62)
        MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider2.Name = "MaterialDivider2"
        MaterialDivider2.Size = New Size(426, 3)
        MaterialDivider2.TabIndex = 61
        MaterialDivider2.Text = "MaterialDivider2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(245, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 17)
        Label1.TabIndex = 9
        Label1.Text = "First Name"
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.AutoSize = True
        Panel5.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel5.Location = New Point(-1, 442)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(466, 10)
        Panel5.TabIndex = 55
        ' 
        ' Police
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 448)
        ControlBox = False
        Controls.Add(Panel5)
        Controls.Add(MaterialDivider2)
        Controls.Add(MaterialDivider1)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(cbPosition)
        Controls.Add(Label2)
        Controls.Add(cbRank)
        Controls.Add(Label4)
        Controls.Add(txtContactNo)
        Controls.Add(Label13)
        Controls.Add(txtMname)
        Controls.Add(txtFname)
        Controls.Add(Label1)
        Controls.Add(txtLname)
        Name = "Police"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Police"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents cbRank As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaterialButton3 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents Panel8 As Panel
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
End Class
