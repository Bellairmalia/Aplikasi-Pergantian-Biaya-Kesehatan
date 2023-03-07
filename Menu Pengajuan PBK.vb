Public Class Menu_Pengajuan_PBK
    Dim cntx As SqlClient.SqlConnection
    Dim cmdx As SqlClient.SqlCommand
    Dim data As SqlClient.SqlDataAdapter
    Dim dst As DataSet
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim Status As String

    Private Sub Menu_Pengajuan_PBK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=PBK_PLN;integrated security =true"
        cntx.Open()
        cmdx = New SqlClient.SqlCommand("select * from pengajuan")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        cmd = New SqlClient.SqlCommand("select *from pengajuan order by id_pengajuan desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            tb_IDPengajuan.Text = "P0" + "001"
        Else
            tb_IDPengajuan.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_pengajuan").ToString, 4, 3)) + 1
            If Len(tb_IDPengajuan.Text) = 1 Then
                tb_IDPengajuan.Text = "P000" & tb_IDPengajuan.Text & ""
            ElseIf Len(tb_IDPengajuan.Text) = 2 Then
                tb_IDPengajuan.Text = "P00" & tb_IDPengajuan.Text & ""
            ElseIf Len(tb_IDPengajuan.Text) = 3 Then
                tb_IDPengajuan.Text = "P0" & tb_IDPengajuan.Text & ""
            End If
        End If
        dr.Close()

        tb_IDPengajuan.Enabled = False
        tb_NIP.Enabled = False
        tb_Nama.Enabled = False
        tb_Grade.Enabled = False
        tb_NoHp.Enabled = False
        tb_Jenkel.Enabled = False
        tb_StatusKar.Enabled = False

        dgv_Pengajuan.DataSource = dst.Tables(0)
        dgv_Pengajuan.Refresh()

        dgv_Pengajuan.Columns(0).Width = 100
        dgv_Pengajuan.Columns(0).HeaderText = "ID Pengajuan"
        dgv_Pengajuan.Columns(1).Width = 120
        dgv_Pengajuan.Columns(1).HeaderText = "Tanggal Kwitansi"
        dgv_Pengajuan.Columns(2).Width = 180
        dgv_Pengajuan.Columns(2).HeaderText = "Nama Pasien"
        dgv_Pengajuan.Columns(3).Width = 130
        dgv_Pengajuan.Columns(3).HeaderText = "Keterangan"
        dgv_Pengajuan.Columns(4).Width = 80
        dgv_Pengajuan.Columns(4).HeaderText = "Nilai"
        dgv_Pengajuan.Columns(5).Width = 130
        dgv_Pengajuan.Columns(5).HeaderText = "Diagnosa"
        dgv_Pengajuan.Columns(6).Width = 120
        dgv_Pengajuan.Columns(6).HeaderText = "Status Pengajuan"
        dgv_Pengajuan.Columns(7).Width = 130
        dgv_Pengajuan.Columns(7).HeaderText = "Keterangan Status"
        dgv_Pengajuan.Columns(8).Width = 130
        dgv_Pengajuan.Columns(8).HeaderText = "Nama Karyawan"
        dgv_Pengajuan.Columns(9).Width = 80
        dgv_Pengajuan.Columns(9).HeaderText = "NIP"
        dgv_Pengajuan.Columns(10).Width = 120
        dgv_Pengajuan.Columns(10).HeaderText = "Grade"
        dgv_Pengajuan.Columns(11).Width = 100
        dgv_Pengajuan.Columns(11).HeaderText = "No Tel/HP"
        dgv_Pengajuan.Columns(12).Width = 120
        dgv_Pengajuan.Columns(12).HeaderText = "Jenis Kelamin"
        dgv_Pengajuan.Columns(13).Width = 120
        dgv_Pengajuan.Columns(13).HeaderText = "Status Karyawan"
        dgv_Pengajuan.Columns(14).Width = 130
        dgv_Pengajuan.Columns(14).HeaderText = "Tanggal Pengesah"
    End Sub

    Private Sub btn_Lihat_Click(sender As Object, e As EventArgs) Handles btn_Lihat.Click
        Dim cari As String
        If tb_Cari.Text = "" Then
            MsgBox("Harap cari data terlebih dahulu !!!")
            Return
        End If

        cari = tb_Cari.Text
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

        tb_Nama.Text = dst.Tables(0).Rows(0)("nama")
        tb_NIP.Text = dst.Tables(0).Rows(0)("NIP")
        tb_Grade.Text = dst.Tables(0).Rows(0)("grade")
        tb_NoHp.Text = dst.Tables(0).Rows(0)("no_hp")
        tb_Jenkel.Text = dst.Tables(0).Rows(0)("jenkel")
        tb_StatusKar.Text = dst.Tables(0).Rows(0)("status_kar")

    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If tb_NamaPasien.Text = "" Or cb_Keterangan.Text = "" Or tb_Nilai.Text = "" Or tb_Diagnosa.Text = "" Or Status = "" Then
            MsgBox("HARAP ISI SEMUA FIELD !!", vbCritical)
            Return
        End If

        cmdx = New SqlClient.SqlCommand

        cmdx.CommandText = "insert into pengajuan(id_pengajuan, tgl_kwitansi, nama_pasien, keterangan, nilai, diagnosa, status, keterangan_status, nama, NIP, grade, no_hp, jenkel, status_kar, tgl_pengesah) values ('" & tb_IDPengajuan.Text & "','" & dtp_Kwitansi.Text & "','" & tb_NamaPasien.Text & "','" & cb_Keterangan.Text & "','" & tb_Nilai.Text & "','" & tb_Diagnosa.Text & "','" & Status & "','" & tb_KeteranganStatus.Text & "','" & tb_Nama.Text & "','" & tb_NIP.Text & "','" & tb_Grade.Text & "','" & tb_NoHp.Text & "','" & tb_Jenkel.Text & "','" & tb_StatusKar.Text & "','" & dtp_Pengesah.Text & "')"
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()
        cmdx = New SqlClient.SqlCommand("select * from pengajuan")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)

        cmd = New SqlClient.SqlCommand("select *from pengajuan order by id_pengajuan desc", cntx)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            tb_IDPengajuan.Text = "P0" + "001"
        Else
            tb_IDPengajuan.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("id_pengajuan").ToString, 4, 3)) + 1
            If Len(tb_IDPengajuan.Text) = 1 Then
                tb_IDPengajuan.Text = "P000" & tb_IDPengajuan.Text & ""
            ElseIf Len(tb_IDPengajuan.Text) = 2 Then
                tb_IDPengajuan.Text = "P00" & tb_IDPengajuan.Text & ""
            ElseIf Len(tb_IDPengajuan.Text) = 3 Then
                tb_IDPengajuan.Text = "P0" & tb_IDPengajuan.Text & ""
            End If
        End If
        dr.Close()

        dgv_Pengajuan.DataSource = dst.Tables(0)
        dgv_Pengajuan.Refresh()

        tb_Cari.Clear()
        tb_NamaPasien.Clear()
        tb_Nilai.Clear()
        tb_Diagnosa.Clear()
        tb_KeteranganStatus.Clear()
        tb_Nama.Clear()
        tb_NIP.Clear()
        tb_Grade.Clear()
        tb_NoHp.Clear()
        tb_Jenkel.Clear()
        tb_StatusKar.Clear()

    End Sub

    Private Sub rb_ACC_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ACC.CheckedChanged
        Status = "ACC"

        If rb_ACC.Checked = True Then
            tb_KeteranganStatus.Enabled = False
        Else
            tb_KeteranganStatus.Enabled = True
        End If
    End Sub

    Private Sub rb_DITOLAK_CheckedChanged(sender As Object, e As EventArgs) Handles rb_DITOLAK.CheckedChanged
        Status = "DITOLAK"
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        Dim cari As String
        cari = InputBox("MASUKKAN ID PENGAJUAN/NAMA KARYAWAN/NAMA PASIEN")
        cmdx = New SqlClient.SqlCommand("select * from pengajuan where id_pengajuan ='" & cari & "' or nama ='" & cari & "' or nama_pasien ='" & cari & "'")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter
        data.SelectCommand = cmdx
        dst = New DataSet

        data.Fill(dst, "ketemu")
        If dst.Tables(0).Rows.Count = 0 Then
            MsgBox("Data Tidak ada / anda batal mencari Data !!")
            Exit Sub
        End If

        tb_IDPengajuan.Text = dst.Tables(0).Rows(0)("id_pengajuan")
        dtp_Kwitansi.Text = dst.Tables(0).Rows(0)("tgl_kwitansi")
        tb_NamaPasien.Text = dst.Tables(0).Rows(0)("nama_pasien")
        cb_Keterangan.Text = dst.Tables(0).Rows(0)("keterangan")
        tb_Nilai.Text = dst.Tables(0).Rows(0)("nilai")
        tb_Diagnosa.Text = dst.Tables(0).Rows(0)("diagnosa")
        Status = dst.Tables(0).Rows(0)("status")
        tb_KeteranganStatus.Text = dst.Tables(0).Rows(0)("keterangan_status")
        tb_Nama.Text = dst.Tables(0).Rows(0)("nama")
        tb_NIP.Text = dst.Tables(0).Rows(0)("NIP")
        tb_Grade.Text = dst.Tables(0).Rows(0)("grade")
        tb_NoHp.Text = dst.Tables(0).Rows(0)("no_hp")
        tb_Jenkel.Text = dst.Tables(0).Rows(0)("NIP")
        tb_NIP.Text = dst.Tables(0).Rows(0)("jenkel")
        tb_StatusKar.Text = dst.Tables(0).Rows(0)("status_kar")
        dtp_Pengesah.Text = dst.Tables(0).Rows(0)("tgl_pengesah")

        dgv_Pengajuan.DataSource = dst.Tables("ketemu")
        dgv_Pengajuan.ReadOnly = True
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If tb_IDPengajuan.Text = "" Then
            MsgBox("ID PENGAJUAN HARUS DIISI")
            Exit Sub
        End If

        cmdx = New SqlClient.SqlCommand
        cmdx.CommandText = "update pengajuan set tgl_kwitansi ='" & dtp_Kwitansi.Text & "', nama_pasien ='" & tb_NamaPasien.Text & "', keterangan='" & cb_Keterangan.Text & "', nilai='" & tb_Nilai.Text & "', diagnosa='" & tb_Diagnosa.Text & "', status='" & Status & "', keterangan_status='" & tb_KeteranganStatus.Text & "', nama='" & tb_Nama.Text & "', NIP='" & tb_NIP.Text & "', grade='" & tb_Grade.Text & "', no_hp='" & tb_NoHp.Text & "', jenkel='" & tb_Jenkel.Text & "', status_kar='" & tb_StatusKar.Text & "', tgl_pengesah='" & dtp_Pengesah.Text & "' where id_pengajuan ='" & tb_IDPengajuan.Text & "'"
        cmdx.Connection = cntx
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        Dim cekupdate As String
        cekupdate = MsgBox("UPDATE DATA INI", MsgBoxStyle.Question)
        If cekupdate = vbNo Then Exit Sub

        cmdx = New SqlClient.SqlCommand("Select *from pengajuan")
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_Pengajuan.DataSource = dst.Tables(0)
        dgv_Pengajuan.Refresh()

        tb_Cari.Clear()
        tb_NamaPasien.Clear()
        tb_Nilai.Clear()
        tb_Diagnosa.Clear()
        tb_KeteranganStatus.Clear()
        tb_Nama.Clear()
        tb_NIP.Clear()
        tb_Grade.Clear()
        tb_NoHp.Clear()
        tb_Jenkel.Clear()
        tb_StatusKar.Clear()
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        If tb_NIP.Text = "" Then
            MsgBox("HARAP ISI ID PENGAJUAN", vbCritical)
            Return
        End If

        cmdx = New SqlClient.SqlCommand("delete from pengajuan where id_pengajuan='" & tb_IDPengajuan.Text & "'")
        cmdx.Connection = cntx
        cmdx.ExecuteNonQuery()

        MsgBox("Hapus selesai", MsgBoxStyle.Exclamation)

        cmdx = New SqlClient.SqlCommand("select * from pengajuan", cntx)
        cmdx.Connection = cntx
        data = New SqlClient.SqlDataAdapter(cmdx)
        dst = New DataSet
        data.Fill(dst)
        dgv_Pengajuan.DataSource = dst.Tables(0)
        dgv_Pengajuan.Refresh()

        tb_Cari.Clear()
        tb_NamaPasien.Clear()
        tb_Nilai.Clear()
        tb_Diagnosa.Clear()
        tb_KeteranganStatus.Clear()
        tb_Nama.Clear()
        tb_NIP.Clear()
        tb_Grade.Clear()
        tb_NoHp.Clear()
        tb_Jenkel.Clear()
        tb_StatusKar.Clear()
    End Sub
End Class