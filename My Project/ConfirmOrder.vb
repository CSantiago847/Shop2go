Imports Shop2go.Shop2godetails
Public Class ConfirmOrder

    Private Sub ConfirmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductName.Text = prod_name
        OriginalPrice.Text = prod_ogprice
        SellingPrice.Text = prod_slprice
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Me.Hide()
        checkout.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Collection.Show()
    End Sub
End Class