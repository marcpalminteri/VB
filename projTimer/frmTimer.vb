Public Class frmTimer

    Private Sub frmTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStop.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer.Start()
        lblTimer.Text = 0
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnReset.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer.Stop()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblTimer.Text = 0
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblTimer.Text = Decimal.Parse(lblTimer.Text) + 0.1
    End Sub

End Class
