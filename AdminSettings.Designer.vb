<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSettings
    '  Inherits System.Windows.Forms.Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AdminSettings))
        Label6 = New Label()
        Label5 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtUname = New TextBox()
        Label2 = New Label()
        txtContactNo = New TextBox()
        Label13 = New Label()
        txtMname = New TextBox()
        txtFname = New TextBox()
        Label1 = New Label()
        txtLname = New TextBox()
        Panel2 = New Panel()
        ConfirmButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel1 = New Panel()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(171, 73)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 17)
        Label6.TabIndex = 56
        Label6.Text = "Middle Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 17)
        Label5.TabIndex = 55
        Label5.Text = "First Name"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(12, 227)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = " Password"
        txtPassword.Size = New Size(153, 23)
        txtPassword.TabIndex = 52
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 51
        Label3.Text = "Password"
        ' 
        ' txtUname
        ' 
        txtUname.Enabled = False
        txtUname.Location = New Point(12, 181)
        txtUname.Name = "txtUname"
        txtUname.PlaceholderText = " Username"
        txtUname.Size = New Size(153, 23)
        txtUname.TabIndex = 50
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 49
        Label2.Text = "Username"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(171, 181)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.PlaceholderText = " Contact Number"
        txtContactNo.Size = New Size(153, 23)
        txtContactNo.TabIndex = 48
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(171, 160)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 17)
        Label13.TabIndex = 47
        Label13.Text = "Contact Number"
        ' 
        ' txtMname
        ' 
        txtMname.Location = New Point(171, 94)
        txtMname.Name = "txtMname"
        txtMname.PlaceholderText = " Middle Name"
        txtMname.Size = New Size(153, 23)
        txtMname.TabIndex = 46
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(12, 94)
        txtFname.Name = "txtFname"
        txtFname.PlaceholderText = " First Name"
        txtFname.Size = New Size(153, 23)
        txtFname.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 17)
        Label1.TabIndex = 44
        Label1.Text = "Last Name"
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(12, 137)
        txtLname.Name = "txtLname"
        txtLname.PlaceholderText = " Last Name"
        txtLname.Size = New Size(153, 23)
        txtLname.TabIndex = 43
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(ConfirmButton)
        Panel2.Location = New Point(90, 264)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(75, 23)
        Panel2.TabIndex = 60
        ' 
        ' ConfirmButton
        ' 
        ConfirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ConfirmButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        ConfirmButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        ConfirmButton.Depth = 0
        ConfirmButton.HighEmphasis = False
        ConfirmButton.Icon = Nothing
        ConfirmButton.Location = New Point(0, 0)
        ConfirmButton.Margin = New Padding(4, 6, 4, 6)
        ConfirmButton.MaximumSize = New Size(75, 23)
        ConfirmButton.MinimumSize = New Size(75, 23)
        ConfirmButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        ConfirmButton.Name = "ConfirmButton"
        ConfirmButton.NoAccentTextColor = Color.Empty
        ConfirmButton.Size = New Size(75, 23)
        ConfirmButton.TabIndex = 7
        ConfirmButton.Text = "Save"
        ConfirmButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        ConfirmButton.UseAccentColor = False
        ConfirmButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel1.Controls.Add(CancelButton)
        Panel1.Location = New Point(172, 264)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 23)
        Panel1.TabIndex = 59
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CancelButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        CancelButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        CancelButton.Depth = 0
        CancelButton.HighEmphasis = False
        CancelButton.Icon = Nothing
        CancelButton.Location = New Point(0, 0)
        CancelButton.Margin = New Padding(4, 6, 4, 6)
        CancelButton.MaximumSize = New Size(75, 23)
        CancelButton.MinimumSize = New Size(75, 23)
        CancelButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        CancelButton.Name = "CancelButton"
        CancelButton.NoAccentTextColor = Color.Empty
        CancelButton.Size = New Size(75, 23)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        CancelButton.UseAccentColor = False
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' AdminSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(339, 298)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
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
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "AdminSettings"
        PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminSettings"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ConfirmButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
End Class
