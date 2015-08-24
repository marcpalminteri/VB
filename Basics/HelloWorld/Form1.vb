Public Class frmHello

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdShowHide_Click(sender As Object, e As EventArgs) Handles cmdShowHide.Click
        If lblMsg.Visible Then
            lblMsg.Visible = False
            cmdShowHide.Text = "Say Hello"
        Else
            lblMsg.Visible = True
            cmdShowHide.Text = "Hide Message"
        End If
    End Sub

End Class