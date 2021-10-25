<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultation))
        Me.UserLoginDB = New WindowsApp1.UserLoginDB()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserLoginDB1 = New WindowsApp1.UserLoginDB()
        Me.UserLoginDB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.nomarticle = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.update = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.UserLoginDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLoginDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLoginDB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserLoginDB
        '
        Me.UserLoginDB.DataSetName = "UserLoginDB"
        Me.UserLoginDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.UserLoginDB1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(559, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(302, 315)
        Me.DataGridView1.TabIndex = 0
        '
        'UserLoginDB1
        '
        Me.UserLoginDB1.DataSetName = "UserLoginDB"
        Me.UserLoginDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserLoginDB1BindingSource
        '
        Me.UserLoginDB1BindingSource.DataSource = Me.UserLoginDB1
        Me.UserLoginDB1BindingSource.Position = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 473)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(559, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(291, 32)
        Me.TextBox1.TabIndex = 1
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.search.Location = New System.Drawing.Point(726, 69)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(115, 33)
        Me.search.TabIndex = 2
        Me.search.Text = "Rechercher"
        Me.search.UseVisualStyleBackColor = True
        '
        'nomarticle
        '
        Me.nomarticle.Location = New System.Drawing.Point(237, 299)
        Me.nomarticle.Multiline = True
        Me.nomarticle.Name = "nomarticle"
        Me.nomarticle.Size = New System.Drawing.Size(247, 30)
        Me.nomarticle.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(237, 372)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(247, 29)
        Me.TextBox3.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(237, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(396, 421)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(88, 32)
        Me.update.TabIndex = 7
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(239, 192)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(244, 24)
        Me.ComboBox2.TabIndex = 8
        '
        'consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(862, 476)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.nomarticle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Menu = Me.MainMenu1
        Me.Name = "consultation"
        Me.Text = "consultation"
        CType(Me.UserLoginDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLoginDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLoginDB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserLoginDB As UserLoginDB
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserLoginDB1BindingSource As BindingSource
    Friend WithEvents UserLoginDB1 As UserLoginDB
    Friend WithEvents MainMenu1 As MainMenu
    Friend WithEvents Panel1 As Panel
    Friend WithEvents search As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents nomarticle As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents update As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
