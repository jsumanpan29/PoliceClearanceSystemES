Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports System.Data.SqlClient

Public Class PoliceHistory
    Friend police_id As Integer
    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command
    Private Sub PoliceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPoliceHistory()
        LoadPoliceName()
    End Sub
    Private Sub LoadPoliceHistory()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT r_prev.[name] AS [PREV RANK], r_curr.[name] AS [CURR RANK], pr.[promotion_date] AS [DATE] FROM [dbo].[promotion] pr JOIN [dbo].[police] p ON pr.[police_id] = p.[police_id] LEFT JOIN [dbo].[rank] r_prev ON pr.[prev_rank_id] = r_prev.[rank_id] LEFT JOIN [dbo].[rank] r_curr ON pr.[curr_rank_id] = r_curr.[rank_id] WHERE p.[police_id] = @police_id ORDER BY pr.[promotion_date] DESC;"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@police_id", police_id)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns("policeHistoryPrevRank").DataPropertyName = "PREV RANK"
            DataGridView1.Columns("policeHistoryCurrRank").DataPropertyName = "CURR RANK"
            DataGridView1.Columns("policeHistoryDate").DataPropertyName = "DATE"
            DataGridView1.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police History error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub LoadPoliceName()
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "SELECT p.[fname] + ' ' + p.[mname] + ' ' + p.[lname] AS [police_name] FROM [dbo].[police] p WHERE p.[police_id] = @police_id"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@police_id", police_id)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            connection.Close()
            command = Nothing
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                TextBox1.Text = Convert.ToString(dt.Rows(0)(0))
            End If
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Police History - Police Name" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub
End Class