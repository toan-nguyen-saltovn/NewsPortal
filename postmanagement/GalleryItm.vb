Public Class GalleryItm

    Public Property gId As Integer
    Public Property gTitle As String
    Public Property gImage As Image

    Private Sub GalleryItm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Innitial display
        If Not picImg.Image Is Nothing Then
            picImg.Image.Dispose()
        End If
        picImg.Image = gImage
        picImg.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Parent.Tag = gId.ToString
        Parent.Controls.Remove(Me)
        Me.Dispose()
    End Sub
End Class
