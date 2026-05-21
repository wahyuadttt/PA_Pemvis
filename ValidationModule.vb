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

End Module