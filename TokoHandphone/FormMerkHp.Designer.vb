<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMerkHp
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
        Me.tKodeMerk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tNamaMerk = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bTutup = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4)
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Merk"
        '
        'tKodeMerk
        '
        Me.tKodeMerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodeMerk.Location = New System.Drawing.Point(116, 20)
        Me.tKodeMerk.Name = "tKodeMerk"
        Me.tKodeMerk.Size = New System.Drawing.Size(182, 22)
        Me.tKodeMerk.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(4)
        Me.Label2.Size = New System.Drawing.Size(88, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Merk"
        '
        'tNamaMerk
        '
        Me.tNamaMerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaMerk.Location = New System.Drawing.Point(116, 59)
        Me.tNamaMerk.Name = "tNamaMerk"
        Me.tNamaMerk.Size = New System.Drawing.Size(182, 22)
        Me.tNamaMerk.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(334, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(379, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(8)
        Me.Label3.Size = New System.Drawing.Size(69, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Search"
        '
        'tSearch
        '
        Me.tSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSearch.Location = New System.Drawing.Point(16, 238)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(282, 22)
        Me.tSearch.TabIndex = 7
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(16, 95)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(66, 33)
        Me.bTambah.TabIndex = 3
        Me.bTambah.Text = "Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(88, 95)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(66, 33)
        Me.bUbah.TabIndex = 4
        Me.bUbah.Text = "Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(160, 95)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(66, 33)
        Me.bHapus.TabIndex = 5
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bTutup
        '
        Me.bTutup.Location = New System.Drawing.Point(232, 95)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(66, 33)
        Me.bTutup.TabIndex = 6
        Me.bTutup.Text = "Tutup"
        Me.bTutup.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 314)
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
        'FormMerkHp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 339)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.bTutup)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tNamaMerk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tKodeMerk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMerkHp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Merk HP"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tKodeMerk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tNamaMerk As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents tSearch As TextBox
    Friend WithEvents bTambah As Button
    Friend WithEvents bUbah As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bTutup As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
End Class
