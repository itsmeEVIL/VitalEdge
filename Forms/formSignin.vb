Public Class formSignin
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
        parentForm.ReplaceChildForm(New formHome)
    End Sub

    Private Sub lblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogin.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formLogin)
    End Sub
End Class