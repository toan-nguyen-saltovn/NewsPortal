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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.pnlUsername = New System.Windows.Forms.Panel()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.chbShowPass = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picPassIcon = New System.Windows.Forms.PictureBox()
        Me.picUserIcon = New System.Windows.Forms.PictureBox()
        Me.picLoginLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picPassIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(111, 196)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(169, 19)
        Me.txtUsername.TabIndex = 2
        '
        'pnlUsername
        '
        Me.pnlUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pnlUsername.Location = New System.Drawing.Point(70, 219)
        Me.pnlUsername.Name = "pnlUsername"
        Me.pnlUsername.Size = New System.Drawing.Size(210, 1)
        Me.pnlUsername.TabIndex = 3
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pnlPass.Location = New System.Drawing.Point(70, 259)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(210, 1)
        Me.pnlPass.TabIndex = 6
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(111, 236)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(169, 19)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'chbShowPass
        '
        Me.chbShowPass.AutoSize = True
        Me.chbShowPass.FlatAppearance.BorderSize = 0
        Me.chbShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbShowPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.chbShowPass.Location = New System.Drawing.Point(90, 266)
        Me.chbShowPass.Name = "chbShowPass"
        Me.chbShowPass.Size = New System.Drawing.Size(173, 19)
        Me.chbShowPass.TabIndex = 7
        Me.chbShowPass.Text = "Show password characters"
        Me.chbShowPass.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(70, 303)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(210, 35)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Sign In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(70, 353)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(210, 35)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'picPassIcon
        '
        Me.picPassIcon.BackgroundImage = Global.postmanagement.My.Resources.Resources.password32px
        Me.picPassIcon.Location = New System.Drawing.Point(70, 223)
        Me.picPassIcon.Name = "picPassIcon"
        Me.picPassIcon.Size = New System.Drawing.Size(32, 32)
        Me.picPassIcon.TabIndex = 4
        Me.picPassIcon.TabStop = False
        '
        'picUserIcon
        '
        Me.picUserIcon.BackgroundImage = Global.postmanagement.My.Resources.Resources.user32px
        Me.picUserIcon.Location = New System.Drawing.Point(70, 183)
        Me.picUserIcon.Name = "picUserIcon"
        Me.picUserIcon.Size = New System.Drawing.Size(32, 32)
        Me.picUserIcon.TabIndex = 1
        Me.picUserIcon.TabStop = False
        '
        'picLoginLogo
        '
        Me.picLoginLogo.BackgroundImage = Global.postmanagement.My.Resources.Resources.login128px
        Me.picLoginLogo.Location = New System.Drawing.Point(111, 12)
        Me.picLoginLogo.Name = "picLoginLogo"
        Me.picLoginLogo.Size = New System.Drawing.Size(128, 128)
        Me.picLoginLogo.TabIndex = 0
        Me.picLoginLogo.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chbShowPass)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.pnlUsername)
        Me.Controls.Add(Me.picPassIcon)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.picUserIcon)
        Me.Controls.Add(Me.picLoginLogo)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.TopMost = True
        CType(Me.picPassIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLoginLogo As PictureBox
    Friend WithEvents picUserIcon As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pnlUsername As Panel
    Friend WithEvents pnlPass As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents picPassIcon As PictureBox
    Friend WithEvents chbShowPass As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
End Class
