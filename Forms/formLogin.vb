Imports RestSharp
Imports Newtonsoft.Json.Linq

Public Class formLogin
    Dim userEmail As String
    Dim userPassword As String

    Private Function isEmpty()
        userEmail = txtEmail.Text
        userPassword = txtPassword.Text

        If String.IsNullOrEmpty(userEmail) OrElse String.IsNullOrEmpty(userPassword) Then
            If String.IsNullOrEmpty(userEmail) Then
                txtEmail.Focus()
            ElseIf String.IsNullOrEmpty(userPassword) Then
                txtPassword.Focus()
            End If

            Return True
        End If
        Return False
    End Function

    Private Function Login(email As String, password As String)
        Dim client As New RestClient("https://zwrsxclozisvztcbkvrz.supabase.co/rest/v1")
        Dim request As New RestRequest("users", Method.Get)
        request.AddHeader("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Inp3cnN4Y2xvemlzdnp0Y2JrdnJ6Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTk1NTk1ODYsImV4cCI6MjAzNTEzNTU4Nn0.oP1ZII9CQOxoGxnDlcLYCH68R3E7Yr242BhK_Y4zK4s")
        request.AddParameter("email", "eq." & email)
        request.AddParameter("password", "eq." & password)

        Dim response As RestResponse = client.Execute(request)

        If response.IsSuccessful Then
            Dim user As JArray = JArray.Parse(response.Content)

            Try
                If user.Any Then
                    Dim username As String = user(0)("username").ToString()
                    Dim profilePicture As String = user(0)("profile_picture")
                    Dim healthPoints As Integer = CInt(user(0)("healthpoints"))

                    UserData.userName = username
                    UserData.userEmail = email
                    UserData.userPassword = password
                    UserData.userProfilePicture = profilePicture
                    UserData.userHealthPoints = healthPoints

                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox($"Error parsing response: {ex.Message}")
                Return False
            End Try
        Else
            MsgBox($"Error fetching data: {response.ErrorMessage}")
            Return False
        End If
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isEmpty() Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
        Else

            If Login(userEmail, userPassword) Then
                MsgBox($"Login successful! Welcome, {UserData.userName}")

                Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
                parentForm.ReplaceChildForm(New formHome)
            Else
                MsgBox("Login failed. Invalid credentials or user not found.")
            End If
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
End Class