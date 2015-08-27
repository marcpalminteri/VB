Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmTrainees

    Dim connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\Users\blue2.FASFG\Documents\vsprojects\VB\projTrainees\Bin\Debug\TraineesDB.mdf;Integrated Security=True"
    Dim sqlCon As SqlConnection = New SqlConnection(connectionString)
    Dim dataTbl As New DataTable
    Dim size As Integer = 0
    Dim current As Integer = 0
    Dim acceptable As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableInput()
        DatabaseConnection()
        DisplayInfo(current)
    End Sub

    Private Sub DisableInput()
        Try
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RadioButton Or TypeOf ctrl Is DateTimePicker Then
                    ctrl.Enabled = False
                Else
                    ctrl.Enabled = True
                End If
            Next

        Catch ex As Exception
            MsgBox("Cannot disable input")
        End Try
    End Sub

    Private Sub EnableInput()
        Try
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RadioButton Or TypeOf ctrl Is DateTimePicker Then
                    ctrl.Enabled = True
                End If
            Next

        Catch ex As Exception
            MsgBox("Cannot enable input")
        End Try
    End Sub

    Private Sub CheckInput()
        Dim FirstnameCorrect As Boolean = True
        Dim LastnameCorrect As Boolean = True
        Dim AddressCorrect As Boolean = True
        Dim PhoneCorrect As Boolean = True
        Dim strOutput As String = ""

        If txtFirstname.Text <> "" Then
            If CheckForAlphaCharacters(txtFirstname.Text) Then
                FirstnameCorrect = True
            Else
                MsgBox("Only enter characters in the 'First Name' field")
                acceptable = False
                Return
            End If
        Else
            FirstnameCorrect = False
        End If

        If txtLastname.Text <> "" Then
            If CheckForAlphaCharacters(txtLastname.Text) Then
                LastnameCorrect = True
            Else
                MsgBox("Only enter characters into the 'Last Name' field")
                acceptable = False
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
            acceptable = False
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
            If errorMessage <> "" Then
                MsgBox(errorMessage)
                acceptable = False
            End If
        End If

    End Sub

    Private Sub DatabaseConnection()
        Try
            sqlCon.Open()
            Dim dataAd As New SqlDataAdapter("Select * from tblTrainees", sqlCon)
            dataAd.Fill(dataTbl)
            size = dataTbl.Rows.Count

        Catch ex As Exception
            MsgBox("Database Error")
        End Try
    End Sub

    Private Sub DisplayInfo(index As Integer)
        Try
            Dim gen As String = String.Empty
            gen = dataTbl.Rows(index)("gender")
            If gen = "m" Then
                rdoMale.Checked = True
            Else
                rdoFemale.Checked = True
            End If

            txtFirstname.Text = dataTbl.Rows(index)("firstName")
            txtLastname.Text = dataTbl.Rows(index)("lastName")
            dtpDateOfBirth.Text = dataTbl.Rows(index)("dateOfBirth")
            cboNationality.Text = dataTbl.Rows(index)("nationality")
            cboBirthCountry.Text = dataTbl.Rows(index)("country")
            If cboBirthCountry.Text = "Ireland" Then
                cboBirthCounty.Text = dataTbl.Rows(index)("county")
            End If
            txtAddress1.Text = dataTbl.Rows(index)("addressLine1")
            If Len(dataTbl.Rows(index)("addressLine2").ToString()) > 0 Then
                txtAddress2.Text = dataTbl.Rows(index)("AddressLine2").ToString()
            Else
                txtAddress2.Clear()
            End If
            cboAddress.Text = dataTbl.Rows(index)("addressLine3")
            txtPhone.Text = dataTbl.Rows(index)("phoneNumber")
            txtEmail.Text = dataTbl.Rows(index)("email")
            If Len(dataTbl.Rows(index)("notes").ToString()) > 0 Then
                txtNotes.Text = dataTbl.Rows(index)("notes").ToString()
            Else
                txtNotes.Clear()
            End If

        Catch ex As Exception
            MsgBox("Cannot display info")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If sqlCon.State = ConnectionState.Open Then
            sqlCon.Close()
        End If
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

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        current = 0
        DisplayInfo(current)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If current < (size - 1) Then
            current = current + 1
            DisplayInfo(current)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If current > 0 Then
            current = current - 1
            DisplayInfo(current)
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        current = size - 1
        DisplayInfo(current)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableInput()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EnableInput()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CheckInput()
        If acceptable = True Then
            DisableInput()
        Else
            acceptable = True
        End If
    End Sub
End Class