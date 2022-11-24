<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bankName
        '
        Me.bankName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bankName.AutoSize = True
        Me.bankName.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankName.Location = New System.Drawing.Point(145, 46)
        Me.bankName.Name = "bankName"
        Me.bankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bankName.Size = New System.Drawing.Size(275, 28)
        Me.bankName.TabIndex = 9
        Me.bankName.Text = "Bank of the Philippines"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Send Money"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(278, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 45)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Statement of Account"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(126, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 45)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Balance Inquiry"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 45)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Withdraw"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(206, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(148, 45)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Deposit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 15
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(237, 324)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 38)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 393)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bankName)
        Me.Name = "Form1"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bankName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
End Class
