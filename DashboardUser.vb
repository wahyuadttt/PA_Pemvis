Public Class DashboardUser

<<<<<<< HEAD
    Private currentUserControl As UserControl

    Private Sub DashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsAdmin = False
        ' Load default: Pembalap
        LoadUserControl(New UC_PembalapUser())
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
        LoadUserControl(New UC_PembalapUser())
    End Sub

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        LoadUserControl(New UC_TimUser())
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        LoadUserControl(New UC_RaceUser())
    End Sub

    Private Sub btnNavHasil_Click(sender As Object, e As EventArgs) Handles btnNavHasil.Click
        LoadUserControl(New UC_HasilRaceUser())
    End Sub

    Private Sub btnNavKlasemen_Click(sender As Object, e As EventArgs) Handles btnNavKlasemen.Click
        LoadUserControl(New UC_Klasemen())
    End Sub

    Private Sub btnNavAdminMode_Click(sender As Object, e As EventArgs) Handles btnNavAdminMode.Click
        LoginAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

=======
    Private Sub DashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsAdmin = False

        tabMain.SelectedTab = tpPembalap

        TampilPembalap()
        TampilTim()
        TampilRace()
        MuatComboBoxRace()
    End Sub


    Private Sub btnNavPembalap_Click(sender As Object, e As EventArgs) Handles btnNavPembalap.Click
        TampilPembalap()
        tabMain.SelectedTab = tpPembalap
    End Sub

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        TampilTim()
        tabMain.SelectedTab = tpTim
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        TampilRace()
        tabMain.SelectedTab = tpRace
    End Sub

    Private Sub btnNavHasil_Click(sender As Object, e As EventArgs)
        tabMain.SelectedTab = tpHasil
    End Sub

    Private Sub btnNavKlasemen_Click(sender As Object, e As EventArgs) Handles btnNavKlasemen.Click
        FormKlasemen.Show()
    End Sub


    Private Sub btnLoginAdmin_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah Anda ingin login sebagai Admin?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            LoginAdmin.Show()
            Me.Hide()
        End If
    End Sub


>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
    Private Sub DashboardUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

<<<<<<< HEAD
=======

    Private Sub TampilPembalap()

        dgvPembalap.DataSource = Nothing
        dgvPembalap.DataSource = GetAllPembalap()
        dgvPembalap.ReadOnly = True

        If dgvPembalap.Columns.Contains("id") Then
            dgvPembalap.Columns("id").Visible = False
        End If

        If dgvPembalap.Columns.Contains("idTim") Then
            dgvPembalap.Columns("idTim").Visible = False
        End If

        If dgvPembalap.Columns.Contains("nama") Then
            dgvPembalap.Columns("nama").HeaderText = "Nama Pembalap"
        End If

        If dgvPembalap.Columns.Contains("negara") Then
            dgvPembalap.Columns("negara").HeaderText = "Negara"
        End If

        If dgvPembalap.Columns.Contains("nomor") Then
            dgvPembalap.Columns("nomor").HeaderText = "Nomor"
        End If

        If dgvPembalap.Columns.Contains("tim") Then
            dgvPembalap.Columns("tim").HeaderText = "Tim"
        End If

    End Sub


    Private Sub TampilTim()

        dgvTim.DataSource = Nothing
        dgvTim.DataSource = GetAllTim()
        dgvTim.ReadOnly = True

        If dgvTim.Columns.Contains("id") Then
            dgvTim.Columns("id").Visible = False
        End If

        If dgvTim.Columns.Contains("namaTim") Then
            dgvTim.Columns("namaTim").HeaderText = "Nama Tim"
        End If

        If dgvTim.Columns.Contains("negara") Then
            dgvTim.Columns("negara").HeaderText = "Negara"
        End If

        If dgvTim.Columns.Contains("mesin") Then
            dgvTim.Columns("mesin").HeaderText = "Mesin"
        End If

        If dgvTim.Columns.Contains("chasis") Then
            dgvTim.Columns("chasis").HeaderText = "Chasis"
        End If

    End Sub


    Private Sub TampilRace()

        dgvRace.DataSource = Nothing
        dgvRace.DataSource = GetAllRace()
        dgvRace.ReadOnly = True

        If dgvRace.Columns.Contains("id") Then
            dgvRace.Columns("id").Visible = False
        End If

        If dgvRace.Columns.Contains("namaRace") Then
            dgvRace.Columns("namaRace").HeaderText = "Nama Race"
        End If

        If dgvRace.Columns.Contains("lokasi") Then
            dgvRace.Columns("lokasi").HeaderText = "Lokasi"
        End If

        If dgvRace.Columns.Contains("tanggal") Then
            dgvRace.Columns("tanggal").HeaderText = "Tanggal"
        End If

        If dgvRace.Columns.Contains("putaran") Then
            dgvRace.Columns("putaran").HeaderText = "Putaran"
        End If

    End Sub


    Private Sub MuatComboBoxRace()

        Dim dtRace As DataTable = GetAllRace()

        cbPilihRace.DataSource = dtRace
        cbPilihRace.DisplayMember = "namaRace"
        cbPilihRace.ValueMember = "id"

        If dtRace.Rows.Count > 0 Then
            cbPilihRace.SelectedIndex = 0
        End If

    End Sub


    Private Sub cbPilihRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPilihRace.SelectedIndexChanged

        If TypeOf cbPilihRace.SelectedValue Is Integer Then

            dgvHasilRace.DataSource = Nothing
            dgvHasilRace.DataSource = GetHasilRaceByRace(CInt(cbPilihRace.SelectedValue))
            dgvHasilRace.ReadOnly = True

            If dgvHasilRace.Columns.Contains("id") Then
                dgvHasilRace.Columns("id").Visible = False
            End If

            If dgvHasilRace.Columns.Contains("namaRace") Then
                dgvHasilRace.Columns("namaRace").HeaderText = "Race"
            End If

            If dgvHasilRace.Columns.Contains("pembalap") Then
                dgvHasilRace.Columns("pembalap").HeaderText = "Pembalap"
            End If

            If dgvHasilRace.Columns.Contains("namaTim") Then
                dgvHasilRace.Columns("namaTim").HeaderText = "Tim"
            End If

            If dgvHasilRace.Columns.Contains("posisiFinish") Then
                dgvHasilRace.Columns("posisiFinish").HeaderText = "Posisi"
            End If

            If dgvHasilRace.Columns.Contains("gap") Then
                dgvHasilRace.Columns("gap").HeaderText = "Gap"
            End If

            If dgvHasilRace.Columns.Contains("statusFinish") Then
                dgvHasilRace.Columns("statusFinish").HeaderText = "Status"
            End If

            If dgvHasilRace.Columns.Contains("fastestLap") Then
                dgvHasilRace.Columns("fastestLap").HeaderText = "Fastest Lap"
            End If

            If dgvHasilRace.Columns.Contains("poin") Then
                dgvHasilRace.Columns("poin").HeaderText = "Poin"
            End If

        End If

    End Sub


    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged

        If txtSearchPembalap.Text.Trim = "" Then
            TampilPembalap()
        Else
            dgvPembalap.DataSource = SearchPembalap(txtSearchPembalap.Text.Trim)

            If dgvPembalap.Columns.Contains("id") Then
                dgvPembalap.Columns("id").Visible = False
            End If

            If dgvPembalap.Columns.Contains("idTim") Then
                dgvPembalap.Columns("idTim").Visible = False
            End If
        End If

    End Sub


    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged

        If txtSearchTim.Text.Trim = "" Then
            TampilTim()
        Else
            dgvTim.DataSource = SearchTim(txtSearchTim.Text.Trim)

            If dgvTim.Columns.Contains("id") Then
                dgvTim.Columns("id").Visible = False
            End If
        End If

    End Sub


    Private Sub txtSearchRace_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRace.TextChanged

        If txtSearchRace.Text.Trim = "" Then
            TampilRace()
        Else
            dgvRace.DataSource = SearchRace(txtSearchRace.Text.Trim)

            If dgvRace.Columns.Contains("id") Then
                dgvRace.Columns("id").Visible = False
            End If
        End If

    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint

    End Sub
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
End Class