<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLanding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLanding))
        pnlImage = New Panel()
        Label2 = New Label()
        picLogo = New PictureBox()
        pnlUsers = New Panel()
        pnlImage.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlImage
        ' 
        pnlImage.BackColor = Color.WhiteSmoke
        pnlImage.Controls.Add(Label2)
        pnlImage.Controls.Add(picLogo)
        pnlImage.Dock = DockStyle.Left
        pnlImage.Location = New Point(0, 0)
        pnlImage.Name = "pnlImage"
        pnlImage.Size = New Size(442, 555)
        pnlImage.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Inter SemiBold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(399, 77)
        Label2.TabIndex = 9
        Label2.Text = "Welcome to"
        ' 
        ' picLogo
        ' 
        picLogo.Anchor = AnchorStyles.None
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(55, 214)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(336, 190)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' pnlUsers
        ' 
        pnlUsers.Dock = DockStyle.Left
        pnlUsers.Location = New Point(442, 0)
        pnlUsers.Name = "pnlUsers"
        pnlUsers.Size = New Size(423, 555)
        pnlUsers.TabIndex = 7
        ' 
        ' formLanding
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(865, 555)
        Controls.Add(pnlUsers)
        Controls.Add(pnlImage)
        FormBorderStyle = FormBorderStyle.None
        Name = "formLanding"
        Text = "formLanding"
        pnlImage.ResumeLayout(False)
        pnlImage.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlImage As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlUsers As Panel
End Class
