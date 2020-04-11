<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPenjualan))
        Me.TxtKasir = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.PelangganBtn = New System.Windows.Forms.Button()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtTgl = New System.Windows.Forms.DateTimePicker()
        Me.TxtFaktur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.TxtDibayar = New System.Windows.Forms.TextBox()
        Me.LblKembali = New System.Windows.Forms.Label()
        Me.Item = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtKasir
        '
        Me.TxtKasir.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKasir.Enabled = False
        Me.TxtKasir.Location = New System.Drawing.Point(825, 86)
        Me.TxtKasir.Name = "TxtKasir"
        Me.TxtKasir.Size = New System.Drawing.Size(147, 20)
        Me.TxtKasir.TabIndex = 1011
        Me.TxtKasir.Text = "Admin"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(768, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 1010
        Me.Label12.Text = "Kasir :"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNama.Enabled = False
        Me.TxtNama.Location = New System.Drawing.Point(243, 83)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(189, 20)
        Me.TxtNama.TabIndex = 1009
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAlamat.Enabled = False
        Me.TxtAlamat.Location = New System.Drawing.Point(243, 104)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ReadOnly = True
        Me.TxtAlamat.Size = New System.Drawing.Size(189, 20)
        Me.TxtAlamat.TabIndex = 1008
        '
        'PelangganBtn
        '
        Me.PelangganBtn.Image = CType(resources.GetObject("PelangganBtn.Image"), System.Drawing.Image)
        Me.PelangganBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PelangganBtn.Location = New System.Drawing.Point(11, 100)
        Me.PelangganBtn.Name = "PelangganBtn"
        Me.PelangganBtn.Size = New System.Drawing.Size(140, 23)
        Me.PelangganBtn.TabIndex = 1007
        Me.PelangganBtn.Text = "Daftar Pelanggan [F4]"
        Me.PelangganBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PelangganBtn.UseVisualStyleBackColor = True
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKode.Enabled = False
        Me.TxtKode.Location = New System.Drawing.Point(157, 82)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(80, 20)
        Me.TxtKode.TabIndex = 1012
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 1006
        Me.Label6.Text = "Kode Pelanggan :"
        '
        'DtTgl
        '
        Me.DtTgl.CustomFormat = "dd/MM/yyyy"
        Me.DtTgl.Enabled = False
        Me.DtTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtTgl.Location = New System.Drawing.Point(662, 107)
        Me.DtTgl.Name = "DtTgl"
        Me.DtTgl.Size = New System.Drawing.Size(100, 20)
        Me.DtTgl.TabIndex = 1005
        '
        'TxtFaktur
        '
        Me.TxtFaktur.BackColor = System.Drawing.SystemColors.Info
        Me.TxtFaktur.Enabled = False
        Me.TxtFaktur.Location = New System.Drawing.Point(662, 86)
        Me.TxtFaktur.Name = "TxtFaktur"
        Me.TxtFaktur.ReadOnly = True
        Me.TxtFaktur.Size = New System.Drawing.Size(100, 20)
        Me.TxtFaktur.TabIndex = 1004
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(558, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1003
        Me.Label2.Text = "Tgl Transaksi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1002
        Me.Label1.Text = "No Faktur :"
        '
        'TxtStatus
        '
        Me.TxtStatus.BackColor = System.Drawing.SystemColors.Info
        Me.TxtStatus.Enabled = False
        Me.TxtStatus.Location = New System.Drawing.Point(157, 104)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(80, 20)
        Me.TxtStatus.TabIndex = 1013
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1014
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1020, 554)
        Me.ShapeContainer1.TabIndex = 1015
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 11
        Me.LineShape2.X2 = 1018
        Me.LineShape2.Y1 = 132
        Me.LineShape2.Y2 = 132
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 14
        Me.LineShape1.X2 = 1021
        Me.LineShape1.Y1 = 72
        Me.LineShape1.Y2 = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(113, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 20)
        Me.Label3.TabIndex = 1016
        Me.Label3.Text = "Toko Buku ""Gunung Ajeng"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 13)
        Me.Label4.TabIndex = 1017
        Me.Label4.Text = "Jl. Perintis Kemerdekaan No 70 Jakarta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 1018
        Me.Label5.Text = "Telp : (021) 98989898"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTotal.Font = New System.Drawing.Font("Chaney", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Red
        Me.LblTotal.Location = New System.Drawing.Point(696, 7)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(310, 59)
        Me.LblTotal.TabIndex = 1020
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Chaney", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(613, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 59)
        Me.Label7.TabIndex = 1021
        Me.Label7.Text = "Rp"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(11, 144)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(996, 305)
        Me.DGV.TabIndex = 1022
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BtnBarang)
        Me.GroupBox1.Controls.Add(Me.TxtDibayar)
        Me.GroupBox1.Controls.Add(Me.LblKembali)
        Me.GroupBox1.Controls.Add(Me.Item)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 455)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 81)
        Me.GroupBox1.TabIndex = 1026
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(826, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 1013
        Me.Label10.Text = "Kembali :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(826, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1012
        Me.Label9.Text = "Dibayar :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(694, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 1011
        Me.Label13.Text = "Total Item :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(127, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 13)
        Me.Label16.TabIndex = 163
        Me.Label16.Text = "[ Up ] - Edit Jumlah Barang"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(127, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 162
        Me.Label15.Text = "[ Esc ] - Batal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(13, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "[ F2 ] - Daftar Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(13, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "[ F1 ] - Bayar"
        '
        'BtnBarang
        '
        Me.BtnBarang.Image = CType(resources.GetObject("BtnBarang.Image"), System.Drawing.Image)
        Me.BtnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBarang.Location = New System.Drawing.Point(316, 13)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(123, 24)
        Me.BtnBarang.TabIndex = 158
        Me.BtnBarang.Text = "Daftar Barang [F2]"
        Me.BtnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'TxtDibayar
        '
        Me.TxtDibayar.Location = New System.Drawing.Point(889, 15)
        Me.TxtDibayar.Name = "TxtDibayar"
        Me.TxtDibayar.Size = New System.Drawing.Size(100, 20)
        Me.TxtDibayar.TabIndex = 157
        Me.TxtDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblKembali
        '
        Me.LblKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblKembali.Location = New System.Drawing.Point(889, 38)
        Me.LblKembali.Name = "LblKembali"
        Me.LblKembali.Size = New System.Drawing.Size(100, 20)
        Me.LblKembali.TabIndex = 154
        Me.LblKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Item
        '
        Me.Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Item.Location = New System.Drawing.Point(760, 17)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(48, 20)
        Me.Item.TabIndex = 152
        Me.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(445, 13)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(123, 24)
        Me.BtnBatal.TabIndex = 151
        Me.BtnBatal.Text = "&Batal [Esc]"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(575, 13)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(109, 24)
        Me.BtnSimpan.TabIndex = 150
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.TxtKasir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.PelangganBtn)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtTgl)
        Me.Controls.Add(Me.TxtFaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtKasir As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents PelangganBtn As System.Windows.Forms.Button
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Item As System.Windows.Forms.Label
    Friend WithEvents TxtDibayar As System.Windows.Forms.TextBox
    Friend WithEvents LblKembali As System.Windows.Forms.Label
    Friend WithEvents BtnBarang As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
