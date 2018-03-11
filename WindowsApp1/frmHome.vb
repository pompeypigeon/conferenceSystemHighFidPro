Public Class frmHome
    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        Hide()
        frmMap.Show()
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        Hide()
        frmTimetable.Show()
    End Sub

    Private Sub btnPresent_Click(sender As Object, e As EventArgs) Handles btnPresent.Click
        Hide()
        frmPresenter.Show()
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Hide()
        frmTransport.Show()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Hide()
        frmInfo.Show()
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Date: " + String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Label3.Text = "Time: " + Now.ToShortTimeString
        lblLoc.Text = "Buckingham BK1.01"
        lblNext.Text = "Security in IoT"
        lblTime.Text = "12:00 - 13-00"
    End Sub

    Private Sub picTrans_Click(sender As Object, e As EventArgs) Handles picTrans.Click
        Hide()
        frmTransport.Show()
    End Sub

    Private Sub picTime_Click(sender As Object, e As EventArgs) Handles picTime.Click
        Hide()
        frmTimetable.Show()
    End Sub

    Private Sub picPre_Click(sender As Object, e As EventArgs) Handles picPre.Click
        Hide()
        frmPresenter.Show()
    End Sub

    Private Sub picHelp_Click(sender As Object, e As EventArgs) Handles picHelp.Click
        Hide()
        frmInfo.Show()
    End Sub

    Private Sub picMap_Click(sender As Object, e As EventArgs) Handles picMap.Click
        Hide()
        frmMap.Show()
    End Sub
End Class
