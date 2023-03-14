Imports System.Configuration
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
    End Sub

    Private Sub LoadAllTable()
        LoadUserTable()
    End Sub

    Private Sub LoadUserTable()
        connection.Open()
        command.CommandText = "SELECT user.user_id AS 'ID', user.username AS 'USERNAME', user.fname AS 'FIRST NAME', user.mname AS 'MIDDLE NAME', user.lname AS 'LAST NAME', user.contact_no AS 'CONTACT NUMBER', usertype.name AS 'USER ROLE' FROM user INNER JOIN usertype ON user.usertype_id = usertype.usertype_id WHERE user.usertype_id != 1"
        Dim da As New SQLiteDataAdapter(command)
        Dim dt As New DataTable()
        da.Fill(dt)
        'Setting Autogenerating of Columns to False to Utilize Designer made Columns
        dataUser.AutoGenerateColumns = False
        'Set DataPropertyName based on ColumnName from DataTable. ex. user.user_id AS 'ID' set dataUser.Columns(0).DataPropertyName = "ID"
        'If DataProperty is not set Data Wont display in that specific Column
        dataUser.Columns(0).DataPropertyName = "ID"
        dataUser.Columns(1).DataPropertyName = "USERNAME"
        dataUser.Columns(2).DataPropertyName = "FIRST NAME"
        dataUser.Columns(3).DataPropertyName = "MIDDLE NAME"
        dataUser.Columns(4).DataPropertyName = "LAST NAME"
        dataUser.Columns(5).DataPropertyName = "ID"
        dataUser.Columns(6).DataPropertyName = "USER ROLE"
        dataUser.DataSource = dt
    End Sub
End Class