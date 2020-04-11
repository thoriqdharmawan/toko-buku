Public Class FrmMenuUtama

    Private Sub FrmMenuUtama_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel4.Text = Format(Now, "dddd, dd-MMMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel5.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub MnuGantiPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGantiPassword.Click
        FrmGantiPassword.Show()
    End Sub

    Private Sub MnuLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLogOut.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub MnuKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Ingin Keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub MnuPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPelanggan.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub MnuSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSupplier.Click
        FrmSupplier.Show()
    End Sub

    Private Sub MnuSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSatuan.Click
        FrmSatuan.Show()
    End Sub

    Private Sub MnuKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuKategori.Click
        FrmKategori.Show()
    End Sub

    Private Sub MnuBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBarang.Click
        FrmBarang.Show()
    End Sub

    Private Sub MnuPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPetugas.Click
        FrmPetugas.Show()
    End Sub

    Private Sub MnuPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPembelian.Click
        FrmPembelian.TxtKasir.Text = Panel2.Text
        FrmPembelian.Show()
    End Sub

    Private Sub MnuPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPenjualan.Click
        FrmPenjualan.TxtKasir.Text = Panel2.Text
        FrmPenjualan.Show()
    End Sub

    Private Sub MnuLapPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLapPelanggan.Click
        FrmLapPelanggan.CrystalReportViewer1.SelectionFormula = ""
        FrmLapPelanggan.CrystalReportViewer1.RefreshReport()
        FrmLapPelanggan.ShowDialog()
    End Sub

    Private Sub MnuLapSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLapSupplier.Click
        FrmLapSupplier.CrystalReportViewer1.SelectionFormula = ""
        FrmLapSupplier.CrystalReportViewer1.RefreshReport()
        FrmLapSupplier.ShowDialog()
    End Sub

    Private Sub MnuLapBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLapBarang.Click
        FrmLapBarang.CrystalReportViewer1.SelectionFormula = ""
        FrmLapBarang.CrystalReportViewer1.RefreshReport()
        FrmLapBarang.ShowDialog()
    End Sub

    Private Sub MnuLapPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLapPembelian.Click
        FrmCetakLapPembelian.Show()
    End Sub

    Private Sub MnuLapPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLapPenjualan.Click
        FrmCetakLapPenjualan.Show()
    End Sub

    Private Sub MnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuExit.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Ingin Keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub BtnGantiPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGantiPass.Click
        FrmGantiPassword.Show()
    End Sub

    Private Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogOut.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Ingin Keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub BtnPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPelanggan.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub BtnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupplier.Click
        FrmSupplier.Show()
    End Sub

    Private Sub BtnSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSatuan.Click
        FrmSatuan.Show()
    End Sub

    Private Sub BtnKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKategori.Click
        FrmKategori.Show()
    End Sub

    Private Sub BtnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarang.Click
        FrmBarang.Show()
    End Sub

    Private Sub BtnPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPembelian.Click
        FrmPembelian.TxtKasir.Text = Panel2.Text
        FrmPembelian.Show()
    End Sub

    Private Sub BtnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenjualan.Click
        FrmPenjualan.TxtKasir.Text = Panel2.Text
        FrmPenjualan.Show()
    End Sub
End Class