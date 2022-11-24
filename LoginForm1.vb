Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "admin" Then
            Form1.Show()
            Me.Close()
        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Exclamation)
        End If

        Dim txtFile As String = "|     " & "Transaction Type" & "     |     " & "Account Number" & "     |     " & "Transaction Amount" & "     |     " & "Transaction Date" & "     |     " & "Remaining Balance" & "     |" & vbCrLf
        My.Computer.FileSystem.WriteAllText("C:\Users\Public\Documents\TransactionHistory.txt", txtFile, True)

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class