Imports System.IO
Imports System.Math

Public Class frmPrime

    Private Function CheckInput()
        If txtMin.Text = "" Or txtMax.Text = "" Then
            MessageBox.Show("Enter numbers into both fields")
            Return False
        End If
        If Not IsNumeric(txtMin.Text) Or Not IsNumeric(txtMax.Text) Then
            MessageBox.Show("Only enter numbers into the fields")
            Return False
        End If
        If txtMin.Text < 1 Then
            MessageBox.Show("Enter a larger number than 0 in the minimum field")
            Return False
        End If
        If Integer.Parse(txtMin.Text) >= Integer.Parse(txtMax.Text) Then
            MessageBox.Show("Make sure the Minimum is less than the Maximum")
            Return False
        End If
        Return True
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If CheckInput() Then
            Dim min As Integer = Integer.Parse(txtMin.Text)
            Dim max As Integer = Integer.Parse(txtMax.Text)
            Dim prime As Boolean
            Dim stringOfPrime As String = ""
            txtDisplay.Clear()

            If min = 1 Or min = 2 Then
                stringOfPrime = "2 "
            End If

            If min Mod 2 = 0 Then
                min = min + 1
            End If

            If min = 1 Then
                min = min + 2
            End If

            For current As Integer = min To max Step 2
                prime = True
                For i As Integer = 2 To Sqrt(current)
                    If current Mod i = 0 Then
                        prime = False
                        Exit For
                    End If
                Next
                If prime Then
                    stringOfPrime = stringOfPrime & current & " "
                End If
            Next
            txtDisplay.Text = stringOfPrime.Substring(0, stringOfPrime.Length - 1)
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If txtDisplay.Text <> "" Then
            Dim fileLoc As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            fileLoc = fileLoc & "\Test.txt"
            If File.Exists(fileLoc) Then
                File.Delete(fileLoc)
            End If

            Dim sw As StreamWriter = New StreamWriter(fileLoc)
            sw.Write(txtDisplay.Text)
            sw.Close()
        Else
            MessageBox.Show("Make sure there is a calculation to report")
            Return
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
