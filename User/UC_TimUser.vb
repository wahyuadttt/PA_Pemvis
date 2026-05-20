Public Class UC_TimUser

    Private Sub UC_TimUser_Load(sender As Object,
                           e As EventArgs) _
                           Handles MyBase.Load

        TampilTim()

    End Sub

    Private Sub TampilTim(Optional keyword As String = "")

        dgvTim.DataSource = Nothing

        If keyword = "" Then
            dgvTim.DataSource = GetAllTim()
        Else
            dgvTim.DataSource = SearchTim(keyword)
        End If

        dgvTim.RowTemplate.Height = 80
        dgvTim.AllowUserToAddRows = False

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

    End Sub

    Private Sub dgvTim_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTim.DataBindingComplete
        If Not dgvTim.Columns.Contains("LogoPreview") Then
            Dim imgCol As New DataGridViewImageColumn()
            imgCol.Name = "LogoPreview"
            imgCol.HeaderText = "Logo"
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.Width = 100
            dgvTim.Columns.Add(imgCol)
        End If

        dgvTim.Columns("LogoPreview").DisplayIndex = dgvTim.Columns.Count - 1

        For Each row As DataGridViewRow In dgvTim.Rows
            If Not row.IsNewRow AndAlso dgvTim.Columns.Contains("logo") Then
                Dim val = row.Cells("logo").Value
                If val IsNot Nothing AndAlso Not DBNull.Value.Equals(val) Then
                    Dim path As String = val.ToString()
                    If IO.File.Exists(path) Then
                        Try
                            Using img As Image = Image.FromFile(path)
                                row.Cells("LogoPreview").Value = New Bitmap(img)
                            End Using
                        Catch ex As Exception
                        End Try
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object,
                                         e As EventArgs) _
                                         Handles txtSearchTim.TextChanged

        TampilTim(txtSearchTim.Text.Trim())

    End Sub

End Class