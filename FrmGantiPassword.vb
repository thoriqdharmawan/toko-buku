Imports System.Data.OleDb
Public Class FrmGantiPassword

    Private Sub FrmGantiPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        TxtPassLama.Enabled = True
        TxtPassBaru.Enabled = False
        TxtKonfirmasi.Enabled = False
    End Sub

    Private Sub TxtPassLama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassLama.KeyPress
        If e.KeyChar = Chr(13) Then
            'Cek Password lama berdasarkan kode petugas
            cmd = New OleDbCommand("select * from petugas where kodeptg='" & FrmMenuUtama.Panel1.Text & "' and passwordptg='" & TxtPassLama.Text & "' ", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TxtPassBaru.Enabled = True
                TxtPassBaru.Focus()
            Else
                MsgBox("Password lama salah")
                TxtPassLama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPassBaru_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassBaru.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtPassBaru.Text = "" Then
                MsgBox("Passwrod baru wajib diisi")
                TxtPassBaru.Focus()
            Else
                TxtKonfirmasi.Enabled = True
                TxtKonfirmasi.Focus()
            End If
        End If
    End Sub

    Private Sub TxtKonfirmasi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKonfirmasi.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtKonfirmasi.Text <> TxtPassBaru.Text Then
                MsgBox("Password konfirmasi salah")
                TxtKonfirmasi.Focus()
            Else
                'Ganti password petugas
                If MessageBox.Show("Yakin akan ganti password..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim ganti As String = "Update petugas set passwordptg='" & TxtPassBaru.Text & "' where kodeptg='" & FrmMenuUtama.Panel1.Text & "'"
                    cmd = New OleDbCommand(ganti, Conn)
                    cmd.ExecuteNonQuery()
                    TxtPassLama.Clear()
                    TxtPassBaru.Clear()
                    TxtKonfirmasi.Clear()
                    Me.Close()
                Else
                    TxtPassLama.Clear()
                    TxtPassBaru.Clear()
                    TxtKonfirmasi.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Me.Close()
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        If TxtPassLama.Text = "" Or TxtPassLama.Text = "" Or TxtKonfirmasi.Text = "" Then
            MsgBox("Password masih kosong", vbExclamation + vbOKOnly, "Pesan")
            Exit Sub
        End If
        If TxtKonfirmasi.Text <> TxtPassBaru.Text Then
            MsgBox("Password konfirmasi salah")
            TxtKonfirmasi.Focus()
        Else
            'Ganti Password
            If MessageBox.Show("Yakin akan ganti password..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim ganti As String = "Update petugas set passwordptg='" & TxtPassBaru.Text & "' where kodeptg='" & FrmMenuUtama.Panel1.Text & "'"
                cmd = New OleDbCommand(ganti, Conn)
                cmd.ExecuteNonQuery()
                TxtPassLama.Clear()
                TxtPassBaru.Clear()
                TxtKonfirmasi.Clear()
                Me.Close()
            Else
                TxtPassLama.Clear()
                TxtPassBaru.Clear()
                TxtKonfirmasi.Clear()
                Me.Close()
            End If
        End If
    End Sub
End Class