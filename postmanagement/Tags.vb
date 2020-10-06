Public Class Tags
    Public Property tagid As Integer
    Public Property tag As String
    Public Property description As String
    Private Sub Tags_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor(5) As Color
        bgColor(0) = Color.FromArgb(254, 249, 231)
        bgColor(1) = Color.FromArgb(252, 243, 207)
        bgColor(2) = Color.FromArgb(249, 231, 159)
        bgColor(3) = Color.FromArgb(247, 220, 111)
        bgColor(4) = Color.FromArgb(255, 255, 192)

        pnlTagsBG.BackColor = bgColor(CInt(Int((5 * Rnd()) + 1)))
        lblTag.Text = tag

        pnlTagsBG.Width = lblTag.Width + btnRemoveTag.Width + 20
        Me.Width = pnlTagsBG.Width

    End Sub

    Private Sub btnRemoveTag_Click(sender As Object, e As EventArgs) Handles btnRemoveTag.Click
        Parent.Tag = tag
        Parent.Controls.Remove(Me)
        Me.Dispose()
    End Sub
End Class
