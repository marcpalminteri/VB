Public Class frmTrainees

    Dim strOutput As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNationality.SelectedItem = "Irish"
        cboBirthCountry.SelectedItem = "Ireland"
        cboAddress.SelectedItem = "Dublin"

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim FirstnameCorrect As Boolean = True
        Dim LastnameCorrect As Boolean = True
        Dim AddressCorrect As Boolean = True
        Dim PhoneCorrect As Boolean = True

        If txtFirstname.Text <> "" Then
            If CheckForAlphaCharacters(txtFirstname.Text) Then
                strOutput = strOutput & txtFirstname.Text & ", "
                FirstnameCorrect = True
            Else
                MsgBox("Only enter characters in the 'First Name' field")
                Return
            End If
        Else
            FirstnameCorrect = False
        End If

        If txtLastname.Text <> "" Then
            If CheckForAlphaCharacters(txtLastname.Text) Then
                strOutput = strOutput & txtLastname.Text & ", "
                LastnameCorrect = True
            Else
                MsgBox("Only enter characters into the 'Last Name' field")
                Return
            End If
        Else
            LastnameCorrect = False
        End If

        If txtAddress1.Text = "" Then
            AddressCorrect = False
        End If

        
        If txtPhone.Text = "" Then
            PhoneCorrect = False
        ElseIf Not IsNumeric(txtPhone.Text) Then
            MsgBox("Only enter numbers into the 'Phone Number' field")
            Return
        End If

        If Not FirstnameCorrect Or Not LastnameCorrect Or Not AddressCorrect Or Not PhoneCorrect Then
            Dim errorMessage As String = "The following boxes are empty:"
            If FirstnameCorrect = False Then
                errorMessage = errorMessage & Environment.NewLine & "First name"
            End If
            If LastnameCorrect = False Then
                errorMessage = errorMessage & Environment.NewLine & "Last name"
            End If
            If AddressCorrect = False Then
                errorMessage = errorMessage & Environment.NewLine & "Address"
            End If
            If PhoneCorrect = False Then
                errorMessage = errorMessage & Environment.NewLine & "Phone number"
            End If
            MsgBox(errorMessage)
            Return
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
            If Not Char.IsLetter(StringToCheck.Chars(i)) And Not Char.IsWhiteSpace(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next
        Return True
    End Function

End Class