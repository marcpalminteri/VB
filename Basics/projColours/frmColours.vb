Public Class frmColours

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        txtDisplay.BackColor = Color.Blue
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        txtDisplay.BackColor = Color.Red
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        txtDisplay.BackColor = Color.Green
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
