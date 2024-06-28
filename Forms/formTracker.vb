Imports System.Windows.Forms.ComboBox

Public Class formTracker
    Private Const CaloriesPerKmRunning As Double = 100
    Private Const CaloriesPerKmWalking As Double = 60

    Private Sub formTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbActivity.ItemHeight = 28
        cmbActivity.DropDownHeight = 60
    End Sub

    Private Sub cmbActivity_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmbActivity.DrawItem
        If e.Index < 0 Then Exit Sub

        Dim item As String = cmbActivity.Items(e.Index).ToString()
        Dim brush As Brush = Brushes.Black
        Dim backgroundColor As Color = If((e.State And DrawItemState.Selected) = DrawItemState.Selected, SystemColors.Highlight, SystemColors.Window)

        e.DrawBackground()

        e.Graphics.DrawString(item, cmbActivity.Font, brush, e.Bounds)

        e.DrawFocusRectangle()
    End Sub

    Private Sub cmbActivity_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles cmbActivity.MeasureItem
        e.ItemHeight = 30
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim distance As Double
        If Not Double.TryParse(txtDistance.Text, distance) Then
            MessageBox.Show("Please enter a valid distance in kilometers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim caloriesBurned As Double
        Select Case cmbActivity.SelectedItem.ToString()
            Case "Running"
                caloriesBurned = CaloriesPerKmRunning * distance
            Case "Walking"
                caloriesBurned = CaloriesPerKmWalking * distance
        End Select

        txtCalories.Text = caloriesBurned & " cal"
    End Sub
End Class