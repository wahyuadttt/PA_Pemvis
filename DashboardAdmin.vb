Public Class DashboardAdmin

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanUserControl(New UC_PembalapAdmin())
    End Sub

    Private Sub TampilkanUserControl(uc As UserControl)

        pnlContent.Controls.Clear()

        uc.Dock = DockStyle.Fill

        pnlContent.Controls.Add(uc)

    End Sub

    Private Sub btnNavPembalap_Click(sender As Object, e As EventArgs) Handles btnNavPembalap.Click
        TampilkanUserControl(New UC_PembalapAdmin())
    End Sub

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        TampilkanUserControl(New UC_TimAdmin())
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        TampilkanUserControl(New UC_RaceAdmin())
    End Sub

    Private Sub btnNavHasil_Click(sender As Object, e As EventArgs) Handles btnNavHasil.Click
        TampilkanUserControl(New UC_HasilRaceAdmin())
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click

        Dim hasil As DialogResult =
            MessageBox.Show(
                "Yakin ingin logout?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            Dim frm As New LoginAdmin()
            frm.Show()

            Me.Close()

        End If

    End Sub

End Class