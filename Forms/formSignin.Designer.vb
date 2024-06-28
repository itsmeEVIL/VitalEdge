<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSignin
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
        lblLogin = New LinkLabel()
        btnSignin = New Button()
        Label3 = New Label()
        txtPassword = New RichTextBox()
        txtEmail = New RichTextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        txtUsername = New RichTextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblLogin
        ' 
        lblLogin.ActiveLinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblLogin.Anchor = AnchorStyles.None
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogin.LinkArea = New LinkArea(25, 30)
        lblLogin.LinkBehavior = LinkBehavior.HoverUnderline
        lblLogin.LinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblLogin.Location = New Point(106, 460)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(210, 21)
        lblLogin.TabIndex = 5
        lblLogin.TabStop = True
        lblLogin.Text = "Already have an account? Log In"
        lblLogin.UseCompatibleTextRendering = True
        lblLogin.VisitedLinkColor = Color.Black
        ' 
        ' btnSignin
        ' 
        btnSignin.Anchor = AnchorStyles.None
        btnSignin.Cursor = Cursors.Hand
        btnSignin.FlatStyle = FlatStyle.Flat
        btnSignin.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnSignin.ForeColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        btnSignin.Location = New Point(84, 420)
        btnSignin.Name = "btnSignin"
        btnSignin.Size = New Size(248, 34)
        btnSignin.TabIndex = 4
        btnSignin.Text = "Sign In"
        btnSignin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold)
        Label3.Location = New Point(108, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 19)
        Label3.TabIndex = 58
        Label3.Text = "Please enter your details."
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(84, 346)
        txtPassword.Multiline = False
        txtPassword.Name = "txtPassword"
        txtPassword.ScrollBars = RichTextBoxScrollBars.None
        txtPassword.Size = New Size(248, 34)
        txtPassword.TabIndex = 3
        txtPassword.Text = ""
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.None
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Cursor = Cursors.IBeam
        txtEmail.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(84, 206)
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
        Label9.Location = New Point(80, 324)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 19)
        Label9.TabIndex = 55
        Label9.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(80, 184)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 19)
        Label7.TabIndex = 54
        Label7.Text = "Email:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Inter SemiBold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(110, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 45)
        Label1.TabIndex = 53
        Label1.Text = "Welcome!"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(84, 275)
        txtUsername.Multiline = False
        txtUsername.Name = "txtUsername"
        txtUsername.ScrollBars = RichTextBoxScrollBars.None
        txtUsername.Size = New Size(248, 34)
        txtUsername.TabIndex = 2
        txtUsername.Text = ""
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label4.Location = New Point(80, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 19)
        Label4.TabIndex = 63
        Label4.Text = "Username:"
        ' 
        ' formSignin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 555)
        Controls.Add(txtUsername)
        Controls.Add(Label4)
        Controls.Add(lblLogin)
        Controls.Add(btnSignin)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formSignin"
        Text = "formSignin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogin As LinkLabel
    Friend WithEvents btnSignin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As RichTextBox
    Friend WithEvents txtEmail As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As RichTextBox
    Friend WithEvents Label4 As Label
End Class
