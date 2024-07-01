Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formSignin
    Dim username As String
    Dim email As String
    Dim password As String = ""

    Private Function ValidateFields(ByVal username As String, ByVal email As String, ByVal password As String) As Boolean
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("Please fill in all the fields!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
            If String.IsNullOrEmpty(username) Then
                txtUsername.Focus()
            ElseIf String.IsNullOrEmpty(email) Then
                txtEmail.Focus()
            Else
                txtPassword.Focus()
            End If
            Return False
        End If
        Return True
    End Function

    Private Function SignUp(ByVal username As String, ByVal email As String, ByVal password As String) As Boolean
        Dim connectionString As String = "server=localhost;user id=root;password=1234;database=vitaledge"
        Dim passwordHashed As String = BCrypt.Net.BCrypt.HashPassword(password)

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            If Not InsertUser(username, email, passwordHashed, connection) Then
                Return False
            End If

            User.Name = username
            User.Email = email
            User.HealthPoints = 0
            User.ProfilePicture = File.ReadAllBytes("Resources/Images/Default_Profile.png")

            MsgBox("Sign up successful!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sign Up")
            Return True

            connection.Close()
        End Using
    End Function

    Private Function InsertUser(username As String, email As String, passwordHashed As String, connection As MySqlConnection) As Boolean
        Dim query As String = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password);"

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", passwordHashed)

            Try
                cmd.ExecuteNonQuery()
                Return True
            Catch ex As MySqlException
                MsgBox("An error occurred during sign in. Please try again later.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Return False
            End Try
        End Using
    End Function

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        username = txtUsername.Text.Trim
        email = txtEmail.Text.Trim
        password = password.Trim

        If Not ValidateFields(username, email, password) Then
            Exit Sub
        End If

        If SignUp(username, email, password) Then
            Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
            parentForm.ReplaceChildForm(New formHome)
        Else
            password = ""
            txtPassword.Clear()
            txtEmail.Clear()
            txtUsername.Clear()
        End If
    End Sub

    Private Sub lblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogin.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formLogin)
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