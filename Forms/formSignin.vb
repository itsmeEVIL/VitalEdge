Imports RestSharp

Public Class formSignin
    Dim userName As String
    Dim userEmail As String
    Dim userPassword As String

    Private Function isEmpty()
        userName = txtUsername.Text
        userEmail = txtEmail.Text
        userPassword = txtPassword.Text

        If String.IsNullOrEmpty(userName) OrElse String.IsNullOrEmpty(userEmail) OrElse String.IsNullOrEmpty(userPassword) Then
            If String.IsNullOrEmpty(userName) Then
                txtUsername.Focus()
            ElseIf String.IsNullOrEmpty(userEmail) Then
                txtEmail.Focus()
            Else
                txtPassword.Focus()
            End If

            Return True
        End If
        Return False
    End Function

    Private Sub SignUp(email As String, username As String, password As String)
        Dim client As New RestClient("https://zwrsxclozisvztcbkvrz.supabase.co/rest/v1")
        Dim request As New RestRequest("users", Method.Post)
        request.AddHeader("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Inp3cnN4Y2xvemlzdnp0Y2JrdnJ6Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTk1NTk1ODYsImV4cCI6MjAzNTEzNTU4Nn0.oP1ZII9CQOxoGxnDlcLYCH68R3E7Yr242BhK_Y4zK4s")
        request.AddHeader("Content-Type", "application/json")

        Dim userData As New Dictionary(Of String, Object) From {
            {"email", email},
            {"username", username},
            {"password", password}
        }

        request.AddJsonBody(userData)

        Dim response As RestResponse = client.Execute(request)
        If response.IsSuccessful Then
            MsgBox("Registration successful!")
        Else
            MsgBox("Registration failed: " & response.Content)
        End If
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        If isEmpty() Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            SignUp(userEmail, userName, userPassword)

            UserData.userName = userName
            UserData.userEmail = userEmail
            UserData.userPassword = userPassword

            Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
            parentForm.ReplaceChildForm(New formHome)
        End If
    End Sub

    Private Sub lblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogin.LinkClicked
        Dim parentForm As formLanding = TryCast(Me.ParentForm, formLanding)
        parentForm.ReplaceChildForm(New formLogin)
    End Sub
End Class