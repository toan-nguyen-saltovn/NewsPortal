<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gallery
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
        Me.txtImgTitle = New System.Windows.Forms.TextBox()
        Me.lblImgTitle = New System.Windows.Forms.Label()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.flpGalleryContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblImgPath = New System.Windows.Forms.Label()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtImgTitle
        '
        Me.txtImgTitle.Location = New System.Drawing.Point(108, 351)
        Me.txtImgTitle.Name = "txtImgTitle"
        Me.txtImgTitle.Size = New System.Drawing.Size(345, 25)
        Me.txtImgTitle.TabIndex = 0
        Me.txtImgTitle.Text = "Image title here"
        '
        'lblImgTitle
        '
        Me.lblImgTitle.AutoSize = True
        Me.lblImgTitle.Location = New System.Drawing.Point(20, 354)
        Me.lblImgTitle.Name = "lblImgTitle"
        Me.lblImgTitle.Size = New System.Drawing.Size(82, 17)
        Me.lblImgTitle.TabIndex = 1
        Me.lblImgTitle.Text = "Image Title:"
        '
        'picImg
        '
        Me.picImg.Location = New System.Drawing.Point(469, 351)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(195, 98)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImg.TabIndex = 2
        Me.picImg.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnbrowse.FlatAppearance.BorderSize = 0
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Location = New System.Drawing.Point(192, 417)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(83, 30)
        Me.btnbrowse.TabIndex = 3
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(281, 417)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(83, 30)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnDelAll
        '
        Me.btnDelAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelAll.FlatAppearance.BorderSize = 0
        Me.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAll.ForeColor = System.Drawing.Color.White
        Me.btnDelAll.Location = New System.Drawing.Point(370, 417)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(83, 30)
        Me.btnDelAll.TabIndex = 3
        Me.btnDelAll.Text = "Delete all"
        Me.btnDelAll.UseVisualStyleBackColor = False
        '
        'flpGalleryContainer
        '
        Me.flpGalleryContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.flpGalleryContainer.Location = New System.Drawing.Point(0, 0)
        Me.flpGalleryContainer.Name = "flpGalleryContainer"
        Me.flpGalleryContainer.Size = New System.Drawing.Size(684, 340)
        Me.flpGalleryContainer.TabIndex = 4
        '
        'lblImgPath
        '
        Me.lblImgPath.Location = New System.Drawing.Point(108, 379)
        Me.lblImgPath.Name = "lblImgPath"
        Me.lblImgPath.Size = New System.Drawing.Size(345, 35)
        Me.lblImgPath.TabIndex = 1
        Me.lblImgPath.Text = "Path of image"
        '
        'Gallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.flpGalleryContainer)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.picImg)
        Me.Controls.Add(Me.lblImgPath)
        Me.Controls.Add(Me.lblImgTitle)
        Me.Controls.Add(Me.txtImgTitle)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Gallery"
        Me.Size = New System.Drawing.Size(684, 461)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtImgTitle As TextBox
    Friend WithEvents lblImgTitle As Label
    Friend WithEvents picImg As PictureBox
    Friend WithEvents btnbrowse As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnDelAll As Button
    Friend WithEvents flpGalleryContainer As FlowLayoutPanel
    Friend WithEvents lblImgPath As Label
End Class
