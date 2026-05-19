Public Class LoginAdmin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ErrorProvider1.Clear()

        Dim usernameValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtUsername, "Username tidak boleh kosong")

        Dim passwordValid As Boolean =
            ValidasiTextBox(ErrorProvider1, txtPassword, "Password tidak boleh kosong")

        If Not usernameValid OrElse Not passwordValid Then Exit Sub

        If txtUsername.Text.Trim() = "admin" AndAlso txtPassword.Text.Trim() = "admin" Then

            IsAdmin = True
<<<<<<< HEAD
            DashboardAdmin.Show()
=======
            FormPembalap.Show()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
            Me.Hide()

        Else
            MessageBox.Show(
                "Username atau password salah!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtUsername.Clear()
        txtPassword.Clear()
        ErrorProvider1.Clear()

        IsAdmin = False
<<<<<<< HEAD
        DashboardUser.Show()
=======
        FormMenu.Show()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        Me.Hide()
    End Sub

    Private Sub LoginAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IsAdmin = False
<<<<<<< HEAD
        DashboardUser.Show()
=======
        FormPembalap.Show()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
    End Sub

    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblLockIcon_Click(sender As Object, e As EventArgs) Handles lblLockIcon.Click

    End Sub

    Private Sub pnlBody_Paint(sender As Object, e As PaintEventArgs) Handles pnlBody.Paint

    End Sub

<<<<<<< HEAD
End Class
=======
End Class
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
