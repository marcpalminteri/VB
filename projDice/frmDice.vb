Public Class frmDice
    Dim random As New Random
    Dim counter As Integer = 0
    Private Sub frmDice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter As Integer = 0
        btnDie2.Enabled = False
    End Sub

    Private Sub btnDie1_Click(sender As Object, e As EventArgs) Handles btnDie1.Click
        txtDie1.Text = random.Next(1, 7)
        txtDie2.Clear()
        btnDie1.Text = ""
        btnDie2.Text = "Roll!"
        btnDie1.Enabled = False
        btnDie2.Enabled = True
        btnDie2.Select()
    End Sub

    Private Sub btnDie2_Click(sender As Object, e As EventArgs) Handles btnDie2.Click
        txtDie2.Text = random.Next(1, 7)
        txtScore.Text = Integer.Parse(txtDie1.Text) + Integer.Parse(txtDie2.Text)
        counter = counter + 1
        txtNoOfRolls.Text = Convert.ToString(counter)
        If Convert.ToInt32(txtScore.Text) > 9 Then
            If Convert.ToInt32(txtNoOfRolls.Text) = 1 Then
                MsgBox("You won after 1 try!")
            Else
                MsgBox("You won after " + txtNoOfRolls.Text + " tries!")
            End If
            counter = 0
            btnDie1.Text = "Roll!"
            btnDie2.Text = ""
            txtDie1.Clear()
            txtDie2.Clear()
            txtNoOfRolls.Clear()
            txtScore.Clear()
        End If
        btnDie1.Text = "Roll!"
        btnDie2.Text = ""
        btnDie1.Enabled = True
        btnDie2.Enabled = False
        btnDie1.Select
    End Sub
End Class
