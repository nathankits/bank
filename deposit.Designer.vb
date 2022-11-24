<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deposit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bankName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accntNumber = New System.Windows.Forms.TextBox()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.confirmDeposit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crrntBalance = New System.Windows.Forms.TextBox()
        Me.confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bankName
        '
        Me.bankName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bankName.AutoSize = True
        Me.bankName.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankName.Location = New System.Drawing.Point(61, 44)
        Me.bankName.Name = "bankName"
        Me.bankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bankName.Size = New System.Drawing.Size(275, 28)
        Me.bankName.TabIndex = 10
        Me.bankName.Text = "Bank of the Philippines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Account Number:"
        '
        'accntNumber
        '
        Me.accntNumber.Location = New System.Drawing.Point(169, 148)
        Me.accntNumber.Name = "accntNumber"
        Me.accntNumber.Size = New System.Drawing.Size(144, 23)
        Me.accntNumber.TabIndex = 14
        Me.accntNumber.Text = "0000000001"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(169, 184)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(100, 23)
        Me.amount.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount:"
        '
        'confirmDeposit
        '
        Me.confirmDeposit.Location = New System.Drawing.Point(95, 213)
        Me.confirmDeposit.Name = "confirmDeposit"
        Me.confirmDeposit.Size = New System.Drawing.Size(100, 32)
        Me.confirmDeposit.TabIndex = 18
        Me.confirmDeposit.Text = "Confirm"
        Me.confirmDeposit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Current Balance:"
        '
        'crrntBalance
        '
        Me.crrntBalance.Location = New System.Drawing.Point(169, 110)
        Me.crrntBalance.Name = "crrntBalance"
        Me.crrntBalance.Size = New System.Drawing.Size(100, 23)
        Me.crrntBalance.TabIndex = 20
        Me.crrntBalance.Text = "0"
        '
        'confirm
        '
        Me.confirm.Location = New System.Drawing.Point(213, 213)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(100, 32)
        Me.confirm.TabIndex = 22
        Me.confirm.Text = "Back"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 307)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.crrntBalance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.confirmDeposit)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.accntNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bankName)
        Me.Name = "deposit"
        Me.Text = "Deposit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bankName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents accntNumber As TextBox
    Friend WithEvents amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents confirmDeposit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents crrntBalance As TextBox
    Friend WithEvents confirm As Button
End Class
