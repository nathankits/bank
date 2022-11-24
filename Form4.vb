Imports System.Data.OleDb

Public Class sndMoney

    Dim amount As Double
    Private Sub sndMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crrntBalance.Text = My.Settings.amount
        crrntBalance.ReadOnly = True
    End Sub

    Private Sub amountToSend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles amountToSend.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter a Valid Amount", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub confirmSend_Click(sender As Object, e As EventArgs) Handles confirmSend.Click


        If amountToSend.Text <= "" Then
            MsgBox("Please enter an amount to send", MsgBoxStyle.Exclamation)
        ElseIf accntNumber.Text <= "" & 0 Then
            MsgBox("Please Enter a valid Account Number", MsgBoxStyle.Exclamation)
        Else
            My.Settings.amount = My.Settings.amount - Val(amountToSend.Text)
            My.Settings.Save()
            MsgBox("Money Sent", MsgBoxStyle.Information)
            crrntBalance.Text = My.Settings.amount

        End If

        'Create a transaction history and type of transaction and add it to the txt file'

        Dim transactionType As String = "Send Money"
        Dim transactionAccount As String = accntNumber.Text
        Dim transactionAmount As String = amountToSend.Text
        Dim transactionDate As String = Date.Now
        Dim transactionBalance As Double = My.Settings.amount

        Dim transactionHistory As String = "|      " & transactionType & "           |         " & transactionAccount & "            |     " & transactionAmount & "     |     " & transactionDate & "     |     " & transactionBalance & "     |" & vbCrLf
        'Dim transaction As String = "Transaction Type: " & transactionType & vbCrLf & "Transaction Amount: " & amountToSend.Text & vbCrLf & "Account Number: " & transactionAccount & vbCrLf & "Date: " & transactionDate & vbCrLf & "Remaining Balance: " & transactionBalance & vbCrLf & vbCrLf & vbCrLf'

        My.Computer.FileSystem.WriteAllText("C:\Users\Public\Documents\TransactionHistory.txt", transactionHistory, True)
        amountToSend.Text = ""



    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Close()
    End Sub
End Class