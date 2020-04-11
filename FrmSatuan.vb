Imports System.Data.OleDb
Public Class FrmSatuan
    ' Membuat prosedur dengan nama Tampilkan untuk menampilkan data satuan-
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Satuan", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Satuan")
        DGV.DataSource = (ds.Tables("Satuan"))
        DGV.ReadOnly = True
    End Sub

    Private Sub FrmSatuan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TxtNama.Focus()
    End Sub
    ' Memanggil prosedur Koneksi dan TampilkanGrid saat form dijalankan
    Private Sub FrmSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        BtnHapus.Enabled = False
    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            'Cari nama satuan
            cmd = New OleDbCommand("select * from Satuan where Nama_Satuan='" & TxtNama.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika satuan ada, maka tampil data
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                TxtNama.Text = rd.Item("nama_satuan")
                TxtNama.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnBatal.Focus()
            Else
                BtnHapus.Enabled = False
                BtnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNama.TextChanged

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TxtNama.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = False
        TxtNama.Text = ""
        TxtNama.Focus()
        Call TampilGrid()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Then
            MsgBox("Nama Masih Kosong")
            Exit Sub
        Else
            'Cari data satuan terlebih dahulu
            cmd = New OleDbCommand("Select * from Satuan where Nama_Satuan='" & _
                                   TxtNama.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                'Jika nama satuan belum ada, maka proses simpan
                Dim sqltambah As String = "Insert into Satuan(Nama_Satuan) values " & _
                "('" & TxtNama.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                TxtNama.Enabled = True
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNama.Text = ""
                TxtNama.Focus()
                Call TampilGrid()
            Else
                'Jika sudah ada maka tampil pesan
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                Call TampilGrid()
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TxtNama.Text = "" Then
            MsgBox("Nama Masih Kosong")
            TxtNama.Focus()
            Exit Sub
        Else
            'Pesan Konfirmasi untuk menghapus, jika ya maka proses hapus
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Satuan where Nama_Satuan='" & _
                                       TxtNama.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                TxtNama.Enabled = True
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNama.Text = ""
                TxtNama.Focus()
                Call TampilGrid()
            Else
                'jika no maka tidak jadi hapus
                TxtNama.Enabled = True
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNama.Text = ""
                TxtNama.Focus()
                Call TampilGrid()
            End If
        End If
    End Sub
End Class