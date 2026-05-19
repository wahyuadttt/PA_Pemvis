<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardAdmin
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
<<<<<<< HEAD
        pnlSidebar = New Panel()
        pnlSidebarAccent = New Panel()
        lblLogoMark = New Label()
        lblMenuLabel = New Label()
=======
        components = New ComponentModel.Container()
        Dim DGVStyleAlt1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleHdr1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleCell1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleAlt2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleHdr2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleCell2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleAlt3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleHdr3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleCell3 As DataGridViewCellStyle = New DataGridViewCellStyle()

        ' ── Header ──────────────────────────────────────────────────
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblAdminBadge = New Label()

        ' ── Sidebar kiri (menu + btnKeluar di bawah) ────────────────
        pnlSidebar = New Panel()
        pnlSidebarTop = New Panel()           ' strip merah kiri
        lblMenuTitle = New Label()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        btnNavHasil = New Button()
<<<<<<< HEAD
        pnlSidebarDiv = New Panel()
        btnNavKlasemen = New Button()
        pnlSidebarFoot = New Panel()
        btnKeluar = New Button()
        pnlContent = New Panel()
        pnlSidebar.SuspendLayout()
        pnlSidebarFoot.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(pnlSidebarAccent)
        pnlSidebar.Controls.Add(lblLogoMark)
        pnlSidebar.Controls.Add(lblMenuLabel)
=======
        pnlSidebarDivider = New Panel()
        btnNavKlasemen = New Button()
        pnlSidebarFoot = New Panel()           ' area kaki sidebar
        btnKeluar = New Button()          ' ← pindah ke sini

        ' ── Area konten (Fill, padding kiri 20) ─────────────────────
        pnlContent = New Panel()
        tabMain = New TabControl()

        ' ── Tab Pembalap ─────────────────────────────────────────────
        tpPembalap = New TabPage()
        pnlInputPembalap = New Panel()
        lblPanelPembalap = New Label()
        lblNamaPembalap = New Label()
        txtNamaPembalap = New TextBox()
        lblNegaraPembalap = New Label()
        txtNegaraPembalap = New TextBox()
        lblNomor = New Label()
        txtNomor = New TextBox()
        lblTimPembalap = New Label()
        cbTim = New ComboBox()
        pnlActionPembalap = New Panel()
        btnSimpanPembalap = New Button()
        btnUbahPembalap = New Button()
        btnHapusPembalap = New Button()
        btnBatalPembalap = New Button()
        btnPrintPembalap = New Button()
        pnlGridPembalap = New Panel()
        txtSearchPembalap = New TextBox()
        dgvPembalap = New DataGridView()

        ' ── Tab Tim ──────────────────────────────────────────────────
        tpTim = New TabPage()
        pnlInputTim = New Panel()
        lblPanelTim = New Label()
        picLogoTim = New PictureBox()
        btnPilihLogo = New Button()
        lblNamaTim = New Label()
        txtNamaTim = New TextBox()
        lblNegaraTim = New Label()
        txtNegaraTim = New TextBox()
        lblMesin = New Label()
        txtMesin = New TextBox()
        lblChasis = New Label()
        txtChasis = New TextBox()
        pnlActionTim = New Panel()
        btnSimpanTim = New Button()
        btnUbahTim = New Button()
        btnHapusTim = New Button()
        btnBatalTim = New Button()
        btnPrintTim = New Button()
        pnlGridTim = New Panel()
        txtSearchTim = New TextBox()
        dgvTim = New DataGridView()

        ' ── Tab Race (txtLokasi → cmbSirkuit) ────────────────────────
        tpRace = New TabPage()
        pnlInputRace = New Panel()
        lblPanelRace = New Label()
        lblNamaRace = New Label()
        txtNamaRace = New TextBox()
        lblLokasi = New Label()
        cmbSirkuit = New ComboBox()        ' ← BARU: ganti txtLokasi
        lblTanggal = New Label()
        dtpTanggal = New DateTimePicker()
        lblPutaran = New Label()
        txtPutaran = New TextBox()
        pnlActionRace = New Panel()
        btnSimpanRace = New Button()
        btnUbahRace = New Button()
        btnHapusRace = New Button()
        btnBatalRace = New Button()
        btnPrintRace = New Button()
        pnlGridRace = New Panel()
        txtSearchRace = New TextBox()
        dgvRace = New DataGridView()

        ' ── Tab Hasil ────────────────────────────────────────────────
        tpHasil = New TabPage()
        Label1 = New Label()
        cbPilihRace = New ComboBox()
        dgvHasilRace = New DataGridView()
        Label2 = New Label()
        cbRaceHasil = New ComboBox()
        Label3 = New Label()
        cbPembalapHasil = New ComboBox()
        Label4 = New Label()
        txtTimHasil = New TextBox()
        Label5 = New Label()
        txtPosisi = New TextBox()
        Label6 = New Label()
        txtGap = New TextBox()
        Label7 = New Label()
        cbStatusFinish = New ComboBox()
        chkFastestLap = New CheckBox()
        Label9 = New Label()
        txtPoinHasil = New TextBox()
        btnSimpanHasil = New Button()
        btnUbahHasil = New Button()
        btnHapusHasil = New Button()
        btnBatalHasil = New Button()

        ErrorProvider1 = New ErrorProvider(components)

        ' ── SuspendLayout ────────────────────────────────────────────
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlSidebarFoot.SuspendLayout()
        pnlContent.SuspendLayout()
        tabMain.SuspendLayout()
        tpPembalap.SuspendLayout()
        pnlInputPembalap.SuspendLayout()
        pnlActionPembalap.SuspendLayout()
        pnlGridPembalap.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        tpTim.SuspendLayout()
        pnlInputTim.SuspendLayout()
        pnlActionTim.SuspendLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridTim.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
        tpRace.SuspendLayout()
        pnlInputRace.SuspendLayout()
        pnlActionRace.SuspendLayout()
        pnlGridRace.SuspendLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).BeginInit()
        tpHasil.SuspendLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ════════════════════════════════════════════════════════════
        ' HEADER  (Dock=Top, 60px)
        ' ════════════════════════════════════════════════════════════
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblAdminBadge)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1280, 60)
        pnlHeader.TabIndex = 0
        ' Garis merah bawah header
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1280, 2)
        pnlHeaderAccent.TabIndex = 0
        ' Judul
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(15, 10)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' Sub judul
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(18, 38)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Admin Dashboard"
        ' Badge ADMIN (pojok kanan header, btnKeluar sudah dipindah ke sidebar)
        lblAdminBadge.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.White
        lblAdminBadge.Location = New Point(1150, 14)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(110, 32)
        lblAdminBadge.TabIndex = 3
        lblAdminBadge.Text = "ADMIN"
        lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter

        ' ════════════════════════════════════════════════════════════
        ' SIDEBAR KIRI  (Dock=Left, 200px)
        ' ════════════════════════════════════════════════════════════
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(pnlSidebarTop)
        pnlSidebar.Controls.Add(lblMenuTitle)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(btnNavHasil)
<<<<<<< HEAD
        pnlSidebar.Controls.Add(pnlSidebarDiv)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(pnlSidebarFoot)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(215, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlSidebarAccent
        ' 
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Left
        pnlSidebarAccent.Location = New Point(0, 0)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(3, 750)
        pnlSidebarAccent.TabIndex = 0
        ' 
        ' lblLogoMark
        ' 
        lblLogoMark.AutoSize = True
        lblLogoMark.BackColor = Color.Transparent
        lblLogoMark.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblLogoMark.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblLogoMark.Location = New Point(14, 20)
        lblLogoMark.Name = "lblLogoMark"
        lblLogoMark.Size = New Size(202, 30)
        lblLogoMark.TabIndex = 1
        lblLogoMark.Text = "F1 MANAGEMENT"
        ' 
        ' lblMenuLabel
        ' 
        lblMenuLabel.AutoSize = True
        lblMenuLabel.BackColor = Color.Transparent
        lblMenuLabel.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblMenuLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(130))
        lblMenuLabel.Location = New Point(14, 60)
        lblMenuLabel.Name = "lblMenuLabel"
        lblMenuLabel.Size = New Size(128, 17)
        lblMenuLabel.TabIndex = 2
        lblMenuLabel.Text = "MANAJEMEN DATA"
        ' 
        ' btnNavPembalap
        ' 
=======
        pnlSidebar.Controls.Add(pnlSidebarDivider)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(pnlSidebarFoot)   ' panel kaki berisi btnKeluar
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 700)
        pnlSidebar.TabIndex = 1
        ' Strip merah vertikal kiri
        pnlSidebarTop.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarTop.Location = New Point(0, 0)
        pnlSidebarTop.Name = "pnlSidebarTop"
        pnlSidebarTop.Size = New Size(4, 700)
        pnlSidebarTop.TabIndex = 0
        ' Label section
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(15, 20)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.TabIndex = 1
        lblMenuTitle.Text = "MANAJEMEN DATA"
        ' Nav Pembalap
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavPembalap.Cursor = Cursors.Hand
        btnNavPembalap.FlatAppearance.BorderSize = 0
        btnNavPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavPembalap.FlatStyle = FlatStyle.Flat
        btnNavPembalap.Font = New Font("Segoe UI", 10.0F)
        btnNavPembalap.ForeColor = Color.White
<<<<<<< HEAD
        btnNavPembalap.Location = New Point(0, 80)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(200, 40)
        btnNavPembalap.TabIndex = 3
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnNavTim
        ' 
=======
        btnNavPembalap.Location = New Point(0, 48)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(200, 44)
        btnNavPembalap.TabIndex = 2
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        ' Nav Tim
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavTim.Cursor = Cursors.Hand
        btnNavTim.FlatAppearance.BorderSize = 0
        btnNavTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavTim.FlatStyle = FlatStyle.Flat
        btnNavTim.Font = New Font("Segoe UI", 10.0F)
        btnNavTim.ForeColor = Color.White
<<<<<<< HEAD
        btnNavTim.Location = New Point(0, 121)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(200, 40)
        btnNavTim.TabIndex = 4
        btnNavTim.Text = "  🏁  Tim / Konstruktor"
        btnNavTim.TextAlign = ContentAlignment.MiddleLeft
        btnNavTim.UseVisualStyleBackColor = False
        ' 
        ' btnNavRace
        ' 
=======
        btnNavTim.Location = New Point(0, 92)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(200, 44)
        btnNavTim.TabIndex = 3
        btnNavTim.Text = "  🏁  Konstruktor"
        btnNavTim.TextAlign = ContentAlignment.MiddleLeft
        btnNavTim.UseVisualStyleBackColor = False
        ' Nav Race
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavRace.Cursor = Cursors.Hand
        btnNavRace.FlatAppearance.BorderSize = 0
        btnNavRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavRace.FlatStyle = FlatStyle.Flat
        btnNavRace.Font = New Font("Segoe UI", 10.0F)
        btnNavRace.ForeColor = Color.White
<<<<<<< HEAD
        btnNavRace.Location = New Point(0, 162)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(200, 40)
        btnNavRace.TabIndex = 5
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' btnNavHasil
        ' 
=======
        btnNavRace.Location = New Point(0, 136)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(200, 44)
        btnNavRace.TabIndex = 4
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' Nav Hasil
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavHasil.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavHasil.Cursor = Cursors.Hand
        btnNavHasil.FlatAppearance.BorderSize = 0
        btnNavHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavHasil.FlatStyle = FlatStyle.Flat
        btnNavHasil.Font = New Font("Segoe UI", 10.0F)
        btnNavHasil.ForeColor = Color.White
<<<<<<< HEAD
        btnNavHasil.Location = New Point(0, 203)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(200, 40)
        btnNavHasil.TabIndex = 6
        btnNavHasil.Text = "  📊  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDiv
        ' 
        pnlSidebarDiv.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDiv.Location = New Point(14, 252)
        pnlSidebarDiv.Name = "pnlSidebarDiv"
        pnlSidebarDiv.Size = New Size(172, 1)
        pnlSidebarDiv.TabIndex = 7
        ' 
        ' btnNavKlasemen
        ' 
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(18), CByte(14))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavKlasemen.Location = New Point(0, 257)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(200, 40)
        btnNavKlasemen.TabIndex = 8
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarFoot
        ' 
        pnlSidebarFoot.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        pnlSidebarFoot.Controls.Add(btnKeluar)
        pnlSidebarFoot.Dock = DockStyle.Bottom
        pnlSidebarFoot.Location = New Point(0, 750)
        pnlSidebarFoot.Name = "pnlSidebarFoot"
        pnlSidebarFoot.Padding = New Padding(0, 10, 0, 10)
        pnlSidebarFoot.Size = New Size(215, 50)
        pnlSidebarFoot.TabIndex = 9
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.Dock = DockStyle.Fill
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.5F)
        btnKeluar.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        btnKeluar.Location = New Point(0, 0)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(215, 50)
        btnKeluar.TabIndex = 0
        btnKeluar.Text = "  ✕  Keluar / Logout"
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(215, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20, 0, 0, 0)
        pnlContent.Size = New Size(1065, 800)
        pnlContent.TabIndex = 1
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1280, 800)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        MinimumSize = New Size(1024, 700)
=======
        btnNavHasil.Location = New Point(0, 180)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(200, 44)
        btnNavHasil.TabIndex = 5
        btnNavHasil.Text = "  🏁  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        ' Garis divider
        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDivider.Location = New Point(15, 236)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(170, 1)
        pnlSidebarDivider.TabIndex = 6
        ' Nav Klasemen (warna merah, bold)
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavKlasemen.Location = New Point(0, 246)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(200, 44)
        btnNavKlasemen.TabIndex = 7
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False

        ' ── Panel kaki sidebar: btnKeluar (Dock=Bottom di pnlSidebar)
        ' ─────────────────────────────────────────────────────────────
        ' pnlSidebarFoot menempel di bawah sidebar via Dock=Bottom
        pnlSidebarFoot.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlSidebarFoot.Controls.Add(btnKeluar)
        pnlSidebarFoot.Dock = DockStyle.Bottom
        pnlSidebarFoot.Location = New Point(4, 640)
        pnlSidebarFoot.Name = "pnlSidebarFoot"
        pnlSidebarFoot.Padding = New Padding(10, 8, 10, 8)
        pnlSidebarFoot.Size = New Size(196, 60)
        pnlSidebarFoot.TabIndex = 8
        ' btnKeluar — lebar penuh dalam panel kaki
        btnKeluar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.Dock = DockStyle.Fill          ' ← mengisi panel kaki
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatAppearance.BorderSize = 1
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(10, 8)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(176, 44)
        btnKeluar.TabIndex = 0
        btnKeluar.Text = "⏻  KELUAR"
        btnKeluar.UseVisualStyleBackColor = False

        ' ════════════════════════════════════════════════════════════
        ' AREA KONTEN  (Dock=Fill, Padding.Left=20 untuk jarak dari sidebar)
        ' ════════════════════════════════════════════════════════════
        pnlContent.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlContent.Controls.Add(tabMain)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(200, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20, 0, 0, 0)  ' ← jarak kiri 20px dari sidebar
        pnlContent.Size = New Size(1080, 700)
        pnlContent.TabIndex = 2

        ' ════════════════════════════════════════════════════════════
        ' TAB CONTROL
        ' ════════════════════════════════════════════════════════════
        tabMain.Appearance = TabAppearance.FlatButtons
        tabMain.Controls.Add(tpPembalap)
        tabMain.Controls.Add(tpTim)
        tabMain.Controls.Add(tpRace)
        tabMain.Controls.Add(tpHasil)
        tabMain.Dock = DockStyle.Fill
        tabMain.ItemSize = New Size(130, 36)
        tabMain.Location = New Point(20, 0)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(1060, 700)
        tabMain.TabIndex = 0

        ' ════════════════════════════════════════════════════════════
        ' TAB PEMBALAP
        ' ════════════════════════════════════════════════════════════
        tpPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpPembalap.Controls.Add(pnlInputPembalap)
        tpPembalap.Controls.Add(pnlGridPembalap)
        tpPembalap.Location = New Point(4, 40)
        tpPembalap.Name = "tpPembalap"
        tpPembalap.Size = New Size(1052, 656)
        tpPembalap.TabIndex = 0
        tpPembalap.Text = "  Pembalap  "
        ' Panel input kiri
        pnlInputPembalap.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputPembalap.Controls.Add(lblPanelPembalap)
        pnlInputPembalap.Controls.Add(lblNamaPembalap)
        pnlInputPembalap.Controls.Add(txtNamaPembalap)
        pnlInputPembalap.Controls.Add(lblNegaraPembalap)
        pnlInputPembalap.Controls.Add(txtNegaraPembalap)
        pnlInputPembalap.Controls.Add(lblNomor)
        pnlInputPembalap.Controls.Add(txtNomor)
        pnlInputPembalap.Controls.Add(lblTimPembalap)
        pnlInputPembalap.Controls.Add(cbTim)
        pnlInputPembalap.Controls.Add(pnlActionPembalap)
        pnlInputPembalap.Location = New Point(8, 8)
        pnlInputPembalap.Name = "pnlInputPembalap"
        pnlInputPembalap.Size = New Size(240, 640)
        pnlInputPembalap.TabIndex = 0
        ' Header panel merah
        lblPanelPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelPembalap.Dock = DockStyle.Top
        lblPanelPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPanelPembalap.ForeColor = Color.White
        lblPanelPembalap.Location = New Point(0, 0)
        lblPanelPembalap.Name = "lblPanelPembalap"
        lblPanelPembalap.Size = New Size(240, 32)
        lblPanelPembalap.TabIndex = 0
        lblPanelPembalap.Text = "  DATA PEMBALAP"
        lblPanelPembalap.TextAlign = ContentAlignment.MiddleLeft
        ' Field Nama
        lblNamaPembalap.AutoSize = True
        lblNamaPembalap.Font = New Font("Segoe UI", 8.0F)
        lblNamaPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaPembalap.Location = New Point(12, 50)
        lblNamaPembalap.Name = "lblNamaPembalap"
        lblNamaPembalap.TabIndex = 1
        lblNamaPembalap.Text = "NAMA PEMBALAP"
        txtNamaPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNamaPembalap.Font = New Font("Segoe UI", 10.0F)
        txtNamaPembalap.ForeColor = Color.White
        txtNamaPembalap.Location = New Point(12, 70)
        txtNamaPembalap.Name = "txtNamaPembalap"
        txtNamaPembalap.Size = New Size(214, 34)
        txtNamaPembalap.TabIndex = 1
        ' Field Negara
        lblNegaraPembalap.AutoSize = True
        lblNegaraPembalap.Font = New Font("Segoe UI", 8.0F)
        lblNegaraPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNegaraPembalap.Location = New Point(12, 115)
        lblNegaraPembalap.Name = "lblNegaraPembalap"
        lblNegaraPembalap.TabIndex = 2
        lblNegaraPembalap.Text = "NEGARA"
        txtNegaraPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNegaraPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNegaraPembalap.Font = New Font("Segoe UI", 10.0F)
        txtNegaraPembalap.ForeColor = Color.White
        txtNegaraPembalap.Location = New Point(12, 135)
        txtNegaraPembalap.Name = "txtNegaraPembalap"
        txtNegaraPembalap.Size = New Size(214, 34)
        txtNegaraPembalap.TabIndex = 2
        ' Field Nomor
        lblNomor.AutoSize = True
        lblNomor.Font = New Font("Segoe UI", 8.0F)
        lblNomor.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNomor.Location = New Point(12, 180)
        lblNomor.Name = "lblNomor"
        lblNomor.TabIndex = 3
        lblNomor.Text = "NOMOR BALAP"
        txtNomor.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNomor.BorderStyle = BorderStyle.FixedSingle
        txtNomor.Font = New Font("Segoe UI", 10.0F)
        txtNomor.ForeColor = Color.White
        txtNomor.Location = New Point(12, 200)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(214, 34)
        txtNomor.TabIndex = 3
        ' Field Tim
        lblTimPembalap.AutoSize = True
        lblTimPembalap.Font = New Font("Segoe UI", 8.0F)
        lblTimPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTimPembalap.Location = New Point(12, 245)
        lblTimPembalap.Name = "lblTimPembalap"
        lblTimPembalap.TabIndex = 4
        lblTimPembalap.Text = "KONSTRUKTOR / TIM"
        cbTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        cbTim.DropDownStyle = ComboBoxStyle.DropDownList
        cbTim.FlatStyle = FlatStyle.Flat
        cbTim.Font = New Font("Segoe UI", 10.0F)
        cbTim.ForeColor = Color.White
        cbTim.FormattingEnabled = True
        cbTim.Location = New Point(12, 265)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(215, 36)
        cbTim.TabIndex = 4
        ' Panel aksi Pembalap
        pnlActionPembalap.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionPembalap.Controls.Add(btnSimpanPembalap)
        pnlActionPembalap.Controls.Add(btnUbahPembalap)
        pnlActionPembalap.Controls.Add(btnHapusPembalap)
        pnlActionPembalap.Controls.Add(btnBatalPembalap)
        pnlActionPembalap.Controls.Add(btnPrintPembalap)
        pnlActionPembalap.Location = New Point(0, 440)
        pnlActionPembalap.Name = "pnlActionPembalap"
        pnlActionPembalap.Size = New Size(240, 200)
        pnlActionPembalap.TabIndex = 10
        btnSimpanPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanPembalap.Cursor = Cursors.Hand
        btnSimpanPembalap.FlatAppearance.BorderSize = 0
        btnSimpanPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanPembalap.FlatStyle = FlatStyle.Flat
        btnSimpanPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanPembalap.ForeColor = Color.White
        btnSimpanPembalap.Location = New Point(10, 10)
        btnSimpanPembalap.Name = "btnSimpanPembalap"
        btnSimpanPembalap.Size = New Size(100, 34)
        btnSimpanPembalap.TabIndex = 5
        btnSimpanPembalap.Text = "SIMPAN"
        btnSimpanPembalap.UseVisualStyleBackColor = False
        btnUbahPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahPembalap.Cursor = Cursors.Hand
        btnUbahPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahPembalap.FlatStyle = FlatStyle.Flat
        btnUbahPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahPembalap.ForeColor = Color.White
        btnUbahPembalap.Location = New Point(125, 10)
        btnUbahPembalap.Name = "btnUbahPembalap"
        btnUbahPembalap.Size = New Size(100, 34)
        btnUbahPembalap.TabIndex = 6
        btnUbahPembalap.Text = "UBAH"
        btnUbahPembalap.UseVisualStyleBackColor = False
        btnHapusPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusPembalap.Cursor = Cursors.Hand
        btnHapusPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusPembalap.FlatStyle = FlatStyle.Flat
        btnHapusPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusPembalap.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusPembalap.Location = New Point(10, 54)
        btnHapusPembalap.Name = "btnHapusPembalap"
        btnHapusPembalap.Size = New Size(100, 34)
        btnHapusPembalap.TabIndex = 7
        btnHapusPembalap.Text = "HAPUS"
        btnHapusPembalap.UseVisualStyleBackColor = False
        btnBatalPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalPembalap.Cursor = Cursors.Hand
        btnBatalPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalPembalap.FlatStyle = FlatStyle.Flat
        btnBatalPembalap.Font = New Font("Segoe UI", 9.0F)
        btnBatalPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalPembalap.Location = New Point(125, 54)
        btnBatalPembalap.Name = "btnBatalPembalap"
        btnBatalPembalap.Size = New Size(100, 34)
        btnBatalPembalap.TabIndex = 8
        btnBatalPembalap.Text = "BATAL"
        btnBatalPembalap.UseVisualStyleBackColor = False
        btnPrintPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintPembalap.Cursor = Cursors.Hand
        btnPrintPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.FlatStyle = FlatStyle.Flat
        btnPrintPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPrintPembalap.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.Location = New Point(10, 100)
        btnPrintPembalap.Name = "btnPrintPembalap"
        btnPrintPembalap.Size = New Size(215, 34)
        btnPrintPembalap.TabIndex = 9
        btnPrintPembalap.Text = "🖨  PRINT DOKUMEN"
        btnPrintPembalap.UseVisualStyleBackColor = False
        ' Grid Pembalap (kanan)
        pnlGridPembalap.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridPembalap.Controls.Add(txtSearchPembalap)
        pnlGridPembalap.Controls.Add(dgvPembalap)
        pnlGridPembalap.Location = New Point(260, 8)
        pnlGridPembalap.Name = "pnlGridPembalap"
        pnlGridPembalap.Size = New Size(784, 640)
        pnlGridPembalap.TabIndex = 1
        txtSearchPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10.0F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchPembalap.Location = New Point(10, 10)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(764, 34)
        txtSearchPembalap.TabIndex = 0
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
        DGVStyleAlt1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvPembalap.AlternatingRowsDefaultCellStyle = DGVStyleAlt1
        dgvPembalap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPembalap.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvPembalap.BorderStyle = BorderStyle.None
        dgvPembalap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPembalap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVStyleHdr1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleHdr1.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHdr1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVStyleHdr1.ForeColor = Color.White
        DGVStyleHdr1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHdr1.WrapMode = DataGridViewTriState.True
        dgvPembalap.ColumnHeadersDefaultCellStyle = DGVStyleHdr1
        dgvPembalap.ColumnHeadersHeight = 36
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVStyleCell1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleCell1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DGVStyleCell1.Font = New Font("Segoe UI", 9.0F)
        DGVStyleCell1.ForeColor = Color.White
        DGVStyleCell1.Padding = New Padding(4)
        DGVStyleCell1.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVStyleCell1.SelectionForeColor = Color.White
        DGVStyleCell1.WrapMode = DataGridViewTriState.False
        dgvPembalap.DefaultCellStyle = DGVStyleCell1
        dgvPembalap.EnableHeadersVisualStyles = False
        dgvPembalap.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvPembalap.Location = New Point(10, 50)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowTemplate.Height = 32
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(764, 580)
        dgvPembalap.TabIndex = 1

        ' ════════════════════════════════════════════════════════════
        ' TAB TIM
        ' ════════════════════════════════════════════════════════════
        tpTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpTim.Controls.Add(pnlInputTim)
        tpTim.Controls.Add(pnlGridTim)
        tpTim.Location = New Point(4, 40)
        tpTim.Name = "tpTim"
        tpTim.Size = New Size(1052, 656)
        tpTim.TabIndex = 1
        tpTim.Text = "  Konstruktor  "
        pnlInputTim.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputTim.Controls.Add(lblPanelTim)
        pnlInputTim.Controls.Add(picLogoTim)
        pnlInputTim.Controls.Add(btnPilihLogo)
        pnlInputTim.Controls.Add(lblNamaTim)
        pnlInputTim.Controls.Add(txtNamaTim)
        pnlInputTim.Controls.Add(lblNegaraTim)
        pnlInputTim.Controls.Add(txtNegaraTim)
        pnlInputTim.Controls.Add(lblMesin)
        pnlInputTim.Controls.Add(txtMesin)
        pnlInputTim.Controls.Add(lblChasis)
        pnlInputTim.Controls.Add(txtChasis)
        pnlInputTim.Controls.Add(pnlActionTim)
        pnlInputTim.Location = New Point(8, 8)
        pnlInputTim.Name = "pnlInputTim"
        pnlInputTim.Size = New Size(240, 640)
        pnlInputTim.TabIndex = 0
        lblPanelTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelTim.Dock = DockStyle.Top
        lblPanelTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPanelTim.ForeColor = Color.White
        lblPanelTim.Location = New Point(0, 0)
        lblPanelTim.Name = "lblPanelTim"
        lblPanelTim.Size = New Size(240, 32)
        lblPanelTim.TabIndex = 0
        lblPanelTim.Text = "  DATA KONSTRUKTOR"
        lblPanelTim.TextAlign = ContentAlignment.MiddleLeft
        picLogoTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        picLogoTim.BorderStyle = BorderStyle.FixedSingle
        picLogoTim.Location = New Point(55, 42)
        picLogoTim.Name = "picLogoTim"
        picLogoTim.Size = New Size(130, 80)
        picLogoTim.SizeMode = PictureBoxSizeMode.Zoom
        picLogoTim.TabIndex = 0
        picLogoTim.TabStop = False
        btnPilihLogo.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnPilihLogo.Cursor = Cursors.Hand
        btnPilihLogo.FlatAppearance.BorderSize = 0
        btnPilihLogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPilihLogo.FlatStyle = FlatStyle.Flat
        btnPilihLogo.Font = New Font("Segoe UI", 8.0F)
        btnPilihLogo.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnPilihLogo.Location = New Point(55, 128)
        btnPilihLogo.Name = "btnPilihLogo"
        btnPilihLogo.Size = New Size(130, 24)
        btnPilihLogo.TabIndex = 1
        btnPilihLogo.Text = "Pilih Logo..."
        btnPilihLogo.UseVisualStyleBackColor = False
        lblNamaTim.AutoSize = True
        lblNamaTim.Font = New Font("Segoe UI", 8.0F)
        lblNamaTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaTim.Location = New Point(12, 165)
        lblNamaTim.Name = "lblNamaTim"
        lblNamaTim.TabIndex = 2
        lblNamaTim.Text = "NAMA TIM"
        txtNamaTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaTim.BorderStyle = BorderStyle.FixedSingle
        txtNamaTim.Font = New Font("Segoe UI", 10.0F)
        txtNamaTim.ForeColor = Color.White
        txtNamaTim.Location = New Point(12, 182)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(214, 34)
        txtNamaTim.TabIndex = 2
        lblNegaraTim.AutoSize = True
        lblNegaraTim.Font = New Font("Segoe UI", 8.0F)
        lblNegaraTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNegaraTim.Location = New Point(12, 226)
        lblNegaraTim.Name = "lblNegaraTim"
        lblNegaraTim.TabIndex = 3
        lblNegaraTim.Text = "NEGARA"
        txtNegaraTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNegaraTim.BorderStyle = BorderStyle.FixedSingle
        txtNegaraTim.Font = New Font("Segoe UI", 10.0F)
        txtNegaraTim.ForeColor = Color.White
        txtNegaraTim.Location = New Point(12, 244)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(214, 34)
        txtNegaraTim.TabIndex = 3
        lblMesin.AutoSize = True
        lblMesin.Font = New Font("Segoe UI", 8.0F)
        lblMesin.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblMesin.Location = New Point(12, 288)
        lblMesin.Name = "lblMesin"
        lblMesin.TabIndex = 4
        lblMesin.Text = "MESIN"
        txtMesin.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtMesin.BorderStyle = BorderStyle.FixedSingle
        txtMesin.Font = New Font("Segoe UI", 10.0F)
        txtMesin.ForeColor = Color.White
        txtMesin.Location = New Point(12, 306)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(214, 34)
        txtMesin.TabIndex = 4
        lblChasis.AutoSize = True
        lblChasis.Font = New Font("Segoe UI", 8.0F)
        lblChasis.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblChasis.Location = New Point(12, 350)
        lblChasis.Name = "lblChasis"
        lblChasis.TabIndex = 5
        lblChasis.Text = "CHASIS"
        txtChasis.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtChasis.BorderStyle = BorderStyle.FixedSingle
        txtChasis.Font = New Font("Segoe UI", 10.0F)
        txtChasis.ForeColor = Color.White
        txtChasis.Location = New Point(12, 368)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(214, 34)
        txtChasis.TabIndex = 5
        pnlActionTim.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionTim.Controls.Add(btnSimpanTim)
        pnlActionTim.Controls.Add(btnUbahTim)
        pnlActionTim.Controls.Add(btnHapusTim)
        pnlActionTim.Controls.Add(btnBatalTim)
        pnlActionTim.Controls.Add(btnPrintTim)
        pnlActionTim.Location = New Point(0, 440)
        pnlActionTim.Name = "pnlActionTim"
        pnlActionTim.Size = New Size(240, 200)
        pnlActionTim.TabIndex = 10
        btnSimpanTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanTim.Cursor = Cursors.Hand
        btnSimpanTim.FlatAppearance.BorderSize = 0
        btnSimpanTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanTim.FlatStyle = FlatStyle.Flat
        btnSimpanTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanTim.ForeColor = Color.White
        btnSimpanTim.Location = New Point(10, 10)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(100, 34)
        btnSimpanTim.TabIndex = 6
        btnSimpanTim.Text = "SIMPAN"
        btnSimpanTim.UseVisualStyleBackColor = False
        btnUbahTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahTim.Cursor = Cursors.Hand
        btnUbahTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahTim.FlatStyle = FlatStyle.Flat
        btnUbahTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahTim.ForeColor = Color.White
        btnUbahTim.Location = New Point(125, 10)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(100, 34)
        btnUbahTim.TabIndex = 7
        btnUbahTim.Text = "UBAH"
        btnUbahTim.UseVisualStyleBackColor = False
        btnHapusTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusTim.Cursor = Cursors.Hand
        btnHapusTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusTim.FlatStyle = FlatStyle.Flat
        btnHapusTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusTim.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusTim.Location = New Point(10, 54)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(100, 34)
        btnHapusTim.TabIndex = 8
        btnHapusTim.Text = "HAPUS"
        btnHapusTim.UseVisualStyleBackColor = False
        btnBatalTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalTim.Cursor = Cursors.Hand
        btnBatalTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalTim.FlatStyle = FlatStyle.Flat
        btnBatalTim.Font = New Font("Segoe UI", 9.0F)
        btnBatalTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalTim.Location = New Point(125, 54)
        btnBatalTim.Name = "btnBatalTim"
        btnBatalTim.Size = New Size(100, 34)
        btnBatalTim.TabIndex = 9
        btnBatalTim.Text = "BATAL"
        btnBatalTim.UseVisualStyleBackColor = False
        btnPrintTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintTim.Cursor = Cursors.Hand
        btnPrintTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.FlatStyle = FlatStyle.Flat
        btnPrintTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPrintTim.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.Location = New Point(10, 100)
        btnPrintTim.Name = "btnPrintTim"
        btnPrintTim.Size = New Size(215, 34)
        btnPrintTim.TabIndex = 10
        btnPrintTim.Text = "🖨  PRINT DOKUMEN"
        btnPrintTim.UseVisualStyleBackColor = False
        pnlGridTim.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridTim.Controls.Add(txtSearchTim)
        pnlGridTim.Controls.Add(dgvTim)
        pnlGridTim.Location = New Point(260, 8)
        pnlGridTim.Name = "pnlGridTim"
        pnlGridTim.Size = New Size(784, 640)
        pnlGridTim.TabIndex = 1
        txtSearchTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchTim.BorderStyle = BorderStyle.FixedSingle
        txtSearchTim.Font = New Font("Segoe UI", 10.0F)
        txtSearchTim.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchTim.Location = New Point(10, 10)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(764, 34)
        txtSearchTim.TabIndex = 0
        txtSearchTim.Text = "🔍  Cari tim konstruktor..."
        DGVStyleAlt2.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DGVStyleAlt2
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVStyleHdr2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleHdr2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHdr2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVStyleHdr2.ForeColor = Color.White
        DGVStyleHdr2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHdr2.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DGVStyleHdr2
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVStyleCell2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleCell2.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DGVStyleCell2.Font = New Font("Segoe UI", 9.0F)
        DGVStyleCell2.ForeColor = Color.White
        DGVStyleCell2.Padding = New Padding(4)
        DGVStyleCell2.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVStyleCell2.SelectionForeColor = Color.White
        DGVStyleCell2.WrapMode = DataGridViewTriState.False
        dgvTim.DefaultCellStyle = DGVStyleCell2
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvTim.Location = New Point(10, 50)
        dgvTim.Name = "dgvTim"
        dgvTim.RowHeadersVisible = False
        dgvTim.RowTemplate.Height = 32
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Size = New Size(764, 580)
        dgvTim.TabIndex = 1

        ' ════════════════════════════════════════════════════════════
        ' TAB RACE  —  txtLokasi diganti cmbSirkuit
        ' ════════════════════════════════════════════════════════════
        tpRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpRace.Controls.Add(pnlInputRace)
        tpRace.Controls.Add(pnlGridRace)
        tpRace.Location = New Point(4, 40)
        tpRace.Name = "tpRace"
        tpRace.Size = New Size(1052, 656)
        tpRace.TabIndex = 2
        tpRace.Text = "  Jadwal Race  "
        ' Panel input Race
        pnlInputRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputRace.Controls.Add(lblPanelRace)
        pnlInputRace.Controls.Add(lblNamaRace)
        pnlInputRace.Controls.Add(txtNamaRace)
        pnlInputRace.Controls.Add(lblLokasi)
        pnlInputRace.Controls.Add(cmbSirkuit)    ' ← ComboBox baru
        pnlInputRace.Controls.Add(lblTanggal)
        pnlInputRace.Controls.Add(dtpTanggal)
        pnlInputRace.Controls.Add(lblPutaran)
        pnlInputRace.Controls.Add(txtPutaran)
        pnlInputRace.Controls.Add(pnlActionRace)
        pnlInputRace.Location = New Point(8, 8)
        pnlInputRace.Name = "pnlInputRace"
        pnlInputRace.Size = New Size(240, 640)
        pnlInputRace.TabIndex = 0
        lblPanelRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelRace.Dock = DockStyle.Top
        lblPanelRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPanelRace.ForeColor = Color.White
        lblPanelRace.Location = New Point(0, 0)
        lblPanelRace.Name = "lblPanelRace"
        lblPanelRace.Size = New Size(240, 32)
        lblPanelRace.TabIndex = 0
        lblPanelRace.Text = "  DATA RACE"
        lblPanelRace.TextAlign = ContentAlignment.MiddleLeft
        lblNamaRace.AutoSize = True
        lblNamaRace.Font = New Font("Segoe UI", 8.0F)
        lblNamaRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaRace.Location = New Point(12, 50)
        lblNamaRace.Name = "lblNamaRace"
        lblNamaRace.TabIndex = 1
        lblNamaRace.Text = "NAMA GRAND PRIX"
        txtNamaRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaRace.BorderStyle = BorderStyle.FixedSingle
        txtNamaRace.Font = New Font("Segoe UI", 10.0F)
        txtNamaRace.ForeColor = Color.White
        txtNamaRace.Location = New Point(12, 68)
        txtNamaRace.Name = "txtNamaRace"
        txtNamaRace.Size = New Size(214, 34)
        txtNamaRace.TabIndex = 1
        ' Label Sirkuit (dulu lblLokasi, nama dipertahankan agar .vb logika tidak patah)
        lblLokasi.AutoSize = True
        lblLokasi.Font = New Font("Segoe UI", 8.0F)
        lblLokasi.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblLokasi.Location = New Point(12, 114)
        lblLokasi.Name = "lblLokasi"
        lblLokasi.TabIndex = 2
        lblLokasi.Text = "SIRKUIT"
        ' ── cmbSirkuit (pengganti txtLokasi) ──────────────────────
        cmbSirkuit.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        cmbSirkuit.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSirkuit.FlatStyle = FlatStyle.Flat
        cmbSirkuit.Font = New Font("Segoe UI", 10.0F)
        cmbSirkuit.ForeColor = Color.White
        cmbSirkuit.FormattingEnabled = True
        cmbSirkuit.Items.AddRange(New Object() {
            "Autodromo Nazionale di Monza",
            "Silverstone Circuit",
            "Suzuka International Racing Course",
            "Circuit de Monaco",
            "Circuit de Spa-Francorchamps",
            "Circuit de Barcelona-Catalunya",
            "Bahrain International Circuit",
            "Jeddah Corniche Circuit",
            "Albert Park Circuit",
            "Miami International Autodrome",
            "Autodromo Enzo e Dino Ferrari (Imola)",
            "Circuit Gilles Villeneuve",
            "Red Bull Ring",
            "Hungaroring",
            "Circuit Zandvoort",
            "Marina Bay Street Circuit",
            "Losail International Circuit",
            "Circuit of the Americas",
            "Autodromo Hermanos Rodriguez",
            "Autodromo Jose Carlos Pace (Interlagos)",
            "Las Vegas Strip Circuit",
            "Yas Marina Circuit"
        })
        cmbSirkuit.Location = New Point(12, 132)
        cmbSirkuit.Name = "cmbSirkuit"
        cmbSirkuit.Size = New Size(215, 36)
        cmbSirkuit.TabIndex = 2
        ' Tanggal
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 8.0F)
        lblTanggal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTanggal.Location = New Point(12, 180)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.TabIndex = 3
        lblTanggal.Text = "TANGGAL"
        dtpTanggal.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        dtpTanggal.CalendarForeColor = Color.White
        dtpTanggal.CalendarMonthBackground = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dtpTanggal.CalendarTitleBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        dtpTanggal.CalendarTitleForeColor = Color.White
        dtpTanggal.Font = New Font("Segoe UI", 10.0F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(12, 198)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(215, 34)
        dtpTanggal.TabIndex = 3
        ' Putaran
        lblPutaran.AutoSize = True
        lblPutaran.Font = New Font("Segoe UI", 8.0F)
        lblPutaran.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblPutaran.Location = New Point(12, 244)
        lblPutaran.Name = "lblPutaran"
        lblPutaran.TabIndex = 4
        lblPutaran.Text = "PUTARAN (ROUND)"
        txtPutaran.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtPutaran.BorderStyle = BorderStyle.FixedSingle
        txtPutaran.Font = New Font("Segoe UI", 10.0F)
        txtPutaran.ForeColor = Color.White
        txtPutaran.Location = New Point(12, 262)
        txtPutaran.Name = "txtPutaran"
        txtPutaran.Size = New Size(214, 34)
        txtPutaran.TabIndex = 4
        ' Panel aksi Race
        pnlActionRace.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionRace.Controls.Add(btnSimpanRace)
        pnlActionRace.Controls.Add(btnUbahRace)
        pnlActionRace.Controls.Add(btnHapusRace)
        pnlActionRace.Controls.Add(btnBatalRace)
        pnlActionRace.Controls.Add(btnPrintRace)
        pnlActionRace.Location = New Point(0, 440)
        pnlActionRace.Name = "pnlActionRace"
        pnlActionRace.Size = New Size(240, 200)
        pnlActionRace.TabIndex = 10
        btnSimpanRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanRace.Cursor = Cursors.Hand
        btnSimpanRace.FlatAppearance.BorderSize = 0
        btnSimpanRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanRace.FlatStyle = FlatStyle.Flat
        btnSimpanRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanRace.ForeColor = Color.White
        btnSimpanRace.Location = New Point(10, 10)
        btnSimpanRace.Name = "btnSimpanRace"
        btnSimpanRace.Size = New Size(100, 34)
        btnSimpanRace.TabIndex = 5
        btnSimpanRace.Text = "SIMPAN"
        btnSimpanRace.UseVisualStyleBackColor = False
        btnUbahRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahRace.Cursor = Cursors.Hand
        btnUbahRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahRace.FlatStyle = FlatStyle.Flat
        btnUbahRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahRace.ForeColor = Color.White
        btnUbahRace.Location = New Point(125, 10)
        btnUbahRace.Name = "btnUbahRace"
        btnUbahRace.Size = New Size(100, 34)
        btnUbahRace.TabIndex = 6
        btnUbahRace.Text = "UBAH"
        btnUbahRace.UseVisualStyleBackColor = False
        btnHapusRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusRace.Cursor = Cursors.Hand
        btnHapusRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusRace.FlatStyle = FlatStyle.Flat
        btnHapusRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusRace.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusRace.Location = New Point(10, 54)
        btnHapusRace.Name = "btnHapusRace"
        btnHapusRace.Size = New Size(100, 34)
        btnHapusRace.TabIndex = 7
        btnHapusRace.Text = "HAPUS"
        btnHapusRace.UseVisualStyleBackColor = False
        btnBatalRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalRace.Cursor = Cursors.Hand
        btnBatalRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalRace.FlatStyle = FlatStyle.Flat
        btnBatalRace.Font = New Font("Segoe UI", 9.0F)
        btnBatalRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalRace.Location = New Point(125, 54)
        btnBatalRace.Name = "btnBatalRace"
        btnBatalRace.Size = New Size(100, 34)
        btnBatalRace.TabIndex = 8
        btnBatalRace.Text = "BATAL"
        btnBatalRace.UseVisualStyleBackColor = False
        btnPrintRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintRace.Cursor = Cursors.Hand
        btnPrintRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatStyle = FlatStyle.Flat
        btnPrintRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPrintRace.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.Location = New Point(10, 100)
        btnPrintRace.Name = "btnPrintRace"
        btnPrintRace.Size = New Size(215, 34)
        btnPrintRace.TabIndex = 9
        btnPrintRace.Text = "🖨  PRINT DOKUMEN"
        btnPrintRace.UseVisualStyleBackColor = False
        ' Grid Race
        pnlGridRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridRace.Controls.Add(txtSearchRace)
        pnlGridRace.Controls.Add(dgvRace)
        pnlGridRace.Location = New Point(260, 8)
        pnlGridRace.Name = "pnlGridRace"
        pnlGridRace.Size = New Size(784, 640)
        pnlGridRace.TabIndex = 1
        txtSearchRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchRace.BorderStyle = BorderStyle.FixedSingle
        txtSearchRace.Font = New Font("Segoe UI", 10.0F)
        txtSearchRace.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchRace.Location = New Point(10, 10)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(764, 34)
        txtSearchRace.TabIndex = 0
        txtSearchRace.Text = "🔍  Cari jadwal race..."
        DGVStyleAlt3.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvRace.AlternatingRowsDefaultCellStyle = DGVStyleAlt3
        dgvRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvRace.BorderStyle = BorderStyle.None
        dgvRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVStyleHdr3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleHdr3.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHdr3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVStyleHdr3.ForeColor = Color.White
        DGVStyleHdr3.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHdr3.WrapMode = DataGridViewTriState.True
        dgvRace.ColumnHeadersDefaultCellStyle = DGVStyleHdr3
        dgvRace.ColumnHeadersHeight = 36
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVStyleCell3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleCell3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DGVStyleCell3.Font = New Font("Segoe UI", 9.0F)
        DGVStyleCell3.ForeColor = Color.White
        DGVStyleCell3.Padding = New Padding(4)
        DGVStyleCell3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVStyleCell3.SelectionForeColor = Color.White
        DGVStyleCell3.WrapMode = DataGridViewTriState.False
        dgvRace.DefaultCellStyle = DGVStyleCell3
        dgvRace.EnableHeadersVisualStyles = False
        dgvRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvRace.Location = New Point(10, 50)
        dgvRace.Name = "dgvRace"
        dgvRace.RowHeadersVisible = False
        dgvRace.RowTemplate.Height = 32
        dgvRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRace.Size = New Size(764, 580)
        dgvRace.TabIndex = 1

        ' ════════════════════════════════════════════════════════════
        ' TAB HASIL  (dipertahankan persis seperti proyek asli)
        ' ════════════════════════════════════════════════════════════
        tpHasil.Controls.Add(btnSimpanHasil)
        tpHasil.Controls.Add(btnUbahHasil)
        tpHasil.Controls.Add(btnHapusHasil)
        tpHasil.Controls.Add(btnBatalHasil)
        tpHasil.Controls.Add(Label9)
        tpHasil.Controls.Add(txtPoinHasil)
        tpHasil.Controls.Add(txtGap)
        tpHasil.Controls.Add(txtPosisi)
        tpHasil.Controls.Add(txtTimHasil)
        tpHasil.Controls.Add(chkFastestLap)
        tpHasil.Controls.Add(Label7)
        tpHasil.Controls.Add(cbStatusFinish)
        tpHasil.Controls.Add(Label6)
        tpHasil.Controls.Add(Label5)
        tpHasil.Controls.Add(Label4)
        tpHasil.Controls.Add(Label3)
        tpHasil.Controls.Add(cbPembalapHasil)
        tpHasil.Controls.Add(Label2)
        tpHasil.Controls.Add(cbRaceHasil)
        tpHasil.Controls.Add(dgvHasilRace)
        tpHasil.Controls.Add(Label1)
        tpHasil.Controls.Add(cbPilihRace)
        tpHasil.Location = New Point(4, 40)
        tpHasil.Name = "tpHasil"
        tpHasil.Size = New Size(1052, 656)
        tpHasil.TabIndex = 3
        tpHasil.Text = "Hasil"
        tpHasil.UseVisualStyleBackColor = True
        cbPilihRace.FormattingEnabled = True
        cbPilihRace.Location = New Point(299, 52)
        cbPilihRace.Name = "cbPilihRace"
        cbPilihRace.Size = New Size(182, 33)
        cbPilihRace.TabIndex = 0
        Label1.AutoSize = True
        Label1.Location = New Point(299, 19)
        Label1.Name = "Label1"
        Label1.TabIndex = 1
        Label1.Text = "Pilih Race"
        dgvHasilRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHasilRace.Location = New Point(299, 96)
        dgvHasilRace.Name = "dgvHasilRace"
        dgvHasilRace.RowHeadersWidth = 62
        dgvHasilRace.Size = New Size(745, 476)
        dgvHasilRace.TabIndex = 2
        cbRaceHasil.FormattingEnabled = True
        cbRaceHasil.Location = New Point(34, 52)
        cbRaceHasil.Name = "cbRaceHasil"
        cbRaceHasil.Size = New Size(182, 33)
        cbRaceHasil.TabIndex = 3
        Label2.AutoSize = True
        Label2.Location = New Point(34, 19)
        Label2.Name = "Label2"
        Label2.TabIndex = 4
        Label2.Text = "Grand Prix"
        cbPembalapHasil.FormattingEnabled = True
        cbPembalapHasil.Location = New Point(34, 129)
        cbPembalapHasil.Name = "cbPembalapHasil"
        cbPembalapHasil.Size = New Size(182, 33)
        cbPembalapHasil.TabIndex = 5
        Label3.AutoSize = True
        Label3.Location = New Point(34, 96)
        Label3.Name = "Label3"
        Label3.TabIndex = 6
        Label3.Text = "Pembalap"
        txtTimHasil.BackColor = SystemColors.ControlDarkDark
        txtTimHasil.Location = New Point(34, 201)
        txtTimHasil.Name = "txtTimHasil"
        txtTimHasil.ReadOnly = True
        txtTimHasil.Size = New Size(150, 31)
        txtTimHasil.TabIndex = 7
        Label4.AutoSize = True
        Label4.Location = New Point(34, 173)
        Label4.Name = "Label4"
        Label4.TabIndex = 8
        Label4.Text = "Tim"
        txtPosisi.BackColor = SystemColors.ControlDarkDark
        txtPosisi.Location = New Point(34, 273)
        txtPosisi.Name = "txtPosisi"
        txtPosisi.Size = New Size(56, 31)
        txtPosisi.TabIndex = 9
        Label5.AutoSize = True
        Label5.Location = New Point(34, 245)
        Label5.Name = "Label5"
        Label5.TabIndex = 10
        Label5.Text = "Posisi"
        txtGap.BackColor = SystemColors.ControlDarkDark
        txtGap.Location = New Point(134, 273)
        txtGap.Name = "txtGap"
        txtGap.Size = New Size(150, 31)
        txtGap.TabIndex = 11
        Label6.AutoSize = True
        Label6.Location = New Point(140, 245)
        Label6.Name = "Label6"
        Label6.TabIndex = 12
        Label6.Text = "Gap"
        cbStatusFinish.FormattingEnabled = True
        cbStatusFinish.Items.AddRange(New Object() {"Finish", "DNF", "DNS"})
        cbStatusFinish.Location = New Point(37, 357)
        cbStatusFinish.Name = "cbStatusFinish"
        cbStatusFinish.Size = New Size(107, 33)
        cbStatusFinish.TabIndex = 13
        Label7.AutoSize = True
        Label7.Location = New Point(34, 329)
        Label7.Name = "Label7"
        Label7.TabIndex = 14
        Label7.Text = "Status Finish"
        chkFastestLap.AutoSize = True
        chkFastestLap.Location = New Point(159, 357)
        chkFastestLap.Name = "chkFastestLap"
        chkFastestLap.Size = New Size(125, 29)
        chkFastestLap.TabIndex = 16
        chkFastestLap.Text = "Fastest Lap"
        chkFastestLap.UseVisualStyleBackColor = True
        txtPoinHasil.BackColor = SystemColors.ControlDarkDark
        txtPoinHasil.Location = New Point(37, 438)
        txtPoinHasil.Name = "txtPoinHasil"
        txtPoinHasil.ReadOnly = True
        txtPoinHasil.Size = New Size(150, 31)
        txtPoinHasil.TabIndex = 17
        Label9.AutoSize = True
        Label9.Location = New Point(37, 410)
        Label9.Name = "Label9"
        Label9.TabIndex = 18
        Label9.Text = "Poin"
        btnSimpanHasil.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanHasil.Cursor = Cursors.Hand
        btnSimpanHasil.FlatAppearance.BorderSize = 0
        btnSimpanHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanHasil.FlatStyle = FlatStyle.Flat
        btnSimpanHasil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanHasil.ForeColor = Color.White
        btnSimpanHasil.Location = New Point(37, 495)
        btnSimpanHasil.Name = "btnSimpanHasil"
        btnSimpanHasil.Size = New Size(100, 34)
        btnSimpanHasil.TabIndex = 19
        btnSimpanHasil.Text = "SIMPAN"
        btnSimpanHasil.UseVisualStyleBackColor = False
        btnUbahHasil.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahHasil.Cursor = Cursors.Hand
        btnUbahHasil.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahHasil.FlatStyle = FlatStyle.Flat
        btnUbahHasil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahHasil.ForeColor = Color.White
        btnUbahHasil.Location = New Point(152, 495)
        btnUbahHasil.Name = "btnUbahHasil"
        btnUbahHasil.Size = New Size(100, 34)
        btnUbahHasil.TabIndex = 20
        btnUbahHasil.Text = "UBAH"
        btnUbahHasil.UseVisualStyleBackColor = False
        btnHapusHasil.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusHasil.Cursor = Cursors.Hand
        btnHapusHasil.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusHasil.FlatStyle = FlatStyle.Flat
        btnHapusHasil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusHasil.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusHasil.Location = New Point(37, 539)
        btnHapusHasil.Name = "btnHapusHasil"
        btnHapusHasil.Size = New Size(100, 34)
        btnHapusHasil.TabIndex = 21
        btnHapusHasil.Text = "HAPUS"
        btnHapusHasil.UseVisualStyleBackColor = False
        btnBatalHasil.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalHasil.Cursor = Cursors.Hand
        btnBatalHasil.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalHasil.FlatStyle = FlatStyle.Flat
        btnBatalHasil.Font = New Font("Segoe UI", 9.0F)
        btnBatalHasil.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalHasil.Location = New Point(152, 539)
        btnBatalHasil.Name = "btnBatalHasil"
        btnBatalHasil.Size = New Size(100, 34)
        btnBatalHasil.TabIndex = 22
        btnBatalHasil.Text = "BATAL"
        btnBatalHasil.UseVisualStyleBackColor = False

        ' ErrorProvider
        ErrorProvider1.ContainerControl = Me

        ' ════════════════════════════════════════════════════════════
        ' FORM
        ' ════════════════════════════════════════════════════════════
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1280, 760)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(1100, 647)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Admin Dashboard"
        WindowState = FormWindowState.Maximized
<<<<<<< HEAD
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlSidebarFoot.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarAccent As Panel
    Friend WithEvents lblLogoMark As Label
    Friend WithEvents lblMenuLabel As Label
=======

        ' ── ResumeLayout ─────────────────────────────────────────────
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebarFoot.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        tabMain.ResumeLayout(False)
        tpPembalap.ResumeLayout(False)
        pnlInputPembalap.ResumeLayout(False)
        pnlInputPembalap.PerformLayout()
        pnlActionPembalap.ResumeLayout(False)
        pnlGridPembalap.ResumeLayout(False)
        pnlGridPembalap.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        tpTim.ResumeLayout(False)
        pnlInputTim.ResumeLayout(False)
        pnlInputTim.PerformLayout()
        pnlActionTim.ResumeLayout(False)
        CType(picLogoTim, ComponentModel.ISupportInitialize).EndInit()
        pnlGridTim.ResumeLayout(False)
        pnlGridTim.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        tpRace.ResumeLayout(False)
        pnlInputRace.ResumeLayout(False)
        pnlInputRace.PerformLayout()
        pnlActionRace.ResumeLayout(False)
        pnlGridRace.ResumeLayout(False)
        pnlGridRace.PerformLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).EndInit()
        tpHasil.ResumeLayout(False)
        tpHasil.PerformLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' ════════════════════════════════════════════════════════════
    ' DEKLARASI VARIABEL (100% sinkron dengan proyek asli + cmbSirkuit)
    ' ════════════════════════════════════════════════════════════
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblAdminBadge As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarTop As Panel
    Friend WithEvents pnlSidebarFoot As Panel
    Friend WithEvents lblMenuTitle As Label
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
    Friend WithEvents btnNavPembalap As Button
    Friend WithEvents btnNavTim As Button
    Friend WithEvents btnNavRace As Button
    Friend WithEvents btnNavHasil As Button
<<<<<<< HEAD
    Friend WithEvents pnlSidebarDiv As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents pnlSidebarFoot As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pnlContent As Panel
=======
    Friend WithEvents pnlSidebarDivider As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tpPembalap As TabPage
    Friend WithEvents pnlInputPembalap As Panel
    Friend WithEvents lblPanelPembalap As Label
    Friend WithEvents lblNamaPembalap As Label
    Friend WithEvents txtNamaPembalap As TextBox
    Friend WithEvents lblNegaraPembalap As Label
    Friend WithEvents txtNegaraPembalap As TextBox
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents lblTimPembalap As Label
    Friend WithEvents cbTim As ComboBox
    Friend WithEvents pnlActionPembalap As Panel
    Friend WithEvents btnSimpanPembalap As Button
    Friend WithEvents btnUbahPembalap As Button
    Friend WithEvents btnHapusPembalap As Button
    Friend WithEvents btnBatalPembalap As Button
    Friend WithEvents btnPrintPembalap As Button
    Friend WithEvents pnlGridPembalap As Panel
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents dgvPembalap As DataGridView
    Friend WithEvents tpTim As TabPage
    Friend WithEvents pnlInputTim As Panel
    Friend WithEvents lblPanelTim As Label
    Friend WithEvents picLogoTim As PictureBox
    Friend WithEvents btnPilihLogo As Button
    Friend WithEvents lblNamaTim As Label
    Friend WithEvents txtNamaTim As TextBox
    Friend WithEvents lblNegaraTim As Label
    Friend WithEvents txtNegaraTim As TextBox
    Friend WithEvents lblMesin As Label
    Friend WithEvents txtMesin As TextBox
    Friend WithEvents lblChasis As Label
    Friend WithEvents txtChasis As TextBox
    Friend WithEvents pnlActionTim As Panel
    Friend WithEvents btnSimpanTim As Button
    Friend WithEvents btnUbahTim As Button
    Friend WithEvents btnHapusTim As Button
    Friend WithEvents btnBatalTim As Button
    Friend WithEvents btnPrintTim As Button
    Friend WithEvents pnlGridTim As Panel
    Friend WithEvents txtSearchTim As TextBox
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents tpRace As TabPage
    Friend WithEvents pnlInputRace As Panel
    Friend WithEvents lblPanelRace As Label
    Friend WithEvents lblNamaRace As Label
    Friend WithEvents txtNamaRace As TextBox
    Friend WithEvents lblLokasi As Label
    Friend WithEvents cmbSirkuit As ComboBox
    Friend WithEvents lblTanggal As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblPutaran As Label
    Friend WithEvents txtPutaran As TextBox
    Friend WithEvents pnlActionRace As Panel
    Friend WithEvents btnSimpanRace As Button
    Friend WithEvents btnUbahRace As Button
    Friend WithEvents btnHapusRace As Button
    Friend WithEvents btnBatalRace As Button
    Friend WithEvents btnPrintRace As Button
    Friend WithEvents pnlGridRace As Panel
    Friend WithEvents txtSearchRace As TextBox
    Friend WithEvents dgvRace As DataGridView
    Friend WithEvents tpHasil As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPilihRace As ComboBox
    Friend WithEvents dgvHasilRace As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbRaceHasil As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbPembalapHasil As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTimHasil As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPosisi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGap As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbStatusFinish As ComboBox
    Friend WithEvents chkFastestLap As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPoinHasil As TextBox
    Friend WithEvents btnSimpanHasil As Button
    Friend WithEvents btnUbahHasil As Button
    Friend WithEvents btnHapusHasil As Button
    Friend WithEvents btnBatalHasil As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
End Class