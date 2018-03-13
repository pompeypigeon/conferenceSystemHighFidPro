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
                TextBox1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus id libero turpis. Proin quis nunc sit amet neque eleifend molestie ac et elit. Phasellus malesuada efficitur magna eget auctor. Nam ultrices sit amet nunc quis condimentum. Praesent tincidunt nulla in sapien ultricies blandit. Suspendisse sem velit, lobortis et hendrerit non, dapibus non nisi."
            Case "Martin Gore"
                TextBox1.Text = "This is a text, consectetur adipiscing elit. Phasellus id libero turpis. Proin quis nunc sit amet neque eleifend molestie ac et elit. Phasellus malesuada efficitur magna eget auctor. Nam ultrices sit amet nunc quis condimentum. Praesent tincidunt nulla in sapien ultricies blandit. Suspendisse sem velit, lobortis et hendrerit non, dapibus non nisi."
            Case "Dave Gahan"
                TextBox1.Text = "Get the Depeche Mode reference?, consectetur adipiscing elit. Phasellus id libero turpis. Proin quis nunc sit amet neque eleifend molestie ac et elit. Phasellus malesuada efficitur magna eget auctor. Nam ultrices sit amet nunc quis condimentum. Praesent tincidunt nulla in sapien ultricies blandit. Suspendisse sem velit, lobortis et hendrerit non, dapibus non nisi."
            Case "Eileen Ekberg"
                TextBox1.Text = "Maybe more, consectetur adipiscing elit. Phasellus id libero turpis. Proin quis nunc sit amet neque eleifend molestie ac et elit. Phasellus malesuada efficitur magna eget auctor. Nam ultrices sit amet nunc quis condimentum. Praesent tincidunt nulla in sapien ultricies blandit. Suspendisse sem velit, lobortis et hendrerit non, dapibus non nisi."
            Case "Rob Top"
                TextBox1.Text = "Rob started his career coding Java and FORTRAN, during his years he has contributed well in the fields of Computing in Education, Web Technologies and many other subjects. He will be presenting many tracks in this conference such as Web Technologies and Security in IoT"
        End Select
    End Sub
End Class