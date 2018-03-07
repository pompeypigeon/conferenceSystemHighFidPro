Public Class frmMap
    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Date = " + String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Label3.Text = "Time: " + Now.ToShortTimeString
        WebBrowser1.Navigate("https://www.google.co.uk/maps/place/Lion+Gate+Building,+Portsmouth+PO1+3HF/@50.7988986,-1.1005894,17z/data=!3m1!4b1!4m5!3m4!1s0x48745d9d561e35c5:0xe59f5c812d84012f!8m2!3d50.7989914!4d-1.0984599")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        frmHome.Show()
    End Sub
End Class