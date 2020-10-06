<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListTags
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picSearchIcon = New System.Windows.Forms.PictureBox()
        Me.pnlTagLine = New System.Windows.Forms.Panel()
        Me.pnlSearchLine = New System.Windows.Forms.Panel()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.txtTagID = New System.Windows.Forms.TextBox()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblTagsInfo = New System.Windows.Forms.Label()
        Me.dgvListTag = New System.Windows.Forms.DataGridView()
        Me.btnCreateTag = New System.Windows.Forms.Button()
        Me.btnDeleteTag = New System.Windows.Forms.Button()
        Me.btnUpdateTag = New System.Windows.Forms.Button()
        Me.btnAddTag = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListTag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSearchIcon
        '
        Me.picSearchIcon.BackgroundImage = Global.postmanagement.My.Resources.Resources.search24px
        Me.picSearchIcon.Location = New System.Drawing.Point(12, 31)
        Me.picSearchIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picSearchIcon.Name = "picSearchIcon"
        Me.picSearchIcon.Size = New System.Drawing.Size(24, 24)
        Me.picSearchIcon.TabIndex = 40
        Me.picSearchIcon.TabStop = False
        '
        'pnlTagLine
        '
        Me.pnlTagLine.BackColor = System.Drawing.Color.Black
        Me.pnlTagLine.Location = New System.Drawing.Point(497, 122)
        Me.pnlTagLine.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTagLine.Name = "pnlTagLine"
        Me.pnlTagLine.Size = New System.Drawing.Size(175, 1)
        Me.pnlTagLine.TabIndex = 36
        '
        'pnlSearchLine
        '
        Me.pnlSearchLine.BackColor = System.Drawing.Color.Black
        Me.pnlSearchLine.Location = New System.Drawing.Point(44, 54)
        Me.pnlSearchLine.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSearchLine.Name = "pnlSearchLine"
        Me.pnlSearchLine.Size = New System.Drawing.Size(200, 1)
        Me.pnlSearchLine.TabIndex = 37
        '
        'txtTag
        '
        Me.txtTag.BackColor = System.Drawing.SystemColors.Window
        Me.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTag.Location = New System.Drawing.Point(497, 104)
        Me.txtTag.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(175, 18)
        Me.txtTag.TabIndex = 32
        '
        'txtTagID
        '
        Me.txtTagID.BackColor = System.Drawing.SystemColors.Control
        Me.txtTagID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTagID.Location = New System.Drawing.Point(497, 72)
        Me.txtTagID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTagID.Name = "txtTagID"
        Me.txtTagID.ReadOnly = True
        Me.txtTagID.Size = New System.Drawing.Size(175, 18)
        Me.txtTagID.TabIndex = 30
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Location = New System.Drawing.Point(383, 104)
        Me.lblTag.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(35, 17)
        Me.lblTag.TabIndex = 34
        Me.lblTag.Text = "Tag:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(383, 72)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(53, 17)
        Me.lblId.TabIndex = 35
        Me.lblId.Text = "Tag ID:"
        '
        'lblTagsInfo
        '
        Me.lblTagsInfo.AutoSize = True
        Me.lblTagsInfo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagsInfo.Location = New System.Drawing.Point(453, 33)
        Me.lblTagsInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTagsInfo.Name = "lblTagsInfo"
        Me.lblTagsInfo.Size = New System.Drawing.Size(156, 22)
        Me.lblTagsInfo.TabIndex = 33
        Me.lblTagsInfo.Text = "Tag Information"
        '
        'dgvListTag
        '
        Me.dgvListTag.AllowUserToAddRows = False
        Me.dgvListTag.AllowUserToDeleteRows = False
        Me.dgvListTag.AllowUserToResizeRows = False
        Me.dgvListTag.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvListTag.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvListTag.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListTag.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListTag.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListTag.Location = New System.Drawing.Point(12, 72)
        Me.dgvListTag.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListTag.Name = "dgvListTag"
        Me.dgvListTag.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvListTag.Size = New System.Drawing.Size(357, 359)
        Me.dgvListTag.TabIndex = 31
        '
        'btnCreateTag
        '
        Me.btnCreateTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateTag.FlatAppearance.BorderSize = 0
        Me.btnCreateTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateTag.ForeColor = System.Drawing.Color.White
        Me.btnCreateTag.Location = New System.Drawing.Point(582, 401)
        Me.btnCreateTag.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateTag.Name = "btnCreateTag"
        Me.btnCreateTag.Size = New System.Drawing.Size(90, 30)
        Me.btnCreateTag.TabIndex = 42
        Me.btnCreateTag.Text = "+ New"
        Me.btnCreateTag.UseVisualStyleBackColor = False
        '
        'btnDeleteTag
        '
        Me.btnDeleteTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDeleteTag.FlatAppearance.BorderSize = 0
        Me.btnDeleteTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTag.ForeColor = System.Drawing.Color.White
        Me.btnDeleteTag.Location = New System.Drawing.Point(582, 363)
        Me.btnDeleteTag.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteTag.Name = "btnDeleteTag"
        Me.btnDeleteTag.Size = New System.Drawing.Size(90, 30)
        Me.btnDeleteTag.TabIndex = 41
        Me.btnDeleteTag.Text = "Delete"
        Me.btnDeleteTag.UseVisualStyleBackColor = False
        '
        'btnUpdateTag
        '
        Me.btnUpdateTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnUpdateTag.FlatAppearance.BorderSize = 0
        Me.btnUpdateTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateTag.ForeColor = System.Drawing.Color.White
        Me.btnUpdateTag.Location = New System.Drawing.Point(484, 363)
        Me.btnUpdateTag.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateTag.Name = "btnUpdateTag"
        Me.btnUpdateTag.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdateTag.TabIndex = 39
        Me.btnUpdateTag.Text = "Update"
        Me.btnUpdateTag.UseVisualStyleBackColor = False
        '
        'btnAddTag
        '
        Me.btnAddTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddTag.FlatAppearance.BorderSize = 0
        Me.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTag.ForeColor = System.Drawing.Color.White
        Me.btnAddTag.Location = New System.Drawing.Point(386, 363)
        Me.btnAddTag.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(90, 30)
        Me.btnAddTag.TabIndex = 38
        Me.btnAddTag.Text = "Add"
        Me.btnAddTag.UseVisualStyleBackColor = False
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
        Me.btnSearch.TabIndex = 29
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
        Me.txtSearch.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(497, 131)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(175, 224)
        Me.txtDescription.TabIndex = 32
        '
        'ListTags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.picSearchIcon)
        Me.Controls.Add(Me.pnlTagLine)
        Me.Controls.Add(Me.pnlSearchLine)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTagID)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblTagsInfo)
        Me.Controls.Add(Me.dgvListTag)
        Me.Controls.Add(Me.btnCreateTag)
        Me.Controls.Add(Me.btnDeleteTag)
        Me.Controls.Add(Me.btnUpdateTag)
        Me.Controls.Add(Me.btnAddTag)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ListTags"
        Me.Size = New System.Drawing.Size(684, 461)
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListTag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSearchIcon As PictureBox
    Friend WithEvents pnlTagLine As Panel
    Friend WithEvents pnlSearchLine As Panel
    Friend WithEvents txtTag As TextBox
    Friend WithEvents txtTagID As TextBox
    Friend WithEvents lblTag As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblTagsInfo As Label
    Friend WithEvents dgvListTag As DataGridView
    Friend WithEvents btnCreateTag As Button
    Friend WithEvents btnDeleteTag As Button
    Friend WithEvents btnUpdateTag As Button
    Friend WithEvents btnAddTag As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As TextBox
End Class
