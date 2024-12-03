Public Class Form1
    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Me.Hide()
        Registration.Show()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Loginbutton.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class
