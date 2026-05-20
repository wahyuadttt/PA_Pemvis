Public Class UC_TimUser

    Private Sub UC_TimUser_Load(sender As Object,
                           e As EventArgs) _
                           Handles MyBase.Load

        TampilTim()

    End Sub

    Private Sub TampilTim()

        dgvTim.DataSource = Nothing
        dgvTim.DataSource = GetAllTim()

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

        ' =========================
        ' KOLOM LOGO
        ' =========================

        If Not dgvTim.Columns.Contains("LogoPreview") Then

            Dim imgCol As New DataGridViewImageColumn()

            imgCol.Name = "LogoPreview"
            imgCol.HeaderText = "Logo"
            imgCol.ImageLayout =
            DataGridViewImageCellLayout.Zoom

            dgvTim.Columns.Add(imgCol)

        End If

        dgvTim.Columns("LogoPreview").Width = 100

        For Each row As DataGridViewRow In dgvTim.Rows

            If Not row.IsNewRow Then

                Dim path As String =
                row.Cells("logo").Value.ToString()

                If IO.File.Exists(path) Then

                    Using img As Image =
                    Image.FromFile(path)

                        row.Cells("LogoPreview").Value =
                        New Bitmap(img)

                    End Using

                End If

            End If

        Next

    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object,
                                         e As EventArgs) _
                                         Handles txtSearchTim.TextChanged

        If txtSearchTim.Text.Trim = "" Then

            TampilTim()

        Else

            dgvTim.DataSource =
                SearchTim(txtSearchTim.Text.Trim)

            If dgvTim.Columns.Contains("id") Then
                dgvTim.Columns("id").Visible = False
            End If

        End If

    End Sub

End Class