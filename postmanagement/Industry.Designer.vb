<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Industry
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picSearchIcon = New System.Windows.Forms.PictureBox()
        Me.pnlSearchLine = New System.Windows.Forms.Panel()
        Me.txtIndName = New System.Windows.Forms.TextBox()
        Me.txtIndID = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblIndusInfo = New System.Windows.Forms.Label()
        Me.dgvListIndustry = New System.Windows.Forms.DataGridView()
        Me.btnResetIndus = New System.Windows.Forms.Button()
        Me.btnDeleteIndus = New System.Windows.Forms.Button()
        Me.btnUpdateIndus = New System.Windows.Forms.Button()
        Me.btnAddIdus = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlNameLine = New System.Windows.Forms.Panel()
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListIndustry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSearchIcon
        '
        Me.picSearchIcon.BackgroundImage = Global.postmanagement.My.Resources.Resources.search24px
        Me.picSearchIcon.Location = New System.Drawing.Point(12, 31)
        Me.picSearchIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picSearchIcon.Name = "picSearchIcon"
        Me.picSearchIcon.Size = New System.Drawing.Size(24, 24)
        Me.picSearchIcon.TabIndex = 25
        Me.picSearchIcon.TabStop = False
        '
        'pnlSearchLine
        '
        Me.pnlSearchLine.BackColor = System.Drawing.Color.Black
        Me.pnlSearchLine.Location = New System.Drawing.Point(44, 54)
        Me.pnlSearchLine.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSearchLine.Name = "pnlSearchLine"
        Me.pnlSearchLine.Size = New System.Drawing.Size(200, 1)
        Me.pnlSearchLine.TabIndex = 22
        '
        'txtIndName
        '
        Me.txtIndName.BackColor = System.Drawing.SystemColors.Window
        Me.txtIndName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIndName.Location = New System.Drawing.Point(497, 104)
        Me.txtIndName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIndName.Name = "txtIndName"
        Me.txtIndName.Size = New System.Drawing.Size(175, 18)
        Me.txtIndName.TabIndex = 16
        '
        'txtIndID
        '
        Me.txtIndID.BackColor = System.Drawing.SystemColors.Control
        Me.txtIndID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIndID.Location = New System.Drawing.Point(497, 72)
        Me.txtIndID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIndID.Name = "txtIndID"
        Me.txtIndID.ReadOnly = True
        Me.txtIndID.Size = New System.Drawing.Size(175, 18)
        Me.txtIndID.TabIndex = 14
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(383, 104)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 17)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Industry Name:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(383, 72)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(81, 17)
        Me.lblId.TabIndex = 21
        Me.lblId.Text = "Industry ID:"
        '
        'lblIndusInfo
        '
        Me.lblIndusInfo.AutoSize = True
        Me.lblIndusInfo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndusInfo.Location = New System.Drawing.Point(453, 33)
        Me.lblIndusInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndusInfo.Name = "lblIndusInfo"
        Me.lblIndusInfo.Size = New System.Drawing.Size(198, 22)
        Me.lblIndusInfo.TabIndex = 17
        Me.lblIndusInfo.Text = "Industry Information"
        '
        'dgvListIndustry
        '
        Me.dgvListIndustry.AllowUserToAddRows = False
        Me.dgvListIndustry.AllowUserToDeleteRows = False
        Me.dgvListIndustry.AllowUserToResizeRows = False
        Me.dgvListIndustry.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvListIndustry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvListIndustry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListIndustry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListIndustry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListIndustry.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListIndustry.Location = New System.Drawing.Point(12, 72)
        Me.dgvListIndustry.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListIndustry.Name = "dgvListIndustry"
        Me.dgvListIndustry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvListIndustry.Size = New System.Drawing.Size(357, 359)
        Me.dgvListIndustry.TabIndex = 15
        '
        'btnResetIndus
        '
        Me.btnResetIndus.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResetIndus.FlatAppearance.BorderSize = 0
        Me.btnResetIndus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetIndus.ForeColor = System.Drawing.Color.White
        Me.btnResetIndus.Location = New System.Drawing.Point(582, 401)
        Me.btnResetIndus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetIndus.Name = "btnResetIndus"
        Me.btnResetIndus.Size = New System.Drawing.Size(90, 30)
        Me.btnResetIndus.TabIndex = 27
        Me.btnResetIndus.Text = "+ New"
        Me.btnResetIndus.UseVisualStyleBackColor = False
        '
        'btnDeleteIndus
        '
        Me.btnDeleteIndus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDeleteIndus.FlatAppearance.BorderSize = 0
        Me.btnDeleteIndus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteIndus.ForeColor = System.Drawing.Color.White
        Me.btnDeleteIndus.Location = New System.Drawing.Point(582, 363)
        Me.btnDeleteIndus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteIndus.Name = "btnDeleteIndus"
        Me.btnDeleteIndus.Size = New System.Drawing.Size(90, 30)
        Me.btnDeleteIndus.TabIndex = 26
        Me.btnDeleteIndus.Text = "Delete"
        Me.btnDeleteIndus.UseVisualStyleBackColor = False
        '
        'btnUpdateIndus
        '
        Me.btnUpdateIndus.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnUpdateIndus.FlatAppearance.BorderSize = 0
        Me.btnUpdateIndus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateIndus.ForeColor = System.Drawing.Color.White
        Me.btnUpdateIndus.Location = New System.Drawing.Point(484, 363)
        Me.btnUpdateIndus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateIndus.Name = "btnUpdateIndus"
        Me.btnUpdateIndus.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdateIndus.TabIndex = 24
        Me.btnUpdateIndus.Text = "Update"
        Me.btnUpdateIndus.UseVisualStyleBackColor = False
        '
        'btnAddIdus
        '
        Me.btnAddIdus.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddIdus.FlatAppearance.BorderSize = 0
        Me.btnAddIdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddIdus.ForeColor = System.Drawing.Color.White
        Me.btnAddIdus.Location = New System.Drawing.Point(386, 363)
        Me.btnAddIdus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddIdus.Name = "btnAddIdus"
        Me.btnAddIdus.Size = New System.Drawing.Size(90, 30)
        Me.btnAddIdus.TabIndex = 23
        Me.btnAddIdus.Text = "Add"
        Me.btnAddIdus.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(269, 30)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Location = New System.Drawing.Point(44, 37)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 18)
        Me.txtSearch.TabIndex = 12
        '
        'pnlNameLine
        '
        Me.pnlNameLine.BackColor = System.Drawing.Color.Black
        Me.pnlNameLine.Location = New System.Drawing.Point(497, 122)
        Me.pnlNameLine.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNameLine.Name = "pnlNameLine"
        Me.pnlNameLine.Size = New System.Drawing.Size(175, 1)
        Me.pnlNameLine.TabIndex = 22
        '
        'Industry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.picSearchIcon)
        Me.Controls.Add(Me.pnlNameLine)
        Me.Controls.Add(Me.pnlSearchLine)
        Me.Controls.Add(Me.txtIndName)
        Me.Controls.Add(Me.txtIndID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblIndusInfo)
        Me.Controls.Add(Me.dgvListIndustry)
        Me.Controls.Add(Me.btnResetIndus)
        Me.Controls.Add(Me.btnDeleteIndus)
        Me.Controls.Add(Me.btnUpdateIndus)
        Me.Controls.Add(Me.btnAddIdus)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Industry"
        Me.Size = New System.Drawing.Size(684, 461)
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListIndustry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSearchIcon As PictureBox
    Friend WithEvents pnlSearchLine As Panel
    Friend WithEvents txtIndName As TextBox
    Friend WithEvents txtIndID As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblIndusInfo As Label
    Friend WithEvents dgvListIndustry As DataGridView
    Friend WithEvents btnResetIndus As Button
    Friend WithEvents btnDeleteIndus As Button
    Friend WithEvents btnUpdateIndus As Button
    Friend WithEvents btnAddIdus As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlNameLine As Panel
End Class
