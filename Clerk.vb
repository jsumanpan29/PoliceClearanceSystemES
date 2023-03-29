Imports System.Data.SqlClient
Imports System.IO

Public Class Clerk
    Friend user_id As Integer


    Private connString As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=ESPCS;Integrated Security=True"

    Private connection As New SqlConnection(connString)
    Private command As New SqlCommand("", connection)

    Private Sub Clerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user_id Then
            MsgBox("UserID:" & user_id)
        End If
    End Sub

End Class