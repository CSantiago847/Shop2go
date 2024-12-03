Imports Shop2go.Shop2godetails
Public Class Games
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub Xboxbutton_Click(sender As Object, e As EventArgs) Handles Xboxbutton.Click
        prod_id = "009"
        prod_name = "Xbox Series X"
        prod_ogprice = "500"
        prod_slprice = "478"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub Play5button_Click(sender As Object, e As EventArgs) Handles Play5button.Click
        prod_id = "010"
        prod_name = "Playstation 5"
        prod_ogprice = "500"
        prod_slprice = "490"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub WitchButton_Click(sender As Object, e As EventArgs) Handles WitchButton.Click
        prod_id = "011"
        prod_name = "The Witcher 3: Wild hunt"
        prod_ogprice = "39.00"
        prod_slprice = "20.00"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub SpideyButton_Click(sender As Object, e As EventArgs) Handles SpideyButton.Click
        prod_id = "012"
        prod_name = "Marvel's Spider-Man 2"
        prod_ogprice = "70.00"
        prod_slprice = "50.00"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub
End Class