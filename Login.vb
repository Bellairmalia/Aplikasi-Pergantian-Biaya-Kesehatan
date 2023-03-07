Imports System.Data.SqlClient
Public Class Login

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim drLogin As SqlDataReader
        Dim CMDLogin As SqlCommand
        Dim cntx As SqlClient.SqlConnection
        Dim SQL As String
        'koneksi ke database
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=PBK_PLN;integrated security= true"
        cntx.Open()

        SQL = "Select *From users " + " WHERE username = '" & UsernameTextBox.Text & "' " + " and password = '" & PasswordTextBox.Text & "'"
        CMDLogin = New SqlCommand
        CMDLogin.CommandType = CommandType.Text
        CMDLogin.Connection = cntx
        CMDLogin.CommandText = SQL

        drLogin = CMDLogin.ExecuteReader()
        If drLogin.HasRows Then

            Index.Show()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        Else
            MsgBox("Nama User atau Password salah", +vbCritical, "Password Salah")
        End If
        cntx.Close()
        CMDLogin.Dispose()
        drLogin.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
