Imports System.Data.SqlClient
Public Class FormMerkHp
    Sub KlikTambah()
        tKodeMerk.Enabled = False
        tNamaMerk.Enabled = True
        bUbah.Enabled = False
        bHapus.Enabled = False
        bTambah.Text = "Simpan"
        bTutup.Text = "Batal"
    End Sub
    Sub KlikBatal()
        tKodeMerk.Enabled = False
        tNamaMerk.Enabled = False
        bUbah.Enabled = True
        bHapus.Enabled = True
        bTambah.Enabled = True
        bTutup.Text = "Tutup"
        bTambah.Text = "Tambah"
        bUbah.Text = "Ubah"
        tKodeMerk.Text = ""
        tNamaMerk.Text = ""
    End Sub
    Sub KlikUbah()
        tKodeMerk.Enabled = False
        bTambah.Enabled = False
        bHapus.Enabled = False
        bTutup.Text = "Batal"
        bUbah.Text = "Simpan"
    End Sub
    Sub KlikHapus()
        tKodeMerk.Enabled = False
        tNamaMerk.Enabled = False
        bTambah.Enabled = False
        bUbah.Enabled = False
        bTutup.Text = "Batal"
        tKodeMerk.Enabled = False
    End Sub
    Sub Kosong()
        Me.Show()
        tKodeMerk.Focus()
        tKodeMerk.Clear()
        tNamaMerk.Clear()
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100

        DataGridView1.Columns(0).HeaderText = "KODE MERK"
        DataGridView1.Columns(1).HeaderText = "NAMA MERK"
        DataGridView1.Columns(2).HeaderText = "TANGGAL INPUT"
        DataGridView1.Columns(3).HeaderText = "OPERATOR"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "d MMM yyyy"
    End Sub
    Sub TampilMerk()
        Call Koneksi()
        da = New SqlDataAdapter("SELECT * FROM tb_merk", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_merk")
        DataGridView1.DataSource = ds.Tables("tb_merk")
        DataGridView1.Refresh()
    End Sub

    Private Sub FormMerkHp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call TampilMerk()
        Call Kosong()
        Call AturGrid()
        ToolStripLabel1.Text = "(MERK)"
        ToolStripLabel2.Text = "(" & FormMenu.ToolStripStatusLabel2.Text & ")"
        ToolStripLabel3.Text = "(" & Date.Today().ToString("dddd, d MMM yyyy") & ")"
        tKodeMerk.Enabled = False
        tNamaMerk.Enabled = False
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bUbah.Enabled = True And bHapus.Enabled = True Then
            tNamaMerk.Text = ""
        End If

        If tNamaMerk.Enabled = False Then
            Call KlikTambah()
            Call Koneksi()
            cmd = New SqlCommand("select * from tb_merk where kode_merk in (select max(kode_merk) from tb_merk)", konek)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                UrutanKode = "M" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                UrutanKode = "M" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            tKodeMerk.Text = UrutanKode
            tNamaMerk.Focus()
        Else
            If tNamaMerk.Text = "" Then
                MsgBox("Data Belum Lengkap !")
            Else
                Call Koneksi()
                Dim Simpan As String
                Simpan = "INSERT INTO tb_merk VALUES('" & tKodeMerk.Text & "','" & tNamaMerk.Text & "','" & Date.Today() & "','" & FormMenu.ToolStripStatusLabel2.Text & "')"
                cmd = New SqlCommand(Simpan, konek)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Terinput", MsgBoxStyle.Information, "information")
                Call KlikBatal()
                Call TampilMerk()
                Call Kosong()
                Call AturGrid()
            End If
        End If
    End Sub

    Private Sub bTutup_Click(sender As Object, e As EventArgs) Handles bTutup.Click
        If bTambah.Enabled = False Or bUbah.Enabled = False Or bHapus.Enabled = False Then
            Call KlikBatal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT * FROM tb_merk WHERE kode_merk='" & DataGridView1.Item(0, i).Value & "'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNamaMerk.Focus()
        Else
            tKodeMerk.Text = rd.Item("kode_merk")
            tNamaMerk.Text = rd.Item("nama_merk")
            tNamaMerk.Focus()
            If bHapus.Enabled = False Then
                tNamaMerk.Enabled = True
            ElseIf bUbah.Enabled = False Then
                tNamaMerk.Enabled = False
            End If
        End If
    End Sub
    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        Call KlikUbah()
        If tNamaMerk.Enabled = False And tKodeMerk.Enabled = False And tKodeMerk.TextLength > 0 Then
            tNamaMerk.Enabled = True
            MsgBox("Silahkan Ubah Nama Merk")
        ElseIf tNamaMerk.Text = "" Or tKodeMerk.Text = "" Then
            tNamaMerk.Enabled = False
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
            Exit Sub
        ElseIf tNamaMerk.Enabled = True And bTambah.Enabled = False Then
            Call Koneksi()
            Dim Edit As String
            Edit = "UPDATE tb_merk SET nama_merk='" & tNamaMerk.Text & "' WHERE kode_merk='" & tKodeMerk.Text & "'"
            cmd = New SqlCommand(Edit, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Information")
            tNamaMerk.Enabled = False
            Call TampilMerk()
            Call Kosong()
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Call KlikHapus()
        If tKodeMerk.Text = "" Then
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
        Else
            Call Koneksi()
            cmd = New SqlCommand("SELECT kode_merk FROM tb_merk WHERE kode_merk IN (SELECT kode_merk FROM tb_hp)", konek)
            rd = cmd.ExecuteReader
            Do While rd.Read
                If rd.Item("kode_merk") = tKodeMerk.Text Then
                    MsgBox("Data sudah terinput sebagai merk di Data HP")
                    Exit Sub
                End If
            Loop
            Call Koneksi()
            Dim Hapus As String
            Hapus = "DELETE FROM tb_merk WHERE kode_merk='" & tKodeMerk.Text & "'"
            cmd = New SqlCommand(Hapus, konek)
            Select Case MsgBox("Yakin menghapus ?", MsgBoxStyle.YesNo, "Hapus Data")
                Case MsgBoxResult.Yes
                    tNamaMerk.Enabled = False
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Dihapus")
                Case MsgBoxResult.No
                    tNamaMerk.Enabled = False
            End Select
            Call TampilMerk()
            Call Kosong()
        End If
    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Call Koneksi()
        cmd = New SqlCommand("SELECT * FROM tb_merk WHERE nama_merk LIKE '%" & tSearch.Text & "%'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("SELECT * FROM tb_merk WHERE nama_merk LIKE '%" & tSearch.Text & "%'", konek)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
End Class