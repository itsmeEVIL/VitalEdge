Public Class formWelcome
    Private Sub formWelcome_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsername.Text = User.Name
    End Sub
End Class