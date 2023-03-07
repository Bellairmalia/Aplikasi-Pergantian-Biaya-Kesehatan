Public Class Menu_Karyawan
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim Gender As String

    Private Sub Menu_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=PBK_PLN;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from karyawan")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        dgv_Karyawan.DataSource = dst.Tables(0)
        dgv_Karyawan.Refresh()

        dgv_Karyawan.Columns(0).Width = 85
        dgv_Karyawan.Columns(0).HeaderText = "NIP"
        dgv_Karyawan.Columns(1).Width = 180
        dgv_Karyawan.Columns(1).HeaderText = "Nama Karyawan"
        dgv_Karyawan.Columns(2).Width = 180
        dgv_Karyawan.Columns(2).HeaderText = "Grade"
        dgv_Karyawan.Columns(3).Width = 90
        dgv_Karyawan.Columns(3).HeaderText = "No Tel/HP"
        dgv_Karyawan.Columns(4).Width = 100
        dgv_Karyawan.Columns(4).HeaderText = "Jenis Kelamin"
        dgv_Karyawan.Columns(5).Width = 100
        dgv_Karyawan.Columns(5).HeaderText = "Status Karyawan"
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If tb_Nama.Text = "" Or tb_NIP.Text = "" Or tb_Grade.Text = "" Or tb_NoHp.Text = "" Or Gender = "" Or cb_StatusKar.Text = "" Then
            MsgBox("HARAP ISI SEMUA FIELD!!", vbCritical)
            Return
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "insert into karyawan(NIP, nama, grade, no_hp, jenkel, status_kar) values ('" & tb_NIP.Text & "','" & tb_Nama.Text & "','" & tb_Grade.Text & "','" & tb_NoHp.Text & "','" & Gender & "','" & cb_StatusKar.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()
        cmdx = New SqlClient.SqlCommand("select * from karyawan")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_Karyawan.DataSource = dst.Tables(0)
        dgv_Karyawan.Refresh()

        tb_Nama.Clear()
        tb_NIP.Clear()
        tb_Grade.Clear()
        tb_NoHp.Clear()
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If tb_NIP.Text = "" Then
            MsgBox("NIP KARYAWAN HARUS DIISI")
            Exit Sub
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update karyawan set nama ='" & tb_Nama.Text & "', grade ='" & tb_Grade.Text & "', no_hp='" & tb_NoHp.Text & "', jenkel='" & Gender & "', status_kar='" & cb_StatusKar.Text & "' where NIP ='" & tb_NIP.Text & "'"
        cmdx.Connection = cntx
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        Dim cekupdate As String
        cekupdate = MsgBox("UPDATE DATA INI", MsgBoxStyle.Question)
        If cekupdate = vbNo Then Exit Sub

        cmdx = New SqlClient.SqlCommand("Select *from karyawan")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_Karyawan.DataSource = dst.Tables(0)
        dgv_Karyawan.Refresh()

        tb_Nama.Clear()
        tb_NIP.Clear()
        tb_Grade.Clear()
        tb_NoHp.Clear()
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN NIP ATAU NAMA KARYAWAN")
        cmdx = New SqlClient.SqlCommand("select * from karyawan where NIP ='" & cari & "' or nama ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet

        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        tb_NIP.Text = dst.Tables(0).Rows(0)("NIP")
        tb_Nama.Text = dst.Tables(0).Rows(0)("nama")
        tb_Grade.Text = dst.Tables(0).Rows(0)("grade")
        tb_NoHp.Text = dst.Tables(0).Rows(0)("no_hp")
        Gender = dst.Tables(0).Rows(0)("jenkel")
        cb_StatusKar.Text = dst.Tables(0).Rows(0)("status_kar")

        dgv_Karyawan.DataSource = dst.Tables("ketemu")
        dgv_Karyawan.ReadOnly = True
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        If tb_NIP.Text = "" Then
            MsgBox("HARAP ISI NIP KARYAWAN", vbCritical)
            Return
        End If

        cmdx = New SqlClient.SqlCommand("delete from karyawan where NIP='" & tb_NIP.Text & "'")
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        MsgBox("Hapus selesai", MsgBoxStyle.Exclamation)

        cmdx = New SqlClient.SqlCommand("select * from karyawan", cntx)
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_Karyawan.DataSource = dst.Tables(0)
        dgv_Karyawan.Refresh()

        tb_Nama.Clear()
        tb_NIP.Clear()
        tb_Grade.Clear()
        tb_NoHp.Clear()
    End Sub

    Private Sub rb_Laki_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Laki.CheckedChanged
        Gender = "Laki-Laki"
    End Sub

    Private Sub rb_Perempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Perempuan.CheckedChanged
        Gender = "Perempuan"
    End Sub
End Class