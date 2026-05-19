Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class UC_HasilRaceAdmin

    Private selectedIdHasil As Integer = -1

    Private Sub UC_HasilRaceAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MuatComboBoxRace()
        MuatComboBoxPembalap()

        If cbRaceHasil.Items.Count > 0 Then
            cbRaceHasil.SelectedIndex = 0
        End If

        nudPosisi.Minimum = 1
        nudPosisi.Maximum = 20
        nudPosisi.Value = 1

        TampilHasil()
        UpdatePoin()

    End Sub

    Private Sub MuatComboBoxRace()

        Dim dtRace As DataTable = GetAllRace()

        cbRaceHasil.DataSource = dtRace.Copy()
        cbRaceHasil.DisplayMember = "namaRace"
        cbRaceHasil.ValueMember = "id"

    End Sub

    Private Sub MuatComboBoxPembalap()

        cbPembalapHasil.DataSource = GetPembalapUntukComboBox()
        cbPembalapHasil.DisplayMember = "nama"
        cbPembalapHasil.ValueMember = "id"

    End Sub

    Private Sub TampilHasil()

        If cbRaceHasil.SelectedValue IsNot Nothing AndAlso
           IsNumeric(cbRaceHasil.SelectedValue) Then

            dgvHasilRace.DataSource =
                GetHasilRaceByRace(CInt(cbRaceHasil.SelectedValue))

        End If

        If dgvHasilRace.Columns.Contains("id") Then
            dgvHasilRace.Columns("id").Visible = False
        End If

        If dgvHasilRace.Columns.Contains("idRace") Then
            dgvHasilRace.Columns("idRace").Visible = False
        End If

        If dgvHasilRace.Columns.Contains("idPembalap") Then
            dgvHasilRace.Columns("idPembalap").Visible = False
        End If

    End Sub

    Private Function HitungPoin(posisi As Integer,
                                fastestLap As Boolean) As Integer

        Dim poin As Integer = 0

        Select Case posisi
            Case 1 : poin = 25
            Case 2 : poin = 18
            Case 3 : poin = 15
            Case 4 : poin = 12
            Case 5 : poin = 10
            Case 6 : poin = 8
            Case 7 : poin = 6
            Case 8 : poin = 4
            Case 9 : poin = 2
            Case 10 : poin = 1
        End Select

        If fastestLap And posisi <= 10 Then
            poin += 1
        End If

        Return poin

    End Function

    Private Sub UpdatePoin()

        Dim posisi As Integer = CInt(nudPosisi.Value)

        txtPoinHasil.Text =
            HitungPoin(posisi,
                       chkFastestLap.Checked).ToString()

    End Sub

    Private Sub nudPosisi_ValueChanged(sender As Object,
                                       e As EventArgs) _
                                       Handles nudPosisi.ValueChanged

        UpdatePoin()

    End Sub

    Private Sub chkFastestLap_CheckedChanged(sender As Object,
                                             e As EventArgs) _
                                             Handles chkFastestLap.CheckedChanged

        UpdatePoin()

    End Sub

    Private Sub cbRaceHasil_SelectedIndexChanged(sender As Object,
                                                 e As EventArgs) _
                                                 Handles cbRaceHasil.SelectedIndexChanged

        TampilHasil()

    End Sub

    Private Sub cbPembalapHasil_SelectionChangeCommitted(
        sender As Object,
        e As EventArgs) _
        Handles cbPembalapHasil.SelectionChangeCommitted

        txtTimHasil.Text =
            GetNamaTimByPembalap(
                CInt(cbPembalapHasil.SelectedValue))

    End Sub

    Private Sub btnSimpanHasil_Click(sender As Object,
                                     e As EventArgs) _
                                     Handles btnSimpanHasil.Click

        Dim posisi As Integer = CInt(nudPosisi.Value)

        Dim poin As Integer =
            HitungPoin(posisi, chkFastestLap.Checked)

        If SimpanHasilRace(
            CInt(cbRaceHasil.SelectedValue),
            CInt(cbPembalapHasil.SelectedValue),
            posisi,
            txtGap.Text,
            cbStatusFinish.Text,
            chkFastestLap.Checked,
            poin) Then

            MessageBox.Show("Berhasil disimpan")

            TampilHasil()
            KosongHasil()

        End If

    End Sub

    Private Sub btnUbahHasil_Click(sender As Object,
                                   e As EventArgs) _
                                   Handles btnUbahHasil.Click

        If selectedIdHasil = -1 Then
            MessageBox.Show("Pilih data")
            Exit Sub
        End If

        Dim posisi As Integer = CInt(nudPosisi.Value)

        Dim poin As Integer =
            HitungPoin(posisi, chkFastestLap.Checked)

        If UbahHasilRace(
            selectedIdHasil,
            CInt(cbRaceHasil.SelectedValue),
            CInt(cbPembalapHasil.SelectedValue),
            posisi,
            txtGap.Text,
            cbStatusFinish.Text,
            chkFastestLap.Checked,
            poin) Then

            MessageBox.Show("Data berhasil diubah")

            TampilHasil()
            KosongHasil()

        End If

    End Sub

    Private Sub btnHapusHasil_Click(sender As Object,
                                    e As EventArgs) _
                                    Handles btnHapusHasil.Click

        If selectedIdHasil = -1 Then
            MessageBox.Show("Pilih data")
            Exit Sub
        End If

        If HapusHasilRace(selectedIdHasil) Then

            MessageBox.Show("Data berhasil dihapus")

            TampilHasil()
            KosongHasil()

        End If

    End Sub

    Private Sub dgvHasilRace_CellClick(sender As Object,
                                       e As DataGridViewCellEventArgs) _
                                       Handles dgvHasilRace.CellClick

        If e.RowIndex >= 0 Then

            Dim row = dgvHasilRace.Rows(e.RowIndex)

            selectedIdHasil =
                CInt(row.Cells("id").Value)

            cbPembalapHasil.Text =
                row.Cells("pembalap").Value.ToString()

            txtTimHasil.Text =
                row.Cells("namaTim").Value.ToString()

            nudPosisi.Value =
                CDec(row.Cells("posisiFinish").Value)

            txtGap.Text =
                row.Cells("gap").Value.ToString()

            cbStatusFinish.Text =
                row.Cells("statusFinish").Value.ToString()

            chkFastestLap.Checked =
                CBool(row.Cells("fastestLap").Value)

            txtPoinHasil.Text =
                row.Cells("poin").Value.ToString()

        End If

    End Sub

    Private Sub KosongHasil()

        txtGap.Clear()
        txtTimHasil.Clear()

        chkFastestLap.Checked = False

        nudPosisi.Value = 1

        UpdatePoin()

        selectedIdHasil = -1

    End Sub

    Private Sub btnPrintHasil_Click(sender As Object, e As EventArgs) Handles btnPrintHasil.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 10)

        Dim y As Integer = 50

        e.Graphics.DrawString(
            "HASIL RACE FORMULA 1",
            fontJudul,
            Brushes.Black,
            220,
            y)

        y += 50

        For Each row As DataGridViewRow In dgvHasilRace.Rows

            If Not row.IsNewRow Then

                Dim teks As String =
                    "Pembalap : " & row.Cells("pembalap").Value.ToString() &
                    " | Tim : " & row.Cells("namaTim").Value.ToString() &
                    " | Posisi : " & row.Cells("posisiFinish").Value.ToString() &
                    " | Poin : " & row.Cells("poin").Value.ToString()

                e.Graphics.DrawString(
                    teks,
                    fontIsi,
                    Brushes.Black,
                    50,
                    y)

                y += 30

            End If

        Next

    End Sub

End Class