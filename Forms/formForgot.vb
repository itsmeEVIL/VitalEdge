Imports MySql.Data.MySqlClient

Public Class formForgot
    Dim email As String
    Dim password As String
    Dim passwordNew As String

    Private Function ValidateFields(ByVal email As String, ByVal password As String, ByVal confirmPassword As String) As Boolean
        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPassword) Then
            MsgBox("Please fill in all the fields!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
            If String.IsNullOrEmpty(email) Then
                txtEmail.Focus()
            ElseIf String.IsNullOrEmpty(password) Then
                txtPassword.Focus()
            Else
                txtPasswordConfirm.Focus()
            End If
            Return False
        End If

        If password <> confirmPassword Then
            MsgBox("Passwords do not match!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Password Mismatch")
            txtPassword.Clear()
            txtPasswordConfirm.Clear()
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ResetPassword(ByVal email As String, ByVal passwordNew As String) As Boolean
        Dim connectionString As String = "server=localhost;user id=root;password=1234;database=vitaledge"
        Dim passwordNewHashed As String = BCrypt.Net.BCrypt.HashPassword(passwordNew)

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE email = @email;"
                Using cmd As New MySqlCommand(checkQuery, connection)
                    cmd.Parameters.AddWithValue("@email", email)

                    Dim updateQuery As String = "UPDATE users SET password = @password WHERE email = @email;"
                    Dim emailExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If emailExists > 0 Then
                        Using updateCmd As New MySqlCommand(updateQuery, connection)
                            updateCmd.Parameters.AddWithValue("@password", passwordNewHashed)
                            updateCmd.Parameters.AddWithValue("@email", email)

                            updateCmd.ExecuteNonQuery()
                            MsgBox("Password reset successful!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Password Reset")
                            Return True
                        End Using
                    Else
                        MsgBox("Email doesn't exist!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Password Reset")
                        Return False
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            Return False
        End Try
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        email = txtEmail.Text.Trim()
        password = txtPassword.Text.Trim()
        passwordNew = txtPasswordConfirm.Text.Trim()

        If Not ValidateFields(email, password, passwordNew) Then
            Exit Sub
        End If

        If ResetPassword(email, passwordNew) Then
            Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
            parentForm.ReplaceChildForm(New formLogin)
        End If
    End Sub

    Private Sub lblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogin.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formLogin)
    End Sub
End Class