Public Class frmPresenter
    Private Sub frmPresenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Date = " + String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Label3.Text = "Time: " + Now.ToShortTimeString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        frmHome.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "Andy Fletcher"
                TextBox1.Text = "AF"
            Case "Martin Gore"
                TextBox1.Text = "MG"
            Case "Dave Gahan"
                TextBox1.Text = "DG"
            Case "Eileen Ekberg"
                TextBox1.Text = "EE"
            Case "Rob Top"
                TextBox1.Text = "RT"
        End Select
    End Sub
End Class