<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Validation_Hit
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Validation_Hit))
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel8 = New Panel()
        MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Panel2 = New Panel()
        Label7 = New Label()
        MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(64, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 32)
        Label1.TabIndex = 55
        Label1.Text = "Hit! Records Found:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(283, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 32)
        Label2.TabIndex = 57
        Label2.Text = "Number"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(230), CByte(62), CByte(50))
        Panel3.Controls.Add(CancelButton)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(167, 116)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 33)
        Panel3.TabIndex = 59
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CancelButton.BackColor = Color.White
        CancelButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
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
        CancelButton.Text = "Next"
        CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        CancelButton.UseAccentColor = False
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.Control
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Zoom
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(14, 56)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(44, 42)
        Panel8.TabIndex = 56
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.Silver
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-10, 105)
        MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(425, 2)
        MaterialDivider1.TabIndex = 60
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.AutoSize = True
        Panel2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(-6, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(425, 40)
        Panel2.TabIndex = 61
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(92, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(246, 25)
        Label7.TabIndex = 47
        Label7.Text = "Record Found in Database"
        ' 
        ' MaterialDivider2
        ' 
        MaterialDivider2.BackColor = Color.Silver
        MaterialDivider2.Depth = 0
        MaterialDivider2.Location = New Point(-6, 50)
        MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider2.Name = "MaterialDivider2"
        MaterialDivider2.Size = New Size(425, 2)
        MaterialDivider2.TabIndex = 62
        MaterialDivider2.Text = "MaterialDivider2"
        ' 
        ' Validation_Hit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 155)
        ControlBox = False
        Controls.Add(MaterialDivider2)
        Controls.Add(Panel2)
        Controls.Add(MaterialDivider1)
        Controls.Add(Panel8)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Validation_Hit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Validation_Hit"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
End Class
