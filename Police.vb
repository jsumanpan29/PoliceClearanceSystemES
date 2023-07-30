
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Police

    Friend police_id As Integer
    Friend prev_rank_id As Integer
    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)
    Private imgsPath_Police As String = (New ConfigHelper).GetPoliceSignatureImgPath
    Private fileName As String
    Private imgFileToUpload As String = ""
    Private fileSavePath As String = ""
    Private fileOldPath As String = ""
    Private currentDate As DateTime
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

        'Dim currentYear As Integer = currentDate.Year

        If Not Directory.Exists(imgsPath_Police) Then
            Directory.CreateDirectory(imgsPath_Police)
        End If
        If police_id Then
            Try
                'SqlData("UPDATE police SET fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, police_sig = @policesig, rank_id = @rankid, position_id = @positionid WHERE police_id =" & police_id)
                SqlData("UPDATE police SET fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, police_sig = @policesig, position_id = @positionid WHERE police_id =" & police_id & "; INSERT INTO promotion(police_id,promotion_date,prev_rank_id,curr_rank_id) VALUES(" & police_id & ",@currentDate," & prev_rank_id & ",@rankid)")

                If fileSavePath <> fileOldPath Then
                    File.Copy(imgFileToUpload, fileSavePath, True)
                End If
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Update Police error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            Try
                'SqlData("INSERT INTO police(fname,mname,lname,contact_no,police_sig,rank_id,position_id,deleted) VALUES(@fname,@mname,@lname,@contactno,@policesig,@rankid,@positionid,0)")
                'INSERT INTO police (fname, mname, lname, contact_no, police_sig, position_id, deleted) VALUES ('John', 'Doe', 'Smith', '1234567890', 'ABC123', 1, 0); DECLARE @NewPoliceID INT; SET @NewPoliceID = SCOPE_IDENTITY(); INSERT INTO promotion (police_id, promotion_date, prev_rank_id, curr_rank_id) VALUES (@NewPoliceID, '2023-07-26', 1, 2);
                SqlData("INSERT INTO police (fname, mname, lname, contact_no, police_sig, position_id, deleted) VALUES (@fname,@mname,@lname,@contactno,@policesig,@positionid,0); DECLARE @NewPoliceID INT; SET @NewPoliceID = SCOPE_IDENTITY(); INSERT INTO promotion (police_id, promotion_date, prev_rank_id, curr_rank_id) VALUES (@NewPoliceID, @currentDate," & prev_rank_id & ",@rankid)")

                File.Copy(imgFileToUpload, fileSavePath, True)
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Insert Police error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub
    Private Sub SqlData(sqlCommand As String)
        currentDate = DateTime.Now
        connection.Open()
        command = New SqlCommand("", connection)
        command.CommandText = sqlCommand
        command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
        command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
        command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
        command.Parameters.AddWithValue("@contactno", txtContactNo.Text.Trim)
        command.Parameters.AddWithValue("@policesig", fileSavePath)
        command.Parameters.AddWithValue("@currentDate", currentDate)
        command.Parameters.AddWithValue("@rankid", cbRank.SelectedValue.ToString)
        command.Parameters.AddWithValue("@positionid", cbPosition.SelectedValue.ToString)
        command.ExecuteNonQuery()
        connection.Close()
        command = Nothing
    End Sub
    Private Sub PopulateCombobox()
        PopulateComboboxRank()
        PopulateComboboxPosition()

    End Sub
    Private Sub PopulateComboboxRank()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT rank_id AS 'RANK ID', name AS 'RANK NAME' FROM rank"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbRank.DisplayMember = dt.Columns("RANK NAME").ToString
            cbRank.ValueMember = dt.Columns("RANK ID").ToString
            cbRank.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            MsgBox("Loading Rank error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub PopulateComboboxPosition()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT position_id AS 'POSITION ID', name AS 'POSITION NAME' FROM position"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbPosition.DisplayMember = dt.Columns("POSITION NAME").ToString
            cbPosition.ValueMember = dt.Columns("POSITION ID").ToString
            cbPosition.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            MsgBox("Loading Rank error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Police_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Preload data
        PopulateCombobox()
        If police_id Then
            connection.Open()
            command = New SqlCommand("", connection)
            'command.CommandText = "SELECT * FROM police WHERE deleted = 0 AND police_id = " & police_id
            command.CommandText = "SELECT police.*, MAX(rank.rank_id) AS 'RANK' FROM [dbo].police INNER JOIN [dbo].promotion ON promotion.police_id = police.police_id INNER JOIN [dbo].rank ON promotion.curr_rank_id = rank.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE promotion.promotion_date = (SELECT MAX(promotion_date) FROM dbo.promotion WHERE police_id = police.police_id) AND police.deleted=0 AND police.police_id = " & police_id & " GROUP BY police.police_id, police.fname, police.mname, police.lname, police.contact_no, police.police_sig, police.position_id, police.deleted"
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                txtFname.Text = dt.Rows(0).Item("fname")
                txtMname.Text = dt.Rows(0).Item("mname")
                txtLname.Text = dt.Rows(0).Item("lname")
                txtContactNo.Text = dt.Rows(0).Item("contact_no")
                If System.IO.File.Exists(dt.Rows(0).Item("police_sig")) Then
                    'The file exists

                    imgFileToUpload = dt.Rows(0).Item("police_sig")
                    fileName = Path.GetFileName(imgFileToUpload)
                    fileSavePath = Path.Combine(imgsPath_Police, fileName)
                    fileOldPath = fileSavePath
                    Using fs As New FileStream(imgFileToUpload, FileMode.Open, FileAccess.Read)
                        PictureBox1.Image = Image.FromStream(fs)
                    End Using
                Else
                    'the file doesn't exist
                    imgFileToUpload = ""
                    fileName = ""
                    fileSavePath = ""
                End If
                cbRank.SelectedValue = dt.Rows(0).Item("RANK")
                prev_rank_id = dt.Rows(0).Item("RANK")
                cbPosition.SelectedValue = dt.Rows(0).Item("position_id")
            End If
            connection.Close()
            command = Nothing
        Else
            'MsgBox("No police_ID")
        End If


        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub
    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        Dim opfDialog As New OpenFileDialog
        opfDialog.Filter = "Choose Image(*.jpg;*.png) | *.jpg; *.png"

        If opfDialog.ShowDialog = DialogResult.OK Then
            imgFileToUpload = opfDialog.FileName
            fileName = Path.GetFileName(imgFileToUpload)
            fileSavePath = Path.Combine(imgsPath_Police, fileName)
            Using fs As New FileStream(imgFileToUpload, FileMode.Open, FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
            End Using
        End If
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        Me.Dispose()
    End Sub

End Class