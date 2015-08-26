Public Class frmDemoListBox

    Private Sub frmDemoListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPricePds.Items.Add("Potato           149")
        lstPricePds.Items.Add("Red Pepper       343")
        lstPricePds.Items.Add("Cauliflower      193")
        lstPricePds.Items.Add("Carrot           075")
        lstPricePds.Items.Add("Pea              132")
        lstPricePds.Items.Add("Courgette        207")
        lstPricePds.Items.Add("Onion            168")
        lstPricePds.Items.Add("Green Bean       149")
        lstPricePds.Items.Add("Mushroom         243")
        lstPricePds.Items.Add("Broccoli         203")
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub lstPricePds_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPricePds.DoubleClick
        Dim temp, veg, pence, pounds, cents, euros, converted, twoPrices As String
        Dim exchangeRate As Single = 1.14

        temp = lstPricePds.Text
        veg = temp.Substring(0, temp.Length - 3)
        pence = temp.Substring(temp.Length - 3)
        cents = Format(exchangeRate * CInt(pence), "000")
        converted = veg & cents
        lstPriceEuros.Items.Add(converted)
        pounds = Format(CInt(pence) / 100, "0.00")
        euros = Format(CInt(cents) / 100, "0.00")
        twoPrices = veg & " £" & pounds & " = " & "€ " & euros
        txtPriceBoth.Text = txtPriceBoth.Text & twoPrices & vbCrLf
    End Sub

End Class