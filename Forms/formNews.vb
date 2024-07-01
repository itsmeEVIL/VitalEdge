Imports System.Diagnostics
Imports System.Security.Policy

Public Class formNews
    Private currentNewsLink As LinkLabel
    Private currentEventLink As LinkLabel
    Private leftNewsBorderLink As Panel
    Private leftEventBorderLink As Panel

    Dim customColor As Color = Color.FromArgb(65, 155, 191)
    Dim newsLinkHeight As Integer

    Public Sub New()
        InitializeComponent()

        leftNewsBorderLink = New Panel With {
            .Size = New Size(7, newsLinkHeight)
        }
        leftEventBorderLink = New Panel With {
            .Size = New Size(7, newsLinkHeight)
        }
        Panel5.Controls.Add(leftNewsBorderLink)
        Panel6.Controls.Add(leftEventBorderLink)
    End Sub

    Private Sub HoverLink(senderLink As Object, Optional isNews As Boolean = True)
        Dim currentLink As LinkLabel = TryCast(senderLink, LinkLabel)
        If currentLink IsNot Nothing Then
            NonHoverLink(isNews)

            If isNews Then
                currentNewsLink = currentLink
                leftNewsBorderLink.BackColor = customColor
                leftNewsBorderLink.Height = newsLinkHeight
                leftNewsBorderLink.Location = New Point(0, currentNewsLink.Location.Y)
                leftNewsBorderLink.Visible = True
                leftNewsBorderLink.BringToFront()
            Else
                currentEventLink = currentLink
                leftEventBorderLink.BackColor = customColor
                leftEventBorderLink.Height = newsLinkHeight
                leftEventBorderLink.Location = New Point(0, currentEventLink.Location.Y)
                leftEventBorderLink.Visible = True
                leftEventBorderLink.BringToFront()
            End If

            currentLink.LinkColor = customColor
            currentLink.Padding = New Padding(17, 0, 0, 0)
        End If
    End Sub

    Private Sub NonHoverLink(isNews As Boolean)
        Dim currentLink As LinkLabel = If(isNews, currentNewsLink, currentEventLink)
        If currentLink IsNot Nothing Then
            currentLink.Font = FontHelper.GetCustomFont("Inter", 10, FontHelper.CustomFontStyle.Regular)
            currentLink.LinkColor = Color.Black
            currentLink.Padding = New Padding(10, 0, 0, 0)
        End If
    End Sub

    Private Sub formNews_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim mainPanelHeight As Integer = (Me.Panel1.Height - Panel3.Height) / 2
        Panel2.Height = mainPanelHeight
        Panel4.Height = mainPanelHeight


        Dim newsPanelWidth As Integer = (Me.Panel2.Width) / 2
        PictureBox1.Width = newsPanelWidth
        Panel4.Width = newsPanelWidth

        PictureBox2.Width = newsPanelWidth
        Panel6.Width = newsPanelWidth

        newsLinkHeight = Me.Panel5.Height / 5
        LinkLabel1.Height = newsLinkHeight
        LinkLabel2.Height = newsLinkHeight
        LinkLabel3.Height = newsLinkHeight
        LinkLabel4.Height = newsLinkHeight
        LinkLabel5.Height = newsLinkHeight

        LinkLabel6.Height = newsLinkHeight
        LinkLabel7.Height = newsLinkHeight
        LinkLabel8.Height = newsLinkHeight
        LinkLabel9.Height = newsLinkHeight
        LinkLabel10.Height = newsLinkHeight

        HoverLink(currentNewsLink)
        HoverLink(currentEventLink, False)
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        HoverLink(sender)
        PictureBox1.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\news_1.png")
    End Sub

    Private Sub LinkLabel2_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        HoverLink(sender)
        PictureBox1.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\news_2.png")
    End Sub

    Private Sub LinkLabel3_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel3.MouseEnter
        HoverLink(sender)
        PictureBox1.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\news_3.png")
    End Sub

    Private Sub LinkLabel4_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel4.MouseEnter
        HoverLink(sender)
        PictureBox1.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\news_4.png")
    End Sub

    Private Sub LinkLabel5_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel5.MouseEnter
        HoverLink(sender)
        PictureBox1.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\news_5.png")
    End Sub

    Private Sub formNews_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblHealthPoints.Text = User.HealthPoints
        HoverLink(LinkLabel1)
        HoverLink(LinkLabel10, False)
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.healthline.com/health-news/daily-multivitamin-may-not-help-live-longer",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel2_Click(sender As Object, e As EventArgs) Handles LinkLabel2.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.healthline.com/health-news/exercise-prevents-bone-loss-taking-weight-loss-drugs",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel3_Click(sender As Object, e As EventArgs) Handles LinkLabel3.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.healthline.com/health-news/intermittent-fasting-can-help-people-with-type-2-diabetes-control-blood-sugar-weight-loss",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel4_Click(sender As Object, e As EventArgs) Handles LinkLabel4.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.healthline.com/health-news/health-risks-hot-days",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel5_Click(sender As Object, e As EventArgs) Handles LinkLabel5.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.healthline.com/health-news/taking-regular-walks-may-help-reduce-lower-back-pain",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel6_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel6.MouseEnter
        HoverLink(sender, False)
        PictureBox2.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\events_5.jpg")
    End Sub

    Private Sub LinkLabel7_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel7.MouseEnter
        HoverLink(sender, False)
        PictureBox2.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\events_4.jpg")
    End Sub

    Private Sub LinkLabel8_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel8.MouseEnter
        HoverLink(sender, False)
        PictureBox2.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\events_3.jpg")
    End Sub

    Private Sub LinkLabel9_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel9.MouseEnter
        HoverLink(sender, False)
        PictureBox2.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\events_2.jpg")
    End Sub

    Private Sub LinkLabel10_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel10.MouseEnter
        HoverLink(sender, False)
        PictureBox2.Image = Image.FromFile("C:\Users\User\Documents\Uni\3rd Sem\OMC\VitalEdge\Resources\Images\News\events_1.jpg")
    End Sub

    Private Sub LinkLabel6_Click(sender As Object, e As EventArgs) Handles LinkLabel6.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.jomrun.com/event/722-Sarawak-Day-Run-2024",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel7_Click(sender As Object, e As EventArgs) Handles LinkLabel7.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.jomrun.com/event/Klippa-Art-Run-2024",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel8_Click(sender As Object, e As EventArgs) Handles LinkLabel8.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.jomrun.com/event/Watsons-Get-Active-Carnival-2024",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel9_Click(sender As Object, e As EventArgs) Handles LinkLabel9.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.jomrun.com/event/Tian-Siang-BMW-Run-Ipoh",
                .UseShellExecute = True
            })
    End Sub

    Private Sub LinkLabel10_Click(sender As Object, e As EventArgs) Handles LinkLabel10.Click
        Process.Start(New ProcessStartInfo With {
                .FileName = "https://www.jomrun.com/event/Virtual-Run-Laksamana-Run-2024",
                .UseShellExecute = True
            })
    End Sub
End Class