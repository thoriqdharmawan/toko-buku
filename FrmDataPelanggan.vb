Imports System.Data.OleDb
Public Class FrmDataPelanggan

    Private Sub FrmDataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Menampilkan data pelanggan ke grid
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from Pelanggan", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DGVPelanggan.DataSource = (ds.Tables("Pelanggan"))
        DGVPelanggan.ReadOnly = True
    End Sub

    Private Sub TxtCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCari.KeyPress
        'Jika ditekan tombol Esc, maka tutup form
        If e.KeyChar = Chr(27) Then
            Me.Close()
            FrmPenjualan.DGV.Focus()
            FrmPenjualan.DGV.CurrentCell = FrmPenjualan.DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        'Cari data pelanggan berdasarkan nama pelanggan
        da = New OleDbDataAdapter("Select * from Pelanggan where nama_Pelanggan like '%" & TxtCari.Text & "%' order by nama_Pelanggan asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DGVPelanggan.DataSource = (ds.Tables("Pelanggan"))
        DGVPelanggan.ReadOnly = True
    End Sub

    Private Sub DGVPelanggan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPelanggan.CellContentClick

    End Sub

    Private Sub DGVPelanggan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVPelanggan.DoubleClick
        'Manampilkan data pada form penjualan saat double klik
        Try
            With DGVPelanggan
                FrmPenjualan.TxtKode.Text = .SelectedCells(0).Value
                FrmPenjualan.TxtNama.Text = .SelectedCells(1).Value
                FrmPenjualan.TxtAlamat.Text = .SelectedCells(2).Value
                FrmPenjualan.TxtStatus.Text = .SelectedCells(4).Value
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVPelanggan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVPelanggan.KeyDown
        'Tutup form saat tombol esc ditekan
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

End Class