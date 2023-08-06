<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FingerprintForm
    ' Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FingerprintForm))
        Me.deviceSerial = New System.Windows.Forms.Label()
        Me.prompt = New System.Windows.Forms.Label()
        Me.fpicture = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.ConfirmButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.fpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'deviceSerial
        '
        Me.deviceSerial.AutoSize = True
        Me.deviceSerial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.deviceSerial.Location = New System.Drawing.Point(11, 71)
        Me.deviceSerial.Name = "deviceSerial"
        Me.deviceSerial.Size = New System.Drawing.Size(85, 17)
        Me.deviceSerial.TabIndex = 0
        Me.deviceSerial.Text = "Device Serial:"
        '
        'prompt
        '
        Me.prompt.AutoSize = True
        Me.prompt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.prompt.Location = New System.Drawing.Point(11, 347)
        Me.prompt.Name = "prompt"
        Me.prompt.Size = New System.Drawing.Size(56, 17)
        Me.prompt.TabIndex = 1
        Me.prompt.Text = "Ready...."
        '
        'fpicture
        '
        Me.fpicture.Location = New System.Drawing.Point(11, 91)
        Me.fpicture.Name = "fpicture"
        Me.fpicture.Size = New System.Drawing.Size(250, 250)
        Me.fpicture.TabIndex = 2
        Me.fpicture.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.ClearButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.ClearButton.Depth = 0
        Me.ClearButton.HighEmphasis = False
        Me.ClearButton.Icon = Nothing
        Me.ClearButton.Location = New System.Drawing.Point(0, 1)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ClearButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.ClearButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.ClearButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.ClearButton.UseAccentColor = False
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ConfirmButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.ConfirmButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.ConfirmButton.Depth = 0
        Me.ConfirmButton.HighEmphasis = False
        Me.ConfirmButton.Icon = Nothing
        Me.ConfirmButton.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ConfirmButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.TabIndex = 2
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.ConfirmButton.UseAccentColor = False
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        Me.CancelButton.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.CancelButton.Depth = 0
        Me.CancelButton.HighEmphasis = False
        Me.CancelButton.Icon = Nothing
        Me.CancelButton.Location = New System.Drawing.Point(0, 1)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CancelButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.CancelButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.CancelButton.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.CancelButton.UseAccentColor = False
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Location = New System.Drawing.Point(140, 378)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 23)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.ConfirmButton)
        Me.Panel2.Location = New System.Drawing.Point(58, 378)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 23)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.ClearButton)
        Me.Panel3.Location = New System.Drawing.Point(184, 315)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 23)
        Me.Panel3.TabIndex = 11
        '
        'FingerprintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 414)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.fpicture)
        Me.Controls.Add(Me.prompt)
        Me.Controls.Add(Me.deviceSerial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FingerprintForm"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fingerprint"
        CType(Me.fpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deviceSerial As Label
    Friend WithEvents prompt As Label
    Friend WithEvents fpicture As PictureBox
    Friend WithEvents ClearButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents ConfirmButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
