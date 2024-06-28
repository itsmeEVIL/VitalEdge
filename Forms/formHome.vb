Imports FontAwesome.Sharp

Public Class formHome
    Private currentBtn As IconButton
    Private leftborderbtn As Panel
    Private currentChildForm As Form

    Dim customFont As Font = FontHelper.GetCustomFont("Inter", 12, FontHelper.CustomFontStyle.Bold)
    Dim customColor As Color = Color.FromArgb(65, 155, 191)

    Public Sub New()
        InitializeComponent()

        leftborderbtn = New Panel With {
            .Size = New Size(7, 60)
        }
        pnlNavigation.Controls.Add(leftborderbtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(senderBtn, IconButton)
            currentBtn.IconColor = customColor
            currentBtn.Font = customFont
            currentBtn.ForeColor = customColor
            currentBtn.Padding = New Padding(22, 0, 0, 0)

            leftborderbtn.BackColor = customColor
            leftborderbtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.Font = FontHelper.GetCustomFont("Inter", 10, FontHelper.CustomFontStyle.Regular)
            currentBtn.IconColor = Color.Black
            currentBtn.ForeColor = Color.Black
            currentBtn.Padding = New Padding(15, 0, 0, 0)
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        currentChildForm?.Close()
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlDesktop.Controls.Add(childForm)
        pnlDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Public Sub ReplaceChildForm(newForm As Form)
        OpenChildForm(newForm)
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        ActivateButton(btnHome)
        OpenChildForm(New formWelcome)
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ActivateButton(sender)
        OpenChildForm(New formWelcome)
    End Sub

    Private Sub BtnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        ActivateButton(sender)
        OpenChildForm(New formCalculator)
    End Sub

    Private Sub BtnTracker_Click(sender As Object, e As EventArgs) Handles btnTracker.Click
        ActivateButton(sender)
        OpenChildForm(New formTracker)
    End Sub

    Private Sub BtnArticles_Click(sender As Object, e As EventArgs) Handles btnArticles.Click
        ActivateButton(sender)
        OpenChildForm(New formNews)
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ActivateButton(sender)
        OpenChildForm(New formProfile)
    End Sub

    Private Sub FormHome_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ActivateButton(currentBtn)
    End Sub
End Class