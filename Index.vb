Public Class Index

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menu_User.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Karyawan.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Menu_Pengajuan_PBK.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Laporan.ShowDialog()
    End Sub

    Dim konfirmasi As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        konfirmasi = MsgBox("Anda yakin ingin Keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub
End Class