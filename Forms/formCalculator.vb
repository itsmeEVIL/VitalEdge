Public Class formCalculator
    Dim gender As String
    Dim age As Integer
    Dim height As Double
    Dim weight As Double
    Dim bmi As Double
    Dim bmiCategory As String

    Private Function ValidateFields(ByVal age As String, ByVal height As String, ByVal weight As String) As Boolean
        If String.IsNullOrEmpty(age) OrElse String.IsNullOrEmpty(height) OrElse String.IsNullOrEmpty(weight) Then
            MsgBox("Please fill in all the fields!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Incomplete Information")
            If String.IsNullOrEmpty(age) Then
                txtAge.Focus()
            ElseIf String.IsNullOrEmpty(height) Then
                txtHeight.Focus()
            Else
                txtWeight.Focus()
            End If
            Return False
        End If

        If Not Double.TryParse(CDbl(height), height) OrElse Not Double.TryParse(CDbl(weight), weight) Then
            MsgBox("Please make sure the value is valid!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Value")
            If Not Double.TryParse(CDbl(height), height) Then
                txtHeight.Focus()
            ElseIf Not Double.TryParse(CDbl(weight), weight) Then
                txtWeight.Focus()
            End If
            Return False
        End If

        Return True
    End Function

    Private Sub calculateBMI()
        If rdbMale.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        Dim heightInMeters As Double = CDbl(height) / 100.0
        bmi = CDbl(weight) / (heightInMeters * heightInMeters)

        If bmi < 18.5 Then
            bmiCategory = "Underweight"
        ElseIf bmi < 24.9 Then
            bmiCategory = "Normal"
        ElseIf bmi < 29.9 Then
            bmiCategory = "Overweight"
        Else
            bmiCategory = "Obesity"
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        age = txtAge.Text
        height = txtHeight.Text
        weight = txtWeight.Text

        If Not ValidateFields(age, height, weight) Then
            Exit Sub
        End If

        calculateBMI()

        Dim parentForm As formHome = TryCast(Me.ParentForm, formHome)
        parentForm.ReplaceChildForm(New formResult(gender, age, height, weight, bmi, bmiCategory))
    End Sub
End Class