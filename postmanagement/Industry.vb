Imports Oracle.ManagedDataAccess.Client
Public Class Industry

    Dim con As New OracleConnection
    Dim oraDB As New OracleDB

    Private Sub Industry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetIndus()
        ShowListIndus()
    End Sub

    Private Sub ShowListIndus()

        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim dttable As New DataTable

        Try
            'Get data from Oracle DB
            con = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT ID, IND_NAME FROM M_INDUSTRY"

            cmd = con.CreateCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader
            dttable.Load(dr)
            dgvListIndustry.DataSource = dttable
            dr.Close()
            oraDB.closeConnection()

            'Button Enable/Disable
            btnAddIdus.Enabled = False
            If dttable.Rows.Count <= 0 Then
                btnUpdateIndus.Enabled = False
                btnDeleteIndus.Enabled = False
            Else
                btnUpdateIndus.Enabled = True
                btnDeleteIndus.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ResetIndus()
        txtIndID.Text = ""
        txtIndName.Text = ""
    End Sub

    Private Sub IndustryDataControl(sqlStr As String, job As Integer)

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
                    msg = "Industry inserted successfully!"
                    cmd.Parameters.Add("IND_NAME", OracleDbType.NVarchar2, 50).Value = txtIndName.Text
                Case 1
                    msg = "Industry updated successfully!"
                    cmd.Parameters.Add("IND_NAME", OracleDbType.NVarchar2, 50).Value = txtIndName.Text
                    cmd.Parameters.Add("IND_ID", OracleDbType.Int32).Value = Int32.Parse(txtIndID.Text)
                Case 2
                    msg = "Industry deleted successfully!"
                    cmd.Parameters.Add("IND_ID", OracleDbType.Int32).Value = Int32.Parse(txtIndID.Text)
            End Select

            Dim n As Integer
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox(msg)
                ShowListIndus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oraDB.closeConnection()
        End Try

    End Sub

    Private Sub btnAddIdus_Click(sender As Object, e As EventArgs) Handles btnAddIdus.Click
        Dim queryStr As String
        Try

            queryStr = "INSERT INTO M_INDUSTRY(IND_NAME) " +
                       "VALUES(:IND_NAME)"

            IndustryDataControl(queryStr, 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateIndus_Click(sender As Object, e As EventArgs) Handles btnUpdateIndus.Click
        Dim queryStr As String
        Try

            queryStr = "UPDATE M_INDUSTRY 
                        SET
                            IND_NAME = :IND_NAME
                        WHERE
                            ID = :IND_ID"


            IndustryDataControl(queryStr, 1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteIndus_Click(sender As Object, e As EventArgs) Handles btnDeleteIndus.Click
        Dim queryStr As String
        Try
            Dim delIndName As String = dgvListIndustry.Item("IND_NAME", dgvListIndustry.CurrentRow.Index).Value.ToString

            Dim rslt As DialogResult = MessageBox.Show(Me, "Industry " & delIndName & " will permanently delete. Continue?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If rslt = DialogResult.No Then Exit Sub

            queryStr = "DELETE FROM M_INDUSTRY " +
                       "WHERE ID = :IND_ID"

            IndustryDataControl(queryStr, 2)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnResetIndus_Click(sender As Object, e As EventArgs) Handles btnResetIndus.Click
        ResetIndus()
        btnAddIdus.Enabled = True
        btnUpdateIndus.Enabled = False
        btnDeleteIndus.Enabled = False
    End Sub

    Private Sub dgvListIndustry_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListIndustry.SelectionChanged
        Dim row As Integer
        If dgvListIndustry.CurrentRow IsNot Nothing Then
            row = dgvListIndustry.CurrentRow.Index
        Else
            row = 0
        End If

        Try
            txtIndID.Text = dgvListIndustry.Item("ID", row).Value.ToString
            txtIndName.Text = dgvListIndustry.Item("IND_NAME", row).Value.ToString
            btnUpdateIndus.Enabled = True
            btnDeleteIndus.Enabled = True
            btnAddIdus.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
