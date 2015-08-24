Public Class frmScope

    Dim strOutput As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtScope.Text = ""
        strOutput = "Testing scope variables. One"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtScope.Text = strOutput

    End Sub
End Class
