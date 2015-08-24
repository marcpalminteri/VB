Public Class projMyName

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        txtMyName.BackColor = Color.MidnightBlue
        txtMyName.ForeColor = Color.Silver
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        txtMyName.BackColor = Color.Silver
        txtMyName.ForeColor = Color.MidnightBlue
    End Sub
End Class
