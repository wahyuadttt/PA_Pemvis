Imports MySqlConnector

Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiFoto(ep As ErrorProvider, pb As PictureBox, pesan As String) As Boolean
        If pb.Image Is Nothing Then
            ep.SetError(pb, pesan)
            Return False
        Else
            ep.SetError(pb, "")
            Return True
        End If
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function CekPosisiSudahAda(idRace As Integer, posisi As Integer, Optional excludeId As Integer = -1) As Boolean
        Dim query As String

        If excludeId = -1 Then
            query = "SELECT COUNT(*) FROM TabelHasilRace WHERE idRace = @idRace AND posisiFinish = @posisi"
        Else
            query = "SELECT COUNT(*) FROM TabelHasilRace WHERE idRace = @idRace AND posisiFinish = @posisi AND id <> @excludeId"
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idRace", idRace)
                cmd.Parameters.AddWithValue("@posisi", posisi)
                If excludeId <> -1 Then
                    cmd.Parameters.AddWithValue("@excludeId", excludeId)
                End If
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function CekFastestLapSudahAda(idRace As Integer, Optional excludeId As Integer = -1) As Boolean
        Dim query As String

        If excludeId = -1 Then
            query = "SELECT COUNT(*) FROM TabelHasilRace WHERE idRace = @idRace AND fastestLap = 1"
        Else
            query = "SELECT COUNT(*) FROM TabelHasilRace WHERE idRace = @idRace AND fastestLap = 1 AND id <> @excludeId"
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idRace", idRace)
                If excludeId <> -1 Then
                    cmd.Parameters.AddWithValue("@excludeId", excludeId)
                End If
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

End Module