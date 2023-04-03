﻿Imports System.Data.SqlClient
Imports System.IO
Imports TableDependency.SqlClient.Base
Imports TableDependency.SqlClient.Base.Enums
Imports TableDependency.SqlClient
Imports System.Net

Public Class Clerk2
    Friend user_id As Integer

    Private connString As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=ESPCS;Integrated Security=True"
    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)

    Private imgsPath_ApplicantPix As String = Directory.GetCurrentDirectory & "\bin\Debug\img_applicantpix\"
    Private imgsPath_ApplicantFingerprint As String = Directory.GetCurrentDirectory & "\bin\Debug\img_applicantfingerprint\"
    Private imgsPath_ApplicantSig As String = Directory.GetCurrentDirectory & "\bin\Debug\img_applicantsig\"

    'Values for Biological Sex
    Private male As Integer = 1
    Private female As Integer = 2
    Private bSex As Integer

    Private status_pending As String = "PENDING"
    Private status_paid As String = "PAID"
    Private status_validated As String = "VALIDATED"
    Private status_completed As String = "COMPLETED"

    'Private IsEditing As Boolean = False
    Private PccIDToEdit As Integer
    Dim pccDependencyPending As SqlTableDependency(Of PoliceClearanceCertificate)

    Private Sub btnAdd_Save_Click(sender As Object, e As System.EventArgs) Handles btnAdd_Save.Click
        If PccIDToEdit <> Nothing Then

            'Insert UPDATE data codes Here
            Try
                connection.Open()
                'UPDATE police SET fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, police_sig = @policesig, rank_id = @rankid, position_id = @positionid WHERE police_id =" & police_id
                command.CommandText = "UPDATE dbo.[pcc] SET [fname] = @fname, [mname] = @mname, [lname] = @lname, [zone_id] = @zone_id,[barangay_id] = @barangay_id,[cs_id] = @cs_id,[place_of_birth] = @place_of_birth,[date_of_birth] = @date_of_birth,[sex] = @sex,[height] = @height,[nationality] = @nationality,[contact_no] = @contact_no,[purpose_id] = @purpose_id,[ctc_number] = @ctc_number,[ctc_issued_on] = @ctc_issued_on,[ctc_issued_at] = @ctc_issued_at,[signature] = 'signature',[img] = 'img',[thumb] = 'thumb',[pcc_number] = @pcc_number,[pcc_issue_date] = @pcc_issue_date,[police_id_verify] = @police_id_verify,[police_id_certify] = @police_id_certify,[payment_or_number] = @payment_or_number,[payment_amount] = @payment_amount WHERE [pcc_id] = " & PccIDToEdit
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@pcc_number", txtClearanceNo.Text.Trim)
                command.Parameters.AddWithValue("@pcc_issue_date", dtClearanceDate.Value.Date)
                command.Parameters.AddWithValue("@fname", txtClearanceFname.Text.Trim)
                command.Parameters.AddWithValue("@mname", txtClearanceMname.Text.Trim)
                command.Parameters.AddWithValue("@lname", txtClearanceLname.Text.Trim)
                command.Parameters.AddWithValue("@barangay_id", cbBarangay.SelectedValue.ToString)
                command.Parameters.AddWithValue("@zone_id", cbZone.SelectedValue.ToString)
                command.Parameters.AddWithValue("@cs_id", cbCivilStatus.SelectedValue.ToString)
                command.Parameters.AddWithValue("@place_of_birth", txtBirthPlace.Text.Trim)
                command.Parameters.AddWithValue("@date_of_birth", dtBirthDate.Value.Date)
                If rbMale.Checked = True Then
                    bSex = male
                ElseIf rbFemale.Checked = True Then
                    bSex = female
                Else
                    bSex = 0
                End If
                command.Parameters.AddWithValue("@sex", bSex)
                command.Parameters.AddWithValue("@height", txtHeight.Text.Trim)
                command.Parameters.AddWithValue("@nationality", txtNationality.Text.Trim)
                command.Parameters.AddWithValue("@contact_no", txtContactNo.Text.Trim)
                command.Parameters.AddWithValue("@purpose_id", cbPurpose.SelectedValue.ToString)
                command.Parameters.AddWithValue("@ctc_number", txtCTCNo.Text.Trim)
                command.Parameters.AddWithValue("@ctc_issued_on", dtCTCIssueDate.Value.Date)
                command.Parameters.AddWithValue("@ctc_issued_at", txtCTCIssueAt.Text.Trim)

                ''command.Parameters.AddWithValue("@signature", fileSavePath)
                ''command.Parameters.AddWithValue("@img", fileSavePath)
                ''command.Parameters.AddWithValue("@thumb", fileSavePath)

                command.Parameters.AddWithValue("@police_id_verify", cbPoliceVerify.SelectedValue.ToString)
                command.Parameters.AddWithValue("@police_id_certify", cbPoliceCertify.SelectedValue.ToString)
                command.Parameters.AddWithValue("@payment_or_number", txtORNo.Text.Trim)
                command.Parameters.AddWithValue("@payment_amount", txtORAmount.Text.Trim)

                command.Parameters.AddWithValue("@user_id", user_id)
                command.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MsgBox("Update Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try

            PccIDToEdit = Nothing
            btnAdd_Save.Text = "Add"
            btnClear_Cancel.Text = "Clear"
            Clear()
        Else
            Try
                'SqlData()
                connection.Open()
                'command.CommandText = "INSERT INTO dbo.[police_clearance_certificate]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_OR_number], [payment_amount],[user_id],[qrcode],[payment_confirmed_user],[payment_confirmed_date]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,'signature','img','thumb',@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_OR_number, @payment_amount, " & user_id & ",'qrcode',1," & DateTime.Now.ToString("yyyy/MM/dd") & ")"
                command.CommandText = "INSERT INTO dbo.[pcc]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_or_number],[payment_amount],[user_id]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,'signature','img','thumb',@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_or_number, @payment_amount,@user_id)"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@pcc_number", txtClearanceNo.Text.Trim)
                command.Parameters.AddWithValue("@pcc_issue_date", dtClearanceDate.Value.Date)
                command.Parameters.AddWithValue("@fname", txtClearanceFname.Text.Trim)
                command.Parameters.AddWithValue("@mname", txtClearanceMname.Text.Trim)
                command.Parameters.AddWithValue("@lname", txtClearanceLname.Text.Trim)
                command.Parameters.AddWithValue("@barangay_id", cbBarangay.SelectedValue.ToString)
                command.Parameters.AddWithValue("@zone_id", cbZone.SelectedValue.ToString)
                command.Parameters.AddWithValue("@cs_id", cbCivilStatus.SelectedValue.ToString)
                command.Parameters.AddWithValue("@place_of_birth", txtBirthPlace.Text.Trim)
                command.Parameters.AddWithValue("@date_of_birth", dtBirthDate.Value.Date)
                If rbMale.Checked = True Then
                    bSex = male
                ElseIf rbFemale.Checked = True Then
                    bSex = female
                Else
                    bSex = 0
                End If
                command.Parameters.AddWithValue("@sex", bSex)
                command.Parameters.AddWithValue("@height", txtHeight.Text.Trim)
                command.Parameters.AddWithValue("@nationality", txtNationality.Text.Trim)
                command.Parameters.AddWithValue("@contact_no", txtContactNo.Text.Trim)
                command.Parameters.AddWithValue("@purpose_id", cbPurpose.SelectedValue.ToString)
                command.Parameters.AddWithValue("@ctc_number", txtCTCNo.Text.Trim)
                command.Parameters.AddWithValue("@ctc_issued_on", dtCTCIssueDate.Value.Date)
                command.Parameters.AddWithValue("@ctc_issued_at", txtCTCIssueAt.Text.Trim)

                ''command.Parameters.AddWithValue("@signature", fileSavePath)
                ''command.Parameters.AddWithValue("@img", fileSavePath)
                ''command.Parameters.AddWithValue("@thumb", fileSavePath)

                command.Parameters.AddWithValue("@police_id_verify", cbPoliceVerify.SelectedValue.ToString)
                command.Parameters.AddWithValue("@police_id_certify", cbPoliceCertify.SelectedValue.ToString)
                command.Parameters.AddWithValue("@payment_or_number", txtORNo.Text.Trim)
                command.Parameters.AddWithValue("@payment_amount", txtORAmount.Text.Trim)

                command.Parameters.AddWithValue("@user_id", user_id)
                command.ExecuteNonQuery()
                connection.Close()
                'File.Copy(imgFileToUpload, fileSavePath, True)
                Clear()
            Catch ex As Exception
                connection.Close()
                MsgBox("Insert Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If

    End Sub
    Private Sub PopulateCombobox()
        PopulateComboboxZone()
        PopulateComboboxBarangay()
        PopulateComboboxCivilStatus()
        PopulateComboboxPurpose()
        PopulateComboboxVerifiedBy()
        PopulateComboboxCertifiedBy()

    End Sub

    Private Sub Clear()
        txtClearanceFname.Text = ""
        txtClearanceMname.Text = ""
        txtClearanceLname.Text = ""
        cbZone.SelectedIndex = 0
        cbBarangay.SelectedIndex = 0
        cbCivilStatus.SelectedIndex = 0
        txtBirthPlace.Text = ""
        dtBirthDate.Value = DateTime.Now
        rbMale.Checked = True
        txtHeight.Text = ""
        txtNationality.Text = ""
        txtContactNo.Text = ""
        cbPurpose.SelectedIndex = 0
        txtCTCNo.Text = ""
        dtCTCIssueDate.Value = DateTime.Now
        txtCTCIssueAt.Text = ""
        'Insert Codes to Call Image Here([signature],[img],[thumb])
        txtClearanceNo.Text = ""
        dtClearanceDate.Value = DateTime.Now
        cbPoliceVerify.SelectedIndex = 0
        cbPoliceCertify.SelectedIndex = 0
        txtORNo.Text = ""
        txtORAmount.Text = ""
    End Sub
    Private Sub PopulateComboboxZone()
        Try
            connection.Open()
            command.CommandText = "SELECT zone_id AS 'ZONE ID', name AS 'ZONE NAME' FROM zone"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbZone.DisplayMember = dt.Columns("ZONE NAME").ToString
            cbZone.ValueMember = dt.Columns("ZONE ID").ToString
            cbZone.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Zone error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxBarangay()
        Try
            connection.Open()
            command.CommandText = "SELECT barangay_id AS 'BARANGAY ID', name AS 'BARANGAY NAME' FROM barangay"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbBarangay.DisplayMember = dt.Columns("BARANGAY NAME").ToString
            cbBarangay.ValueMember = dt.Columns("BARANGAY ID").ToString
            cbBarangay.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Barangay error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxCivilStatus()
        Try
            connection.Open()
            command.CommandText = "SELECT cs_id AS 'CIVILSTATUS ID', name AS 'CIVILSTATUS NAME' FROM civil_status"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbCivilStatus.DisplayMember = dt.Columns("CIVILSTATUS NAME").ToString
            cbCivilStatus.ValueMember = dt.Columns("CIVILSTATUS ID").ToString
            cbCivilStatus.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Civil Status error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxPurpose()
        Try
            connection.Open()
            command.CommandText = "SELECT purpose_id AS 'PURPOSE ID', name AS 'PURPOSE NAME' FROM purpose"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPurpose.DisplayMember = dt.Columns("PURPOSE NAME").ToString
            cbPurpose.ValueMember = dt.Columns("PURPOSE ID").ToString
            cbPurpose.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Purpose error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxVerifiedBy()
        Try
            connection.Open()
            command.CommandText = "SELECT police_id AS 'POLICE ID', CONCAT(fname,' ',mname,' ',lname) AS 'POLICE NAME' FROM police"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPoliceVerify.DisplayMember = dt.Columns("POLICE NAME").ToString
            cbPoliceVerify.ValueMember = dt.Columns("POLICE ID").ToString
            cbPoliceVerify.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police - Verified By error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxCertifiedBy()
        Try
            connection.Open()
            command.CommandText = "SELECT police_id AS 'POLICE ID', CONCAT(fname,' ',mname,' ',lname) AS 'POLICE NAME' FROM police"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPoliceCertify.DisplayMember = dt.Columns("POLICE NAME").ToString
            cbPoliceCertify.ValueMember = dt.Columns("POLICE ID").ToString
            cbPoliceCertify.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police  - Certified By error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub LoadPCCPending()
        Try
            connection.Open()
            command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE [pcc].[status] <> '" & status_completed & "'"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataApplicantPending.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataApplicantPending.Columns("dataPendingClearanceID").DataPropertyName = "pcc_id"
            dataApplicantPending.Columns("dataPendingClearanceNo").DataPropertyName = "pcc_number"
            dataApplicantPending.Columns("dataPendingClearanceFname").DataPropertyName = "fname"
            dataApplicantPending.Columns("dataPendingClearanceMname").DataPropertyName = "mname"
            dataApplicantPending.Columns("dataPendingClearanceLname").DataPropertyName = "lname"
            dataApplicantPending.Columns("dataPendingClearanceStatus").DataPropertyName = "status"
            dataApplicantPending.Columns("dataPendingClearanceID").Visible = False
            dataApplicantPending.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Clearance Certificate - Pending Data Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub LoadPCCCompleted()
        Try
            connection.Open()
            command.CommandText = "SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc] WHERE [pcc].[status] = '" & status_completed & "'"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataApplicantCompleted.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataApplicantCompleted.Columns("dataCompletedClearanceID").DataPropertyName = "pcc_id"
            dataApplicantCompleted.Columns("dataCompletedClearanceNo").DataPropertyName = "pcc_number"
            dataApplicantCompleted.Columns("dataCompletedClearanceFname").DataPropertyName = "fname"
            dataApplicantCompleted.Columns("dataCompletedClearanceMname").DataPropertyName = "mname"
            dataApplicantCompleted.Columns("dataCompletedClearanceLname").DataPropertyName = "lname"
            dataApplicantCompleted.Columns("dataCompletedClearanceStatus").DataPropertyName = "status"
            dataApplicantCompleted.Columns("dataCompletedClearanceID").Visible = False
            dataApplicantCompleted.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Clearance Certificate - Completed Data Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub Clerk2_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        'If user_id Then
        '    MsgBox("UserID:" & user_id)
        'End If
        rbMale.Checked = True

        If Not Directory.Exists(imgsPath_ApplicantPix) Then
            Directory.CreateDirectory(imgsPath_ApplicantPix)
            Console.WriteLine("Images Path for Applicant Pictures Created")
        End If
        If Not Directory.Exists(imgsPath_ApplicantFingerprint) Then
            Directory.CreateDirectory(imgsPath_ApplicantFingerprint)
            Console.WriteLine("Images Path for Applicant Fingerprint Created")
        End If
        If Not Directory.Exists(imgsPath_ApplicantSig) Then
            Directory.CreateDirectory(imgsPath_ApplicantSig)
            Console.WriteLine("Images Path for Applicant Signature Created")
        End If
        'Populating ComboBoxes
        PopulateCombobox()

        'Populate DataGrid
        LoadPCCPending()
        LoadPCCCompleted()


        Dim pccDependencyMapper = New TableDependency.SqlClient.Base.ModelToTableMapper(Of PoliceClearanceCertificate)()
        pccDependencyMapper.AddMapping(Function(c) c.PccNo, "pcc_number").AddMapping(Function(c) c.Fname, "fname").AddMapping(Function(c) c.Mname, "mname").AddMapping(Function(c) c.Lname, "lname").AddMapping(Function(c) c.Status, "status")
        pccDependencyPending = New SqlTableDependency(Of PoliceClearanceCertificate)(connString, "pcc", "dbo", pccDependencyMapper)

        AddHandler pccDependencyPending.OnChanged, AddressOf OnPccDependencyPendingChanged

        pccDependencyPending.Start()

    End Sub
    Delegate Sub UpdatePccDependencyPending()
    Private Sub OnPccDependencyPendingChanged(ByVal sender As Object, ByVal e As TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs(Of PoliceClearanceCertificate))
        'MsgBox("Updated:" + e.ChangeType)

        If e.ChangeType <> TableDependency.SqlClient.Base.Enums.ChangeType.None Then
            Dim changedEntity = e.Entity
            Console.WriteLine("DML operation: " & e.ChangeType.ToString())
            Console.WriteLine("value: " & changedEntity.Fname)
            Dim reloadPccPendingData As UpdatePccDependencyPending = New UpdatePccDependencyPending(AddressOf LoadPCCPending)
            Me.Invoke(reloadPccPendingData, Nothing)

        End If
    End Sub
    Private Sub btnCamera_Click(sender As Object, e As System.EventArgs) Handles btnCamera.Click
        Dim cameraForm As New CameraForm
        cameraForm.ShowDialog()
    End Sub

    Private Sub btnThumbmark_Click(sender As Object, e As System.EventArgs) Handles btnThumbmark.Click
        Dim fingerprintForm As New FingerprintForm
        fingerprintForm.ShowDialog()
    End Sub

    Private Sub btnSignature_Click(sender As Object, e As System.EventArgs) Handles btnSignature.Click
        Dim signatureForm As New SignatureForm
        signatureForm.ShowDialog()
    End Sub

    Private Sub dataApplicantPending_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataApplicantPending.RowsAdded
        For index As Integer = e.RowIndex To e.RowIndex + e.RowCount - 1
            Dim row As DataGridViewRow = dataApplicantPending.Rows(index)
            If dataApplicantPending.Rows(index).Cells("dataPendingClearanceStatus").Value.ToString.Trim.ToUpper = status_pending Then
                dataApplicantPending.Rows(index).Cells("dataPendingClearanceSetBtn").Value = "Validate"
                'ElseIf dataApplicantPending.Rows(index).Cells("dataPendingClearanceStatus").Value.ToString = "0" Then
                '    dataApplicantPending.Rows(index).Cells("dataButton").Value = "Confirm"
            End If
        Next
    End Sub

    Private Sub Clerk2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pccDependencyPending.Stop()

    End Sub

    Private Sub dataApplicantPending_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataApplicantPending.CellContentClick
        Dim colname As String = dataApplicantPending.Columns(e.ColumnIndex).Name
        If colname = "dataPendingClearanceEdit" Then
            Try
                Dim row As DataGridViewRow = dataApplicantPending.Rows(e.RowIndex)
                Dim pcc_id As Integer = row.Cells("dataPendingClearanceID").Value
                Dim result As DialogResult = MessageBox.Show("Confirm Edit?",
                              "Edit Applicant",
                              MessageBoxButtons.YesNo)
                If (result = DialogResult.Yes) Then
                    PccIDToEdit = pcc_id
                    If PccIDToEdit <> Nothing Then
                        btnAdd_Save.Text = "Save"
                        btnClear_Cancel.Text = "Cancel"
                    End If
                    connection.Open()
                    command.CommandText = "SELECT [pcc_id],[fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_OR_number],[payment_amount] FROM [pcc] WHERE [pcc_id] = " & pcc_id
                    Dim da As New SqlDataAdapter(command)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    If (dt.Rows.Count > 0) Then

                        txtClearanceFname.Text = dt.Rows(0).Item("fname")
                        txtClearanceMname.Text = dt.Rows(0).Item("mname")
                        txtClearanceLname.Text = dt.Rows(0).Item("lname")
                        cbZone.SelectedValue = dt.Rows(0).Item("zone_id")
                        cbBarangay.SelectedValue = dt.Rows(0).Item("barangay_id")
                        cbCivilStatus.SelectedValue = dt.Rows(0).Item("cs_id")
                        txtBirthPlace.Text = dt.Rows(0).Item("place_of_birth")
                        dtBirthDate.Value = dt.Rows(0).Item("date_of_birth")
                        If dt.Rows(0).Item("sex") = male Then
                            rbMale.Checked = True
                            rbFemale.Checked = False
                        ElseIf dt.Rows(0).Item("sex") = female Then
                            rbFemale.Checked = True
                            rbMale.Checked = False
                        Else
                            rbFemale.Checked = False
                            rbMale.Checked = False
                        End If
                        txtHeight.Text = dt.Rows(0).Item("height")
                        txtNationality.Text = dt.Rows(0).Item("nationality")
                        txtContactNo.Text = dt.Rows(0).Item("contact_no")
                        cbPurpose.SelectedValue = dt.Rows(0).Item("purpose_id")
                        txtCTCNo.Text = dt.Rows(0).Item("ctc_number")
                        dtCTCIssueDate.Value = dt.Rows(0).Item("ctc_issued_on")
                        txtCTCIssueAt.Text = dt.Rows(0).Item("ctc_issued_at")
                        'Insert Codes to Call Image Here([signature],[img],[thumb])
                        ',[pcc_number],[pcc_issue_date]
                        txtClearanceNo.Text = dt.Rows(0).Item("pcc_number")
                        dtClearanceDate.Value = dt.Rows(0).Item("pcc_issue_date")
                        cbPoliceVerify.SelectedValue = dt.Rows(0).Item("police_id_verify")
                        cbPoliceCertify.SelectedValue = dt.Rows(0).Item("police_id_certify")
                        txtORNo.Text = dt.Rows(0).Item("payment_OR_number")
                        txtORAmount.Text = dt.Rows(0).Item("payment_amount")
                    End If
                    connection.Close()
                End If
            Catch ex As Exception
                MsgBox("Police Clearance Pending Table - Edit Button error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        ElseIf colname = "dataPendingClearanceDelete" Then
            Try
                Dim row As DataGridViewRow = dataApplicantPending.Rows(e.RowIndex)
                Dim pcc_to_delete As Integer = row.Cells("dataPendingClearanceID").Value
                Dim result As DialogResult = MessageBox.Show("Confirm Delete?",
                              "Delete Applicant",
                              MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    quickSqlCommand("DELETE FROM dbo.[pcc] WHERE [pcc_id] =" & pcc_to_delete)
                End If
            Catch ex As Exception
                MsgBox("Police Clearance Pending Table - Delete Button error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'MsgBox("Data User: Column name does not exist")
            'Cellclick prompt
        End If
        connection.Close()
    End Sub
    Private Sub quickSqlCommand(commandString As String)
        connection.Open()
        command.CommandText = commandString
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub btnClear_Cancel_Click(sender As Object, e As System.EventArgs) Handles btnClear_Cancel.Click
        Clear()

    End Sub
End Class