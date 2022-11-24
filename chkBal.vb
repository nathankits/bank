Public Class chkBal
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Me.Close()
    End Sub

    Private Sub accntNumber_TextChanged(sender As Object, e As EventArgs) Handles accntNumber.TextChanged
        Dim accountNumber As Integer = Val(accntNumber.Text)
        accntNumber.ReadOnly = True
        accntNumber.Text = deposit.accntNumber.Text
    End Sub

    Private Sub chkBal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currntBalance As Double = Val(crrntBalance.Text)
        crrntBalance.Text = My.Settings.amount
        crrntBalance.ReadOnly = True

        Dim transactionType As String = "Balance Inquiry"
        Dim transactionAccount As String = accntNumber.Text
        Dim transactionAmount As String = crrntBalance.Text
        Dim transactionDate As String = Date.Now
        Dim transactionBalance As Double = My.Settings.amount

        Dim transactionHistory As String = "|    " & transactionType & "        |         " & transactionAccount & "            |     " & transactionAmount & "     |     " & transactionDate & "     |     " & transactionBalance & "     |" & vbCrLf
        My.Computer.FileSystem.WriteAllText("C:\Users\Public\Documents\TransactionHistory.txt", transactionHistory, True)

    End Sub
End Class