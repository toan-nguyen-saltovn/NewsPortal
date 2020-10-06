Imports Oracle.ManagedDataAccess.Client

Public Class MainForm

    Dim con As New OracleConnection
    Dim oraDB As New OracleDB
    Dim uCtrlUser As Users
    Dim uCtrlLstPosts As ListPosts
    Dim uCtrlGallery As Gallery
    Dim uCtrlIndustry As Industry
    Dim uCtrlLstTag As ListTags
    Dim uCtrlFileControls As FileControls

#Region "Shared property"
    Private Shared _obj As MainForm
    Public Shared Property Instance() As MainForm
        Get
            If _obj Is Nothing Then
                _obj = New MainForm()
            End If
            Return _obj
        End Get
        Set(value As MainForm)
            _obj = value
        End Set
    End Property

    Public Property pContainer As Panel
        Get
            Return pnlContainer
        End Get
        Set(value As Panel)
            pnlContainer = value
        End Set
    End Property

    Public Property BackBtn As Button
        Get
            Return btnBack
        End Get
        Set(value As Button)
            btnBack = value
        End Set
    End Property
#End Region


#Region "MainForm Control"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBtnActive.Height = btnUser.Height
        pnlBtnActive.Top = btnUser.Top

        Try

            btnBack.Visible = False
            _obj = Me

            ' Load Users managerment
            uCtrlUser = New Users()
            pnlContainer.Controls.Add(uCtrlUser)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frmLogin As New LoginForm()
        frmLogin.Show()
        Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        pnlBtnActive.Height = btnUser.Height
        pnlBtnActive.Top = btnUser.Top

        Try

            For Each ctrl As Control In pnlContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlUser = New Users()
            pnlContainer.Controls.Add(uCtrlUser)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnPosts_Click(sender As Object, e As EventArgs) Handles btnPosts.Click
        pnlBtnActive.Height = btnPosts.Height
        pnlBtnActive.Top = btnPosts.Top
        Try

            For Each ctrl As Control In pnlContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlLstPosts = New ListPosts()
            pnlContainer.Controls.Add(uCtrlLstPosts)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIndustry_Click(sender As Object, e As EventArgs) Handles btnIndustry.Click
        pnlBtnActive.Height = btnIndustry.Height
        pnlBtnActive.Top = btnIndustry.Top

        Try

            For Each ctrl As Control In pnlContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlIndustry = New Industry()
            pnlContainer.Controls.Add(uCtrlIndustry)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnTags_Click(sender As Object, e As EventArgs) Handles btnTags.Click
        pnlBtnActive.Height = btnTags.Height
        pnlBtnActive.Top = btnTags.Top
        Try

            For Each ctrl As Control In pnlContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlLstTag = New ListTags()
            pnlContainer.Controls.Add(uCtrlLstTag)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnVideos_Click(sender As Object, e As EventArgs) Handles btnVideos.Click
        pnlBtnActive.Height = btnVideos.Height
        pnlBtnActive.Top = btnVideos.Top
    End Sub

    Private Sub btnGallery_Click(sender As Object, e As EventArgs) Handles btnGallery.Click
        pnlBtnActive.Height = btnGallery.Height
        pnlBtnActive.Top = btnGallery.Top

        Try

            For Each ctrl As Control In pnlContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlGallery = New Gallery()
            pnlContainer.Controls.Add(uCtrlGallery)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFiles_Click(sender As Object, e As EventArgs) Handles btnFiles.Click
        pnlBtnActive.Height = btnFiles.Height
        pnlBtnActive.Top = btnFiles.Top

        Try

            For Each ctrl As Control In pnlContainer.Controls
                ctrl.Dispose()
            Next
            uCtrlFileControls = New FileControls()
            pnlContainer.Controls.Add(uCtrlFileControls)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If con.State = ConnectionState.Open Then oraDB.closeConnection()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Back
        btnBack.Visible = False
        If pnlContainer.Controls.ContainsKey("NewsDetail") Then
            btnPosts.PerformClick()
        End If

    End Sub


#End Region
End Class