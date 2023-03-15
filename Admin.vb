Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO

Public Class Admin
    Friend user_id As Integer

    Private dbName As String = "ESPCS.db"
    Private dbPath As String = Directory.GetCurrentDirectory & "\" & dbName
    'Private dbPath As String = Application.StartupPath & "\" & dbName
    'Private dbPath As String = "C:\Users\Predator\source\repos\PoliceClearanceSystemES" & "\" & dbName
    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user_id Then
            'MsgBox(Me.Name & " UserID:" & user_id)
            LoadAllTable()
        End If
        connection.Close()
    End Sub

    Private Sub LoadAllTable()
        LoadUserTable()
    End Sub

    Private Sub LoadUserTable()
        Try
            connection.Open()
            command.CommandText = "SELECT user.user_id AS 'ID', user.username AS 'USERNAME', user.fname AS 'FIRST NAME', user.mname AS 'MIDDLE NAME', user.lname AS 'LAST NAME', user.contact_no AS 'CONTACT NUMBER', usertype.name AS 'USER ROLE' FROM user INNER JOIN usertype ON user.usertype_id = usertype.usertype_id WHERE user.usertype_id != 1"
            Dim da As New SQLiteDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            'Setting Autogenerating of Columns to False to Utilize Designer made Columns
            dataUser.AutoGenerateColumns = False
            'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
            'If DataProperty is not set Data Wont display in that specific Column
            dataUser.Columns("dataUserID").DataPropertyName = "ID"
            dataUser.Columns("dataUserUname").DataPropertyName = "USERNAME"
            dataUser.Columns("dataUserFname").DataPropertyName = "FIRST NAME"
            dataUser.Columns("dataUserMname").DataPropertyName = "MIDDLE NAME"
            dataUser.Columns("dataUserLname").DataPropertyName = "LAST NAME"
            dataUser.Columns("dataUserContactNo").DataPropertyName = "CONTACT NUMBER"
            dataUser.Columns("dataUserUtype").DataPropertyName = "USER ROLE"
            dataUser.DataSource = dt
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading User error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try

    End Sub

    Private Sub dataUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUser.CellContentClick
        Dim colname As String = dataUser.Columns(e.ColumnIndex).Name
        If colname = "dataUserBtnEdit" Then
            Try
                Dim row As DataGridViewRow = dataUser.Rows(e.RowIndex)
                Dim userForm As New User
                userForm.user_id = row.Cells("dataUserID").Value
                userForm.ShowDialog()
                LoadUserTable()
            Catch ex As Exception
                MsgBox("User Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        ElseIf colname = "dataUserBtnDelete" Then
            Try
                Dim row As DataGridViewRow = dataUser.Rows(e.RowIndex)
                Dim user_id_to_delete As Integer = row.Cells("dataUserID").Value
                If (MessageBox.Show("Delete", "Are you sure you want to delete the data?", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    deleteUser("DELETE FROM user WHERE user_id =" & user_id_to_delete)
                End If
                LoadUserTable()
            Catch ex As Exception
                MsgBox("User Table error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            'MsgBox("Data User: Column name does not exist")
            'Cellclick prompt
        End If
        connection.Close()
    End Sub

    Private Sub deleteUser(deleteUserCommand As String)
        connection.Open()
        command.CommandText = deleteUserCommand
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub btnUserAdd_Click(sender As Object, e As EventArgs) Handles btnUserAdd.Click
        Dim userForm As New User
        userForm.ShowDialog()
        LoadUserTable()
    End Sub
End Class