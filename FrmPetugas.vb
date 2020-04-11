Imports System.Data.OleDb
Public Class FrmPetugas
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Kosongkan()
        TKode.Text = ""
        TNama.Text = ""
        TPassword.Text = ""
        CBOStatus.Text = ""
        TKode.Focus()
    End Sub

    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub DataBaru()
        TNama.Text = ""
        TPassword.Text = ""
        CBOStatus.Text = ""
        TNama.Focus()
    End Sub

    ' Membuat prosedur dengan nama TampilGrid untuk menampilkan data -
    ' ke dalam Grid View
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Petugas ORDER BY 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Petugas")
        DGV.DataSource = (ds.Tables("Petugas"))
        DGV.ReadOnly = True
    End Sub

    Private Sub FrmPetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        CBOStatus.Items.Add("ADMIN")
        CBOStatus.Items.Add("KASIR")
    End Sub

    Private Sub TKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKode.KeyPress
        If e.KeyChar = Chr(13) Then
            'Cari Kode Petugas
            cmd = New OleDbCommand("select * from Petugas where kodePTG='" & TKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika Kode Petugas telah ada maka tampil data
                TNama.Text = rd.GetString(1)
                TPassword.Text = rd.GetString(2)
                CBOStatus.Text = rd.GetString(3)
                TNama.Focus()
            Else
                'Jika tidak ada maka lanjut
                Call DataBaru()
                TNama.Focus()
            End If
        End If
    End Sub

    Private Sub TNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNama.KeyPress
        If e.KeyChar = Chr(13) Then TPassword.Focus()
    End Sub

    Private Sub TPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPassword.KeyPress
        If e.KeyChar = Chr(13) Then CBOStatus.Focus()
    End Sub


    Private Sub CmbStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBOStatus.KeyPress
        If e.KeyChar = Chr(13) Then CmdSimpan.Focus()
    End Sub


    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TKode.Text = "" Or TNama.Text = "" Or TPassword.Text = "" Or CBOStatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            'Cari kode petugas
            cmd = New OleDbCommand("Select * from Petugas where kodePTG='" & TKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                'Jika kode petugas tdk ada maka proses simpan
                Dim sqltambah As String = "Insert into Petugas(kodePTG,namaPTG,PasswordPTG,StatusPTG) values " & _
                "('" & TKode.Text & "','" & TNama.Text & "','" & TPassword.Text & "','" & CBOStatus.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                'Jika Kode petugas telah ada maka proses edit data
                Dim sqledit As String = "Update Petugas set " & _
                "NamaPTG='" & TNama.Text & "', " & _
                "PasswordPTG='" & TPassword.Text & "', " & _
                "StatusPTG='" & CBOStatus.Text & "' where kodePTG='" & TKode.Text & "'"
                cmd = New OleDbCommand(sqledit, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub


    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If TKode.Text = "" Then
            MsgBox("Isi kode Petugas terlebih dahulu")
            TKode.Focus()
            Exit Sub
        Else
            'Hapus Data petugas
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Petugas where kodePTG='" & TKode.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Call Kosongkan()
    End Sub

    Private Sub CmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        Me.Close()
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        'Cari Nama petugas
        da = New OleDbDataAdapter("Select * from Petugas where namaPTG like '%" & TxtCari.Text & "%' order by namaPTG asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Petugas")
        DGV.DataSource = (ds.Tables("Petugas"))
        DGV.ReadOnly = True
    End Sub
End Class
