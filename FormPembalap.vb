Public Class FormPembalap

    Private selectedIdPembalap As Integer = -1
    Private dtTimCombo As DataTable

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        FormTim.Show()
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        ' Mana formnya wok
    End Sub

    Private Sub btnNavHasil_Click(sender As Object, e As EventArgs) Handles btnNavHasil.Click
        FormHasilRace.Show()
    End Sub

    Private Sub btnNavKlasemen_Click(sender As Object, e As EventArgs) Handles btnNavKlasemen.Click
        FormKlasemen.Show()
    End Sub

    Private Sub FormPembalap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatComboBoxTim()
        TampilPembalap()
    End Sub

    Private Sub MuatComboBoxTim()

        dtTimCombo = GetTimUntukComboBox()

        cbTim.DataSource = Nothing
        cbTim.DataSource = dtTimCombo
        cbTim.DisplayMember = "namaTim"
        cbTim.ValueMember = "id"

        If cbTim.Items.Count > 0 Then
            cbTim.SelectedIndex = 0
        End If

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

        Dim namaValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNamaPembalap, "Inputan tidak boleh kosong")

        Dim negaraValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNegaraPembalap, "Inputan tidak boleh kosong")

        Dim nomorValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNomor, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not negaraValid OrElse Not nomorValid Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        Return True

    End Function

    Private Sub KosongPembalap()

        txtNamaPembalap.Clear()
        txtNegaraPembalap.Clear()
        txtNomor.Clear()
        txtSearchPembalap.Clear()

        selectedIdPembalap = -1

        If cbTim.Items.Count > 0 Then
            cbTim.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnSimpanPembalap_Click(sender As Object, e As EventArgs) Handles btnSimpanPembalap.Click

        If Not ValidasiPembalap() Then Exit Sub

        If SimpanPembalap(
            txtNamaPembalap.Text.Trim(),
            txtNegaraPembalap.Text.Trim(),
            txtNomor.Text.Trim(),
            CInt(cbTim.SelectedValue)) Then

            MessageBox.Show("Data berhasil disimpan")

            TampilPembalap()
            KosongPembalap()

        End If

    End Sub

    Private Sub btnUbahPembalap_Click(sender As Object, e As EventArgs) Handles btnUbahPembalap.Click

        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan diubah")
            Exit Sub
        End If

        If Not ValidasiPembalap() Then Exit Sub

        If UbahPembalap(
            selectedIdPembalap,
            txtNamaPembalap.Text.Trim(),
            txtNegaraPembalap.Text.Trim(),
            txtNomor.Text.Trim(),
            CInt(cbTim.SelectedValue)) Then

            MessageBox.Show("Data berhasil diubah")

            TampilPembalap()
            KosongPembalap()

        End If

    End Sub

    Private Sub btnHapusPembalap_Click(sender As Object, e As EventArgs) Handles btnHapusPembalap.Click

        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus")
            Exit Sub
        End If

        If HapusPembalap(selectedIdPembalap) Then

            MessageBox.Show("Data berhasil dihapus")

            TampilPembalap()
            KosongPembalap()

        End If

    End Sub

    Private Sub dgvPembalap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembalap.CellClick

        If e.RowIndex >= 0 Then

            Dim row = dgvPembalap.Rows(e.RowIndex)

            selectedIdPembalap = CInt(row.Cells("id").Value)

            txtNamaPembalap.Text = row.Cells("nama").Value.ToString()
            txtNegaraPembalap.Text = row.Cells("negara").Value.ToString()
            txtNomor.Text = row.Cells("nomor").Value.ToString()

            cbTim.SelectedValue = CInt(row.Cells("idTim").Value)

        End If

    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged

        If txtSearchPembalap.Text.Trim() = "" Then
            TampilPembalap()
        Else

            dgvPembalap.DataSource =
                SearchPembalap(txtSearchPembalap.Text.Trim())

        End If

    End Sub

End Class