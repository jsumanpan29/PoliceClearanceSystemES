<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignatureForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SignatureForm))
        pBoxSignature = New PictureBox()
        Panel2 = New Panel()
        Panel8 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel4 = New Panel()
        MaterialButton2 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel5 = New Panel()
        MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        CType(pBoxSignature, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' pBoxSignature
        ' 
        pBoxSignature.BackColor = Color.White
        pBoxSignature.Location = New Point(6, 87)
        pBoxSignature.Name = "pBoxSignature"
        pBoxSignature.Size = New Size(493, 404)
        pBoxSignature.SizeMode = PictureBoxSizeMode.StretchImage
        pBoxSignature.TabIndex = 0
        pBoxSignature.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel2.Location = New Point(-6, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(515, 20)
        Panel2.TabIndex = 50
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.Control
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Zoom
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(16, 24)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(27, 31)
        Panel8.TabIndex = 47
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(49, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 30)
        Label7.TabIndex = 46
        Label7.Text = "Signature"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkGray
        Label1.Location = New Point(16, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 15)
        Label1.TabIndex = 51
        Label1.Text = "Sign your Signature here*"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(458, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(41, 41)
        Panel1.TabIndex = 48
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(MaterialButton1)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(163, 502)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 33)
        Panel3.TabIndex = 59
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
        MaterialButton1.Text = "Confirm"
        MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel4.Controls.Add(MaterialButton2)
        Panel4.ForeColor = Color.White
        Panel4.Location = New Point(274, 502)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(75, 33)
        Panel4.TabIndex = 58
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
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel5.Location = New Point(-6, 548)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(527, 17)
        Panel5.TabIndex = 51
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-6, 62)
        MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(515, 2)
        MaterialDivider1.TabIndex = 60
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' SignatureForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(508, 554)
        ControlBox = False
        Controls.Add(MaterialDivider1)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(Panel8)
        Controls.Add(Panel2)
        Controls.Add(Label7)
        Controls.Add(pBoxSignature)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SignatureForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignatureForm"
        CType(pBoxSignature, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pBoxSignature As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaterialButton2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
End Class
