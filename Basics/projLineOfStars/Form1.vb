Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStars_Click(sender As Object, e As EventArgs) Handles btnStars.Click
        txtStars.Text = ""
        For iCount As Integer = 1 To 20 Step 1
            txtStars.Text = txtStars.Text & "*"
            Application.DoEvents()
        Next
    End Sub
End Class