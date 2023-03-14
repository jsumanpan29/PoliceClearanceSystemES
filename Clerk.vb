Public Class Clerk
    Friend user_id As Integer
    Private Sub Clerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user_id Then
            MsgBox("UserID:" & user_id)
        End If
    End Sub
End Class