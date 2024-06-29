Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json.Linq
Imports RestSharp

Public Class formProfile
    Private Sub formProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsername.Text = UserData.userName
        lblEmail.Text = UserData.userEmail
        lblHealthPoints.Text = UserData.userHealthPoints
        lblPassword.Text = UserData.userPassword
        DisplayProfilePicture(UserData.userProfilePicture)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
        parentForm.ReplaceChildForm(New formLanding)
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imgPath As String = openFileDialog.FileName

            Try
                Dim base64Image As String = ConvertImageToBase64(imgPath)
                Dim userId As Integer = GetCurrentUserId()
                Dim isUpdated As Boolean = UpdateProfilePicture(userId, base64Image)

                If isUpdated Then
                    picProfile.ImageLocation = imgPath
                    UserData.userProfilePicture = base64Image
                    MessageBox.Show("Profile picture updated successfully!")
                Else
                    MessageBox.Show("Failed to update profile picture.")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try

        End If
    End Sub

    Private Function ConvertImageToBase64(imagePath As String) As String
        Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
        Return Convert.ToBase64String(imageBytes)
    End Function

    Private Sub DisplayProfilePicture(base64Image As String)
        Try
            Dim imageBytes As Byte() = Convert.FromBase64String(base64Image)

            Using ms As New MemoryStream(imageBytes)
                Dim profileImage As Image = Image.FromStream(ms)

                picProfile.Image = profileImage
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error displaying profile picture: {ex.Message}")
        End Try
    End Sub

    Private Function GetCurrentUserId() As Integer
        ' Replace with your logic to fetch the current user's user_id
        ' For example, if you store user_id in a session or retrieve it from your database
        Return 1 ' Replace with actual logic
    End Function

    Private Function UpdateProfilePicture(userId As Integer, base64Image As String) As Boolean
        Try
            Dim client As New RestClient("https://zwrsxclozisvztcbkvrz.supabase.co/rest/v1")
            Dim request As New RestRequest($"users?id=eq.{userId}", Method.Patch)

            request.AddHeader("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Inp3cnN4Y2xvemlzdnp0Y2JrdnJ6Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTk1NTk1ODYsImV4cCI6MjAzNTEzNTU4Nn0.oP1ZII9CQOxoGxnDlcLYCH68R3E7Yr242BhK_Y4zK4s")
            request.AddHeader("Content-Type", "application/json")

            Dim userData As New JObject()
            userData.Add("profile_picture", base64Image)

            request.AddJsonBody(userData)

            Dim response As RestResponse = client.Execute(request)

            MsgBox(response.Content)

            If response.IsSuccessful Then
                Return True
            Else
                MessageBox.Show($"Failed to update profile picture: {response.ErrorMessage}")
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error updating profile picture: {ex.Message}")
            Return False
        End Try
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        picProfile.Image.Dispose()
        picProfile.Image = Nothing
        UserData.userProfilePicture = Nothing
    End Sub
End Class