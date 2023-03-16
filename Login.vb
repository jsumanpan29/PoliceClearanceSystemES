
Imports System.Data.SQLite
Imports System.IO

Public Class Login
    Private dbName As String = "ESPCS.db"
    Private dbPath As String = Directory.GetCurrentDirectory & "\bin\Debug\db\" & dbName
    'Private dbPath As String = Application.StartupPath & "\" & dbName
    'Private dbPath As String = "C:\Users\Predator\source\repos\PoliceClearanceSystemES" & "\" & dbName
    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Private usertype_admin As Integer = 1
    Private usertype_clerk As Integer = 2
    Private usertype_cashier As Integer = 3
    'User default values
    Private user_id As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtUser.Text.Trim = "" And txtPassword.Text.Trim = "") Then
            MsgBox("Username & Password Empty")
        ElseIf txtUser.Text.Trim = "" Then
            MsgBox("Username Empty")
        ElseIf txtPassword.Text.Trim = "" Then
            MsgBox("Password Empty")
        Else
            Try
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    MsgBox("Logging In")
                    'command.CommandText = "SELECT * FROM user WHERE username = @user AND password= @pass"
                    command.CommandText = "SELECT * FROM user WHERE username = @user AND password= @pass AND deleted=0"
                    command.Parameters.AddWithValue("@user", txtUser.Text.Trim)
                    command.Parameters.AddWithValue("@pass", txtPassword.Text.Trim)
                    Dim da As New SQLiteDataAdapter(command)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    If (dt.Rows.Count > 0) Then
                        'MsgBox("Logged In")
                        If dt.Rows(0).Item("usertype_id") = usertype_admin Then
                            'prompt.Text = "Username:" & dt.Rows(0).Item("username") & ",Usertype:" & usertype_admin
                            user_id = dt.Rows(0).Item("user_id")
                            Admin.user_id = user_id
                            Admin.Show()
                            Me.Hide()

                        ElseIf dt.Rows(0).Item("usertype_id") = usertype_clerk Then
                            user_id = dt.Rows(0).Item("user_id")
                            Clerk.user_id = user_id
                            Clerk.Show()
                            Me.Hide()
                        ElseIf dt.Rows(0).Item("usertype_id") = usertype_cashier Then
                            user_id = dt.Rows(0).Item("user_id")
                            Cashier.user_id = user_id
                            Cashier.Show()
                            Me.Hide()
                        Else
                            MsgBox("User Usertype nonexistent")
                        End If
                    Else
                        MsgBox("User nonexistent")
                    End If
                End If
                connection.Close()
            Catch ex As Exception
                MsgBox("Connection Error!: Cannot connect to Database")
            End Try
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Database Connected")
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox("Connection Error!: Cannot connect to Database")
            connection.Close()
        End Try


    End Sub
End Class
