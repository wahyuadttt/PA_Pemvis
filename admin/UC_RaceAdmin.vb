Imports System.Drawing.Printing

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

    Private Function ValidasiRace() As Boolean

        ErrorProvider1.Clear()

        Dim namaValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNamaRace, "Tidak boleh kosong")

        Dim lokasiValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtLokasi, "Tidak boleh kosong")

        Dim putaranValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtPutaran, "Tidak boleh kosong")

        Return namaValid And lokasiValid And putaranValid

    End Function

    Private Sub btnSimpanRace_Click(sender As Object, e As EventArgs) Handles btnSimpanRace.Click

        If Not ValidasiRace() Then Exit Sub

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

        If Not ValidasiRace() Then Exit Sub

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

    Private Sub btnPrintRace_Click(sender As Object, e As EventArgs) Handles btnPrintRace.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)

        Dim marginLeft As Integer = e.MarginBounds.Left
        Dim y As Integer = 50

        e.Graphics.DrawString(
            "DATA RACE",
            fontHeader,
            brush,
            marginLeft,
            y)

        y += 40

        e.Graphics.DrawString("Nama Race", fontIsi, brush, marginLeft, y)
        e.Graphics.DrawString("Lokasi", fontIsi, brush, marginLeft + 200, y)
        e.Graphics.DrawString("Tanggal", fontIsi, brush, marginLeft + 400, y)
        e.Graphics.DrawString("Putaran", fontIsi, brush, marginLeft + 550, y)

        y += 25

        e.Graphics.DrawLine(Pens.Black, marginLeft, y, marginLeft + 650, y)

        y += 10

        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                e.Graphics.DrawString(
                    row.Cells("namaRace").Value.ToString(),
                    fontIsi,
                    brush,
                    marginLeft,
                    y)

                e.Graphics.DrawString(
                    row.Cells("lokasi").Value.ToString(),
                    fontIsi,
                    brush,
                    marginLeft + 200,
                    y)

                e.Graphics.DrawString(
                    Convert.ToDateTime(
                        row.Cells("tanggal").Value).ToString("dd/MM/yyyy"),
                    fontIsi,
                    brush,
                    marginLeft + 400,
                    y)

                e.Graphics.DrawString(
                    row.Cells("putaran").Value.ToString(),
                    fontIsi,
                    brush,
                    marginLeft + 550,
                    y)

                y += 25
            End If
        Next
    End Sub

End Class