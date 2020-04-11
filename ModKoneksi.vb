' Baris kode ini digunakan untuk refrence fungsi .net system data OLEDB untuk 
' koneksi ke database
Imports System.Data.OleDb
Module ModKoneksi
    ' Baris kode ini digunakan untuk deklarasi turunan yang digunakan 
    ' untuk berkomunikasi dengan database
    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public str As String

    ' Membuat prosedur Function Global dengan nama Koneksi yang digunakan
    ' untuk membuat koneksi database ke Ms Access 2007.
    Public Sub Koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbTokoBuku.accdb"
        Conn = New OleDbConnection(str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
