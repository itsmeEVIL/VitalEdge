﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formForgot
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
        btnReset = New Button()
        Label3 = New Label()
        txtPassword = New RichTextBox()
        txtEmail = New RichTextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        txtPasswordConfirm = New RichTextBox()
        Label2 = New Label()
        lblLogin = New LinkLabel()
        SuspendLayout()
        ' 
        ' btnReset
        ' 
        btnReset.Anchor = AnchorStyles.None
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnReset.ForeColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        btnReset.Location = New Point(85, 406)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(248, 34)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold)
        Label3.Location = New Point(81, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(263, 19)
        Label3.TabIndex = 58
        Label3.Text = "Please enter your new password."
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(85, 275)
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
        txtEmail.Location = New Point(85, 209)
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
        Label9.Location = New Point(81, 253)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 19)
        Label9.TabIndex = 55
        Label9.Text = "New Password:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(81, 187)
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
        Label1.Location = New Point(61, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 45)
        Label1.TabIndex = 53
        Label1.Text = "Reset Password"
        ' 
        ' txtPasswordConfirm
        ' 
        txtPasswordConfirm.Anchor = AnchorStyles.None
        txtPasswordConfirm.BorderStyle = BorderStyle.None
        txtPasswordConfirm.Cursor = Cursors.IBeam
        txtPasswordConfirm.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPasswordConfirm.Location = New Point(85, 342)
        txtPasswordConfirm.Multiline = False
        txtPasswordConfirm.Name = "txtPasswordConfirm"
        txtPasswordConfirm.ScrollBars = RichTextBoxScrollBars.None
        txtPasswordConfirm.Size = New Size(248, 34)
        txtPasswordConfirm.TabIndex = 3
        txtPasswordConfirm.Text = ""
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(81, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 19)
        Label2.TabIndex = 61
        Label2.Text = "Reconfirm New Password:"
        ' 
        ' lblLogin
        ' 
        lblLogin.ActiveLinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblLogin.Anchor = AnchorStyles.None
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogin.LinkArea = New LinkArea(23, 30)
        lblLogin.LinkBehavior = LinkBehavior.HoverUnderline
        lblLogin.LinkColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblLogin.Location = New Point(97, 443)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(220, 21)
        lblLogin.TabIndex = 5
        lblLogin.TabStop = True
        lblLogin.Text = "Remember your password? Log In"
        lblLogin.UseCompatibleTextRendering = True
        lblLogin.VisitedLinkColor = Color.Black
        ' 
        ' formForgot
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 555)
        Controls.Add(txtPasswordConfirm)
        Controls.Add(Label2)
        Controls.Add(lblLogin)
        Controls.Add(btnReset)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formForgot"
        Text = "formForgot"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As RichTextBox
    Friend WithEvents txtEmail As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswordConfirm As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLogin As LinkLabel
End Class
