Imports Oracle.ManagedDataAccess.Client
Imports System.IO

Public Class NewsDetail

#Region "Properties"
    Public Property dId As Integer = 0
    Public Property dTitle As String = ""
    Public Property dSummary As String = ""
    Public Property dContent As String = ""
    Public Property dImg As Image
    Public Property dImgname As String = ""
    Public Property dIndustry As Integer = 0
    Public Property delTag As String = ""

    Dim conn As New OracleConnection
    Dim oraDB As New OracleDB

    Structure Industry
        Public id As Integer
        Public name As String
    End Structure
    Dim indus() As Industry

    Structure NTags
        Public id As Integer
        Public tag As String
        Public descipt As String
    End Structure
    Dim ntag() As NTags

    Private maxTagID As Integer = 0

#End Region

    Private Sub NewsDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetIndustryList()

        If dId <> 0 Or dTitle.CompareTo("") <> 0 Then
            InitDisp(1)
        Else
            InitDisp(0)
        End If

        maxTagID = GetMaxTagID()

    End Sub

    Private Sub GetIndustryList()
        Try
            Dim cmd As New OracleCommand
            Dim dr As OracleDataReader
            Dim dttable As New DataTable
            Dim qStr As String = ""

            conn = oraDB.getConnection
            oraDB.openConnection()

            qStr = "SELECT ID, IND_NAME FROM M_INDUSTRY"

            cmd = conn.CreateCommand
            cmd.CommandText = qStr
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader
            dttable.Load(dr)
            dr.Close()
            oraDB.closeConnection()

            ReDim indus(dttable.Rows.Count - 1)
            Dim i As Integer = 0
            cbxNewsIndustry.Items.Clear()

            For Each row As DataRow In dttable.Rows
                ' industry info storage
                indus(i).id = Convert.ToInt32(row.Item("ID"))
                indus(i).name = row.Item("IND_NAME").ToString

                'industry list create
                cbxNewsIndustry.Items.Add(indus(i).name)

                i += 1
            Next
            cbxNewsIndustry.Items.Add("-- Select Industry --")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' InitDisp(0:Initial display 1:View detail)
    ''' </summary>
    ''' <param name="mode">0:Initial display 1:View detail</param>
    Private Sub InitDisp(mode As Integer)

        If mode = 1 Then
            txtNewsTitle.Text = dTitle
            txtNewsSum.Text = dSummary
            txtContent.Text = dContent
            If Not dImg Is Nothing Then
                picNewsImg.Image = dImg
            End If

            cbxNewsIndustry.SelectedIndex = cbxNewsIndustry.Items.Count - 1
            For i As Integer = 0 To indus.Length - 1
                If indus(i).id = dIndustry Then
                    cbxNewsIndustry.SelectedIndex = i
                    Exit For
                End If
            Next

            ShowTags()

            btnUpdateNews.Enabled = True
            btnDeleteNews.Enabled = True
            btnAdd.Enabled = False
        Else

            dId = 0
            dTitle = ""
            dSummary = ""
            dContent = ""
            dImg = Nothing
            dImgname = ""
            dIndustry = 0

            txtNewsTitle.Text = "News's title"
            txtNewsSum.Text = "News's summary here"
            txtContent.Text = "News's content"
            cbxNewsIndustry.SelectedIndex = cbxNewsIndustry.Items.Count - 1
            picNewsImg.Image = Nothing
            lblImgName.Text = ""
            lblVideosSelected.Text = ""
            For Each ctr As Control In flpTagsContainer.Controls
                ctr.Dispose()
            Next

            btnUpdateNews.Enabled = False
            btnDeleteNews.Enabled = False
            btnAdd.Enabled = True

        End If

    End Sub

    ''' <summary>
    ''' 0:Insert, 1:Update, 2:Delete News
    ''' </summary>
    ''' <param name="sqlStr"></param>
    ''' <param name="job"></param>
    Private Sub NewsDataControl(sqlStr As String, job As Integer)

        Dim cmd As New OracleCommand
        Dim dttable As New DataTable
        Dim msg As String
        msg = ""
        Try
            conn = oraDB.getConnection()
            oraDB.openConnection()

            cmd = conn.CreateCommand
            cmd.CommandText = sqlStr
            cmd.CommandType = CommandType.Text

            Select Case job
                Case 0
                    msg = "News inserted successfully!"

                    cmd.Parameters.Add("NEWS_TITLE", OracleDbType.NVarchar2, 100).Value = txtNewsTitle.Text
                    cmd.Parameters.Add("NEWS_SUM", OracleDbType.NVarchar2, 1000).Value = txtNewsSum.Text
                    cmd.Parameters.Add("NEWS_CONTENT", OracleDbType.Clob).Value = txtContent.Text

                    ' Convert image to byte
                    If lblImgName.Text <> "" Then
                        Dim fls As FileStream
                        fls = New FileStream(lblImgName.Text, FileMode.Open, FileAccess.Read)
                        'a byte array to read the image
                        Dim blob(fls.Length) As Byte
                        fls.Read(blob, 0, Convert.ToInt32(fls.Length))
                        fls.Close()
                        cmd.Parameters.Add("NEWS_IMG", OracleDbType.Blob).Value = blob
                    Else
                        cmd.Parameters.Add("NEWS_IMG", OracleDbType.Blob).Value = Nothing
                    End If
                    cmd.Parameters.Add("NEWS_INDID", OracleDbType.Int32).Value = indus(cbxNewsIndustry.SelectedIndex).id

                Case 1
                    msg = "News updated successfully!"

                    cmd.Parameters.Add("NEWS_TITLE", OracleDbType.NVarchar2, 100).Value = txtNewsTitle.Text
                    cmd.Parameters.Add("NEWS_SUM", OracleDbType.NVarchar2, 1000).Value = txtNewsSum.Text
                    cmd.Parameters.Add("NEWS_CONTENT", OracleDbType.Clob).Value = txtContent.Text

                    ' Convert image to byte
                    If Not picNewsImg.Image Is Nothing Then

                        Dim cv As ImageConverter = New ImageConverter()
                        Dim imgBlod() As Byte
                        imgBlod = Nothing

                        Dim newimg As Bitmap
                        newimg = New Bitmap(picNewsImg.Image)

                        imgBlod = cv.ConvertTo(newimg, GetType(Byte()))
                        cmd.Parameters.Add("NEWS_IMG", OracleDbType.Blob).Value = imgBlod

                    Else
                        cmd.Parameters.Add("NEWS_IMG", OracleDbType.Blob).Value = Nothing


                    End If

                    cmd.Parameters.Add("NEWS_INDID", OracleDbType.Int32).Value = indus(cbxNewsIndustry.SelectedIndex).id
                    cmd.Parameters.Add("NEWS_ID", OracleDbType.Int32).Value = dId

                Case 2
                    msg = "News deleted successfully!"
                    cmd.Parameters.Add("NEWS_ID", OracleDbType.Int32).Value = dId

            End Select

            ' insert, update news's tags
            If job <> 2 Then InsertUpdateTags(job)

            Dim n As Integer
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox(msg)
                If job = 2 Then InitDisp(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oraDB.closeConnection()
        End Try

    End Sub

    Private Sub ShowTags()
        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim dttable As New DataTable
        Dim lstTags() As Tags

        Try
            'Get data from Oracle DB
            conn = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT T_NEWSTAGS.NEWSID, T_NEWSTAGS.TAGID, M_TAGS.TAG, M_TAGS.DESCRIPTION 
                     FROM T_NEWSTAGS 
                     LEFT OUTER JOIN M_TAGS 
                     ON T_NEWSTAGS.TAGID = M_TAGS.ID 
                     WHERE T_NEWSTAGS.NEWSID = :NEWS_ID"

            cmd = conn.CreateCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("NEWS_ID", OracleDbType.Int32).Value = dId

            dr = cmd.ExecuteReader
            dttable.Load(dr)
            dr.Close()

            ReDim ntag(dttable.Rows.Count - 1)
            ReDim lstTags(dttable.Rows.Count - 1)
            For Each ctr As Control In flpTagsContainer.Controls
                ctr.Dispose()
            Next
            Dim i As Integer = 0
            For Each row As DataRow In dttable.Rows
                ' industry info storage
                ntag(i).id = Convert.ToInt32(row.Item("TAGID"))
                ntag(i).tag = row.Item("TAG").ToString
                ntag(i).descipt = row.Item("DESCRIPTION").ToString

                lstTags(i) = New Tags()
                lstTags(i).Name = "Tags" & i.ToString
                lstTags(i).tagid = ntag(i).id
                lstTags(i).tag = ntag(i).tag
                lstTags(i).description = ntag(i).descipt

                flpTagsContainer.Controls.Add(lstTags(i))

                i += 1
            Next

            flpTagsContainer.HorizontalScroll.Maximum = 0
            flpTagsContainer.AutoScroll = False
            flpTagsContainer.VerticalScroll.Visible = False
            flpTagsContainer.AutoScroll = True
            flpTagsContainer.AutoScrollMinSize = New Size(flpTagsContainer.Width, flpTagsContainer.Height)

            oraDB.closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GetMaxTagID() As Integer
        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim dttable As New DataTable
        Dim returnVal As Integer = 0

        Try
            'Get data from Oracle DB
            conn = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT MAX(ID) FROM M_TAGS"

            cmd = conn.CreateCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                returnVal = Convert.ToInt32(dr.Item(0))
            End If

            dr.Close()
            cmd.Dispose()
            oraDB.closeConnection()

            Return returnVal

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Private Sub InsertUpdateTags(job As Integer)
        Dim cmd As New OracleCommand

        Dim queryStr As String
        Try
            If job = 1 Then
                ' Update mode
                queryStr = "DELETE FROM T_NEWSTAGS " +
                       "WHERE NEWSID = :NEWS_ID"

                cmd = conn.CreateCommand
                cmd.CommandText = queryStr
                cmd.CommandType = CommandType.Text

                cmd.Parameters.Add("NEWS_ID", OracleDbType.Int32).Value = dId
                cmd.ExecuteNonQuery()
            End If

            If ntag.Length > 0 Then
                For i As Integer = 0 To ntag.Length - 1

                    If CheckExistTag(ntag(i).tag) = False Then
                        queryStr = "INSERT INTO M_TAGS(ID, TAG, DESCRIPTION) " +
                           "VALUES(:MTAG_ID, :MTAG_NAME, '')"

                        cmd = conn.CreateCommand
                        cmd.CommandText = queryStr
                        cmd.CommandType = CommandType.Text

                        cmd.Parameters.Add("MTAG_ID", OracleDbType.Int32).Value = ntag(i).id
                        cmd.Parameters.Add("MTAG_NAME", OracleDbType.NVarchar2, 20).Value = ntag(i).tag
                        cmd.ExecuteNonQuery()
                    End If

                    queryStr = "INSERT INTO T_NEWSTAGS(NEWSID, TAGID, TAGNAME) " +
                           "VALUES(:NEWS_ID, :TAG_ID, :TAG_NAME)"

                    cmd = conn.CreateCommand
                    cmd.CommandText = queryStr
                    cmd.CommandType = CommandType.Text

                    cmd.Parameters.Add("NEWS_ID", OracleDbType.Int32).Value = dId
                    cmd.Parameters.Add("TAG_ID", OracleDbType.Int32).Value = ntag(i).id
                    cmd.Parameters.Add("TAG_NAME", OracleDbType.NVarchar2, 20).Value = ntag(i).tag
                    cmd.ExecuteNonQuery()
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddNews_Click(sender As Object, e As EventArgs) Handles btnAddNews.Click
        InitDisp(0)
    End Sub

    Private Sub btnImgBrowse_Click(sender As Object, e As EventArgs) Handles btnImgBrowse.Click
        Dim fldlg As FileDialog

        Try

            fldlg = New OpenFileDialog()
            ' specify your own initial directory 
            fldlg.InitialDirectory = ":C\"
            ' this will allow onlt those file extensions to be added
            fldlg.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"
            If fldlg.ShowDialog = DialogResult.OK Then
                dImgname = fldlg.FileName
                Dim newimg As Bitmap
                newimg = New Bitmap(dImgname)
                picNewsImg.SizeMode = PictureBoxSizeMode.StretchImage
                picNewsImg.Image = DirectCast(newimg, Image)
                lblImgName.Text = dImgname
            End If

            fldlg = Nothing

        Catch ae As ArgumentException
            dImgname = ""
            MsgBox(ae.Message)
        End Try
    End Sub

    Private Sub btnDeleteNews_Click(sender As Object, e As EventArgs) Handles btnDeleteNews.Click

        Dim queryStr As String
        Try
            If dId > 0 Then

                Dim rslt As DialogResult = MessageBox.Show(Me, "This news will permanently delete. Continue?", "Delete news", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

                If rslt = DialogResult.No Then Exit Sub

                queryStr = "DELETE FROM M_NEWS " +
                           "WHERE ID = :NEWS_ID"

                NewsDataControl(queryStr, 2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnUpdateNews_Click(sender As Object, e As EventArgs) Handles btnUpdateNews.Click
        Dim queryStr As String
        Try

            queryStr = "UPDATE M_NEWS 
                        SET
                            TITLE = :NEWS_TITLE,
                            SUMMARY = :NEWS_SUM,
                            CONTENT = :NEWS_CONTENT,
                            IMG = :NEWS_IMG,
                            IND_ID = :NEWS_INDID
                        WHERE
                            ID = :NEWS_ID"


            NewsDataControl(queryStr, 1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim queryStr As String
        Try

            queryStr = "INSERT INTO M_NEWS(TITLE, SUMMARY, CONTENT, IMG, IND_ID) " +
                       "VALUES(:NEWS_TITLE, :NEWS_SUM, :NEWS_CONTENT, :NEWS_IMG, :NEWS_INDID)"

            NewsDataControl(queryStr, 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtContent.Text = ""
    End Sub

    Private Sub btnAddTag_Click(sender As Object, e As EventArgs) Handles btnAddTag.Click


        If txtTags.Text.CompareTo("") = 0 Then Exit Sub

        If ntag.Length > 0 Then
            For i As Integer = 0 To ntag.Length - 1
                If txtTags.Text.CompareTo(ntag(i).tag) = 0 Then
                    MessageBox.Show(Me, "Tags existed", "Tags", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
        End If

        Array.Resize(Of NTags)(ntag, ntag.Length + 1)

        maxTagID = maxTagID + 1
        ntag(ntag.Length - 1).id = maxTagID
        ntag(ntag.Length - 1).tag = txtTags.Text
        ntag(ntag.Length - 1).descipt = ""

        Dim newTag As Tags = New Tags()

        newTag.Name = "Tags" & CStr(flpTagsContainer.Controls.Count + 1)
        newTag.tagid = maxTagID
        newTag.tag = ntag(ntag.Length - 1).tag
        newTag.description = ""

        flpTagsContainer.Controls.Add(newTag)
        flpTagsContainer.Refresh()
        txtTags.Text = ""

    End Sub

    Private Sub txtTags_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTags.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddTag.PerformClick()
        End If
    End Sub

    Private Sub btnClrImg_Click(sender As Object, e As EventArgs) Handles btnClrImg.Click
        picNewsImg.Image = Nothing
    End Sub

    Public Sub RemoveAt(Of T)(ByRef arr As T(), ByVal index As Integer)
        Dim uBound = arr.GetUpperBound(0)
        Dim lBound = arr.GetLowerBound(0)
        Dim arrLen = uBound - lBound

        If index < lBound OrElse index > uBound Then
            Throw New ArgumentOutOfRangeException(
            String.Format("Index must be from {0} to {1}.", lBound, uBound))

        Else
            'create an array 1 element less than the input array
            Dim outArr(arrLen - 1) As T
            'copy the first part of the input array
            Array.Copy(arr, 0, outArr, 0, index)
            'then copy the second part of the input array
            Array.Copy(arr, index + 1, outArr, index, uBound - index)

            arr = outArr
        End If
    End Sub

    Private Sub flpTagsContainer_ControlRemoved(sender As Object, e As ControlEventArgs) Handles flpTagsContainer.ControlRemoved
        delTag = flpTagsContainer.Tag.ToString
        For i As Integer = 0 To ntag.Length - 1
            If ntag(i).tag.CompareTo(delTag) = 0 Then
                RemoveAt(Of NTags)(ntag, i)
                Exit Sub
            End If
        Next
    End Sub

    Private Function CheckExistTag(tagN As String) As Boolean
        Dim result As Boolean = False
        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim query As String
        query = "SELECT * FROM M_TAGS WHERE TAG = :TAG"

        cmd = conn.CreateCommand
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("TAG", OracleDbType.NVarchar2, 20).Value = tagN
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            result = True
        End If

        dr.Close()
        cmd.Dispose()

        Return result
    End Function

    Private Sub btnPrintNews_Click(sender As Object, e As EventArgs) Handles btnPrintNews.Click
        ' Print news

    End Sub
End Class
