Imports System.ComponentModel
Imports Oracle.ManagedDataAccess.Client

Public Class ListPostsItem

#Region "Porperties and variable"

    Public Property newID As Integer
    Public Property imgBack As String
    Public Property newsTile As String
    Public Property newsSum As String
    Public Property newsContent As String
    Public Property newsImg As Image
    Public Property newsIndustry As Integer

    Dim con As New OracleConnection
    Dim oraBD As New OracleDB

    Dim uCtrlNewsDetail As NewsDetail


#End Region

#Region "Control"
    Private Sub ListPostsItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Innitial display
        If Not picNewsImg.Image Is Nothing Then
            picNewsImg.Image.Dispose()
        End If
        picNewsImg.Image = newsImg
        lblNewsItmTitle.Text = newsTile
        lblNewsItmSum.Text = newsSum

    End Sub

    Private Sub btnDelNewsItm_Click(sender As Object, e As EventArgs) Handles btnDelNewsItm.Click

        Dim cmd As New OracleCommand

        Dim queryStr As String
        Try

            Dim rslt As DialogResult = MessageBox.Show(Me, "News will permanently delete. Continue?", "Delete news", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If rslt = DialogResult.No Then Exit Sub

            con = oraBD.getConnection()
            oraBD.openConnection()
            queryStr = "DELETE FROM M_NEWS " +
                       "WHERE ID = :NEWS_ID"

            cmd = con.CreateCommand
            cmd.CommandText = queryStr
            cmd.CommandType = CommandType.Text

            cmd.Parameters.Add("NEWS_ID", OracleDbType.Int32).Value = newID

            Dim n As Integer
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox("News has been deleted successfully!")
                Parent.Controls.Remove(Me)
                Me.Dispose()
            End If

            oraBD.closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnDetailView_Click(sender As Object, e As EventArgs) Handles btnDetailView.Click
        Try
            ' Load News Detail
            'If Not MainForm.Instance.pContainer.Controls.ContainsKey("NewsDetail") Then

            '    uCtrlNewsDetail = New NewsDetail()
            '    MainForm.Instance.pContainer.Controls.Add(uCtrlNewsDetail)

            'End If

            For Each ctrl As Control In MainForm.Instance.pContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlNewsDetail = New NewsDetail()
            uCtrlNewsDetail.dId = newID
            uCtrlNewsDetail.dTitle = newsTile
            uCtrlNewsDetail.dSummary = newsSum
            uCtrlNewsDetail.dContent = newsContent
            If Not newsImg Is Nothing Then uCtrlNewsDetail.dImg = newsImg
            uCtrlNewsDetail.dIndustry = newsIndustry
            MainForm.Instance.pContainer.Controls.Add(uCtrlNewsDetail)

            MainForm.Instance.pContainer.Controls.Item("NewsDetail").BringToFront()
            MainForm.Instance.BackBtn.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



#End Region

End Class
