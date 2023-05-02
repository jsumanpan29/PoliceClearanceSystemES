<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin2Framework.Controls.MaterialForm
    'Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Label8 = New Label()
        Panel5 = New Panel()
        Label4 = New Label()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        btnLogin = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel3 = New Panel()
        txtPassword = New MaterialSkin2Framework.Controls.MaterialTextBox2()
        Panel11 = New Panel()
        txtUser = New MaterialSkin2Framework.Controls.MaterialTextBox2()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel11.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 64)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(981, 559)
        Panel1.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(32, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(165, 30)
        Label8.TabIndex = 19
        Label8.Text = "El Salvador City"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(9), CByte(45), CByte(73))
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(32, 328)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(287, 51)
        Panel5.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(64, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 32)
        Label4.TabIndex = 11
        Label4.Text = "Police Station"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel6.Controls.Add(Panel7)
        Panel6.Location = New Point(3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(47, 45)
        Panel6.TabIndex = 8
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Transparent
        Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), Image)
        Panel7.BackgroundImageLayout = ImageLayout.Zoom
        Panel7.Location = New Point(7, 7)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(32, 32)
        Panel7.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(26, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(596, 50)
        Label2.TabIndex = 17
        Label2.Text = "Police Clearance Issuance System"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel11)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(657, 64)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(327, 559)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label1.Location = New Point(108, 167)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 40)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN"
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLogin.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        btnLogin.Depth = 0
        btnLogin.HighEmphasis = True
        btnLogin.Icon = Nothing
        btnLogin.Location = New Point(23, 357)
        btnLogin.Margin = New Padding(10, 6, 4, 6)
        btnLogin.MaximumSize = New Size(240, 50)
        btnLogin.MinimumSize = New Size(286, 38)
        btnLogin.MouseState = MaterialSkin2Framework.MouseState.HOVER
        btnLogin.Name = "btnLogin"
        btnLogin.NoAccentTextColor = Color.Empty
        btnLogin.Size = New Size(286, 38)
        btnLogin.TabIndex = 16
        btnLogin.Text = "Login"
        btnLogin.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained
        btnLogin.UseAccentColor = False
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txtPassword)
        Panel3.Location = New Point(22, 283)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(287, 55)
        Panel3.TabIndex = 15
        ' 
        ' txtPassword
        ' 
        txtPassword.AnimateReadOnly = False
        txtPassword.AutoCompleteMode = AutoCompleteMode.None
        txtPassword.AutoCompleteSource = AutoCompleteSource.None
        txtPassword.BackgroundImageLayout = ImageLayout.None
        txtPassword.CharacterCasing = CharacterCasing.Normal
        txtPassword.Depth = 0
        txtPassword.ErrorMessage = "Password not Match"
        txtPassword.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPassword.HelperText = "Enter Your Password"
        txtPassword.HideSelection = True
        txtPassword.Hint = "Enter Password"
        txtPassword.LeadingIcon = CType(resources.GetObject("txtPassword.LeadingIcon"), Image)
        txtPassword.Location = New Point(6, 3)
        txtPassword.MaxLength = 32767
        txtPassword.MouseState = MaterialSkin2Framework.MouseState.OUT
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PrefixSuffixText = Nothing
        txtPassword.ReadOnly = False
        txtPassword.RightToLeft = RightToLeft.No
        txtPassword.SelectedText = ""
        txtPassword.SelectionLength = 0
        txtPassword.SelectionStart = 0
        txtPassword.ShortcutsEnabled = True
        txtPassword.Size = New Size(278, 48)
        txtPassword.TabIndex = 1
        txtPassword.TabStop = False
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TrailingIcon = Nothing
        txtPassword.UseAccent = False
        txtPassword.UseSystemPasswordChar = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(txtUser)
        Panel11.Location = New Point(22, 210)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(287, 55)
        Panel11.TabIndex = 14
        ' 
        ' txtUser
        ' 
        txtUser.AnimateReadOnly = False
        txtUser.AutoCompleteMode = AutoCompleteMode.None
        txtUser.AutoCompleteSource = AutoCompleteSource.None
        txtUser.BackgroundImageLayout = ImageLayout.None
        txtUser.CharacterCasing = CharacterCasing.Normal
        txtUser.Depth = 0
        txtUser.ErrorMessage = "The User is Not Yet Exist"
        txtUser.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtUser.HelperText = "Enter Your Username"
        txtUser.HideSelection = True
        txtUser.Hint = "Enter Username"
        txtUser.LeadingIcon = CType(resources.GetObject("txtUser.LeadingIcon"), Image)
        txtUser.Location = New Point(6, 3)
        txtUser.MaxLength = 32767
        txtUser.MouseState = MaterialSkin2Framework.MouseState.OUT
        txtUser.Name = "txtUser"
        txtUser.PasswordChar = ChrW(0)
        txtUser.PrefixSuffixText = Nothing
        txtUser.ReadOnly = False
        txtUser.RightToLeft = RightToLeft.No
        txtUser.SelectedText = ""
        txtUser.SelectionLength = 0
        txtUser.SelectionStart = 0
        txtUser.ShortcutsEnabled = True
        txtUser.Size = New Size(278, 48)
        txtUser.TabIndex = 0
        txtUser.TabStop = False
        txtUser.TextAlign = HorizontalAlignment.Left
        txtUser.TrailingIcon = Nothing
        txtUser.UseAccent = False
        txtUser.UseSystemPasswordChar = False
        ' 
        ' Login
        ' 
        ClientSize = New Size(987, 626)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Login"
        PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        StartPosition = FormStartPosition.CenterScreen
        Text = "Police Clearance Issuance System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtUser As MaterialSkin2Framework.Controls.MaterialTextBox2
    Friend WithEvents txtPassword As MaterialSkin2Framework.Controls.MaterialTextBox2
    Friend WithEvents btnLogin As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
End Class
