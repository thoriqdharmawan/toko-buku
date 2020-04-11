Imports System.Data.OleDb
Public Class FrmDataSupplier
    Private Sub FrmDataSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Menampilkan data supplier ke grid
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from Supplier", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Supplier")
        DGVSupplier.DataSource = (ds.Tables("Supplier"))
        DGVSupplier.ReadOnly = True
    End Sub

    Private Sub TxtCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCari.KeyPress
        'Jika ditekan tombol Esc, maka tutup form
        If e.KeyChar = Chr(27) Then
            Me.Close()
            FrmPembelian.DGV.Focus()
            FrmPembelian.DGV.CurrentCell = FrmPembelian.DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        'Cari data supplier berdasarkan nama supplier
        da = New OleDbDataAdapter("Select * from Supplier where nama_Supplier like '%" & TxtCari.Text & "%' order by nama_Supplier asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Supplier")
        DGVSupplier.DataSource = (ds.Tables("Supplier"))
        DGVSupplier.ReadOnly = True
    End Sub

    Private Sub DGVSupplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVSupplier.DoubleClick
        'Manampilkan data pada form pembelian saat double klik
        Try
            With DGVSupplier
                FrmPembelian.TxtKode.Text = .SelectedCells(0).Value
                FrmPembelian.TxtNama.Text = .SelectedCells(1).Value
                FrmPembelian.TxtAlamat.Text = .SelectedCells(2).Value
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVSupplier.KeyDown
        'Tutup form saat tombol esc ditekan
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

End Class