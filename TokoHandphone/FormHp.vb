Imports System.Data.SqlClient
Public Class FormHp
    Sub KlikTambah()
        bUbah.Enabled = False
        bHapus.Enabled = False
        bTambah.Text = "Simpan"
        bTutup.Text = "Batal"
        cbKodeMerk.Enabled = True
        tNamaBrg.Enabled = True
        cbRam.Enabled = True
        cbRom.Enabled = True
        tSpes.Enabled = True
        tHarga.Enabled = True
    End Sub
    Sub KlikBatal()
        bUbah.Enabled = True
        bHapus.Enabled = True
        bTambah.Enabled = True
        bTutup.Text = "Tutup"
        bTambah.Text = "Tambah"
        bUbah.Text = "Ubah"
        tKodeBrg.Text = ""
        tNamaBrg.Text = ""
        tSpes.Text = ""
        tHarga.Text = ""
        cbKodeMerk.Text = ""
        cbRam.Text = ""
        cbRom.Text = ""
        cbKodeMerk.Enabled = False
        tNamaBrg.Enabled = False
        cbRam.Enabled = False
        cbRom.Enabled = False
        tSpes.Enabled = False
        tHarga.Enabled = False
    End Sub
    Sub KlikUbah()
        tKodeBrg.Enabled = False
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
        tKodeBrg.Clear()
        cbKodeMerk.SelectedIndex = -1
        tNamaBrg.Clear()
        cbRam.SelectedIndex = -1
        cbRom.SelectedIndex = -1
        tSpes.Clear()
        tHarga.Clear()
    End Sub
    Sub TampilMerk()
        cmd = New SqlCommand("SELECT kode_merk, nama_merk FROM tb_merk", konek)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbKodeMerk.Items.Add(rd.Item("kode_merk") + "  |  " + rd.Item("nama_merk"))
        Loop
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 140
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100

        DataGridView1.Columns(0).HeaderText = "KODE BARANG"
        DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(2).HeaderText = "RAM"
        DataGridView1.Columns(3).HeaderText = "ROM"
        DataGridView1.Columns(4).HeaderText = "HARGA"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp #,###"
        DataGridView1.Columns(5).HeaderText = "TANGGAL INPUT"
        DataGridView1.Columns(6).HeaderText = "OPERATOR"

    End Sub
    Sub TampilHp()
        Call Koneksi()
        da = New SqlDataAdapter("SELECT kode_barang, nama_barang, ram, rom, harga, tanggal_input, operator FROM tb_hp", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_hp")
        DataGridView1.DataSource = ds.Tables("tb_hp")
        DataGridView1.Refresh()
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bUbah.Enabled = True And bHapus.Enabled = True Then
            tKodeBrg.Text = ""
            tNamaBrg.Text = ""
            tSpes.Text = ""
            tHarga.Text = ""
            cbKodeMerk.Text = ""
            cbRam.Text = ""
            cbRom.Text = ""
        End If
        If tNamaBrg.Enabled = False Then
            Call KlikTambah()
            Call Koneksi()
            cmd = New SqlCommand("select * from tb_hp where kode_barang in (select max(kode_barang) from tb_hp)", konek)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                UrutanKode = "B" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                UrutanKode = "B" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            tKodeBrg.Text = UrutanKode
            tNamaBrg.Focus()
        ElseIf tKodeBrg.Text = "" Or tNamaBrg.Text = "" Or tSpes.text = "" Or tHarga.Text = "" Or cbKodeMerk.Text = "" Or cbRam.Text = "" Or cbRom.Text = "" Then
            MsgBox("Data Belum Lengkap !")
        Else
            Call Koneksi()
            Dim Simpan As String
            Simpan = "INSERT INTO tb_hp VALUES('" & tKodeBrg.Text & "','" & cbKodeMerk.Text.Substring(0, 4) & "','" & tNamaBrg.Text & "','" & cbRam.Text & "','" & cbRom.Text & "','" & tSpes.Text & "','" & tHarga.Text & "','" & Date.Today() & "','" & FormMenu.ToolStripStatusLabel2.Text & "')"
            cmd = New SqlCommand(Simpan, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Terinput", MsgBoxStyle.Information, "information")
            Call KlikBatal()
            Call TampilHp()
            Call Kosong()
            Call AturGrid()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        Call KlikUbah()
        If tNamaBrg.Enabled = False And tKodeBrg.Enabled = False And tKodeBrg.TextLength > 0 Then
            tNamaBrg.Enabled = True
            tSpes.Enabled = True
            tHarga.Enabled = True
            cbKodeMerk.Enabled = True
            cbRam.Enabled = True
            cbRom.Enabled = True
            MsgBox("Silahkan Ubah Identitas Barang")
        ElseIf tNamabrg.Text = "" Or tKodebrg.Text = "" Then
            tNamaBrg.Enabled = False
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
            Exit Sub
        ElseIf tNamabrg.Enabled = True And bTambah.Enabled = False Then
            Call Koneksi()
            Dim Edit As String
            Edit = "UPDATE tb_hp SET kode_merk='" & cbKodeMerk.Text.Substring(0, 4) & "', nama_barang='" & tNamaBrg.Text & "', ram='" & cbRam.Text & "', rom='" & cbRom.Text & "', spesifikasi='" & tSpes.Text & "', harga='" & tHarga.Text & "' WHERE kode_barang='" & tKodeBrg.Text & "'"
            cmd = New SqlCommand(Edit, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Information")
            tNamaBrg.Enabled = False
            tSpes.Enabled = False
            tHarga.Enabled = False
            cbKodeMerk.Enabled = False
            cbRam.Enabled = False
            cbRom.Enabled = False
            Call TampilHp()
            Call Kosong()
        End If

    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Call KlikHapus()
        If tKodeBrg.Text = "" Then
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
        Else
            Call Koneksi()
            Dim Hapus As String
            Hapus = "DELETE FROM tb_hp WHERE kode_barang='" & tKodeBrg.Text & "'"
            cmd = New SqlCommand(Hapus, konek)
            Select Case MsgBox("Yakin menghapus ?", MsgBoxStyle.YesNo, "Hapus Data")
                Case MsgBoxResult.Yes
                    tNamaBrg.Enabled = False
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Dihapus")
                Case MsgBoxResult.No
                    tNamaBrg.Enabled = False
            End Select
            Call TampilHp()
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

    Private Sub FormHp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call TampilMerk()
        Call TampilHp()
        Call Kosong()
        Call AturGrid()
        ToolStripLabel1.Text = "(HANDPHONE)"
        ToolStripLabel2.Text = "(" & FormMenu.ToolStripStatusLabel2.Text & ")"
        ToolStripLabel3.Text = "(" & Date.Today().ToString("dddd, d MMM yyyy") & ")"
        tKodeBrg.Enabled = False
        cbKodeMerk.Enabled = False
        tNamaBrg.Enabled = False
        cbRam.Enabled = False
        cbRom.Enabled = False
        tSpes.Enabled = False
        tHarga.Enabled = False
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If bUbah.Enabled = False And bHapus.Enabled = False Then
            MsgBox("Silahkan Isi Field Form")
        End If
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT kode_barang, tb_hp.kode_merk, nama_merk, nama_barang, ram, rom, spesifikasi, harga FROM tb_hp inner join tb_merk on tb_hp.kode_merk = tb_merk.kode_merk WHERE kode_barang='" & DataGridView1.Item(0, i).Value & "'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNamaBrg.Focus()
        Else
            tKodeBrg.Text = rd.Item("kode_barang")
            tNamaBrg.Text = rd.Item("nama_barang")
            tSpes.Text = rd.Item("spesifikasi")
            tHarga.Text = rd.Item("harga")
            cbKodeMerk.Text = rd.Item("kode_merk") + "  |  " + rd.Item("nama_merk")
            cbRam.Text = rd.Item("ram")
            cbRom.Text = rd.Item("rom")
            tNamaBrg.Focus()
            If bHapus.Enabled = False Then
                tNamaBrg.Enabled = True
                tSpes.Enabled = True
                tHarga.Enabled = True
                cbKodeMerk.Enabled = True
                cbRam.Enabled = True
                cbRom.Enabled = True
            ElseIf bUbah.Enabled = False Then
                tNamaBrg.Enabled = False
                tSpes.Enabled = False
                tHarga.Enabled = False
                cbKodeMerk.Enabled = False
                cbRam.Enabled = False
                cbRom.Enabled = False
            End If

        End If

    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Call Koneksi()
        cmd = New SqlCommand("SELECT kode_barang, nama_barang, ram, rom, harga, tanggal_input, operator FROM tb_hp WHERE nama_barang LIKE '%" & tSearch.Text & "%' OR ram LIKE '%" & tSearch.Text & "%' OR rom LIKE '%" & tSearch.Text & "%' OR harga LIKE '%" & tSearch.Text & "%'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("SELECT kode_barang, nama_barang, ram, rom, harga, tanggal_input, operator FROM tb_hp WHERE nama_barang LIKE '%" & tSearch.Text & "%' OR ram LIKE '%" & tSearch.Text & "%' OR rom LIKE '%" & tSearch.Text & "%' OR harga LIKE '%" & tSearch.Text & "%'", konek)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If

    End Sub

    Private Sub cbKodeMerk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbKodeMerk.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbRam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRam.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbRom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRom.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class