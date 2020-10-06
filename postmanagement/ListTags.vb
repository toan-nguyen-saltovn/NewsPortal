Imports Oracle.ManagedDataAccess.Client

Public Class ListTags

    Dim con As New OracleConnection
    Dim oraDB As New OracleDB
    Private maxTagID As Integer = 0

    Private Sub ListTags_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetTag()
        ShowListTags()
    End Sub

    Private Sub ShowListTags()

        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim dttable As New DataTable

        Try
            'Get data from Oracle DB
            con = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT ID, TAG, DESCRIPTION FROM M_TAGS"

            cmd = con.CreateCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader
            dttable.Load(dr)
            dgvListTag.DataSource = dttable
            dr.Close()
            oraDB.closeConnection()

            'Button Enable/Disable
            btnAddTag.Enabled = False
            If dttable.Rows.Count <= 0 Then
                btnUpdateTag.Enabled = False
                btnDeleteTag.Enabled = False
            Else
                btnUpdateTag.Enabled = True
                btnDeleteTag.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ResetTag()
        txtTagID.Text = ""
        txtTag.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub TagDataControl(sqlStr As String, job As Integer)

        Dim cmd As New OracleCommand
        Dim dttable As New DataTable
        Dim msg As String
        msg = ""
        Try
            con = oraDB.getConnection()
            oraDB.openConnection()

            cmd = con.CreateCommand
            cmd.CommandText = sqlStr
            cmd.CommandType = CommandType.Text

            Select Case job
                Case 0
                    msg = "Tag inserted successfully!"
                    cmd.Parameters.Add("TAG_ID", OracleDbType.Int32).Value = Int32.Parse(maxTagID + 1)
                    cmd.Parameters.Add("TAG_N", OracleDbType.NVarchar2, 20).Value = txtTag.Text
                    cmd.Parameters.Add("TAG_DES", OracleDbType.NVarchar2, 500).Value = txtDescription.Text
                Case 1
                    msg = "Tag updated successfully!"
                    cmd.Parameters.Add("TAG_N", OracleDbType.NVarchar2, 20).Value = txtTag.Text
                    cmd.Parameters.Add("TAG_DES", OracleDbType.NVarchar2, 500).Value = txtDescription.Text
                    cmd.Parameters.Add("TAG_ID", OracleDbType.Int32).Value = Int32.Parse(txtTagID.Text)
                Case 2
                    msg = "Tag deleted successfully!"
                    cmd.Parameters.Add("TAG_ID", OracleDbType.Int32).Value = Int32.Parse(txtTagID.Text)
            End Select

            Dim n As Integer
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox(msg)
                ShowListTags()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oraDB.closeConnection()
        End Try

    End Sub

    Private Function GetMaxTagID() As Integer
        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim dttable As New DataTable
        Dim returnVal As Integer = 0

        Try
            'Get data from Oracle DB
            con = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT MAX(ID) FROM M_TAGS"

            cmd = con.CreateCommand
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


    Private Sub btnAddTag_Click(sender As Object, e As EventArgs) Handles btnAddTag.Click
        Dim queryStr As String
        Try

            queryStr = "INSERT INTO M_TAGS(ID, TAG, DESCRIPTION) " +
                       "VALUES(:TAG_ID, :TAG_N, :TAG_DES)"

            maxTagID = GetMaxTagID()

            TagDataControl(queryStr, 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateTag_Click(sender As Object, e As EventArgs) Handles btnUpdateTag.Click
        Dim queryStr As String
        Try

            queryStr = "UPDATE M_TAGS 
                        SET
                            TAG = :TAG_N,
                            DESCRIPTION = :TAG_DES 
                        WHERE
                            ID = :TAG_ID"


            TagDataControl(queryStr, 1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteTag_Click(sender As Object, e As EventArgs) Handles btnDeleteTag.Click
        Dim queryStr As String
        Try
            Dim delTag As String = dgvListTag.Item("TAG", dgvListTag.CurrentRow.Index).Value.ToString

            Dim rslt As DialogResult = MessageBox.Show(Me, "Tag " & delTag & " will permanently delete. Continue?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If rslt = DialogResult.No Then Exit Sub

            queryStr = "DELETE FROM M_TAGS " +
                       "WHERE ID = :TAG_ID"

            TagDataControl(queryStr, 2)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCreateTag_Click(sender As Object, e As EventArgs) Handles btnCreateTag.Click
        ResetTag()
        btnAddTag.Enabled = True
        btnUpdateTag.Enabled = False
        btnDeleteTag.Enabled = False
    End Sub

    Private Sub dgvListTag_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListTag.SelectionChanged
        Dim row As Integer
        If dgvListTag.CurrentRow IsNot Nothing Then
            row = dgvListTag.CurrentRow.Index
        Else
            row = 0
        End If

        Try
            txtTagID.Text = dgvListTag.Item("ID", row).Value.ToString
            txtTag.Text = dgvListTag.Item("TAG", row).Value.ToString
            txtDescription.Text = dgvListTag.Item("DESCRIPTION", row).Value.ToString

            btnUpdateTag.Enabled = True
            btnDeleteTag.Enabled = True
            btnAddTag.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
