<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chkBal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chkBal))
        Me.bankName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.crrntBalance = New System.Windows.Forms.TextBox()
        Me.accntNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bankName
        '
        Me.bankName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bankName.AutoSize = True
        Me.bankName.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankName.Location = New System.Drawing.Point(42, 32)
        Me.bankName.Name = "bankName"
        Me.bankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bankName.Size = New System.Drawing.Size(275, 28)
        Me.bankName.TabIndex = 8
        Me.bankName.Text = "Bank of the Philippines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Account Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Current Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name:"
        '
        'confirm
        '
        Me.confirm.Location = New System.Drawing.Point(127, 378)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(125, 39)
        Me.confirm.TabIndex = 15
        Me.confirm.Text = "Confirm"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(102, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'crrntBalance
        '
        Me.crrntBalance.Location = New System.Drawing.Point(150, 330)
        Me.crrntBalance.Name = "crrntBalance"
        Me.crrntBalance.Size = New System.Drawing.Size(100, 23)
        Me.crrntBalance.TabIndex = 21
        '
        'accntNumber
        '
        Me.accntNumber.Location = New System.Drawing.Point(150, 291)
        Me.accntNumber.Name = "accntNumber"
        Me.accntNumber.Size = New System.Drawing.Size(144, 23)
        Me.accntNumber.TabIndex = 22
        Me.accntNumber.Text = "0000000001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nathaniel A. Quitua"
        '
        'chkBal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 448)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.accntNumber)
        Me.Controls.Add(Me.crrntBalance)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bankName)
        Me.Name = "chkBal"
        Me.Text = "Balance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bankName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents confirm As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents crrntBalance As TextBox
    Friend WithEvents accntNumber As TextBox
    Friend WithEvents Label2 As Label
End Class
