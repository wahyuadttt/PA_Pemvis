Public Class FormTim

    Private selectedIdTim As Integer = -1


    Private Sub btnNavPembalap_Click(sender As Object, e As EventArgs) Handles btnNavPembalap.Click
        FormPembalap.Show()
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

    Private Sub FormTim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTim()
    End Sub

    Private Sub TampilTim()

        dgvTim.DataSource = Nothing
        dgvTim.DataSource = GetAllTim()

        If dgvTim.Columns.Contains("id") Then
            dgvTim.Columns("id").Visible = False
        End If

    End Sub

    Private Function ValidasiTim() As Boolean

        ErrorProvider1.Clear()

        Dim namaValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNamaTim, "Tidak boleh kosong")

        Dim negaraValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNegaraTim, "Tidak boleh kosong")

        Dim mesinValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtMesin, "Tidak boleh kosong")

        Dim chasisValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtChasis, "Tidak boleh kosong")

        Return namaValid And negaraValid And mesinValid And chasisValid

    End Function

    Private Sub KosongTim()

        txtNamaTim.Clear()
        txtNegaraTim.Clear()
        txtMesin.Clear()
        txtChasis.Clear()

        selectedIdTim = -1

    End Sub

    Private Sub btnSimpanTim_Click(sender As Object, e As EventArgs) Handles btnSimpanTim.Click

        If Not ValidasiTim() Then Exit Sub

        If SimpanTim(
            txtNamaTim.Text.Trim(),
            txtNegaraTim.Text.Trim(),
            txtMesin.Text.Trim(),
            txtChasis.Text.Trim()) Then

            MessageBox.Show("Data berhasil disimpan")

            TampilTim()
            KosongTim()

        End If

    End Sub

    Private Sub btnUbahTim_Click(sender As Object, e As EventArgs) Handles btnUbahTim.Click

        If selectedIdTim = -1 Then
            MessageBox.Show("Pilih data")
            Exit Sub
        End If

        If UbahTim(
            selectedIdTim,
            txtNamaTim.Text.Trim(),
            txtNegaraTim.Text.Trim(),
            txtMesin.Text.Trim(),
            txtChasis.Text.Trim()) Then

            MessageBox.Show("Data berhasil diubah")

            TampilTim()
            KosongTim()

        End If

    End Sub

    Private Sub btnHapusTim_Click(sender As Object, e As EventArgs) Handles btnHapusTim.Click

        If selectedIdTim = -1 Then
            MessageBox.Show("Pilih data")
            Exit Sub
        End If

        If HapusTim(selectedIdTim) Then

            MessageBox.Show("Data berhasil dihapus")

            TampilTim()
            KosongTim()

        End If

    End Sub

    Private Sub dgvTim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTim.CellClick

        If e.RowIndex >= 0 Then

            Dim row = dgvTim.Rows(e.RowIndex)

            selectedIdTim = CInt(row.Cells("id").Value)

            txtNamaTim.Text = row.Cells("namaTim").Value.ToString()
            txtNegaraTim.Text = row.Cells("negara").Value.ToString()
            txtMesin.Text = row.Cells("mesin").Value.ToString()
            txtChasis.Text = row.Cells("chasis").Value.ToString()

        End If

    End Sub

End Class