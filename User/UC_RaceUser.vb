Public Class UC_RaceUser

    Private Sub UC_RaceUser_Load(sender As Object,
                            e As EventArgs) _
                            Handles MyBase.Load

        TampilRace()

    End Sub

    Private Sub TampilRace()

        dgvRace.DataSource = Nothing
        dgvRace.DataSource = GetAllRace()

        dgvRace.ReadOnly = True

        If dgvRace.Columns.Contains("id") Then
            dgvRace.Columns("id").Visible = False
        End If

        If dgvRace.Columns.Contains("namaRace") Then
            dgvRace.Columns("namaRace").HeaderText =
                "Nama Race"
        End If

        If dgvRace.Columns.Contains("lokasi") Then
            dgvRace.Columns("lokasi").HeaderText =
                "Lokasi"
        End If

        If dgvRace.Columns.Contains("tanggal") Then
            dgvRace.Columns("tanggal").HeaderText =
                "Tanggal"
        End If

        If dgvRace.Columns.Contains("putaran") Then
            dgvRace.Columns("putaran").HeaderText =
                "Putaran"
        End If

    End Sub

    Private Sub txtSearchRace_TextChanged(sender As Object,
                                          e As EventArgs) _
                                          Handles txtSearchRace.TextChanged

        If txtSearchRace.Text.Trim = "" Then

            TampilRace()

        Else

            dgvRace.DataSource =
                SearchRace(txtSearchRace.Text.Trim)

            If dgvRace.Columns.Contains("id") Then
                dgvRace.Columns("id").Visible = False
            End If

        End If

    End Sub

End Class