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
        OpenChildForm(New formHome)
    End Sub
End Class
