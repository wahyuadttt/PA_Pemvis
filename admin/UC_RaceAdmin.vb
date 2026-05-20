Public Class UC_RaceAdmin

    Private selectedId As Integer = 0

    Private Sub UC_RaceAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilRace()
        btnUbahRace.Enabled = False
        btnHapusRace.Enabled = False
    End Sub

    Private Sub TampilRace()

        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = GetAllRace()

        DataGridView2.ReadOnly = True
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.MultiSelect = False

        If DataGridView2.Columns.Contains("id") Then
            DataGridView2.Columns("id").Visible = False
        End If

        If DataGridView2.Columns.Contains("namaRace") Then
            DataGridView2.Columns("namaRace").HeaderText = "Nama Race"
        End If

        If DataGridView2.Columns.Contains("lokasi") Then
            DataGridView2.Columns("lokasi").HeaderText = "Lokasi"
        End If

        If DataGridView2.Columns.Contains("tanggal") Then
            DataGridView2.Columns("tanggal").HeaderText = "Tanggal"
        End If

        If DataGridView2.Columns.Contains("putaran") Then
            DataGridView2.Columns("putaran").HeaderText = "Putaran"
        End If

    End Sub

    Private Sub BersihForm()

        selectedId = 0

        txtNamaRace.Clear()
        txtLokasi.Clear()
        txtPutaran.Clear()

        dtpTanggal.Value = Date.Today

        btnSimpanRace.Enabled = True
        btnUbahRace.Enabled = False
        btnHapusRace.Enabled = False

        txtNamaRace.Focus()

    End Sub

    Private Sub btnSimpanRace_Click(sender As Object, e As EventArgs) Handles btnSimpanRace.Click

        If selectedId <> 0 Then
            MessageBox.Show(
            "Anda sedang memilih data untuk diubah." &
            Environment.NewLine &
            "Gunakan tombol Ubah atau klik Batal terlebih dahulu.")
            Exit Sub
        End If

        If txtNamaRace.Text.Trim = "" Then
            MessageBox.Show("Nama race wajib diisi.")
            Exit Sub
        End If

        If SimpanRace(
        txtNamaRace.Text.Trim,
        txtLokasi.Text.Trim,
        dtpTanggal.Value.ToString("yyyy-MM-dd"),
        CInt(txtPutaran.Text.Trim)) Then

            MessageBox.Show("Data race berhasil disimpan.")

            TampilRace()
            BersihForm()

        End If

    End Sub

    Private Sub btnUbahRace_Click(sender As Object, e As EventArgs) Handles btnUbahRace.Click

        If selectedId = 0 Then
            MessageBox.Show("Pilih data yang ingin diubah.")
            Exit Sub
        End If

        If UbahRace(
            selectedId,
            txtNamaRace.Text.Trim,
            txtLokasi.Text.Trim,
            dtpTanggal.Value.ToString("yyyy-MM-dd"),
            txtPutaran.Text.Trim) Then

            MessageBox.Show("Data race berhasil diubah.")

            TampilRace()
            BersihForm()

        End If

    End Sub

    Private Sub btnHapusRace_Click(sender As Object, e As EventArgs) Handles btnHapusRace.Click

        If selectedId = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus.")
            Exit Sub
        End If

        Dim hasil As DialogResult =
            MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            If HapusRace(selectedId) Then

                MessageBox.Show("Data race berhasil dihapus.")

                TampilRace()
                BersihForm()

            End If

        End If

    End Sub

    Private Sub btnBatalRace_Click(sender As Object, e As EventArgs) Handles btnBatalRace.Click
        BersihForm()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object,
                                        e As DataGridViewCellEventArgs) _
                                        Handles DataGridView2.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

        selectedId = CInt(row.Cells("id").Value)

        txtNamaRace.Text = row.Cells("namaRace").Value.ToString()
        txtLokasi.Text = row.Cells("lokasi").Value.ToString()

        dtpTanggal.Value =
            Convert.ToDateTime(row.Cells("tanggal").Value)

        txtPutaran.Text =
            row.Cells("putaran").Value.ToString()

        btnSimpanRace.Enabled = False
        btnUbahRace.Enabled = True
        btnHapusRace.Enabled = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object,
                                     e As EventArgs) _
                                     Handles TextBox1.TextChanged

        Dim keyword As String = TextBox1.Text.Trim

        If keyword = "" Then

            TampilRace()

        Else

            DataGridView2.DataSource =
                SearchRace(keyword)

            If DataGridView2.Columns.Contains("id") Then
                DataGridView2.Columns("id").Visible = False
            End If

        End If

    End Sub

    Private Sub txtNamaRace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaRace.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtLokasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLokasi.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtPutaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPutaran.KeyPress
        HanyaAngka(e)
    End Sub

End Class