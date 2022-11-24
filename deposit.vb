Public Class deposit

    Dim newBalance As Double
    Private Sub confirmDeposit_Click(sender As Object, e As EventArgs) Handles confirmDeposit.Click
        Dim depositAmount As Double = Val(amount.Text)
        Dim currentBalance As Double
        Dim accountNumber As Integer = Val(accntNumber.Text)

        crrntBalance.ReadOnly = True

        If amount.Text <= "" & 0 Then
            MsgBox("Please enter an amount to deposit", MsgBoxStyle.Exclamation)
        ElseIf accntNumber.Text <= "" & 0 Then
            MsgBox("Please enter your account number", MsgBoxStyle.Exclamation)
        Else
            currentBalance = Val(crrntBalance.Text)
            newBalance = currentBalance + depositAmount
            crrntBalance.Text = newBalance
            My.Settings.amount = newBalance
            My.Settings.Save()
        End If

        Dim transactionType As String = "Deposit"
        Dim transactionAccount As String = accntNumber.Text
        Dim transactionAmount As String = amount.Text
        Dim transactionDate As String = Date.Now
        Dim transactionBalance As Double = My.Settings.amount

        Dim transactionHistory As String = "|      " & transactionType & "                    |         " & transactionAccount & "           |     " & transactionAmount & "     |     " & transactionDate & "     |     " & transactionBalance & "     |" & vbCrLf

        My.Computer.FileSystem.WriteAllText("C:\Users\Public\Documents\TransactionHistory.txt", transactionHistory, True)

        amount.Text = ""

    End Sub

    Private Sub amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles amount.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter a Valid Amount", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub accntNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles accntNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Enter a Valid Account Number", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Me.Close()
    End Sub

    Private Sub deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crrntBalance.Text = My.Settings.amount
        crrntBalance.ReadOnly = True
    End Sub
End Class