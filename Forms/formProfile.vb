Public Class formProfile
    Private Sub formProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblHealthPoints.Text = UserInfo.userHealthPoints
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
        parentForm.ReplaceChildForm(New formLanding)
    End Sub
End Class