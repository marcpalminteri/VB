Public Class frmLogIn

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If tboPassword.Text = "password" Then
            frmWelcome.Show()
        Else
            MessageBox.Show("Wrong password!")
        End If
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub tboPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tboPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSubmit.PerformClick()
        End If
    End Sub
End Class
