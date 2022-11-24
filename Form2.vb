Public Class wthdrwForm
    Private Sub wthdrwForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crrntBalance.ReadOnly = True
        crrntBalance.Text = My.Settings.amount
    End Sub

    Private Sub withdrawAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles withdrawAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter a Valid Amount", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub confirmWithdraw_Click(sender As Object, e As EventArgs) Handles confirmWithdraw.Click
        If withdrawAmount.Text <= "" & 0 Then

            MsgBox("Please enter a valid amount to withdraw", MsgBoxStyle.Exclamation)
            'prevent user from withdrawing more than they have
        Else
            My.Settings.amount = My.Settings.amount - Val(withdrawAmount.Text)
            My.Settings.Save()
            MsgBox("Withdrawal Successful", MsgBoxStyle.Information)
            crrntBalance.Text = My.Settings.amount
        End If

        Dim transactionType As String = "Withdrawal"
        Dim transactionAmount As String = withdrawAmount.Text
        Dim transactionDate As String = Date.Now
        Dim transactionBalance As Double = My.Settings.amount

        Dim transactionHistory As String = "|      " & transactionType & "             |         " & "0000000001" & "            |     " & transactionAmount & "     |     " & transactionDate & "     |     " & transactionBalance & "     |" & vbCrLf
        'Dim transaction As String = "Transaction Type: " & transactionType & vbCrLf & "Transaction Amount: " & amountToSend.Text & vbCrLf & "Account Number: " & transactionAccount & vbCrLf & "Date: " & transactionDate & vbCrLf & "Remaining Balance: " & transactionBalance & vbCrLf & vbCrLf & vbCrLf'

        My.Computer.FileSystem.WriteAllText("C:\Users\Public\Documents\TransactionHistory.txt", transactionHistory, True)

        withdrawAmount.Text = ""

    End Sub

    Private Sub closeForm_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Close()
    End Sub
End Class