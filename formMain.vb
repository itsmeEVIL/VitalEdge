Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class formMain
    Private currentChildForm As Form

    Private Sub OpenChildForm(childForm As Form)
        currentChildForm?.Close()
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(childForm)
        pnlMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenChildForm(New formLanding)
    End Sub

    Public Sub ReplaceChildForm(newForm As Form)
        OpenChildForm(newForm)
    End Sub

    Private Sub formMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim email As String = User.Email
        Dim healthpoints As String = User.HealthPoints
        Dim connectionString As String = "server=localhost;user id=root;password=1234;database=vitaledge"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE users SET healthpoints = @healthpoints WHERE email = @email;"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@healthpoints", healthpoints)

                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
    End Sub
End Class
