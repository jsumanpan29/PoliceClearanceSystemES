<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
    Inherits System.Windows.Forms.Form

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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtPendingSearchDate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ClearanceCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClearanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClearanceFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClearanceMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClearanceLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chbAll = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClearanceCheckBox, Me.ClearanceID, Me.ClearanceFname, Me.ClearanceMname, Me.ClearanceLname})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1001, 399)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(951, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(951, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(660, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 23)
        Me.TextBox1.TabIndex = 3
        '
        'dtPendingSearchDate
        '
        Me.dtPendingSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPendingSearchDate.Location = New System.Drawing.Point(555, 27)
        Me.dtPendingSearchDate.Name = "dtPendingSearchDate"
        Me.dtPendingSearchDate.Size = New System.Drawing.Size(99, 23)
        Me.dtPendingSearchDate.TabIndex = 144
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(515, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 15)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "Date:"
        '
        'ClearanceCheckBox
        '
        Me.ClearanceCheckBox.HeaderText = ""
        Me.ClearanceCheckBox.Name = "ClearanceCheckBox"
        Me.ClearanceCheckBox.ReadOnly = True
        '
        'ClearanceID
        '
        Me.ClearanceID.HeaderText = "Clearance Number"
        Me.ClearanceID.Name = "ClearanceID"
        Me.ClearanceID.ReadOnly = True
        '
        'ClearanceFname
        '
        Me.ClearanceFname.HeaderText = "First Name"
        Me.ClearanceFname.Name = "ClearanceFname"
        Me.ClearanceFname.ReadOnly = True
        '
        'ClearanceMname
        '
        Me.ClearanceMname.HeaderText = "Middle Name"
        Me.ClearanceMname.Name = "ClearanceMname"
        Me.ClearanceMname.ReadOnly = True
        '
        'ClearanceLname
        '
        Me.ClearanceLname.HeaderText = "Last Name"
        Me.ClearanceLname.Name = "ClearanceLname"
        Me.ClearanceLname.ReadOnly = True
        '
        'chbAll
        '
        Me.chbAll.AutoSize = True
        Me.chbAll.Location = New System.Drawing.Point(25, 32)
        Me.chbAll.Name = "chbAll"
        Me.chbAll.Size = New System.Drawing.Size(74, 19)
        Me.chbAll.TabIndex = 145
        Me.chbAll.Text = "Select All"
        Me.chbAll.UseVisualStyleBackColor = True
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 497)
        Me.Controls.Add(Me.chbAll)
        Me.Controls.Add(Me.dtPendingSearchDate)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cashier"
        Me.Text = "Cashier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dtPendingSearchDate As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents ClearanceCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents ClearanceID As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceFname As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceMname As DataGridViewTextBoxColumn
    Friend WithEvents ClearanceLname As DataGridViewTextBoxColumn
    Friend WithEvents chbAll As CheckBox
End Class
