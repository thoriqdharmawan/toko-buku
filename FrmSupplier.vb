﻿Imports System.Data.OleDb
Public Class FrmSupplier
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Bersih()
        TxtKode.Enabled = True
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNo.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    ' Membuat prosedur dengan nama TampilGrid untuk menampilkan data -
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Supplier", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Supplier")
        DGV.DataSource = (ds.Tables("Supplier"))
        DGV.ReadOnly = True
    End Sub
    Private Sub FrmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Bersih()
    End Sub

    Private Sub TxtKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            ' Cari kode Supplier
            cmd = New OleDbCommand("select * from Supplier where Kode_Supplier='" & TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                ' Jika kode Supplier ada maka tampil data
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("Kode_Supplier")
                TxtNama.Text = rd.Item("Nama_Supplier")
                TxtAlamat.Text = rd.Item("Alamat_Supplier")
                TxtNo.Text = rd.Item("No_Telp")

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
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnUbah.Focus()
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text = "" Or TxtNama.Text = "" Then
            MsgBox("Kode / Nama masih kosong")
            Exit Sub
        Else
            'Cari kode supplier apakah sudah ada
            cmd = New OleDbCommand("Select * from Supplier where Kode_Supplier='" & _
                                   TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                'Jika kode Supplier tdk ada, maka proses simpan
                Dim sqltambah As String = "Insert into Supplier(kode_Supplier,nama_Supplier,alamat_Supplier,No_Telp) values " & _
                "('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & _
                TxtNo.Text & "')"
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
            '## Ubah data supplier berdasarkan kode supplier
            cmd = New OleDbCommand("Update Supplier set Nama_Supplier='" & _
                                   TxtNama.Text & "',alamat_Supplier='" & TxtAlamat.Text & _
                                   "',No_telp='" & TxtNo.Text & "' where Kode_Supplier='" & _
                                   TxtKode.Text & "'", Conn)
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
            '## Hapus data supplier berdasarkan kode supplier
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Supplier where Kode_Supplier='" & _
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
        'Cari Supplier berdasarkan nama Supplier
        da = New OleDbDataAdapter("Select * from Supplier where nama_Supplier like '%" & TxtCari.Text & "%' order by nama_Supplier asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Supplier")
        DGV.DataSource = (ds.Tables("Supplier"))
        DGV.ReadOnly = True
    End Sub
End Class