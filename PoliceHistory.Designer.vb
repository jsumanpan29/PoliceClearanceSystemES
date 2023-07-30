<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoliceHistory
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.policeHistoryPrevRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeHistoryCurrRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeHistoryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaterialLabel1 = New MaterialSkin2Framework.Controls.MaterialLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.policeHistoryPrevRank, Me.policeHistoryCurrRank, Me.policeHistoryDate})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(443, 400)
        Me.DataGridView1.TabIndex = 0
        '
        'policeHistoryPrevRank
        '
        Me.policeHistoryPrevRank.HeaderText = "Previous Rank"
        Me.policeHistoryPrevRank.Name = "policeHistoryPrevRank"
        Me.policeHistoryPrevRank.ReadOnly = True
        Me.policeHistoryPrevRank.Width = 150
        '
        'policeHistoryCurrRank
        '
        Me.policeHistoryCurrRank.HeaderText = "Current Rank"
        Me.policeHistoryCurrRank.Name = "policeHistoryCurrRank"
        Me.policeHistoryCurrRank.ReadOnly = True
        Me.policeHistoryCurrRank.Width = 150
        '
        'policeHistoryDate
        '
        Me.policeHistoryDate.HeaderText = "Date"
        Me.policeHistoryDate.Name = "policeHistoryDate"
        Me.policeHistoryDate.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(69, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(390, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(16, 91)
        Me.MaterialLabel1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Name:"
        '
        'PoliceHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 577)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "PoliceHistory"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Police History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaterialLabel1 As MaterialSkin2Framework.Controls.MaterialLabel
    Friend WithEvents policeHistoryPrevRank As DataGridViewTextBoxColumn
    Friend WithEvents policeHistoryCurrRank As DataGridViewTextBoxColumn
    Friend WithEvents policeHistoryDate As DataGridViewTextBoxColumn
End Class
