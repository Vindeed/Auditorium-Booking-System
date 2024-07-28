<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Input))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.btnSeatPlan = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubheading = New System.Windows.Forms.Label()
        Me.nudPhone = New System.Windows.Forms.NumericUpDown()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.nudPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(328, 45)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(324, 45)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Add New Bookings"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(28, 28)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(124, 29)
        Me.lblFName.TabIndex = 9
        Me.lblFName.Text = "First Name:"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(28, 87)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(122, 29)
        Me.lblLName.TabIndex = 10
        Me.lblLName.Text = "Last Name:"
        '
        'btnSeatPlan
        '
        Me.btnSeatPlan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSeatPlan.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeatPlan.Location = New System.Drawing.Point(785, 474)
        Me.btnSeatPlan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeatPlan.Name = "btnSeatPlan"
        Me.btnSeatPlan.Size = New System.Drawing.Size(151, 59)
        Me.btnSeatPlan.TabIndex = 26
        Me.btnSeatPlan.Text = "CHOOSE SEATS"
        Me.btnSeatPlan.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(22, 474)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(119, 59)
        Me.btnEnd.TabIndex = 27
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(28, 146)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(142, 29)
        Me.lblDOB.TabIndex = 28
        Me.lblDOB.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 29)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Phone Number:"
        '
        'lblSubheading
        '
        Me.lblSubheading.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheading.Location = New System.Drawing.Point(60, 110)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(861, 48)
        Me.lblSubheading.TabIndex = 30
        Me.lblSubheading.Text = "Input the information required in the fields below pertaining to the client compl" &
    "eting the booking."
        '
        'nudPhone
        '
        Me.nudPhone.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPhone.Location = New System.Drawing.Point(222, 201)
        Me.nudPhone.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudPhone.Minimum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudPhone.Name = "nudPhone"
        Me.nudPhone.Size = New System.Drawing.Size(250, 37)
        Me.nudPhone.TabIndex = 32
        Me.nudPhone.Value = New Decimal(New Integer() {1000000000, 0, 0, 0})
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(222, 24)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(250, 37)
        Me.txtFName.TabIndex = 33
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(222, 83)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(250, 37)
        Me.txtLName.TabIndex = 34
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MM/yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(222, 142)
        Me.dtpDOB.MaxDate = New Date(2022, 4, 15, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(250, 37)
        Me.dtpDOB.TabIndex = 35
        Me.dtpDOB.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Pink
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(22, 20)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(119, 59)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.nudPhone)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.lblLName)
        Me.GroupBox1.Controls.Add(Me.lblFName)
        Me.GroupBox1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(222, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 270)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Details"
        '
        'Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSubheading)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSeatPlan)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input"
        CType(Me.nudPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents btnSeatPlan As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblDOB As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubheading As Label
    Friend WithEvents nudPhone As NumericUpDown
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
