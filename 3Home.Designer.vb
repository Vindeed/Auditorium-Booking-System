<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblGoTo = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(192, 38)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(557, 45)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Sentinel Studio's Booking System"
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSort.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(38, 391)
        Me.btnSort.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(119, 59)
        Me.btnSort.TabIndex = 12
        Me.btnSort.Text = "SORT BOOKINGS"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'lblGoTo
        '
        Me.lblGoTo.AutoSize = True
        Me.lblGoTo.Font = New System.Drawing.Font("Corbel Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoTo.Location = New System.Drawing.Point(67, 81)
        Me.lblGoTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoTo.Name = "lblGoTo"
        Me.lblGoTo.Size = New System.Drawing.Size(64, 26)
        Me.lblGoTo.TabIndex = 13
        Me.lblGoTo.Text = "Go to:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(38, 321)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 59)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "SEARCH BOOKINGS"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(38, 251)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 59)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "DELETE BOOKING"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInput.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(38, 111)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(119, 59)
        Me.btnInput.TabIndex = 9
        Me.btnInput.Text = "ADD BOOKING"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(38, 468)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(119, 59)
        Me.btnEnd.TabIndex = 25
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(192, 111)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(686, 341)
        Me.lblInfo.TabIndex = 27
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(38, 181)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(119, 59)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "UPDATE BOOKING"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Gray
        Me.btnHelp.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHelp.Location = New System.Drawing.Point(806, 468)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(119, 59)
        Me.btnHelp.TabIndex = 28
        Me.btnHelp.Text = "HELP"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lblGoTo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents lblGoTo As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHelp As Button
End Class
