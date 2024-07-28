<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pbxSearch = New System.Windows.Forms.PictureBox()
        Me.lblSortInfo = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.FName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxSearch
        '
        Me.pbxSearch.Image = CType(resources.GetObject("pbxSearch.Image"), System.Drawing.Image)
        Me.pbxSearch.Location = New System.Drawing.Point(629, 116)
        Me.pbxSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(40, 38)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxSearch.TabIndex = 44
        Me.pbxSearch.TabStop = False
        '
        'lblSortInfo
        '
        Me.lblSortInfo.AutoSize = True
        Me.lblSortInfo.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSortInfo.Location = New System.Drawing.Point(424, 81)
        Me.lblSortInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSortInfo.Name = "lblSortInfo"
        Me.lblSortInfo.Size = New System.Drawing.Size(126, 14)
        Me.lblSortInfo.TabIndex = 43
        Me.lblSortInfo.Text = "to get Client Information"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(176, 120)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(445, 31)
        Me.txtSearch.TabIndex = 37
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(258, 33)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(458, 45)
        Me.lblTitle.TabIndex = 42
        Me.lblTitle.Text = "Search a First or Last Name"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Pink
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(18, 23)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(110, 59)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(18, 471)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(110, 59)
        Me.btnEnd.TabIndex = 53
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(689, 106)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 59)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvDisplay
        '
        Me.dgvDisplay.AllowUserToAddRows = False
        Me.dgvDisplay.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisplay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FName, Me.LName, Me.DOB, Me.Phone, Me.Payment})
        Me.dgvDisplay.EnableHeadersVisualStyles = False
        Me.dgvDisplay.Location = New System.Drawing.Point(91, 177)
        Me.dgvDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.ReadOnly = True
        Me.dgvDisplay.Size = New System.Drawing.Size(793, 269)
        Me.dgvDisplay.TabIndex = 57
        '
        'FName
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.DefaultCellStyle = DataGridViewCellStyle2
        Me.FName.HeaderText = "First Name"
        Me.FName.Name = "FName"
        Me.FName.ReadOnly = True
        Me.FName.Width = 150
        '
        'LName
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.DefaultCellStyle = DataGridViewCellStyle3
        Me.LName.HeaderText = "Last Name"
        Me.LName.Name = "LName"
        Me.LName.ReadOnly = True
        Me.LName.Width = 150
        '
        'DOB
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.DefaultCellStyle = DataGridViewCellStyle4
        Me.DOB.HeaderText = "Date Of Birth"
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Width = 150
        '
        'Phone
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.DefaultCellStyle = DataGridViewCellStyle5
        Me.Phone.HeaderText = "Phone Number"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Width = 150
        '
        'Payment
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.DefaultCellStyle = DataGridViewCellStyle6
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.ReadOnly = True
        Me.Payment.Width = 150
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.pbxSearch)
        Me.Controls.Add(Me.lblSortInfo)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxSearch As PictureBox
    Friend WithEvents lblSortInfo As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents FName As DataGridViewTextBoxColumn
    Friend WithEvents LName As DataGridViewTextBoxColumn
    Friend WithEvents DOB As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewTextBoxColumn
End Class
