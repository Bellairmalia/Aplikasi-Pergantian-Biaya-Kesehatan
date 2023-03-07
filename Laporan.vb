Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Laporan

    Dim cntx As SqlClient.SqlConnection

    Sub koneksi()
        cntx = New SqlClient.SqlConnection
        cntx.ConnectionString = "data source=(local);initial catalog=PBK_PLN;integrated security =true"
        cntx.Open()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
       Dim objReport As New crKaryawan
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from karyawan", cntx)

        AccessCommand.CommandText = "select * from karyawan"
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("karyawan").SetDataSource(ds.Tables(0))

        frmLaporan.rptview.ShowGroupTreeButton = False
        frmLaporan.rptview.ReportSource = objReport
        frmLaporan.rptview.Refresh()
        frmLaporan.StartPosition = FormStartPosition.CenterScreen
        frmLaporan.WindowState = FormWindowState.Maximized
        frmLaporan.Show()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim objReport As New crPengajuan
        Dim AccessCommand As New System.Data.SqlClient.SqlCommand("select * from pengajuan", cntx)
        Dim whereString As String = ""

        If cbBulanan.Checked = True Then
            whereString = "month(tgl_kwitansi)='" & Format(DTP1.Value, "MM") & "' and year(tgl_kwitansi)='" & Format(DTP1.Value, "yyyy") & "'"
        Else
            whereString = "(tgl_kwitansi>='" & Format(DTP1.Value, "MM/dd/yyyy") & "' and tgl_kwitansi<='" & Format(DTP2.Value, "MM/dd/yyyy") & "')"
        End If
        'get data
        AccessCommand.CommandText = "select * from pengajuan where " & whereString & ""
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(AccessCommand)
        Dim dtT As New DataTable
        da.Fill(dtT)
        ds.Tables.Add(dtT)
        objReport.Database.Tables("pengajuan").SetDataSource(ds.Tables(0))


        'send to parameter

        If cbBulanan.Checked = True Then
            objReport.SetParameterValue("TampilTanggal", "Bulan :" & Format(DTP1.Value.Date, "MMMM") & ", " & Format(DTP2.Value.Date, "yyyy"))
        Else
            objReport.SetParameterValue("TampilTanggal", "Tanggal :" & Format(DTP1.Value.Date, "dd MMMM yyyy") & " - " & Format(DTP2.Value.Date, "dd MMMM yyyy"))
        End If


        'load to view report
        frmLaporan.rptview.ShowGroupTreeButton = False
        frmLaporan.rptview.ReportSource = objReport
        frmLaporan.rptview.Refresh()
        frmLaporan.StartPosition = FormStartPosition.CenterScreen
        frmLaporan.WindowState = FormWindowState.Maximized
        frmLaporan.Show()
    End Sub

    Private Sub cbBulanan_CheckedChanged(sender As Object, e As EventArgs) Handles cbBulanan.CheckedChanged
        If cbBulanan.Checked = True Then
            DTP2.Enabled = False
            DTP1.Format = DateTimePickerFormat.Custom
            DTP1.CustomFormat = "MM/yyyy"
        Else
            DTP2.Enabled = True
            DTP1.Format = DateTimePickerFormat.Custom
            DTP1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub
End Class