Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Attachment
    Friend cr_id As Integer

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command
    Private imgsPath_Attachments As String = (New ConfigHelper).GetCriminalRecordsAttachmentPath
    Private fileName As String
    Private imgFileToUpload As String = ""
    Private fileSavePath As String = ""
    Private fileOldPath As String = ""
    Private Sub Attachment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT cr.[fname] + ' ' + cr.[mname] + ' ' + cr.[lname] AS [cr_name],cr.attachment FROM [dbo].[criminal_records] cr WHERE cr.[cr_id] = @cr_id"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@cr_id", cr_id)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            connection.Close()
            command = Nothing
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                TextBox2.Text = Convert.ToString(dt.Rows(0)(0))
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
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Attachment Error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub
End Class