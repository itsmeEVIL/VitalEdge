Imports MySql.Data.MySqlClient

Public Class formLogin
    Dim email As String
    Dim password As String = ""

    Private Function ValidateFields(ByVal email As String, ByVal password As String)
        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("Please fill in all the fields!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
            If String.IsNullOrEmpty(email) Then
                txtEmail.Focus()
            Else
                txtPassword.Focus()
            End If
            Return False
        End If
        Return True
    End Function

    Private Function Login(email As String, password As String) As Boolean
        Dim connectionString As String = "server=localhost;user id=root;password=1234;database=vitaledge"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim storedHashedPassword = GetHashedPassword(email, connection)
                If Not String.IsNullOrEmpty(storedHashedPassword) Then
                    If BCrypt.Net.BCrypt.Verify(password, storedHashedPassword) Then
                        If GetUser(email, connection) Then
                            MsgBox("Login successful!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Login")
                            Return True
                        Else
                            MsgBox("An error occurred retrieving user information.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                            Return False
                        End If
                    Else
                        MsgBox("Invalid password.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                        Return False
                    End If
                Else
                    MsgBox("Invalid email.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                    Return False
                End If

                connection.Close()
            Catch ex As MySqlException
                MsgBox("An error occurred during login. Please try again later.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Return False
            End Try
        End Using
    End Function

    Private Function GetHashedPassword(email As String, connection As MySqlConnection) As String
        Dim passwordQuery As String = "SELECT password FROM users WHERE email = @email"

        Using passwordCmd As New MySqlCommand(passwordQuery, connection)
            passwordCmd.Parameters.AddWithValue("@email", email)

            Using passwordReader As MySqlDataReader = passwordCmd.ExecuteReader()
                If passwordReader.HasRows Then
                    passwordReader.Read()
                    Return passwordReader.GetString("password")
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Private Function GetUser(email As String, connection As MySqlConnection) As Boolean
        Dim userQuery As String = "SELECT username, email, healthpoints, profile_picture FROM users WHERE email = @email"

        Using userCmd As New MySqlCommand(userQuery, connection)
            userCmd.Parameters.AddWithValue("@email", email)

            Using userReader As MySqlDataReader = userCmd.ExecuteReader()
                If userReader.HasRows Then
                    userReader.Read()
                    User.Name = userReader.GetString("username")
                    User.Email = userReader.GetString("email")
                    User.HealthPoints = userReader.GetInt32("healthpoints")
                    User.ProfilePicture = If(userReader.IsDBNull(userReader.GetOrdinal("profile_picture")), Nothing, CType(userReader(userReader.GetOrdinal("profile_picture")), Byte()))
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        email = txtEmail.Text.Trim
        password = password.Trim

        If Not ValidateFields(email, password) Then
            Exit Sub
        End If

        If Login(email, password) Then
            Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
            parentForm.ReplaceChildForm(New formHome)
        Else
            password = ""
            txtPassword.Clear()
            txtEmail.Clear()
        End If
    End Sub

    Private Sub lblSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSignup.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formSignin)
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formForgot)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(8) Then
            If password.Length > 0 Then
                password = password.Substring(0, password.Length - 1)
            End If

            If txtPassword.TextLength > 0 Then
                txtPassword.Select(txtPassword.TextLength - 1, 1)
                txtPassword.SelectedText = ""
            End If

            e.Handled = True
        ElseIf e.KeyChar <> Chr(0) Then
            password &= e.KeyChar

            txtPassword.AppendText("*")
            e.Handled = True
        End If
    End Sub
End Class