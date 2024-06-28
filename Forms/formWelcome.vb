Public Class formWelcome
    Private Sub formWelcome_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsername.Text = UserInfo.userName
    End Sub
End Class