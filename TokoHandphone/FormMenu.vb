Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MerkHandphoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerkHandphoneToolStripMenuItem.Click
        FormMerkHp.Show()
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem.Click
        FormPengguna.Show()
    End Sub

    Private Sub DataHandphoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataHandphoneToolStripMenuItem.Click
        FormHp.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        FormPembelian.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub StokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangToolStripMenuItem.Click
        FormLaporanStok.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        FormLaporanPembelian.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        FormLaporanPenjualan.Show()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class