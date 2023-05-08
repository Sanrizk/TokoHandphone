<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tKodeB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tTotalB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNamaSupB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tHargaSupB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tJumlah = New System.Windows.Forms.TextBox()
        Me.cbKodeBrgB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(78, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Beli"
        '
        'tKodeB
        '
        Me.tKodeB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodeB.Location = New System.Drawing.Point(145, 112)
        Me.tKodeB.Name = "tKodeB"
        Me.tKodeB.Size = New System.Drawing.Size(100, 22)
        Me.tKodeB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Biaya Total"
        '
        'tTotalB
        '
        Me.tTotalB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotalB.Location = New System.Drawing.Point(145, 246)
        Me.tTotalB.Name = "tTotalB"
        Me.tTotalB.Size = New System.Drawing.Size(197, 22)
        Me.tTotalB.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(110, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Supplier"
        '
        'tNamaSupB
        '
        Me.tNamaSupB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaSupB.Location = New System.Drawing.Point(145, 166)
        Me.tNamaSupB.Name = "tNamaSupB"
        Me.tNamaSupB.Size = New System.Drawing.Size(197, 22)
        Me.tNamaSupB.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(111, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Harga Supplier"
        '
        'tHargaSupB
        '
        Me.tHargaSupB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHargaSupB.Location = New System.Drawing.Point(145, 192)
        Me.tHargaSupB.Name = "tHargaSupB"
        Me.tHargaSupB.Size = New System.Drawing.Size(150, 22)
        Me.tHargaSupB.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(63, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jumlah"
        '
        'tJumlah
        '
        Me.tJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJumlah.Location = New System.Drawing.Point(145, 219)
        Me.tJumlah.Name = "tJumlah"
        Me.tJumlah.Size = New System.Drawing.Size(150, 22)
        Me.tJumlah.TabIndex = 5
        '
        'cbKodeBrgB
        '
        Me.cbKodeBrgB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKodeBrgB.FormattingEnabled = True
        Me.cbKodeBrgB.Location = New System.Drawing.Point(145, 138)
        Me.cbKodeBrgB.Name = "cbKodeBrgB"
        Me.cbKodeBrgB.Size = New System.Drawing.Size(150, 24)
        Me.cbKodeBrgB.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(99, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kode Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(26, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 87)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(127, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(495, 54)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "PEMBELIAN SUPPLIER"
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(24, 287)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(75, 35)
        Me.bTambah.TabIndex = 7
        Me.bTambah.Text = "Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(105, 287)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(75, 35)
        Me.bUbah.TabIndex = 8
        Me.bUbah.Text = "Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(186, 287)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(75, 35)
        Me.bHapus.TabIndex = 9
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bTutup
        '
        Me.bTutup.Location = New System.Drawing.Point(267, 287)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(75, 35)
        Me.bTutup.TabIndex = 10
        Me.bTutup.Text = "Tutup"
        Me.bTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(353, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(412, 180)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(10, 338)
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
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(353, 112)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(412, 20)
        Me.tSearch.TabIndex = 11
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 366)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bTutup)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbKodeBrgB)
        Me.Controls.Add(Me.tJumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tHargaSupB)
        Me.Controls.Add(Me.tNamaSupB)
        Me.Controls.Add(Me.tTotalB)
        Me.Controls.Add(Me.tKodeB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembelian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tKodeB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tTotalB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tNamaSupB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tHargaSupB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tJumlah As TextBox
    Friend WithEvents cbKodeBrgB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents bTambah As Button
    Friend WithEvents bUbah As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bTutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents tSearch As TextBox
End Class
