Imports Oracle.ManagedDataAccess.Client
Imports System.Configuration
Public Class OracleDB
    Private con As New OracleConnection(ConfigurationManager.ConnectionStrings("oraconnect").ToString())

    ReadOnly Property getConnection() As OracleConnection
        Get
            Return con
        End Get
    End Property

    Sub openConnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Sub closeConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Class
