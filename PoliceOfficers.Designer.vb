<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoliceOfficers
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.policeVerifiedByChkbx = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.policeVerifiedByID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeVerifiedByfname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeVerifiedByMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeVerifiedByLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeVerifiedByRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeVerifiedByPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeVerifiedByHistory = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.policeCertifiedByChkbx = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.policeCertifiedByID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeCertifiedByFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeCertifiedByMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeCertifiedByLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeCertifiedByRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeCertifiedByPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.policeCertifiedByHistory = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MaterialLabel1 = New MaterialSkin2Framework.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin2Framework.Controls.MaterialLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(474, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.policeVerifiedByChkbx, Me.policeVerifiedByID, Me.policeVerifiedByfname, Me.policeVerifiedByMname, Me.policeVerifiedByLname, Me.policeVerifiedByRank, Me.policeVerifiedByPosition, Me.policeVerifiedByHistory})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(972, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'policeVerifiedByChkbx
        '
        Me.policeVerifiedByChkbx.HeaderText = "   "
        Me.policeVerifiedByChkbx.Name = "policeVerifiedByChkbx"
        Me.policeVerifiedByChkbx.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.policeVerifiedByChkbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'policeVerifiedByID
        '
        Me.policeVerifiedByID.HeaderText = "ID"
        Me.policeVerifiedByID.Name = "policeVerifiedByID"
        Me.policeVerifiedByID.ReadOnly = True
        '
        'policeVerifiedByfname
        '
        Me.policeVerifiedByfname.HeaderText = "First Name"
        Me.policeVerifiedByfname.Name = "policeVerifiedByfname"
        Me.policeVerifiedByfname.ReadOnly = True
        '
        'policeVerifiedByMname
        '
        Me.policeVerifiedByMname.HeaderText = "Middle Name"
        Me.policeVerifiedByMname.Name = "policeVerifiedByMname"
        Me.policeVerifiedByMname.ReadOnly = True
        '
        'policeVerifiedByLname
        '
        Me.policeVerifiedByLname.HeaderText = "Last Name"
        Me.policeVerifiedByLname.Name = "policeVerifiedByLname"
        Me.policeVerifiedByLname.ReadOnly = True
        '
        'policeVerifiedByRank
        '
        Me.policeVerifiedByRank.HeaderText = "Rank"
        Me.policeVerifiedByRank.Name = "policeVerifiedByRank"
        Me.policeVerifiedByRank.ReadOnly = True
        Me.policeVerifiedByRank.Width = 150
        '
        'policeVerifiedByPosition
        '
        Me.policeVerifiedByPosition.HeaderText = "Position"
        Me.policeVerifiedByPosition.Name = "policeVerifiedByPosition"
        Me.policeVerifiedByPosition.ReadOnly = True
        '
        'policeVerifiedByHistory
        '
        Me.policeVerifiedByHistory.HeaderText = ""
        Me.policeVerifiedByHistory.Name = "policeVerifiedByHistory"
        Me.policeVerifiedByHistory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.policeVerifiedByHistory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.policeVerifiedByHistory.Text = "Check History"
        Me.policeVerifiedByHistory.UseColumnTextForButtonValue = True
        Me.policeVerifiedByHistory.Width = 150
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.policeCertifiedByChkbx, Me.policeCertifiedByID, Me.policeCertifiedByFname, Me.policeCertifiedByMname, Me.policeCertifiedByLname, Me.policeCertifiedByRank, Me.policeCertifiedByPosition, Me.policeCertifiedByHistory})
        Me.DataGridView2.Location = New System.Drawing.Point(23, 288)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(972, 150)
        Me.DataGridView2.TabIndex = 6
        '
        'policeCertifiedByChkbx
        '
        Me.policeCertifiedByChkbx.HeaderText = ""
        Me.policeCertifiedByChkbx.Name = "policeCertifiedByChkbx"
        Me.policeCertifiedByChkbx.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.policeCertifiedByChkbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'policeCertifiedByID
        '
        Me.policeCertifiedByID.HeaderText = "ID"
        Me.policeCertifiedByID.Name = "policeCertifiedByID"
        Me.policeCertifiedByID.ReadOnly = True
        '
        'policeCertifiedByFname
        '
        Me.policeCertifiedByFname.HeaderText = "First Name"
        Me.policeCertifiedByFname.Name = "policeCertifiedByFname"
        Me.policeCertifiedByFname.ReadOnly = True
        '
        'policeCertifiedByMname
        '
        Me.policeCertifiedByMname.HeaderText = "Middle Name"
        Me.policeCertifiedByMname.Name = "policeCertifiedByMname"
        Me.policeCertifiedByMname.ReadOnly = True
        '
        'policeCertifiedByLname
        '
        Me.policeCertifiedByLname.HeaderText = "Last Name"
        Me.policeCertifiedByLname.Name = "policeCertifiedByLname"
        Me.policeCertifiedByLname.ReadOnly = True
        '
        'policeCertifiedByRank
        '
        Me.policeCertifiedByRank.HeaderText = "Rank"
        Me.policeCertifiedByRank.Name = "policeCertifiedByRank"
        Me.policeCertifiedByRank.ReadOnly = True
        Me.policeCertifiedByRank.Width = 150
        '
        'policeCertifiedByPosition
        '
        Me.policeCertifiedByPosition.HeaderText = "Position"
        Me.policeCertifiedByPosition.Name = "policeCertifiedByPosition"
        Me.policeCertifiedByPosition.ReadOnly = True
        '
        'policeCertifiedByHistory
        '
        Me.policeCertifiedByHistory.HeaderText = ""
        Me.policeCertifiedByHistory.Name = "policeCertifiedByHistory"
        Me.policeCertifiedByHistory.Text = "Check History"
        Me.policeCertifiedByHistory.UseColumnTextForButtonValue = True
        Me.policeCertifiedByHistory.Width = 150
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(23, 82)
        Me.MaterialLabel1.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel1.TabIndex = 7
        Me.MaterialLabel1.Text = "Verified By"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(23, 266)
        Me.MaterialLabel2.MouseState = MaterialSkin2Framework.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel2.TabIndex = 8
        Me.MaterialLabel2.Text = "Certified By"
        '
        'PoliceOfficers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 497)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "PoliceOfficers"
        Me.PrimaryColor = MaterialSkin2Framework.Primary.Blue700
        Me.PrimaryDarkColor = MaterialSkin2Framework.Primary.Blue900
        Me.PrimaryLightColor = MaterialSkin2Framework.Primary.Blue300
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Police Officers Settings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MaterialLabel1 As MaterialSkin2Framework.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin2Framework.Controls.MaterialLabel
    Friend WithEvents policeVerifiedByChkbx As DataGridViewCheckBoxColumn
    Friend WithEvents policeVerifiedByID As DataGridViewTextBoxColumn
    Friend WithEvents policeVerifiedByfname As DataGridViewTextBoxColumn
    Friend WithEvents policeVerifiedByMname As DataGridViewTextBoxColumn
    Friend WithEvents policeVerifiedByLname As DataGridViewTextBoxColumn
    Friend WithEvents policeVerifiedByRank As DataGridViewTextBoxColumn
    Friend WithEvents policeVerifiedByPosition As DataGridViewTextBoxColumn
    Friend WithEvents policeVerifiedByHistory As DataGridViewButtonColumn
    Friend WithEvents policeCertifiedByChkbx As DataGridViewCheckBoxColumn
    Friend WithEvents policeCertifiedByID As DataGridViewTextBoxColumn
    Friend WithEvents policeCertifiedByFname As DataGridViewTextBoxColumn
    Friend WithEvents policeCertifiedByMname As DataGridViewTextBoxColumn
    Friend WithEvents policeCertifiedByLname As DataGridViewTextBoxColumn
    Friend WithEvents policeCertifiedByRank As DataGridViewTextBoxColumn
    Friend WithEvents policeCertifiedByPosition As DataGridViewTextBoxColumn
    Friend WithEvents policeCertifiedByHistory As DataGridViewButtonColumn
End Class
