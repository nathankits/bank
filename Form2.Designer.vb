<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wthdrwForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.withdrawAmount = New System.Windows.Forms.TextBox()
        Me.confirmWithdraw = New System.Windows.Forms.Button()
        Me.crrntBalance = New System.Windows.Forms.TextBox()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bankName
        '
        Me.bankName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bankName.AutoSize = True
        Me.bankName.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankName.Location = New System.Drawing.Point(26, 35)
        Me.bankName.Name = "bankName"
        Me.bankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bankName.Size = New System.Drawing.Size(275, 28)
        Me.bankName.TabIndex = 9
        Me.bankName.Text = "Bank of the Philippines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Current Balance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Amount:"
        '
        'withdrawAmount
        '
        Me.withdrawAmount.Location = New System.Drawing.Point(136, 172)
        Me.withdrawAmount.Name = "withdrawAmount"
        Me.withdrawAmount.Size = New System.Drawing.Size(100, 23)
        Me.withdrawAmount.TabIndex = 12
        '
        'confirmWithdraw
        '
        Me.confirmWithdraw.Location = New System.Drawing.Point(136, 210)
        Me.confirmWithdraw.Name = "confirmWithdraw"
        Me.confirmWithdraw.Size = New System.Drawing.Size(100, 40)
        Me.confirmWithdraw.TabIndex = 13
        Me.confirmWithdraw.Text = "Confirm"
        Me.confirmWithdraw.UseVisualStyleBackColor = True
        '
        'crrntBalance
        '
        Me.crrntBalance.Location = New System.Drawing.Point(136, 137)
        Me.crrntBalance.Name = "crrntBalance"
        Me.crrntBalance.Size = New System.Drawing.Size(100, 23)
        Me.crrntBalance.TabIndex = 14
        '
        'closeForm
        '
        Me.closeForm.Location = New System.Drawing.Point(223, 269)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(100, 40)
        Me.closeForm.TabIndex = 19
        Me.closeForm.Text = "Close"
        Me.closeForm.UseVisualStyleBackColor = True
        '
        'wthdrwForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 403)
        Me.Controls.Add(Me.closeForm)
        Me.Controls.Add(Me.crrntBalance)
        Me.Controls.Add(Me.confirmWithdraw)
        Me.Controls.Add(Me.withdrawAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bankName)
        Me.Name = "wthdrwForm"
        Me.Text = "Withdraw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bankName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents withdrawAmount As TextBox
    Friend WithEvents confirmWithdraw As Button
    Friend WithEvents crrntBalance As TextBox
    Friend WithEvents closeForm As Button
End Class
