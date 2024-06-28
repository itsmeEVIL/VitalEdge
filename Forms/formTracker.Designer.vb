<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTracker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTracker))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        txtCalories = New RichTextBox()
        txtDistance = New RichTextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        btnCalculate = New Button()
        Label2 = New Label()
        cmbActivity = New ComboBox()
        lblHealthPoints = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter ExtraBold", 18F, FontStyle.Bold)
        Label1.Location = New Point(43, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 29)
        Label1.TabIndex = 3
        Label1.Text = "TRACKER"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(244, 372)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' txtCalories
        ' 
        txtCalories.Anchor = AnchorStyles.None
        txtCalories.BackColor = Color.White
        txtCalories.BorderStyle = BorderStyle.None
        txtCalories.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCalories.Location = New Point(330, 282)
        txtCalories.Multiline = False
        txtCalories.Name = "txtCalories"
        txtCalories.ReadOnly = True
        txtCalories.ScrollBars = RichTextBoxScrollBars.None
        txtCalories.Size = New Size(191, 34)
        txtCalories.TabIndex = 38
        txtCalories.TabStop = False
        txtCalories.Text = ""
        ' 
        ' txtDistance
        ' 
        txtDistance.Anchor = AnchorStyles.None
        txtDistance.BorderStyle = BorderStyle.None
        txtDistance.Cursor = Cursors.IBeam
        txtDistance.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDistance.Location = New Point(330, 200)
        txtDistance.Multiline = False
        txtDistance.Name = "txtDistance"
        txtDistance.ScrollBars = RichTextBoxScrollBars.None
        txtDistance.Size = New Size(191, 34)
        txtDistance.TabIndex = 2
        txtDistance.Text = ""
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label9.Location = New Point(326, 260)
        Label9.Name = "Label9"
        Label9.Size = New Size(123, 19)
        Label9.TabIndex = 35
        Label9.Text = "Calories Burnt:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label7.Location = New Point(326, 178)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 19)
        Label7.TabIndex = 34
        Label7.Text = "Distance (km):"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label5.Location = New Point(326, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 19)
        Label5.TabIndex = 33
        Label5.Text = "Activity:"
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
        btnCalculate.Size = New Size(191, 34)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(330, 344)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10)
        Label2.Size = New Size(191, 80)
        Label2.TabIndex = 42
        Label2.Text = "Earn 10 HealthPoints for each kilometer."
        ' 
        ' cmbActivity
        ' 
        cmbActivity.Anchor = AnchorStyles.None
        cmbActivity.Cursor = Cursors.Hand
        cmbActivity.DrawMode = DrawMode.OwnerDrawVariable
        cmbActivity.FlatStyle = FlatStyle.Flat
        cmbActivity.Font = New Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbActivity.FormattingEnabled = True
        cmbActivity.Items.AddRange(New Object() {"Walking", "Running"})
        cmbActivity.Location = New Point(330, 121)
        cmbActivity.Name = "cmbActivity"
        cmbActivity.Size = New Size(191, 24)
        cmbActivity.TabIndex = 1
        ' 
        ' lblHealthPoints
        ' 
        lblHealthPoints.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHealthPoints.BackColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        lblHealthPoints.Font = New Font("Inter", 9.75F, FontStyle.Bold)
        lblHealthPoints.Location = New Point(455, 48)
        lblHealthPoints.Name = "lblHealthPoints"
        lblHealthPoints.Size = New Size(120, 23)
        lblHealthPoints.TabIndex = 46
        lblHealthPoints.Text = "120"
        lblHealthPoints.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.BackColor = Color.FromArgb(CByte(65), CByte(155), CByte(191))
        Label4.Font = New Font("Inter", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(455, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 29)
        Label4.TabIndex = 45
        Label4.Text = "My HealthPoints:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' formTracker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 516)
        Controls.Add(lblHealthPoints)
        Controls.Add(Label4)
        Controls.Add(cmbActivity)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(txtCalories)
        Controls.Add(txtDistance)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(btnCalculate)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formTracker"
        Text = "formTracker"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCalories As RichTextBox
    Friend WithEvents txtDistance As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbActivity As ComboBox
    Friend WithEvents lblHealthPoints As Label
    Friend WithEvents Label4 As Label
End Class
