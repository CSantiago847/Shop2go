Imports Shop2go.Shop2godetails

Public Class checkout
    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Id.Text = prod_id
        ProductName.Text = prod_name

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Application.Exit()

    End Sub
End Class