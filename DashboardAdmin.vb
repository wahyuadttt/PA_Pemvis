Public Class DashboardAdmin

    Private currentUserControl As UserControl

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load default: Pembalap
        LoadUserControl(New UC_PembalapAdmin())
    End Sub

    Private Sub LoadUserControl(uc As UserControl)
        ' Hapus UserControl lama
        pnlContent.Controls.Clear()
        
        ' Set properties UserControl
        uc.Dock = DockStyle.Fill
        
        ' Tambahkan ke panel
        pnlContent.Controls.Add(uc)
        
        ' Simpan referensi
        currentUserControl = uc
    End Sub

    Private Sub btnNavPembalap_Click(sender As Object, e As EventArgs) Handles btnNavPembalap.Click
        LoadUserControl(New UC_PembalapAdmin())
    End Sub

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        LoadUserControl(New UC_TimAdmin())
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        LoadUserControl(New UC_RaceAdmin())
    End Sub

    Private Sub btnNavHasil_Click(sender As Object, e As EventArgs) Handles btnNavHasil.Click
        LoadUserControl(New UC_HasilRaceAdmin())
    End Sub

    Private Sub btnNavKlasemen_Click(sender As Object, e As EventArgs) Handles btnNavKlasemen.Click
        LoadUserControl(New UC_Klasemen())
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            DashboardUser.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DashboardAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DashboardUser.Show()
    End Sub

End Class
