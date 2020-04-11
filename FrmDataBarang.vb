Imports System.Data.OleDb
Public Class FrmDataBarang
    Private Sub FrmDataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tampilkan Data Barang
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from Barang", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Barang")
        DGVBarang.DataSource = (ds.Tables("Barang"))
        DGVBarang.ReadOnly = True
        DGVBarang.Columns(0).Width = 120
        DGVBarang.Columns(1).Width = 300
        DGVBarang.Columns(2).Width = 75
        Select Case Me.Text
            'Jika dibuka dengan form pembelian, harga beli kelihatan
            Case "Data Barang - Pembelian"
                DGVBarang.Columns(9).Visible = True
                'Jika dibuka dengan form penjualan, harga beli tidak kelihatan
            Case "Data Barang - Penjualan"
                DGVBarang.Columns(9).Visible = False
        End Select
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        'Cari data barang berdasarkan nama barang
        da = New OleDbDataAdapter("Select * from Barang where nama_Barang like '%" & TxtCari.Text & "%' order by nama_Barang asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Barang")
        DGVBarang.DataSource = (ds.Tables("Barang"))
        DGVBarang.ReadOnly = True
    End Sub
End Class