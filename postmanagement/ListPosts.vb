Imports Oracle.ManagedDataAccess.Client
Imports System.IO
Public Class ListPosts

    Dim con As New OracleConnection
    Dim oraDB As New OracleDB
    Dim dttable As New DataTable
    Dim logo As Image
    Dim uCtrlNewsDetail As NewsDetail

    Private Sub ListPosts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateItems()
        flpLstPost.HorizontalScroll.Maximum = 0
        flpLstPost.AutoScroll = False
        flpLstPost.VerticalScroll.Visible = False
        flpLstPost.AutoScroll = True
        flpLstPost.AutoScrollMinSize = New Size(flpLstPost.Width, flpLstPost.Height)
    End Sub

    Private Sub GetListPost()

        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader

        Try
            'Get data from Oracle DB
            con = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT ID, TITLE, SUMMARY, CONTENT, IMG, IND_ID, VIDEO FROM M_NEWS"

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

        Dim lstNewsItms() As ListPostsItem

        GetListPost()

        If dttable.Rows.Count <= 0 Then
            lblNoresult.Location = New Point(50, 100)
            lblNoresult.Visible = True
        Else
            lblNoresult.Visible = False
        End If

        ReDim lstNewsItms(dttable.Rows.Count)

        Dim i As Integer = 0
        For Each row As DataRow In dttable.Rows
            lstNewsItms(i) = New ListPostsItem()
            lstNewsItms(i).Name = "NewsItem" & i.ToString
            lstNewsItms(i).newID = Convert.ToInt32(row.Item("ID"))
            lstNewsItms(i).newsTile = row.Item("TITLE").ToString
            lstNewsItms(i).newsSum = row.Item("SUMMARY").ToString
            lstNewsItms(i).newsContent = row.Item("CONTENT").ToString
            lstNewsItms(i).newsIndustry = Convert.ToInt32(row.Item("IND_ID"))

            If Not IsDBNull(row.Item("IMG")) Then

                Dim FS As FileStream
                FS = New FileStream("image.jpg", FileMode.Create)

                Dim blob() As Byte
                blob = Nothing
                blob = row("IMG")
                FS.Write(blob, 0, blob.Length)
                FS.Close()
                FS = Nothing
                Using str As Stream = File.OpenRead("image.jpg")
                    logo = Image.FromStream(str)
                End Using

                lstNewsItms(i).newsImg = logo
            End If

            lstNewsItms(i).Location = New Point(10, i * lstNewsItms(i).Height + 10)

            ' Add to flowlayoutpanel
            flpLstPost.Controls.Add(lstNewsItms(i))

            i += 1

        Next

    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        Try
            For Each ctrl As Control In MainForm.Instance.pContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlNewsDetail = New NewsDetail()
            uCtrlNewsDetail.dId = 0
            uCtrlNewsDetail.dTitle = ""
            uCtrlNewsDetail.dSummary = ""
            uCtrlNewsDetail.dContent = ""
            uCtrlNewsDetail.dImg = Nothing
            uCtrlNewsDetail.dIndustry = 0
            MainForm.Instance.pContainer.Controls.Add(uCtrlNewsDetail)

            MainForm.Instance.pContainer.Controls.Item("NewsDetail").BringToFront()
            MainForm.Instance.BackBtn.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
