<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clerk
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
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dataApplicant_ToPay = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dataApplicant_ToValidate = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dataApplicant_ToPrint = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dataApplicant_Cancelled = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dataApplicant_UnderInvestigation = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dataApplicant_Completed = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnApplicantSearch_ToPayRefresh = New System.Windows.Forms.Button()
        Me.txtApplicantSearch_ToPay = New System.Windows.Forms.TextBox()
        Me.btnApplicantSearch_ToValidateRefresh = New System.Windows.Forms.Button()
        Me.txtApplicantSearch_ToValidate = New System.Windows.Forms.TextBox()
        Me.btnApplicantSearch_ToPrintRefresh = New System.Windows.Forms.Button()
        Me.txtApplicantSearch_ToPrint = New System.Windows.Forms.TextBox()
        Me.btnApplicantSearch_CancelledRefresh = New System.Windows.Forms.Button()
        Me.txtApplicantSearch_Cancelled = New System.Windows.Forms.TextBox()
        Me.btnApplicantSearch_UnderInvestigationRefresh = New System.Windows.Forms.Button()
        Me.txtApplicantSearch_UnderInvestigation = New System.Windows.Forms.TextBox()
        Me.btnApplicantSearch_CompletedRefresh = New System.Windows.Forms.Button()
        Me.txtApplicantSearch_Completed = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dataApplicant_ToPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataApplicant_ToValidate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dataApplicant_ToPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dataApplicant_Cancelled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dataApplicant_UnderInvestigation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dataApplicant_Completed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'GenerateReportToolStripMenuItem
        '
        Me.GenerateReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToPDFToolStripMenuItem, Me.ToCSVToolStripMenuItem})
        Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
        Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
        '
        'ToPDFToolStripMenuItem
        '
        Me.ToPDFToolStripMenuItem.Name = "ToPDFToolStripMenuItem"
        Me.ToPDFToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ToPDFToolStripMenuItem.Text = "To PDF"
        '
        'ToCSVToolStripMenuItem
        '
        Me.ToCSVToolStripMenuItem.Name = "ToCSVToolStripMenuItem"
        Me.ToCSVToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ToCSVToolStripMenuItem.Text = "To CSV"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1042, 446)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnApplicantSearch_ToPayRefresh)
        Me.TabPage1.Controls.Add(Me.txtApplicantSearch_ToPay)
        Me.TabPage1.Controls.Add(Me.dataApplicant_ToPay)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1034, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "To Pay"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dataApplicant_ToPay
        '
        Me.dataApplicant_ToPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicant_ToPay.Location = New System.Drawing.Point(6, 34)
        Me.dataApplicant_ToPay.Name = "dataApplicant_ToPay"
        Me.dataApplicant_ToPay.RowTemplate.Height = 25
        Me.dataApplicant_ToPay.Size = New System.Drawing.Size(1022, 371)
        Me.dataApplicant_ToPay.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnApplicantSearch_ToValidateRefresh)
        Me.TabPage2.Controls.Add(Me.txtApplicantSearch_ToValidate)
        Me.TabPage2.Controls.Add(Me.dataApplicant_ToValidate)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1034, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "To Validate"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dataApplicant_ToValidate
        '
        Me.dataApplicant_ToValidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicant_ToValidate.Location = New System.Drawing.Point(6, 35)
        Me.dataApplicant_ToValidate.Name = "dataApplicant_ToValidate"
        Me.dataApplicant_ToValidate.RowTemplate.Height = 25
        Me.dataApplicant_ToValidate.Size = New System.Drawing.Size(1022, 371)
        Me.dataApplicant_ToValidate.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnApplicantSearch_ToPrintRefresh)
        Me.TabPage3.Controls.Add(Me.txtApplicantSearch_ToPrint)
        Me.TabPage3.Controls.Add(Me.dataApplicant_ToPrint)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1034, 418)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "To Print"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dataApplicant_ToPrint
        '
        Me.dataApplicant_ToPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicant_ToPrint.Location = New System.Drawing.Point(9, 35)
        Me.dataApplicant_ToPrint.Name = "dataApplicant_ToPrint"
        Me.dataApplicant_ToPrint.RowTemplate.Height = 25
        Me.dataApplicant_ToPrint.Size = New System.Drawing.Size(1022, 371)
        Me.dataApplicant_ToPrint.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnApplicantSearch_CancelledRefresh)
        Me.TabPage4.Controls.Add(Me.txtApplicantSearch_Cancelled)
        Me.TabPage4.Controls.Add(Me.dataApplicant_Cancelled)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1034, 418)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Cancelled"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dataApplicant_Cancelled
        '
        Me.dataApplicant_Cancelled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicant_Cancelled.Location = New System.Drawing.Point(3, 34)
        Me.dataApplicant_Cancelled.Name = "dataApplicant_Cancelled"
        Me.dataApplicant_Cancelled.RowTemplate.Height = 25
        Me.dataApplicant_Cancelled.Size = New System.Drawing.Size(1022, 371)
        Me.dataApplicant_Cancelled.TabIndex = 6
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnApplicantSearch_UnderInvestigationRefresh)
        Me.TabPage5.Controls.Add(Me.txtApplicantSearch_UnderInvestigation)
        Me.TabPage5.Controls.Add(Me.dataApplicant_UnderInvestigation)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1034, 418)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Under Investigation"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dataApplicant_UnderInvestigation
        '
        Me.dataApplicant_UnderInvestigation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicant_UnderInvestigation.Location = New System.Drawing.Point(3, 36)
        Me.dataApplicant_UnderInvestigation.Name = "dataApplicant_UnderInvestigation"
        Me.dataApplicant_UnderInvestigation.RowTemplate.Height = 25
        Me.dataApplicant_UnderInvestigation.Size = New System.Drawing.Size(1022, 371)
        Me.dataApplicant_UnderInvestigation.TabIndex = 6
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnApplicantSearch_CompletedRefresh)
        Me.TabPage6.Controls.Add(Me.txtApplicantSearch_Completed)
        Me.TabPage6.Controls.Add(Me.dataApplicant_Completed)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1034, 418)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Completed"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dataApplicant_Completed
        '
        Me.dataApplicant_Completed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataApplicant_Completed.Location = New System.Drawing.Point(9, 34)
        Me.dataApplicant_Completed.Name = "dataApplicant_Completed"
        Me.dataApplicant_Completed.RowTemplate.Height = 25
        Me.dataApplicant_Completed.Size = New System.Drawing.Size(1022, 371)
        Me.dataApplicant_Completed.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(975, 479)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnApplicantSearch_ToPayRefresh
        '
        Me.btnApplicantSearch_ToPayRefresh.Location = New System.Drawing.Point(953, 6)
        Me.btnApplicantSearch_ToPayRefresh.Name = "btnApplicantSearch_ToPayRefresh"
        Me.btnApplicantSearch_ToPayRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantSearch_ToPayRefresh.TabIndex = 9
        Me.btnApplicantSearch_ToPayRefresh.Text = "x"
        Me.btnApplicantSearch_ToPayRefresh.UseVisualStyleBackColor = True
        '
        'txtApplicantSearch_ToPay
        '
        Me.txtApplicantSearch_ToPay.Location = New System.Drawing.Point(721, 7)
        Me.txtApplicantSearch_ToPay.Name = "txtApplicantSearch_ToPay"
        Me.txtApplicantSearch_ToPay.Size = New System.Drawing.Size(226, 23)
        Me.txtApplicantSearch_ToPay.TabIndex = 8
        '
        'btnApplicantSearch_ToValidateRefresh
        '
        Me.btnApplicantSearch_ToValidateRefresh.Location = New System.Drawing.Point(953, 6)
        Me.btnApplicantSearch_ToValidateRefresh.Name = "btnApplicantSearch_ToValidateRefresh"
        Me.btnApplicantSearch_ToValidateRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantSearch_ToValidateRefresh.TabIndex = 9
        Me.btnApplicantSearch_ToValidateRefresh.Text = "x"
        Me.btnApplicantSearch_ToValidateRefresh.UseVisualStyleBackColor = True
        '
        'txtApplicantSearch_ToValidate
        '
        Me.txtApplicantSearch_ToValidate.Location = New System.Drawing.Point(721, 7)
        Me.txtApplicantSearch_ToValidate.Name = "txtApplicantSearch_ToValidate"
        Me.txtApplicantSearch_ToValidate.Size = New System.Drawing.Size(226, 23)
        Me.txtApplicantSearch_ToValidate.TabIndex = 8
        '
        'btnApplicantSearch_ToPrintRefresh
        '
        Me.btnApplicantSearch_ToPrintRefresh.Location = New System.Drawing.Point(956, 6)
        Me.btnApplicantSearch_ToPrintRefresh.Name = "btnApplicantSearch_ToPrintRefresh"
        Me.btnApplicantSearch_ToPrintRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantSearch_ToPrintRefresh.TabIndex = 9
        Me.btnApplicantSearch_ToPrintRefresh.Text = "x"
        Me.btnApplicantSearch_ToPrintRefresh.UseVisualStyleBackColor = True
        '
        'txtApplicantSearch_ToPrint
        '
        Me.txtApplicantSearch_ToPrint.Location = New System.Drawing.Point(724, 7)
        Me.txtApplicantSearch_ToPrint.Name = "txtApplicantSearch_ToPrint"
        Me.txtApplicantSearch_ToPrint.Size = New System.Drawing.Size(226, 23)
        Me.txtApplicantSearch_ToPrint.TabIndex = 8
        '
        'btnApplicantSearch_CancelledRefresh
        '
        Me.btnApplicantSearch_CancelledRefresh.Location = New System.Drawing.Point(950, 5)
        Me.btnApplicantSearch_CancelledRefresh.Name = "btnApplicantSearch_CancelledRefresh"
        Me.btnApplicantSearch_CancelledRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantSearch_CancelledRefresh.TabIndex = 9
        Me.btnApplicantSearch_CancelledRefresh.Text = "x"
        Me.btnApplicantSearch_CancelledRefresh.UseVisualStyleBackColor = True
        '
        'txtApplicantSearch_Cancelled
        '
        Me.txtApplicantSearch_Cancelled.Location = New System.Drawing.Point(718, 6)
        Me.txtApplicantSearch_Cancelled.Name = "txtApplicantSearch_Cancelled"
        Me.txtApplicantSearch_Cancelled.Size = New System.Drawing.Size(226, 23)
        Me.txtApplicantSearch_Cancelled.TabIndex = 8
        '
        'btnApplicantSearch_UnderInvestigationRefresh
        '
        Me.btnApplicantSearch_UnderInvestigationRefresh.Location = New System.Drawing.Point(950, 7)
        Me.btnApplicantSearch_UnderInvestigationRefresh.Name = "btnApplicantSearch_UnderInvestigationRefresh"
        Me.btnApplicantSearch_UnderInvestigationRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantSearch_UnderInvestigationRefresh.TabIndex = 9
        Me.btnApplicantSearch_UnderInvestigationRefresh.Text = "x"
        Me.btnApplicantSearch_UnderInvestigationRefresh.UseVisualStyleBackColor = True
        '
        'txtApplicantSearch_UnderInvestigation
        '
        Me.txtApplicantSearch_UnderInvestigation.Location = New System.Drawing.Point(718, 8)
        Me.txtApplicantSearch_UnderInvestigation.Name = "txtApplicantSearch_UnderInvestigation"
        Me.txtApplicantSearch_UnderInvestigation.Size = New System.Drawing.Size(226, 23)
        Me.txtApplicantSearch_UnderInvestigation.TabIndex = 8
        '
        'btnApplicantSearch_CompletedRefresh
        '
        Me.btnApplicantSearch_CompletedRefresh.Location = New System.Drawing.Point(956, 5)
        Me.btnApplicantSearch_CompletedRefresh.Name = "btnApplicantSearch_CompletedRefresh"
        Me.btnApplicantSearch_CompletedRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnApplicantSearch_CompletedRefresh.TabIndex = 9
        Me.btnApplicantSearch_CompletedRefresh.Text = "x"
        Me.btnApplicantSearch_CompletedRefresh.UseVisualStyleBackColor = True
        '
        'txtApplicantSearch_Completed
        '
        Me.txtApplicantSearch_Completed.Location = New System.Drawing.Point(724, 6)
        Me.txtApplicantSearch_Completed.Name = "txtApplicantSearch_Completed"
        Me.txtApplicantSearch_Completed.Size = New System.Drawing.Size(226, 23)
        Me.txtApplicantSearch_Completed.TabIndex = 8
        '
        'Clerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 530)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Clerk"
        Me.Text = "Clerk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dataApplicant_ToPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataApplicant_ToValidate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dataApplicant_ToPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dataApplicant_Cancelled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dataApplicant_UnderInvestigation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dataApplicant_Completed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dataApplicant_ToPay As DataGridView
    Friend WithEvents dataApplicant_ToValidate As DataGridView
    Friend WithEvents dataApplicant_ToPrint As DataGridView
    Friend WithEvents dataApplicant_Cancelled As DataGridView
    Friend WithEvents dataApplicant_UnderInvestigation As DataGridView
    Friend WithEvents dataApplicant_Completed As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents GenerateReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnApplicantSearch_ToPayRefresh As Button
    Friend WithEvents txtApplicantSearch_ToPay As TextBox
    Friend WithEvents btnApplicantSearch_ToValidateRefresh As Button
    Friend WithEvents txtApplicantSearch_ToValidate As TextBox
    Friend WithEvents btnApplicantSearch_ToPrintRefresh As Button
    Friend WithEvents txtApplicantSearch_ToPrint As TextBox
    Friend WithEvents btnApplicantSearch_CancelledRefresh As Button
    Friend WithEvents txtApplicantSearch_Cancelled As TextBox
    Friend WithEvents btnApplicantSearch_UnderInvestigationRefresh As Button
    Friend WithEvents txtApplicantSearch_UnderInvestigation As TextBox
    Friend WithEvents btnApplicantSearch_CompletedRefresh As Button
    Friend WithEvents txtApplicantSearch_Completed As TextBox
End Class
