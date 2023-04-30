<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CriminalRecords
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CriminalRecords))
        txtRemarks = New TextBox()
        Label2 = New Label()
        txtISNO = New TextBox()
        Label13 = New Label()
        txtCCNO = New TextBox()
        txtCrime = New TextBox()
        Label1 = New Label()
        txtFName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtMName = New TextBox()
        Label6 = New Label()
        txtLName = New TextBox()
        Panel2 = New Panel()
        Panel8 = New Panel()
        Label7 = New Label()
        Panel1 = New Panel()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel3 = New Panel()
        CancelButton = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(6, 364)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.PlaceholderText = " Remarks"
        txtRemarks.Size = New Size(262, 23)
        txtRemarks.TabIndex = 42
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 346)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 41
        Label2.Text = "Remarks"
        ' 
        ' txtISNO
        ' 
        txtISNO.Location = New Point(6, 320)
        txtISNO.Name = "txtISNO"
        txtISNO.PlaceholderText = " I.S. #"
        txtISNO.Size = New Size(262, 23)
        txtISNO.TabIndex = 40
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(9, 300)
        Label13.Name = "Label13"
        Label13.Size = New Size(44, 15)
        Label13.TabIndex = 39
        Label13.Text = "I.S. No."
        ' 
        ' txtCCNO
        ' 
        txtCCNO.Location = New Point(6, 272)
        txtCCNO.Name = "txtCCNO"
        txtCCNO.PlaceholderText = " Criminal Case #"
        txtCCNO.Size = New Size(262, 23)
        txtCCNO.TabIndex = 38
        ' 
        ' txtCrime
        ' 
        txtCrime.Location = New Point(6, 226)
        txtCrime.Name = "txtCrime"
        txtCrime.PlaceholderText = " Crime/Offense Committed"
        txtCrime.Size = New Size(262, 23)
        txtCrime.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 36
        Label1.Text = "First Name"
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(6, 84)
        txtFName.Name = "txtFName"
        txtFName.PlaceholderText = " First Name"
        txtFName.Size = New Size(262, 23)
        txtFName.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 15)
        Label3.TabIndex = 43
        Label3.Text = "Crime/Offense Committed"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 254)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 15)
        Label4.TabIndex = 44
        Label4.Text = "Criminal Case No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(9, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 48
        Label5.Text = "Middle Name"
        ' 
        ' txtMName
        ' 
        txtMName.Location = New Point(6, 130)
        txtMName.Name = "txtMName"
        txtMName.PlaceholderText = " Middle Name"
        txtMName.Size = New Size(262, 23)
        txtMName.TabIndex = 47
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 15)
        Label6.TabIndex = 50
        Label6.Text = "Last Name"
        ' 
        ' txtLName
        ' 
        txtLName.Location = New Point(6, 178)
        txtLName.Name = "txtLName"
        txtLName.PlaceholderText = " Last Name"
        txtLName.Size = New Size(262, 23)
        txtLName.TabIndex = 49
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(277, 50)
        Panel2.TabIndex = 51
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(3), CByte(59), CByte(106))
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(62, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 25)
        Label7.TabIndex = 46
        Label7.Text = "Criminal Records"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(MaterialButton1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(50, 403)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 33)
        Panel1.TabIndex = 52
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        Panel3.Controls.Add(CancelButton)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(160, 403)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(75, 33)
        Panel3.TabIndex = 55
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
        ' CriminalRecords
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(277, 447)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Label6)
        Controls.Add(txtLName)
        Controls.Add(Label5)
        Controls.Add(txtMName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtRemarks)
        Controls.Add(Label2)
        Controls.Add(txtISNO)
        Controls.Add(Label13)
        Controls.Add(txtCCNO)
        Controls.Add(txtCrime)
        Controls.Add(Label1)
        Controls.Add(txtFName)
        Name = "CriminalRecords"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Criminal Records"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtISNO As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCCNO As TextBox
    Friend WithEvents txtCrime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As MaterialSkin2Framework.Controls.MaterialButton
End Class
