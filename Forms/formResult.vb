Public Class formResult
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim parentForm As formHome = TryCast(Me.ParentForm, formHome)
        parentForm.ReplaceChildForm(New formCalculator)
    End Sub
End Class