<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnUserAdd = New System.Windows.Forms.Button()
        Me.dataUser = New System.Windows.Forms.DataGridView()
        Me.dataUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserUname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserMname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserUtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataUserBtnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dataUserBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Button11)
        Me.TabPage7.Controls.Add(Me.TextBox6)
        Me.TabPage7.Controls.Add(Me.Button12)
        Me.TabPage7.Controls.Add(Me.DataGridView6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1038, 593)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Criminal Records"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(954, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 7
        Me.Button11.Text = "Search"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(722, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(226, 23)
        Me.TextBox6.TabIndex = 6
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(954, 427)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "Add"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(3, 33)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowTemplate.Height = 25
        Me.DataGridView6.Size = New System.Drawing.Size(1026, 388)
        Me.DataGridView6.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1038, 593)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Police"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(954, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(722, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(226, 23)
        Me.TextBox2.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(954, 429)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(3, 35)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(1026, 388)
        Me.DataGridView2.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.btnUserAdd)
        Me.TabPage2.Controls.Add(Me.dataUser)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1038, 459)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(957, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(725, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 23)
        Me.TextBox1.TabIndex = 2
        '
        'btnUserAdd
        '
        Me.btnUserAdd.Location = New System.Drawing.Point(957, 430)
        Me.btnUserAdd.Name = "btnUserAdd"
        Me.btnUserAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnUserAdd.TabIndex = 1
        Me.btnUserAdd.Text = "Add"
        Me.btnUserAdd.UseVisualStyleBackColor = True
        '
        'dataUser
        '
        Me.dataUser.AllowUserToAddRows = False
        Me.dataUser.AllowUserToDeleteRows = False
        Me.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataUserID, Me.dataUserUname, Me.dataUserFname, Me.dataUserMname, Me.dataUserLname, Me.dataUserContactNo, Me.dataUserUtype, Me.dataUserBtnEdit, Me.dataUserBtnDelete})
        Me.dataUser.Location = New System.Drawing.Point(6, 36)
        Me.dataUser.Name = "dataUser"
        Me.dataUser.ReadOnly = True
        Me.dataUser.RowTemplate.Height = 25
        Me.dataUser.Size = New System.Drawing.Size(1026, 388)
        Me.dataUser.TabIndex = 0
        '
        'dataUserID
        '
        Me.dataUserID.HeaderText = "ID"
        Me.dataUserID.Name = "dataUserID"
        Me.dataUserID.ReadOnly = True
        '
        'dataUserUname
        '
        Me.dataUserUname.HeaderText = "USERNAME"
        Me.dataUserUname.Name = "dataUserUname"
        Me.dataUserUname.ReadOnly = True
        '
        'dataUserFname
        '
        Me.dataUserFname.HeaderText = "FIRST NAME"
        Me.dataUserFname.Name = "dataUserFname"
        Me.dataUserFname.ReadOnly = True
        '
        'dataUserMname
        '
        Me.dataUserMname.HeaderText = "MIDDLE NAME"
        Me.dataUserMname.Name = "dataUserMname"
        Me.dataUserMname.ReadOnly = True
        '
        'dataUserLname
        '
        Me.dataUserLname.HeaderText = "LAST NAME"
        Me.dataUserLname.Name = "dataUserLname"
        Me.dataUserLname.ReadOnly = True
        '
        'dataUserContactNo
        '
        Me.dataUserContactNo.HeaderText = "CONTACT NUMBER"
        Me.dataUserContactNo.Name = "dataUserContactNo"
        Me.dataUserContactNo.ReadOnly = True
        '
        'dataUserUtype
        '
        Me.dataUserUtype.HeaderText = "USER ROLE"
        Me.dataUserUtype.Name = "dataUserUtype"
        Me.dataUserUtype.ReadOnly = True
        '
        'dataUserBtnEdit
        '
        Me.dataUserBtnEdit.HeaderText = ""
        Me.dataUserBtnEdit.Name = "dataUserBtnEdit"
        Me.dataUserBtnEdit.ReadOnly = True
        Me.dataUserBtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUserBtnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataUserBtnEdit.Text = "Edit"
        Me.dataUserBtnEdit.UseColumnTextForButtonValue = True
        '
        'dataUserBtnDelete
        '
        Me.dataUserBtnDelete.HeaderText = ""
        Me.dataUserBtnDelete.Name = "dataUserBtnDelete"
        Me.dataUserBtnDelete.ReadOnly = True
        Me.dataUserBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUserBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dataUserBtnDelete.Text = "Delete"
        Me.dataUserBtnDelete.UseColumnTextForButtonValue = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1038, 459)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(681, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 177)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(378, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 177)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(70, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 177)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1046, 487)
        Me.TabControl1.TabIndex = 0
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 518)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnUserAdd As Button
    Friend WithEvents dataUser As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents dataUserID As DataGridViewTextBoxColumn
    Friend WithEvents dataUserUname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserFname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserMname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserLname As DataGridViewTextBoxColumn
    Friend WithEvents dataUserContactNo As DataGridViewTextBoxColumn
    Friend WithEvents dataUserUtype As DataGridViewTextBoxColumn
    Friend WithEvents dataUserBtnEdit As DataGridViewButtonColumn
    Friend WithEvents dataUserBtnDelete As DataGridViewButtonColumn
End Class
