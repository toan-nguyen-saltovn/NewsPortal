<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPostsItem
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
        Me.picNewsImg = New System.Windows.Forms.PictureBox()
        Me.lblNewsItmTitle = New System.Windows.Forms.Label()
        Me.lblNewsItmSum = New System.Windows.Forms.Label()
        Me.btnDelNewsItm = New System.Windows.Forms.Button()
        Me.btnDetailView = New System.Windows.Forms.Button()
        CType(Me.picNewsImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picNewsImg
        '
        Me.picNewsImg.Location = New System.Drawing.Point(10, 10)
        Me.picNewsImg.Margin = New System.Windows.Forms.Padding(0)
        Me.picNewsImg.Name = "picNewsImg"
        Me.picNewsImg.Size = New System.Drawing.Size(130, 80)
        Me.picNewsImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNewsImg.TabIndex = 0
        Me.picNewsImg.TabStop = False
        '
        'lblNewsItmTitle
        '
        Me.lblNewsItmTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewsItmTitle.Location = New System.Drawing.Point(153, 10)
        Me.lblNewsItmTitle.Name = "lblNewsItmTitle"
        Me.lblNewsItmTitle.Size = New System.Drawing.Size(340, 20)
        Me.lblNewsItmTitle.TabIndex = 1
        Me.lblNewsItmTitle.Text = "This is title of the news item"
        '
        'lblNewsItmSum
        '
        Me.lblNewsItmSum.Location = New System.Drawing.Point(154, 30)
        Me.lblNewsItmSum.Name = "lblNewsItmSum"
        Me.lblNewsItmSum.Size = New System.Drawing.Size(339, 60)
        Me.lblNewsItmSum.TabIndex = 2
        Me.lblNewsItmSum.Text = "Label1"
        '
        'btnDelNewsItm
        '
        Me.btnDelNewsItm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelNewsItm.FlatAppearance.BorderSize = 0
        Me.btnDelNewsItm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelNewsItm.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelNewsItm.ForeColor = System.Drawing.Color.White
        Me.btnDelNewsItm.Location = New System.Drawing.Point(499, 10)
        Me.btnDelNewsItm.Name = "btnDelNewsItm"
        Me.btnDelNewsItm.Size = New System.Drawing.Size(80, 35)
        Me.btnDelNewsItm.TabIndex = 3
        Me.btnDelNewsItm.Text = "Delete"
        Me.btnDelNewsItm.UseVisualStyleBackColor = False
        '
        'btnDetailView
        '
        Me.btnDetailView.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnDetailView.FlatAppearance.BorderSize = 0
        Me.btnDetailView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetailView.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetailView.ForeColor = System.Drawing.Color.White
        Me.btnDetailView.Location = New System.Drawing.Point(499, 55)
        Me.btnDetailView.Name = "btnDetailView"
        Me.btnDetailView.Size = New System.Drawing.Size(80, 35)
        Me.btnDetailView.TabIndex = 3
        Me.btnDetailView.Text = "Detail"
        Me.btnDetailView.UseVisualStyleBackColor = False
        '
        'ListPostsItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnDetailView)
        Me.Controls.Add(Me.btnDelNewsItm)
        Me.Controls.Add(Me.lblNewsItmSum)
        Me.Controls.Add(Me.lblNewsItmTitle)
        Me.Controls.Add(Me.picNewsImg)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(50, 4, 4, 4)
        Me.Name = "ListPostsItem"
        Me.Size = New System.Drawing.Size(588, 98)
        CType(Me.picNewsImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picNewsImg As PictureBox
    Friend WithEvents lblNewsItmTitle As Label
    Friend WithEvents lblNewsItmSum As Label
    Friend WithEvents btnDelNewsItm As Button
    Friend WithEvents btnDetailView As Button
End Class
