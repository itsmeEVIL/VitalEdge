Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formProfile
    Dim profilePicturePath As String
    Dim profilePicture As Byte() = Nothing

    Private Sub formProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsername.Text = User.Name
        lblEmail.Text = User.Email
        lblHealthPoints.Text = User.HealthPoints
        picProfile.Image = updateProfilePicture()
    End Sub

    Private Function updateProfilePicture()
        Dim profilePicture As Image

        Using ms As New MemoryStream(User.ProfilePicture)
            profilePicture = Image.FromStream(ms)
        End Using

        Return profilePicture
    End Function

    Private Function uploadProfilePicture()
        Dim email As String = User.Email
        Dim connectionString As String = "server=localhost;user id=root;password=1234;database=vitaledge"

        If Not String.IsNullOrEmpty(profilePicturePath) Then
            profilePicture = File.ReadAllBytes(profilePicturePath)
            User.ProfilePicture = profilePicture
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "UPDATE users SET profile_picture = @profile_picture WHERE email = @email;"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@email", email)

                    If profilePicture IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@profile_picture", profilePicture)
                    Else
                        cmd.Parameters.AddWithValue("@profile_picture", DBNull.Value)
                    End If

                    cmd.ExecuteNonQuery()
                    MsgBox("Profile picture updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Profile Picture")
                    Return True
                End Using
                connection.Close()
            Catch ex As MySqlException
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
                Return False
            End Try
        End Using
    End Function

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                profilePicturePath = ofd.FileName
                picProfile.Image = Image.FromFile(profilePicturePath)
            End If
        End Using

        uploadProfilePicture()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        picProfile.Image.Dispose()
        picProfile.Image = Image.FromFile("Resources/Images/Default_Profile.png")
        User.ProfilePicture = File.ReadAllBytes("Resources/Images/Default_Profile.png")
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim email As String = User.Email
        Dim healthpoints As String = User.HealthPoints
        Dim connectionString As String = "server=localhost;user id=root;password=1234;database=vitaledge"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "UPDATE users SET healthpoints = @healthpoints WHERE email = @email;"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@healthpoints", healthpoints)

                    cmd.ExecuteNonQuery()
                    MsgBox("Log out succesfull!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Log Out")
                End Using
                connection.Close()
            Catch ex As MySqlException
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            End Try
        End Using

        Dim parentForm As formMain = TryCast(Me.ParentForm.ParentForm, formMain)
        parentForm.ReplaceChildForm(New formLanding)
    End Sub
End Class