<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin2Framework.Controls.MaterialForm

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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ReportForm))
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Panel1 = New Panel()
        MaterialButton1 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel2 = New Panel()
        MaterialButton3 = New MaterialSkin2Framework.Controls.MaterialButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        ComboBox1.Location = New Point(60, 79)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 1
        Label1.Text = "Report:"
        ' 
        ' ReportViewer2
        ' 
        ReportViewer2.Location = New Point(12, 112)
        ReportViewer2.Name = "ReportViewer"
        ReportViewer2.ServerReport.BearerToken = Nothing
        ReportViewer2.Size = New Size(780, 500)
        ReportViewer2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(MaterialButton1)
        Panel1.Location = New Point(197, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(75, 23)
        Panel1.TabIndex = 12
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        MaterialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = False
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(0, 0)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MaximumSize = New Size(75, 23)
        MaterialButton1.MinimumSize = New Size(75, 23)
        MaterialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(75, 23)
        MaterialButton1.TabIndex = 7
        MaterialButton1.Text = "Generate"
        MaterialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(MaterialButton3)
        Panel2.Location = New Point(360, 626)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(75, 23)
        Panel2.TabIndex = 13
        ' 
        ' MaterialButton3
        ' 
        MaterialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton3.CharacterCasing = MaterialSkin2Framework.Controls.MaterialButton.CharacterCasingEnum.Normal
        MaterialButton3.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton3.Depth = 0
        MaterialButton3.HighEmphasis = False
        MaterialButton3.Icon = Nothing
        MaterialButton3.Location = New Point(0, 0)
        MaterialButton3.Margin = New Padding(4, 6, 4, 6)
        MaterialButton3.MaximumSize = New Size(75, 23)
        MaterialButton3.MinimumSize = New Size(75, 23)
        MaterialButton3.MouseState = MaterialSkin2Framework.MouseState.HOVER
        MaterialButton3.Name = "MaterialButton3"
        MaterialButton3.NoAccentTextColor = Color.Empty
        MaterialButton3.Size = New Size(75, 23)
        MaterialButton3.TabIndex = 7
        MaterialButton3.Text = "Clear"
        MaterialButton3.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Text
        MaterialButton3.UseAccentColor = False
        MaterialButton3.UseVisualStyleBackColor = True
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 663)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ReportViewer2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ReportForm"
        Text = "Report"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button_2 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin2Framework.Controls.MaterialButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialButton3 As MaterialSkin2Framework.Controls.MaterialButton
End Class
