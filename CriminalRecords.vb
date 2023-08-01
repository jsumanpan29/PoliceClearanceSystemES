Imports System.Data.SqlClient
Imports System.IO

Public Class CriminalRecords

    Friend cr_id As Integer

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)

    Private imgsPath_Attachments As String = (New ConfigHelper).GetCriminalRecordsAttachmentPath
    Private fileName As String
    Private imgFileToUpload As String = ""
    Private fileSavePath As String = ""
    Private fileOldPath As String = ""
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If Not Directory.Exists(imgsPath_Attachments) Then
            Directory.CreateDirectory(imgsPath_Attachments)
        End If
        If cr_id Then
            Try
                SqlData("UPDATE criminal_records SET fname = @fname, mname = @mname, lname = @lname, crime_offense = @crimeoffense, ccno = @ccno, isno = @isno, remarks = @remarks, attachment = @attachment WHERE cr_id =" & cr_id)
                If fileSavePath <> fileOldPath Then
                    File.Copy(imgFileToUpload, fileSavePath, True)
                End If
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Update Criminal Record error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            Try
                SqlData("INSERT INTO criminal_records(fname,mname,lname,crime_offense,ccno,isno,remarks,attachment,deleted) VALUES(@fname,@mname,@lname,@crimeoffense,@ccno,@isno,@remarks,@attachment,0)")
                File.Copy(imgFileToUpload, fileSavePath, True)
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Insert Criminal Record error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        Me.Dispose()
    End Sub
    Private Sub SqlData(sqlCommand As String)
        connection.Open()
        command.CommandText = sqlCommand
        command.Parameters.AddWithValue("@fname", txtFName.Text.Trim)
        command.Parameters.AddWithValue("@mname", txtMName.Text.Trim)
        command.Parameters.AddWithValue("@lname", txtLName.Text.Trim)
        command.Parameters.AddWithValue("@crimeoffense", txtCrime.Text.Trim)
        command.Parameters.AddWithValue("@ccno", txtCCNO.Text.Trim)
        command.Parameters.AddWithValue("@isno", txtISNO.Text.Trim)
        command.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim)
        command.Parameters.AddWithValue("@attachment", fileSavePath)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub CriminalRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cr_id Then
            connection.Open()
            command.CommandText = "SELECT * FROM criminal_records WHERE deleted = 0 AND cr_id = " & cr_id
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                txtFName.Text = dt.Rows(0).Item("fname")
                txtMName.Text = dt.Rows(0).Item("mname")
                txtLName.Text = dt.Rows(0).Item("lname")
                txtCrime.Text = dt.Rows(0).Item("crime_offense")
                txtCCNO.Text = dt.Rows(0).Item("ccno")
                txtISNO.Text = dt.Rows(0).Item("isno")
                txtRemarks.Text = dt.Rows(0).Item("remarks")
                If System.IO.File.Exists(dt.Rows(0).Item("attachment")) Then
                    'The file exists

                    imgFileToUpload = dt.Rows(0).Item("attachment")
                    fileName = Path.GetFileName(imgFileToUpload)
                    fileSavePath = Path.Combine(imgsPath_Attachments, fileName)
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
            End If
            connection.Close()
        Else
            'MsgBox("No cr_id")
        End If
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        Dim opfDialog As New OpenFileDialog
        opfDialog.Filter = "Choose Image(*.jpg;*.png) | *.jpg; *.png"

        If opfDialog.ShowDialog = DialogResult.OK Then
            imgFileToUpload = opfDialog.FileName
            fileName = Path.GetFileName(imgFileToUpload)
            fileSavePath = Path.Combine(imgsPath_Attachments, fileName)
            Using fs As New FileStream(imgFileToUpload, FileMode.Open, FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
            End Using
        End If
    End Sub
End Class