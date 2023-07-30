<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Applicant
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbBarangay = New System.Windows.Forms.ComboBox()
        Me.cbZone = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConfirm = New MaterialSkin2Framework.Controls.MaterialButton()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(172, 102)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 15)
        Me.Label23.TabIndex = 172
        Me.Label23.Text = ","
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(340, 228)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PlaceholderText = " Contact Number*"
        Me.txtContactNo.Size = New System.Drawing.Size(150, 23)
        Me.txtContactNo.TabIndex = 162
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(337, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 15)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "Contact Number"
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(229, 228)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.PlaceholderText = " Nationality*"
        Me.txtNationality.Size = New System.Drawing.Size(105, 23)
        Me.txtNationality.TabIndex = 161
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "Nationality"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(145, 228)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.PlaceholderText = " Height*"
        Me.txtHeight.Size = New System.Drawing.Size(78, 23)
        Me.txtHeight.TabIndex = 160
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(76, 230)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 19)
        Me.rbFemale.TabIndex = 159
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(19, 230)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(51, 19)
        Me.rbMale.TabIndex = 158
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Height(ft)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(19, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 15)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Date of Birth"
        '
        'dtBirthDate
        '
        Me.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthDate.Location = New System.Drawing.Point(340, 186)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(150, 23)
        Me.dtBirthDate.TabIndex = 157
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Location = New System.Drawing.Point(19, 186)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.PlaceholderText = " Place of Birth*"
        Me.txtBirthPlace.Size = New System.Drawing.Size(274, 23)
        Me.txtBirthPlace.TabIndex = 156
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Place of Birth"
        '
        'cbCivilStatus
        '
        Me.cbCivilStatus.FormattingEnabled = True
        Me.cbCivilStatus.Location = New System.Drawing.Point(340, 142)
        Me.cbCivilStatus.Name = "cbCivilStatus"
        Me.cbCivilStatus.Size = New System.Drawing.Size(150, 23)
        Me.cbCivilStatus.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Civil Status"
        '
        'cbBarangay
        '
        Me.cbBarangay.FormattingEnabled = True
        Me.cbBarangay.Location = New System.Drawing.Point(90, 142)
        Me.cbBarangay.Name = "cbBarangay"
        Me.cbBarangay.Size = New System.Drawing.Size(203, 23)
        Me.cbBarangay.TabIndex = 154
        '
        'cbZone
        '
        Me.cbZone.FormattingEnabled = True
        Me.cbZone.Location = New System.Drawing.Point(19, 142)
        Me.cbZone.Name = "cbZone"
        Me.cbZone.Size = New System.Drawing.Size(68, 23)
        Me.cbZone.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 15)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Address(Zone, Barangay)"
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(340, 93)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.PlaceholderText = " Middle Name*"
        Me.txtMname.Size = New System.Drawing.Size(150, 23)
        Me.txtMname.TabIndex = 152
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(184, 93)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PlaceholderText = " First Name*"
        Me.txtFname.Size = New System.Drawing.Size(150, 23)
        Me.txtFname.TabIndex = 151
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(266, 15)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "Full Name(Last Name, First Name, Middle Name)"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(19, 93)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PlaceholderText = " Last Name*"
        Me.txtLname.Size = New System.Drawing.Size(150, 23)
        Me.txtLname.TabIndex = 150
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(270, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(132, 25)
        Me.Panel3.TabIndex = 174
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnCancel.Depth = 0
        Me.btnCancel.HighEmphasis = False
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MaximumSize = New System.Drawing.Size(132, 25)
        Me.btnCancel.MinimumSize = New System.Drawing.Size(132, 25)
        Me.btnCancel.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnCancel.Size = New System.Drawing.Size(132, 25)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnCancel.UseAccentColor = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnConfirm)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(108, 273)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 25)
        Me.Panel1.TabIndex = 173
        '
        'btnConfirm
        '
        Me.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnConfirm.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnConfirm.Depth = 0
        Me.btnConfirm.DrawShadows = False
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.HighEmphasis = False
        Me.btnConfirm.Icon = Nothing
        Me.btnConfirm.Location = New System.Drawing.Point(0, 0)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConfirm.MaximumSize = New System.Drawing.Size(132, 25)
        Me.btnConfirm.MinimumSize = New System.Drawing.Size(132, 25)
        Me.btnConfirm.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnConfirm.Size = New System.Drawing.Size(132, 25)
        Me.btnConfirm.TabIndex = 53
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnConfirm.UseAccentColor = False
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Applicant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 308)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtBirthDate)
        Me.Controls.Add(Me.txtBirthPlace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbCivilStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBarangay)
        Me.Controls.Add(Me.cbZone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtLname)
        Me.MaximizeBox = False
        Me.Name = "Applicant"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Applicant"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label23 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbBarangay As ComboBox
    Friend WithEvents cbZone As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfirm As MaterialSkin2Framework.Controls.MaterialButton
End Class
