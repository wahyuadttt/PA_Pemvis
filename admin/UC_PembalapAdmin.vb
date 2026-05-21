Imports System.Drawing.Printing

Public Class UC_PembalapAdmin

    Private selectedIdPembalap As Integer = -1
    Private dtTimCombo As DataTable
    Private fotoPath As String = ""

    Private Sub UC_PembalapAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatComboBoxTim()
        TampilPembalap()

        cbTim.SelectedIndex = -1

        btnUbahPembalap.Enabled = False
        btnHapusPembalap.Enabled = False
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

    Private Sub TampilPembalap(Optional keyword As String = "")

        dgvPembalap.DataSource = Nothing

        If keyword = "" Then
            dgvPembalap.DataSource = GetAllPembalap()
        Else
            dgvPembalap.DataSource = SearchPembalap(keyword)
        End If

        dgvPembalap.RowTemplate.Height = 80

        If dgvPembalap.Columns.Contains("id") Then
            dgvPembalap.Columns("id").Visible = False
        End If

        If dgvPembalap.Columns.Contains("idTim") Then
            dgvPembalap.Columns("idTim").Visible = False
        End If

        If dgvPembalap.Columns.Contains("foto") Then
            dgvPembalap.Columns("foto").Visible = False
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

    Private Sub dgvPembalap_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPembalap.DataBindingComplete
        If Not dgvPembalap.Columns.Contains("FotoPreview") Then
            Dim imgCol As New DataGridViewImageColumn()
            imgCol.Name = "FotoPreview"
            imgCol.HeaderText = "Foto"
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.Width = 100
            dgvPembalap.Columns.Add(imgCol)
        End If

        dgvPembalap.Columns("FotoPreview").DisplayIndex = dgvPembalap.Columns.Count - 1

        For Each row As DataGridViewRow In dgvPembalap.Rows
            If Not row.IsNewRow AndAlso dgvPembalap.Columns.Contains("foto") Then
                Dim val = row.Cells("foto").Value
                If val IsNot Nothing AndAlso Not DBNull.Value.Equals(val) Then
                    Dim path As String = val.ToString()
                    If IO.File.Exists(path) Then
                        Try
                            Using img As Image = Image.FromFile(path)
                                row.Cells("FotoPreview").Value = New Bitmap(img)
                            End Using
                        Catch ex As Exception
                        End Try
                    End If
                End If
            End If
        Next
    End Sub

    Private Function ValidasiPembalap() As Boolean

        ErrorProvider1.Clear()

        Dim namaValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNamaPembalap, "Inputan tidak boleh kosong")

        Dim negaraValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNegaraPembalap, "Inputan tidak boleh kosong")

        Dim nomorValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtNomor, "Inputan tidak boleh kosong")

        Dim fotoValid As Boolean =
            ValidasiFoto(ErrorProvider1, picFotoPembalap, "Foto harus dipilih")

        Dim timValid As Boolean =
            ValidasiComboBox(ErrorProvider1, cbTim, "Tim harus dipilih")

        Return namaValid And negaraValid And nomorValid And fotoValid And timValid

    End Function

    Private Sub KosongPembalap()

        txtNamaPembalap.Clear()
        txtNegaraPembalap.Clear()
        txtNomor.Clear()
        txtSearchPembalap.Clear()

        picFotoPembalap.Image = Nothing

        fotoPath = ""
        selectedIdPembalap = -1

        btnSimpanPembalap.Enabled = True
        btnUbahPembalap.Enabled = False
        btnHapusPembalap.Enabled = False

        If cbTim.Items.Count > 0 Then
            cbTim.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnPilihFoto_Click(sender As Object, e As EventArgs) Handles btnPilihFoto.Click

        Dim ofd As New OpenFileDialog

        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then

            fotoPath = ofd.FileName

            picFotoPembalap.Image =
                Image.FromFile(fotoPath)

            picFotoPembalap.SizeMode =
                PictureBoxSizeMode.StretchImage

        End If

    End Sub

    Private Sub btnSimpanPembalap_Click(sender As Object, e As EventArgs) Handles btnSimpanPembalap.Click

        If Not ValidasiPembalap() Then Exit Sub

        If SimpanPembalap(
            txtNamaPembalap.Text.Trim(),
            txtNegaraPembalap.Text.Trim(),
            CInt(txtNomor.Text.Trim()),
            fotoPath,
            CInt(cbTim.SelectedValue)) Then

            MessageBox.Show("Data berhasil disimpan")

            TampilPembalap()
            KosongPembalap()

        End If

    End Sub

    Private Sub btnUbahPembalap_Click(sender As Object, e As EventArgs) Handles btnUbahPembalap.Click

        If Not ValidasiPembalap() Then Exit Sub

        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan diubah")
            Exit Sub
        End If

        If Not ValidasiPembalap() Then Exit Sub

        If UbahPembalap(
            selectedIdPembalap,
            txtNamaPembalap.Text.Trim(),
            txtNegaraPembalap.Text.Trim(),
            CInt(txtNomor.Text.Trim()),
            fotoPath,
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

            fotoPath = row.Cells("foto").Value.ToString()

            If fotoPath <> "" AndAlso IO.File.Exists(fotoPath) Then

                picFotoPembalap.Image =
                Image.FromFile(fotoPath)

                picFotoPembalap.SizeMode =
                PictureBoxSizeMode.StretchImage

            Else
                picFotoPembalap.Image = Nothing
            End If

            btnSimpanPembalap.Enabled = False
            btnUbahPembalap.Enabled = True
            btnHapusPembalap.Enabled = True

        End If

    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged

        TampilPembalap(txtSearchPembalap.Text.Trim())

    End Sub

    Private Sub btnPrintPembalap_Click(sender As Object, e As EventArgs) Handles btnPrintPembalap.Click

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
        "DATA PEMBALAP FORMULA 1",
        fontJudul,
        brush,
        marginLeft,
        y)

        y += 40

        e.Graphics.DrawString("Nama", fontIsi, brush, marginLeft, y)
        e.Graphics.DrawString("Negara", fontIsi, brush, marginLeft + 200, y)
        e.Graphics.DrawString("Nomor", fontIsi, brush, marginLeft + 400, y)
        e.Graphics.DrawString("Tim", fontIsi, brush, marginLeft + 520, y)

        y += 25

        e.Graphics.DrawLine(
        Pens.Black,
        marginLeft,
        y,
        marginLeft + 700,
        y)

        y += 10

        For Each row As DataGridViewRow In dgvPembalap.Rows

            If Not row.IsNewRow Then

                e.Graphics.DrawString(
                row.Cells("nama").Value.ToString(),
                fontIsi,
                brush,
                marginLeft,
                y)

                e.Graphics.DrawString(
                row.Cells("negara").Value.ToString(),
                fontIsi,
                brush,
                marginLeft + 200,
                y)

                e.Graphics.DrawString(
                row.Cells("nomor").Value.ToString(),
                fontIsi,
                brush,
                marginLeft + 400,
                y)

                e.Graphics.DrawString(
                row.Cells("tim").Value.ToString(),
                fontIsi,
                brush,
                marginLeft + 520,
                y)

                y += 25

            End If

        Next

    End Sub

    Private Sub txtNamaPembalap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPembalap.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNegaraPembalap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNegaraPembalap.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        HanyaAngka(e)
    End Sub

End Class