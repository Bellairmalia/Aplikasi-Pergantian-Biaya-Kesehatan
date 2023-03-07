<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_User
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
        Me.dgv_User = New System.Windows.Forms.DataGridView()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.tb_NamaUser = New System.Windows.Forms.TextBox()
        Me.tb_IDUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_User)
        Me.GroupBox1.Controls.Add(Me.btn_Hapus)
        Me.GroupBox1.Controls.Add(Me.btn_Cari)
        Me.GroupBox1.Controls.Add(Me.btn_Edit)
        Me.GroupBox1.Controls.Add(Me.btn_Simpan)
        Me.GroupBox1.Controls.Add(Me.tb_Password)
        Me.GroupBox1.Controls.Add(Me.tb_Username)
        Me.GroupBox1.Controls.Add(Me.tb_NamaUser)
        Me.GroupBox1.Controls.Add(Me.tb_IDUser)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 351)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User"
        '
        'dgv_User
        '
        Me.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_User.Location = New System.Drawing.Point(0, 143)
        Me.dgv_User.Name = "dgv_User"
        Me.dgv_User.Size = New System.Drawing.Size(556, 206)
        Me.dgv_User.TabIndex = 12
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Location = New System.Drawing.Point(379, 104)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_Hapus.TabIndex = 11
        Me.btn_Hapus.Text = "HAPUS"
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Cari
        '
        Me.btn_Cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cari.Location = New System.Drawing.Point(285, 104)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cari.TabIndex = 10
        Me.btn_Cari.Text = "CARI"
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(189, 104)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Edit.TabIndex = 9
        Me.btn_Edit.Text = "EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Simpan.Location = New System.Drawing.Point(97, 104)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_Simpan.TabIndex = 8
        Me.btn_Simpan.Text = "SIMPAN"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'tb_Password
        '
        Me.tb_Password.Location = New System.Drawing.Point(379, 67)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.Size = New System.Drawing.Size(156, 20)
        Me.tb_Password.TabIndex = 7
        '
        'tb_Username
        '
        Me.tb_Username.Location = New System.Drawing.Point(379, 34)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(156, 20)
        Me.tb_Username.TabIndex = 6
        '
        'tb_NamaUser
        '
        Me.tb_NamaUser.Location = New System.Drawing.Point(97, 67)
        Me.tb_NamaUser.Name = "tb_NamaUser"
        Me.tb_NamaUser.Size = New System.Drawing.Size(179, 20)
        Me.tb_NamaUser.TabIndex = 5
        '
        'tb_IDUser
        '
        Me.tb_IDUser.Location = New System.Drawing.Point(97, 34)
        Me.tb_IDUser.Name = "tb_IDUser"
        Me.tb_IDUser.Size = New System.Drawing.Size(125, 20)
        Me.tb_IDUser.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID User"
        '
        'Menu_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Menu_User"
        Me.Text = "Menu_User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_User As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Hapus As System.Windows.Forms.Button
    Friend WithEvents btn_Cari As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Simpan As System.Windows.Forms.Button
    Friend WithEvents tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents tb_Username As System.Windows.Forms.TextBox
    Friend WithEvents tb_NamaUser As System.Windows.Forms.TextBox
    Friend WithEvents tb_IDUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
