Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class frmMySQL_Con
    Dim MySQLConn As MySqlConnection

    Private Sub btnCheck_Conn_Click(sender As Object, e As EventArgs) Handles btnCheck_Conn.Click
        MySQLConn = New MySqlConnection

        MySQLConn.ConnectionString = ConfigurationManager.AppSettings("MySQLConn")

        Try
            MySQLConn.Open()
            MessageBox.Show("Connection Success")
            MySQLConn.Clone()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class