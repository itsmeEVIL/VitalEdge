<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formResult
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
        btnBack = New Button()
        lblWeight = New Label()
        Label9 = New Label()
        lblHeight = New Label()
        Label7 = New Label()
        lblAge = New Label()
        Label5 = New Label()
        lblGender = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblBMIScore = New Label()
        lblBMIStatus = New Label()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBack.Cursor = Cursors.Hand
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnBack.ForeColor = Color.Black
        btnBack.Location = New Point(443, 454)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(135, 34)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblWeight
        ' 
        lblWeight.Anchor = AnchorStyles.None
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeight.ForeColor = Color.Black
        lblWeight.Location = New Point(336, 400)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(29, 19)
        lblWeight.TabIndex = 34
        lblWeight.Text = "68"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label9.Location = New Point(242, 399)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 19)
        Label9.TabIndex = 33
        Label9.Text = "Weight:"
        ' 
        ' lblHeight
        ' 
        lblHeight.Anchor = AnchorStyles.None
        lblHeight.AutoSize = True
        lblHeight.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeight.ForeColor = Color.Black
        lblHeight.Location = New Point(336, 368)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(36, 19)
        lblHeight.TabIndex = 32
        lblHeight.Text = "173"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(245, 366)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 19)
        Label7.TabIndex = 31
        Label7.Text = "Height:"
        ' 
        ' lblAge
        ' 
        lblAge.Anchor = AnchorStyles.None
        lblAge.AutoSize = True
        lblAge.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAge.ForeColor = Color.Black
        lblAge.Location = New Point(336, 332)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(27, 19)
        lblAge.TabIndex = 30
        lblAge.Text = "19"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label5.Location = New Point(266, 332)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 19)
        Label5.TabIndex = 29
        Label5.Text = "Age:"
        ' 
        ' lblGender
        ' 
        lblGender.Anchor = AnchorStyles.None
        lblGender.AutoSize = True
        lblGender.Font = New Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGender.ForeColor = Color.Black
        lblGender.Location = New Point(336, 295)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(46, 19)
        lblGender.TabIndex = 28
        lblGender.Text = "Male"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(243, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 19)
        Label2.TabIndex = 26
        Label2.Text = "Gender:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter ExtraBold", 18F, FontStyle.Bold)
        Label1.Location = New Point(43, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 29)
        Label1.TabIndex = 23
        Label1.Text = "BMI RESULT"
        ' 
        ' lblBMIScore
        ' 
        lblBMIScore.Anchor = AnchorStyles.None
        lblBMIScore.Font = New Font("Inter ExtraBold", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBMIScore.ForeColor = Color.FromArgb(CByte(70), CByte(158), CByte(56))
        lblBMIScore.Location = New Point(126, 85)
        lblBMIScore.Name = "lblBMIScore"
        lblBMIScore.Size = New Size(386, 116)
        lblBMIScore.TabIndex = 36
        lblBMIScore.Text = "22.7"
        lblBMIScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBMIStatus
        ' 
        lblBMIStatus.Anchor = AnchorStyles.None
        lblBMIStatus.Font = New Font("Inter ExtraBold", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBMIStatus.ForeColor = Color.FromArgb(CByte(70), CByte(158), CByte(56))
        lblBMIStatus.Location = New Point(171, 185)
        lblBMIStatus.Name = "lblBMIStatus"
        lblBMIStatus.Size = New Size(291, 42)
        lblBMIStatus.TabIndex = 37
        lblBMIStatus.Text = "Normal"
        lblBMIStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' formResult
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 516)
        Controls.Add(lblBMIStatus)
        Controls.Add(lblBMIScore)
        Controls.Add(btnBack)
        Controls.Add(lblWeight)
        Controls.Add(Label9)
        Controls.Add(lblHeight)
        Controls.Add(Label7)
        Controls.Add(lblAge)
        Controls.Add(Label5)
        Controls.Add(lblGender)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formResult"
        Text = "formResult"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblWeight As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBMIScore As Label
    Friend WithEvents lblBMIStatus As Label
End Class
