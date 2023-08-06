Imports System.Data.SqlClient
Imports AForge.Controls
Imports System.Drawing.Imaging
Imports MaterialSkin2Framework.Controls

Public Class Applicant
    Friend applicant_id As Integer
    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command
    'Values for Biological Sex
    Private male As Integer = 1
    Private female As Integer = 2
    Private bSex As Integer
    Private Sub PopulateCombobox()
        PopulateComboboxZone()
        PopulateComboboxBarangay()
        PopulateComboboxCivilStatus()

    End Sub
    'Private Sub SqlData(sqlCommand As String)
    '    connection.Open()
    '    command = New SqlCommand("", connection)
    '    command.CommandText = sqlCommand
    '    command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
    '    command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
    '    command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
    '    command.Parameters.AddWithValue("@contactno", txtContactNo.Text.Trim)
    '    command.Parameters.AddWithValue("@policesig", fileSavePath)
    '    command.Parameters.AddWithValue("@currentDate", currentDate)
    '    command.Parameters.AddWithValue("@rankid", cbRank.SelectedValue.ToString)
    '    command.Parameters.AddWithValue("@positionid", cbPosition.SelectedValue.ToString)
    '    command.ExecuteNonQuery()
    '    connection.Close()
    '    command = Nothing
    'End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrEmpty(txtFname.Text) Then
            ' Code to execute if txtFname.Text is empty or null
            ' For example:
            MaterialMessageBox.Show("Please enter a first name.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        ElseIf String.IsNullOrEmpty(txtMname.Text) Then
            MaterialMessageBox.Show("Please enter a middle name.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        ElseIf String.IsNullOrEmpty(txtLname.Text) Then
            MaterialMessageBox.Show("Please enter a last name.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        ElseIf String.IsNullOrEmpty(txtBirthPlace.Text) Then
            MaterialMessageBox.Show("Please enter birth place.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        ElseIf String.IsNullOrEmpty(txtHeight.Text) Then
            MaterialMessageBox.Show("Please enter height.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        ElseIf String.IsNullOrEmpty(txtNationality.Text) Then
            MaterialMessageBox.Show("Please enter nationality.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        ElseIf String.IsNullOrEmpty(txtContactNo.Text) Then
            MaterialMessageBox.Show("Please enter contact number.", "Applicant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, False)
        Else
            If applicant_id <> Nothing Then

                'Insert UPDATE data codes Here
                Try
                    connection.Open()
                    'UPDATE police SET fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, police_sig = @policesig, rank_id = @rankid, position_id = @positionid WHERE police_id =" & police_id
                    command = New SqlCommand("", connection)
                    command.CommandText = "UPDATE dbo.[applicant] SET [fname] = @fname, [mname] = @mname, [lname] = @lname, [zone_id] = @zone_id,[barangay_id] = @barangay_id,[cs_id] = @cs_id,[place_of_birth] = @place_of_birth,[date_of_birth] = @date_of_birth,[sex] = @sex,[height] = @height,[nationality] = @nationality,[contact_no] = @contact_no WHERE [applicant_id] = " & applicant_id
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
                    command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
                    command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
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
                    command.ExecuteNonQuery()
                    connection.Close()
                    command = Nothing
                    Me.Dispose()
                Catch ex As Exception
                    connection.Close()
                    MsgBox("Update Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                End Try
            Else
                Try
                    'SqlData()
                    connection.Open()
                    command = New SqlCommand("", connection)
                    command.CommandText = "INSERT INTO dbo.[applicant]([fname],[mname],[lname],[zone_id],[barangay_id],[cs_id],[place_of_birth],[date_of_birth],[sex],[height],[nationality],[contact_no],[deleted]) VALUES(@fname,@mname,@lname,@zone_id,@barangay_id,@cs_id,@place_of_birth,@date_of_birth,@sex,@height,@nationality,@contact_no,0)"
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
                    command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
                    command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
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
                    command.ExecuteNonQuery()
                    connection.Close()
                    command = Nothing
                    'File.Copy(imgFileToUpload, fileSavePath, True)
                    Me.Dispose()
                Catch ex As Exception
                    connection.Close()
                    MsgBox("Insert Police Clearance error" & vbCrLf & String.Format("Error: {0}", ex.Message))
                End Try
            End If
        End If




    End Sub

    Private Sub PopulateComboboxZone()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT zone_id AS 'ZONE ID', name AS 'ZONE NAME' FROM zone"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbZone.DisplayMember = dt.Columns("ZONE NAME").ToString
            cbZone.ValueMember = dt.Columns("ZONE ID").ToString
            cbZone.DataSource = dt
            connection.Close()
            command = Nothing

        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Zone error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxBarangay()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT barangay_id AS 'BARANGAY ID', name AS 'BARANGAY NAME' FROM barangay"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbBarangay.DisplayMember = dt.Columns("BARANGAY NAME").ToString
            cbBarangay.ValueMember = dt.Columns("BARANGAY ID").ToString
            cbBarangay.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Barangay error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxCivilStatus()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT cs_id AS 'CIVILSTATUS ID', name AS 'CIVILSTATUS NAME' FROM civil_status"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbCivilStatus.DisplayMember = dt.Columns("CIVILSTATUS NAME").ToString
            cbCivilStatus.ValueMember = dt.Columns("CIVILSTATUS ID").ToString
            cbCivilStatus.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Civil Status error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Applicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox()
        rbMale.Checked = True
        If applicant_id Then
            'MsgBox(Me.Name & " UserID:" & user_id)
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT * FROM [applicant] WHERE deleted = 0 AND applicant_id = " & applicant_id
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                txtFname.Text = dt.Rows(0).Item("fname")
                txtMname.Text = dt.Rows(0).Item("mname")
                txtLname.Text = dt.Rows(0).Item("lname")
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
            End If
            connection.Close()
            command = Nothing
        Else
            'MsgBox("No user_ID")
        End If


        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        Me.Dispose()

    End Sub
End Class