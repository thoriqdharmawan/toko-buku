<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPetugas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmdTutup = New System.Windows.Forms.Button()
        Me.CmdHapus = New System.Windows.Forms.Button()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.TPassword = New System.Windows.Forms.TextBox()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TKode = New System.Windows.Forms.TextBox()
        Me.CBOStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmdTutup)
        Me.GroupBox1.Controls.Add(Me.CmdHapus)
        Me.GroupBox1.Controls.Add(Me.CmdBatal)
        Me.GroupBox1.Controls.Add(Me.CmdSimpan)
        Me.GroupBox1.Controls.Add(Me.TPassword)
        Me.GroupBox1.Controls.Add(Me.TNama)
        Me.GroupBox1.Controls.Add(Me.TKode)
        Me.GroupBox1.Controls.Add(Me.CBOStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Input / Edit Data"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(188, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "* [Enter] untuk melanjutkan"
        '
        'CmdTutup
        '
        Me.CmdTutup.Image = CType(resources.GetObject("CmdTutup.Image"), System.Drawing.Image)
        Me.CmdTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdTutup.Location = New System.Drawing.Point(291, 106)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(86, 24)
        Me.CmdTutup.TabIndex = 167
        Me.CmdTutup.Text = "&Tutup"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Image = CType(resources.GetObject("CmdHapus.Image"), System.Drawing.Image)
        Me.CmdHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdHapus.Location = New System.Drawing.Point(107, 106)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(86, 24)
        Me.CmdHapus.TabIndex = 165
        Me.CmdHapus.Text = "&Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Image = CType(resources.GetObject("CmdBatal.Image"), System.Drawing.Image)
        Me.CmdBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdBatal.Location = New System.Drawing.Point(199, 106)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(86, 24)
        Me.CmdBatal.TabIndex = 166
        Me.CmdBatal.Text = "&Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Image = CType(resources.GetObject("CmdSimpan.Image"), System.Drawing.Image)
        Me.CmdSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSimpan.Location = New System.Drawing.Point(15, 106)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(86, 24)
        Me.CmdSimpan.TabIndex = 164
        Me.CmdSimpan.Text = "&Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(82, 59)
        Me.TPassword.MaxLength = 10
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(154, 20)
        Me.TPassword.TabIndex = 113
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(82, 39)
        Me.TNama.MaxLength = 30
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(267, 20)
        Me.TNama.TabIndex = 112
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(82, 19)
        Me.TKode.MaxLength = 5
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(100, 20)
        Me.TKode.TabIndex = 111
        '
        'CBOStatus
        '
        Me.CBOStatus.FormattingEnabled = True
        Me.CBOStatus.Location = New System.Drawing.Point(82, 79)
        Me.CBOStatus.Name = "CBOStatus"
        Me.CBOStatus.Size = New System.Drawing.Size(154, 21)
        Me.CBOStatus.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Kode"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtCari)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 238)
        Me.GroupBox2.TabIndex = 163
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Cara Petugas Berdasarkan : "
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 54)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(389, 166)
        Me.DGV.TabIndex = 159
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Nama :"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(59, 19)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(187, 20)
        Me.TxtCari.TabIndex = 132
        '
        'FrmPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 410)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Petugas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TKode As System.Windows.Forms.TextBox
    Friend WithEvents CBOStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
