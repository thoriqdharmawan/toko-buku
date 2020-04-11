Imports System.Data.OleDb
Public Class FrmCetakLapPenjualan

    Private Sub FrmCetakLapPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        'Tampilkan Faktur pada CmbNo
        cmd = New OleDbCommand("select * FROM Penjualan order by Faktur desc", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            CmbNo.Items.Add(rd.Item(0))
        Loop

        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
        BtnCetak.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        CmbNo.Enabled = True
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
        CmbNo.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = True
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = True
        DTPMulai.Focus()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        If RadioButton1.Checked = True Then
            'Cetak Semua Data
            FrmLapPenjualan.CrystalReportViewer1.SelectionFormula = ""
            FrmLapPenjualan.CrystalReportViewer1.RefreshReport()
            FrmLapPenjualan.ShowDialog()
        ElseIf RadioButton2.Checked = True Then
            If CmbNo.Text = "" Then
                MsgBox("Silahkan pilih No Faktur terlebih dahulu", vbInformation + vbOKOnly, "Pesan")
                Exit Sub
            End If
            'Cetak Laporan Berdasarkan Nomor Faktur
            FrmLapPenjualan.CrystalReportViewer1.SelectionFormula = "{Penjualan.Faktur} ='" & CmbNo.Text & "' "
            FrmLapPenjualan.CrystalReportViewer1.RefreshReport()
            FrmLapPenjualan.ShowDialog()
        ElseIf RadioButton3.Checked = True Then
            'Cetak Laporan Berdasarkan range tanggal
            FrmLapPenjualan.CrystalReportViewer1.SelectionFormula = "{Penjualan.tanggal} >= date('" & _
                Format(DTPMulai.Value, "dd/MM/yyyy") & "') and {Penjualan.tanggal} <= date('" & _
                Format(DTPAkhir.Value, "dd/MM/yyyy") & "')"
            FrmLapPenjualan.CrystalReportViewer1.RefreshReport()
            FrmLapPenjualan.Show()
        End If
    End Sub
End Class