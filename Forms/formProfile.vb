Public Class formProfile
    Private Sub formProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsername.Text = UserInfo.userName
        lblEmail.Text = UserInfo.userEmail
        lblHealthPoints.Text = UserInfo.userHealthPoints
        lblPassword.Text = UserInfo.userPassword
        picProfile.ImageLocation = UserInfo.userProfilePicture
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
        parentForm.ReplaceChildForm(New formLanding)
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim picLocation As String = openFileDialog.FileName
            picProfile.ImageLocation = picLocation
            UserInfo.userProfilePicture = picLocation
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        picProfile.Image.Dispose()
        picProfile.Image = Nothing
        UserInfo.userProfilePicture = Nothing
    End Sub
End Class