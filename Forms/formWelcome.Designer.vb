<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formWelcome
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
        lblUsername = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.None
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Inter ExtraBold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblUsername.Location = New Point(160, 211)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(286, 116)
        lblUsername.TabIndex = 9
        lblUsername.Text = "John"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Inter SemiBold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(207, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 77)
        Label2.TabIndex = 8
        Label2.Text = "Hello"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter ExtraBold", 18F, FontStyle.Bold)
        Label1.Location = New Point(43, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 29)
        Label1.TabIndex = 7
        Label1.Text = "HOME"
        ' 
        ' formWelcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 477)
        Controls.Add(lblUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formWelcome"
        Text = "formWelcome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
