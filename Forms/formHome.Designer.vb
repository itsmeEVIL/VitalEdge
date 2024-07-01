<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHome))
        pnlDesktop = New Panel()
        pnlNavigation = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnProfile = New FontAwesome.Sharp.IconButton()
        btnArticles = New FontAwesome.Sharp.IconButton()
        btnTracker = New FontAwesome.Sharp.IconButton()
        btnBMI = New FontAwesome.Sharp.IconButton()
        btnHome = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        picLogo = New PictureBox()
        pnlNavigation.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDesktop
        ' 
        pnlDesktop.BackColor = SystemColors.Control
        pnlDesktop.Dock = DockStyle.Fill
        pnlDesktop.Location = New Point(215, 0)
        pnlDesktop.Name = "pnlDesktop"
        pnlDesktop.Size = New Size(650, 555)
        pnlDesktop.TabIndex = 4
        ' 
        ' pnlNavigation
        ' 
        pnlNavigation.BackColor = Color.WhiteSmoke
        pnlNavigation.Controls.Add(Panel1)
        pnlNavigation.Controls.Add(btnProfile)
        pnlNavigation.Controls.Add(btnArticles)
        pnlNavigation.Controls.Add(btnTracker)
        pnlNavigation.Controls.Add(btnBMI)
        pnlNavigation.Controls.Add(btnHome)
        pnlNavigation.Controls.Add(Panel2)
        pnlNavigation.Dock = DockStyle.Left
        pnlNavigation.Location = New Point(0, 0)
        pnlNavigation.Name = "pnlNavigation"
        pnlNavigation.Size = New Size(215, 555)
        pnlNavigation.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 340)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(215, 155)
        Panel1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 21)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnProfile
        ' 
        btnProfile.Cursor = Cursors.Hand
        btnProfile.Dock = DockStyle.Bottom
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Inter", 9.75F)
        btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserLarge
        btnProfile.IconColor = Color.Black
        btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProfile.IconSize = 32
        btnProfile.ImageAlign = ContentAlignment.MiddleLeft
        btnProfile.Location = New Point(0, 495)
        btnProfile.Name = "btnProfile"
        btnProfile.Padding = New Padding(15, 0, 15, 0)
        btnProfile.Size = New Size(215, 60)
        btnProfile.TabIndex = 5
        btnProfile.Text = "Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnArticles
        ' 
        btnArticles.Cursor = Cursors.Hand
        btnArticles.Dock = DockStyle.Top
        btnArticles.FlatAppearance.BorderSize = 0
        btnArticles.FlatStyle = FlatStyle.Flat
        btnArticles.Font = New Font("Inter", 9.75F)
        btnArticles.IconChar = FontAwesome.Sharp.IconChar.Newspaper
        btnArticles.IconColor = Color.Black
        btnArticles.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnArticles.IconSize = 32
        btnArticles.ImageAlign = ContentAlignment.MiddleLeft
        btnArticles.Location = New Point(0, 280)
        btnArticles.Name = "btnArticles"
        btnArticles.Padding = New Padding(15, 0, 15, 0)
        btnArticles.Size = New Size(215, 60)
        btnArticles.TabIndex = 4
        btnArticles.Text = "News && Events"
        btnArticles.TextAlign = ContentAlignment.MiddleLeft
        btnArticles.TextImageRelation = TextImageRelation.ImageBeforeText
        btnArticles.UseVisualStyleBackColor = True
        ' 
        ' btnTracker
        ' 
        btnTracker.Cursor = Cursors.Hand
        btnTracker.Dock = DockStyle.Top
        btnTracker.FlatAppearance.BorderSize = 0
        btnTracker.FlatStyle = FlatStyle.Flat
        btnTracker.Font = New Font("Inter", 9.75F)
        btnTracker.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
        btnTracker.IconColor = Color.Black
        btnTracker.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTracker.IconSize = 32
        btnTracker.ImageAlign = ContentAlignment.MiddleLeft
        btnTracker.Location = New Point(0, 220)
        btnTracker.Name = "btnTracker"
        btnTracker.Padding = New Padding(15, 0, 15, 0)
        btnTracker.Size = New Size(215, 60)
        btnTracker.TabIndex = 3
        btnTracker.Text = "Tracker"
        btnTracker.TextAlign = ContentAlignment.MiddleLeft
        btnTracker.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTracker.UseVisualStyleBackColor = True
        ' 
        ' btnBMI
        ' 
        btnBMI.Cursor = Cursors.Hand
        btnBMI.Dock = DockStyle.Top
        btnBMI.FlatAppearance.BorderSize = 0
        btnBMI.FlatStyle = FlatStyle.Flat
        btnBMI.Font = New Font("Inter", 9.75F)
        btnBMI.IconChar = FontAwesome.Sharp.IconChar.Calculator
        btnBMI.IconColor = Color.Black
        btnBMI.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBMI.IconSize = 32
        btnBMI.ImageAlign = ContentAlignment.MiddleLeft
        btnBMI.Location = New Point(0, 160)
        btnBMI.Name = "btnBMI"
        btnBMI.Padding = New Padding(15, 0, 15, 0)
        btnBMI.Size = New Size(215, 60)
        btnBMI.TabIndex = 2
        btnBMI.Text = "BMI Calculator"
        btnBMI.TextAlign = ContentAlignment.MiddleLeft
        btnBMI.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBMI.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Cursor = Cursors.Hand
        btnHome.Dock = DockStyle.Top
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Inter", 9.75F)
        btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt
        btnHome.IconColor = Color.Black
        btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnHome.IconSize = 32
        btnHome.ImageAlign = ContentAlignment.MiddleLeft
        btnHome.Location = New Point(0, 100)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(15, 0, 15, 0)
        btnHome.Size = New Size(215, 60)
        btnHome.TabIndex = 1
        btnHome.Text = "Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(picLogo)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(215, 100)
        Panel2.TabIndex = 0
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(24, 10)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(152, 78)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' formHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(865, 555)
        Controls.Add(pnlDesktop)
        Controls.Add(pnlNavigation)
        FormBorderStyle = FormBorderStyle.None
        Name = "formHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formHome"
        pnlNavigation.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDesktop As Panel
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents btnProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents btnArticles As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTracker As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBMI As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
