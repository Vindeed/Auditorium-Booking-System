<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delete))
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.nudDelete = New System.Windows.Forms.NumericUpDown()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        CType(Me.nudDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.Location = New System.Drawing.Point(348, 415)
        Me.lblRecord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(153, 26)
        Me.lblRecord.TabIndex = 0
        Me.lblRecord.Text = "Record Number:"
        '
        'nudDelete
        '
        Me.nudDelete.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDelete.Location = New System.Drawing.Point(505, 412)
        Me.nudDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.nudDelete.Name = "nudDelete"
        Me.nudDelete.Size = New System.Drawing.Size(117, 33)
        Me.nudDelete.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(429, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 59)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(347, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(281, 45)
        Me.lblTitle.TabIndex = 53
        Me.lblTitle.Text = "Delete Bookings"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Pink
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(22, 20)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(119, 59)
        Me.btnBack.TabIndex = 55
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(22, 472)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(119, 59)
        Me.btnEnd.TabIndex = 54
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'Payment
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.DefaultCellStyle = DataGridViewCellStyle1
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.ReadOnly = True
        Me.Payment.Width = 150
        '
        'Phone
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.DefaultCellStyle = DataGridViewCellStyle2
        Me.Phone.HeaderText = "Phone Number"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Width = 150
        '
        'DOB
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.DefaultCellStyle = DataGridViewCellStyle3
        Me.DOB.HeaderText = "Date Of Birth"
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Width = 150
        '
        'LName
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.DefaultCellStyle = DataGridViewCellStyle4
        Me.LName.HeaderText = "Last Name"
        Me.LName.Name = "LName"
        Me.LName.ReadOnly = True
        Me.LName.Width = 150
        '
        'FName
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.DefaultCellStyle = DataGridViewCellStyle5
        Me.FName.HeaderText = "First Name"
        Me.FName.Name = "FName"
        Me.FName.ReadOnly = True
        Me.FName.Width = 150
        '
        'dgvDisplay
        '
        Me.dgvDisplay.AllowUserToAddRows = False
        Me.dgvDisplay.AllowUserToDeleteRows = False
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FName, Me.LName, Me.DOB, Me.Phone, Me.Payment})
        Me.dgvDisplay.Location = New System.Drawing.Point(91, 109)
        Me.dgvDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.ReadOnly = True
        Me.dgvDisplay.Size = New System.Drawing.Size(793, 269)
        Me.dgvDisplay.TabIndex = 51
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.nudDelete)
        Me.Controls.Add(Me.lblRecord)
        Me.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete"
        CType(Me.nudDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRecord As Label
    Friend WithEvents nudDelete As NumericUpDown
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents Payment As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents DOB As DataGridViewTextBoxColumn
    Friend WithEvents LName As DataGridViewTextBoxColumn
    Friend WithEvents FName As DataGridViewTextBoxColumn
    Friend WithEvents dgvDisplay As DataGridView
End Class
