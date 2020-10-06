<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListPosts
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
        Me.flpLstPost = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNoresult = New System.Windows.Forms.Label()
        Me.pnlLstPostTop = New System.Windows.Forms.Panel()
        Me.picSearchIcon = New System.Windows.Forms.PictureBox()
        Me.pnlSearchLine = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.flpLstPost.SuspendLayout()
        Me.pnlLstPostTop.SuspendLayout()
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpLstPost
        '
        Me.flpLstPost.Controls.Add(Me.lblNoresult)
        Me.flpLstPost.Location = New System.Drawing.Point(3, 50)
        Me.flpLstPost.Name = "flpLstPost"
        Me.flpLstPost.Size = New System.Drawing.Size(681, 398)
        Me.flpLstPost.TabIndex = 0
        '
        'lblNoresult
        '
        Me.lblNoresult.AutoSize = True
        Me.lblNoresult.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoresult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblNoresult.Location = New System.Drawing.Point(3, 0)
        Me.lblNoresult.Name = "lblNoresult"
        Me.lblNoresult.Size = New System.Drawing.Size(131, 18)
        Me.lblNoresult.TabIndex = 0
        Me.lblNoresult.Text = "You have no post"
        '
        'pnlLstPostTop
        '
        Me.pnlLstPostTop.Controls.Add(Me.picSearchIcon)
        Me.pnlLstPostTop.Controls.Add(Me.pnlSearchLine)
        Me.pnlLstPostTop.Controls.Add(Me.btnCreateNew)
        Me.pnlLstPostTop.Controls.Add(Me.btnSearch)
        Me.pnlLstPostTop.Controls.Add(Me.txtSearch)
        Me.pnlLstPostTop.Controls.Add(Me.lblPageTitle)
        Me.pnlLstPostTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLstPostTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlLstPostTop.Name = "pnlLstPostTop"
        Me.pnlLstPostTop.Size = New System.Drawing.Size(684, 50)
        Me.pnlLstPostTop.TabIndex = 1
        '
        'picSearchIcon
        '
        Me.picSearchIcon.BackgroundImage = Global.postmanagement.My.Resources.Resources.search24px
        Me.picSearchIcon.Location = New System.Drawing.Point(183, 17)
        Me.picSearchIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picSearchIcon.Name = "picSearchIcon"
        Me.picSearchIcon.Size = New System.Drawing.Size(24, 24)
        Me.picSearchIcon.TabIndex = 14
        Me.picSearchIcon.TabStop = False
        '
        'pnlSearchLine
        '
        Me.pnlSearchLine.BackColor = System.Drawing.Color.Black
        Me.pnlSearchLine.Location = New System.Drawing.Point(215, 40)
        Me.pnlSearchLine.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSearchLine.Name = "pnlSearchLine"
        Me.pnlSearchLine.Size = New System.Drawing.Size(120, 1)
        Me.pnlSearchLine.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(343, 12)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search Tags"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Location = New System.Drawing.Point(215, 23)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(120, 18)
        Me.txtSearch.TabIndex = 11
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(48, 22)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(125, 22)
        Me.lblPageTitle.TabIndex = 1
        Me.lblPageTitle.Text = "List of Posts"
        '
        'btnCreateNew
        '
        Me.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCreateNew.FlatAppearance.BorderSize = 0
        Me.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNew.ForeColor = System.Drawing.Color.White
        Me.btnCreateNew.Location = New System.Drawing.Point(541, 11)
        Me.btnCreateNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(100, 30)
        Me.btnCreateNew.TabIndex = 12
        Me.btnCreateNew.Text = " + New Post"
        Me.btnCreateNew.UseVisualStyleBackColor = False
        '
        'ListPosts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.pnlLstPostTop)
        Me.Controls.Add(Me.flpLstPost)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ListPosts"
        Me.Size = New System.Drawing.Size(684, 461)
        Me.flpLstPost.ResumeLayout(False)
        Me.flpLstPost.PerformLayout()
        Me.pnlLstPostTop.ResumeLayout(False)
        Me.pnlLstPostTop.PerformLayout()
        CType(Me.picSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpLstPost As FlowLayoutPanel
    Friend WithEvents lblNoresult As Label
    Friend WithEvents pnlLstPostTop As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents picSearchIcon As PictureBox
    Friend WithEvents pnlSearchLine As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnCreateNew As Button
End Class
