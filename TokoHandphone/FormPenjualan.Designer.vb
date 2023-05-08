<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bTutup = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbKodeBrgJ = New System.Windows.Forms.ComboBox()
        Me.tJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tHargaCusJ = New System.Windows.Forms.TextBox()
        Me.tNamaCusJ = New System.Windows.Forms.TextBox()
        Me.tTotalJ = New System.Windows.Forms.TextBox()
        Me.tKodeJ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(353, 112)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(412, 20)
        Me.tSearch.TabIndex = 31
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(10, 338)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(273, 25)
        Me.ToolStrip1.TabIndex = 13
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(353, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(412, 180)
        Me.DataGridView1.TabIndex = 14
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
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Biaya Total"
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
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Jumlah"
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
        Me.Label4.Size = New System.Drawing.Size(86, 28)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Harga Jual"
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
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama Customer"
        '
        'bTutup
        '
        Me.bTutup.Location = New System.Drawing.Point(267, 287)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(75, 35)
        Me.bTutup.TabIndex = 30
        Me.bTutup.Text = "Tutup"
        Me.bTutup.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(186, 287)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(75, 35)
        Me.bHapus.TabIndex = 29
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(105, 287)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(75, 35)
        Me.bUbah.TabIndex = 28
        Me.bUbah.Text = "Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(24, 287)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(75, 35)
        Me.bTambah.TabIndex = 27
        Me.bTambah.Text = "Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(26, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 87)
        Me.Panel1.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(115, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(535, 54)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "PENJUALAN CUSTOMER"
        '
        'cbKodeBrgJ
        '
        Me.cbKodeBrgJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKodeBrgJ.FormattingEnabled = True
        Me.cbKodeBrgJ.Location = New System.Drawing.Point(145, 138)
        Me.cbKodeBrgJ.Name = "cbKodeBrgJ"
        Me.cbKodeBrgJ.Size = New System.Drawing.Size(150, 24)
        Me.cbKodeBrgJ.TabIndex = 22
        '
        'tJumlah
        '
        Me.tJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJumlah.Location = New System.Drawing.Point(145, 219)
        Me.tJumlah.Name = "tJumlah"
        Me.tJumlah.Size = New System.Drawing.Size(150, 22)
        Me.tJumlah.TabIndex = 25
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
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Kode Barang"
        '
        'tHargaCusJ
        '
        Me.tHargaCusJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHargaCusJ.Location = New System.Drawing.Point(145, 192)
        Me.tHargaCusJ.Name = "tHargaCusJ"
        Me.tHargaCusJ.Size = New System.Drawing.Size(150, 22)
        Me.tHargaCusJ.TabIndex = 24
        '
        'tNamaCusJ
        '
        Me.tNamaCusJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaCusJ.Location = New System.Drawing.Point(145, 166)
        Me.tNamaCusJ.Name = "tNamaCusJ"
        Me.tNamaCusJ.Size = New System.Drawing.Size(197, 22)
        Me.tNamaCusJ.TabIndex = 23
        '
        'tTotalJ
        '
        Me.tTotalJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotalJ.Location = New System.Drawing.Point(145, 246)
        Me.tTotalJ.Name = "tTotalJ"
        Me.tTotalJ.Size = New System.Drawing.Size(197, 22)
        Me.tTotalJ.TabIndex = 26
        '
        'tKodeJ
        '
        Me.tKodeJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodeJ.Location = New System.Drawing.Point(145, 112)
        Me.tKodeJ.Name = "tKodeJ"
        Me.tKodeJ.Size = New System.Drawing.Size(100, 22)
        Me.tKodeJ.TabIndex = 21
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
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Jual"
        '
        'FormPenjualan
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
        Me.Controls.Add(Me.cbKodeBrgJ)
        Me.Controls.Add(Me.tJumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tHargaCusJ)
        Me.Controls.Add(Me.tNamaCusJ)
        Me.Controls.Add(Me.tTotalJ)
        Me.Controls.Add(Me.tKodeJ)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenjualan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tSearch As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bTutup As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bUbah As Button
    Friend WithEvents bTambah As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cbKodeBrgJ As ComboBox
    Friend WithEvents tJumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tHargaCusJ As TextBox
    Friend WithEvents tNamaCusJ As TextBox
    Friend WithEvents tTotalJ As TextBox
    Friend WithEvents tKodeJ As TextBox
    Friend WithEvents Label1 As Label
End Class
