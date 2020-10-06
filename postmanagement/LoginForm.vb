Imports Oracle.ManagedDataAccess.Client
Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial control

    End Sub

    Private Sub chbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chbShowPass.CheckedChanged

        If txtPass.UseSystemPasswordChar Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim oraDb As New OracleDB
        Dim adapter As New OracleDataAdapter
        Dim datatable As New DataTable()
        Dim cmd As OracleCommand

        Try
            oraDb.openConnection()

            Dim query As String
            query = "SELECT * FROM M_USERS WHERE USERNAME = '" + txtUsername.Text + "' AND PASSWD = '" + txtPass.Text + "'"

            cmd = New OracleCommand(query, oraDb.getConnection)

            adapter.SelectCommand = cmd
            adapter.Fill(datatable)

            If datatable.Rows.Count > 0 Then

                Dim frmMain As New MainForm()
                frmMain.Show()
                Close()
            Else
                MsgBox("Invalid username or password", MsgBoxStyle.Critical, "Login Error")
            End If

            oraDb.closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class