Imports System.Data.SqlClient
Imports System.IO
Imports TableDependency.SqlClient.Base
Imports TableDependency.SqlClient.Base.Enums
Imports TableDependency.SqlClient

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
    Private Sub btnAdd_Save_Click(sender As Object, e As System.EventArgs) Handles btnAdd_Save.Click
        Try
            'SqlData()
            connection.Open()
            'command.CommandText = "INSERT INTO dbo.[police_clearance_certificate]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_OR_number], [payment_amount],[user_id],[qrcode],[payment_confirmed_user],[payment_confirmed_date]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,'signature','img','thumb',@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_OR_number, @payment_amount, " & user_id & ",'qrcode',1," & DateTime.Now.ToString("yyyy/MM/dd") & ")"
            command.CommandText = "INSERT INTO dbo.[pcc]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[purpose_id],[ctc_number],[ctc_issued_on],[ctc_issued_at],[signature],[img],[thumb],[pcc_number],[pcc_issue_date],[police_id_verify],[police_id_certify],[payment_OR_number],[payment_amount]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,@purpose_id,@ctc_number,@ctc_issued_on,@ctc_issued_at,'signature','img','thumb',@pcc_number,@pcc_issue_date,@police_id_verify,@police_id_certify,@payment_or_number, @payment_amount)"
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
            command.Parameters.AddWithValue("@payment_OR_number", txtORNo.Text.Trim)
            command.Parameters.AddWithValue("@payment_amount", txtORAmount.Text.Trim)

            'command.Parameters.AddWithValue("@user_id", user_id)
            command.ExecuteNonQuery()
            connection.Close()
            'File.Copy(imgFileToUpload, fileSavePath, True)
        Catch ex As Exception
            'connection.Close()
            MsgBox("Insert Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateCombobox()
        PopulateComboboxZone()
        PopulateComboboxBarangay()
        PopulateComboboxCivilStatus()
        PopulateComboboxPurpose()
        PopulateComboboxVerifiedBy()
        PopulateComboboxCertifiedBy()

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
            'command.CommandText = "SELECT pcc_number AS 'PCC NO', fname AS 'FIRST NAME',mname AS 'MIDDLE NAME',lname AS 'LAST NAME',UPPER(status) AS 'STATUS' FROM dbo.police_clearance_certificate"
            command.CommandText = "SELECT [pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname],[pcc].[status] FROM dbo.[pcc]"
            'command.CommandText = "SELECT [police_clearance_certificate].ctc_number, [police_clearance_certificate].fname, [police_clearance_certificate].mname, [police_clearance_certificate].lname, [police_clearance_certificate].status FROM dbo.[police_clearance_certificate]"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            dataApplicantPending.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataApplicantPending.Columns("dataPendingClearanceNo").DataPropertyName = "pcc_number"
            dataApplicantPending.Columns("dataPendingClearanceFname").DataPropertyName = "fname"
            dataApplicantPending.Columns("dataPendingClearanceMname").DataPropertyName = "mname"
            dataApplicantPending.Columns("dataPendingClearanceLname").DataPropertyName = "lname"
            dataApplicantPending.Columns("dataPendingClearanceStatus").DataPropertyName = "status"
            dataApplicantPending.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police Clearance Certificate - Pending Data Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
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
        Dim pccDependencyMapper = New TableDependency.SqlClient.Base.ModelToTableMapper(Of PoliceClearanceCertificate)()
        pccDependencyMapper.AddMapping(Function(c) c.PccNo, "pcc_number").AddMapping(Function(c) c.Fname, "fname").AddMapping(Function(c) c.Mname, "mname").AddMapping(Function(c) c.Lname, "lname").AddMapping(Function(c) c.Status, "status")
        Dim pccDependencyPending = New SqlTableDependency(Of PoliceClearanceCertificate)(connString, "pcc", "dbo", pccDependencyMapper)

        AddHandler pccDependencyPending.OnChanged, AddressOf OnPccDependencyPendingChanged

        pccDependencyPending.Start()

    End Sub
    Delegate Sub UpdatePccDependencyPending()
    Private Sub OnPccDependencyPendingChanged(ByVal sender As Object, ByVal e As TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs(Of PoliceClearanceCertificate))
        'MsgBox("Updated:" + e.ChangeType)

        'If e.ChangeType <> TableDependencySystem.Base.Enums.ChangeType.None Then
        Dim changedEntity = e.Entity
        Console.WriteLine("DML operation: " & e.ChangeType.ToString())
        Console.WriteLine("value: " & changedEntity.Fname)
        Dim reloadPccPendingData As UpdatePccDependencyPending = New UpdatePccDependencyPending(AddressOf LoadPCCPending)
        Me.Invoke(reloadPccPendingData, Nothing)

        'End If
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
End Class