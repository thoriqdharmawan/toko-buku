Imports System.Data.OleDb
Public Class FrmKategori
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Bersih()
        TxtKode.Enabled = True
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtNo.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    ' Membuat prosedur dengan nama Tampilkan untuk menampilkan data kategori-
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Kategori", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Kategori")
        DGV.DataSource = (ds.Tables("Kategori"))
        DGV.ReadOnly = True
    End Sub

    ' Memanggil prosedur Koneksi dan TampilkanGrid serta Bersih saat form dijalankan
    Private Sub FrmKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Bersih()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Bersih()
        Call TampilGrid()
        TxtKode.Focus()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtNo.Text = "" Then
            MsgBox("Data masih ada yang kosong")
            Exit Sub
        Else
            'Cari kode kategori apakah sudah ada sebelumnya
            cmd = New OleDbCommand("Select * from Kategori where Kode_Kategori='" & _
                                   TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                'Jika kode belum ada maka proses simpan
                Dim sqltambah As String = "Insert into Kategori values " & _
                "('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtNo.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                'jika kode sudah ada maka muncul pesan :
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                Call TampilGrid()
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            TxtNama.Focus()
            Exit Sub
        Else
            'Pesan konfirmasi hapus,jika ya maka akan dihapus
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Kategori where Kode_Kategori='" & _
                                       TxtKode.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                'jika tidak maka batal hapus
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            End If
        End If
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            BtnBatal.Focus()
            Exit Sub
        Else
            ' Ubah data kategori berdasarkan kode kategori
            cmd = New OleDbCommand("Update Kategori set Nama_Kategori='" & _
                                   TxtNama.Text & "',No_rak='" & TxtNo.Text & _
                                   "' where Kode_Kategori='" & TxtKode.Text & "'", Conn)
            cmd.ExecuteNonQuery()
            Call Bersih()
            Call TampilGrid()
            TxtKode.Focus()
        End If
    End Sub

    Private Sub TxtKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKode.KeyPress
        'Jika text kode di enter maka : 
        If e.KeyChar = Chr(13) Then
            'cari kode kategori
            cmd = New OleDbCommand("select * from Kategori where Kode_Kategori='" & TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika kode ditemukan, maka muncul data berdasarkan kode
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("Kode_Kategori")
                TxtNama.Text = rd.Item("Nama_Kategori")
                TxtNo.Text = rd.Item("No_Rak")
                TxtKode.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnUbah.Enabled = True
                BtnBatal.Focus()
            Else
                'Jika tidak ada maka cursor focus ke nama
                TxtNama.Focus()
            End If
        End If
    End Sub
    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNo.Focus()
        End If
    End Sub
    Private Sub TxtNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNo.KeyPress
        If e.KeyChar = Chr(13) Then
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnUbah.Focus()
            End If
        End If

    End Sub

End Class