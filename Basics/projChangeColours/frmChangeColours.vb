Public Class frmChangeColours

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        Dim BackColour1, BackColour2 As Color

        BackColour1 = txt1.BackColor
        BackColour2 = txt2.BackColor

        txt1.BackColor = BackColour2
        txt2.BackColor = BackColour1

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
