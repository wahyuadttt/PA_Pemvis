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

            dgvHasilRace.ReadOnly = True

            If dgvHasilRace.Columns.Contains("id") Then
                dgvHasilRace.Columns("id").Visible = False
            End If

        End If

    End Sub

End Class