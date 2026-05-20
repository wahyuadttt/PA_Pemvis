Public Class UC_PembalapUser

    Private Sub UC_PembalapUser_Load(sender As Object,
                                e As EventArgs) _
                                Handles MyBase.Load

        TampilPembalap()

    End Sub

    Private Sub TampilPembalap()

        dgvPembalap.DataSource = Nothing
        dgvPembalap.DataSource = GetAllPembalap()

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

        ' =========================
        ' KOLOM FOTO
        ' =========================

        If Not dgvPembalap.Columns.Contains("FotoPreview") Then

            Dim imgCol As New DataGridViewImageColumn()

            imgCol.Name = "FotoPreview"
            imgCol.HeaderText = "Foto"
            imgCol.ImageLayout =
            DataGridViewImageCellLayout.Zoom

            dgvPembalap.Columns.Add(imgCol)

        End If

        dgvPembalap.Columns("FotoPreview").Width = 100

        For Each row As DataGridViewRow In dgvPembalap.Rows

            If Not row.IsNewRow Then

                Dim path As String =
                row.Cells("foto").Value.ToString()

                If IO.File.Exists(path) Then

                    Using img As Image =
                    Image.FromFile(path)

                        row.Cells("FotoPreview").Value =
                        New Bitmap(img)

                    End Using

                End If

            End If

        Next

    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object,
                                              e As EventArgs) _
                                              Handles txtSearchPembalap.TextChanged

        If txtSearchPembalap.Text.Trim = "" Then

            TampilPembalap()

        Else

            dgvPembalap.DataSource =
                SearchPembalap(txtSearchPembalap.Text.Trim)

            If dgvPembalap.Columns.Contains("id") Then
                dgvPembalap.Columns("id").Visible = False
            End If

            If dgvPembalap.Columns.Contains("idTim") Then
                dgvPembalap.Columns("idTim").Visible = False
            End If

        End If

    End Sub

End Class