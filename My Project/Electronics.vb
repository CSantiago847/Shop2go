Imports Shop2go.Shop2godetails
Public Class Electronics
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub SamTvbutton_Click(sender As Object, e As EventArgs) Handles SamTvbutton.Click
        prod_id = "005"
        prod_name = "SAMSUNG 65' Class DU7200B CryUHD 4K Smart TV"
        prod_ogprice = "600"
        prod_slprice = "528"
        Me.Hide()
        ConfirmOrder.Show()

    End Sub

    Private Sub Acerbutton_Click(sender As Object, e As EventArgs) Handles Acerbutton.Click
        prod_id = "006"
        prod_name = "Acer Nitro 5 Gaming laptop"
        prod_ogprice = "999"
        prod_slprice = "899"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub IpadButton_Click(sender As Object, e As EventArgs) Handles IpadButton.Click
        prod_id = "007"
        prod_name = "Apple 11-inch"
        prod_ogprice = "700"
        prod_slprice = "599"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub DellButton_Click(sender As Object, e As EventArgs) Handles DellButton.Click
        prod_id = "008"
        prod_name = "Dell OptiPlex"
        prod_ogprice = "400"
        prod_slprice = "299"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub
End Class