Public Class frmMetricConversion

    Private Sub frmMetricConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpbDistance.Enabled = False
        gpbTemperature.Enabled = False
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If rdoDistance.Checked Then
            If IsNumeric(txtMiles.Text) Or IsNumeric(txtKilo.Text) Then
                If txtMiles.Text <> "" Then
                    Dim mileValue As Decimal = Decimal.Parse(txtMiles.Text)
                    txtKilo.Text = (mileValue * (8 / 5)).ToString
                Else
                    Dim kiloValue As Decimal = Decimal.Parse(txtKilo.Text)
                    txtMiles.Text = (kiloValue * (5 / 8)).ToString
                End If
            Else
                MsgBox("Enter a number into either box", , "No number")
            End If
        ElseIf rdoTemperature.Checked Then
            If txtCelsius.Text = "" And txtFahrenheit.Text = "" Then
                MsgBox("Enter a number into either box", , "No value")
            Else
                If txtCelsius.Text <> "" Then
                    Dim celValue As Decimal = Decimal.Parse(txtCelsius.Text)
                    txtFahrenheit.Text = ((celValue * (9 / 5)) + 32).ToString
                Else
                    Dim farValue As Decimal = Decimal.Parse(txtFahrenheit.Text)
                    txtCelsius.Text = ((farValue - 32) * (5 / 9)).ToString
                End If
            End If
        Else
            MsgBox("Select a type of conversion", , "No option selected")
        End If
    End Sub

    Private Sub rdoDistance_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDistance.CheckedChanged
        btnClear.PerformClick()
            gpbDistance.Enabled = True
            gpbTemperature.Enabled = False

    End Sub

    Private Sub rdoTemperature_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTemperature.CheckedChanged
        btnClear.PerformClick()

        gpbDistance.Enabled = False
        gpbTemperature.Enabled = True

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtKilo.Clear()
        txtMiles.Clear()
        txtCelsius.Clear()
        txtFahrenheit.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class