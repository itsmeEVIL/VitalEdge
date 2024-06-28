<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        lblForgotPassword = New LinkLabel()
        lblSignup = New LinkLabel()
        btnLogin = New Button()
        Label3 = New Label()
        txtPassword = New RichTextBox()
        txtEmail = New RichTextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblForgotPassword
        ' 
        lblForgotPassword.ActiveLinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblForgotPassword.Anchor = AnchorStyles.None
        lblForgotPassword.AutoSize = True
        lblForgotPassword.Font = New Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblForgotPassword.LinkArea = New LinkArea(0, 15)
        lblForgotPassword.LinkBehavior = LinkBehavior.HoverUnderline
        lblForgotPassword.LinkColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        lblForgotPassword.Location = New Point(219, 355)
        lblForgotPassword.Name = "lblForgotPassword"
        lblForgotPassword.Size = New Size(113, 16)
        lblForgotPassword.TabIndex = 4
        lblForgotPassword.TabStop = True
        lblForgotPassword.Text = "Forgot password"
        lblForgotPassword.VisitedLinkColor = Color.Black
        ' 
        ' lblSignup
        ' 
        lblSignup.ActiveLinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblSignup.Anchor = AnchorStyles.None
        lblSignup.AutoSize = True
        lblSignup.Font = New Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSignup.LinkArea = New LinkArea(23, 30)
        lblSignup.LinkBehavior = LinkBehavior.HoverUnderline
        lblSignup.LinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblSignup.Location = New Point(106, 441)
        lblSignup.Name = "lblSignup"
        lblSignup.Size = New Size(206, 21)
        lblSignup.TabIndex = 5
        lblSignup.TabStop = True
        lblSignup.Text = "Don't have an account? Sign Up"
        lblSignup.UseCompatibleTextRendering = True
        lblSignup.VisitedLinkColor = Color.Black
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        btnLogin.Location = New Point(84, 401)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(248, 34)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold)
        Label3.Location = New Point(107, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 19)
        Label3.TabIndex = 49
        Label3.Text = "Please enter your details."
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(84, 318)
        txtPassword.Multiline = False
        txtPassword.Name = "txtPassword"
        txtPassword.ScrollBars = RichTextBoxScrollBars.None
        txtPassword.Size = New Size(248, 34)
        txtPassword.TabIndex = 2
        txtPassword.Text = ""
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.None
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Cursor = Cursors.IBeam
        txtEmail.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(84, 243)
        txtEmail.Multiline = False
        txtEmail.Name = "txtEmail"
        txtEmail.ScrollBars = RichTextBoxScrollBars.None
        txtEmail.Size = New Size(248, 34)
        txtEmail.TabIndex = 1
        txtEmail.Text = ""
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label9.Location = New Point(80, 296)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 19)
        Label9.TabIndex = 46
        Label9.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(80, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 19)
        Label7.TabIndex = 45
        Label7.Text = "Email:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Inter SemiBold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(70, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 45)
        Label1.TabIndex = 44
        Label1.Text = "Welcome back"
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 555)
        Controls.Add(lblForgotPassword)
        Controls.Add(lblSignup)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formLogin"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "formLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblForgotPassword As LinkLabel
    Friend WithEvents lblSignup As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As RichTextBox
    Friend WithEvents txtEmail As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
