<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Validation_NoHit
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
        Label1 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        Panel3 = New Panel()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel1 = New Panel()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        MaterialDivider1 = New MaterialSkin2Framework.Controls.MaterialDivider()
        MaterialDivider2 = New MaterialSkin2Framework.Controls.MaterialDivider()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(13, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(592, 32)
        Label1.TabIndex = 53
        Label1.Text = "No Criminal/Derogatory Record on file as of this Date!"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.AutoSize = True
        Panel2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(-1, -4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(616, 56)
        Panel2.TabIndex = 56
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(162, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(306, 30)
        Label7.TabIndex = 46
        Label7.Text = "No Record Found in Database"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel3.Controls.Add(CancelButton)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(330, 129)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 33)
        Panel3.TabIndex = 58
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(MaterialButton1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(229, 129)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 33)
        Panel1.TabIndex = 57
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
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-1, 116)
        MaterialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(616, 3)
        MaterialDivider1.TabIndex = 59
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' MaterialDivider2
        ' 
        MaterialDivider2.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider2.Depth = 0
        MaterialDivider2.Location = New Point(-1, 63)
        MaterialDivider2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialDivider2.Name = "MaterialDivider2"
        MaterialDivider2.Size = New Size(616, 3)
        MaterialDivider2.TabIndex = 60
        MaterialDivider2.Text = "MaterialDivider2"
        ' 
        ' Validation_NoHit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 174)
        ControlBox = False
        Controls.Add(MaterialDivider2)
        Controls.Add(MaterialDivider1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Name = "Validation_NoHit"
        Text = "Validation_NoHit"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin2Framework.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin2Framework.Controls.MaterialDivider
End Class
