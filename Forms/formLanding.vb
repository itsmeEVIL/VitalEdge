Public Class formLanding
    Private currentChildForm As Form

    Private Sub formLanding_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim mainPanelWidth As Integer = Me.ClientSize.Width / 2
        pnlUsers.Width = mainPanelWidth
        pnlImage.Width = mainPanelWidth
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        currentChildForm?.Close()
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlUsers.Controls.Add(childForm)
        pnlUsers.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenChildForm(New formLogin)
    End Sub

    Public Sub ReplaceChildForm(newForm As Form)
        OpenChildForm(newForm)
    End Sub
End Class