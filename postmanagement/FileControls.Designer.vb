<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileControls
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.txtFileContent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(588, 65)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 25)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnbrowse.FlatAppearance.BorderSize = 0
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Location = New System.Drawing.Point(13, 34)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(83, 25)
        Me.btnbrowse.TabIndex = 9
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(270, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(139, 22)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Txt File Editor"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(102, 34)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(345, 25)
        Me.txtFilePath.TabIndex = 4
        Me.txtFilePath.Text = "File path"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(10, 68)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(78, 17)
        Me.lblFileName.TabIndex = 10
        Me.lblFileName.Text = "File Name:"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(102, 65)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(345, 25)
        Me.txtFileName.TabIndex = 4
        Me.txtFileName.Text = "File name"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(477, 65)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 25)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCreateNew
        '
        Me.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCreateNew.FlatAppearance.BorderSize = 0
        Me.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNew.ForeColor = System.Drawing.Color.White
        Me.btnCreateNew.Location = New System.Drawing.Point(477, 34)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(194, 25)
        Me.btnCreateNew.TabIndex = 9
        Me.btnCreateNew.Text = "+ Create New"
        Me.btnCreateNew.UseVisualStyleBackColor = False
        '
        'txtFileContent
        '
        Me.txtFileContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtFileContent.Location = New System.Drawing.Point(13, 96)
        Me.txtFileContent.Multiline = True
        Me.txtFileContent.Name = "txtFileContent"
        Me.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFileContent.Size = New System.Drawing.Size(658, 349)
        Me.txtFileContent.TabIndex = 11
        '
        'FileControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.txtFileContent)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreateNew)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.txtFilePath)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FileControls"
        Me.Size = New System.Drawing.Size(684, 461)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnbrowse As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblFileName As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents txtFileContent As TextBox
End Class
