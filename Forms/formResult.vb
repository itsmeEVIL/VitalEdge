Public Class formResult
    Private ReadOnly _gender As String
    Private ReadOnly _age As Integer
    Private ReadOnly _height As Double
    Private ReadOnly _weight As Double
    Private ReadOnly _bmi As Double
    Private ReadOnly _bmiCategory As String

    Public Sub New(gender As String, age As Integer, height As Double, weight As Double, bmi As Double, bmiCategory As String)
        InitializeComponent()
        _gender = gender
        _age = age
        _height = height
        _weight = weight
        _bmi = bmi
        _bmiCategory = bmiCategory
    End Sub

    Private Sub formResult_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblGender.Text = _gender
        lblAge.Text = _age
        lblHeight.Text = _height.ToString()
        lblWeight.Text = _weight.ToString()
        lblBMIScore.Text = _bmi.ToString("F2")
        lblBMIStatus.Text = _bmiCategory

        If _bmiCategory = "Underweight" Then
            lblBMIScore.ForeColor = Color.FromArgb(2, 174, 247)
            lblBMIStatus.ForeColor = Color.FromArgb(2, 174, 247)
        ElseIf _bmiCategory = "Normal" Then
            lblBMIScore.ForeColor = Color.FromArgb(70, 158, 56)
            lblBMIStatus.ForeColor = Color.FromArgb(70, 158, 56)
        ElseIf _bmiCategory = "Overweight" Then
            lblBMIScore.ForeColor = Color.FromArgb(255, 189, 4)
            lblBMIStatus.ForeColor = Color.FromArgb(255, 189, 4)
        Else
            lblBMIScore.ForeColor = Color.FromArgb(244, 16, 16)
            lblBMIStatus.ForeColor = Color.FromArgb(244, 16, 16)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim parentForm As formHome = TryCast(Me.ParentForm, formHome)
        parentForm.ReplaceChildForm(New formCalculator)
    End Sub
End Class