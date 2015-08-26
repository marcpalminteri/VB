Public Class frmConcat

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'If String.Compare(txtEmail1.Text, txtEmail2.Text) <> 0 Then
        'MsgBox("Your email addresses do not match", , "Error")
        'txtEmail2.Clear()
        'Return
        'End If
        Dim position As Integer
        Dim afterSubString As String

        position = txtEmail1.Text.IndexOf("@")
        afterSubString = txtEmail1.Text.Substring(position, txtEmail1.Text.Length - position)
        position = afterSubString.IndexOf(".")
        MsgBox("Your email is of type " & afterSubString.Substring(position, afterSubString.Length - position))
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
