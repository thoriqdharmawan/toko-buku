Imports System.Data.OleDb
Public Class FrmBarang
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Bersih()
        TxtKode.Text = ""
        TxtNama.Text = ""
        CmbKategori.Text = ""
        CmbSatuan.Text = ""
        TxtPengarang.Text = ""
        TxtPenerbit.Text = ""
        TxtTahun.Text = ""
        TxtISBN.Text = ""
        TxtHrgBeli.Text = ""
        TxtHrgJualRetail.Text = ""
        TxtHargaJualGrosir.Text = ""
        TxtStock.Text = ""
        TxtKode.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    ' Membuat prosedur dengan nama TampilGrid untuk menampilkan data Barang-
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Barang", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Barang")
        DGV.DataSource = (ds.Tables("Barang"))
        DGV.ReadOnly = True
    End Sub

    ' Membuat prosedur dengan nama TampilKategori untuk menampilkan Kategori-
    ' ke dalam combobox kategori
    Sub TampilKategori()
        cmd = New OleDbCommand("select * FROM Kategori", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            CmbKategori.Items.Add(rd.Item(0))
        Loop
    End Sub

    ' Membuat prosedur dengan nama TampilSatuan untuk menampilkan satuan Barang-
    ' ke dalam combobox satuan
    Sub TampilSatuan()
        cmd = New OleDbCommand("select * FROM Satuan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            CmbSatuan.Items.Add(rd.Item(0))
        Loop
    End Sub

    ' Memanggil prosedur yang dibuat tadi saat form dijalankan
    Private Sub FrmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call TampilKategori()
        Call TampilSatuan()
        Call Bersih()
    End Sub

    Private Sub TxtKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            ' Jika di Enter, maka proses cari kode barang
            cmd = New OleDbCommand("select * from Barang where Kode_Barang='" & TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika kode barang ada, maka tampilkan data
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("Kode_Barang")
                TxtNama.Text = rd.Item("Nama_Barang")
                CmbKategori.Text = rd.Item("Kode_Kategori")
                CmbSatuan.Text = rd.Item("Satuan")
                TxtPengarang.Text = rd.Item("Pengarang")
                TxtPenerbit.Text = rd.Item("Penerbit")
                TxtTahun.Text = rd.Item("Tahun")
                TxtISBN.Text = rd.Item("ISBN")
                TxtHrgBeli.Text = rd.Item("Harga_Beli")
                TxtHrgJualRetail.Text = rd.Item("Harga_Jual_Retail")
                TxtHargaJualGrosir.Text = rd.Item("Harga_Jual_Grosir")
                TxtStock.Text = rd.Item("Stock")

                Dim JenisBarang As String
                JenisBarang = rd.Item("Jenis")
                If JenisBarang = "Buku" Then
                    Rd1.Checked = True
                Else
                    Rd2.Checked = True
                End If

                TxtKode.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnUbah.Enabled = True
                BtnBatal.Focus()
            Else
                'Jika kode barang tidak ada maka cursor focus ke txtnama
                TxtNama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            Rd1.Focus()
        End If
    End Sub


    Private Sub CmbKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKategori.SelectedIndexChanged
        CmbSatuan.Focus()
    End Sub

    Private Sub CmbSatuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSatuan.SelectedIndexChanged
        TxtPengarang.Focus()
    End Sub

    Private Sub TxtPengarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPengarang.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPenerbit.Focus()
        End If
    End Sub

    Private Sub TxtPenerbit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPenerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTahun.Focus()
        End If
    End Sub

    Private Sub TxtTahun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTahun.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtISBN.Focus()
        End If
    End Sub

    Private Sub TxtISBN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtISBN.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHrgBeli.Focus()
        End If
    End Sub

    Private Sub TxtHrgBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHrgBeli.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHrgJualRetail.Focus()
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtHrgJualRetail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHrgJualRetail.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHargaJualGrosir.Focus()
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True

    End Sub

    Private Sub TxtHargaJualGrosir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHargaJualGrosir.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtStock.Focus()
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True

    End Sub

    Private Sub TxtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStock.KeyPress
        If e.KeyChar = Chr(13) Then
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnUbah.Focus()
            End If
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True

    End Sub


    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text = "" Or TxtNama.Text = "" Then
            MsgBox("Kode / Nama Barang masih ada yang kosong")
            Exit Sub
        Else
            '## Cek kode barang apakah sudah ada sebelumnya..
            cmd = New OleDbCommand("Select * from Barang where Kode_Barang='" & _
                                   TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()

            '## Jika kode barang ada maka proses simpan 
            If Not rd.HasRows Then
                Dim JenisBrg As String
                If Rd1.Checked = True Then
                    JenisBrg = "Buku"
                Else
                    JenisBrg = "ATK"
                End If

                '## Proses Simpan :
                Dim sqltambah As String = "Insert into Barang(Kode_Barang,Nama_Barang,Jenis,Kode_Kategori,Satuan,Pengarang,Penerbit,Tahun,ISBN,Harga_Beli,Harga_Jual_Retail,Harga_Jual_Grosir,Stock) values " & _
                "('" & TxtKode.Text & "','" & TxtNama.Text & "','" & JenisBrg & "','" & _
                CmbKategori.Text & "','" & CmbSatuan.Text & "','" & TxtPengarang.Text & _
                "','" & TxtPenerbit.Text & "','" & TxtTahun.Text & "','" & TxtISBN.Text & _
                "','" & Val(TxtHrgBeli.Text) & "','" & Val(TxtHrgJualRetail.Text) & _
                "','" & Val(TxtHargaJualGrosir.Text) & "','" & Val(TxtStock.Text) & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                '## Jika kode barang sudah ada maka tidak dapat menyimpan..
                MsgBox("Kode Barang telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                Call TampilGrid()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Bersih()
        Call TampilGrid()
        TxtKode.Focus()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            BtnBatal.Focus()
            Exit Sub
        Else
            Dim JnsBrg As String
            If Rd1.Checked = True Then
                JnsBrg = "Buku"
            Else
                JnsBrg = "ATK"
            End If

            '## Ubah data barang berdasarkan kode barang ..
            cmd = New OleDbCommand("Update Barang set Nama_Barang='" & _
                                   TxtNama.Text & "',Jenis='" & JnsBrg & "',kode_kategori='" & CmbKategori.Text & "',satuan='" & _
                                   CmbSatuan.Text & "',Pengarang='" & TxtPengarang.Text & _
                                   "',Penerbit='" & TxtPenerbit.Text & "',Tahun='" & TxtTahun.Text & _
                                   "',ISBN='" & TxtISBN.Text & "',harga_Beli='" & _
                                   Val(TxtHrgBeli.Text) & "',Harga_Jual_retail='" & _
                                   Val(TxtHrgJualRetail.Text) & "',harga_Jual_Grosir='" & _
                                   Val(TxtHargaJualGrosir.Text) & "',stock='" & _
                                   Val(TxtStock.Text) & "' where Kode_Barang='" & TxtKode.Text & "'", Conn)
            cmd.ExecuteNonQuery()
            Call Bersih()
            Call TampilGrid()
            TxtKode.Focus()
        End If

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            BtnBatal.Focus()
            Exit Sub
        Else
            '## Hapus data barang berdasarkan kode barang..
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Barang where Kode_Barang='" & _
                                       TxtKode.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        If RbNama.Checked = True Then
            'Cari Barang berdasarkan nama Barang
            da = New OleDbDataAdapter("Select * from Barang where nama_Barang like '%" & TxtCari.Text & "%' order by nama_Barang asc", Conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Barang")
            DGV.DataSource = (ds.Tables("Barang"))
            DGV.ReadOnly = True
        ElseIf RbKode.Checked = True Then
            'Cari Barang Berdasarkan Kode Barang
            da = New OleDbDataAdapter("Select * from Barang where kode_Barang like '%" & TxtCari.Text & "%' order by kode_Barang asc", Conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Barang")
            DGV.DataSource = (ds.Tables("Barang"))
            DGV.ReadOnly = True
        End If
    End Sub

    Private Sub BtnKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKategori.Click
        FrmKategori.Show()
    End Sub

    Private Sub BtnSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSatuan.Click
        FrmSatuan.Show()
    End Sub
End Class