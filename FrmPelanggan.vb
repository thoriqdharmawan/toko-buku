Imports System.Data.OleDb
Public Class FrmPelanggan
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Bersih()
        TxtKode.Enabled = True
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNo.Text = ""
        CmbStatus.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    ' Membuat prosedur dengan nama TampilGrid untuk menampilkan data Barang-
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Pelanggan", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DGV.DataSource = (ds.Tables("Pelanggan"))
        DGV.ReadOnly = True
    End Sub
    Private Sub FrmPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Bersih()
        CmbStatus.Items.Add("Retail")
        CmbStatus.Items.Add("Grosir")
    End Sub

    Private Sub TxtKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            ' Cari kode pelanggan
            cmd = New OleDbCommand("select * from Pelanggan where Kode_Pelanggan='" & TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                ' Jika kode pelanggan ada maka tampil data
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("Kode_Pelanggan")
                TxtNama.Text = rd.Item("Nama_Pelanggan")
                TxtAlamat.Text = rd.Item("Alamat_Pelanggan")
                TxtNo.Text = rd.Item("No_Telp")
                CmbStatus.Text = rd.Item("Status_Pelanggan")
                TxtKode.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnUbah.Enabled = True
                BtnBatal.Focus()
            Else
                'Jika tdk ada cursor focus ke text nama
                TxtNama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAlamat.Focus()
        End If
    End Sub

    Private Sub TxtAlamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNo.Focus()
        End If
    End Sub

    Private Sub TxtNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNo.KeyPress
        If e.KeyChar = Chr(13) Then
            CmbStatus.Focus()
        End If
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStatus.SelectedIndexChanged
        If BtnSimpan.Enabled = True Then
            BtnSimpan.Focus()
        Else
            BtnUbah.Focus()
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text = "" Or CmbStatus.Text = "" Then
            MsgBox("Kode / status masih kosong")
            Exit Sub
        Else
            'Cari kode pelanggan apakah sudah ada
            cmd = New OleDbCommand("Select * from Pelanggan where Kode_Pelanggan='" & _
                                   TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                'Jika kode pelanggan tdk ada, maka proses simpan
                Dim sqltambah As String = "Insert into Pelanggan(kode_pelanggan,nama_pelanggan,alamat_Pelanggan,No_Telp,Status_Pelanggan) values " & _
                "('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & _
                TxtNo.Text & "','" & CmbStatus.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                'Jika kode ada, maka keluar pesan
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
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
            '## Ubah data Pelanggan berdasarkan kode
            cmd = New OleDbCommand("Update Pelanggan set Nama_Pelanggan='" & _
                                   TxtNama.Text & "',alamat_Pelanggan='" & TxtAlamat.Text & _
                                   "',No_telp='" & TxtNo.Text & "',status_pelanggan='" & _
                                   CmbStatus.Text & "' where Kode_Pelanggan='" & TxtKode.Text & "'", Conn)
            cmd.ExecuteNonQuery()
            Call Bersih()
            Call TampilGrid()
            TxtKode.Focus()
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            TxtNama.Focus()
            Exit Sub
        Else
            '## Hapus data Pelanggan berdasarkan kode pelanggan
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Pelanggan where Kode_Pelanggan='" & _
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
        'Cari Pelanggan berdasarkan nama pelanggan
        da = New OleDbDataAdapter("Select * from Pelanggan where nama_Pelanggan like '%" & TxtCari.Text & "%' order by nama_Pelanggan asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DGV.DataSource = (ds.Tables("Pelanggan"))
        DGV.ReadOnly = True
    End Sub
End Class