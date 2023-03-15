Imports System.Data.SQLite
Imports System.IO

Public Class User
    Friend user_id As Integer
    Private dbName As String = "ESPCS.db"
    Private dbPath As String = Directory.GetCurrentDirectory & "\" & dbName
    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If value of user_id is passed here, execute update data then
        If user_id Then
            'MsgBox(Me.Name & " UserID:" & user_id)
            Try
                SqlData("UPDATE user SET username = @uname, password = @pword, fname = @fname, mname = @mname, lname = @lname, contact_no = @contactno, usertype_id = @utype_id WHERE user_id =" & user_id)
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Update User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'If no user_id value then add new User to data table
            Try
                SqlData("INSERT INTO user(username,password,fname,mname,lname,contact_no,usertype_id) VALUES(@uname,@pword,@fname,@mname,@lname,@contactno,@utype_id)")
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Insert User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
        connection.Close()
    End Sub
    Private Sub SqlData(sqlCommand As String)
        connection.Open()
        command.CommandText = sqlCommand
        command.Parameters.AddWithValue("@uname", txtUname.Text.Trim)
        command.Parameters.AddWithValue("@pword", txtPassword.Text.Trim)
        command.Parameters.AddWithValue("@fname", txtFname.Text.Trim)
        command.Parameters.AddWithValue("@mname", txtMname.Text.Trim)
        command.Parameters.AddWithValue("@lname", txtLname.Text.Trim)
        command.Parameters.AddWithValue("@contactno", txtContactNo.Text.Trim)
        command.Parameters.AddWithValue("@utype_id", cbUsertype.SelectedValue.ToString)

        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Preload data
        PopulateCombobox()
        'If value of user_id is passed here, execute update data then
        If user_id Then
            'MsgBox(Me.Name & " UserID:" & user_id)
            connection.Open()
            command.CommandText = "SELECT * FROM user WHERE user_id = " & user_id
            Dim da As New SQLiteDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                txtUname.Text = dt.Rows(0).Item("username")
                txtPassword.Text = dt.Rows(0).Item("password")
                txtFname.Text = dt.Rows(0).Item("fname")
                txtMname.Text = dt.Rows(0).Item("mname")
                txtLname.Text = dt.Rows(0).Item("lname")
                txtContactNo.Text = dt.Rows(0).Item("contact_no")
                cbUsertype.SelectedValue = dt.Rows(0).Item("usertype_id")
            End If
            connection.Close()
        Else
            'MsgBox("No user_ID")
        End If


        connection.Close()
    End Sub

    Private Sub PopulateCombobox()
        Try
            connection.Open()
            command.CommandText = "SELECT usertype_id AS 'USERTYPE ID', name AS 'USERTYPE NAME' FROM usertype WHERE usertype_id != 1"
            Dim da As New SQLiteDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbUsertype.DisplayMember = dt.Columns("USERTYPE NAME").ToString
            cbUsertype.ValueMember = dt.Columns("USERTYPE ID").ToString
            cbUsertype.DataSource = dt
            connection.Close()
        Catch ex As Exception
            MsgBox("Loading User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
End Class