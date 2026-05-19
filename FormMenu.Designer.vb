<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        ' ── DGV Cell Styles ──────────────────────────────────────────────────
        Dim DGVAlt1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVHdr1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVCell1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVAlt2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVHdr2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVCell2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVAlt3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVHdr3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVCell3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVAlt4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVHdr4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVCell4 As DataGridViewCellStyle = New DataGridViewCellStyle()

        ' ── Sidebar ──────────────────────────────────────────────────────────
        pnlSidebar = New Panel()
        pnlSidebarAccent = New Panel()
        pnlSidebarTop = New Panel()
        lblAppName = New Label()
        lblAppSub = New Label()
        pnlLogoSep = New Panel()
        lblMenuTitle = New Label()
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        pnlSidebarDivider = New Panel()
        btnNavKlasemen = New Button()
        btnNavHasil = New Button()
        lblMenuAdmin = New Label()
        pnlAdminDivider = New Panel()
        btnNavAdminMode = New Button()
        btnKeluar = New Button()

        ' ── Content ──────────────────────────────────────────────────────────
        pnlContent = New Panel()
        pnlContentHeader = New Panel()
        pnlContentHeaderAccent = New Panel()
        lblPageTitle = New Label()
        lblPageSub = New Label()
        lblAdminBadge = New Label()

        tabMain = New TabControl()

        ' Tab: Pembalap
        tpPembalap = New TabPage()
        txtSearchPembalap = New TextBox()
        dgvPembalap = New DataGridView()

        ' Tab: Tim
        tpTim = New TabPage()
        txtSearchTim = New TextBox()
        dgvTim = New DataGridView()

        ' Tab: Race
        tpRace = New TabPage()
        txtSearchRace = New TextBox()
        dgvRace = New DataGridView()

        ' Tab: Hasil
        tpHasil = New TabPage()
        lblPilihRace = New Label()
        cbPilihRace = New ComboBox()
        dgvHasilRace = New DataGridView()

        ' ── Suspend ──────────────────────────────────────────────────────────
        pnlSidebar.SuspendLayout()
        pnlSidebarTop.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlContentHeader.SuspendLayout()
        tabMain.SuspendLayout()
        tpPembalap.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        tpTim.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
        tpRace.SuspendLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).BeginInit()
        tpHasil.SuspendLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ════════════════════════════════════════════════════════════════════
        ' pnlSidebar  (Dock = Left, 200px)
        ' ════════════════════════════════════════════════════════════════════
        pnlSidebar.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlSidebar.Controls.Add(btnKeluar)
        pnlSidebar.Controls.Add(btnNavAdminMode)
        pnlSidebar.Controls.Add(pnlAdminDivider)
        pnlSidebar.Controls.Add(lblMenuAdmin)
        pnlSidebar.Controls.Add(btnNavHasil)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(pnlSidebarDivider)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(lblMenuTitle)
        pnlSidebar.Controls.Add(pnlLogoSep)
        pnlSidebar.Controls.Add(pnlSidebarTop)
        pnlSidebar.Controls.Add(pnlSidebarAccent)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 768)
        pnlSidebar.TabIndex = 0

        ' Thin red right-border accent
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Right
        pnlSidebarAccent.Location = New Point(197, 0)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(3, 768)
        pnlSidebarAccent.TabIndex = 0

        ' Logo area at top
        pnlSidebarTop.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(14))
        pnlSidebarTop.Controls.Add(lblAppName)
        pnlSidebarTop.Controls.Add(lblAppSub)
        pnlSidebarTop.Dock = DockStyle.Top
        pnlSidebarTop.Location = New Point(0, 0)
        pnlSidebarTop.Name = "pnlSidebarTop"
        pnlSidebarTop.Size = New Size(197, 80)
        pnlSidebarTop.TabIndex = 1

        lblAppName.AutoSize = False
        lblAppName.BackColor = Color.Transparent
        lblAppName.Dock = DockStyle.None
        lblAppName.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(14, 14)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(172, 28)
        lblAppName.Text = "F1 MANAGEMENT"
        lblAppName.TabIndex = 0

        lblAppSub.AutoSize = True
        lblAppSub.BackColor = Color.Transparent
        lblAppSub.Font = New Font("Segoe UI", 7.0F)
        lblAppSub.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAppSub.Location = New Point(15, 46)
        lblAppSub.Name = "lblAppSub"
        lblAppSub.Text = "RACE INFORMATION SYSTEM"
        lblAppSub.TabIndex = 1

        pnlLogoSep.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlLogoSep.Location = New Point(14, 82)
        pnlLogoSep.Name = "pnlLogoSep"
        pnlLogoSep.Size = New Size(172, 1)
        pnlLogoSep.TabIndex = 2

        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblMenuTitle.Location = New Point(16, 98)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Text = "MENU UTAMA"
        lblMenuTitle.TabIndex = 3

        ' ── Nav Buttons (nav item pattern) ──────────────────────────────────
        ' Helper: BackColor, ForeColor, Location, Size, Text
        btnNavPembalap.BackColor = Color.Transparent
        btnNavPembalap.Cursor = Cursors.Hand
        btnNavPembalap.FlatAppearance.BorderSize = 0
        btnNavPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(30), CByte(42))
        btnNavPembalap.FlatStyle = FlatStyle.Flat
        btnNavPembalap.Font = New Font("Segoe UI", 10.0F)
        btnNavPembalap.ForeColor = Color.FromArgb(CByte(210), CByte(210), CByte(225))
        btnNavPembalap.ImageAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.Location = New Point(0, 116)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(197, 38)
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        btnNavPembalap.TabIndex = 4

        btnNavTim.BackColor = Color.Transparent
        btnNavTim.Cursor = Cursors.Hand
        btnNavTim.FlatAppearance.BorderSize = 0
        btnNavTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(30), CByte(42))
        btnNavTim.FlatStyle = FlatStyle.Flat
        btnNavTim.Font = New Font("Segoe UI", 10.0F)
        btnNavTim.ForeColor = Color.FromArgb(CByte(210), CByte(210), CByte(225))
        btnNavTim.Location = New Point(0, 155)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(197, 38)
        btnNavTim.Text = "  🏁  Konstruktor"
        btnNavTim.TextAlign = ContentAlignment.MiddleLeft
        btnNavTim.UseVisualStyleBackColor = False
        btnNavTim.TabIndex = 5

        btnNavRace.BackColor = Color.Transparent
        btnNavRace.Cursor = Cursors.Hand
        btnNavRace.FlatAppearance.BorderSize = 0
        btnNavRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(30), CByte(42))
        btnNavRace.FlatStyle = FlatStyle.Flat
        btnNavRace.Font = New Font("Segoe UI", 10.0F)
        btnNavRace.ForeColor = Color.FromArgb(CByte(210), CByte(210), CByte(225))
        btnNavRace.Location = New Point(0, 194)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(197, 38)
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        btnNavRace.TabIndex = 6

        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(48))
        pnlSidebarDivider.Location = New Point(14, 240)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(172, 1)
        pnlSidebarDivider.TabIndex = 7

        btnNavKlasemen.BackColor = Color.Transparent
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(30), CByte(42))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10.0F)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(210), CByte(210), CByte(225))
        btnNavKlasemen.Location = New Point(0, 248)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(197, 38)
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        btnNavKlasemen.TabIndex = 8

        btnNavHasil.BackColor = Color.Transparent
        btnNavHasil.Cursor = Cursors.Hand
        btnNavHasil.FlatAppearance.BorderSize = 0
        btnNavHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(30), CByte(42))
        btnNavHasil.FlatStyle = FlatStyle.Flat
        btnNavHasil.Font = New Font("Segoe UI", 10.0F)
        btnNavHasil.ForeColor = Color.FromArgb(CByte(210), CByte(210), CByte(225))
        btnNavHasil.Location = New Point(0, 287)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(197, 38)
        btnNavHasil.Text = "  📊  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        btnNavHasil.TabIndex = 9

        ' Admin section divider
        pnlAdminDivider.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(48))
        pnlAdminDivider.Location = New Point(14, 336)
        pnlAdminDivider.Name = "pnlAdminDivider"
        pnlAdminDivider.Size = New Size(172, 1)
        pnlAdminDivider.TabIndex = 10

        lblMenuAdmin.AutoSize = True
        lblMenuAdmin.BackColor = Color.Transparent
        lblMenuAdmin.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblMenuAdmin.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblMenuAdmin.Location = New Point(16, 344)
        lblMenuAdmin.Name = "lblMenuAdmin"
        lblMenuAdmin.Text = "AKSES"
        lblMenuAdmin.TabIndex = 11

        btnNavAdminMode.BackColor = Color.FromArgb(CByte(40), CByte(10), CByte(8))
        btnNavAdminMode.Cursor = Cursors.Hand
        btnNavAdminMode.FlatAppearance.BorderSize = 0
        btnNavAdminMode.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(80), CByte(20), CByte(16))
        btnNavAdminMode.FlatStyle = FlatStyle.Flat
        btnNavAdminMode.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavAdminMode.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavAdminMode.Location = New Point(0, 362)
        btnNavAdminMode.Name = "btnNavAdminMode"
        btnNavAdminMode.Size = New Size(197, 38)
        btnNavAdminMode.Text = "  🔐  Login Admin"
        btnNavAdminMode.TextAlign = ContentAlignment.MiddleLeft
        btnNavAdminMode.UseVisualStyleBackColor = False
        btnNavAdminMode.TabIndex = 12

        ' Keluar — anchored to bottom of sidebar
        btnKeluar.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(28))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.0F)
        btnKeluar.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        btnKeluar.Location = New Point(0, 726)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(197, 40)
        btnKeluar.Text = "  ✕  Keluar"
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft
        btnKeluar.UseVisualStyleBackColor = False
        btnKeluar.TabIndex = 13

        ' ════════════════════════════════════════════════════════════════════
        ' pnlContent  (Dock = Fill)
        ' ════════════════════════════════════════════════════════════════════
        pnlContent.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(32))
        pnlContent.Controls.Add(tabMain)
        pnlContent.Controls.Add(pnlContentHeader)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(200, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.TabIndex = 1

        ' ── Content Header (thin title bar inside content area) ──────────────
        pnlContentHeader.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        pnlContentHeader.Controls.Add(pnlContentHeaderAccent)
        pnlContentHeader.Controls.Add(lblPageTitle)
        pnlContentHeader.Controls.Add(lblPageSub)
        pnlContentHeader.Controls.Add(lblAdminBadge)
        pnlContentHeader.Dock = DockStyle.Top
        pnlContentHeader.Location = New Point(0, 0)
        pnlContentHeader.Name = "pnlContentHeader"
        pnlContentHeader.Size = New Size(1080, 56)
        pnlContentHeader.TabIndex = 0

        pnlContentHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlContentHeaderAccent.Dock = DockStyle.Bottom
        pnlContentHeaderAccent.Location = New Point(0, 54)
        pnlContentHeaderAccent.Name = "pnlContentHeaderAccent"
        pnlContentHeaderAccent.Size = New Size(1080, 2)
        pnlContentHeaderAccent.TabIndex = 0

        lblPageTitle.AutoSize = True
        lblPageTitle.BackColor = Color.Transparent
        lblPageTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.White
        lblPageTitle.Location = New Point(16, 8)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Text = "DASHBOARD"
        lblPageTitle.TabIndex = 1

        lblPageSub.AutoSize = True
        lblPageSub.BackColor = Color.Transparent
        lblPageSub.Font = New Font("Segoe UI", 8.0F)
        lblPageSub.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPageSub.Location = New Point(18, 36)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Text = "Data Pembalap, Tim, dan Race"
        lblPageSub.TabIndex = 2

        lblAdminBadge.BackColor = Color.FromArgb(CByte(15), CByte(40), CByte(15))
        lblAdminBadge.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.FromArgb(CByte(80), CByte(210), CByte(80))
        lblAdminBadge.Location = New Point(960, 16)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(90, 24)
        lblAdminBadge.Text = "● PUBLIC"
        lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter
        lblAdminBadge.TabIndex = 3

        ' ════════════════════════════════════════════════════════════════════
        ' tabMain  (Dock = Fill, hidden tabs — nav driven by sidebar)
        ' ════════════════════════════════════════════════════════════════════
        tabMain.Appearance = TabAppearance.FlatButtons
        tabMain.Controls.Add(tpPembalap)
        tabMain.Controls.Add(tpTim)
        tabMain.Controls.Add(tpRace)
        tabMain.Controls.Add(tpHasil)
        tabMain.Dock = DockStyle.Fill
        tabMain.ItemSize = New Size(0, 1)        ' effectively hide tab headers
        tabMain.Location = New Point(0, 56)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(1080, 712)
        tabMain.TabIndex = 1

        ' ── tpPembalap ───────────────────────────────────────────────────────
        tpPembalap.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(32))
        tpPembalap.Controls.Add(txtSearchPembalap)
        tpPembalap.Controls.Add(dgvPembalap)
        tpPembalap.Location = New Point(4, 5)
        tpPembalap.Name = "tpPembalap"
        tpPembalap.Padding = New Padding(14, 12, 14, 12)
        tpPembalap.Size = New Size(1072, 703)
        tpPembalap.TabIndex = 0
        tpPembalap.Text = "Pembalap"

        txtSearchPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10.0F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(130), CByte(130), CByte(145))
        txtSearchPembalap.Location = New Point(14, 12)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(1040, 30)
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
        txtSearchPembalap.TabIndex = 0

        DGVAlt1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(50))
        dgvPembalap.AlternatingRowsDefaultCellStyle = DGVAlt1
        dgvPembalap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPembalap.BackgroundColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        dgvPembalap.BorderStyle = BorderStyle.None
        dgvPembalap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPembalap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVHdr1.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVHdr1.ForeColor = Color.White
        DGVHdr1.SelectionBackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr1.SelectionForeColor = Color.White
        DGVHdr1.WrapMode = DataGridViewTriState.True
        dgvPembalap.ColumnHeadersDefaultCellStyle = DGVHdr1
        dgvPembalap.ColumnHeadersHeight = 36
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVCell1.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        DGVCell1.Font = New Font("Segoe UI", 9.0F)
        DGVCell1.ForeColor = Color.White
        DGVCell1.Padding = New Padding(4)
        DGVCell1.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVCell1.SelectionForeColor = Color.White
        dgvPembalap.DefaultCellStyle = DGVCell1
        dgvPembalap.EnableHeadersVisualStyles = False
        dgvPembalap.GridColor = Color.FromArgb(CByte(48), CByte(48), CByte(62))
        dgvPembalap.Location = New Point(14, 50)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.ReadOnly = True
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowTemplate.Height = 34
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPembalap.Size = New Size(1040, 641)
        dgvPembalap.TabIndex = 1

        ' ── tpTim ────────────────────────────────────────────────────────────
        tpTim.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(32))
        tpTim.Controls.Add(txtSearchTim)
        tpTim.Controls.Add(dgvTim)
        tpTim.Location = New Point(4, 5)
        tpTim.Name = "tpTim"
        tpTim.Padding = New Padding(14, 12, 14, 12)
        tpTim.Size = New Size(1072, 703)
        tpTim.TabIndex = 1
        tpTim.Text = "Tim"

        txtSearchTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchTim.BorderStyle = BorderStyle.FixedSingle
        txtSearchTim.Font = New Font("Segoe UI", 10.0F)
        txtSearchTim.ForeColor = Color.FromArgb(CByte(130), CByte(130), CByte(145))
        txtSearchTim.Location = New Point(14, 12)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(1040, 30)
        txtSearchTim.Text = "🔍  Cari tim / konstruktor..."
        txtSearchTim.TabIndex = 0

        DGVAlt2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(50))
        dgvTim.AlternatingRowsDefaultCellStyle = DGVAlt2
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVHdr2.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVHdr2.ForeColor = Color.White
        DGVHdr2.SelectionBackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr2.SelectionForeColor = Color.White
        DGVHdr2.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DGVHdr2
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVCell2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        DGVCell2.Font = New Font("Segoe UI", 9.0F)
        DGVCell2.ForeColor = Color.White
        DGVCell2.Padding = New Padding(4)
        DGVCell2.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVCell2.SelectionForeColor = Color.White
        dgvTim.DefaultCellStyle = DGVCell2
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(48), CByte(48), CByte(62))
        dgvTim.Location = New Point(14, 50)
        dgvTim.Name = "dgvTim"
        dgvTim.ReadOnly = True
        dgvTim.RowHeadersVisible = False
        dgvTim.RowTemplate.Height = 34
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTim.Size = New Size(1040, 641)
        dgvTim.TabIndex = 1

        ' ── tpRace ───────────────────────────────────────────────────────────
        tpRace.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(32))
        tpRace.Controls.Add(txtSearchRace)
        tpRace.Controls.Add(dgvRace)
        tpRace.Location = New Point(4, 5)
        tpRace.Name = "tpRace"
        tpRace.Padding = New Padding(14, 12, 14, 12)
        tpRace.Size = New Size(1072, 703)
        tpRace.TabIndex = 2
        tpRace.Text = "Race"

        txtSearchRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchRace.BorderStyle = BorderStyle.FixedSingle
        txtSearchRace.Font = New Font("Segoe UI", 10.0F)
        txtSearchRace.ForeColor = Color.FromArgb(CByte(130), CByte(130), CByte(145))
        txtSearchRace.Location = New Point(14, 12)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(1040, 30)
        txtSearchRace.Text = "🔍  Cari jadwal race..."
        txtSearchRace.TabIndex = 0

        DGVAlt3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(50))
        dgvRace.AlternatingRowsDefaultCellStyle = DGVAlt3
        dgvRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRace.BackgroundColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        dgvRace.BorderStyle = BorderStyle.None
        dgvRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVHdr3.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVHdr3.ForeColor = Color.White
        DGVHdr3.SelectionBackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr3.SelectionForeColor = Color.White
        DGVHdr3.WrapMode = DataGridViewTriState.True
        dgvRace.ColumnHeadersDefaultCellStyle = DGVHdr3
        dgvRace.ColumnHeadersHeight = 36
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVCell3.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        DGVCell3.Font = New Font("Segoe UI", 9.0F)
        DGVCell3.ForeColor = Color.White
        DGVCell3.Padding = New Padding(4)
        DGVCell3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVCell3.SelectionForeColor = Color.White
        dgvRace.DefaultCellStyle = DGVCell3
        dgvRace.EnableHeadersVisualStyles = False
        dgvRace.GridColor = Color.FromArgb(CByte(48), CByte(48), CByte(62))
        dgvRace.Location = New Point(14, 50)
        dgvRace.Name = "dgvRace"
        dgvRace.ReadOnly = True
        dgvRace.RowHeadersVisible = False
        dgvRace.RowTemplate.Height = 34
        dgvRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRace.Size = New Size(1040, 641)
        dgvRace.TabIndex = 1

        ' ── tpHasil ──────────────────────────────────────────────────────────
        tpHasil.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(32))
        tpHasil.Controls.Add(lblPilihRace)
        tpHasil.Controls.Add(cbPilihRace)
        tpHasil.Controls.Add(dgvHasilRace)
        tpHasil.Location = New Point(4, 5)
        tpHasil.Name = "tpHasil"
        tpHasil.Padding = New Padding(14, 12, 14, 12)
        tpHasil.Size = New Size(1072, 703)
        tpHasil.TabIndex = 3
        tpHasil.Text = "Hasil Race"

        lblPilihRace.AutoSize = True
        lblPilihRace.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblPilihRace.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPilihRace.Location = New Point(14, 14)
        lblPilihRace.Name = "lblPilihRace"
        lblPilihRace.Text = "PILIH SIRKUIT / RACE"
        lblPilihRace.TabIndex = 0

        cbPilihRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbPilihRace.DropDownStyle = ComboBoxStyle.DropDownList
        cbPilihRace.FlatStyle = FlatStyle.Flat
        cbPilihRace.Font = New Font("Segoe UI", 10.0F)
        cbPilihRace.ForeColor = Color.White
        cbPilihRace.Location = New Point(14, 32)
        cbPilihRace.Name = "cbPilihRace"
        cbPilihRace.Size = New Size(400, 30)
        cbPilihRace.TabIndex = 1

        DGVAlt4.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(50))
        dgvHasilRace.AlternatingRowsDefaultCellStyle = DGVAlt4
        dgvHasilRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHasilRace.BackgroundColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        dgvHasilRace.BorderStyle = BorderStyle.None
        dgvHasilRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvHasilRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVHdr4.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVHdr4.ForeColor = Color.White
        DGVHdr4.SelectionBackColor = Color.FromArgb(CByte(12), CByte(12), CByte(18))
        DGVHdr4.SelectionForeColor = Color.White
        DGVHdr4.WrapMode = DataGridViewTriState.True
        dgvHasilRace.ColumnHeadersDefaultCellStyle = DGVHdr4
        dgvHasilRace.ColumnHeadersHeight = 36
        dgvHasilRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVCell4.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(38))
        DGVCell4.Font = New Font("Segoe UI", 9.0F)
        DGVCell4.ForeColor = Color.White
        DGVCell4.Padding = New Padding(4)
        DGVCell4.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVCell4.SelectionForeColor = Color.White
        dgvHasilRace.DefaultCellStyle = DGVCell4
        dgvHasilRace.EnableHeadersVisualStyles = False
        dgvHasilRace.GridColor = Color.FromArgb(CByte(48), CByte(48), CByte(62))
        dgvHasilRace.Location = New Point(14, 70)
        dgvHasilRace.Name = "dgvHasilRace"
        dgvHasilRace.ReadOnly = True
        dgvHasilRace.RowHeadersVisible = False
        dgvHasilRace.RowTemplate.Height = 34
        dgvHasilRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHasilRace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHasilRace.Size = New Size(1040, 621)
        dgvHasilRace.TabIndex = 2

        ' ════════════════════════════════════════════════════════════════════
        ' FormMenu
        ' ════════════════════════════════════════════════════════════════════
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(32))
        ClientSize = New Size(1280, 768)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        MinimumSize = New Size(900, 600)
        Name = "FormMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management System"
        WindowState = FormWindowState.Maximized

        ' ── Resume ───────────────────────────────────────────────────────────
        pnlSidebarTop.ResumeLayout(False)
        pnlSidebarTop.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContentHeader.ResumeLayout(False)
        pnlContentHeader.PerformLayout()
        pnlContent.ResumeLayout(False)
        tabMain.ResumeLayout(False)
        tpPembalap.ResumeLayout(False)
        tpPembalap.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        tpTim.ResumeLayout(False)
        tpTim.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        tpRace.ResumeLayout(False)
        tpRace.PerformLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).EndInit()
        tpHasil.ResumeLayout(False)
        tpHasil.PerformLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' ── Field declarations ────────────────────────────────────────────────
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarAccent As Panel
    Friend WithEvents pnlSidebarTop As Panel
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblAppSub As Label
    Friend WithEvents pnlLogoSep As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnNavPembalap As Button
    Friend WithEvents btnNavTim As Button
    Friend WithEvents btnNavRace As Button
    Friend WithEvents pnlSidebarDivider As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents btnNavHasil As Button
    Friend WithEvents pnlAdminDivider As Panel
    Friend WithEvents lblMenuAdmin As Label
    Friend WithEvents btnNavAdminMode As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlContentHeader As Panel
    Friend WithEvents pnlContentHeaderAccent As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblPageSub As Label
    Friend WithEvents lblAdminBadge As Label
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tpPembalap As TabPage
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents dgvPembalap As DataGridView
    Friend WithEvents tpTim As TabPage
    Friend WithEvents txtSearchTim As TextBox
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents tpRace As TabPage
    Friend WithEvents txtSearchRace As TextBox
    Friend WithEvents dgvRace As DataGridView
    Friend WithEvents tpHasil As TabPage
    Friend WithEvents lblPilihRace As Label
    Friend WithEvents cbPilihRace As ComboBox
    Friend WithEvents dgvHasilRace As DataGridView
End Class