Public Class frmControl

    Dim formDisplay As New frmDisplay

    Private Sub btnDisplay1_Click(sender As Object, e As EventArgs) Handles btnDisplay1.Click
        Dim counter As Integer
        Dim output As String = String.Empty
        For counter = 0 To 50
            output = output & "Line " & counter & ": Display 1" & Environment.NewLine
        Next
        formDisplay.txtDisplay.Text = output
        formDisplay.Show()
    End Sub

    Private Sub btnDisplay2_Click(sender As Object, e As EventArgs) Handles btnDisplay2.Click
        Dim counter As Integer
        Dim output As String = String.Empty
        For counter = 0 To 50
            output = output & "Line " & counter & ": Display 2" & Environment.NewLine
        Next
        formDisplay.txtDisplay.Text = output
        formDisplay.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class