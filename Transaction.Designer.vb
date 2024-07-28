<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPaymentValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.nudCCNumber = New System.Windows.Forms.NumericUpDown()
        Me.nudSecurity = New System.Windows.Forms.NumericUpDown()
        Me.dtpExpiry = New System.Windows.Forms.DateTimePicker()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.nudCCNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Pink
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(15, 22)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(119, 59)
        Me.btnBack.TabIndex = 56
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(15, 474)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(119, 59)
        Me.btnEnd.TabIndex = 55
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(384, 29)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(207, 45)
        Me.lblTitle.TabIndex = 54
        Me.lblTitle.Text = "Transaction"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(375, 93)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(105, 29)
        Me.lblPayment.TabIndex = 57
        Me.lblPayment.Text = "Payment:"
        '
        'lblPaymentValue
        '
        Me.lblPaymentValue.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPaymentValue.Location = New System.Drawing.Point(483, 85)
        Me.lblPaymentValue.Name = "lblPaymentValue"
        Me.lblPaymentValue.Size = New System.Drawing.Size(118, 44)
        Me.lblPaymentValue.TabIndex = 58
        Me.lblPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 29)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Credit Card Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 29)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Security Number:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(316, 78)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(274, 37)
        Me.txtName.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 29)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Expiry Date:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(33, 82)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(196, 29)
        Me.lblName.TabIndex = 64
        Me.lblName.Text = "Card Holder Name:"
        '
        'nudCCNumber
        '
        Me.nudCCNumber.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCCNumber.Location = New System.Drawing.Point(316, 25)
        Me.nudCCNumber.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.nudCCNumber.Minimum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.nudCCNumber.Name = "nudCCNumber"
        Me.nudCCNumber.Size = New System.Drawing.Size(274, 37)
        Me.nudCCNumber.TabIndex = 65
        Me.nudCCNumber.Value = New Decimal(New Integer() {-595961418, 258467, 0, 0})
        '
        'nudSecurity
        '
        Me.nudSecurity.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSecurity.Location = New System.Drawing.Point(316, 130)
        Me.nudSecurity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudSecurity.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudSecurity.Name = "nudSecurity"
        Me.nudSecurity.Size = New System.Drawing.Size(274, 37)
        Me.nudSecurity.TabIndex = 66
        Me.nudSecurity.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'dtpExpiry
        '
        Me.dtpExpiry.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpiry.Location = New System.Drawing.Point(316, 184)
        Me.dtpExpiry.Name = "dtpExpiry"
        Me.dtpExpiry.Size = New System.Drawing.Size(277, 37)
        Me.dtpExpiry.TabIndex = 67
        Me.dtpExpiry.Value = New Date(2022, 5, 12, 10, 22, 33, 0)
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(813, 474)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(119, 59)
        Me.btnConfirm.TabIndex = 68
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpExpiry)
        Me.GroupBox1.Controls.Add(Me.nudSecurity)
        Me.GroupBox1.Controls.Add(Me.nudCCNumber)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(171, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 251)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Transaction Details"
        '
        'Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblPaymentValue)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        CType(Me.nudCCNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblPaymentValue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents nudCCNumber As NumericUpDown
    Friend WithEvents nudSecurity As NumericUpDown
    Friend WithEvents dtpExpiry As DateTimePicker
    Friend WithEvents btnConfirm As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
