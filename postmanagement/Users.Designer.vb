<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlListUsers = New System.Windows.Forms.Panel()
        Me.picSearchIcon = New System.Windows.Forms.PictureBox()
        Me.txtDetailAddress = New System.Windows.Forms.TextBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cbxDetailRole = New System.Windows.Forms.ComboBox()
        Me.pnlSearchLine = New System.Windows.Forms.Panel()
        Me.pnlLine3 = New System.Windows.Forms.Panel()
        Me.pnlLine2 = New System.Windows.Forms.Panel()
        Me.pnlLine1 = New System.Windows.Forms.Panel()
        Me.txtDetailDspName = New System.Windows.Forms.TextBox()
        Me.txtDetailPass = New System.Windows.Forms.TextBox()
        Me.txtDetailUsername = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblDetailRole = New System.Windows.Forms.Label()
        Me.lblDetailDspName = New System.Windows.Forms.Label()
        Me.lblDetailPass = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.dgvListUsers = New System.Windows.Forms.DataGridView()
        Me.btnResetUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlListUsers.SuspendLayout()
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlListUsers
        '
        Me.pnlListUsers.BackColor = System.Drawing.SystemColors.Window
        Me.pnlListUsers.Controls.Add(Me.picSearchIcon)
        Me.pnlListUsers.Controls.Add(Me.txtDetailAddress)
        Me.pnlListUsers.Controls.Add(Me.dtpStartDate)
        Me.pnlListUsers.Controls.Add(Me.cbxDetailRole)
        Me.pnlListUsers.Controls.Add(Me.pnlSearchLine)
        Me.pnlListUsers.Controls.Add(Me.pnlLine3)
        Me.pnlListUsers.Controls.Add(Me.pnlLine2)
        Me.pnlListUsers.Controls.Add(Me.pnlLine1)
        Me.pnlListUsers.Controls.Add(Me.txtDetailDspName)
        Me.pnlListUsers.Controls.Add(Me.txtDetailPass)
        Me.pnlListUsers.Controls.Add(Me.txtDetailUsername)
        Me.pnlListUsers.Controls.Add(Me.lblAddress)
        Me.pnlListUsers.Controls.Add(Me.lblStartDate)
        Me.pnlListUsers.Controls.Add(Me.lblDetailRole)
        Me.pnlListUsers.Controls.Add(Me.lblDetailDspName)
        Me.pnlListUsers.Controls.Add(Me.lblDetailPass)
        Me.pnlListUsers.Controls.Add(Me.lblUsername)
        Me.pnlListUsers.Controls.Add(Me.lblUserInfo)
        Me.pnlListUsers.Controls.Add(Me.dgvListUsers)
        Me.pnlListUsers.Controls.Add(Me.btnResetUser)
        Me.pnlListUsers.Controls.Add(Me.btnDeleteUser)
        Me.pnlListUsers.Controls.Add(Me.btnUpdateUser)
        Me.pnlListUsers.Controls.Add(Me.btnAddUser)
        Me.pnlListUsers.Controls.Add(Me.btnSearch)
        Me.pnlListUsers.Controls.Add(Me.txtSearch)
        Me.pnlListUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlListUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlListUsers.Name = "pnlListUsers"
        Me.pnlListUsers.Size = New System.Drawing.Size(684, 461)
        Me.pnlListUsers.TabIndex = 1
        '
        'picSearchIcon
        '
        Me.picSearchIcon.BackgroundImage = Global.postmanagement.My.Resources.Resources.search24px
        Me.picSearchIcon.Location = New System.Drawing.Point(8, 20)
        Me.picSearchIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picSearchIcon.Name = "picSearchIcon"
        Me.picSearchIcon.Size = New System.Drawing.Size(24, 24)
        Me.picSearchIcon.TabIndex = 10
        Me.picSearchIcon.TabStop = False
        '
        'txtDetailAddress
        '
        Me.txtDetailAddress.Location = New System.Drawing.Point(471, 239)
        Me.txtDetailAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetailAddress.Multiline = True
        Me.txtDetailAddress.Name = "txtDetailAddress"
        Me.txtDetailAddress.Size = New System.Drawing.Size(197, 90)
        Me.txtDetailAddress.TabIndex = 7
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(471, 202)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(197, 25)
        Me.dtpStartDate.TabIndex = 6
        '
        'cbxDetailRole
        '
        Me.cbxDetailRole.BackColor = System.Drawing.SystemColors.Window
        Me.cbxDetailRole.FormattingEnabled = True
        Me.cbxDetailRole.Location = New System.Drawing.Point(471, 159)
        Me.cbxDetailRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxDetailRole.Name = "cbxDetailRole"
        Me.cbxDetailRole.Size = New System.Drawing.Size(197, 25)
        Me.cbxDetailRole.TabIndex = 5
        '
        'pnlSearchLine
        '
        Me.pnlSearchLine.BackColor = System.Drawing.Color.Black
        Me.pnlSearchLine.Location = New System.Drawing.Point(40, 43)
        Me.pnlSearchLine.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSearchLine.Name = "pnlSearchLine"
        Me.pnlSearchLine.Size = New System.Drawing.Size(200, 1)
        Me.pnlSearchLine.TabIndex = 6
        '
        'pnlLine3
        '
        Me.pnlLine3.BackColor = System.Drawing.Color.Black
        Me.pnlLine3.Location = New System.Drawing.Point(471, 142)
        Me.pnlLine3.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLine3.Name = "pnlLine3"
        Me.pnlLine3.Size = New System.Drawing.Size(197, 1)
        Me.pnlLine3.TabIndex = 6
        '
        'pnlLine2
        '
        Me.pnlLine2.BackColor = System.Drawing.Color.Black
        Me.pnlLine2.Location = New System.Drawing.Point(471, 109)
        Me.pnlLine2.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLine2.Name = "pnlLine2"
        Me.pnlLine2.Size = New System.Drawing.Size(197, 1)
        Me.pnlLine2.TabIndex = 4
        '
        'pnlLine1
        '
        Me.pnlLine1.BackColor = System.Drawing.Color.Black
        Me.pnlLine1.Location = New System.Drawing.Point(471, 77)
        Me.pnlLine1.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLine1.Name = "pnlLine1"
        Me.pnlLine1.Size = New System.Drawing.Size(197, 1)
        Me.pnlLine1.TabIndex = 3
        '
        'txtDetailDspName
        '
        Me.txtDetailDspName.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetailDspName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetailDspName.Location = New System.Drawing.Point(471, 126)
        Me.txtDetailDspName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetailDspName.Name = "txtDetailDspName"
        Me.txtDetailDspName.Size = New System.Drawing.Size(197, 18)
        Me.txtDetailDspName.TabIndex = 4
        '
        'txtDetailPass
        '
        Me.txtDetailPass.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetailPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetailPass.Location = New System.Drawing.Point(471, 93)
        Me.txtDetailPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetailPass.Name = "txtDetailPass"
        Me.txtDetailPass.Size = New System.Drawing.Size(197, 18)
        Me.txtDetailPass.TabIndex = 3
        '
        'txtDetailUsername
        '
        Me.txtDetailUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetailUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetailUsername.Location = New System.Drawing.Point(471, 61)
        Me.txtDetailUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetailUsername.Name = "txtDetailUsername"
        Me.txtDetailUsername.Size = New System.Drawing.Size(197, 18)
        Me.txtDetailUsername.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(379, 242)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 17)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(379, 208)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(75, 17)
        Me.lblStartDate.TabIndex = 4
        Me.lblStartDate.Text = "Start date:"
        '
        'lblDetailRole
        '
        Me.lblDetailRole.AutoSize = True
        Me.lblDetailRole.Location = New System.Drawing.Point(379, 162)
        Me.lblDetailRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDetailRole.Name = "lblDetailRole"
        Me.lblDetailRole.Size = New System.Drawing.Size(42, 17)
        Me.lblDetailRole.TabIndex = 4
        Me.lblDetailRole.Text = "Role:"
        '
        'lblDetailDspName
        '
        Me.lblDetailDspName.AutoSize = True
        Me.lblDetailDspName.Location = New System.Drawing.Point(379, 126)
        Me.lblDetailDspName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDetailDspName.Name = "lblDetailDspName"
        Me.lblDetailDspName.Size = New System.Drawing.Size(51, 17)
        Me.lblDetailDspName.TabIndex = 4
        Me.lblDetailDspName.Text = "Name:"
        '
        'lblDetailPass
        '
        Me.lblDetailPass.AutoSize = True
        Me.lblDetailPass.Location = New System.Drawing.Point(379, 93)
        Me.lblDetailPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDetailPass.Name = "lblDetailPass"
        Me.lblDetailPass.Size = New System.Drawing.Size(78, 17)
        Me.lblDetailPass.TabIndex = 4
        Me.lblDetailPass.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(379, 61)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(84, 17)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "User name:"
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(449, 22)
        Me.lblUserInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(164, 22)
        Me.lblUserInfo.TabIndex = 3
        Me.lblUserInfo.Text = "User Information"
        '
        'dgvListUsers
        '
        Me.dgvListUsers.AllowUserToAddRows = False
        Me.dgvListUsers.AllowUserToDeleteRows = False
        Me.dgvListUsers.AllowUserToResizeRows = False
        Me.dgvListUsers.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvListUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvListUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListUsers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListUsers.Location = New System.Drawing.Point(8, 61)
        Me.dgvListUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListUsers.Name = "dgvListUsers"
        Me.dgvListUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvListUsers.Size = New System.Drawing.Size(357, 359)
        Me.dgvListUsers.TabIndex = 2
        '
        'btnResetUser
        '
        Me.btnResetUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResetUser.FlatAppearance.BorderSize = 0
        Me.btnResetUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetUser.ForeColor = System.Drawing.Color.White
        Me.btnResetUser.Location = New System.Drawing.Point(578, 390)
        Me.btnResetUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetUser.Name = "btnResetUser"
        Me.btnResetUser.Size = New System.Drawing.Size(90, 30)
        Me.btnResetUser.TabIndex = 11
        Me.btnResetUser.Text = "Reset"
        Me.btnResetUser.UseVisualStyleBackColor = False
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDeleteUser.FlatAppearance.BorderSize = 0
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.White
        Me.btnDeleteUser.Location = New System.Drawing.Point(578, 352)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(90, 30)
        Me.btnDeleteUser.TabIndex = 10
        Me.btnDeleteUser.Text = "Delete"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnUpdateUser.FlatAppearance.BorderSize = 0
        Me.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.White
        Me.btnUpdateUser.Location = New System.Drawing.Point(480, 352)
        Me.btnUpdateUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdateUser.TabIndex = 9
        Me.btnUpdateUser.Text = "Update"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(382, 352)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(90, 30)
        Me.btnAddUser.TabIndex = 8
        Me.btnAddUser.Text = "Add"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(265, 19)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Location = New System.Drawing.Point(40, 26)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 18)
        Me.txtSearch.TabIndex = 0
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.pnlListUsers)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Users"
        Me.Size = New System.Drawing.Size(684, 461)
        Me.pnlListUsers.ResumeLayout(False)
        Me.pnlListUsers.PerformLayout()
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlListUsers As Panel
    Friend WithEvents picSearchIcon As PictureBox
    Friend WithEvents txtDetailAddress As TextBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents cbxDetailRole As ComboBox
    Friend WithEvents pnlSearchLine As Panel
    Friend WithEvents pnlLine3 As Panel
    Friend WithEvents pnlLine2 As Panel
    Friend WithEvents pnlLine1 As Panel
    Friend WithEvents txtDetailDspName As TextBox
    Friend WithEvents txtDetailPass As TextBox
    Friend WithEvents txtDetailUsername As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblDetailRole As Label
    Friend WithEvents lblDetailDspName As Label
    Friend WithEvents lblDetailPass As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents dgvListUsers As DataGridView
    Friend WithEvents btnResetUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
