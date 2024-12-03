Public Class Collection
    Private Sub Modelkitsbutton_Click(sender As Object, e As EventArgs) Handles Modelkitsbutton.Click
        Me.Hide()
        Modelkits.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Electronicsbutton_Click(sender As Object, e As EventArgs) Handles Electronicsbutton.Click
        Me.Hide()
        Electronics.Show()
    End Sub

    Private Sub Gamesbutton_Click(sender As Object, e As EventArgs) Handles Gamesbutton.Click
        Me.Hide()
        Games.Show()
    End Sub

    Private Sub Homebutton_Click(sender As Object, e As EventArgs) Handles Homebutton.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class