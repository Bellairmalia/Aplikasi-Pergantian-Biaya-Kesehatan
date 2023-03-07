Public Class Menu_User
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub Menu_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=PBK_PLN;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from users")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        tb_IDUser.Enabled = False

        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            tb_IDUser.Text = "U" + "0001"
        Else
            tb_IDUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(tb_IDUser.Text) = 1 Then
                tb_IDUser.Text = "U000" & tb_IDUser.Text & ""
            ElseIf Len(tb_IDUser.Text) = 2 Then
                tb_IDUser.Text = "U00" & tb_IDUser.Text & ""
            ElseIf Len(tb_IDUser.Text) = 3 Then
                tb_IDUser.Text = "U0" & tb_IDUser.Text & ""
            End If
        End If
        dr.Close()

        dgv_User.DataSource = dst.Tables(0)
        dgv_User.Refresh()

        dgv_User.Columns(0).Width = 100
        dgv_User.Columns(0).HeaderText = "ID User"
        dgv_User.Columns(1).Width = 150
        dgv_User.Columns(1).HeaderText = "Nama User"
        dgv_User.Columns(2).Width = 150
        dgv_User.Columns(2).HeaderText = "Username"
        dgv_User.Columns(3).Width = 110
        dgv_User.Columns(3).HeaderText = "Password"

    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If tb_NamaUser.Text = "" Or tb_Username.Text = "" Or tb_Password.Text = "" Then
            MsgBox("HARAP ISI NAMA USER, USERNAME, DAN PASSWORD!!", vbCritical)
            Return
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into users(id_user, nama_user, username, password ) values ('" & tb_IDUser.Text & "','" & tb_NamaUser.Text & "','" & tb_Username.Text & "','" & tb_Password.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()
        cmdx = New SqlClient.SqlCommand("select * from users")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_User.DataSource = dst.Tables(0)
        dgv_User.Refresh()

        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            tb_IDUser.Text = "U" + "0001"
        Else
            tb_IDUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(tb_IDUser.Text) = 1 Then
                tb_IDUser.Text = "U000" & tb_IDUser.Text & ""
            ElseIf Len(tb_IDUser.Text) = 2 Then
                tb_IDUser.Text = "U00" & tb_IDUser.Text & ""
            ElseIf Len(tb_IDUser.Text) = 3 Then
                tb_IDUser.Text = "U0" & tb_IDUser.Text & ""
            End If
        End If
        dr.Close()

        tb_NamaUser.Clear()
        tb_Username.Clear()
        tb_Password.Clear()
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If tb_IDUser.Text = "" Then
            MsgBox("ID USER HARUS DIISI")
            Exit Sub
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update users set nama_user ='" & tb_NamaUser.Text & "', username ='" & tb_Username.Text & "', password ='" & tb_Password.Text & "' where id_user ='" & tb_IDUser.Text & "'"
        cmdx.Connection = cntx
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        Dim cekupdate As String
        cekupdate = MsgBox("UPDATE DATA INI", MsgBoxStyle.Question)
        If cekupdate = vbNo Then Exit Sub

        cmdx = New SqlClient.SqlCommand("Select *from users")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_User.DataSource = dst.Tables(0)
        dgv_User.Refresh()

        tb_NamaUser.Clear()
        tb_Username.Clear()
        tb_Password.Clear()
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN ID USER ATAU NAMA USER")
        cmdx = New SqlClient.SqlCommand("select * from users where id_user ='" & cari & "' or nama_user='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet

        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        tb_IDUser.Text = dst.Tables(0).Rows(0)("id_user")
        tb_NamaUser.Text = dst.Tables(0).Rows(0)("nama_user")
        tb_Username.Text = dst.Tables(0).Rows(0)("username")
        tb_Password.Text = dst.Tables(0).Rows(0)("password")
    
        dgv_User.DataSource = dst.Tables("ketemu")
        dgv_User.ReadOnly = True
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        If tb_IDUser.Text = "" Then
            MsgBox("HARAP CARI ID USER", vbCritical)
            Return
        End If

        cmdx = New SqlClient.SqlCommand("delete from users where id_user='" & tb_IDUser.Text & "'")
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        MsgBox("Hapus selesai", MsgBoxStyle.Exclamation)

        cmdx = New SqlClient.SqlCommand("select * from users", cntx)
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_User.DataSource = dst.Tables(0)
        dgv_User.Refresh()

        cmd = New SqlClient.SqlCommand("select *from users order by id_user desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            tb_IDUser.Text = "U" + "0001"
        Else
            tb_IDUser.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_user").ToString, 4, 3)) + 1
            If Len(tb_IDUser.Text) = 1 Then
                tb_IDUser.Text = "U000" & tb_IDUser.Text & ""
            ElseIf Len(tb_IDUser.Text) = 2 Then
                tb_IDUser.Text = "U00" & tb_IDUser.Text & ""
            ElseIf Len(tb_IDUser.Text) = 3 Then
                tb_IDUser.Text = "U0" & tb_IDUser.Text & ""
            End If
        End If
        dr.Close()

        tb_NamaUser.Clear()
        tb_Username.Clear()
        tb_Password.Clear()
    End Sub
End Class