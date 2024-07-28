<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pbxPass = New System.Windows.Forms.PictureBox()
        Me.pbxUser = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSortInfo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCreate
        '
        Me.lblCreate.Font = New System.Drawing.Font("Corbel Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.Location = New System.Drawing.Point(217, 181)
        Me.lblCreate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(184, 43)
        Me.lblCreate.TabIndex = 25
        Me.lblCreate.Text = "Create Login:"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(441, 178)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(118, 49)
        Me.btnCreate.TabIndex = 22
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(24, 471)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(110, 59)
        Me.btnEnd.TabIndex = 23
        Me.btnEnd.Text = "END"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 33)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Enter Password:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Corbel Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(12, 24)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(218, 38)
        Me.lblUser.TabIndex = 29
        Me.lblUser.Text = "Enter Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Corbel Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(236, 23)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 40)
        Me.txtUsername.TabIndex = 30
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Corbel Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(236, 77)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 40)
        Me.txtPassword.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Login Here:"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(236, 128)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(250, 42)
        Me.btnLogin.TabIndex = 33
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pbxPass
        '
        Me.pbxPass.Image = CType(resources.GetObject("pbxPass.Image"), System.Drawing.Image)
        Me.pbxPass.Location = New System.Drawing.Point(502, 77)
        Me.pbxPass.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxPass.Name = "pbxPass"
        Me.pbxPass.Size = New System.Drawing.Size(49, 40)
        Me.pbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPass.TabIndex = 35
        Me.pbxPass.TabStop = False
        '
        'pbxUser
        '
        Me.pbxUser.Image = CType(resources.GetObject("pbxUser.Image"), System.Drawing.Image)
        Me.pbxUser.Location = New System.Drawing.Point(502, 23)
        Me.pbxUser.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxUser.Name = "pbxUser"
        Me.pbxUser.Size = New System.Drawing.Size(51, 40)
        Me.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUser.TabIndex = 34
        Me.pbxUser.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(217, 52)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(557, 45)
        Me.lblTitle.TabIndex = 36
        Me.lblTitle.Text = "Sentinel Studio's Booking System"
        '
        'lblSortInfo
        '
        Me.lblSortInfo.AutoSize = True
        Me.lblSortInfo.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSortInfo.Location = New System.Drawing.Point(258, 106)
        Me.lblSortInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSortInfo.Name = "lblSortInfo"
        Me.lblSortInfo.Size = New System.Drawing.Size(475, 18)
        Me.lblSortInfo.TabIndex = 66
        Me.lblSortInfo.Text = "Login to the booking system by entering your username and password below"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbxPass)
        Me.GroupBox1.Controls.Add(Me.pbxUser)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.lblUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(205, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 196)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(959, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSortInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnEnd)
        Me.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCreate As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents pbxPass As PictureBox
    Friend WithEvents pbxUser As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSortInfo As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
