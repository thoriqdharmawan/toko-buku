<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuUtama))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuLapBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MnuLapSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSatuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuKategori = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuPetugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLapPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuGantiPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuLapPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLapPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnPenjualan = New System.Windows.Forms.Button()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.BtnSatuan = New System.Windows.Forms.Button()
        Me.BtnSupplier = New System.Windows.Forms.Button()
        Me.BtnPelanggan = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnGantiPass = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Panel1, Me.Panel2, Me.Panel3, Me.Panel4, Me.Panel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 464)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1170, 25)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 20)
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 20)
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 20)
        '
        'Panel4
        '
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(153, 20)
        Me.Panel4.Text = "ToolStripStatusLabel1"
        '
        'Panel5
        '
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(153, 20)
        Me.Panel5.Text = "ToolStripStatusLabel2"
        '
        'MnuLapBarang
        '
        Me.MnuLapBarang.Image = CType(resources.GetObject("MnuLapBarang.Image"), System.Drawing.Image)
        Me.MnuLapBarang.Name = "MnuLapBarang"
        Me.MnuLapBarang.Size = New System.Drawing.Size(183, 24)
        Me.MnuLapBarang.Text = "Data Barang"
        '
        'MnuExit
        '
        Me.MnuExit.Image = CType(resources.GetObject("MnuExit.Image"), System.Drawing.Image)
        Me.MnuExit.Name = "MnuExit"
        Me.MnuExit.Size = New System.Drawing.Size(79, 24)
        Me.MnuExit.Text = "Keluar"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MnuLapSupplier
        '
        Me.MnuLapSupplier.Image = CType(resources.GetObject("MnuLapSupplier.Image"), System.Drawing.Image)
        Me.MnuLapSupplier.Name = "MnuLapSupplier"
        Me.MnuLapSupplier.Size = New System.Drawing.Size(183, 24)
        Me.MnuLapSupplier.Text = "Data Supplier"
        '
        'MnuMaster
        '
        Me.MnuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuPelanggan, Me.MnuSupplier, Me.ToolStripMenuItem1, Me.MnuSatuan, Me.MnuKategori, Me.MnuBarang, Me.ToolStripMenuItem2, Me.MnuPetugas})
        Me.MnuMaster.Image = CType(resources.GetObject("MnuMaster.Image"), System.Drawing.Image)
        Me.MnuMaster.Name = "MnuMaster"
        Me.MnuMaster.Size = New System.Drawing.Size(82, 24)
        Me.MnuMaster.Text = "Master"
        '
        'MnuPelanggan
        '
        Me.MnuPelanggan.Image = CType(resources.GetObject("MnuPelanggan.Image"), System.Drawing.Image)
        Me.MnuPelanggan.Name = "MnuPelanggan"
        Me.MnuPelanggan.Size = New System.Drawing.Size(186, 24)
        Me.MnuPelanggan.Text = "Pelanggan"
        '
        'MnuSupplier
        '
        Me.MnuSupplier.Image = CType(resources.GetObject("MnuSupplier.Image"), System.Drawing.Image)
        Me.MnuSupplier.Name = "MnuSupplier"
        Me.MnuSupplier.Size = New System.Drawing.Size(186, 24)
        Me.MnuSupplier.Text = "Supplier"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 6)
        '
        'MnuSatuan
        '
        Me.MnuSatuan.Image = CType(resources.GetObject("MnuSatuan.Image"), System.Drawing.Image)
        Me.MnuSatuan.Name = "MnuSatuan"
        Me.MnuSatuan.Size = New System.Drawing.Size(186, 24)
        Me.MnuSatuan.Text = "Satuan Barang"
        '
        'MnuKategori
        '
        Me.MnuKategori.Image = CType(resources.GetObject("MnuKategori.Image"), System.Drawing.Image)
        Me.MnuKategori.Name = "MnuKategori"
        Me.MnuKategori.Size = New System.Drawing.Size(186, 24)
        Me.MnuKategori.Text = "Kategori Barang"
        '
        'MnuBarang
        '
        Me.MnuBarang.Image = CType(resources.GetObject("MnuBarang.Image"), System.Drawing.Image)
        Me.MnuBarang.Name = "MnuBarang"
        Me.MnuBarang.Size = New System.Drawing.Size(186, 24)
        Me.MnuBarang.Text = "Barang"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 6)
        '
        'MnuPetugas
        '
        Me.MnuPetugas.Image = CType(resources.GetObject("MnuPetugas.Image"), System.Drawing.Image)
        Me.MnuPetugas.Name = "MnuPetugas"
        Me.MnuPetugas.Size = New System.Drawing.Size(186, 24)
        Me.MnuPetugas.Text = "Petugas"
        '
        'MnuLapPelanggan
        '
        Me.MnuLapPelanggan.Image = CType(resources.GetObject("MnuLapPelanggan.Image"), System.Drawing.Image)
        Me.MnuLapPelanggan.Name = "MnuLapPelanggan"
        Me.MnuLapPelanggan.Size = New System.Drawing.Size(183, 24)
        Me.MnuLapPelanggan.Text = "Data Pelanggan"
        '
        'MnuKeluar
        '
        Me.MnuKeluar.Image = CType(resources.GetObject("MnuKeluar.Image"), System.Drawing.Image)
        Me.MnuKeluar.Name = "MnuKeluar"
        Me.MnuKeluar.Size = New System.Drawing.Size(178, 24)
        Me.MnuKeluar.Text = "Keluar"
        '
        'MnuLogOut
        '
        Me.MnuLogOut.Image = CType(resources.GetObject("MnuLogOut.Image"), System.Drawing.Image)
        Me.MnuLogOut.Name = "MnuLogOut"
        Me.MnuLogOut.Size = New System.Drawing.Size(178, 24)
        Me.MnuLogOut.Text = "Log Out"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFile, Me.MnuMaster, Me.MnuTransaksi, Me.MnuLaporan, Me.MnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1170, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnuFile
        '
        Me.MnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuGantiPassword, Me.MnuLogOut, Me.MnuKeluar})
        Me.MnuFile.Image = CType(resources.GetObject("MnuFile.Image"), System.Drawing.Image)
        Me.MnuFile.Name = "MnuFile"
        Me.MnuFile.Size = New System.Drawing.Size(60, 24)
        Me.MnuFile.Text = "File"
        '
        'MnuGantiPassword
        '
        Me.MnuGantiPassword.Image = CType(resources.GetObject("MnuGantiPassword.Image"), System.Drawing.Image)
        Me.MnuGantiPassword.Name = "MnuGantiPassword"
        Me.MnuGantiPassword.Size = New System.Drawing.Size(178, 24)
        Me.MnuGantiPassword.Text = "Ganti Password"
        '
        'MnuTransaksi
        '
        Me.MnuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuPembelian, Me.MnuPenjualan})
        Me.MnuTransaksi.Image = CType(resources.GetObject("MnuTransaksi.Image"), System.Drawing.Image)
        Me.MnuTransaksi.Name = "MnuTransaksi"
        Me.MnuTransaksi.Size = New System.Drawing.Size(96, 24)
        Me.MnuTransaksi.Text = "Transaksi"
        '
        'MnuPembelian
        '
        Me.MnuPembelian.Image = CType(resources.GetObject("MnuPembelian.Image"), System.Drawing.Image)
        Me.MnuPembelian.Name = "MnuPembelian"
        Me.MnuPembelian.Size = New System.Drawing.Size(147, 24)
        Me.MnuPembelian.Text = "Pembelian"
        '
        'MnuPenjualan
        '
        Me.MnuPenjualan.Image = CType(resources.GetObject("MnuPenjualan.Image"), System.Drawing.Image)
        Me.MnuPenjualan.Name = "MnuPenjualan"
        Me.MnuPenjualan.Size = New System.Drawing.Size(147, 24)
        Me.MnuPenjualan.Text = "Penjualan"
        '
        'MnuLaporan
        '
        Me.MnuLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuLapPelanggan, Me.MnuLapSupplier, Me.MnuLapBarang, Me.ToolStripMenuItem3, Me.MnuLapPembelian, Me.MnuLapPenjualan})
        Me.MnuLaporan.Image = CType(resources.GetObject("MnuLaporan.Image"), System.Drawing.Image)
        Me.MnuLaporan.Name = "MnuLaporan"
        Me.MnuLaporan.Size = New System.Drawing.Size(91, 24)
        Me.MnuLaporan.Text = "Laporan"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 6)
        '
        'MnuLapPembelian
        '
        Me.MnuLapPembelian.Image = CType(resources.GetObject("MnuLapPembelian.Image"), System.Drawing.Image)
        Me.MnuLapPembelian.Name = "MnuLapPembelian"
        Me.MnuLapPembelian.Size = New System.Drawing.Size(183, 24)
        Me.MnuLapPembelian.Text = "Pembelian"
        '
        'MnuLapPenjualan
        '
        Me.MnuLapPenjualan.Image = CType(resources.GetObject("MnuLapPenjualan.Image"), System.Drawing.Image)
        Me.MnuLapPenjualan.Name = "MnuLapPenjualan"
        Me.MnuLapPenjualan.Size = New System.Drawing.Size(183, 24)
        Me.MnuLapPenjualan.Text = "Penjualan"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 33)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1360, 129)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Controls.Add(Me.BtnPenjualan)
        Me.GroupBox3.Controls.Add(Me.BtnPembelian)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(785, 23)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(239, 101)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi"
        '
        'BtnPenjualan
        '
        Me.BtnPenjualan.AutoSize = True
        Me.BtnPenjualan.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPenjualan.FlatAppearance.BorderSize = 0
        Me.BtnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPenjualan.Image = CType(resources.GetObject("BtnPenjualan.Image"), System.Drawing.Image)
        Me.BtnPenjualan.Location = New System.Drawing.Point(116, 19)
        Me.BtnPenjualan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPenjualan.Name = "BtnPenjualan"
        Me.BtnPenjualan.Size = New System.Drawing.Size(108, 78)
        Me.BtnPenjualan.TabIndex = 6
        Me.BtnPenjualan.Text = "Penjualan"
        Me.BtnPenjualan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPenjualan.UseVisualStyleBackColor = True
        '
        'BtnPembelian
        '
        Me.BtnPembelian.AutoSize = True
        Me.BtnPembelian.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPembelian.FlatAppearance.BorderSize = 0
        Me.BtnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPembelian.Image = CType(resources.GetObject("BtnPembelian.Image"), System.Drawing.Image)
        Me.BtnPembelian.Location = New System.Drawing.Point(4, 19)
        Me.BtnPembelian.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Size = New System.Drawing.Size(112, 78)
        Me.BtnPembelian.TabIndex = 5
        Me.BtnPembelian.Text = "Pembelian"
        Me.BtnPembelian.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPembelian.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.BtnBarang)
        Me.GroupBox1.Controls.Add(Me.BtnKategori)
        Me.GroupBox1.Controls.Add(Me.BtnSatuan)
        Me.GroupBox1.Controls.Add(Me.BtnSupplier)
        Me.GroupBox1.Controls.Add(Me.BtnPelanggan)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(293, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(488, 101)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master"
        '
        'BtnBarang
        '
        Me.BtnBarang.AutoSize = True
        Me.BtnBarang.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnBarang.FlatAppearance.BorderSize = 0
        Me.BtnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarang.Image = CType(resources.GetObject("BtnBarang.Image"), System.Drawing.Image)
        Me.BtnBarang.Location = New System.Drawing.Point(420, 19)
        Me.BtnBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(91, 78)
        Me.BtnBarang.TabIndex = 8
        Me.BtnBarang.Text = "Barang"
        Me.BtnBarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'BtnKategori
        '
        Me.BtnKategori.AutoSize = True
        Me.BtnKategori.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnKategori.FlatAppearance.BorderSize = 0
        Me.BtnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKategori.Image = CType(resources.GetObject("BtnKategori.Image"), System.Drawing.Image)
        Me.BtnKategori.Location = New System.Drawing.Point(329, 19)
        Me.BtnKategori.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Size = New System.Drawing.Size(91, 78)
        Me.BtnKategori.TabIndex = 7
        Me.BtnKategori.Text = "Kaegori"
        Me.BtnKategori.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKategori.UseVisualStyleBackColor = True
        '
        'BtnSatuan
        '
        Me.BtnSatuan.AutoSize = True
        Me.BtnSatuan.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSatuan.FlatAppearance.BorderSize = 0
        Me.BtnSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSatuan.Image = CType(resources.GetObject("BtnSatuan.Image"), System.Drawing.Image)
        Me.BtnSatuan.Location = New System.Drawing.Point(212, 19)
        Me.BtnSatuan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSatuan.Name = "BtnSatuan"
        Me.BtnSatuan.Size = New System.Drawing.Size(117, 78)
        Me.BtnSatuan.TabIndex = 6
        Me.BtnSatuan.Text = "Satuan"
        Me.BtnSatuan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSatuan.UseVisualStyleBackColor = True
        '
        'BtnSupplier
        '
        Me.BtnSupplier.AutoSize = True
        Me.BtnSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSupplier.FlatAppearance.BorderSize = 0
        Me.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplier.Image = CType(resources.GetObject("BtnSupplier.Image"), System.Drawing.Image)
        Me.BtnSupplier.Location = New System.Drawing.Point(119, 19)
        Me.BtnSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Size = New System.Drawing.Size(93, 78)
        Me.BtnSupplier.TabIndex = 4
        Me.BtnSupplier.Text = "Supplier"
        Me.BtnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSupplier.UseVisualStyleBackColor = True
        '
        'BtnPelanggan
        '
        Me.BtnPelanggan.AutoSize = True
        Me.BtnPelanggan.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPelanggan.FlatAppearance.BorderSize = 0
        Me.BtnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPelanggan.Image = CType(resources.GetObject("BtnPelanggan.Image"), System.Drawing.Image)
        Me.BtnPelanggan.Location = New System.Drawing.Point(4, 19)
        Me.BtnPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPelanggan.Name = "BtnPelanggan"
        Me.BtnPelanggan.Size = New System.Drawing.Size(115, 78)
        Me.BtnPelanggan.TabIndex = 3
        Me.BtnPelanggan.Text = "Pelanggan"
        Me.BtnPelanggan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPelanggan.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(4, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(480, 78)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 146
        Me.LineShape1.X2 = 146
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 54
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnLogOut)
        Me.GroupBox2.Controls.Add(Me.BtnGantiPass)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox2.Location = New System.Drawing.Point(8, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(285, 101)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnKeluar.FlatAppearance.BorderSize = 0
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.Location = New System.Drawing.Point(247, 19)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(79, 78)
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnLogOut
        '
        Me.BtnLogOut.AutoSize = True
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnLogOut.FlatAppearance.BorderSize = 0
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.Image = CType(resources.GetObject("BtnLogOut.Image"), System.Drawing.Image)
        Me.BtnLogOut.Location = New System.Drawing.Point(160, 19)
        Me.BtnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(87, 78)
        Me.BtnLogOut.TabIndex = 5
        Me.BtnLogOut.Text = "LogOut"
        Me.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'BtnGantiPass
        '
        Me.BtnGantiPass.AutoSize = True
        Me.BtnGantiPass.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnGantiPass.FlatAppearance.BorderSize = 0
        Me.BtnGantiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGantiPass.Image = CType(resources.GetObject("BtnGantiPass.Image"), System.Drawing.Image)
        Me.BtnGantiPass.Location = New System.Drawing.Point(4, 19)
        Me.BtnGantiPass.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGantiPass.Name = "BtnGantiPass"
        Me.BtnGantiPass.Size = New System.Drawing.Size(156, 78)
        Me.BtnGantiPass.TabIndex = 4
        Me.BtnGantiPass.Text = "Ganti Password"
        Me.BtnGantiPass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGantiPass.UseVisualStyleBackColor = True
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1170, 489)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Buku & ATK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MnuLapBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MnuLapSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuPelanggan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuSatuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuKategori As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuPetugas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLapPelanggan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuGantiPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuPembelian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuPenjualan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuLapPembelian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLapPenjualan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPenjualan As System.Windows.Forms.Button
    Friend WithEvents BtnPembelian As System.Windows.Forms.Button
    Friend WithEvents BtnBarang As System.Windows.Forms.Button
    Friend WithEvents BtnKategori As System.Windows.Forms.Button
    Friend WithEvents BtnSatuan As System.Windows.Forms.Button
    Friend WithEvents BtnSupplier As System.Windows.Forms.Button
    Friend WithEvents BtnPelanggan As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents BtnGantiPass As System.Windows.Forms.Button
End Class
