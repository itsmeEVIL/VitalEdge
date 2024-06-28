<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formProfile))
        Label1 = New Label()
        picProfile = New PictureBox()
        btnChange = New Button()
        Label2 = New Label()
        btnDelete = New Button()
        lblUsername = New Label()
        lblEmail = New Label()
        Label5 = New Label()
        lblHealthPoint = New Label()
        Label7 = New Label()
        lblPassword = New Label()
        Label9 = New Label()
        btnLogOut = New Button()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter ExtraBold", 18F, FontStyle.Bold)
        Label1.Location = New Point(43, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 29)
        Label1.TabIndex = 3
        Label1.Text = "PROFILE"
        ' 
        ' picProfile
        ' 
        picProfile.Anchor = AnchorStyles.None
        picProfile.Image = CType(resources.GetObject("picProfile.Image"), Image)
        picProfile.Location = New Point(131, 119)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(100, 100)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 4
        picProfile.TabStop = False
        ' 
        ' btnChange
        ' 
        btnChange.Anchor = AnchorStyles.None
        btnChange.Cursor = Cursors.Hand
        btnChange.FlatStyle = FlatStyle.Flat
        btnChange.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnChange.Location = New Point(281, 125)
        btnChange.Name = "btnChange"
        btnChange.Size = New Size(135, 34)
        btnChange.TabIndex = 5
        btnChange.Text = "Change Picture"
        btnChange.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(131, 258)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 19)
        Label2.TabIndex = 6
        Label2.Text = "Username:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.None
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnDelete.ForeColor = Color.Red
        btnDelete.Location = New Point(281, 179)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(135, 34)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete Picture"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(281, 258)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(48, 19)
        lblUsername.TabIndex = 15
        lblUsername.Text = "John"
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.None
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.Black
        lblEmail.Location = New Point(281, 295)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(192, 19)
        lblEmail.TabIndex = 17
        lblEmail.Text = "john-1993@proton.mail"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label5.Location = New Point(131, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 19)
        Label5.TabIndex = 16
        Label5.Text = "Email:"
        ' 
        ' lblHealthPoint
        ' 
        lblHealthPoint.Anchor = AnchorStyles.None
        lblHealthPoint.AutoSize = True
        lblHealthPoint.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHealthPoint.ForeColor = Color.Black
        lblHealthPoint.Location = New Point(281, 331)
        lblHealthPoint.Name = "lblHealthPoint"
        lblHealthPoint.Size = New Size(36, 19)
        lblHealthPoint.TabIndex = 19
        lblHealthPoint.Text = "114"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(131, 331)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 19)
        Label7.TabIndex = 18
        Label7.Text = "HealthPoints:"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.None
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.Black
        lblPassword.Location = New Point(281, 367)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(90, 19)
        lblPassword.TabIndex = 21
        lblPassword.Text = "*********"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label9.Location = New Point(131, 367)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 19)
        Label9.TabIndex = 20
        Label9.Text = "Password:"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogOut.Cursor = Cursors.Hand
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnLogOut.ForeColor = Color.Red
        btnLogOut.Location = New Point(443, 454)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(135, 34)
        btnLogOut.TabIndex = 22
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' formProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(634, 516)
        Controls.Add(btnLogOut)
        Controls.Add(lblPassword)
        Controls.Add(Label9)
        Controls.Add(lblHealthPoint)
        Controls.Add(Label7)
        Controls.Add(lblEmail)
        Controls.Add(Label5)
        Controls.Add(lblUsername)
        Controls.Add(btnDelete)
        Controls.Add(Label2)
        Controls.Add(btnChange)
        Controls.Add(picProfile)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formProfile"
        Text = "formProfile"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnChange As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblHealthPoint As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
