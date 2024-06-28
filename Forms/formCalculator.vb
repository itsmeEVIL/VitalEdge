Public Class formCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim parentForm As formHome = TryCast(Me.ParentForm, formHome)
        parentForm.ReplaceChildForm(New formResult)
    End Sub
End Class