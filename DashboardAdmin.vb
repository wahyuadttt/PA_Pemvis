Public Class DashboardAdmin

<<<<<<< HEAD
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
=======
    Private selectedIdPembalap As Integer = -1
    Private selectedIdTim As Integer = -1
    Private selectedIdRace As Integer = -1
    Private selectedIdHasil As Integer = -1
    Private selectedIdKlasemen As Integer = -1

    Private dtTimCombo As DataTable


    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabMain.SelectedTab = tpPembalap
        MuatComboBoxTim()
        TampilPembalap()
        TampilTim()
        TampilRace()
        MuatComboBoxRace()
        MuatComboBoxPembalap()
        TampilHasil()
    End Sub


    Private Sub btnNavPembalap_Click(sender As Object, e As EventArgs) Handles btnNavPembalap.Click
        tabMain.SelectedTab = tpPembalap
    End Sub

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        tabMain.SelectedTab = tpTim
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        tabMain.SelectedTab = tpRace
    End Sub

    Private Sub btnNavHasil_Click(sender As Object, e As EventArgs) Handles btnNavHasil.Click
        tabMain.SelectedTab = tpHasil
    End Sub

    Private Sub btnNavKlasemen_Click(sender As Object, e As EventArgs) Handles btnNavKlasemen.Click
        FormKlasemen.Show()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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

<<<<<<< HEAD
=======
    Private Sub MuatComboBoxTim()
        dtTimCombo = GetTimUntukComboBox()
        cbTim.DataSource = Nothing
        cbTim.DataSource = dtTimCombo
        cbTim.DisplayMember = "namaTim"
        cbTim.ValueMember = "id"
        If cbTim.Items.Count > 0 Then cbTim.SelectedIndex = 0
    End Sub

    Private Sub KosongPembalap()
        txtNamaPembalap.Clear()
        txtNegaraPembalap.Clear()
        txtNomor.Clear()
        txtSearchPembalap.Clear()
        ErrorProvider1.Clear()
        selectedIdPembalap = -1
        If cbTim.Items.Count > 0 Then cbTim.SelectedIndex = 0
        txtNamaPembalap.Focus()
    End Sub

    Private Sub TampilPembalap()

        dgvPembalap.DataSource = Nothing
        dgvPembalap.DataSource = GetAllPembalap()

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

    Private Function ValidasiPembalap() As Boolean
        ErrorProvider1.Clear()
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNamaPembalap, "Inputan tidak boleh kosong")
        Dim negaraValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNegaraPembalap, "Inputan tidak boleh kosong")
        Dim nomorValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNomor, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not negaraValid OrElse Not nomorValid Then
            MessageBox.Show("Inputan tidak boleh kosong", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cbTim.SelectedValue Is Nothing Then
            MessageBox.Show("Pilih Tim terlebih dahulu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnSimpanPembalap_Click(sender As Object, e As EventArgs) Handles btnSimpanPembalap.Click
        If Not ValidasiPembalap() Then Exit Sub

        Dim hasil = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Dim idTimDipilih = Convert.ToInt32(cbTim.SelectedValue)

            If SimpanPembalap(txtNamaPembalap.Text.Trim, txtNegaraPembalap.Text.Trim,
                              txtNomor.Text.Trim, idTimDipilih) Then
                MessageBox.Show("Data berhasil disimpan", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembalap()
                MuatComboBoxPembalap()
                KosongPembalap()
            End If
        End If
    End Sub

    Private Sub btnUbahPembalap_Click(sender As Object, e As EventArgs) Handles btnUbahPembalap.Click
        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not ValidasiPembalap() Then Exit Sub

        Dim hasil = MessageBox.Show("Apakah data ingin diubah?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Dim idTimDipilih = Convert.ToInt32(cbTim.SelectedValue)

            If UbahPembalap(selectedIdPembalap, txtNamaPembalap.Text.Trim,
                            txtNegaraPembalap.Text.Trim, txtNomor.Text.Trim, idTimDipilih) Then
                MessageBox.Show("Data berhasil diubah", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembalap()
                MuatComboBoxPembalap()
                KosongPembalap()
            End If
        End If
    End Sub

    Private Sub btnHapusPembalap_Click(sender As Object, e As EventArgs) Handles btnHapusPembalap.Click
        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPembalap(selectedIdPembalap) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembalap()
                MuatComboBoxPembalap()
                KosongPembalap()
            End If
        End If
    End Sub

    Private Sub btnBatalPembalap_Click(sender As Object, e As EventArgs) Handles btnBatalPembalap.Click
        KosongPembalap()
        TampilPembalap()
    End Sub

    Private Sub dgvPembalap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembalap.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvPembalap.Rows(e.RowIndex)
            selectedIdPembalap = Convert.ToInt32(row.Cells("id").Value)
            txtNamaPembalap.Text = row.Cells("nama").Value.ToString
            txtNegaraPembalap.Text = row.Cells("negara").Value.ToString
            txtNomor.Text = row.Cells("nomor").Value.ToString

            Dim idTimRow = Convert.ToInt32(row.Cells("idTim").Value)
            cbTim.SelectedValue = idTimRow
        End If
    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged
        If txtSearchPembalap.Text.Trim = "" Then
            TampilPembalap()
        Else
            dgvPembalap.DataSource = SearchPembalap(txtSearchPembalap.Text.Trim)
            If dgvPembalap.Columns.Contains("id") Then dgvPembalap.Columns("id").Visible = False
            If dgvPembalap.Columns.Contains("idTim") Then dgvPembalap.Columns("idTim").Visible = False
        End If
    End Sub

    Private Sub txtNamaPembalap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPembalap.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNegara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNegaraPembalap.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub KosongTim()
        txtNamaTim.Clear()
        txtNegaraTim.Clear()
        txtMesin.Clear()
        txtChasis.Clear()
        txtSearchTim.Clear()
        ErrorProvider1.Clear()
        selectedIdTim = -1
        txtNamaTim.Focus()
    End Sub

    Private Sub TampilTim()

        dgvTim.DataSource = Nothing
        dgvTim.DataSource = GetAllTim()

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

    Private Function ValidasiTim() As Boolean
        ErrorProvider1.Clear()
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNamaTim, "Inputan tidak boleh kosong")
        Dim negaraValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNegaraTim, "Inputan tidak boleh kosong")
        Dim mesinValid As Boolean = ValidasiTextBox(ErrorProvider1, txtMesin, "Inputan tidak boleh kosong")
        Dim chasisValid As Boolean = ValidasiTextBox(ErrorProvider1, txtChasis, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not negaraValid OrElse Not mesinValid OrElse Not chasisValid Then
            MessageBox.Show("Inputan tidak boleh kosong", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSimpanTim_Click(sender As Object, e As EventArgs) Handles btnSimpanTim.Click

        If Not ValidasiTim() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
        "Apakah data ingin disimpan?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If SimpanTim(txtNamaTim.Text.Trim(),
                     txtNegaraTim.Text.Trim(),
                     txtMesin.Text.Trim(),
                     txtChasis.Text.Trim()) Then

                MessageBox.Show("Data berhasil disimpan")

                TampilTim()
                MuatComboBoxTim()
                TampilPembalap()
                TampilHasil()
                KosongTim()

            End If
        End If

    End Sub

    Private Sub btnUbahTim_Click(sender As Object, e As EventArgs) Handles btnUbahTim.Click

        If selectedIdTim = -1 Then
            MessageBox.Show("Pilih data tim yang akan diubah")
            Exit Sub
        End If

        If Not ValidasiTim() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
        "Apakah data ingin diubah?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If UbahTim(selectedIdTim,
                   txtNamaTim.Text.Trim(),
                   txtNegaraTim.Text.Trim(),
                   txtMesin.Text.Trim(),
                   txtChasis.Text.Trim()) Then

                MessageBox.Show("Data berhasil diubah")

                TampilTim()
                MuatComboBoxTim()
                TampilPembalap()
                TampilHasil()
                KosongTim()

            End If
        End If

    End Sub

    Private Sub btnHapusTim_Click(sender As Object, e As EventArgs) Handles btnHapusTim.Click

        If selectedIdTim = -1 Then
            MessageBox.Show("Pilih data tim yang akan dihapus")
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
        "Yakin ingin menghapus tim ini?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If HapusTim(selectedIdTim) Then

                MessageBox.Show("Data berhasil dihapus")

                TampilTim()
                MuatComboBoxTim()
                TampilPembalap()
                TampilHasil()
                KosongTim()

            End If
        End If

    End Sub

    Private Sub btnBatalTim_Click(sender As Object, e As EventArgs) Handles btnBatalTim.Click
        KosongTim()
        TampilTim()
    End Sub

    Private Sub dgvTim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTim.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTim.Rows(e.RowIndex)
            selectedIdTim = Convert.ToInt32(row.Cells("id").Value)
            txtNamaTim.Text = row.Cells("namaTim").Value.ToString()
            txtNegaraTim.Text = row.Cells("negara").Value.ToString()
            txtMesin.Text = row.Cells("mesin").Value.ToString()
            txtChasis.Text = row.Cells("chasis").Value.ToString()
        End If
    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged
        If txtSearchTim.Text.Trim() = "" Then
            TampilTim()
        Else
            dgvTim.DataSource = SearchTim(txtSearchTim.Text.Trim())
            If dgvTim.Columns.Contains("id") Then dgvTim.Columns("id").Visible = False
        End If
    End Sub

    Private Sub txtNamaTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaTim.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNegaraTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNegaraTim.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub KosongRace()
        txtNamaRace.Clear()
        cmbSirkuit.SelectedIndex = -1
        txtPutaran.Clear()
        txtSearchRace.Clear()
        ErrorProvider1.Clear()
        selectedIdRace = -1
        dtpTanggal.Value = DateTime.Now
        txtNamaRace.Focus()
    End Sub

    Private Sub TampilRace()

        dgvRace.DataSource = Nothing
        dgvRace.DataSource = GetAllRace()

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

    Private Function ValidasiRace() As Boolean
        ErrorProvider1.Clear()
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNamaRace, "Inputan tidak boleh kosong")
        Dim lokasiValid As Boolean = (cmbSirkuit.Text.Trim() <> "")
        If Not lokasiValid Then ErrorProvider1.SetError(cmbSirkuit, "Inputan tidak boleh kosong") Else ErrorProvider1.SetError(cmbSirkuit, "")
        Dim putaranValid As Boolean = ValidasiTextBox(ErrorProvider1, txtPutaran, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not lokasiValid OrElse Not putaranValid Then
            MessageBox.Show("Inputan tidak boleh kosong", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSimpanRace_Click(sender As Object, e As EventArgs) Handles btnSimpanRace.Click

        If Not ValidasiRace() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
        "Apakah data ingin disimpan?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If SimpanRace(
            txtNamaRace.Text.Trim,
            cmbSirkuit.Text.Trim,
            dtpTanggal.Value.ToString("yyyy-MM-dd"),
            txtPutaran.Text.Trim) Then

                MessageBox.Show("Data berhasil disimpan")

                TampilRace()
                MuatComboBoxRace()
                KosongRace()

            End If
        End If

    End Sub

    Private Sub btnUbahRace_Click(sender As Object, e As EventArgs) Handles btnUbahRace.Click

        If selectedIdRace = -1 Then
            MessageBox.Show("Pilih data race yang akan diubah")
            Exit Sub
        End If

        If Not ValidasiRace() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
        "Apakah data ingin diubah?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If UbahRace(
            selectedIdRace,
            txtNamaRace.Text.Trim,
            cmbSirkuit.Text.Trim,
            dtpTanggal.Value.ToString("yyyy-MM-dd"),
            txtPutaran.Text.Trim) Then

                MessageBox.Show("Data berhasil diubah")

                TampilRace()
                MuatComboBoxRace()
                KosongRace()

            End If
        End If

    End Sub

    Private Sub btnHapusRace_Click(sender As Object, e As EventArgs) Handles btnHapusRace.Click

        If selectedIdRace = -1 Then
            MessageBox.Show("Pilih data race yang akan dihapus")
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
        "Yakin ingin menghapus race ini?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If HapusRace(selectedIdRace) Then

                MessageBox.Show("Data berhasil dihapus")

                TampilRace()
                MuatComboBoxRace()
                TampilHasil()
                KosongRace()

            End If
        End If

    End Sub

    Private Sub btnBatalRace_Click(sender As Object, e As EventArgs) Handles btnBatalRace.Click
        KosongRace()
        TampilRace()
    End Sub

    Private Sub dgvRace_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRace.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRace.Rows(e.RowIndex)
            selectedIdRace = Convert.ToInt32(row.Cells("id").Value)
            txtNamaRace.Text = row.Cells("namaRace").Value.ToString()
            cmbSirkuit.Text = row.Cells("lokasi").Value.ToString()
            txtPutaran.Text = row.Cells("putaran").Value.ToString()
            Dim tgl As String = row.Cells("tanggal").Value.ToString()
            If tgl <> "" Then
                dtpTanggal.Value = Convert.ToDateTime(tgl)
            End If
        End If
    End Sub

    Private Sub txtSearchRace_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRace.TextChanged
        If txtSearchRace.Text.Trim() = "" Then
            TampilRace()
        Else
            dgvRace.DataSource = SearchRace(txtSearchRace.Text.Trim())
            If dgvRace.Columns.Contains("id") Then dgvRace.Columns("id").Visible = False
        End If
    End Sub

    Private Sub txtNamaRace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaRace.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtPutaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPutaran.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub MuatComboBoxRace()

        Dim dtRace As DataTable = GetAllRace()

        cbRaceHasil.DataSource = dtRace.Copy()
        cbRaceHasil.DisplayMember = "namaRace"
        cbRaceHasil.ValueMember = "id"

        cbPilihRace.DataSource = dtRace
        cbPilihRace.DisplayMember = "namaRace"
        cbPilihRace.ValueMember = "id"

    End Sub

    Private Sub MuatComboBoxPembalap()
        cbPembalapHasil.DataSource = GetPembalapUntukComboBox()
        cbPembalapHasil.DisplayMember = "nama"
        cbPembalapHasil.ValueMember = "id"
    End Sub

    Private Sub cbPembalapHasil_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPembalapHasil.SelectionChangeCommitted
        txtTimHasil.Text =
        GetNamaTimByPembalap(CInt(cbPembalapHasil.SelectedValue))

    End Sub

    Private Sub TampilHasil()

        If cbPilihRace.SelectedValue IsNot Nothing AndAlso IsNumeric(cbPilihRace.SelectedValue) Then
            dgvHasilRace.DataSource =
            GetHasilRaceByRace(CInt(cbPilihRace.SelectedValue))
        End If

        If dgvHasilRace.Columns.Contains("id") Then
            dgvHasilRace.Columns("id").Visible = False
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

    End Sub

    Private Function HitungPoin(posisi As Integer, fastestLap As Boolean) As Integer
        Dim poin As Integer = 0

        Select Case posisi
            Case 1 : poin = 25
            Case 2 : poin = 18
            Case 3 : poin = 15
            Case 4 : poin = 12
            Case 5 : poin = 10
            Case 6 : poin = 8
            Case 7 : poin = 6
            Case 8 : poin = 4
            Case 9 : poin = 2
            Case 10 : poin = 1
        End Select

        If fastestLap And posisi <= 10 Then
            poin += 1
        End If

        Return poin
    End Function

    Private Sub UpdatePoin()

        Dim posisi As Integer

        If Integer.TryParse(txtPosisi.Text, posisi) Then
            txtPoinHasil.Text = HitungPoin(
            posisi,
            chkFastestLap.Checked
        ).ToString()
        Else
            txtPoinHasil.Text = "0"
        End If

    End Sub

    Private Sub txtPosisi_TextChanged(sender As Object, e As EventArgs) Handles txtPosisi.TextChanged
        UpdatePoin()
    End Sub

    Private Sub chkFastestLap_CheckedChanged(sender As Object, e As EventArgs) Handles chkFastestLap.CheckedChanged
        UpdatePoin()
    End Sub

    Private Sub cbPilihRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPilihRace.SelectedIndexChanged

        If cbPilihRace.SelectedValue IsNot Nothing AndAlso IsNumeric(cbPilihRace.SelectedValue) Then
            dgvHasilRace.DataSource =
            GetHasilRaceByRace(CInt(cbPilihRace.SelectedValue))
        End If

    End Sub

    Private Sub btnSimpanHasil_Click(sender As Object, e As EventArgs) Handles btnSimpanHasil.Click

        If txtPosisi.Text.Trim = "" Then
            MessageBox.Show("Posisi finish harus diisi")
            Exit Sub
        End If

        Dim posisi As Integer
        If Not Integer.TryParse(txtPosisi.Text, posisi) Then
            MessageBox.Show("Posisi harus berupa angka")
            Exit Sub
        End If

        If Not Integer.TryParse(txtPosisi.Text, posisi) Then
            MessageBox.Show("Posisi harus berupa angka")
            Exit Sub
        End If

        Dim poin As Integer = HitungPoin(posisi, chkFastestLap.Checked)


        If SimpanHasilRace(
        CInt(cbRaceHasil.SelectedValue),
        CInt(cbPembalapHasil.SelectedValue),
        posisi,
        txtGap.Text,
        cbStatusFinish.Text,
        chkFastestLap.Checked,
        poin) Then

            MessageBox.Show("Berhasil disimpan")

            TampilHasil()
            KosongHasil()

        End If

    End Sub

    Private Sub btnUbahHasil_Click(sender As Object, e As EventArgs) Handles btnUbahHasil.Click

        If selectedIdHasil = -1 Then
            MessageBox.Show("Pilih data hasil race yang akan diubah")
            Exit Sub
        End If

        Dim posisi As Integer

        If Not Integer.TryParse(txtPosisi.Text, posisi) Then
            MessageBox.Show("Posisi harus berupa angka")
            Exit Sub
        End If

        Dim poin As Integer = HitungPoin(posisi, chkFastestLap.Checked)

        If UbahHasilRace(
        selectedIdHasil,
        CInt(cbRaceHasil.SelectedValue),
        CInt(cbPembalapHasil.SelectedValue),
        posisi,
        txtGap.Text,
        cbStatusFinish.Text,
        chkFastestLap.Checked,
        poin) Then

            MessageBox.Show("Data berhasil diubah")

            TampilHasil()
            KosongHasil()

        End If

    End Sub


    Private Sub btnHapusHasil_Click(sender As Object, e As EventArgs) Handles btnHapusHasil.Click

        If selectedIdHasil = -1 Then
            MessageBox.Show("Pilih data hasil race yang akan dihapus")
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
        "Yakin ingin menghapus hasil race ini?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If HapusHasilRace(selectedIdHasil) Then

                MessageBox.Show("Data berhasil dihapus")

                TampilHasil()
                KosongHasil()

            End If
        End If

    End Sub

    Private Sub dgvHasilRace_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHasilRace.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvHasilRace.Rows(e.RowIndex)

            selectedIdHasil = CInt(row.Cells("id").Value)

            cbPembalapHasil.Text = row.Cells("pembalap").Value.ToString()
            txtTimHasil.Text = row.Cells("namaTim").Value.ToString()
            txtPosisi.Text = row.Cells("posisiFinish").Value.ToString()
            txtGap.Text = row.Cells("gap").Value.ToString()
            cbStatusFinish.Text = row.Cells("statusFinish").Value.ToString()
            chkFastestLap.Checked = CBool(row.Cells("fastestLap").Value)
            txtPoinHasil.Text = row.Cells("poin").Value.ToString()
        End If

    End Sub

    Private Sub KosongHasil()
        txtGap.Clear()
        txtTimHasil.Clear()
        txtPoinHasil.Clear()

        chkFastestLap.Checked = False
        txtPosisi.Text = 1

        selectedIdHasil = -1
    End Sub



>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
End Class
