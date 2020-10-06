Imports Oracle.ManagedDataAccess.Client
Imports System.IO
Public Class Gallery

    Dim imagename As String
    Dim con As New OracleConnection
    Dim oraDB As New OracleDB
    Dim dttable As New DataTable
    Dim gallerySource As Image
    Dim delImgId As Integer = 0

    Private Sub Gallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateItems()

        flpGalleryContainer.HorizontalScroll.Maximum = 0
        flpGalleryContainer.AutoScroll = False
        flpGalleryContainer.VerticalScroll.Visible = False
        flpGalleryContainer.AutoScroll = True
        flpGalleryContainer.AutoScrollMinSize = New Size(flpGalleryContainer.Width, flpGalleryContainer.Height)
    End Sub

    Private Sub GetListGallery()

        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader

        Try
            'Get data from Oracle DB
            con = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT ID, TITLE, IMG_SOURCE FROM M_GALLERY"

            cmd = con.CreateCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader
            dttable.Load(dr)
            dr.Close()

            oraDB.closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub populateItems()

        Dim lstGallery() As GalleryItm

        GetListGallery()

        ReDim lstGallery(dttable.Rows.Count)

        Dim i As Integer = 0
        For Each row As DataRow In dttable.Rows
            lstGallery(i) = New GalleryItm()
            lstGallery(i).Name = "Gallery" & i.ToString
            lstGallery(i).gId = Convert.ToInt32(row.Item("ID"))
            lstGallery(i).gTitle = row.Item("TITLE").ToString

            If Not IsDBNull(row.Item("IMG_SOURCE")) Then

                Dim FS As FileStream
                FS = New FileStream("imgGallery.jpg", FileMode.Create)

                Dim blob() As Byte
                blob = Nothing
                blob = row("IMG_SOURCE")
                FS.Write(blob, 0, blob.Length)
                FS.Close()
                FS = Nothing
                Using str As Stream = File.OpenRead("imgGallery.jpg")
                    gallerySource = Image.FromStream(str)
                End Using

                lstGallery(i).gImage = gallerySource
            End If

            ' Add to flowlayoutpanel
            flpGalleryContainer.Controls.Add(lstGallery(i))

            i += 1

        Next

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click

        Dim fldlg As FileDialog

        Try

            fldlg = New OpenFileDialog()
            ' specify your own initial directory 
            fldlg.InitialDirectory = ":C\"
            ' this will allow onlt those file extensions to be added
            fldlg.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"
            If fldlg.ShowDialog = DialogResult.OK Then
                imagename = fldlg.FileName
                Dim newimg As Bitmap
                newimg = New Bitmap(imagename)
                picImg.SizeMode = PictureBoxSizeMode.StretchImage
                picImg.Image = DirectCast(newimg, Image)
                lblImgPath.Text = imagename
                txtImgTitle.Text = "Gallery"
            End If

            fldlg = Nothing

        Catch ae As ArgumentException
            imagename = " "
            MsgBox(ae.Message)
        End Try
    End Sub

    Private Sub UpdateData()

        Dim cmd As New OracleCommand

        Try
            If imagename <> "" Then
                Dim fls As FileStream
                fls = New FileStream(imagename, FileMode.Open, FileAccess.Read)
                'a byte array to read the image
                Dim blob(fls.Length) As Byte
                fls.Read(blob, 0, Convert.ToInt32(fls.Length))
                fls.Close()

                ' open the database using odp.net And insert the data
                con = oraDB.getConnection()
                oraDB.openConnection()
                Dim query As String

                query = "INSERT INTO M_GALLERY(TITLE, IMG_SOURCE) " +
                       "VALUES(:IMG_TITLE, :IMG_SOURCE)"

                ' insert the byte as oracle parameter of type blob 
                cmd = con.CreateCommand
                cmd.CommandText = query
                cmd.CommandType = CommandType.Text

                cmd.Parameters.Add("IMG_TITLE", OracleDbType.NVarchar2, 100).Value = txtImgTitle.Text
                cmd.Parameters.Add("IMG_SOURCE", OracleDbType.Blob).Value = blob

                Dim n As Integer
                n = cmd.ExecuteNonQuery
                If n > 0 Then
                    MsgBox("Gallery inserted successfully!")

                    ' Add new gallery to layout

                    Dim newGallery As GalleryItm = New GalleryItm()

                    newGallery.Name = "Tags" & CStr(flpGalleryContainer.Controls.Count + 1)
                    newGallery.gId = 0
                    newGallery.gTitle = txtImgTitle.Text
                    newGallery.gImage = picImg.Image

                    flpGalleryContainer.Controls.Add(newGallery)
                    flpGalleryContainer.Refresh()
                    txtImgTitle.Text = "New Gallery title"
                    picImg.Image = Nothing


                End If
                oraDB.closeConnection()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        UpdateData()
    End Sub

    Private Sub btnDelAll_Click(sender As Object, e As EventArgs) Handles btnDelAll.Click
        Dim queryStr As String
        Dim cmd As New OracleCommand
        Dim dttable As New DataTable
        Try
            Dim rslt As DialogResult = MessageBox.Show(Me, "All gallery wil permanently delete. Continue?", "Delete gallery", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If rslt = DialogResult.No Then Exit Sub

            con = oraDB.getConnection()
            oraDB.openConnection()

            queryStr = "DELETE FROM M_GALLERY"

            cmd = con.CreateCommand
            cmd.CommandText = queryStr
            cmd.CommandType = CommandType.Text

            Dim n As Integer
            n = cmd.ExecuteNonQuery
            If n > 0 Then

                flpGalleryContainer.Controls.Clear()

                MsgBox("All gallery deleted successfully")
            End If
            oraDB.closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub flpGalleryContainer_ControlRemoved(sender As Object, e As ControlEventArgs) Handles flpGalleryContainer.ControlRemoved
        delImgId = Convert.ToInt32(flpGalleryContainer.Tag)
        DeleteGallery()
    End Sub
    Private Sub DeleteGallery()
        Dim queryStr As String
        Dim cmd As New OracleCommand
        Dim dttable As New DataTable
        Try
            con = oraDB.getConnection()
            oraDB.openConnection()

            If delImgId > 0 Then
                queryStr = "DELETE FROM M_GALLERY " +
                           "WHERE ID = :IMG_ID"

                cmd = con.CreateCommand
                cmd.CommandText = queryStr
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add("IMG_ID", OracleDbType.Int32).Value = delImgId

                cmd.ExecuteNonQuery()
                delImgId = 0
            End If
            oraDB.closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
