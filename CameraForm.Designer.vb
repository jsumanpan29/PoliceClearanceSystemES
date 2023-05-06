<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CameraForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CameraForm))
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        ComboboxSources = New ComboBox()
        Panel2 = New Panel()
        ConfirmButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel1 = New Panel()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel3 = New Panel()
        BtnCapture = New MaterialSkin2Framework.Controls.MaterialButton()
        BtnStart = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel4 = New Panel()
        MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Panel5 = New Panel()
        Panel6 = New Panel()
        PictureBox1 = New PictureBox()
        Panel7 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(324, 88)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(282, 263)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(86, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 21)
        Label1.TabIndex = 5
        Label1.Text = "Camera Feed"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(112, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 21)
        Label2.TabIndex = 6
        Label2.Text = "Capture"
        ' 
        ' ComboboxSources
        ' 
        ComboboxSources.FormattingEnabled = True
        ComboboxSources.Location = New Point(235, 397)
        ComboboxSources.Name = "ComboboxSources"
        ComboboxSources.Size = New Size(166, 23)
        ComboboxSources.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(ConfirmButton)
        Panel2.Location = New Point(235, 458)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(75, 23)
        Panel2.TabIndex = 62
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
        Panel1.Location = New Point(326, 458)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 23)
        Panel1.TabIndex = 61
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(BtnCapture)
        Panel3.Location = New Point(326, 429)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 23)
        Panel3.TabIndex = 64
        ' 
        ' BtnCapture
        ' 
        BtnCapture.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnCapture.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        BtnCapture.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnCapture.Depth = 0
        BtnCapture.HighEmphasis = False
        BtnCapture.Icon = Nothing
        BtnCapture.Location = New Point(0, 0)
        BtnCapture.Margin = New Padding(4, 6, 4, 6)
        BtnCapture.MaximumSize = New Size(75, 23)
        BtnCapture.MinimumSize = New Size(75, 23)
        BtnCapture.MouseState = MaterialSkin2Framework.MouseState.HOVER
        BtnCapture.Name = "BtnCapture"
        BtnCapture.NoAccentTextColor = Color.Empty
        BtnCapture.Size = New Size(75, 23)
        BtnCapture.TabIndex = 8
        BtnCapture.Text = "Capture"
        BtnCapture.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        BtnCapture.UseAccentColor = False
        BtnCapture.UseVisualStyleBackColor = True
        ' 
        ' BtnStart
        ' 
        BtnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnStart.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        BtnStart.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnStart.Depth = 0
        BtnStart.ForeColor = Color.White
        BtnStart.HighEmphasis = False
        BtnStart.Icon = Nothing
        BtnStart.Location = New Point(0, 0)
        BtnStart.Margin = New Padding(4, 6, 4, 6)
        BtnStart.MaximumSize = New Size(75, 23)
        BtnStart.MinimumSize = New Size(75, 23)
        BtnStart.MouseState = MaterialSkin2Framework.MouseState.HOVER
        BtnStart.Name = "BtnStart"
        BtnStart.NoAccentTextColor = Color.Empty
        BtnStart.Size = New Size(75, 23)
        BtnStart.TabIndex = 7
        BtnStart.Text = "Start"
        BtnStart.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        BtnStart.UseAccentColor = False
        BtnStart.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(126), CByte(185))
        Panel4.Controls.Add(BtnStart)
        Panel4.Location = New Point(235, 429)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(75, 23)
        Panel4.TabIndex = 63
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(25, 82)
        MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(283, 3)
        MaterialDivider1.TabIndex = 65
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' MaterialDivider2
        ' 
        MaterialDivider2.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider2.Depth = 0
        MaterialDivider2.Location = New Point(324, 82)
        MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider2.Name = "MaterialDivider2"
        MaterialDivider2.Size = New Size(283, 3)
        MaterialDivider2.TabIndex = 66
        MaterialDivider2.Text = "MaterialDivider2"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LightGray
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(26, 350)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(282, 32)
        Panel5.TabIndex = 64
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.LightGray
        Panel6.Controls.Add(Label2)
        Panel6.Location = New Point(324, 350)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(282, 32)
        Panel6.TabIndex = 65
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(26, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(282, 263)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel7.Location = New Point(-1, 494)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(636, 5)
        Panel7.TabIndex = 64
        ' 
        ' CameraForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(633, 497)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(MaterialDivider2)
        Controls.Add(MaterialDivider1)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(ComboboxSources)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "CameraForm"
        PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Text = "Camera"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ComboboxSources As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ConfirmButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnStart As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnCapture As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
End Class
