Imports System.Drawing.Printing

Public Class UC_TimAdmin

    Private selectedIdTim As Integer = -1
    Private logoPath As String = ""

    Private Sub UC_TimAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilTim()
        KosongTim()

    End Sub

    Private Sub TampilTim()

        dgvTim.DataSource = Nothing
        dgvTim.DataSource = GetAllTim()

        If dgvTim.Columns.Contains("id") Then
            dgvTim.Columns("id").Visible = False
        End If

        If dgvTim.Columns.Contains("logo") Then
            dgvTim.Columns("logo").Visible = False
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

        picLogoTim.Image = Nothing

        logoPath = ""
        selectedIdTim = -1

        btnSimpanTim.Enabled = True
        btnUbahTim.Enabled = False

    End Sub

    Private Sub btnPilihLogo_Click(sender As Object, e As EventArgs) Handles btnPilihLogo.Click

        Dim ofd As New OpenFileDialog

        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then

            logoPath = ofd.FileName

            picLogoTim.Image =
                Image.FromFile(logoPath)

            picLogoTim.SizeMode =
                PictureBoxSizeMode.StretchImage

        End If

    End Sub

    Private Sub btnSimpanTim_Click(sender As Object, e As EventArgs) Handles btnSimpanTim.Click

        If Not ValidasiTim() Then Exit Sub

        If SimpanTim(
            txtNamaTim.Text.Trim(),
            txtNegaraTim.Text.Trim(),
            txtMesin.Text.Trim(),
            txtChasis.Text.Trim(),
            logoPath) Then

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
            txtChasis.Text.Trim(),
            logoPath) Then

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

            logoPath = row.Cells("logo").Value.ToString()

            btnSimpanTim.Enabled = False
            btnUbahTim.Enabled = True

            If logoPath <> "" AndAlso IO.File.Exists(logoPath) Then

                picLogoTim.Image =
                    Image.FromFile(logoPath)

                picLogoTim.SizeMode =
                    PictureBoxSizeMode.StretchImage

            Else
                picLogoTim.Image = Nothing
            End If

        End If

    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged

        If txtSearchTim.Text.Trim() = "" Then

            TampilTim()

        Else

            dgvTim.DataSource =
                SearchTim(txtSearchTim.Text.Trim())

        End If

    End Sub

    Private Sub btnPrintTim_Click(sender As Object, e As EventArgs) Handles btnPrintTim.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 10)

        Dim y As Integer = 50

        e.Graphics.DrawString(
            "DATA TIM FORMULA 1",
            fontJudul,
            Brushes.Black,
            240,
            y)

        y += 50

        For Each row As DataGridViewRow In dgvTim.Rows

            If Not row.IsNewRow Then

                Dim teks As String =
                    "Tim : " & row.Cells("namaTim").Value.ToString() &
                    " | Negara : " & row.Cells("negara").Value.ToString() &
                    " | Mesin : " & row.Cells("mesin").Value.ToString() &
                    " | Chasis : " & row.Cells("chasis").Value.ToString()

                e.Graphics.DrawString(
                    teks,
                    fontIsi,
                    Brushes.Black,
                    50,
                    y)

                y += 30

            End If

        Next

    End Sub

    Private Sub txtNamaTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaTim.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNegaraTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNegaraTim.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtMesin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMesin.KeyPress
        HanyaHuruf(e)
    End Sub


End Class