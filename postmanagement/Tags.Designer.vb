<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tags
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
        Me.pnlTagsBG = New System.Windows.Forms.Panel()
        Me.btnRemoveTag = New System.Windows.Forms.Button()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.pnlTagsBG.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTagsBG
        '
        Me.pnlTagsBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTagsBG.Controls.Add(Me.btnRemoveTag)
        Me.pnlTagsBG.Controls.Add(Me.lblTag)
        Me.pnlTagsBG.Location = New System.Drawing.Point(0, 0)
        Me.pnlTagsBG.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTagsBG.Name = "pnlTagsBG"
        Me.pnlTagsBG.Size = New System.Drawing.Size(105, 25)
        Me.pnlTagsBG.TabIndex = 0
        '
        'btnRemoveTag
        '
        Me.btnRemoveTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveTag.FlatAppearance.BorderSize = 0
        Me.btnRemoveTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRemoveTag.Location = New System.Drawing.Point(80, 0)
        Me.btnRemoveTag.Name = "btnRemoveTag"
        Me.btnRemoveTag.Size = New System.Drawing.Size(25, 25)
        Me.btnRemoveTag.TabIndex = 1
        Me.btnRemoveTag.Text = "X"
        Me.btnRemoveTag.UseVisualStyleBackColor = True
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblTag.Location = New System.Drawing.Point(5, 5)
        Me.lblTag.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(67, 16)
        Me.lblTag.TabIndex = 0
        Me.lblTag.Text = "#iphone12"
        '
        'Tags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.pnlTagsBG)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Tags"
        Me.Size = New System.Drawing.Size(105, 25)
        Me.pnlTagsBG.ResumeLayout(False)
        Me.pnlTagsBG.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTagsBG As Panel
    Friend WithEvents btnRemoveTag As Button
    Friend WithEvents lblTag As Label
End Class
