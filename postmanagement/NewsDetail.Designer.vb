<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewsDetail
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.cbxNewsIndustry = New System.Windows.Forms.ComboBox()
        Me.pnlTitleLine = New System.Windows.Forms.Panel()
        Me.txtNewsTitle = New System.Windows.Forms.TextBox()
        Me.lblNewsIndustry = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.txtNewsSum = New System.Windows.Forms.TextBox()
        Me.btnClrImg = New System.Windows.Forms.Button()
        Me.btnImgBrowse = New System.Windows.Forms.Button()
        Me.lblImgName = New System.Windows.Forms.Label()
        Me.lblNewsSum = New System.Windows.Forms.Label()
        Me.lblSelectimg = New System.Windows.Forms.Label()
        Me.picNewsImg = New System.Windows.Forms.PictureBox()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.flpTagsContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDeleteNews = New System.Windows.Forms.Button()
        Me.btnUpdateNews = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddNews = New System.Windows.Forms.Button()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.btnAddTag = New System.Windows.Forms.Button()
        Me.btnVideoBrowse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.lblVideosSelected = New System.Windows.Forms.Label()
        Me.lblVideo = New System.Windows.Forms.Label()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.btnPrintNews = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        CType(Me.picNewsImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.cbxNewsIndustry)
        Me.pnlTop.Controls.Add(Me.pnlTitleLine)
        Me.pnlTop.Controls.Add(Me.txtNewsTitle)
        Me.pnlTop.Controls.Add(Me.lblNewsIndustry)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(684, 41)
        Me.pnlTop.TabIndex = 0
        '
        'cbxNewsIndustry
        '
        Me.cbxNewsIndustry.FormattingEnabled = True
        Me.cbxNewsIndustry.Location = New System.Drawing.Point(450, 10)
        Me.cbxNewsIndustry.Name = "cbxNewsIndustry"
        Me.cbxNewsIndustry.Size = New System.Drawing.Size(147, 25)
        Me.cbxNewsIndustry.TabIndex = 3
        '
        'pnlTitleLine
        '
        Me.pnlTitleLine.BackColor = System.Drawing.Color.Black
        Me.pnlTitleLine.Location = New System.Drawing.Point(47, 31)
        Me.pnlTitleLine.Name = "pnlTitleLine"
        Me.pnlTitleLine.Size = New System.Drawing.Size(325, 1)
        Me.pnlTitleLine.TabIndex = 2
        '
        'txtNewsTitle
        '
        Me.txtNewsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewsTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewsTitle.Location = New System.Drawing.Point(47, 14)
        Me.txtNewsTitle.Name = "txtNewsTitle"
        Me.txtNewsTitle.Size = New System.Drawing.Size(325, 19)
        Me.txtNewsTitle.TabIndex = 1
        Me.txtNewsTitle.Text = "Title of news"
        '
        'lblNewsIndustry
        '
        Me.lblNewsIndustry.AutoSize = True
        Me.lblNewsIndustry.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewsIndustry.Location = New System.Drawing.Point(381, 15)
        Me.lblNewsIndustry.Name = "lblNewsIndustry"
        Me.lblNewsIndustry.Size = New System.Drawing.Size(63, 17)
        Me.lblNewsIndustry.TabIndex = 0
        Me.lblNewsIndustry.Text = "Industry:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 17)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'pnlSummary
        '
        Me.pnlSummary.Controls.Add(Me.txtNewsSum)
        Me.pnlSummary.Controls.Add(Me.btnClrImg)
        Me.pnlSummary.Controls.Add(Me.btnImgBrowse)
        Me.pnlSummary.Controls.Add(Me.lblImgName)
        Me.pnlSummary.Controls.Add(Me.lblNewsSum)
        Me.pnlSummary.Controls.Add(Me.lblSelectimg)
        Me.pnlSummary.Controls.Add(Me.picNewsImg)
        Me.pnlSummary.Location = New System.Drawing.Point(0, 41)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Size = New System.Drawing.Size(684, 124)
        Me.pnlSummary.TabIndex = 1
        '
        'txtNewsSum
        '
        Me.txtNewsSum.Location = New System.Drawing.Point(384, 20)
        Me.txtNewsSum.Multiline = True
        Me.txtNewsSum.Name = "txtNewsSum"
        Me.txtNewsSum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNewsSum.Size = New System.Drawing.Size(286, 100)
        Me.txtNewsSum.TabIndex = 3
        '
        'btnClrImg
        '
        Me.btnClrImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClrImg.FlatAppearance.BorderSize = 0
        Me.btnClrImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClrImg.ForeColor = System.Drawing.Color.White
        Me.btnClrImg.Location = New System.Drawing.Point(32, 52)
        Me.btnClrImg.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClrImg.Name = "btnClrImg"
        Me.btnClrImg.Size = New System.Drawing.Size(100, 30)
        Me.btnClrImg.TabIndex = 2
        Me.btnClrImg.Text = "Clear"
        Me.btnClrImg.UseVisualStyleBackColor = False
        '
        'btnImgBrowse
        '
        Me.btnImgBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnImgBrowse.FlatAppearance.BorderSize = 0
        Me.btnImgBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImgBrowse.ForeColor = System.Drawing.Color.White
        Me.btnImgBrowse.Location = New System.Drawing.Point(32, 90)
        Me.btnImgBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImgBrowse.Name = "btnImgBrowse"
        Me.btnImgBrowse.Size = New System.Drawing.Size(100, 30)
        Me.btnImgBrowse.TabIndex = 2
        Me.btnImgBrowse.Text = "Browse"
        Me.btnImgBrowse.UseVisualStyleBackColor = False
        '
        'lblImgName
        '
        Me.lblImgName.Location = New System.Drawing.Point(3, 23)
        Me.lblImgName.Name = "lblImgName"
        Me.lblImgName.Size = New System.Drawing.Size(136, 21)
        Me.lblImgName.TabIndex = 1
        '
        'lblNewsSum
        '
        Me.lblNewsSum.AutoSize = True
        Me.lblNewsSum.Location = New System.Drawing.Point(381, 0)
        Me.lblNewsSum.Name = "lblNewsSum"
        Me.lblNewsSum.Size = New System.Drawing.Size(126, 17)
        Me.lblNewsSum.TabIndex = 1
        Me.lblNewsSum.Text = "News's summary:"
        '
        'lblSelectimg
        '
        Me.lblSelectimg.AutoSize = True
        Me.lblSelectimg.Location = New System.Drawing.Point(3, 0)
        Me.lblSelectimg.Name = "lblSelectimg"
        Me.lblSelectimg.Size = New System.Drawing.Size(136, 17)
        Me.lblSelectimg.TabIndex = 1
        Me.lblSelectimg.Text = "Select news image:"
        '
        'picNewsImg
        '
        Me.picNewsImg.Location = New System.Drawing.Point(145, 3)
        Me.picNewsImg.Name = "picNewsImg"
        Me.picNewsImg.Size = New System.Drawing.Size(202, 118)
        Me.picNewsImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNewsImg.TabIndex = 0
        Me.picNewsImg.TabStop = False
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.flpTagsContainer)
        Me.pnlContent.Controls.Add(Me.btnDeleteNews)
        Me.pnlContent.Controls.Add(Me.btnUpdateNews)
        Me.pnlContent.Controls.Add(Me.btnAdd)
        Me.pnlContent.Controls.Add(Me.btnAddNews)
        Me.pnlContent.Controls.Add(Me.txtTags)
        Me.pnlContent.Controls.Add(Me.btnAddTag)
        Me.pnlContent.Controls.Add(Me.btnVideoBrowse)
        Me.pnlContent.Controls.Add(Me.btnPrintNews)
        Me.pnlContent.Controls.Add(Me.btnClear)
        Me.pnlContent.Controls.Add(Me.txtContent)
        Me.pnlContent.Controls.Add(Me.lblTags)
        Me.pnlContent.Controls.Add(Me.lblVideosSelected)
        Me.pnlContent.Controls.Add(Me.lblVideo)
        Me.pnlContent.Controls.Add(Me.lblContent)
        Me.pnlContent.Location = New System.Drawing.Point(0, 165)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(684, 296)
        Me.pnlContent.TabIndex = 2
        '
        'flpTagsContainer
        '
        Me.flpTagsContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.flpTagsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpTagsContainer.Location = New System.Drawing.Point(384, 87)
        Me.flpTagsContainer.Name = "flpTagsContainer"
        Me.flpTagsContainer.Size = New System.Drawing.Size(286, 70)
        Me.flpTagsContainer.TabIndex = 19
        '
        'btnDeleteNews
        '
        Me.btnDeleteNews.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDeleteNews.FlatAppearance.BorderSize = 0
        Me.btnDeleteNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteNews.ForeColor = System.Drawing.Color.White
        Me.btnDeleteNews.Location = New System.Drawing.Point(540, 216)
        Me.btnDeleteNews.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteNews.Name = "btnDeleteNews"
        Me.btnDeleteNews.Size = New System.Drawing.Size(130, 30)
        Me.btnDeleteNews.TabIndex = 18
        Me.btnDeleteNews.Text = "Delete"
        Me.btnDeleteNews.UseVisualStyleBackColor = False
        '
        'btnUpdateNews
        '
        Me.btnUpdateNews.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnUpdateNews.FlatAppearance.BorderSize = 0
        Me.btnUpdateNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateNews.ForeColor = System.Drawing.Color.White
        Me.btnUpdateNews.Location = New System.Drawing.Point(384, 216)
        Me.btnUpdateNews.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateNews.Name = "btnUpdateNews"
        Me.btnUpdateNews.Size = New System.Drawing.Size(130, 30)
        Me.btnUpdateNews.TabIndex = 17
        Me.btnUpdateNews.Text = "Update"
        Me.btnUpdateNews.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(384, 253)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 30)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnAddNews
        '
        Me.btnAddNews.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddNews.FlatAppearance.BorderSize = 0
        Me.btnAddNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNews.ForeColor = System.Drawing.Color.White
        Me.btnAddNews.Location = New System.Drawing.Point(540, 253)
        Me.btnAddNews.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNews.Name = "btnAddNews"
        Me.btnAddNews.Size = New System.Drawing.Size(130, 30)
        Me.btnAddNews.TabIndex = 16
        Me.btnAddNews.Text = "+ New Post"
        Me.btnAddNews.UseVisualStyleBackColor = False
        '
        'txtTags
        '
        Me.txtTags.Location = New System.Drawing.Point(384, 163)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(179, 25)
        Me.txtTags.TabIndex = 15
        '
        'btnAddTag
        '
        Me.btnAddTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddTag.FlatAppearance.BorderSize = 0
        Me.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTag.ForeColor = System.Drawing.Color.White
        Me.btnAddTag.Location = New System.Drawing.Point(570, 163)
        Me.btnAddTag.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(100, 25)
        Me.btnAddTag.TabIndex = 13
        Me.btnAddTag.Text = "Add Tag"
        Me.btnAddTag.UseVisualStyleBackColor = False
        '
        'btnVideoBrowse
        '
        Me.btnVideoBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnVideoBrowse.FlatAppearance.BorderSize = 0
        Me.btnVideoBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVideoBrowse.ForeColor = System.Drawing.Color.White
        Me.btnVideoBrowse.Location = New System.Drawing.Point(384, 23)
        Me.btnVideoBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVideoBrowse.Name = "btnVideoBrowse"
        Me.btnVideoBrowse.Size = New System.Drawing.Size(100, 30)
        Me.btnVideoBrowse.TabIndex = 13
        Me.btnVideoBrowse.Text = "Browse"
        Me.btnVideoBrowse.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(6, 253)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 30)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Content"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(6, 23)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(341, 223)
        Me.txtContent.TabIndex = 4
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Location = New System.Drawing.Point(381, 67)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(43, 17)
        Me.lblTags.TabIndex = 2
        Me.lblTags.Text = "Tags:"
        '
        'lblVideosSelected
        '
        Me.lblVideosSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVideosSelected.Location = New System.Drawing.Point(491, 23)
        Me.lblVideosSelected.Name = "lblVideosSelected"
        Me.lblVideosSelected.Size = New System.Drawing.Size(179, 30)
        Me.lblVideosSelected.TabIndex = 2
        Me.lblVideosSelected.Text = "No video selected"
        '
        'lblVideo
        '
        Me.lblVideo.AutoSize = True
        Me.lblVideo.Location = New System.Drawing.Point(381, 2)
        Me.lblVideo.Name = "lblVideo"
        Me.lblVideo.Size = New System.Drawing.Size(151, 17)
        Me.lblVideo.TabIndex = 2
        Me.lblVideo.Text = "(Select news's video):"
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(3, 3)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(112, 17)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "News's content:"
        '
        'btnPrintNews
        '
        Me.btnPrintNews.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnPrintNews.FlatAppearance.BorderSize = 0
        Me.btnPrintNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintNews.ForeColor = System.Drawing.Color.White
        Me.btnPrintNews.Location = New System.Drawing.Point(157, 253)
        Me.btnPrintNews.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrintNews.Name = "btnPrintNews"
        Me.btnPrintNews.Size = New System.Drawing.Size(190, 30)
        Me.btnPrintNews.TabIndex = 12
        Me.btnPrintNews.Text = "Print This News"
        Me.btnPrintNews.UseVisualStyleBackColor = False
        '
        'NewsDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewsDetail"
        Me.Size = New System.Drawing.Size(684, 461)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()
        CType(Me.picNewsImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlTitleLine As Panel
    Friend WithEvents txtNewsTitle As TextBox
    Friend WithEvents cbxNewsIndustry As ComboBox
    Friend WithEvents lblNewsIndustry As Label
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents picNewsImg As PictureBox
    Friend WithEvents lblSelectimg As Label
    Friend WithEvents btnImgBrowse As Button
    Friend WithEvents lblImgName As Label
    Friend WithEvents txtNewsSum As TextBox
    Friend WithEvents lblNewsSum As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lblContent As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblVideo As Label
    Friend WithEvents btnVideoBrowse As Button
    Friend WithEvents lblTags As Label
    Friend WithEvents txtTags As TextBox
    Friend WithEvents btnAddTag As Button
    Friend WithEvents btnDeleteNews As Button
    Friend WithEvents btnUpdateNews As Button
    Friend WithEvents btnAddNews As Button
    Friend WithEvents lblVideosSelected As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents flpTagsContainer As FlowLayoutPanel
    Friend WithEvents btnClrImg As Button
    Friend WithEvents btnPrintNews As Button
End Class
