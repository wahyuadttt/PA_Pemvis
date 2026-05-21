Imports System.Drawing.Printing

Public Class UC_TimAdmin

    Private selectedIdTim As Integer = -1
    Private logoPath As String = ""

    Private Sub UC_TimAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilTim()
        KosongTim()

    End Sub

    Private Sub TampilTim(Optional keyword As String = "")

        dgvTim.DataSource = Nothing

        If keyword = "" Then
            dgvTim.DataSource = GetAllTim()
        Else
            dgvTim.DataSource = SearchTim(keyword)
        End If

        dgvTim.RowTemplate.Height = 80

        If dgvTim.Columns.Contains("id") Then
            dgvTim.Columns("id").Visible = False
        End If

        If dgvTim.Columns.Contains("logo") Then
            dgvTim.Columns("logo").Visible = False
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

    Private Sub dgvTim_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTim.DataBindingComplete
        If Not dgvTim.Columns.Contains("LogoPreview") Then
            Dim imgCol As New DataGridViewImageColumn()
            imgCol.Name = "LogoPreview"
            imgCol.HeaderText = "Logo"
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.Width = 100
            dgvTim.Columns.Add(imgCol)
        End If

        dgvTim.Columns("LogoPreview").DisplayIndex = dgvTim.Columns.Count - 1

        For Each row As DataGridViewRow In dgvTim.Rows
            If Not row.IsNewRow AndAlso dgvTim.Columns.Contains("logo") Then
                Dim val = row.Cells("logo").Value
                If val IsNot Nothing AndAlso Not DBNull.Value.Equals(val) Then
                    Dim path As String = val.ToString()
                    If IO.File.Exists(path) Then
                        Try
                            Using img As Image = Image.FromFile(path)
                                row.Cells("LogoPreview").Value = New Bitmap(img)
                            End Using
                        Catch ex As Exception
                        End Try
                    End If
                End If
            End If
        Next
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

        Dim fotoValid As Boolean =
            ValidasiFoto(ErrorProvider1, picLogoTim, "Foto harus dipilih")

        Return namaValid And negaraValid And mesinValid And chasisValid And fotoValid

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

        If Not ValidasiTim() Then Exit Sub

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

        TampilTim(txtSearchTim.Text.Trim())

    End Sub

    Private Sub btnPrintTim_Click(sender As Object, e As EventArgs) Handles btnPrintTim.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)

        Dim marginLeft As Integer = e.MarginBounds.Left
        Dim y As Integer = 50

        e.Graphics.DrawString(
        "DATA TIM FORMULA 1",
        fontJudul,
        brush,
        marginLeft,
        y)

        y += 40

        e.Graphics.DrawString("Nama Tim", fontIsi, brush, marginLeft, y)
        e.Graphics.DrawString("Negara", fontIsi, brush, marginLeft + 220, y)
        e.Graphics.DrawString("Mesin", fontIsi, brush, marginLeft + 420, y)
        e.Graphics.DrawString("Chasis", fontIsi, brush, marginLeft + 580, y)

        y += 25

        e.Graphics.DrawLine(
        Pens.Black,
        marginLeft,
        y,
        marginLeft + 750,
        y)

        y += 10

        For Each row As DataGridViewRow In dgvTim.Rows

            If Not row.IsNewRow Then

                e.Graphics.DrawString(
                row.Cells("namaTim").Value.ToString(),
                fontIsi,
                brush,
                marginLeft,
                y)

                e.Graphics.DrawString(
                row.Cells("negara").Value.ToString(),
                fontIsi,
                brush,
                marginLeft + 220,
                y)

                e.Graphics.DrawString(
                row.Cells("mesin").Value.ToString(),
                fontIsi,
                brush,
                marginLeft + 420,
                y)

                e.Graphics.DrawString(
                row.Cells("chasis").Value.ToString(),
                fontIsi,
                brush,
                marginLeft + 580,
                y)

                y += 25

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