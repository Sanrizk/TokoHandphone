Imports System.Data.SqlClient
Public Class FormPenjualan
    Dim harga, jumlah, total As Double
    Sub KlikTambah()
        bUbah.Enabled = False
        bHapus.Enabled = False
        bTambah.Text = "Simpan"
        bTutup.Text = "Batal"
        cbKodeBrgJ.Enabled = True
        tNamaCusJ.Enabled = True
        tHargaCusJ.Enabled = True
        tJumlah.Enabled = True
        tTotalJ.Enabled = True
    End Sub
    Sub KlikBatal()
        bUbah.Enabled = True
        bHapus.Enabled = True
        bTambah.Enabled = True
        bTutup.Text = "Tutup"
        bTambah.Text = "Tambah"
        bUbah.Text = "Ubah"
        tKodeJ.Enabled = False
        cbKodeBrgJ.Enabled = False
        tNamaCusJ.Enabled = False
        tHargaCusJ.Enabled = False
        tJumlah.Enabled = False
        tTotalJ.Enabled = False
        tKodeJ.Text = ""
        cbKodeBrgJ.Text = ""
        tNamaCusJ.Text = ""
        tHargaCusJ.Text = ""
        tJumlah.Text = ""
        tTotalJ.Text = ""
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
        tKodeJ.Text = ""
        cbKodeBrgJ.Text = ""
        tNamaCusJ.Text = ""
        tHargaCusJ.Text = ""
        tJumlah.Text = ""
        tTotalJ.Text = ""
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
    Sub TampilPenjualan()
        Call Koneksi()
        da = New SqlDataAdapter("SELECT kode_jual, nama_barang, nama_pembeli, harga_satuan, jumlah, total_dibayar, tb_penjualan.tanggal_input, tb_penjualan.operator FROM tb_penjualan INNER JOIN tb_hp on tb_penjualan.kode_barang = tb_hp.kode_barang", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_penjualan")
        DataGridView1.DataSource = ds.Tables("tb_penjualan")
        DataGridView1.Refresh()
    End Sub
    Sub TampilHp()
        cmd = New SqlCommand("SELECT kode_barang, nama_barang, harga FROM tb_hp", konek)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbKodeBrgJ.Items.Add(rd.Item("kode_barang") + "  |  " + rd.Item("nama_barang"))
        Loop
    End Sub


    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bUbah.Enabled = True And bHapus.Enabled = True Then
            tKodeJ.Text = ""
            tNamaCusJ.Text = ""
            tHargaCusJ.Text = ""
            tJumlah.Text = ""
            tTotalJ.Text = ""
            cbKodeBrgJ.Text = ""
        End If
        If tNamaCusJ.Enabled = False Then
            Call KlikTambah()
            Call Koneksi()
            cmd = New SqlCommand("select * from tb_penjualan where kode_jual in (select max(kode_jual) from tb_penjualan)", konek)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                UrutanKode = "KJ" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                UrutanKode = "KJ" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            tKodeJ.Text = UrutanKode
            cbKodeBrgJ.Focus()
        ElseIf tKodeJ.Text = "" Or tNamaCusJ.Text = "" Or cbKodeBrgJ.Text = "" Or tHargaCusJ.Text = "" Or tJumlah.Text = "" Or tTotalJ.Text = "" Then
            MsgBox("Data Belum Lengkap !")
        Else
            Call Koneksi()
            Dim Simpan As String
            Simpan = "INSERT INTO tb_penjualan VALUES('" & tKodeJ.Text & "','" & cbKodeBrgJ.Text.Substring(0, 4) & "','" & tNamaCusJ.Text & "','" & tHargaCusJ.Text & "','" & tJumlah.Text & "','" & tTotalJ.Text & "','" & Date.Today() & "','" & FormMenu.ToolStripStatusLabel2.Text & "')"
            cmd = New SqlCommand(Simpan, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Terinput", MsgBoxStyle.Information, "information")
            Call KlikBatal()
            Call TampilPenjualan()
            Call Kosong()
            Call AturGrid()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        Call KlikUbah()
        If tNamaCusJ.Enabled = False And tKodeJ.Enabled = False And tKodeJ.TextLength > 0 Then
            cbKodeBrgJ.Enabled = True
            tNamaCusJ.Enabled = True
            tHargaCusJ.Enabled = True
            tJumlah.Enabled = True
            tTotalJ.Enabled = True
            MsgBox("Silahkan Ubah Identitas Barang")
        ElseIf tNamaCusJ.Text = "" Or tKodeJ.Text = "" Then
            tNamaCusJ.Enabled = False
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
            Exit Sub
        ElseIf tNamaCusJ.Enabled = True And bTambah.Enabled = False Then
            Call Koneksi()
            Dim Edit As String
            Edit = "UPDATE tb_penjualan SET kode_barang='" & cbKodeBrgJ.Text.Substring(0, 4) & "', nama_pembeli='" & tNamaCusJ.Text & "', harga_satuan='" & tHargaCusJ.Text & "', jumlah='" & tJumlah.Text & "', total_dibayar='" & tTotalJ.Text & "' WHERE kode_jual='" & tKodeJ.Text & "'"
            cmd = New SqlCommand(Edit, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Information")
            cbKodeBrgJ.Enabled = False
            tNamaCusJ.Enabled = False
            tHargaCusJ.Enabled = False
            tJumlah.Enabled = False
            tTotalJ.Enabled = False
            Call TampilPenjualan()
            Call Kosong()
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Call KlikHapus()
        If tKodeJ.Text = "" Then
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
        Else
            Call Koneksi()
            Dim Hapus As String
            Hapus = "DELETE FROM tb_penjualan WHERE kode_jual='" & tKodeJ.Text & "'"
            cmd = New SqlCommand(Hapus, konek)
            Select Case MsgBox("Yakin menghapus ?", MsgBoxStyle.YesNo, "Hapus Data")
                Case MsgBoxResult.Yes
                    tNamaCusJ.Enabled = False
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Dihapus")
                Case MsgBoxResult.No
                    tNamaCusJ.Enabled = False
            End Select
            Call TampilPenjualan()
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
        Call TampilPenjualan()
        Call AturGrid()
        ToolStripLabel1.Text = "(PENJUALAN)"
        ToolStripLabel2.Text = "(" & FormMenu.ToolStripStatusLabel2.Text & ")"
        ToolStripLabel3.Text = "(" & Date.Today().ToString("dddd, d MMM yyyy") & ")"
        tKodeJ.Enabled = False
        cbKodeBrgJ.Enabled = False
        tNamaCusJ.Enabled = False
        tHargaCusJ.Enabled = False
        tJumlah.Enabled = False
        tTotalJ.Enabled = False
    End Sub

    Sub TotalPembelian()
        harga = Val(tHargaCusJ.Text)
        jumlah = Val(tJumlah.Text)
        total = jumlah * harga
        tTotalJ.Text = total
    End Sub

    Private Sub tHargaSupB_TextChanged(sender As Object, e As EventArgs) Handles tHargaCusJ.TextChanged
        Call TotalPembelian()
    End Sub

    Private Sub tJumlah_TextChanged(sender As Object, e As EventArgs) Handles tJumlah.TextChanged
        Call TotalPembelian()
    End Sub

    Private Sub tTotalB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tTotalJ.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub tJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tHargaSupB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tHargaCusJ.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If bUbah.Enabled = False And bHapus.Enabled = False Then
            MsgBox("Silahkan Isi Field Form")
        End If
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT kode_jual, tb_penjualan.kode_barang, nama_barang, nama_pembeli, harga_satuan, jumlah, total_dibayar, tb_penjualan.tanggal_input, tb_penjualan.operator FROM tb_penjualan INNER JOIN tb_hp on tb_penjualan.kode_barang = tb_hp.kode_barang WHERE kode_jual='" & DataGridView1.Item(0, i).Value & "'", konek)
        'cmd = New SqlCommand("SELECT * FROM tb_penjualan WHERE kode_jual='" & DataGridView1.Item(0, i).Value & "'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNamaCusJ.Focus()
        Else
            tKodeJ.Text = rd.Item("kode_jual")
            cbKodeBrgJ.Text = rd.Item("kode_barang") + "  |  " + rd.Item("nama_barang")
            'cbKodeBrgJ.Text = rd.Item("kode_barang")
            tNamaCusJ.Text = rd.Item("nama_pembeli")
            tHargaCusJ.Text = rd.Item("harga_satuan")
            tJumlah.Text = rd.Item("jumlah")
            tTotalJ.Text = rd.Item("total_dibayar")
            tKodeJ.Focus()
            If bHapus.Enabled = False Then
                cbKodeBrgJ.Enabled = True
                tNamaCusJ.Enabled = True
                tHargaCusJ.Enabled = True
                tJumlah.Enabled = True
                tTotalJ.Enabled = True
            ElseIf bUbah.Enabled = False Then
                cbKodeBrgJ.Enabled = False
                tNamaCusJ.Enabled = False
                tHargaCusJ.Enabled = False
                tJumlah.Enabled = False
                tTotalJ.Enabled = False
            End If

        End If

    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Call Koneksi()
        cmd = New SqlCommand("SELECT kode_jual, nama_barang, nama_pembeli, harga_satuan, jumlah, total_dibayar, tb_penjualan.tanggal_input, tb_penjualan.operator FROM tb_penjualan INNER JOIN tb_hp on tb_penjualan.kode_barang = tb_hp.kode_barang WHERE nama_barang LIKE '%" & tSearch.Text & "%' OR kode_jual LIKE '%" & tSearch.Text & "%' OR nama_pembeli LIKE '%" & tSearch.Text & "%'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("SELECT kode_jual, nama_barang, nama_pembeli, harga_satuan, jumlah, total_dibayar, tb_penjualan.tanggal_input, tb_penjualan.operator FROM tb_penjualan INNER JOIN tb_hp on tb_penjualan.kode_barang = tb_hp.kode_barang WHERE nama_barang LIKE '%" & tSearch.Text & "%' OR kode_jual LIKE '%" & tSearch.Text & "%' OR nama_pembeli LIKE '%" & tSearch.Text & "%'", konek)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If

    End Sub

    Private Sub cbKodeBrgJ_TextChanged(sender As Object, e As EventArgs) Handles cbKodeBrgJ.TextChanged
        If cbKodeBrgJ.Text.Length >= 4 And bUbah.Enabled = False And bHapus.Enabled = False Then
            Dim kode_barang As String
            kode_barang = cbKodeBrgJ.Text.Substring(0, 4)
            Call Koneksi()
            cmd = New SqlCommand("SELECT nama_barang, harga FROM tb_hp WHERE kode_barang ='" & kode_barang & "'", konek)
            rd = cmd.ExecuteReader
            rd.Read()
            tHargaCusJ.Text = rd.Item("harga")
        ElseIf cbKodeBrgJ.Text.Length >= 4 And tNamaCusJ.Enabled = True And bTambah.Enabled = False And bHapus.Enabled = False Then
            Dim kode_barang As String
            kode_barang = cbKodeBrgJ.Text.Substring(0, 4)
            Call Koneksi()
            cmd = New SqlCommand("SELECT nama_barang, harga FROM tb_hp WHERE kode_barang ='" & kode_barang & "'", konek)
            rd = cmd.ExecuteReader
            rd.Read()
            tHargaCusJ.Text = rd.Item("harga")
        Else
            Exit Sub

        End If
    End Sub

    Private Sub cbKodeBrgJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbKodeBrgJ.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class