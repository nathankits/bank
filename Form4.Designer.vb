<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sndMoney
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
        Me.accntNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amountToSend = New System.Windows.Forms.TextBox()
        Me.confirmSend = New System.Windows.Forms.Button()
        Me.crrntBalance = New System.Windows.Forms.TextBox()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bankName
        '
        Me.bankName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bankName.AutoSize = True
        Me.bankName.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankName.Location = New System.Drawing.Point(49, 35)
        Me.bankName.Name = "bankName"
        Me.bankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bankName.Size = New System.Drawing.Size(275, 28)
        Me.bankName.TabIndex = 9
        Me.bankName.Text = "Bank of the Philippines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Current Balance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Account Number:"
        '
        'accntNumber
        '
        Me.accntNumber.Location = New System.Drawing.Point(166, 169)
        Me.accntNumber.Name = "accntNumber"
        Me.accntNumber.Size = New System.Drawing.Size(144, 23)
        Me.accntNumber.TabIndex = 13
        Me.accntNumber.Text = "0000000002"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Amount:"
        '
        'amountToSend
        '
        Me.amountToSend.Location = New System.Drawing.Point(166, 206)
        Me.amountToSend.Name = "amountToSend"
        Me.amountToSend.Size = New System.Drawing.Size(100, 23)
        Me.amountToSend.TabIndex = 15
        '
        'confirmSend
        '
        Me.confirmSend.Location = New System.Drawing.Point(166, 251)
        Me.confirmSend.Name = "confirmSend"
        Me.confirmSend.Size = New System.Drawing.Size(100, 40)
        Me.confirmSend.TabIndex = 16
        Me.confirmSend.Text = "Confirm"
        Me.confirmSend.UseVisualStyleBackColor = True
        '
        'crrntBalance
        '
        Me.crrntBalance.Location = New System.Drawing.Point(166, 134)
        Me.crrntBalance.Name = "crrntBalance"
        Me.crrntBalance.Size = New System.Drawing.Size(100, 23)
        Me.crrntBalance.TabIndex = 17
        '
        'closeForm
        '
        Me.closeForm.Location = New System.Drawing.Point(166, 297)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(100, 40)
        Me.closeForm.TabIndex = 18
        Me.closeForm.Text = "Close"
        Me.closeForm.UseVisualStyleBackColor = True
        '
        'sndMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 424)
        Me.Controls.Add(Me.closeForm)
        Me.Controls.Add(Me.crrntBalance)
        Me.Controls.Add(Me.confirmSend)
        Me.Controls.Add(Me.amountToSend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.accntNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bankName)
        Me.Name = "sndMoney"
        Me.Text = "Send Money"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bankName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents accntNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents amountToSend As TextBox
    Friend WithEvents confirmSend As Button
    Friend WithEvents crrntBalance As TextBox
    Friend WithEvents closeForm As Button
End Class
