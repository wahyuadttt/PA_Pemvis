Public Class UC_Klasemen

    Private Sub UC_Klasemen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKlasemen.BringToFront()
        TampilKlasemenPembalap()
    End Sub

    Private Sub TampilKlasemenPembalap()
        dgvKlasemen.DataSource = Nothing
        dgvKlasemen.DataSource = GetKlasemenPembalap()

        If dgvKlasemen.Columns.Contains("nama") Then
            dgvKlasemen.Columns("nama").HeaderText = "Pembalap"
        End If

        If dgvKlasemen.Columns.Contains("namaTim") Then
            dgvKlasemen.Columns("namaTim").HeaderText = "Tim"
        End If

        If dgvKlasemen.Columns.Contains("totalPoin") Then
            dgvKlasemen.Columns("totalPoin").HeaderText = "Total Poin"
        End If

        dgvKlasemen.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill
    End Sub

End Class