Public Class UC_PembalapUser

    Private Sub UC_PembalapUser_Load(sender As Object,
                                e As EventArgs) _
                                Handles MyBase.Load

        TampilPembalap()

    End Sub

    Private Sub TampilPembalap()

        dgvPembalap.DataSource = Nothing
        dgvPembalap.DataSource = GetAllPembalap()

        dgvPembalap.ReadOnly = True

        If dgvPembalap.Columns.Contains("id") Then
            dgvPembalap.Columns("id").Visible = False
        End If

        If dgvPembalap.Columns.Contains("idTim") Then
            dgvPembalap.Columns("idTim").Visible = False
        End If

        If dgvPembalap.Columns.Contains("nama") Then
            dgvPembalap.Columns("nama").HeaderText =
                "Nama Pembalap"
        End If

        If dgvPembalap.Columns.Contains("negara") Then
            dgvPembalap.Columns("negara").HeaderText =
                "Negara"
        End If

        If dgvPembalap.Columns.Contains("nomor") Then
            dgvPembalap.Columns("nomor").HeaderText =
                "Nomor"
        End If

        If dgvPembalap.Columns.Contains("tim") Then
            dgvPembalap.Columns("tim").HeaderText =
                "Tim"
        End If

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