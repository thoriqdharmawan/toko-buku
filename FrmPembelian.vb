Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class FrmPembelian
    'Fungsi membersihkan Text
    Sub BersihkanText()
        LblTotal.Text = "0"
        TxtFaktur.Text = ""
        Item.Text = ""
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
    End Sub

    'Fungsi untuk membuat kolom pada DataGridView
    Sub BuatKolomBaru()
        DGV.Columns.Add("Kode", "Kode Barang / Scan Barcode")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Jenis", "Jenis")
        DGV.Columns.Add("Satuan", "Satuan")
        DGV.Columns.Add("Harga", "Harga Beli")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Total", "SubTotal")
        Call AturLebarKolom()
    End Sub

    'Mengatur Lebar kolom grid
    Sub AturLebarKolom()
        DGV.Columns(0).Width = 180
        DGV.Columns(1).Width = 300
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 75
        DGV.Columns(4).Width = 120
        DGV.Columns(5).Width = 75
        DGV.Columns(6).Width = 120
        'kunci kolom grid
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
    End Sub

    'Menghitung Total Barang / Item
    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungItem = HitungItem + Val(DGV.Rows(I).Cells(5).Value)
            Item.Text = HitungItem
        Next
    End Sub

    'Menghitung Total Harga
    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungHarga = HitungHarga + Val(DGV.Rows(I).Cells(6).Value)
            'Memisahkan angka dengan titik, seperti 100000 menjadi 100.000
            LblTotal.Text = Format(HitungHarga, "##,##")
        Next
    End Sub
    Private Sub FrmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()
        Call BersihkanText()
    End Sub

    Private Sub TxtFaktur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFaktur.KeyPress
        If e.KeyChar = Chr(13) Then
            'Cari nomor faktur apakah sudah ada sebelumnya
            cmd = New OleDbCommand("Select * from Pembelian where Faktur='" & _
                                   TxtFaktur.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                BtnSupplier.Focus()
            Else
                MsgBox("Nomor Faktur telah ada sebelumnya, harap ganti nomor faktur", vbInformation + vbOKOnly, "Pesan")
                TxtFaktur.Focus()
            End If
        End If
    End Sub

    Private Sub BtnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupplier.Click
        ' Cursor akan fokus di Grid dan menampilkan Form Data Supplier
        DGV.Focus()
        DGV.CurrentCell = DGV.Rows(0).Cells(0)
        FrmDataSupplier.ShowDialog()
    End Sub

    'Edit data Grid
    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        'Edit Data Grid pada kolom pertama (Kode Barang)
        If e.ColumnIndex = 0 Then
            'Cari kode barang berdasarkan Grid kolom pertama
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                'Jika ditemukan maka tampil data
                DGV.CurrentCell = DGV.Rows(e.RowIndex).Cells(4)
                DGV.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = rd.Item(2)
                DGV.Rows(e.RowIndex).Cells(3).Value = rd.Item(4)
                DGV.Rows(e.RowIndex).Cells(4).Value = rd.Item(9)
                DGV.Rows(e.RowIndex).Cells(5).Value = 1
                DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                Call TotalItem()
                Call TotalHarga()
                DGV.CurrentCell = DGV(4, 0)
            Else
                MsgBox("Kode barang tidak terdaftar")
                DGV.Rows(e.RowIndex).Cells(0).Value = ""
                DGV.Rows(e.RowIndex).Cells(1).Value = ""
                DGV.Rows(e.RowIndex).Cells(2).Value = ""
                DGV.Rows(e.RowIndex).Cells(3).Value = ""
                DGV.Rows(e.RowIndex).Cells(4).Value = ""
                DGV.Rows(e.RowIndex).Cells(5).Value = ""
                DGV.Rows(e.RowIndex).Cells(6).Value = ""
            End If
        End If
        'Edit Data Grid pada kolom kelima (Harga Beli)
        If e.ColumnIndex = 4 Then
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                'Cek apakah harga beli sama dengan yang di master barang,
                'Jika harga beli tdk sama maka muncul pesan
                If DGV.Rows(e.RowIndex).Cells(4).Value <> rd.Item(9) Then
                    MsgBox("Harga Beli Tidak sama dengan yang ada di master, Akan otomatis merubah harga beli menjadi " & DGV.Rows(e.RowIndex).Cells(4).Value & "")
                    DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If
            DGV.CurrentCell = DGV.Rows(e.RowIndex).Cells(5)
        End If
        'Edit Data Grid pada kolom ke enam (Jumlah Beli)
        'Hitung Sub Total
        If e.ColumnIndex = 5 Then
            DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
            Call TotalItem()
            Call TotalHarga()
            DGV.CurrentCell = DGV.Rows(e.RowIndex).Cells(0)
        End If
    End Sub
    Private Sub GridViewTextBox_KeyPress(ByVal sender As Object, ByVal ex As KeyPressEventArgs)
        'Input hanya angka pada kolom harga dan jumlah
        If DGV.CurrentCell.ColumnIndex = 5 Or DGV.CurrentCell.ColumnIndex = 4 Then
            If ((Asc(ex.KeyChar) < 48 Or Asc(ex.KeyChar) > 57) And Asc(ex.KeyChar) <> 8) Then
                ex.Handled = True
            End If
        End If
    End Sub

    Private Sub DGV_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        If e.Control.GetType.ToString() = "System.Windows.Forms.DataGridViewTextBoxEditingControl" Then
            Dim c As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler c.KeyPress, AddressOf GridViewTextBox_KeyPress
            AddHandler c.KeyPress, AddressOf GridViewTextBox_KeyPress
        End If
    End Sub

    Private Sub DGV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV.KeyDown
        Select Case e.KeyCode
            'Jika tombol F1 ditekan, maka cursor fokus ke tombol simpan
            Case Keys.F1
                BtnSimpan.Focus()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F2
                FrmDataBarang.Text = "Data Barang - Pembelian"
                FrmDataBarang.ShowDialog()
        End Select
    End Sub

    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(13) Then 'Tombol Enter
            Call TotalItem()
            Call TotalHarga()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        ElseIf e.KeyChar = Chr(27) Then 'Tombol Esc
            Call BersihkanText()
            DGV.Columns.Clear()
            Call BuatKolomBaru()
            DGV.Focus()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call BersihkanText()
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        DGV.Focus()
    End Sub

    Private Sub BtnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarang.Click
        FrmDataBarang.Text = "Data Barang - Pembelian"
        FrmDataBarang.ShowDialog()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text = "" Or TxtFaktur.Text = "" Or LblTotal.Text = "0" Or Item.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau Supplier / No Faktur masih kosong")
            Exit Sub
        End If
        cmd = New OleDbCommand("Select * from Pembelian where Faktur='" & _
                                   TxtFaktur.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            'simpan ke tabel Pembelian
            Dim simpanmaster As String = "Insert into Pembelian(faktur,tanggal,total,KodePtg,Kode_Supplier) values " & _
            "('" & TxtFaktur.Text & "','" & Format(DtTgl.Value, "dd/MM/yyyy") & "','" & _
            Val(Replace(LblTotal.Text, ".", "")) & "','" & FrmMenuUtama.Panel1.Text & "','" & TxtKode.Text & "')"
            cmd = New OleDbCommand(simpanmaster, Conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To DGV.Rows.Count - 2
                'simpan ke tabel detail
                Dim sqlsimpan As String = "Insert into detailBeli (faktur,kode_Barang,nama_Barang,harga_Beli,jumlah,subtotal) values " & _
                "('" & TxtFaktur.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "','" & DGV.Rows(baris).Cells(6).Value & "')"
                cmd = New OleDbCommand(sqlsimpan, Conn)
                cmd.ExecuteNonQuery()

                'Tambah stok barang + Update Harga Beli
                cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Dim kurangistok As String = "update barang set stock= '" & rd.Item(12) + DGV.Rows(baris).Cells(5).Value & "',Harga_beli='" & _
                        DGV.Rows(baris).Cells(4).Value & "' where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'"
                    cmd = New OleDbCommand(kurangistok, Conn)
                    cmd.ExecuteNonQuery()
                End If
            Next baris
            'Tampil bukti faktur pembelian
            FrmLapPembelian.CrystalReportViewer1.SelectionFormula = "{Pembelian.Faktur} ='" & TxtFaktur.Text & "' "
            FrmLapPembelian.CrystalReportViewer1.RefreshReport()
            FrmLapPembelian.ShowDialog()
            DGV.Columns.Clear()
            Call BuatKolomBaru()
            Call BersihkanText()
            TxtFaktur.Focus()
        Else
            MsgBox("Nomor Faktur telah ada sebelumnya, harap ganti nomor faktur", vbInformation + vbOKOnly, "Pesan")
            TxtFaktur.Focus()
        End If
    End Sub

End Class