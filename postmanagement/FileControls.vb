Imports System.IO
Public Class FileControls

    Dim filePath As String
    Dim fileDir As String
    Dim fileName As String
    Dim fileContent As String
    Dim fileInfo As FileInfo

    Private Sub FileControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do something
        InitDisp()
    End Sub

    Private Sub InitDisp()
        filePath = ""
        fileName = ""
        fileContent = ""
        fileInfo = Nothing

        txtFilePath.Text = "--No file selected--"
        txtFileName.Text = "--File name here--"
        txtFileContent.Text = "--File content--"

        btnSave.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim fldlg As FileDialog

        Try

            fldlg = New OpenFileDialog()
            ' specify your own initial directory 
            fldlg.InitialDirectory = ":C\"
            ' this will allow onlt those file extensions to be added
            fldlg.Filter = "Image File (*.txt)|*.txt"
            If fldlg.ShowDialog = DialogResult.OK Then

                InitDisp()

                ' get file full path
                filePath = fldlg.FileName
                fileInfo = New FileInfo(filePath)
                ' file directory
                txtFilePath.Text = fileInfo.DirectoryName
                ' file name and extension
                fileName = fileInfo.Name
                txtFileName.Text = fileName

                If filePath.CompareTo("") <> 0 Then
                    LoadFile()
                End If

                btnSave.Enabled = True
                btnDelete.Enabled = True

            End If

            fldlg = Nothing

        Catch ae As ArgumentException
            filePath = ""
            MsgBox(ae.Message)
        End Try
    End Sub

    Private Sub LoadFile()
        Using textReader As New StreamReader(filePath)
            fileContent = textReader.ReadToEnd
        End Using
        txtFileContent.Text = fileContent
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        InitDisp()
        txtFilePath.Text = "Input file location..."
        txtFileName.Text = "Input file name..."
        txtFileContent.Text = "Edit file content"
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            fileDir = txtFilePath.Text
            fileName = txtFileName.Text
            Dim ec As Char
            ec = fileDir(fileDir.Length - 1)
            If ec <> "\" Then fileDir = fileDir & "\"
            filePath = fileDir & fileName

            If filePath.CompareTo("") = 0 Or File.Exists(filePath) = False Then Exit Sub
            fileContent = txtFileContent.Text

            Using writer As StreamWriter = New StreamWriter(filePath)
                writer.Write(fileContent)
            End Using

            MessageBox.Show(Me, " [" & fileName & "] file saved successfully", "File Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message,, "Something went wrong!")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            Dim rslt As DialogResult = MessageBox.Show(Me, " [" & fileName & "] file will permanently delete. Continue?", "File delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If rslt = DialogResult.No Then Exit Sub

            If filePath.CompareTo("") <> 0 And File.Exists(filePath) Then
                File.Delete(filePath)
                fileInfo = Nothing
                MessageBox.Show(Me, " [" & fileName & "] file deleted", "File Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                InitDisp()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
