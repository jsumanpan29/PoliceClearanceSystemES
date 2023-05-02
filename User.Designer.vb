<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(User))
        txtMname = New TextBox()
        txtFname = New TextBox()
        Label1 = New Label()
        txtLname = New TextBox()
        txtContactNo = New TextBox()
        Label13 = New Label()
        txtUname = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        cbUsertype = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel8 = New Panel()
        Panel2 = New Panel()
        MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Panel3 = New Panel()
        MaterialButton2 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel1 = New Panel()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtMname
        ' 
        txtMname.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        txtMname.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtMname.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtMname.Location = New Point(11, 137)
        txtMname.Name = "txtMname"
        txtMname.PlaceholderText = " Middle Name"
        txtMname.Size = New Size(309, 23)
        txtMname.TabIndex = 7
        ' 
        ' txtFname
        ' 
        txtFname.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        txtFname.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtFname.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtFname.Location = New Point(11, 87)
        txtFname.Name = "txtFname"
        txtFname.PlaceholderText = " First Name"
        txtFname.Size = New Size(309, 23)
        txtFname.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label1.Location = New Point(10, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 16)
        Label1.TabIndex = 5
        Label1.Text = "Last Name"
        ' 
        ' txtLname
        ' 
        txtLname.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        txtLname.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtLname.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtLname.Location = New Point(11, 186)
        txtLname.Name = "txtLname"
        txtLname.PlaceholderText = " Last Name"
        txtLname.Size = New Size(309, 23)
        txtLname.TabIndex = 4
        ' 
        ' txtContactNo
        ' 
        txtContactNo.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        txtContactNo.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtContactNo.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtContactNo.Location = New Point(11, 331)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.PlaceholderText = " Contact #"
        txtContactNo.Size = New Size(309, 23)
        txtContactNo.TabIndex = 32
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label13.Location = New Point(10, 312)
        Label13.Name = "Label13"
        Label13.Size = New Size(117, 16)
        Label13.TabIndex = 31
        Label13.Text = "Contact Number"
        ' 
        ' txtUname
        ' 
        txtUname.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        txtUname.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtUname.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtUname.Location = New Point(11, 235)
        txtUname.Name = "txtUname"
        txtUname.PlaceholderText = " Username"
        txtUname.Size = New Size(309, 23)
        txtUname.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label2.Location = New Point(10, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 16)
        Label2.TabIndex = 33
        Label2.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        txtPassword.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPassword.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtPassword.Location = New Point(11, 284)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = " Password"
        txtPassword.Size = New Size(309, 23)
        txtPassword.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label3.Location = New Point(10, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 16)
        Label3.TabIndex = 35
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label4.Location = New Point(10, 359)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 16)
        Label4.TabIndex = 39
        Label4.Text = "User Type"
        ' 
        ' cbUsertype
        ' 
        cbUsertype.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        cbUsertype.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        cbUsertype.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbUsertype.FormattingEnabled = True
        cbUsertype.Location = New Point(11, 380)
        cbUsertype.Name = "cbUsertype"
        cbUsertype.Size = New Size(309, 25)
        cbUsertype.TabIndex = 40
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label5.Location = New Point(10, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 16)
        Label5.TabIndex = 41
        Label5.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(242))
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        Label6.Location = New Point(10, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 16)
        Label6.TabIndex = 42
        Label6.Text = "Middle Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(117, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 30)
        Label7.TabIndex = 46
        Label7.Text = "Add User"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Zoom
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(12, 7)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(27, 31)
        Panel8.TabIndex = 47
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(339, 44)
        Panel2.TabIndex = 49
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(6, 54)
        MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(314, 2)
        MaterialDivider1.TabIndex = 44
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' MaterialDivider2
        ' 
        MaterialDivider2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        MaterialDivider2.Depth = 0
        MaterialDivider2.Location = New Point(6, 418)
        MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider2.Name = "MaterialDivider2"
        MaterialDivider2.Size = New Size(314, 2)
        MaterialDivider2.TabIndex = 50
        MaterialDivider2.Text = "MaterialDivider2"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel3.Controls.Add(MaterialButton2)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(184, 430)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 33)
        Panel3.TabIndex = 55
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialButton2.HighEmphasis = False
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(0, 0)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MaximumSize = New Size(75, 33)
        MaterialButton2.MinimumSize = New Size(75, 33)
        MaterialButton2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(75, 33)
        MaterialButton2.TabIndex = 55
        MaterialButton2.Text = "Cancel"
        MaterialButton2.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(MaterialButton1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(70, 430)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 33)
        Panel1.TabIndex = 56
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
        ' User
        ' 
        AccentColor = MaterialSkin2Framework.Accent.Blue700
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(335, 473)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(MaterialDivider2)
        Controls.Add(Panel2)
        Controls.Add(MaterialDivider1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(cbUsertype)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(txtUname)
        Controls.Add(Label2)
        Controls.Add(txtContactNo)
        Controls.Add(Label13)
        Controls.Add(txtMname)
        Controls.Add(txtFname)
        Controls.Add(Label1)
        Controls.Add(txtLname)
        ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaximizeBox = False
        MinimizeBox = False
        Name = "User"
        PrimaryColor = MaterialSkin2Framework.Primary.Indigo700
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbUsertype As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
End Class
