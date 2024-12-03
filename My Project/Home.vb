Imports Shop2go.Shop2godetails
Public Class Home
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub Sheetsbutton_Click(sender As Object, e As EventArgs) Handles Sheetsbutton.Click
        prod_id = "013"
        prod_name = "Mainstays Black 7 Piece Quilt Set"
        prod_ogprice = "50.00"
        prod_slprice = "39.96"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub Napqueenbutton_Click(sender As Object, e As EventArgs) Handles Napqueenbutton.Click
        prod_id = "014"
        prod_name = "NapQueen Victoria 10'Hybrid Mattress"
        prod_ogprice = "200"
        prod_slprice = "188"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub LampButton_Click(sender As Object, e As EventArgs) Handles LampButton.Click
        prod_id = "015"
        prod_name = "Table Lamp"
        prod_ogprice = "39.99"
        prod_slprice = "19.99"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub PillowButton_Click(sender As Object, e As EventArgs) Handles PillowButton.Click
        prod_id = "016"
        prod_name = "Hearth & Harbor Temperature Regulating Reversible Cooling Pillow"
        prod_ogprice = "197"
        prod_slprice = "44.99"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub
End Class