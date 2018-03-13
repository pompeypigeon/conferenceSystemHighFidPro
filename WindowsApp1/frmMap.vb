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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate("https://www.google.co.uk/maps/dir/Lion+Gate+Building,+Portsmouth/Buckingham+Building,+Portsmouth+PO1+3HE/@50.798701,-1.1009356,17z/data=!3m1!4b1!4m13!4m12!1m5!1m1!1s0x48745d9d561e35c5:0xe59f5c812d84012f!2m2!1d-1.0984599!2d50.7989914!1m5!1m1!1s0x48745d9d5230695b:0xc36a460305fe1251!2m2!1d-1.098529!2d50.7984221")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://www.google.co.uk/maps/dir/Lion+Gate+Building,+Portsmouth/Dennis+Sciama+Building,+Portsmouth+PO1+3FX/@50.7982848,-1.1012815,17z/data=!3m1!4b1!4m13!4m12!1m5!1m1!1s0x48745d9d561e35c5:0xe59f5c812d84012f!2m2!1d-1.0984599!2d50.7989914!1m5!1m1!1s0x48745d9d485c9423:0xe9c2652d27936657!2m2!1d-1.0983177!2d50.797693")
    End Sub
End Class