Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If InStr(1, txtMessage.Text, "Paul Miller") Then
            MsgBox("Hello Paul Miller!")
            GoTo Done
        End If
        If InStr(1, txtMessage.Text, "Guy Man") Then
            MsgBox("Greetings Guy Man!")
            GoTo Done
        End If
Done:
    End Sub
End Class
