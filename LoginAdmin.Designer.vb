<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginAdmin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ErrorProvider1 = New ErrorProvider(components)
        pnlOuter = New Panel()
        pnlTopAccent = New Panel()
        pnlTitleBar = New Panel()
        lblFormTitle = New Label()
        lblFormSubtitle = New Label()
        pnlBody = New Panel()
        lblLockIcon = New Label()
        lblAdminTitle = New Label()
        lblAdminSub = New Label()
        pnlFieldArea = New Panel()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        pnlButtons = New Panel()
        btnLogin = New Button()
        btnBatal = New Button()
        lblFooter = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        pnlOuter.SuspendLayout()
        pnlTitleBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlFieldArea.SuspendLayout()
        pnlButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' pnlOuter
        ' 
        pnlOuter.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlOuter.Controls.Add(pnlTopAccent)
        pnlOuter.Controls.Add(pnlTitleBar)
        pnlOuter.Controls.Add(pnlBody)
        pnlOuter.Dock = DockStyle.Fill
        pnlOuter.Location = New Point(0, 0)
        pnlOuter.Name = "pnlOuter"
        pnlOuter.Size = New Size(459, 420)
        pnlOuter.TabIndex = 0
        ' 
        ' pnlTopAccent
        ' 
        pnlTopAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlTopAccent.Dock = DockStyle.Top
        pnlTopAccent.Location = New Point(0, 52)
        pnlTopAccent.Name = "pnlTopAccent"
        pnlTopAccent.Size = New Size(459, 4)
        pnlTopAccent.TabIndex = 0
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlTitleBar.Controls.Add(lblFormTitle)
        pnlTitleBar.Controls.Add(lblFormSubtitle)
        pnlTitleBar.Dock = DockStyle.Top
        pnlTitleBar.Location = New Point(0, 0)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(459, 52)
        pnlTitleBar.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.BackColor = Color.Transparent
        lblFormTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(16, 8)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(228, 25)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "AKSES ADMINISTRATOR"
        ' 
        ' lblFormSubtitle
        ' 
        lblFormSubtitle.AutoSize = True
        lblFormSubtitle.BackColor = Color.Transparent
        lblFormSubtitle.Font = New Font("Segoe UI", 8F)
        lblFormSubtitle.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(160))
        lblFormSubtitle.Location = New Point(18, 32)
        lblFormSubtitle.Name = "lblFormSubtitle"
        lblFormSubtitle.Size = New Size(298, 19)
        lblFormSubtitle.TabIndex = 1
        lblFormSubtitle.Text = "Masukkan kredensial admin untuk melanjutkan"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlBody.Controls.Add(lblLockIcon)
        pnlBody.Controls.Add(lblAdminTitle)
        pnlBody.Controls.Add(lblAdminSub)
        pnlBody.Controls.Add(pnlFieldArea)
        pnlBody.Controls.Add(pnlButtons)
        pnlBody.Controls.Add(lblFooter)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 0)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(32, 20, 32, 16)
        pnlBody.Size = New Size(459, 420)
        pnlBody.TabIndex = 2
        ' 
        ' lblLockIcon
        ' 
        lblLockIcon.AutoSize = True
        lblLockIcon.BackColor = Color.Transparent
        lblLockIcon.Font = New Font("Segoe UI Emoji", 28F)
        lblLockIcon.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblLockIcon.Location = New Point(11, 60)
        lblLockIcon.Name = "lblLockIcon"
        lblLockIcon.Size = New Size(92, 63)
        lblLockIcon.TabIndex = 0
        lblLockIcon.Text = "🔐"
        lblLockIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAdminTitle
        ' 
        lblAdminTitle.AutoSize = True
        lblAdminTitle.BackColor = Color.Transparent
        lblAdminTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblAdminTitle.ForeColor = Color.White
        lblAdminTitle.Location = New Point(120, 67)
        lblAdminTitle.Name = "lblAdminTitle"
        lblAdminTitle.Size = New Size(144, 30)
        lblAdminTitle.TabIndex = 1
        lblAdminTitle.Text = "Login Admin"
        ' 
        ' lblAdminSub
        ' 
        lblAdminSub.AutoSize = True
        lblAdminSub.BackColor = Color.Transparent
        lblAdminSub.Font = New Font("Segoe UI", 8.5F)
        lblAdminSub.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(140))
        lblAdminSub.Location = New Point(101, 93)
        lblAdminSub.Name = "lblAdminSub"
        lblAdminSub.Size = New Size(293, 20)
        lblAdminSub.TabIndex = 2
        lblAdminSub.Text = "Area terbatas — hanya untuk administrator"
        ' 
        ' pnlFieldArea
        ' 
        pnlFieldArea.BackColor = Color.Transparent
        pnlFieldArea.Controls.Add(lblUsername)
        pnlFieldArea.Controls.Add(txtUsername)
        pnlFieldArea.Controls.Add(lblPassword)
        pnlFieldArea.Controls.Add(txtPassword)
        pnlFieldArea.Location = New Point(32, 123)
        pnlFieldArea.Name = "pnlFieldArea"
        pnlFieldArea.Size = New Size(427, 148)
        pnlFieldArea.TabIndex = 3
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(200))
        lblUsername.Location = New Point(0, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(80, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(0, 21)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(396, 30)
        txtUsername.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(200))
        lblPassword.Location = New Point(0, 67)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(0, 88)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(396, 30)
        txtPassword.TabIndex = 3
        ' 
        ' pnlButtons
        ' 
        pnlButtons.BackColor = Color.Transparent
        pnlButtons.Controls.Add(btnLogin)
        pnlButtons.Controls.Add(btnBatal)
        pnlButtons.Location = New Point(32, 280)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(395, 39)
        pnlButtons.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(185), CByte(0), CByte(0))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(210, 0)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(186, 43)
        btnLogin.TabIndex = 0
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(70), CByte(90))
        btnBatal.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F)
        btnBatal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(200))
        btnBatal.Location = New Point(0, 0)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(200, 43)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.BackColor = Color.Transparent
        lblFooter.Font = New Font("Segoe UI", 7.5F, FontStyle.Italic)
        lblFooter.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(100))
        lblFooter.Location = New Point(32, 339)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(395, 19)
        lblFooter.TabIndex = 5
        lblFooter.Text = "F1 Race Management System — Admin Access Only"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        ClientSize = New Size(459, 420)
        ControlBox = False
        Controls.Add(pnlOuter)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginAdmin"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Login — F1 Race Management"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        pnlOuter.ResumeLayout(False)
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        pnlFieldArea.ResumeLayout(False)
        pnlFieldArea.PerformLayout()
        pnlButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlOuter As Panel
    Friend WithEvents pnlTopAccent As Panel
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblFormSubtitle As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblLockIcon As Label
    Friend WithEvents lblAdminTitle As Label
    Friend WithEvents lblAdminSub As Label
    Friend WithEvents pnlFieldArea As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblFooter As Label
End Class