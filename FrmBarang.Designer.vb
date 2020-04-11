<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbKode = New System.Windows.Forms.RadioButton()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSatuan = New System.Windows.Forms.Button()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Rd2 = New System.Windows.Forms.RadioButton()
        Me.Rd1 = New System.Windows.Forms.RadioButton()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.CmbKategori = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtPengarang = New System.Windows.Forms.TextBox()
        Me.TxtISBN = New System.Windows.Forms.TextBox()
        Me.TxtTahun = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtHrgJualRetail = New System.Windows.Forms.TextBox()
        Me.TxtHrgBeli = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtHargaJualGrosir = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbKode)
        Me.GroupBox2.Controls.Add(Me.RbNama)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtCari)
        Me.GroupBox2.Location = New System.Drawing.Point(603, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 81)
        Me.GroupBox2.TabIndex = 145
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Cara Data Berdasarkan : "
        '
        'RbKode
        '
        Me.RbKode.AutoSize = True
        Me.RbKode.Location = New System.Drawing.Point(154, 16)
        Me.RbKode.Name = "RbKode"
        Me.RbKode.Size = New System.Drawing.Size(87, 17)
        Me.RbKode.TabIndex = 135
        Me.RbKode.TabStop = True
        Me.RbKode.Text = "Kode Barang"
        Me.RbKode.UseVisualStyleBackColor = True
        '
        'RbNama
        '
        Me.RbNama.AutoSize = True
        Me.RbNama.Location = New System.Drawing.Point(56, 16)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(90, 17)
        Me.RbNama.TabIndex = 134
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "Nama Barang"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Cari :"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(56, 43)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(187, 20)
        Me.TxtCari.TabIndex = 132
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(9, 216)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(886, 277)
        Me.DGV.TabIndex = 141
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSatuan)
        Me.GroupBox1.Controls.Add(Me.CmbSatuan)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Rd2)
        Me.GroupBox1.Controls.Add(Me.Rd1)
        Me.GroupBox1.Controls.Add(Me.BtnKategori)
        Me.GroupBox1.Controls.Add(Me.CmbKategori)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtKode)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 137)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input / Edit Data"
        '
        'BtnSatuan
        '
        Me.BtnSatuan.Image = CType(resources.GetObject("BtnSatuan.Image"), System.Drawing.Image)
        Me.BtnSatuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSatuan.Location = New System.Drawing.Point(265, 103)
        Me.BtnSatuan.Name = "BtnSatuan"
        Me.BtnSatuan.Size = New System.Drawing.Size(26, 24)
        Me.BtnSatuan.TabIndex = 150
        Me.BtnSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSatuan.UseVisualStyleBackColor = True
        '
        'CmbSatuan
        '
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(138, 103)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(121, 21)
        Me.CmbSatuan.TabIndex = 149
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 22)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Satuan"
        '
        'Rd2
        '
        Me.Rd2.AutoSize = True
        Me.Rd2.Location = New System.Drawing.Point(200, 64)
        Me.Rd2.Name = "Rd2"
        Me.Rd2.Size = New System.Drawing.Size(46, 17)
        Me.Rd2.TabIndex = 147
        Me.Rd2.TabStop = True
        Me.Rd2.Text = "ATK"
        Me.Rd2.UseVisualStyleBackColor = True
        '
        'Rd1
        '
        Me.Rd1.AutoSize = True
        Me.Rd1.Location = New System.Drawing.Point(144, 63)
        Me.Rd1.Name = "Rd1"
        Me.Rd1.Size = New System.Drawing.Size(50, 17)
        Me.Rd1.TabIndex = 146
        Me.Rd1.TabStop = True
        Me.Rd1.Text = "Buku"
        Me.Rd1.UseVisualStyleBackColor = True
        '
        'BtnKategori
        '
        Me.BtnKategori.Image = CType(resources.GetObject("BtnKategori.Image"), System.Drawing.Image)
        Me.BtnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKategori.Location = New System.Drawing.Point(265, 82)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Size = New System.Drawing.Size(26, 24)
        Me.BtnKategori.TabIndex = 145
        Me.BtnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKategori.UseVisualStyleBackColor = True
        '
        'CmbKategori
        '
        Me.CmbKategori.FormattingEnabled = True
        Me.CmbKategori.Location = New System.Drawing.Point(138, 82)
        Me.CmbKategori.Name = "CmbKategori"
        Me.CmbKategori.Size = New System.Drawing.Size(121, 21)
        Me.CmbKategori.TabIndex = 144
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 22)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Kategory"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Jenis :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Nama :"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(138, 40)
        Me.TxtNama.MaxLength = 25
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(158, 20)
        Me.TxtNama.TabIndex = 139
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Kode Barang / Barcode :"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(138, 19)
        Me.TxtKode.MaxLength = 25
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(158, 20)
        Me.TxtKode.TabIndex = 137
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtPenerbit)
        Me.GroupBox3.Controls.Add(Me.TxtPengarang)
        Me.GroupBox3.Controls.Add(Me.TxtISBN)
        Me.GroupBox3.Controls.Add(Me.TxtTahun)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(329, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 112)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "  Identitas Khusus Buku"
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(86, 38)
        Me.TxtPenerbit.MaxLength = 25
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(158, 20)
        Me.TxtPenerbit.TabIndex = 143
        '
        'TxtPengarang
        '
        Me.TxtPengarang.Location = New System.Drawing.Point(86, 17)
        Me.TxtPengarang.MaxLength = 25
        Me.TxtPengarang.Name = "TxtPengarang"
        Me.TxtPengarang.Size = New System.Drawing.Size(158, 20)
        Me.TxtPengarang.TabIndex = 142
        '
        'TxtISBN
        '
        Me.TxtISBN.Location = New System.Drawing.Point(86, 80)
        Me.TxtISBN.MaxLength = 25
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.Size = New System.Drawing.Size(158, 20)
        Me.TxtISBN.TabIndex = 141
        '
        'TxtTahun
        '
        Me.TxtTahun.Location = New System.Drawing.Point(86, 59)
        Me.TxtTahun.MaxLength = 4
        Me.TxtTahun.Name = "TxtTahun"
        Me.TxtTahun.Size = New System.Drawing.Size(158, 20)
        Me.TxtTahun.TabIndex = 140
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ISBN :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tahun Terbit :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Penerbit :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pengarang :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtHrgJualRetail)
        Me.GroupBox4.Controls.Add(Me.TxtHrgBeli)
        Me.GroupBox4.Controls.Add(Me.TxtStock)
        Me.GroupBox4.Controls.Add(Me.TxtHargaJualGrosir)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(602, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(293, 112)
        Me.GroupBox4.TabIndex = 149
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Setting Harga"
        '
        'TxtHrgJualRetail
        '
        Me.TxtHrgJualRetail.Location = New System.Drawing.Point(114, 37)
        Me.TxtHrgJualRetail.MaxLength = 10
        Me.TxtHrgJualRetail.Name = "TxtHrgJualRetail"
        Me.TxtHrgJualRetail.Size = New System.Drawing.Size(158, 20)
        Me.TxtHrgJualRetail.TabIndex = 151
        '
        'TxtHrgBeli
        '
        Me.TxtHrgBeli.Location = New System.Drawing.Point(114, 16)
        Me.TxtHrgBeli.MaxLength = 10
        Me.TxtHrgBeli.Name = "TxtHrgBeli"
        Me.TxtHrgBeli.Size = New System.Drawing.Size(158, 20)
        Me.TxtHrgBeli.TabIndex = 150
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(114, 79)
        Me.TxtStock.MaxLength = 6
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(158, 20)
        Me.TxtStock.TabIndex = 149
        '
        'TxtHargaJualGrosir
        '
        Me.TxtHargaJualGrosir.Location = New System.Drawing.Point(114, 58)
        Me.TxtHargaJualGrosir.MaxLength = 10
        Me.TxtHargaJualGrosir.Name = "TxtHargaJualGrosir"
        Me.TxtHargaJualGrosir.Size = New System.Drawing.Size(158, 20)
        Me.TxtHargaJualGrosir.TabIndex = 148
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Stock On Hand :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 146
        Me.Label12.Text = "Harga Jual Grosir :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 145
        Me.Label13.Text = "Harga Jual Retail :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "Harga Beli :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnUbah)
        Me.GroupBox5.Controls.Add(Me.BtnHapus)
        Me.GroupBox5.Controls.Add(Me.BtnBatal)
        Me.GroupBox5.Controls.Add(Me.BtnSimpan)
        Me.GroupBox5.Location = New System.Drawing.Point(329, 129)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(267, 81)
        Me.GroupBox5.TabIndex = 150
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "  Proses"
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(13, 46)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(86, 24)
        Me.BtnUbah.TabIndex = 150
        Me.BtnUbah.Text = "&Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(103, 46)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(86, 24)
        Me.BtnHapus.TabIndex = 148
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(103, 19)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(86, 24)
        Me.BtnBatal.TabIndex = 149
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(12, 19)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(86, 24)
        Me.BtnSimpan.TabIndex = 147
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(12, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 20)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "* [Enter] untuk melanjutkan"
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 505)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbKode As System.Windows.Forms.RadioButton
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnKategori As System.Windows.Forms.Button
    Friend WithEvents CmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents Rd2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rd1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSatuan As System.Windows.Forms.Button
    Friend WithEvents CmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtPenerbit As System.Windows.Forms.TextBox
    Friend WithEvents TxtPengarang As System.Windows.Forms.TextBox
    Friend WithEvents TxtISBN As System.Windows.Forms.TextBox
    Friend WithEvents TxtTahun As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgJualRetail As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgBeli As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtHargaJualGrosir As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
