Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class FrmPenjualan
    'Fungsi membersihkan Text
    Sub BersihkanText()
        LblTotal.Text = "0"
        Item.Text = ""
        TxtKode.Text = "U-1"
        TxtNama.Text = "Umum"
        TxtAlamat.Text = "-"
        TxtStatus.Text = "Retail"
        TxtDibayar.Text = ""
        LblKembali.Text = "0"
        Call FakturOtomatis()
    End Sub

    'Fungsi untuk membuat kolom pada DataGridView
    Sub BuatKolomBaru()
        DGV.Columns.Add("Kode", "Kode Barang / Scan Barcode")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Jenis", "Jenis")
        DGV.Columns.Add("Satuan", "Satuan")
        DGV.Columns.Add("Harga", "Harga")
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
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
    End Sub

    'Nomor Faktur Ototmatis
    Sub FakturOtomatis()
        cmd = New OleDbCommand("Select * from penjualan where faktur in (select max(faktur) from penjualan) order by faktur desc", Conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                urutan = Format(Now, "yyMMdd") + "0001"
            Else
                hitung = rd.GetString(0) + 1
                urutan = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        TxtFaktur.Text = urutan
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
            'Memisahkan angka dengan titik
            LblTotal.Text = Format(HitungHarga, "##,##")
        Next
    End Sub

    Private Sub FrmPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()
        Call BersihkanText()
    End Sub

    Private Sub PelangganBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganBtn.Click
        ' Cursor akan fokus di Grid dan menampilkan Form Data Pelanggan
        DGV.Focus()
        DGV.CurrentCell = DGV.Rows(0).Cells(0)
        FrmDataPelanggan.ShowDialog()
    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        'Edit Data Grid pada kolom pertama (Kode Barang)
        If e.ColumnIndex = 0 Then
            'Cari kode barang berdasarkan Grid kolom pertama
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                'Jika ditemukan maka tampil data
                DGV.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = rd.Item(2)
                DGV.Rows(e.RowIndex).Cells(3).Value = rd.Item(4)
                'Jika pelanggan retail, maka harga jual retail, 
                'selainnya harga jual grosir
                If TxtStatus.Text = "Retail" Then
                    DGV.Rows(e.RowIndex).Cells(4).Value = rd.Item(10)
                Else
                    DGV.Rows(e.RowIndex).Cells(4).Value = rd.Item(11)
                End If
                DGV.Rows(e.RowIndex).Cells(5).Value = 1
                DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                Call TotalItem()
                Call TotalHarga()
            Else
                MsgBox("Kode barang tidak terdaftar")
                DGV.Rows(e.RowIndex).Cells(0).Value = ""
                DGV.Rows(e.RowIndex).Cells(1).Value = ""
                DGV.Rows(e.RowIndex).Cells(2).Value = ""
                DGV.Rows(e.RowIndex).Cells(3).Value = ""
                DGV.Rows(e.RowIndex).Cells(4).Value = ""
                DGV.Rows(e.RowIndex).Cells(5).Value = ""
                DGV.Rows(e.RowIndex).Cells(6).Value = ""
                DGV.CurrentCell = DGV.Rows(0).Cells(0)
            End If
        End If
        'Edit Data Grid pada kolom keenam (Harga Beli)
        If e.ColumnIndex = 5 Then
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                'Cek stock barang apakah mencukupi
                If DGV.Rows(e.RowIndex).Cells(5).Value > rd.Item(12) Then
                    MsgBox("Stok barang hanya ada " & rd.Item(12) & "")
                    DGV.Rows(e.RowIndex).Cells(5).Value = 1
                    DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    DGV.Rows(e.RowIndex).Cells(6).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub
    Private Sub GridViewTextBox_KeyPress(ByVal sender As Object, ByVal ex As KeyPressEventArgs)
        'Input hanya angka pada kolom jumlah
        If DGV.CurrentCell.ColumnIndex = 5 Then
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
            'Jika tombol F1 ditekan, maka cursor fokus ke text bayar
            Case Keys.F1
                TxtDibayar.Focus()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F2
                FrmDataBarang.Text = "Data Barang - Penjualan"
                FrmDataBarang.ShowDialog()
                'Jika tombol UP ditekan,  maka cursor fokus ke jumlah jual
            Case Keys.Up
                DGV.CurrentCell = DGV.Rows(0).Cells(5)
        End Select
    End Sub

    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(13) Then 'Tombol Enter
            Call TotalItem()
            Call TotalHarga()
        ElseIf e.KeyChar = Chr(27) Then 'Tombol Esc
            Call BersihkanText()
            DGV.Columns.Clear()
            Call BuatKolomBaru()
            DGV.Focus()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub TxtDibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            'Hitung jumlah kembalian
            If Val(TxtDibayar.Text) < Val(Replace(LblTotal.Text, ".", "")) Then
                MsgBox("Pembayaran kurang")
                LblKembali.Text = ""
                TxtDibayar.Focus()
                Exit Sub
            ElseIf Val(TxtDibayar.Text) = Val(Replace(LblTotal.Text, ".", "")) Then
                LblKembali.Text = 0
                BtnSimpan.Focus()
            Else
                LblKembali.Text = Format(Val(TxtDibayar.Text) - Val(Replace(LblTotal.Text, ".", "")), "##,##")
                BtnSimpan.Focus()
            End If
        ElseIf e.KeyChar = Chr(27) Then 'Tombol Esc
            Call BersihkanText()
            DGV.Columns.Clear()
            Call BuatKolomBaru()
            DGV.Focus()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call BersihkanText()
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        DGV.Focus()
    End Sub

    Private Sub BtnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarang.Click
        FrmDataBarang.Text = "Data Barang - Penjualan"
        FrmDataBarang.ShowDialog()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If LblTotal.Text = "0" Or TxtDibayar.Text = "" Or LblKembali.Text = "" Or Item.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            Exit Sub
        End If

        'simpan ke tabel penjualan
        Dim simpanmaster As String = "Insert into penjualan(faktur,tanggal,total,dibayar,kembali,KodePtg,Kode_Pelanggan) values " & _
        "('" & TxtFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & _
        Val(Replace(LblTotal.Text, ".", "")) & "','" & Val(TxtDibayar.Text) & _
        "','" & Val(Replace(LblKembali.Text, ".", "")) & "','" & _
        FrmMenuUtama.Panel1.Text & "','" & TxtKode.Text & "')"
        cmd = New OleDbCommand(simpanmaster, Conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To DGV.Rows.Count - 2
            'simpan ke tabel detail
            Dim sqlsimpan As String = "Insert into detailjual (faktur,kode_Barang,nama_Barang,harga_Jual,jumlah,subtotal) values " & _
            "('" & TxtFaktur.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "','" & DGV.Rows(baris).Cells(6).Value & "')"
            cmd = New OleDbCommand(sqlsimpan, Conn)
            cmd.ExecuteNonQuery()

            'kurangi stok barang
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim kurangistok As String = "update barang set stock= '" & rd.Item(12) - DGV.Rows(baris).Cells(5).Value & "' where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'"
                cmd = New OleDbCommand(kurangistok, Conn)
                cmd.ExecuteNonQuery()
            End If
        Next baris

        'Tampil bukti faktur
        FrmFakturJual.CrystalReportViewer1.SelectionFormula = "{Penjualan.Faktur} ='" & TxtFaktur.Text & "' "
        FrmFakturJual.CrystalReportViewer1.RefreshReport()
        FrmFakturJual.ShowDialog()

        DGV.Columns.Clear()
        Call BuatKolomBaru()
        Call FakturOtomatis()
        Call BersihkanText()

        DGV.Focus()
        DGV.CurrentCell = DGV.Rows(0).Cells(0)

    End Sub

    Private Sub BtnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class