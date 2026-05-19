Public Class UC_TimUser

    Private Sub UC_TimUser_Load(sender As Object,
                           e As EventArgs) _
                           Handles MyBase.Load

        TampilTim()

    End Sub

    Private Sub TampilTim()

        dgvTim.DataSource = Nothing
        dgvTim.DataSource = GetAllTim()

        dgvTim.ReadOnly = True

        If dgvTim.Columns.Contains("id") Then
            dgvTim.Columns("id").Visible = False
        End If

        If dgvTim.Columns.Contains("namaTim") Then
            dgvTim.Columns("namaTim").HeaderText =
                "Nama Tim"
        End If

        If dgvTim.Columns.Contains("negara") Then
            dgvTim.Columns("negara").HeaderText =
                "Negara"
        End If

        If dgvTim.Columns.Contains("mesin") Then
            dgvTim.Columns("mesin").HeaderText =
                "Mesin"
        End If

        If dgvTim.Columns.Contains("chasis") Then
            dgvTim.Columns("chasis").HeaderText =
                "Chasis"
        End If

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