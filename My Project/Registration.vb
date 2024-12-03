Imports System.IO

Public Class Registration
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RegisterNow_Click(sender As Object, e As EventArgs) Handles RegisterNow.Click
        MessageBox.Show("Register Succesful")
        Me.Hide()
        Collection.Show()

    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class