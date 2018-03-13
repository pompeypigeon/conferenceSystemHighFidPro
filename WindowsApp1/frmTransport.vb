Public Class frmTransport
    Private Sub frmTransport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Date = " + String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Label4.Text = "Time: " + Now.ToShortTimeString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        frmHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        frmMap.Show()
        frmMap.WebBrowser1.Navigate("https://www.google.co.uk/maps/dir/Lion+Gate+Building,+Portsmouth/Winston+Churchill+Ave,+Portsmouth/@50.7972851,-1.0956047,16z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x48745d9d561e35c5:0xe59f5c812d84012f!2m2!1d-1.0984599!2d50.7989914!1m5!1m1!1s0x48745da1df4b6895:0x46210ff7bd68867e!2m2!1d-1.0870611!2d50.7951073!3e2")
    End Sub
End Class