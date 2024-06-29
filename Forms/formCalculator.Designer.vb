<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCalculator))
        Label1 = New Label()
        btnCalculate = New Button()
        Label9 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        txtAge = New RichTextBox()
        txtHeight = New RichTextBox()
        txtWeight = New RichTextBox()
        rdbMale = New RadioButton()
        rdbFemale = New RadioButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter ExtraBold", 18F, FontStyle.Bold)
        Label1.Location = New Point(43, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 29)
        Label1.TabIndex = 1
        Label1.Text = "BMI CALCULATOR"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.None
        btnCalculate.Cursor = Cursors.Hand
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        btnCalculate.Location = New Point(330, 436)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(192, 34)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label9.Location = New Point(326, 343)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 19)
        Label9.TabIndex = 24
        Label9.Text = "Weight (kg):"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(326, 260)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 19)
        Label7.TabIndex = 23
        Label7.Text = "Height (cm):"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label5.Location = New Point(326, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 19)
        Label5.TabIndex = 22
        Label5.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(326, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 19)
        Label2.TabIndex = 21
        Label2.Text = "Gender:"
        ' 
        ' txtAge
        ' 
        txtAge.Anchor = AnchorStyles.None
        txtAge.BorderStyle = BorderStyle.None
        txtAge.Cursor = Cursors.IBeam
        txtAge.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(330, 200)
        txtAge.Multiline = False
        txtAge.Name = "txtAge"
        txtAge.ScrollBars = RichTextBoxScrollBars.None
        txtAge.Size = New Size(192, 34)
        txtAge.TabIndex = 3
        txtAge.Text = ""
        ' 
        ' txtHeight
        ' 
        txtHeight.Anchor = AnchorStyles.None
        txtHeight.BorderStyle = BorderStyle.None
        txtHeight.Cursor = Cursors.IBeam
        txtHeight.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHeight.Location = New Point(330, 282)
        txtHeight.Multiline = False
        txtHeight.Name = "txtHeight"
        txtHeight.ScrollBars = RichTextBoxScrollBars.None
        txtHeight.Size = New Size(192, 34)
        txtHeight.TabIndex = 4
        txtHeight.Text = ""
        ' 
        ' txtWeight
        ' 
        txtWeight.Anchor = AnchorStyles.None
        txtWeight.BorderStyle = BorderStyle.None
        txtWeight.Cursor = Cursors.IBeam
        txtWeight.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtWeight.Location = New Point(330, 365)
        txtWeight.Multiline = False
        txtWeight.Name = "txtWeight"
        txtWeight.ScrollBars = RichTextBoxScrollBars.None
        txtWeight.Size = New Size(192, 34)
        txtWeight.TabIndex = 5
        txtWeight.Text = ""
        ' 
        ' rdbMale
        ' 
        rdbMale.Anchor = AnchorStyles.None
        rdbMale.Appearance = Appearance.Button
        rdbMale.BackColor = Color.WhiteSmoke
        rdbMale.CheckAlign = ContentAlignment.MiddleCenter
        rdbMale.Checked = True
        rdbMale.Cursor = Cursors.Hand
        rdbMale.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        rdbMale.Location = New Point(330, 120)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(88, 34)
        rdbMale.TabIndex = 1
        rdbMale.TabStop = True
        rdbMale.Tag = "gender"
        rdbMale.Text = "Male"
        rdbMale.TextAlign = ContentAlignment.MiddleCenter
        rdbMale.UseVisualStyleBackColor = False
        ' 
        ' rdbFemale
        ' 
        rdbFemale.Anchor = AnchorStyles.None
        rdbFemale.Appearance = Appearance.Button
        rdbFemale.BackColor = Color.WhiteSmoke
        rdbFemale.Cursor = Cursors.Hand
        rdbFemale.Font = New Font("Inter SemiBold", 10F, FontStyle.Bold)
        rdbFemale.Location = New Point(435, 120)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(87, 34)
        rdbFemale.TabIndex = 2
        rdbFemale.Tag = "gender"
        rdbFemale.Text = "Female"
        rdbFemale.TextAlign = ContentAlignment.MiddleCenter
        rdbFemale.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(90, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(207, 414)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' formCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 516)
        Controls.Add(PictureBox1)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtWeight)
        Controls.Add(txtHeight)
        Controls.Add(txtAge)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(btnCalculate)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formCalculator"
        Text = "formCalculator"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAge As RichTextBox
    Friend WithEvents txtHeight As RichTextBox
    Friend WithEvents txtWeight As RichTextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
