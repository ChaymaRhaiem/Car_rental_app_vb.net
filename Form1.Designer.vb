<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picturebox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.signup = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 203)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(140, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 51)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "WELCOME"
        '
        'picturebox2
        '
        Me.picturebox2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.coloneb
        Me.picturebox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picturebox2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.picturebox2.Location = New System.Drawing.Point(135, 256)
        Me.picturebox2.Name = "picturebox2"
        Me.picturebox2.Size = New System.Drawing.Size(224, 42)
        Me.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picturebox2.TabIndex = 10
        Me.picturebox2.TabStop = False
        Me.picturebox2.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.coloneb
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox1.Location = New System.Drawing.Point(135, 332)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(151, 265)
        Me.username.Multiline = True
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(192, 24)
        Me.username.TabIndex = 12
        Me.username.Text = "Enter username"
        Me.username.UseWaitCursor = True
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.Location = New System.Drawing.Point(151, 342)
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(192, 24)
        Me.password.TabIndex = 13
        Me.password.Text = "Enter password"
        Me.password.UseWaitCursor = True
        '
        'signup
        '
        Me.signup.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.signup.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.signup.Location = New System.Drawing.Point(126, 530)
        Me.signup.Name = "signup"
        Me.signup.Size = New System.Drawing.Size(233, 36)
        Me.signup.TabIndex = 14
        Me.signup.Text = "signup"
        Me.signup.UseVisualStyleBackColor = False
        Me.signup.UseWaitCursor = True
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.coloneb
        Me.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.login.FlatAppearance.BorderSize = 0
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.login.Location = New System.Drawing.Point(210, 398)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(74, 29)
        Me.login.TabIndex = 15
        Me.login.Text = "login"
        Me.login.UseVisualStyleBackColor = False
        Me.login.UseWaitCursor = True
        '
        'cancel
        '
        Me.cancel.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Location = New System.Drawing.Point(219, 456)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(65, 23)
        Me.cancel.TabIndex = 28
        Me.cancel.UseVisualStyleBackColor = True
        Me.cancel.UseWaitCursor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._2_2
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(104, 258)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 40)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._3_3
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(104, 332)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(21, 40)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(485, 578)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.signup)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picturebox2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents picturebox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents signup As Button
    Friend WithEvents login As Button
    Friend WithEvents cancel As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
