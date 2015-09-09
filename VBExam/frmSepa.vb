Public Class frmSepa

    '**************************************************************************************************************************'
    'This program adds information to the database in the bin/debug folder, not the one visual studios uses to test the program'
    '**************************************************************************************************************************'

    Dim acceptable As Boolean = True

    Private Sub frmSepa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblSepaTableAdapter.Fill(Me.VBExamDBDataSet.tblSepa)
        gpbPayees.Visible = False
        'Set the minimum date to the current one so a past date cant be entered
        dtpDate.MinDate = Date.Today
    End Sub

    'If the "Account Transfer" button is checked, clear the fields, set the insert type, show the appropriate fields and vice versa
    Private Sub rdoAccountTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAccountTransfer.CheckedChanged
        BoxClear()
        If rdoAccountTransfer.Checked = True Then
            gpbAccountTransfer.Visible = True
            gpbPayees.Visible = False
        Else
            gpbAccountTransfer.Visible = False
            gpbPayees.Visible = True
        End If
    End Sub

    'Method is to clear the fields inside and out of the group boxes
    Private Sub BoxClear()
        For Each gpCtrl As Control In Me.Controls
            If TypeOf gpCtrl Is GroupBox Then
                For Each ctrl As Control In gpCtrl.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                        ctrl.Text = ""
                    End If
                Next
            End If
        Next
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    'This method checks to see if the inputed data is valid
    Private Sub CheckInput()
        'If the "Account Transfer" button is checked then...
        acceptable = True
        If rdoAccountTransfer.Checked Then
            'See if the "To" or "From" fields are and error if either are
            If cboATFrom.Text = "" Or cboATTo.Text = "" Then
                MessageBox.Show("Both of the 'To' and 'From' fields must be filled", "Error")
                acceptable = False
                Return
            End If
            'See if the "To" and "From" fields are different and error if otherwise
            If cboATFrom.Text = cboATTo.Text Then
                MessageBox.Show("The 'To' and 'From' fields cannot be the same", "Error")
                acceptable = False
                Return
            End If
            'If the "Payee" button is checked then...
        Else
            'See if the "From", "Name", "BIC" or "IBAN" fields are empty and error if any are
            If cboPFrom.Text = "" Or txtPName.Text = "" Or txtPBIC.Text = "" Or txtPIBAN.Text = "" Then
                MessageBox.Show("All the fields must be filled", "Error")
                acceptable = False
                Return
            End If
        End If

        'Check if the data entered into "Amount" is a number and, if so, round the value to 2 decimal places
        Dim dbl As Double
        If Double.TryParse(txtAmount.Text, dbl) Then
            txtAmount.Text = String.Format("{0:n2}", dbl)
        Else
            If Not IsNumeric(txtAmount.Text) Then
                MessageBox.Show("Only enter numbers into the 'Amount' field")
                acceptable = False
                Return
            End If
        End If

        'Check if the BIC is contained in the IBAN
        If Not txtPIBAN.Text.Contains(txtPBIC.Text) Then
            MessageBox.Show("The IBAN must contain the BIC", "Error")
            acceptable = False
            Return
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check the input fields. If the boolean "acceptable" is set to False then do not continue
        CheckInput()
        If acceptable = False Then
            Return
        End If

        'See if the insert type is for an "Account Transfer" or "Payees" and use the according insert
        If rdoAccountTransfer.Checked Then
            Me.TblSepaTableAdapter.InsertAccountTransfer(dtpDate.Value.Date, Decimal.Parse(txtAmount.Text), cboATFrom.Text, cboATTo.Text, txtReference.Text)
        Else
            Me.TblSepaTableAdapter.InsertPayees(txtPName.Text, dtpDate.Value.Date, Decimal.Parse(txtAmount.Text), txtPBIC.Text, txtPIBAN.Text, cboPFrom.Text, txtReference.Text)
        End If
        'Save and update all information
        Me.TblSepaTableAdapter.Fill(Me.VBExamDBDataSet.tblSepa)
        Me.Validate()
        Me.TblSepaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBExamDBDataSet)
        MessageBox.Show("Transaction successful")
    End Sub

    'Give the user a check to see if they really want to clear all fields
    Private Sub btnCancal_Click(sender As Object, e As EventArgs) Handles btnCancal.Click
        If MessageBox.Show("Are you sure you want to cancel?", "Clearing Fields", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            BoxClear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class