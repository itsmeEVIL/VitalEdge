Public Class formSignin
    Private Function isEmpty()
        Dim userName As String = txtUsername.Text
        Dim userEmail As String = txtEmail.Text
        Dim userPassword As String = txtPassword.Text

        If String.IsNullOrEmpty(userName) OrElse String.IsNullOrEmpty(userEmail) OrElse String.IsNullOrEmpty(userPassword) Then
            If String.IsNullOrEmpty(txtUsername.Text) Then
                txtUsername.Focus()
            ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
                txtEmail.Focus()
            Else
                txtPassword.Focus()
            End If

            Return True
        End If
        Return False
    End Function

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        If isEmpty() Then
            MsgBox("Please fill in all fields (Username, Email, Password).", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            MsgBox("Sign In Successful!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sign In")
            Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
            parentForm.ReplaceChildForm(New formHome)
        End If
    End Sub

    Private Sub lblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogin.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formLogin)
    End Sub
End Class