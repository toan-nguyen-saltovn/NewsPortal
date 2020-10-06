Imports Oracle.ManagedDataAccess.Client
Public Class Users

    Dim con As New OracleConnection
    Dim oraDB As New OracleDB
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResetUser()
        ShowListUser()
    End Sub

#Region "Users"
    Private Sub ShowListUser()

        Dim cmd As New OracleCommand
        Dim dr As OracleDataReader
        Dim dttable As New DataTable

        Try
            'Get data from Oracle DB
            con = oraDB.getConnection()
            oraDB.openConnection()
            Dim query As String
            query = "SELECT ID, USERNAME, PASSWD, DISPLAYNAME, USROLE, STARTDATE, ADDRESS FROM M_USERS"

            cmd = con.CreateCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader
            dttable.Load(dr)
            dgvListUsers.DataSource = dttable
            dr.Close()
            oraDB.closeConnection()

            btnUpdateUser.Enabled = True
            btnDeleteUser.Enabled = True
            btnAddUser.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UserDataControl(sqlStr As String, job As Integer)

        Dim cmd As New OracleCommand
        Dim dttable As New DataTable
        Dim msg As String
        msg = ""
        Try
            con = oraDB.getConnection()
            oraDB.openConnection()

            cmd = con.CreateCommand
            cmd.CommandText = sqlStr
            cmd.CommandType = CommandType.StoredProcedure

            Select Case job
                Case 0
                    msg = "User inserted successfully!"
                    cmd.Parameters.Add("UNAME", OracleDbType.NVarchar2, 40).Value = txtDetailUsername.Text
                    cmd.Parameters.Add("UPASS", OracleDbType.NVarchar2, 40).Value = txtDetailPass.Text
                    cmd.Parameters.Add("UDISP", OracleDbType.NVarchar2, 50).Value = txtDetailDspName.Text
                    cmd.Parameters.Add("UROLE", OracleDbType.Int32, 1).Value = cbxDetailRole.SelectedIndex
                    cmd.Parameters.Add("USTDATE", OracleDbType.Date).Value = dtpStartDate.Value
                    cmd.Parameters.Add("UADD", OracleDbType.NVarchar2, 100).Value = txtDetailAddress.Text
                Case 1
                    msg = "User updated successfully!"
                    cmd.Parameters.Add("UNAME", OracleDbType.NVarchar2, 40).Value = txtDetailUsername.Text
                    cmd.Parameters.Add("UPASS", OracleDbType.NVarchar2, 40).Value = txtDetailPass.Text
                    cmd.Parameters.Add("UDISP", OracleDbType.NVarchar2, 50).Value = txtDetailDspName.Text
                    cmd.Parameters.Add("UROLE", OracleDbType.Int32, 1).Value = cbxDetailRole.SelectedIndex
                    cmd.Parameters.Add("USTDATE", OracleDbType.Date).Value = dtpStartDate.Value
                    cmd.Parameters.Add("UADD", OracleDbType.NVarchar2, 100).Value = txtDetailAddress.Text
                    cmd.Parameters.Add("UID", OracleDbType.Int32).Value = Int32.Parse(dgvListUsers.Item("ID", dgvListUsers.CurrentRow.Index).Value)
                Case 2
                    msg = "User deleted successfully!"
                    cmd.Parameters.Add("UID", OracleDbType.Int32).Value = Int32.Parse(dgvListUsers.Item("ID", dgvListUsers.CurrentRow.Index).Value)
            End Select

            cmd.ExecuteNonQuery()
            MsgBox(msg)
            ShowListUser()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oraDB.closeConnection()
        End Try

    End Sub

    Private Sub ResetUser()
        ' Role combobox initial value setting
        cbxDetailRole.Items.Clear()
        cbxDetailRole.Items.Add("Owner")
        cbxDetailRole.Items.Add("Moderator")
        cbxDetailRole.Items.Add("Standard User")
        cbxDetailRole.Items.Add(" -- Select role -- ")

        txtDetailUsername.Text = ""
        txtDetailPass.Text = ""
        txtDetailDspName.Text = ""
        cbxDetailRole.SelectedIndex = cbxDetailRole.Items.Count - 1
        dtpStartDate.Value = DateTime.Now
        txtDetailAddress.Text = ""
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim queryStr As String
        Try

            'queryStr = "INSERT INTO M_USERS(USERNAME, PASSWD, DISPLAYNAME, USROLE, STARTDATE, ADDRESS) " +
            '           "VALUES(:USER_NAME, :USER_PASS, :USER_DSPNAME, :USER_ROLE, :USER_STARTDATE, :USER_ADDRESS)"

            queryStr = "USP_INSERT_USER"
            UserDataControl(queryStr, 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Dim queryStr As String
        Try

            'queryStr = "UPDATE m_users 
            '            SET
            '                USERNAME = :USER_NAME,
            '                PASSWD = :USER_PASS,
            '                DISPLAYNAME = :USER_DSPNAME,
            '                USROLE = :USER_ROLE,
            '                STARTDATE = :USER_STARTDATE,
            '                ADDRESS = :USER_ADDRESS
            '            WHERE
            '                id = :USER_ID"


            queryStr = "USP_UPDATE_USER"

            UserDataControl(queryStr, 1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim queryStr As String
        Try
            Dim delUserName As String = dgvListUsers.Item("USERNAME", dgvListUsers.CurrentRow.Index).Value.ToString

            Dim rslt As DialogResult = MessageBox.Show(Me, "User " & delUserName & " will permanently delete. Continue?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If rslt = DialogResult.No Then Exit Sub

            'queryStr = "DELETE FROM M_USERS " +
            '           "WHERE ID = :USER_ID"

            queryStr = "USP_DELETE_USER"

            UserDataControl(queryStr, 2)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnResetUser_Click(sender As Object, e As EventArgs) Handles btnResetUser.Click
        ResetUser()
        btnAddUser.Enabled = True
        btnUpdateUser.Enabled = False
        btnDeleteUser.Enabled = False
    End Sub

    Private Sub dgvListUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListUsers.SelectionChanged
        Dim row As Integer
        If dgvListUsers.CurrentRow IsNot Nothing Then
            row = dgvListUsers.CurrentRow.Index
        Else
            row = 0
        End If

        Try

            txtDetailUsername.Text = IIf(IsDBNull(dgvListUsers.Item("USERNAME", row).Value), "", dgvListUsers.Item("USERNAME", row).Value)
            txtDetailPass.Text = IIf(IsDBNull(dgvListUsers.Item("PASSWD", row).Value), "", dgvListUsers.Item("PASSWD", row).Value)
            txtDetailDspName.Text = IIf(IsDBNull(dgvListUsers.Item("DISPLAYNAME", row).Value), "", dgvListUsers.Item("DISPLAYNAME", row).Value)

            If IsDBNull(dgvListUsers.Item("USROLE", row).Value) Then
                cbxDetailRole.SelectedIndex = cbxDetailRole.Items.Count - 1
            Else
                cbxDetailRole.SelectedIndex = Int32.Parse(dgvListUsers.Item("USROLE", row).Value)
            End If

            If IsDBNull(dgvListUsers.Item("STARTDATE", row).Value) Then
                dtpStartDate.Value = Now
            Else
                dtpStartDate.Value = DateTime.Parse(dgvListUsers.Item("STARTDATE", row).Value)
            End If

            txtDetailAddress.Text = IIf(IsDBNull(dgvListUsers.Item("ADDRESS", row).Value), "", dgvListUsers.Item("ADDRESS", row).Value)

            btnUpdateUser.Enabled = True
            btnDeleteUser.Enabled = True
            btnAddUser.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class
