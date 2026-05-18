<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasilRace
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
        Dim DGVStyleAlt As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleHeader As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DGVStyleCell As DataGridViewCellStyle = New DataGridViewCellStyle()

        ' ── Controls ─────────────────────────────────────────────────────────
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblAdminBadge = New Label()

        pnlSidebar = New Panel()
        pnlSidebarAccent = New Panel()
        lblMenuTitle = New Label()
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        pnlSidebarDivider = New Panel()
        btnNavKlasemen = New Button()
        btnNavHasil = New Button()
        btnKeluar = New Button()

        pnlContent = New Panel()

        ' Left: Input Panel
        pnlInput = New Panel()
        pnlInputAccent = New Panel()
        lblPanelInput = New Label()

        ' Filter section
        lblSirkuit = New Label()
        cbSirkuit = New ComboBox()

        ' Divider
        pnlInputSep = New Panel()
        lblInputDetail = New Label()

        ' Input fields
        lblPembalap = New Label()
        cbPembalap = New ComboBox()
        lblTim = New Label()
        cbTim = New ComboBox()
        lblPosisi = New Label()
        nudPosisi = New NumericUpDown()
        lblPoin = New Label()
        nudPoin = New NumericUpDown()
        lblGap = New Label()
        txtGap = New TextBox()
        lblStatus = New Label()
        cbStatusFinish = New ComboBox()
        chkFastestLap = New CheckBox()

        ' Action buttons
        pnlAction = New Panel()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnPrint = New Button()

        ' Right: Grid Panel
        pnlGrid = New Panel()
        pnlGridHeader = New Panel()
        lblGridTitle = New Label()
        lblGridSub = New Label()
        txtSearch = New TextBox()
        dgvHasilRace = New DataGridView()

        ' ── Suspend ──────────────────────────────────────────────────────────
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlInput.SuspendLayout()
        pnlAction.SuspendLayout()
        pnlGrid.SuspendLayout()
        pnlGridHeader.SuspendLayout()
        CType(nudPosisi, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPoin, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ════════════════════════════════════════════════════════════════════
        ' pnlHeader
        ' ════════════════════════════════════════════════════════════════════
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblAdminBadge)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1280, 60)
        pnlHeader.TabIndex = 0

        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1280, 2)
        pnlHeaderAccent.TabIndex = 0

        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(15, 8)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        lblHeaderTitle.TabIndex = 1

        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(17, 40)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Text = "Input & Tampilan Hasil Balapan"
        lblHeaderSub.TabIndex = 2

        lblAdminBadge.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        lblAdminBadge.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Location = New Point(1150, 17)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(80, 26)
        lblAdminBadge.Text = "● ADMIN"
        lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter
        lblAdminBadge.TabIndex = 3

        ' ════════════════════════════════════════════════════════════════════
        ' pnlSidebar
        ' ════════════════════════════════════════════════════════════════════
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(pnlSidebarAccent)
        pnlSidebar.Controls.Add(lblMenuTitle)
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(pnlSidebarDivider)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(btnNavHasil)
        pnlSidebar.Controls.Add(btnKeluar)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(180, 668)
        pnlSidebar.TabIndex = 1

        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Left
        pnlSidebarAccent.Location = New Point(0, 0)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(3, 668)
        pnlSidebarAccent.TabIndex = 0

        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(14, 18)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Text = "KELOLA DATA"
        lblMenuTitle.TabIndex = 1

        btnNavPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavPembalap.Cursor = Cursors.Hand
        btnNavPembalap.FlatAppearance.BorderSize = 0
        btnNavPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavPembalap.FlatStyle = FlatStyle.Flat
        btnNavPembalap.Font = New Font("Segoe UI", 10.0F)
        btnNavPembalap.ForeColor = Color.White
        btnNavPembalap.Location = New Point(0, 42)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(180, 36)
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        btnNavPembalap.TabIndex = 2

        btnNavTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavTim.Cursor = Cursors.Hand
        btnNavTim.FlatAppearance.BorderSize = 0
        btnNavTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavTim.FlatStyle = FlatStyle.Flat
        btnNavTim.Font = New Font("Segoe UI", 10.0F)
        btnNavTim.ForeColor = Color.White
        btnNavTim.Location = New Point(0, 79)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(180, 36)
        btnNavTim.Text = "  🏁  Konstruktor"
        btnNavTim.TextAlign = ContentAlignment.MiddleLeft
        btnNavTim.UseVisualStyleBackColor = False
        btnNavTim.TabIndex = 3

        btnNavRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavRace.Cursor = Cursors.Hand
        btnNavRace.FlatAppearance.BorderSize = 0
        btnNavRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavRace.FlatStyle = FlatStyle.Flat
        btnNavRace.Font = New Font("Segoe UI", 10.0F)
        btnNavRace.ForeColor = Color.White
        btnNavRace.Location = New Point(0, 116)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(180, 36)
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        btnNavRace.TabIndex = 4

        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDivider.Location = New Point(14, 160)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(152, 1)
        pnlSidebarDivider.TabIndex = 5

        btnNavKlasemen.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10.0F)
        btnNavKlasemen.ForeColor = Color.White
        btnNavKlasemen.Location = New Point(0, 165)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(180, 36)
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        btnNavKlasemen.TabIndex = 6

        ' Hasil Race — active/highlighted
        btnNavHasil.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        btnNavHasil.Cursor = Cursors.Hand
        btnNavHasil.FlatAppearance.BorderSize = 0
        btnNavHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(18), CByte(14))
        btnNavHasil.FlatStyle = FlatStyle.Flat
        btnNavHasil.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavHasil.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavHasil.Location = New Point(0, 202)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(180, 36)
        btnNavHasil.Text = "  📊  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        btnNavHasil.TabIndex = 7

        btnKeluar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.0F)
        btnKeluar.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        btnKeluar.Location = New Point(0, 630)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(180, 36)
        btnKeluar.Text = "  ✕  Keluar"
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft
        btnKeluar.UseVisualStyleBackColor = False
        btnKeluar.TabIndex = 8

        ' ════════════════════════════════════════════════════════════════════
        ' pnlContent  (Dock = Fill)
        ' ════════════════════════════════════════════════════════════════════
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlGrid)
        pnlContent.Controls.Add(pnlInput)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(180, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(16, 12, 16, 12)
        pnlContent.TabIndex = 2

        ' ════════════════════════════════════════════════════════════════════
        ' pnlInput — Left column (360px)
        ' ════════════════════════════════════════════════════════════════════
        pnlInput.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlInput.Controls.Add(pnlInputAccent)
        pnlInput.Controls.Add(lblPanelInput)
        pnlInput.Controls.Add(lblSirkuit)
        pnlInput.Controls.Add(cbSirkuit)
        pnlInput.Controls.Add(pnlInputSep)
        pnlInput.Controls.Add(lblInputDetail)
        pnlInput.Controls.Add(lblPembalap)
        pnlInput.Controls.Add(cbPembalap)
        pnlInput.Controls.Add(lblTim)
        pnlInput.Controls.Add(cbTim)
        pnlInput.Controls.Add(lblPosisi)
        pnlInput.Controls.Add(nudPosisi)
        pnlInput.Controls.Add(lblPoin)
        pnlInput.Controls.Add(nudPoin)
        pnlInput.Controls.Add(lblGap)
        pnlInput.Controls.Add(txtGap)
        pnlInput.Controls.Add(lblStatus)
        pnlInput.Controls.Add(cbStatusFinish)
        pnlInput.Controls.Add(chkFastestLap)
        pnlInput.Controls.Add(pnlAction)
        pnlInput.Dock = DockStyle.Left
        pnlInput.Location = New Point(16, 12)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(360, 644)
        pnlInput.TabIndex = 0

        pnlInputAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlInputAccent.Dock = DockStyle.Top
        pnlInputAccent.Location = New Point(0, 0)
        pnlInputAccent.Name = "pnlInputAccent"
        pnlInputAccent.Size = New Size(360, 3)
        pnlInputAccent.TabIndex = 0

        lblPanelInput.AutoSize = True
        lblPanelInput.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPanelInput.ForeColor = Color.White
        lblPanelInput.Location = New Point(14, 16)
        lblPanelInput.Name = "lblPanelInput"
        lblPanelInput.Text = "INPUT HASIL RACE"
        lblPanelInput.TabIndex = 1

        ' ── Sirkuit filter ───────────────────────────────────────────────────
        lblSirkuit.AutoSize = True
        lblSirkuit.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblSirkuit.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblSirkuit.Location = New Point(14, 52)
        lblSirkuit.Name = "lblSirkuit"
        lblSirkuit.Text = "SIRKUIT / RACE"
        lblSirkuit.TabIndex = 2

        cbSirkuit.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbSirkuit.DropDownStyle = ComboBoxStyle.DropDownList
        cbSirkuit.FlatStyle = FlatStyle.Flat
        cbSirkuit.Font = New Font("Segoe UI", 10.0F)
        cbSirkuit.ForeColor = Color.White
        cbSirkuit.Location = New Point(14, 70)
        cbSirkuit.Name = "cbSirkuit"
        cbSirkuit.Size = New Size(332, 30)
        cbSirkuit.TabIndex = 3

        ' Section divider inside input panel
        pnlInputSep.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlInputSep.Location = New Point(14, 114)
        pnlInputSep.Name = "pnlInputSep"
        pnlInputSep.Size = New Size(332, 1)
        pnlInputSep.TabIndex = 4

        lblInputDetail.AutoSize = True
        lblInputDetail.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblInputDetail.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblInputDetail.Location = New Point(14, 122)
        lblInputDetail.Name = "lblInputDetail"
        lblInputDetail.Text = "DETAIL HASIL PEMBALAP"
        lblInputDetail.TabIndex = 5

        ' ── Pembalap ─────────────────────────────────────────────────────────
        lblPembalap.AutoSize = True
        lblPembalap.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPembalap.Location = New Point(14, 140)
        lblPembalap.Name = "lblPembalap"
        lblPembalap.Text = "PEMBALAP"
        lblPembalap.TabIndex = 6

        cbPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbPembalap.DropDownStyle = ComboBoxStyle.DropDownList
        cbPembalap.FlatStyle = FlatStyle.Flat
        cbPembalap.Font = New Font("Segoe UI", 10.0F)
        cbPembalap.ForeColor = Color.White
        cbPembalap.Location = New Point(14, 158)
        cbPembalap.Name = "cbPembalap"
        cbPembalap.Size = New Size(332, 30)
        cbPembalap.TabIndex = 7

        ' ── Tim ──────────────────────────────────────────────────────────────
        lblTim.AutoSize = True
        lblTim.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblTim.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblTim.Location = New Point(14, 200)
        lblTim.Name = "lblTim"
        lblTim.Text = "TIM / KONSTRUKTOR"
        lblTim.TabIndex = 8

        cbTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbTim.DropDownStyle = ComboBoxStyle.DropDownList
        cbTim.FlatStyle = FlatStyle.Flat
        cbTim.Font = New Font("Segoe UI", 10.0F)
        cbTim.ForeColor = Color.White
        cbTim.Location = New Point(14, 218)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(332, 30)
        cbTim.TabIndex = 9

        ' ── Posisi & Poin (side by side) ─────────────────────────────────────
        lblPosisi.AutoSize = True
        lblPosisi.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblPosisi.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPosisi.Location = New Point(14, 262)
        lblPosisi.Name = "lblPosisi"
        lblPosisi.Text = "POSISI FINISH"
        lblPosisi.TabIndex = 10

        nudPosisi.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        nudPosisi.BorderStyle = BorderStyle.FixedSingle
        nudPosisi.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        nudPosisi.ForeColor = Color.White
        nudPosisi.Location = New Point(14, 280)
        nudPosisi.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudPosisi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudPosisi.Name = "nudPosisi"
        nudPosisi.Size = New Size(156, 34)
        nudPosisi.TextAlign = HorizontalAlignment.Center
        nudPosisi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        nudPosisi.TabIndex = 11

        lblPoin.AutoSize = True
        lblPoin.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblPoin.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPoin.Location = New Point(190, 262)
        lblPoin.Name = "lblPoin"
        lblPoin.Text = "POIN DIDAPAT"
        lblPoin.TabIndex = 12

        nudPoin.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        nudPoin.BorderStyle = BorderStyle.FixedSingle
        nudPoin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        nudPoin.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        nudPoin.Location = New Point(190, 280)
        nudPoin.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        nudPoin.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        nudPoin.Name = "nudPoin"
        nudPoin.Size = New Size(156, 34)
        nudPoin.TextAlign = HorizontalAlignment.Center
        nudPoin.Value = New Decimal(New Integer() {25, 0, 0, 0})
        nudPoin.TabIndex = 13

        ' ── Gap ──────────────────────────────────────────────────────────────
        lblGap.AutoSize = True
        lblGap.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblGap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblGap.Location = New Point(14, 328)
        lblGap.Name = "lblGap"
        lblGap.Text = "GAP / SELISIH WAKTU"
        lblGap.TabIndex = 14

        txtGap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtGap.BorderStyle = BorderStyle.FixedSingle
        txtGap.Font = New Font("Segoe UI", 10.0F)
        txtGap.ForeColor = Color.White
        txtGap.Location = New Point(14, 346)
        txtGap.Name = "txtGap"
        txtGap.PlaceholderText = "Contoh: +1.234s / WINNER"
        txtGap.Size = New Size(332, 30)
        txtGap.TabIndex = 15

        ' ── Status Finish ─────────────────────────────────────────────────────
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblStatus.Location = New Point(14, 390)
        lblStatus.Name = "lblStatus"
        lblStatus.Text = "STATUS FINISH"
        lblStatus.TabIndex = 16

        cbStatusFinish.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbStatusFinish.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatusFinish.FlatStyle = FlatStyle.Flat
        cbStatusFinish.Font = New Font("Segoe UI", 10.0F)
        cbStatusFinish.ForeColor = Color.White
        cbStatusFinish.Items.AddRange(New Object() {"Finish", "DNF", "DNS", "DSQ", "Retired"})
        cbStatusFinish.Location = New Point(14, 408)
        cbStatusFinish.Name = "cbStatusFinish"
        cbStatusFinish.Size = New Size(332, 30)
        cbStatusFinish.TabIndex = 17

        ' ── Fastest Lap checkbox ─────────────────────────────────────────────
        chkFastestLap.BackColor = Color.Transparent
        chkFastestLap.Font = New Font("Segoe UI", 9.0F)
        chkFastestLap.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(215))
        chkFastestLap.Location = New Point(14, 450)
        chkFastestLap.Name = "chkFastestLap"
        chkFastestLap.Size = New Size(200, 24)
        chkFastestLap.Text = "  ⚡ Fastest Lap (+1 Poin)"
        chkFastestLap.UseVisualStyleBackColor = False
        chkFastestLap.TabIndex = 18

        ' ════════════════════════════════════════════════════════════════════
        ' pnlAction — Bottom of input panel
        ' ════════════════════════════════════════════════════════════════════
        pnlAction.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlAction.Controls.Add(btnSimpan)
        pnlAction.Controls.Add(btnUbah)
        pnlAction.Controls.Add(btnHapus)
        pnlAction.Controls.Add(btnBatal)
        pnlAction.Controls.Add(btnPrint)
        pnlAction.Dock = DockStyle.Bottom
        pnlAction.Location = New Point(0, 556)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(12, 10, 12, 10)
        pnlAction.Size = New Size(360, 88)
        pnlAction.TabIndex = 19

        ' Simpan — merah, selalu visible (untuk memilih/lihat juga)
        btnSimpan.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(12, 10)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(78, 30)
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        btnSimpan.Visible = False       ' hidden — admin only
        btnSimpan.TabIndex = 0

        btnUbah.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.0F)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(96, 10)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(66, 30)
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        btnUbah.Visible = False         ' hidden — admin only
        btnUbah.TabIndex = 1

        btnHapus.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(168, 10)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(66, 30)
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        btnHapus.Visible = False        ' hidden — admin only
        btnHapus.TabIndex = 2

        btnBatal.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F)
        btnBatal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(195))
        btnBatal.Location = New Point(240, 10)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(66, 30)
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        btnBatal.Visible = False        ' hidden — admin only
        btnBatal.TabIndex = 3

        ' Print — hidden by default
        btnPrint.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9.0F)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(12, 46)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(294, 30)
        btnPrint.Text = "🖨  Cetak Laporan Hasil Race"
        btnPrint.UseVisualStyleBackColor = False
        btnPrint.Visible = False        ' hidden — admin only
        btnPrint.TabIndex = 4

        ' ════════════════════════════════════════════════════════════════════
        ' pnlGrid — Right column (fills remaining width)
        ' ════════════════════════════════════════════════════════════════════
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(pnlGridHeader)
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(dgvHasilRace)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(392, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.TabIndex = 1

        ' ── Grid header strip ─────────────────────────────────────────────────
        pnlGridHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlGridHeader.Controls.Add(lblGridTitle)
        pnlGridHeader.Controls.Add(lblGridSub)
        pnlGridHeader.Dock = DockStyle.Top
        pnlGridHeader.Location = New Point(14, 12)
        pnlGridHeader.Name = "pnlGridHeader"
        pnlGridHeader.Size = New Size(840, 46)
        pnlGridHeader.TabIndex = 0

        lblGridTitle.AutoSize = True
        lblGridTitle.BackColor = Color.Transparent
        lblGridTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblGridTitle.ForeColor = Color.White
        lblGridTitle.Location = New Point(10, 6)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Text = "HASIL BALAPAN"
        lblGridTitle.TabIndex = 0

        lblGridSub.AutoSize = True
        lblGridSub.BackColor = Color.Transparent
        lblGridSub.Font = New Font("Segoe UI", 8.0F)
        lblGridSub.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblGridSub.Location = New Point(12, 28)
        lblGridSub.Name = "lblGridSub"
        lblGridSub.Text = "Pilih sirkuit di kiri untuk memfilter data"
        lblGridSub.TabIndex = 1

        txtSearch.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearch.Location = New Point(14, 66)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(840, 30)
        txtSearch.Text = "🔍  Cari pembalap / tim..."
        txtSearch.TabIndex = 1

        ' ── DataGridView ─────────────────────────────────────────────────────
        DGVStyleAlt.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvHasilRace.AlternatingRowsDefaultCellStyle = DGVStyleAlt
        dgvHasilRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHasilRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvHasilRace.BorderStyle = BorderStyle.None
        dgvHasilRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvHasilRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        DGVStyleHeader.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DGVStyleHeader.ForeColor = Color.White
        DGVStyleHeader.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DGVStyleHeader.SelectionForeColor = Color.White
        DGVStyleHeader.WrapMode = DataGridViewTriState.True
        dgvHasilRace.ColumnHeadersDefaultCellStyle = DGVStyleHeader
        dgvHasilRace.ColumnHeadersHeight = 36
        dgvHasilRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        DGVStyleCell.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGVStyleCell.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DGVStyleCell.Font = New Font("Segoe UI", 9.0F)
        DGVStyleCell.ForeColor = Color.White
        DGVStyleCell.Padding = New Padding(4)
        DGVStyleCell.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DGVStyleCell.SelectionForeColor = Color.White
        DGVStyleCell.WrapMode = DataGridViewTriState.False
        dgvHasilRace.DefaultCellStyle = DGVStyleCell

        dgvHasilRace.EnableHeadersVisualStyles = False
        dgvHasilRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvHasilRace.Location = New Point(14, 104)
        dgvHasilRace.Name = "dgvHasilRace"
        dgvHasilRace.ReadOnly = True
        dgvHasilRace.RowHeadersVisible = False
        dgvHasilRace.RowHeadersWidth = 51
        dgvHasilRace.RowTemplate.Height = 34
        dgvHasilRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHasilRace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHasilRace.Size = New Size(840, 528)
        dgvHasilRace.TabIndex = 2

        ' ════════════════════════════════════════════════════════════════════
        ' FormHasilRace
        ' ════════════════════════════════════════════════════════════════════
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        ClientSize = New Size(1280, 728)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(1024, 600)
        Name = "FormHasilRace"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Hasil Balapan"
        WindowState = FormWindowState.Maximized

        ' ── Resume ───────────────────────────────────────────────────────────
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        pnlAction.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        pnlGridHeader.ResumeLayout(False)
        pnlGridHeader.PerformLayout()
        CType(nudPosisi, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPoin, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' ── Field declarations ────────────────────────────────────────────────
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblAdminBadge As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarAccent As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnNavPembalap As Button
    Friend WithEvents btnNavTim As Button
    Friend WithEvents btnNavRace As Button
    Friend WithEvents pnlSidebarDivider As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents btnNavHasil As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlInputAccent As Panel
    Friend WithEvents lblPanelInput As Label
    Friend WithEvents lblSirkuit As Label
    Friend WithEvents cbSirkuit As ComboBox
    Friend WithEvents pnlInputSep As Panel
    Friend WithEvents lblInputDetail As Label
    Friend WithEvents lblPembalap As Label
    Friend WithEvents cbPembalap As ComboBox
    Friend WithEvents lblTim As Label
    Friend WithEvents cbTim As ComboBox
    Friend WithEvents lblPosisi As Label
    Friend WithEvents nudPosisi As NumericUpDown
    Friend WithEvents lblPoin As Label
    Friend WithEvents nudPoin As NumericUpDown
    Friend WithEvents lblGap As Label
    Friend WithEvents txtGap As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatusFinish As ComboBox
    Friend WithEvents chkFastestLap As CheckBox
    Friend WithEvents pnlAction As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents pnlGridHeader As Panel
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents lblGridSub As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvHasilRace As DataGridView
End Class