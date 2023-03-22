Imports System.Data.SQLite
Imports System.IO

Public Class CriminalRecords

    Friend cr_id As Integer

    Private dbName As String = "ESPCS.db"
    Private dbPath As String = Directory.GetCurrentDirectory & "\bin\Debug\db\" & dbName
    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cr_id Then
            Try
                SqlData("UPDATE criminal_records SET name = @name, crime_offense = @crimeoffense, ccno = @ccno, isno = @isno, remarks = @remarks WHERE cr_id =" & cr_id)
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Update Criminal Record error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        Else
            Try
                SqlData("INSERT INTO criminal_records(name,crime_offense,ccno,isno,remarks,deleted) VALUES(@name,@crimeoffense,@ccno,@isno,@remarks,0)")
                Me.Dispose()
            Catch ex As Exception
                connection.Close()
                MsgBox("Insert Criminal Record error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub
    Private Sub SqlData(sqlCommand As String)
        connection.Open()
        command.CommandText = sqlCommand
        command.Parameters.AddWithValue("@name", txtName.Text.Trim)
        command.Parameters.AddWithValue("@crimeoffense", txtCrime.Text.Trim)
        command.Parameters.AddWithValue("@ccno", txtCCNO.Text.Trim)
        command.Parameters.AddWithValue("@isno", txtISNO.Text.Trim)
        command.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub CriminalRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cr_id Then
            connection.Open()
            command.CommandText = "SELECT * FROM criminal_records WHERE deleted = 0 AND cr_id = " & cr_id
            Dim da As New SQLiteDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                txtName.Text = dt.Rows(0).Item("name")
                txtCrime.Text = dt.Rows(0).Item("crime_offense")
                txtCCNO.Text = dt.Rows(0).Item("ccno")
                txtISNO.Text = dt.Rows(0).Item("isno")
                txtRemarks.Text = dt.Rows(0).Item("remarks")
            End If
            connection.Close()
        Else
            'MsgBox("No cr_id")
        End If


        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        Me.Dispose()
    End Sub
End Class