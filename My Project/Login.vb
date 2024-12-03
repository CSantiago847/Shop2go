Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If Emailbox.Text = "Username" And passbox.Text = "Password" Then
            MessageBox.Show("Login Succesful")
            Me.Hide()
            Collection.Show()
        End If
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        Me.Hide()
        Form1.Show()
    End Sub
End Class
