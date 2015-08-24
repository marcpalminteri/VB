Public Class frmListBox

    Private Sub frmListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCounties.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tboAdd.Text <> "" Then
            ListBox1.Items.Add(tboAdd.Text)
            tboAdd.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class