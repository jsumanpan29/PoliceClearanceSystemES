<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FingerprintForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.deviceSerial = New System.Windows.Forms.Label()
        Me.prompt = New System.Windows.Forms.Label()
        Me.fpicture = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.fpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deviceSerial
        '
        Me.deviceSerial.AutoSize = True
        Me.deviceSerial.Location = New System.Drawing.Point(12, 9)
        Me.deviceSerial.Name = "deviceSerial"
        Me.deviceSerial.Size = New System.Drawing.Size(76, 15)
        Me.deviceSerial.TabIndex = 0
        Me.deviceSerial.Text = "Device Serial:"
        '
        'prompt
        '
        Me.prompt.AutoSize = True
        Me.prompt.Location = New System.Drawing.Point(12, 280)
        Me.prompt.Name = "prompt"
        Me.prompt.Size = New System.Drawing.Size(51, 15)
        Me.prompt.TabIndex = 1
        Me.prompt.Text = "Ready...."
        '
        'fpicture
        '
        Me.fpicture.Location = New System.Drawing.Point(12, 27)
        Me.fpicture.Name = "fpicture"
        Me.fpicture.Size = New System.Drawing.Size(250, 250)
        Me.fpicture.TabIndex = 2
        Me.fpicture.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(140, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FingerprintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 350)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fpicture)
        Me.Controls.Add(Me.prompt)
        Me.Controls.Add(Me.deviceSerial)
        Me.Name = "FingerprintForm"
        Me.Text = "FingerprintForm"
        CType(Me.fpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deviceSerial As Label
    Friend WithEvents prompt As Label
    Friend WithEvents fpicture As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
