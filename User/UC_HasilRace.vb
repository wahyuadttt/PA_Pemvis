Public Class UC_HasilRace

    Private Sub UC_HasilRace_Load(sender As Object,
                                 e As EventArgs) _
                                 Handles MyBase.Load

        MuatComboBoxRace()

    End Sub

    Private Sub MuatComboBoxRace()

        Dim dtRace As DataTable =
            GetAllRace()

        cbPilihRace.DataSource = dtRace
        cbPilihRace.DisplayMember = "namaRace"
        cbPilihRace.ValueMember = "id"

        If dtRace.Rows.Count > 0 Then
            cbPilihRace.SelectedIndex = 0
        End If

    End Sub

    Private Sub cbPilihRace_SelectedIndexChanged(sender As Object,
                                                 e As EventArgs) _
                                                 Handles cbPilihRace.SelectedIndexChanged

        If TypeOf cbPilihRace.SelectedValue Is Integer Then

            dgvHasilRace.DataSource =
                GetHasilRaceByRace(
                    CInt(cbPilihRace.SelectedValue))

            dgvHasilRace.AllowUserToAddRows = False
            dgvHasilRace.ReadOnly = True

            If dgvHasilRace.Columns.Contains("id") Then
                dgvHasilRace.Columns("id").Visible = False
            End If

            If dgvHasilRace.Columns.Contains("posisiFinish") Then
                dgvHasilRace.Columns("posisiFinish").HeaderText = "Posisi"
            End If

            If dgvHasilRace.Columns.Contains("pembalap") Then
                dgvHasilRace.Columns("pembalap").HeaderText = "Nama"
            End If

            If dgvHasilRace.Columns.Contains("namaTim") Then
                dgvHasilRace.Columns("namaTim").HeaderText = "Tim"
            End If

            If dgvHasilRace.Columns.Contains("gap") Then
                dgvHasilRace.Columns("gap").HeaderText = "Gap"
            End If

            If dgvHasilRace.Columns.Contains("statusFinish") Then
                dgvHasilRace.Columns("statusFinish").HeaderText = "Status"
            End If

            If dgvHasilRace.Columns.Contains("fastestLap") Then
                dgvHasilRace.Columns("fastestLap").HeaderText = "Fastest Lap"
            End If

            If dgvHasilRace.Columns.Contains("poin") Then
                dgvHasilRace.Columns("poin").HeaderText = "Poin"
            End If

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object,
                                       e As EventArgs) _
                                       Handles txtSearch.TextChanged

        If cbPilihRace.SelectedValue Is Nothing Then Exit Sub

        Dim idRace As Integer =
            CInt(cbPilihRace.SelectedValue)

        Dim keyword As String =
            txtSearch.Text.Trim()

        If keyword = "" Then

            dgvHasilRace.DataSource =
                GetHasilRaceByRace(idRace)

        Else

            dgvHasilRace.DataSource =
                SearchHasilRace(keyword, idRace)

        End If

    End Sub

End Class