Public Class frmTimetable
    Private Sub frmTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Date: " + String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Label3.Text = "Time: " + Now.ToShortTimeString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        frmHome.Show()
    End Sub
End Class