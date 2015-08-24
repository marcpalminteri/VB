Public Class frmTrainees

    Dim strOutput As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNationality.SelectedItem = "Irish"
        cboBirthCountry.SelectedItem = "Ireland"
        cboAddress.SelectedItem = "Dublin"

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFirstname.Text <> "" Then
            If CheckForAlphaCharacters(txtFirstname.Text) Then
                strOutput = strOutput & txtFirstname.Text & ", "
            Else
                MsgBox("Only enter valid characters")
                Return
            End If
        Else
            MsgBox("Enter something")
        End If
        MsgBox(strOutput)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboBirthCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBirthCountry.SelectedIndexChanged
        If cboBirthCountry.Text = "Ireland" Then
            lblBirthCounty.Visible = True
            cboBirthCounty.Visible = True
        Else
            lblBirthCounty.Visible = False
            cboBirthCounty.Visible = False
        End If
    End Sub

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next

        Return True
    End Function

End Class