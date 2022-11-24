Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sndMoney.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        chkBal.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        wthdrwForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        history.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        deposit.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        My.Computer.FileSystem.DeleteFile("C:\Users\Public\Documents\TransactionHistory.txt")
    End Sub

    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        My.Computer.FileSystem.DeleteFile("C:\Users\Public\Documents\TransactionHistory.txt")
    End Sub
End Class