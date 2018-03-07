Public Class frmTransport
    Private Sub frmTransport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Date = " + String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Label4.Text = "Time: " + Now.ToShortTimeString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        frmHome.Show()
    End Sub
End Class