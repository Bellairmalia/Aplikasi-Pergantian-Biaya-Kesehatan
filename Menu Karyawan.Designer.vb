<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Karyawan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_StatusKar = New System.Windows.Forms.ComboBox()
        Me.dgv_Karyawan = New System.Windows.Forms.DataGridView()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.tb_NoHp = New System.Windows.Forms.TextBox()
        Me.tb_Grade = New System.Windows.Forms.TextBox()
        Me.tb_NIP = New System.Windows.Forms.TextBox()
        Me.tb_Nama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_Laki = New System.Windows.Forms.RadioButton()
        Me.rb_Perempuan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Karyawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Perempuan)
        Me.GroupBox1.Controls.Add(Me.rb_Laki)
        Me.GroupBox1.Controls.Add(Me.cb_StatusKar)
        Me.GroupBox1.Controls.Add(Me.dgv_Karyawan)
        Me.GroupBox1.Controls.Add(Me.btn_Hapus)
        Me.GroupBox1.Controls.Add(Me.btn_Cari)
        Me.GroupBox1.Controls.Add(Me.btn_Edit)
        Me.GroupBox1.Controls.Add(Me.btn_Simpan)
        Me.GroupBox1.Controls.Add(Me.tb_NoHp)
        Me.GroupBox1.Controls.Add(Me.tb_Grade)
        Me.GroupBox1.Controls.Add(Me.tb_NIP)
        Me.GroupBox1.Controls.Add(Me.tb_Nama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan"
        '
        'cb_StatusKar
        '
        Me.cb_StatusKar.FormattingEnabled = True
        Me.cb_StatusKar.Items.AddRange(New Object() {"AKTIF", "PENSIUNAN"})
        Me.cb_StatusKar.Location = New System.Drawing.Point(538, 114)
        Me.cb_StatusKar.Name = "cb_StatusKar"
        Me.cb_StatusKar.Size = New System.Drawing.Size(155, 21)
        Me.cb_StatusKar.TabIndex = 18
        Me.cb_StatusKar.Text = "- Pilih -"
        '
        'dgv_Karyawan
        '
        Me.dgv_Karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Karyawan.Location = New System.Drawing.Point(0, 205)
        Me.dgv_Karyawan.Name = "dgv_Karyawan"
        Me.dgv_Karyawan.Size = New System.Drawing.Size(778, 213)
        Me.dgv_Karyawan.TabIndex = 16
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Location = New System.Drawing.Point(400, 154)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(75, 36)
        Me.btn_Hapus.TabIndex = 15
        Me.btn_Hapus.Text = "HAPUS"
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Cari
        '
        Me.btn_Cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cari.Location = New System.Drawing.Point(308, 154)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(75, 36)
        Me.btn_Cari.TabIndex = 14
        Me.btn_Cari.Text = "CARI"
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(215, 154)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 36)
        Me.btn_Edit.TabIndex = 13
        Me.btn_Edit.Text = "EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Simpan.Location = New System.Drawing.Point(123, 154)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(75, 36)
        Me.btn_Simpan.TabIndex = 12
        Me.btn_Simpan.Text = "SIMPAN"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'tb_NoHp
        '
        Me.tb_NoHp.Location = New System.Drawing.Point(538, 37)
        Me.tb_NoHp.Name = "tb_NoHp"
        Me.tb_NoHp.Size = New System.Drawing.Size(194, 20)
        Me.tb_NoHp.TabIndex = 9
        '
        'tb_Grade
        '
        Me.tb_Grade.Location = New System.Drawing.Point(125, 114)
        Me.tb_Grade.Name = "tb_Grade"
        Me.tb_Grade.Size = New System.Drawing.Size(280, 20)
        Me.tb_Grade.TabIndex = 8
        '
        'tb_NIP
        '
        Me.tb_NIP.Location = New System.Drawing.Point(125, 77)
        Me.tb_NIP.Name = "tb_NIP"
        Me.tb_NIP.Size = New System.Drawing.Size(151, 20)
        Me.tb_NIP.TabIndex = 7
        '
        'tb_Nama
        '
        Me.tb_Nama.Location = New System.Drawing.Point(125, 37)
        Me.tb_Nama.Name = "tb_Nama"
        Me.tb_Nama.Size = New System.Drawing.Size(280, 20)
        Me.tb_Nama.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status Karyawan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Tel/HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Karyawan"
        '
        'rb_Laki
        '
        Me.rb_Laki.AutoSize = True
        Me.rb_Laki.Location = New System.Drawing.Point(538, 76)
        Me.rb_Laki.Name = "rb_Laki"
        Me.rb_Laki.Size = New System.Drawing.Size(68, 17)
        Me.rb_Laki.TabIndex = 19
        Me.rb_Laki.TabStop = True
        Me.rb_Laki.Text = "Laki-Laki"
        Me.rb_Laki.UseVisualStyleBackColor = True
        '
        'rb_Perempuan
        '
        Me.rb_Perempuan.AutoSize = True
        Me.rb_Perempuan.Location = New System.Drawing.Point(642, 76)
        Me.rb_Perempuan.Name = "rb_Perempuan"
        Me.rb_Perempuan.Size = New System.Drawing.Size(79, 17)
        Me.rb_Perempuan.TabIndex = 20
        Me.rb_Perempuan.TabStop = True
        Me.rb_Perempuan.Text = "Perempuan"
        Me.rb_Perempuan.UseVisualStyleBackColor = True
        '
        'Menu_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Menu_Karyawan"
        Me.Text = "Menu_Karyawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Karyawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Karyawan As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Hapus As System.Windows.Forms.Button
    Friend WithEvents btn_Cari As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents tb_NoHp As System.Windows.Forms.TextBox
    Friend WithEvents tb_Grade As System.Windows.Forms.TextBox
    Friend WithEvents tb_NIP As System.Windows.Forms.TextBox
    Friend WithEvents tb_Nama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_StatusKar As System.Windows.Forms.ComboBox
    Friend WithEvents rb_Perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Laki As System.Windows.Forms.RadioButton
End Class
