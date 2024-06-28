Public Class formProfile
    Private Sub formProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblHealthPoints.Text = UserInfo.userHealthPoints
    End Sub
End Class