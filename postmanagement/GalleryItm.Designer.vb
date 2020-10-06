<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GalleryItm
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
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.btnDel = New System.Windows.Forms.Button()
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImg
        '
        Me.picImg.BackColor = System.Drawing.SystemColors.Window
        Me.picImg.Location = New System.Drawing.Point(0, 0)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(195, 110)
        Me.picImg.TabIndex = 0
        Me.picImg.TabStop = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.Window
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDel.Location = New System.Drawing.Point(170, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(25, 25)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "X"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'GalleryItm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.picImg)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GalleryItm"
        Me.Size = New System.Drawing.Size(195, 110)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picImg As PictureBox
    Friend WithEvents btnDel As Button
End Class
