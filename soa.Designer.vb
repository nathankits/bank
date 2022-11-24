<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FileSystemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.history1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FileSystemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemBindingSource1
        '
        Me.FileSystemBindingSource1.DataSource = GetType(Microsoft.VisualBasic.FileSystem)
        '
        'FileSystemBindingSource
        '
        Me.FileSystemBindingSource.DataSource = GetType(Microsoft.VisualBasic.FileSystem)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.history1})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'history1
        '
        Me.history1.HeaderText = "History"
        Me.history1.Name = "history1"
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "history"
        Me.Text = "Statement of Account"
        CType(Me.FileSystemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileSystemBindingSource1 As BindingSource
    Friend WithEvents FileSystemBindingSource As BindingSource

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim transactionHistory As String = My.Computer.FileSystem.ReadAllText("C:\Users\Public\Documents\transactionHistory.txt")
        DataGridView1.Rows.Add(transactionHistory)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents history1 As DataGridViewTextBoxColumn
End Class
