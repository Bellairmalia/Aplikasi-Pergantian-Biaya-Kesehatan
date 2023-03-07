<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Pengajuan_PBK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Pengajuan_PBK))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_DITOLAK = New System.Windows.Forms.RadioButton()
        Me.rb_ACC = New System.Windows.Forms.RadioButton()
        Me.dtp_Pengesah = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgv_Pengajuan = New System.Windows.Forms.DataGridView()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.tb_KeteranganStatus = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_Lihat = New System.Windows.Forms.Button()
        Me.tb_Cari = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_Kwitansi = New System.Windows.Forms.DateTimePicker()
        Me.cb_Keterangan = New System.Windows.Forms.ComboBox()
        Me.tb_IDPengajuan = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_Diagnosa = New System.Windows.Forms.TextBox()
        Me.tb_Nilai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_NamaPasien = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_StatusKar = New System.Windows.Forms.TextBox()
        Me.tb_Jenkel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_NoHp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Grade = New System.Windows.Forms.TextBox()
        Me.tb_NIP = New System.Windows.Forms.TextBox()
        Me.tb_Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Pengajuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Edit)
        Me.GroupBox1.Controls.Add(Me.rb_DITOLAK)
        Me.GroupBox1.Controls.Add(Me.rb_ACC)
        Me.GroupBox1.Controls.Add(Me.dtp_Pengesah)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.dgv_Pengajuan)
        Me.GroupBox1.Controls.Add(Me.btn_Hapus)
        Me.GroupBox1.Controls.Add(Me.btn_Cari)
        Me.GroupBox1.Controls.Add(Me.btn_Simpan)
        Me.GroupBox1.Controls.Add(Me.tb_KeteranganStatus)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btn_Lihat)
        Me.GroupBox1.Controls.Add(Me.tb_Cari)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtp_Kwitansi)
        Me.GroupBox1.Controls.Add(Me.cb_Keterangan)
        Me.GroupBox1.Controls.Add(Me.tb_IDPengajuan)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tb_Diagnosa)
        Me.GroupBox1.Controls.Add(Me.tb_Nilai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tb_NamaPasien)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tb_StatusKar)
        Me.GroupBox1.Controls.Add(Me.tb_Jenkel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_NoHp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_Grade)
        Me.GroupBox1.Controls.Add(Me.tb_NIP)
        Me.GroupBox1.Controls.Add(Me.tb_Nama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(953, 528)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pengajuan Pergantian Biaya Kesehatan"
        '
        'rb_DITOLAK
        '
        Me.rb_DITOLAK.AutoSize = True
        Me.rb_DITOLAK.Location = New System.Drawing.Point(219, 263)
        Me.rb_DITOLAK.Name = "rb_DITOLAK"
        Me.rb_DITOLAK.Size = New System.Drawing.Size(71, 17)
        Me.rb_DITOLAK.TabIndex = 63
        Me.rb_DITOLAK.TabStop = True
        Me.rb_DITOLAK.Text = "DITOLAK"
        Me.rb_DITOLAK.UseVisualStyleBackColor = True
        '
        'rb_ACC
        '
        Me.rb_ACC.AutoSize = True
        Me.rb_ACC.Location = New System.Drawing.Point(137, 263)
        Me.rb_ACC.Name = "rb_ACC"
        Me.rb_ACC.Size = New System.Drawing.Size(46, 17)
        Me.rb_ACC.TabIndex = 62
        Me.rb_ACC.TabStop = True
        Me.rb_ACC.Text = "ACC"
        Me.rb_ACC.UseVisualStyleBackColor = True
        '
        'dtp_Pengesah
        '
        Me.dtp_Pengesah.Location = New System.Drawing.Point(574, 256)
        Me.dtp_Pengesah.Name = "dtp_Pengesah"
        Me.dtp_Pengesah.Size = New System.Drawing.Size(153, 20)
        Me.dtp_Pengesah.TabIndex = 60
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(471, 257)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Tanggal Pengesah"
        '
        'dgv_Pengajuan
        '
        Me.dgv_Pengajuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Pengajuan.Location = New System.Drawing.Point(0, 333)
        Me.dgv_Pengajuan.Name = "dgv_Pengajuan"
        Me.dgv_Pengajuan.Size = New System.Drawing.Size(955, 195)
        Me.dgv_Pengajuan.TabIndex = 58
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Location = New System.Drawing.Point(852, 287)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(75, 29)
        Me.btn_Hapus.TabIndex = 57
        Me.btn_Hapus.Text = "HAPUS"
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Cari
        '
        Me.btn_Cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cari.Location = New System.Drawing.Point(758, 287)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(75, 29)
        Me.btn_Cari.TabIndex = 56
        Me.btn_Cari.Text = "CARI"
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Simpan.Location = New System.Drawing.Point(574, 287)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(75, 29)
        Me.btn_Simpan.TabIndex = 54
        Me.btn_Simpan.Text = "SIMPAN"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'tb_KeteranganStatus
        '
        Me.tb_KeteranganStatus.Location = New System.Drawing.Point(137, 296)
        Me.tb_KeteranganStatus.Name = "tb_KeteranganStatus"
        Me.tb_KeteranganStatus.Size = New System.Drawing.Size(269, 20)
        Me.tb_KeteranganStatus.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Keterangan Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Status Pengajuan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(134, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "* Berdasarkan Nama Karyawan atau NIP "
        '
        'btn_Lihat
        '
        Me.btn_Lihat.BackColor = System.Drawing.Color.White
        Me.btn_Lihat.BackgroundImage = CType(resources.GetObject("btn_Lihat.BackgroundImage"), System.Drawing.Image)
        Me.btn_Lihat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Lihat.Location = New System.Drawing.Point(428, 26)
        Me.btn_Lihat.Name = "btn_Lihat"
        Me.btn_Lihat.Size = New System.Drawing.Size(47, 23)
        Me.btn_Lihat.TabIndex = 46
        Me.btn_Lihat.UseVisualStyleBackColor = False
        '
        'tb_Cari
        '
        Me.tb_Cari.Location = New System.Drawing.Point(137, 29)
        Me.tb_Cari.Name = "tb_Cari"
        Me.tb_Cari.Size = New System.Drawing.Size(285, 20)
        Me.tb_Cari.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Cari Data"
        '
        'dtp_Kwitansi
        '
        Me.dtp_Kwitansi.Location = New System.Drawing.Point(137, 106)
        Me.dtp_Kwitansi.Name = "dtp_Kwitansi"
        Me.dtp_Kwitansi.Size = New System.Drawing.Size(153, 20)
        Me.dtp_Kwitansi.TabIndex = 43
        '
        'cb_Keterangan
        '
        Me.cb_Keterangan.FormattingEnabled = True
        Me.cb_Keterangan.Items.AddRange(New Object() {"RAWAT INAP", "RAWAT JALAN"})
        Me.cb_Keterangan.Location = New System.Drawing.Point(137, 166)
        Me.cb_Keterangan.Name = "cb_Keterangan"
        Me.cb_Keterangan.Size = New System.Drawing.Size(121, 21)
        Me.cb_Keterangan.TabIndex = 42
        Me.cb_Keterangan.Text = "- Pilih -"
        '
        'tb_IDPengajuan
        '
        Me.tb_IDPengajuan.Location = New System.Drawing.Point(137, 77)
        Me.tb_IDPengajuan.Name = "tb_IDPengajuan"
        Me.tb_IDPengajuan.Size = New System.Drawing.Size(153, 20)
        Me.tb_IDPengajuan.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "ID Pengajuan PBK"
        '
        'tb_Diagnosa
        '
        Me.tb_Diagnosa.Location = New System.Drawing.Point(137, 228)
        Me.tb_Diagnosa.Name = "tb_Diagnosa"
        Me.tb_Diagnosa.Size = New System.Drawing.Size(269, 20)
        Me.tb_Diagnosa.TabIndex = 39
        '
        'tb_Nilai
        '
        Me.tb_Nilai.Location = New System.Drawing.Point(137, 196)
        Me.tb_Nilai.Name = "tb_Nilai"
        Me.tb_Nilai.Size = New System.Drawing.Size(153, 20)
        Me.tb_Nilai.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Tanggal Kwitansi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Diagnosa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nilai Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Keterangan"
        '
        'tb_NamaPasien
        '
        Me.tb_NamaPasien.Location = New System.Drawing.Point(137, 136)
        Me.tb_NamaPasien.Name = "tb_NamaPasien"
        Me.tb_NamaPasien.Size = New System.Drawing.Size(269, 20)
        Me.tb_NamaPasien.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Nama Pasien"
        '
        'tb_StatusKar
        '
        Me.tb_StatusKar.Location = New System.Drawing.Point(574, 226)
        Me.tb_StatusKar.Name = "tb_StatusKar"
        Me.tb_StatusKar.Size = New System.Drawing.Size(151, 20)
        Me.tb_StatusKar.TabIndex = 27
        '
        'tb_Jenkel
        '
        Me.tb_Jenkel.Location = New System.Drawing.Point(574, 194)
        Me.tb_Jenkel.Name = "tb_Jenkel"
        Me.tb_Jenkel.Size = New System.Drawing.Size(151, 20)
        Me.tb_Jenkel.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(473, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "NIP"
        '
        'tb_NoHp
        '
        Me.tb_NoHp.Location = New System.Drawing.Point(574, 164)
        Me.tb_NoHp.Name = "tb_NoHp"
        Me.tb_NoHp.Size = New System.Drawing.Size(194, 20)
        Me.tb_NoHp.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(471, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Status Karyawan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(471, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(471, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "No Tel/HP"
        '
        'tb_Grade
        '
        Me.tb_Grade.Location = New System.Drawing.Point(574, 134)
        Me.tb_Grade.Name = "tb_Grade"
        Me.tb_Grade.Size = New System.Drawing.Size(338, 20)
        Me.tb_Grade.TabIndex = 13
        '
        'tb_NIP
        '
        Me.tb_NIP.Location = New System.Drawing.Point(574, 104)
        Me.tb_NIP.Name = "tb_NIP"
        Me.tb_NIP.Size = New System.Drawing.Size(151, 20)
        Me.tb_NIP.TabIndex = 12
        '
        'tb_Nama
        '
        Me.tb_Nama.Location = New System.Drawing.Point(574, 75)
        Me.tb_Nama.Name = "tb_Nama"
        Me.tb_Nama.Size = New System.Drawing.Size(338, 20)
        Me.tb_Nama.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(473, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Grade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(473, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama Karyawan"
        '
        'btn_Edit
        '
        Me.btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(664, 287)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 29)
        Me.btn_Edit.TabIndex = 65
        Me.btn_Edit.Text = "EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'Menu_Pengajuan_PBK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Menu_Pengajuan_PBK"
        Me.Text = "Menu_Pengajuan_PBK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Pengajuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_Grade As System.Windows.Forms.TextBox
    Friend WithEvents tb_NIP As System.Windows.Forms.TextBox
    Friend WithEvents tb_Nama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_NoHp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_Diagnosa As System.Windows.Forms.TextBox
    Friend WithEvents tb_Nilai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_NamaPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_StatusKar As System.Windows.Forms.TextBox
    Friend WithEvents tb_Jenkel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_Kwitansi As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_Keterangan As System.Windows.Forms.ComboBox
    Friend WithEvents tb_IDPengajuan As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_Lihat As System.Windows.Forms.Button
    Friend WithEvents tb_Cari As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_KeteranganStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgv_Pengajuan As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Hapus As System.Windows.Forms.Button
    Friend WithEvents btn_Cari As System.Windows.Forms.Button
    Friend WithEvents btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents dtp_Pengesah As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents rb_DITOLAK As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ACC As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
End Class
