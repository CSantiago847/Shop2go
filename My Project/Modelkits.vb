Imports Shop2go.Shop2godetails
Public Class Modelkits
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        Me.Hide()
        Collection.Show()
    End Sub

    Private Sub Nihubutton_Click(sender As Object, e As EventArgs) Handles Nihubutton.Click
        prod_id = "001"
        prod_name = "RG Hi Nu Gundam"
        prod_ogprice = "80.00"
        prod_slprice = "54.99"
        Me.Hide()
        ConfirmOrder.Show()

    End Sub

    Private Sub Eva2button_Click(sender As Object, e As EventArgs) Handles Eva2button.Click
        prod_id = "002"
        prod_name = "Evangelion RG EVA Unit-02 Production"
        prod_ogprice = "60.00"
        prod_slprice = "57.99"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub Epyonbutton_Click(sender As Object, e As EventArgs) Handles Epyonbutton.Click
        prod_id = "003"
        prod_name = "RG Gundam Epyon"
        prod_ogprice = "80.00"
        prod_slprice = "57.99"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub

    Private Sub ZeongButton_Click(sender As Object, e As EventArgs) Handles ZeongButton.Click
        prod_id = "004"
        prod_name = "RG Zeong"
        prod_ogprice = "80.00"
        prod_slprice = "65.99"
        Me.Hide()
        ConfirmOrder.Show()
    End Sub
End Class