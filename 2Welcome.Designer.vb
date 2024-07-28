<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.btnGo = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblSubheading = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGo.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(589, 427)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(119, 59)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(290, 160)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(394, 257)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 9
        Me.pbxLogo.TabStop = False
        '
        'lblHome
        '
        Me.lblHome.Font = New System.Drawing.Font("Corbel Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(266, 435)
        Me.lblHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(306, 43)
        Me.lblHome.TabIndex = 8
        Me.lblHome.Text = "Go to the Home Screen:"
        '
        'lblSubheading
        '
        Me.lblSubheading.Font = New System.Drawing.Font("Corbel Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheading.Location = New System.Drawing.Point(137, 98)
        Me.lblSubheading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(701, 59)
        Me.lblSubheading.TabIndex = 7
        Me.lblSubheading.Text = "Sentinel Studios is a Central Sydney-based auditorium. We pride ourselves with re" &
    "verberating, spacious, and beautiful concert hall that top class musicians hope " &
    "to perform at."
        Me.lblSubheading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(209, 38)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(557, 45)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Sentinel Studio's Booking System"
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(25, 469)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(110, 59)
        Me.btnEnd.TabIndex = 24
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.lblSubheading)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lblHome As Label
    Friend WithEvents lblSubheading As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnEnd As Button
End Class
