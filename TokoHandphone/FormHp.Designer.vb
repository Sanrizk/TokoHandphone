<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tKodeBrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNamaBrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tSpes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tHarga = New System.Windows.Forms.TextBox()
        Me.cbKodeMerk = New System.Windows.Forms.ComboBox()
        Me.cbRam = New System.Windows.Forms.ComboBox()
        Me.cbRom = New System.Windows.Forms.ComboBox()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(99, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'tKodeBrg
        '
        Me.tKodeBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodeBrg.Location = New System.Drawing.Point(132, 23)
        Me.tKodeBrg.Name = "tKodeBrg"
        Me.tKodeBrg.Size = New System.Drawing.Size(100, 22)
        Me.tKodeBrg.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(85, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Merk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(104, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Barang"
        '
        'tNamaBrg
        '
        Me.tNamaBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaBrg.Location = New System.Drawing.Point(132, 49)
        Me.tNamaBrg.Name = "tNamaBrg"
        Me.tNamaBrg.Size = New System.Drawing.Size(388, 22)
        Me.tNamaBrg.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(50, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(51, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ROM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(86, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Spesifikasi"
        '
        'tSpes
        '
        Me.tSpes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSpes.Location = New System.Drawing.Point(132, 127)
        Me.tSpes.Multiline = True
        Me.tSpes.Name = "tSpes"
        Me.tSpes.Size = New System.Drawing.Size(388, 76)
        Me.tSpes.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(103, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Harga Satuan"
        '
        'tHarga
        '
        Me.tHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHarga.Location = New System.Drawing.Point(132, 209)
        Me.tHarga.Name = "tHarga"
        Me.tHarga.Size = New System.Drawing.Size(100, 22)
        Me.tHarga.TabIndex = 7
        '
        'cbKodeMerk
        '
        Me.cbKodeMerk.FormattingEnabled = True
        Me.cbKodeMerk.Location = New System.Drawing.Point(358, 22)
        Me.cbKodeMerk.Name = "cbKodeMerk"
        Me.cbKodeMerk.Size = New System.Drawing.Size(162, 21)
        Me.cbKodeMerk.TabIndex = 2
        '
        'cbRam
        '
        Me.cbRam.FormattingEnabled = True
        Me.cbRam.Items.AddRange(New Object() {"2", "3", "4", "6", "8"})
        Me.cbRam.Location = New System.Drawing.Point(132, 75)
        Me.cbRam.Name = "cbRam"
        Me.cbRam.Size = New System.Drawing.Size(100, 21)
        Me.cbRam.TabIndex = 4
        '
        'cbRom
        '
        Me.cbRom.FormattingEnabled = True
        Me.cbRom.Items.AddRange(New Object() {"32", "64", "128"})
        Me.cbRom.Location = New System.Drawing.Point(132, 101)
        Me.cbRom.Name = "cbRom"
        Me.cbRom.Size = New System.Drawing.Size(100, 21)
        Me.cbRom.TabIndex = 5
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(68, 265)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(99, 37)
        Me.bTambah.TabIndex = 8
        Me.bTambah.Text = "Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(173, 265)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(99, 37)
        Me.bUbah.TabIndex = 9
        Me.bUbah.Text = "Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(278, 265)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(99, 37)
        Me.bHapus.TabIndex = 10
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bTutup
        '
        Me.bTutup.Location = New System.Drawing.Point(383, 265)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(99, 37)
        Me.bTutup.TabIndex = 11
        Me.bTutup.Text = "Tutup"
        Me.bTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(543, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(378, 227)
        Me.DataGridView1.TabIndex = 0
        '
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(542, 51)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(378, 20)
        Me.tSearch.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(542, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5)
        Me.Label8.Size = New System.Drawing.Size(63, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Search"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 316)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(273, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'FormHp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 344)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bTutup)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.cbRom)
        Me.Controls.Add(Me.cbRam)
        Me.Controls.Add(Me.cbKodeMerk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tNamaBrg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tSpes)
        Me.Controls.Add(Me.tHarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tKodeBrg)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang HandPhone"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tKodeBrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tNamaBrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tSpes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tHarga As TextBox
    Friend WithEvents cbKodeMerk As ComboBox
    Friend WithEvents cbRam As ComboBox
    Friend WithEvents cbRom As ComboBox
    Friend WithEvents bTambah As Button
    Friend WithEvents bUbah As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bTutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
End Class
