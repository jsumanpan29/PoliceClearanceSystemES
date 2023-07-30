Imports System.Data.SqlClient
Imports MaterialSkin2Framework.Controls
Public Class PoliceOfficers
    Friend user_id As Integer
    Friend verifiedBy_id As Integer
    Friend certifiedBy_id As Integer

    Private connString As String = (New ConfigHelper).ConnectionString
    Private connection As New SqlConnection(connString)
    Private command

    Private Sub PoliceOfficers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVerifiedByPolice()
        LoadCertifiedByPolice()


        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView_CellContentClick_OnlyOneChecked
        AddHandler DataGridView2.CellContentClick, AddressOf DataGridView_CellContentClick_OnlyOneChecked

        SetCheckedRow()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim verified_id As Integer = 0
        Dim certified_id As Integer = 0
        Dim result As DialogResult = MaterialMessageBox.Show("Confirm Police Officers to Verify/Certify Police Clearance Certificate?",
                              "Confirm Changes",
                              MessageBoxButtons.YesNo, False)
        If result = DialogResult.Yes Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If CBool(row.Cells("policeVerifiedByChkbx").Value) Then
                    ' Do something with the checked row
                    ' For example:
                    verified_id = CInt(row.Cells("policeVerifiedByID").Value)
                End If
            Next
            For Each row2 As DataGridViewRow In DataGridView2.Rows
                If CBool(row2.Cells("policeCertifiedByChkbx").Value) Then
                    ' Do something with the checked row
                    ' For example:
                    certified_id = CInt(row2.Cells("policeCertifiedByID").Value)
                End If
            Next

            connection.Open()
            command = New SqlCommand("", connection)
            command.CommandText = "UPDATE dbo.[user] SET [user].[police_verifiedby_id] = @verify_id, [user].[police_certifiedby_id] = @certify_id WHERE [user].[user_id] = @user_id"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@user_id", user_id)
            command.Parameters.AddWithValue("@verify_id", verified_id)
            command.Parameters.AddWithValue("@certify_id", certified_id)
            command.ExecuteNonQuery()
            connection.Close()
            command = Nothing
        End If


        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub LoadVerifiedByPolice(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT police.police_id AS 'ID', police.fname AS 'FIRST NAME', police.mname AS 'MIDDLE NAME', police.lname AS 'LAST NAME', police.contact_no AS 'CONTACT NUMBER', MAX(rank.name) AS 'RANK', MAX(position.name) AS 'POSITION' FROM [dbo].police INNER JOIN [dbo].promotion ON promotion.police_id = police.police_id INNER JOIN [dbo].rank ON promotion.curr_rank_id = rank.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE promotion.promotion_date = (SELECT MAX(promotion_date) FROM dbo.promotion WHERE police_id = police.police_id) AND police.deleted=0 GROUP BY police.police_id, police.fname, police.mname, police.lname, police.contact_no"
            Else
                command.CommandText = "SELECT police.police_id AS 'ID', police.fname AS 'FIRST NAME', police.mname AS 'MIDDLE NAME', police.lname AS 'LAST NAME', police.contact_no AS 'CONTACT NUMBER', MAX(rank.name) AS 'RANK', MAX(position.name) AS 'POSITION' FROM [dbo].police INNER JOIN [dbo].promotion ON promotion.police_id = police.police_id INNER JOIN [dbo].rank ON promotion.curr_rank_id = rank.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE promotion.promotion_date = (SELECT MAX(promotion_date) FROM dbo.promotion WHERE police_id = police.police_id) AND police.deleted=0 AND (police.fname LIKE @searchString OR police.mname LIKE @searchString OR police.lname LIKE @searchString OR rank.name LIKE @searchString OR position.name LIKE @searchString) GROUP BY police.police_id, police.fname, police.mname, police.lname, police.contact_no"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns("policeVerifiedByID").DataPropertyName = "ID"
            DataGridView1.Columns("policeVerifiedByfname").DataPropertyName = "FIRST NAME"
            DataGridView1.Columns("policeVerifiedByMname").DataPropertyName = "MIDDLE NAME"
            DataGridView1.Columns("policeVerifiedByLname").DataPropertyName = "LAST NAME"
            DataGridView1.Columns("policeVerifiedByRank").DataPropertyName = "RANK"
            DataGridView1.Columns("policeVerifiedByPosition").DataPropertyName = "POSITION"
            DataGridView1.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Verified By Police error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub LoadCertifiedByPolice(Optional searchString As String = "")
        Try
            connection.Open()
            command = New SqlCommand("", connection)
            If searchString = "" Then
                command.CommandText = "SELECT police.police_id AS 'ID', police.fname AS 'FIRST NAME', police.mname AS 'MIDDLE NAME', police.lname AS 'LAST NAME', police.contact_no AS 'CONTACT NUMBER', MAX(rank.name) AS 'RANK', MAX(position.name) AS 'POSITION' FROM [dbo].police INNER JOIN [dbo].promotion ON promotion.police_id = police.police_id INNER JOIN [dbo].rank ON promotion.curr_rank_id = rank.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE promotion.promotion_date = (SELECT MAX(promotion_date) FROM dbo.promotion WHERE police_id = police.police_id) AND police.deleted=0 GROUP BY police.police_id, police.fname, police.mname, police.lname, police.contact_no"
            Else
                command.CommandText = "SELECT police.police_id AS 'ID', police.fname AS 'FIRST NAME', police.mname AS 'MIDDLE NAME', police.lname AS 'LAST NAME', police.contact_no AS 'CONTACT NUMBER', MAX(rank.name) AS 'RANK', MAX(position.name) AS 'POSITION' FROM [dbo].police INNER JOIN [dbo].promotion ON promotion.police_id = police.police_id INNER JOIN [dbo].rank ON promotion.curr_rank_id = rank.rank_id INNER JOIN [dbo].position ON position.position_id = police.position_id WHERE promotion.promotion_date = (SELECT MAX(promotion_date) FROM dbo.promotion WHERE police_id = police.police_id) AND police.deleted=0 AND (police.fname LIKE @searchString OR police.mname LIKE @searchString OR police.lname LIKE @searchString OR rank.name LIKE @searchString OR position.name LIKE @searchString) GROUP BY police.police_id, police.fname, police.mname, police.lname, police.contact_no"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
            End If
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView2.AutoGenerateColumns = False
            DataGridView2.Columns("policeCertifiedByID").DataPropertyName = "ID"
            DataGridView2.Columns("policeCertifiedByFname").DataPropertyName = "FIRST NAME"
            DataGridView2.Columns("policeCertifiedByMname").DataPropertyName = "MIDDLE NAME"
            DataGridView2.Columns("policeCertifiedByLname").DataPropertyName = "LAST NAME"
            DataGridView2.Columns("policeCertifiedByRank").DataPropertyName = "RANK"
            DataGridView2.Columns("policeCertifiedByPosition").DataPropertyName = "POSITION"
            DataGridView2.DataSource = dt
            connection.Close()
            command = Nothing
        Catch ex As Exception
            connection.Close()
            MsgBox("Loading Certified By Police error" & vbCrLf & String.Format("Error: {0}", ex.Message))
        End Try
    End Sub
    Private Sub SetCheckedRow()
        Dim verID As Integer = verifiedBy_id ' Change this to the ID you want to find
        Dim cerID As Integer = certifiedBy_id ' Change this to the ID you want to find

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowID As Integer = CInt(row.Cells(1).Value) ' Assuming the ID column is at index 0

            If rowID = verID Then
                ' Found the row with the specified ID, you can perform your actions here
                ' For example, you can check the checkbox for the found row:
                row.Cells(0).Value = True ' Assuming the checkbox column is at index 2
                Exit For ' Exit the loop since you found the target row
            End If
        Next

        For Each row2 As DataGridViewRow In DataGridView2.Rows
            Dim rowID As Integer = CInt(row2.Cells(1).Value) ' Assuming the ID column is at index 0

            If rowID = cerID Then
                ' Found the row with the specified ID, you can perform your actions here
                ' For example, you can check the checkbox for the found row:
                row2.Cells(0).Value = True ' Assuming the checkbox column is at index 2
                Exit For ' Exit the loop since you found the target row
            End If
        Next
    End Sub
    Private Sub DataGridView_CellContentClick_OnlyOneChecked(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
            Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
            Dim clickedCell As DataGridViewCheckBoxCell = TryCast(dataGridView(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)

            If clickedCell IsNot Nothing Then
                ' Uncheck all other checkboxes in the same column
                For Each row As DataGridViewRow In dataGridView.Rows
                    If row.Index <> e.RowIndex Then
                        Dim cell As DataGridViewCheckBoxCell = TryCast(dataGridView(e.ColumnIndex, row.Index), DataGridViewCheckBoxCell)
                        If cell IsNot Nothing Then
                            cell.Value = False
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "policeVerifiedByHistory" Then
            Try
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim police_id As Integer = row.Cells("policeVerifiedByID").Value
                Dim policeHistory As New PoliceHistory
                policeHistory.police_id = police_id
                policeHistory.ShowDialog()

            Catch ex As Exception
                MsgBox("Police Officers Settings(Verified By) - Check History error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim colname As String = DataGridView2.Columns(e.ColumnIndex).Name
        If colname = "policeCertifiedByHistory" Then
            Try
                Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
                Dim police_id As Integer = row.Cells("policeCertifiedByID").Value
                Dim policeHistory As New PoliceHistory
                policeHistory.police_id = police_id
                policeHistory.ShowDialog()

            Catch ex As Exception
                MsgBox("Police Officers Settings(Certified By) - Check History error" & vbCrLf & String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub
End Class