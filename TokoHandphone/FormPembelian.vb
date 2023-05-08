Imports System.Data.SqlClient
Public Class FormPembelian
    Dim harga, jumlah, total As Double
    Sub KlikTambah()
        bUbah.Enabled = False
        bHapus.Enabled = False
        bTambah.Text = "Simpan"
        bTutup.Text = "Batal"
        cbKodeBrgB.Enabled = True
        tNamaSupB.Enabled = True
        tHargaSupB.Enabled = True
        tJumlah.Enabled = True
        tTotalB.Enabled = True
    End Sub
    Sub KlikBatal()
        bUbah.Enabled = True
        bHapus.Enabled = True
        bTambah.Enabled = True
        bTutup.Text = "Tutup"
        bTambah.Text = "Tambah"
        bUbah.Text = "Ubah"
        tKodeB.Enabled = False
        cbKodeBrgB.Enabled = False
        tNamaSupB.Enabled = False
        tHargaSupB.Enabled = False
        tJumlah.Enabled = False
        tTotalB.Enabled = False
        tKodeB.Text = ""
        cbKodeBrgB.Text = ""
        tNamaSupB.Text = ""
        tHargaSupB.Text = ""
        tJumlah.Text = ""
        tTotalB.Text = ""
    End Sub
    Sub KlikUbah()
        bTambah.Enabled = False
        bHapus.Enabled = False
        bTutup.Text = "Batal"
        bUbah.Text = "Simpan"
    End Sub
    Sub KlikHapus()
        bTambah.Enabled = False
        bUbah.Enabled = False
        bTutup.Text = "Batal"
    End Sub
    Sub Kosong()
        Me.Show()
        tKodeB.Text = ""
        cbKodeBrgB.Text = ""
        tNamaSupB.Text = ""
        tHargaSupB.Text = ""
        tJumlah.Text = ""
        tTotalB.Text = ""
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 70
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100

        DataGridView1.Columns(0).HeaderText = "KODE BELI"
        DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(2).HeaderText = "NAMA SUPPLIER"
        DataGridView1.Columns(3).HeaderText = "HARGA SATUAN"
        DataGridView1.Columns(4).HeaderText = "JUMLAH"
        DataGridView1.Columns(5).HeaderText = "TOTAL"
        DataGridView1.Columns(6).HeaderText = "TANGGAL INPUT"
        DataGridView1.Columns(7).HeaderText = "OPERATOR"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "d MMM yyyy"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "Rp #,###"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp #,###"

    End Sub
    Sub TampilPembelian()
        Call Koneksi()
        da = New SqlDataAdapter("SELECT kode_beli, nama_barang, nama_supplier, harga_supplier, jumlah, total_dibeli, tb_pembelian.tanggal_input, tb_pembelian.operator FROM tb_pembelian INNER JOIN tb_hp on tb_pembelian.kode_barang = tb_hp.kode_barang", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_pembelian")
        DataGridView1.DataSource = ds.Tables("tb_pembelian")
        DataGridView1.Refresh()
    End Sub
    Sub TampilHp()
        cmd = New SqlCommand("SELECT kode_barang, nama_barang FROM tb_hp", konek)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbKodeBrgB.Items.Add(rd.Item("kode_barang") + "  |  " + rd.Item("nama_barang"))
        Loop
    End Sub


    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bUbah.Enabled = True And bHapus.Enabled = True Then
            tKodeB.Text = ""
            tNamaSupB.Text = ""
            tHargaSupB.Text = ""
            tJumlah.Text = ""
            tTotalB.Text = ""
            cbKodeBrgB.Text = ""
        End If
        If tNamaSupB.Enabled = False Then
            Call KlikTambah()
            Call Koneksi()
            cmd = New SqlCommand("select * from tb_pembelian where kode_beli in (select max(kode_beli) from tb_pembelian)", konek)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                UrutanKode = "BL" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                UrutanKode = "BL" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            tKodeB.Text = UrutanKode
            cbKodeBrgB.Focus()
        ElseIf tKodeB.Text = "" Or tNamaSupB.Text = "" Or cbKodeBrgB.text = "" Or tHargaSupB.Text = "" Or tJumlah.Text = "" Or tTotalB.Text = "" Then
            MsgBox("Data Belum Lengkap !")
        Else
            Call Koneksi()
            Dim Simpan As String
            Simpan = "INSERT INTO tb_pembelian VALUES('" & tKodeB.Text & "','" & cbKodeBrgB.Text.Substring(0, 4) & "','" & tNamaSupB.Text & "','" & tHargaSupB.Text & "','" & tJumlah.Text & "','" & tTotalB.Text & "','" & Date.Today() & "','" & FormMenu.ToolStripStatusLabel2.Text & "')"
            cmd = New SqlCommand(Simpan, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Terinput", MsgBoxStyle.Information, "information")
            Call KlikBatal()
            Call TampilPembelian()
            Call Kosong()
            Call AturGrid()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        Call KlikUbah()
        If tNamaSupB.Enabled = False And tKodeB.Enabled = False And tKodeB.TextLength > 0 Then
            cbKodeBrgB.Enabled = True
            tNamaSupB.Enabled = True
            tHargaSupB.Enabled = True
            tJumlah.Enabled = True
            tTotalB.Enabled = True
            MsgBox("Silahkan Ubah Identitas Barang")
        ElseIf tNamaSupB.Text = "" Or tKodeB.Text = "" Then
            tNamaSupB.Enabled = False
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
            Exit Sub
        ElseIf tNamaSupB.Enabled = True And bTambah.Enabled = False Then
            Call Koneksi()
            Dim Edit As String
            Edit = "UPDATE tb_pembelian SET kode_barang='" & cbKodeBrgB.Text.Substring(0, 4) & "', nama_supplier='" & tNamaSupB.Text & "', harga_supplier='" & tHargaSupB.Text & "', jumlah='" & tJumlah.Text & "', total_dibeli='" & tTotalB.Text & "' WHERE kode_beli='" & tKodeB.Text & "'"
            cmd = New SqlCommand(Edit, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Information")
            cbKodeBrgB.Enabled = False
            tNamaSupB.Enabled = False
            tHargaSupB.Enabled = False
            tJumlah.Enabled = False
            tTotalB.Enabled = False
            Call TampilPembelian()
            Call Kosong()
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Call KlikHapus()
        If tKodeB.Text = "" Then
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
        Else
            Call Koneksi()
            Dim Hapus As String
            Hapus = "DELETE FROM tb_pembelian WHERE kode_beli='" & tKodeB.Text & "'"
            cmd = New SqlCommand(Hapus, konek)
            Select Case MsgBox("Yakin menghapus ?", MsgBoxStyle.YesNo, "Hapus Data")
                Case MsgBoxResult.Yes
                    tNamaSupB.Enabled = False
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Dihapus")
                Case MsgBoxResult.No
                    tNamaSupB.Enabled = False
            End Select
            Call TampilPembelian()
            Call Kosong()
        End If
    End Sub

    Private Sub bTutup_Click(sender As Object, e As EventArgs) Handles bTutup.Click
        If bTambah.Enabled = False Or bUbah.Enabled = False Or bHapus.Enabled = False Then
            Call KlikBatal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call TampilHp()
        Call TampilPembelian()
        Call AturGrid()
        ToolStripLabel1.Text = "(PEMBELIAN)"
        ToolStripLabel2.Text = "(" & FormMenu.ToolStripStatusLabel2.Text & ")"
        ToolStripLabel3.Text = "(" & Date.Today().ToString("dddd, d MMM yyyy") & ")"
        tKodeB.Enabled = False
        cbKodeBrgB.Enabled = False
        tNamaSupB.Enabled = False
        tHargaSupB.Enabled = False
        tJumlah.Enabled = False
        tTotalB.Enabled = False
    End Sub

    Private Sub cbKodeBrgB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbKodeBrgB.KeyPress
        e.KeyChar = Chr(0)
    End Sub
    Sub TotalPembelian()
        harga = Val(tHargaSupB.Text)
        jumlah = Val(tJumlah.Text)
        total = jumlah * harga
        tTotalB.Text = total
    End Sub

    Private Sub tHargaSupB_TextChanged(sender As Object, e As EventArgs) Handles tHargaSupB.TextChanged
        Call TotalPembelian()
    End Sub

    Private Sub tJumlah_TextChanged(sender As Object, e As EventArgs) Handles tJumlah.TextChanged
        Call TotalPembelian()
    End Sub

    Private Sub tTotalB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tTotalB.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub tJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tHargaSupB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tHargaSupB.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If bUbah.Enabled = False And bHapus.Enabled = False Then
            MsgBox("Silahkan Isi Field Form")
        End If
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT kode_beli, tb_pembelian.kode_barang, nama_barang, nama_supplier, harga_supplier, jumlah, total_dibeli, tb_pembelian.tanggal_input, tb_pembelian.operator FROM tb_pembelian INNER JOIN tb_hp on tb_pembelian.kode_barang = tb_hp.kode_barang WHERE kode_beli='" & DataGridView1.Item(0, i).Value & "'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNamaSupB.Focus()
        Else
            tKodeB.Text = rd.Item("kode_beli")
            cbKodeBrgB.Text = rd.Item("kode_barang") + "  |  " + rd.Item("nama_barang")
            tNamaSupB.Text = rd.Item("nama_supplier")
            tHargaSupB.Text = rd.Item("harga_supplier")
            tJumlah.Text = rd.Item("jumlah")
            tTotalB.Text = rd.Item("total_dibeli")
            tKodeB.Focus()
            If bHapus.Enabled = False Then
                cbKodeBrgB.Enabled = True
                tNamaSupB.Enabled = True
                tHargaSupB.Enabled = True
                tJumlah.Enabled = True
                tTotalB.Enabled = True
            ElseIf bUbah.Enabled = False Then
                cbKodeBrgB.Enabled = False
                tNamaSupB.Enabled = False
                tHargaSupB.Enabled = False
                tJumlah.Enabled = False
                tTotalB.Enabled = False
            End If

        End If

    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Call Koneksi()
        cmd = New SqlCommand("SELECT kode_beli, nama_barang, nama_supplier, harga_supplier, jumlah, total_dibeli, tb_pembelian.tanggal_input, tb_pembelian.operator FROM tb_pembelian INNER JOIN tb_hp on tb_pembelian.kode_barang = tb_hp.kode_barang WHERE nama_barang LIKE '%" & tSearch.Text & "%' OR kode_beli LIKE '%" & tSearch.Text & "%' OR nama_supplier LIKE '%" & tSearch.Text & "%'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("SELECT kode_beli, nama_barang, nama_supplier, harga_supplier, jumlah, total_dibeli, tb_pembelian.tanggal_input, tb_pembelian.operator FROM tb_pembelian INNER JOIN tb_hp on tb_pembelian.kode_barang = tb_hp.kode_barang WHERE nama_barang LIKE '%" & tSearch.Text & "%' OR kode_beli LIKE '%" & tSearch.Text & "%' OR nama_supplier LIKE '%" & tSearch.Text & "%'", konek)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If

    End Sub
End Class