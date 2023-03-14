Public Class Admin
    Friend user_id As Integer
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user_id Then
            MsgBox(Me.Name & " UserID:" & user_id)
        End If
    End Sub
End Class