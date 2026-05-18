<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembalap
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        pnlGrid = New Panel()
        txtSearch = New TextBox()
        dgvPembalap = New DataGridView()
        pnlInput = New Panel()
        pnlInputAccent = New Panel()
        lblPanelInput = New Label()
        lblNamaPembalap = New Label()
        txtNamaPembalap = New TextBox()
        lblNomor = New Label()
        txtNomor = New TextBox()
        lblNegaraPembalap = New Label()
        txtNegaraPembalap = New TextBox()
        lblTimPembalap = New Label()
        cbTim = New ComboBox()
        lblFoto = New Label()
        picFotoPembalap = New PictureBox()
        btnPilihFoto = New Button()
        pnlAction = New Panel()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnPrint = New Button()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlInput.SuspendLayout()
        CType(picFotoPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlAction.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
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
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1280, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(15, 8)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(324, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(17, 40)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(144, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Pembalap"
        ' 
        ' lblAdminBadge
        ' 
        lblAdminBadge.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        lblAdminBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Location = New Point(345, 19)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(80, 26)
        lblAdminBadge.TabIndex = 3
        lblAdminBadge.Text = "● ADMIN"
        lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSidebar
        ' 
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
        ' 
        ' pnlSidebarAccent
        ' 
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Left
        pnlSidebarAccent.Location = New Point(0, 0)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(3, 668)
        pnlSidebarAccent.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(14, 18)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(100, 19)
        lblMenuTitle.TabIndex = 1
        lblMenuTitle.Text = "KELOLA DATA"
        ' 
        ' btnNavPembalap
        ' 
        btnNavPembalap.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        btnNavPembalap.Cursor = Cursors.Hand
        btnNavPembalap.FlatAppearance.BorderSize = 0
        btnNavPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(18), CByte(14))
        btnNavPembalap.FlatStyle = FlatStyle.Flat
        btnNavPembalap.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnNavPembalap.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavPembalap.Location = New Point(0, 42)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(180, 36)
        btnNavPembalap.TabIndex = 2
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnNavTim
        ' 
        btnNavTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavTim.Cursor = Cursors.Hand
        btnNavTim.FlatAppearance.BorderSize = 0
        btnNavTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavTim.FlatStyle = FlatStyle.Flat
        btnNavTim.Font = New Font("Segoe UI", 10F)
        btnNavTim.ForeColor = Color.White
        btnNavTim.Location = New Point(0, 79)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(180, 36)
        btnNavTim.TabIndex = 3
        btnNavTim.Text = "  🏁  Konstruktor"
        btnNavTim.TextAlign = ContentAlignment.MiddleLeft
        btnNavTim.UseVisualStyleBackColor = False
        ' 
        ' btnNavRace
        ' 
        btnNavRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavRace.Cursor = Cursors.Hand
        btnNavRace.FlatAppearance.BorderSize = 0
        btnNavRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavRace.FlatStyle = FlatStyle.Flat
        btnNavRace.Font = New Font("Segoe UI", 10F)
        btnNavRace.ForeColor = Color.White
        btnNavRace.Location = New Point(0, 116)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(180, 36)
        btnNavRace.TabIndex = 4
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDivider
        ' 
        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDivider.Location = New Point(14, 160)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(152, 1)
        pnlSidebarDivider.TabIndex = 5
        ' 
        ' btnNavKlasemen
        ' 
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10F)
        btnNavKlasemen.ForeColor = Color.White
        btnNavKlasemen.Location = New Point(0, 165)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(180, 36)
        btnNavKlasemen.TabIndex = 6
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        ' 
        ' btnNavHasil
        ' 
        btnNavHasil.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavHasil.Cursor = Cursors.Hand
        btnNavHasil.FlatAppearance.BorderSize = 0
        btnNavHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavHasil.FlatStyle = FlatStyle.Flat
        btnNavHasil.Font = New Font("Segoe UI", 10F)
        btnNavHasil.ForeColor = Color.White
        btnNavHasil.Location = New Point(0, 202)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(180, 36)
        btnNavHasil.TabIndex = 7
        btnNavHasil.Text = "  📊  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9F)
        btnKeluar.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        btnKeluar.Location = New Point(0, 630)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(180, 36)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "  ✕  Keluar"
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlGrid)
        pnlContent.Controls.Add(pnlInput)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(180, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(16, 12, 16, 12)
        pnlContent.Size = New Size(1100, 668)
        pnlContent.TabIndex = 2
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(dgvPembalap)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(356, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.Size = New Size(728, 644)
        pnlGrid.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearch.Location = New Point(14, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(880, 30)
        txtSearch.TabIndex = 0
        txtSearch.Text = "🔍  Cari pembalap..."
        ' 
        ' dgvPembalap
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvPembalap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPembalap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPembalap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPembalap.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvPembalap.BorderStyle = BorderStyle.None
        dgvPembalap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPembalap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPembalap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPembalap.ColumnHeadersHeight = 36
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPembalap.DefaultCellStyle = DataGridViewCellStyle3
        dgvPembalap.EnableHeadersVisualStyles = False
        dgvPembalap.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvPembalap.Location = New Point(14, 50)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.ReadOnly = True
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowHeadersWidth = 51
        dgvPembalap.RowTemplate.Height = 34
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(1408, 1134)
        dgvPembalap.TabIndex = 1
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlInput.Controls.Add(pnlInputAccent)
        pnlInput.Controls.Add(lblPanelInput)
        pnlInput.Controls.Add(lblNamaPembalap)
        pnlInput.Controls.Add(txtNamaPembalap)
        pnlInput.Controls.Add(lblNomor)
        pnlInput.Controls.Add(txtNomor)
        pnlInput.Controls.Add(lblNegaraPembalap)
        pnlInput.Controls.Add(txtNegaraPembalap)
        pnlInput.Controls.Add(lblTimPembalap)
        pnlInput.Controls.Add(cbTim)
        pnlInput.Controls.Add(lblFoto)
        pnlInput.Controls.Add(picFotoPembalap)
        pnlInput.Controls.Add(btnPilihFoto)
        pnlInput.Controls.Add(pnlAction)
        pnlInput.Dock = DockStyle.Left
        pnlInput.Location = New Point(16, 12)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(340, 644)
        pnlInput.TabIndex = 0
        ' 
        ' pnlInputAccent
        ' 
        pnlInputAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlInputAccent.Dock = DockStyle.Top
        pnlInputAccent.Location = New Point(0, 0)
        pnlInputAccent.Name = "pnlInputAccent"
        pnlInputAccent.Size = New Size(340, 3)
        pnlInputAccent.TabIndex = 0
        ' 
        ' lblPanelInput
        ' 
        lblPanelInput.AutoSize = True
        lblPanelInput.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblPanelInput.ForeColor = Color.White
        lblPanelInput.Location = New Point(14, 16)
        lblPanelInput.Name = "lblPanelInput"
        lblPanelInput.Size = New Size(166, 25)
        lblPanelInput.TabIndex = 1
        lblPanelInput.Text = "DATA PEMBALAP"
        ' 
        ' lblNamaPembalap
        ' 
        lblNamaPembalap.AutoSize = True
        lblNamaPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNamaPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNamaPembalap.Location = New Point(14, 52)
        lblNamaPembalap.Name = "lblNamaPembalap"
        lblNamaPembalap.Size = New Size(131, 19)
        lblNamaPembalap.TabIndex = 2
        lblNamaPembalap.Text = "NAMA PEMBALAP"
        ' 
        ' txtNamaPembalap
        ' 
        txtNamaPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNamaPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNamaPembalap.Font = New Font("Segoe UI", 10F)
        txtNamaPembalap.ForeColor = Color.White
        txtNamaPembalap.Location = New Point(14, 70)
        txtNamaPembalap.Name = "txtNamaPembalap"
        txtNamaPembalap.Size = New Size(312, 30)
        txtNamaPembalap.TabIndex = 3
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNomor.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNomor.Location = New Point(14, 112)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(113, 19)
        lblNomor.TabIndex = 4
        lblNomor.Text = "NOMOR BALAP"
        ' 
        ' txtNomor
        ' 
        txtNomor.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNomor.BorderStyle = BorderStyle.FixedSingle
        txtNomor.Font = New Font("Segoe UI", 10F)
        txtNomor.ForeColor = Color.White
        txtNomor.Location = New Point(14, 130)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(312, 30)
        txtNomor.TabIndex = 5
        ' 
        ' lblNegaraPembalap
        ' 
        lblNegaraPembalap.AutoSize = True
        lblNegaraPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNegaraPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNegaraPembalap.Location = New Point(14, 172)
        lblNegaraPembalap.Name = "lblNegaraPembalap"
        lblNegaraPembalap.Size = New Size(105, 19)
        lblNegaraPembalap.TabIndex = 6
        lblNegaraPembalap.Text = "NEGARA ASAL"
        ' 
        ' txtNegaraPembalap
        ' 
        txtNegaraPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNegaraPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNegaraPembalap.Font = New Font("Segoe UI", 10F)
        txtNegaraPembalap.ForeColor = Color.White
        txtNegaraPembalap.Location = New Point(14, 190)
        txtNegaraPembalap.Name = "txtNegaraPembalap"
        txtNegaraPembalap.Size = New Size(312, 30)
        txtNegaraPembalap.TabIndex = 7
        ' 
        ' lblTimPembalap
        ' 
        lblTimPembalap.AutoSize = True
        lblTimPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblTimPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblTimPembalap.Location = New Point(14, 232)
        lblTimPembalap.Name = "lblTimPembalap"
        lblTimPembalap.Size = New Size(150, 19)
        lblTimPembalap.TabIndex = 8
        lblTimPembalap.Text = "TIM / KONSTRUKTOR"
        ' 
        ' cbTim
        ' 
        cbTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbTim.DropDownStyle = ComboBoxStyle.DropDownList
        cbTim.FlatStyle = FlatStyle.Flat
        cbTim.Font = New Font("Segoe UI", 10F)
        cbTim.ForeColor = Color.White
        cbTim.Location = New Point(14, 250)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(312, 31)
        cbTim.TabIndex = 9
        ' 
        ' lblFoto
        ' 
        lblFoto.AutoSize = True
        lblFoto.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblFoto.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblFoto.Location = New Point(14, 294)
        lblFoto.Name = "lblFoto"
        lblFoto.Size = New Size(122, 19)
        lblFoto.TabIndex = 10
        lblFoto.Text = "FOTO PEMBALAP"
        ' 
        ' picFotoPembalap
        ' 
        picFotoPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        picFotoPembalap.BorderStyle = BorderStyle.FixedSingle
        picFotoPembalap.Location = New Point(14, 312)
        picFotoPembalap.Name = "picFotoPembalap"
        picFotoPembalap.Size = New Size(160, 160)
        picFotoPembalap.SizeMode = PictureBoxSizeMode.Zoom
        picFotoPembalap.TabIndex = 11
        picFotoPembalap.TabStop = False
        ' 
        ' btnPilihFoto
        ' 
        btnPilihFoto.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPilihFoto.Cursor = Cursors.Hand
        btnPilihFoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnPilihFoto.FlatStyle = FlatStyle.Flat
        btnPilihFoto.Font = New Font("Segoe UI", 9F)
        btnPilihFoto.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(215))
        btnPilihFoto.Location = New Point(185, 312)
        btnPilihFoto.Name = "btnPilihFoto"
        btnPilihFoto.Size = New Size(141, 36)
        btnPilihFoto.TabIndex = 12
        btnPilihFoto.Text = "📁  Pilih Foto..."
        btnPilihFoto.UseVisualStyleBackColor = False
        ' 
        ' pnlAction
        ' 
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
        pnlAction.Size = New Size(340, 88)
        pnlAction.TabIndex = 13
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(12, 10)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(74, 30)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(92, 10)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(62, 30)
        btnUbah.TabIndex = 1
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(160, 10)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(62, 30)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F)
        btnBatal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(195))
        btnBatal.Location = New Point(228, 10)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(62, 30)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9F)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(12, 46)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(278, 30)
        btnPrint.TabIndex = 4
        btnPrint.Text = "🖨  Cetak Laporan Pembalap"
        btnPrint.UseVisualStyleBackColor = False
        btnPrint.Visible = False
        ' 
        ' FormPembalap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        ClientSize = New Size(1280, 728)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(1024, 600)
        Name = "FormPembalap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Manajemen Pembalap"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(picFotoPembalap, ComponentModel.ISupportInitialize).EndInit()
        pnlAction.ResumeLayout(False)
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
    Friend WithEvents lblNamaPembalap As Label
    Friend WithEvents txtNamaPembalap As TextBox
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents lblNegaraPembalap As Label
    Friend WithEvents txtNegaraPembalap As TextBox
    Friend WithEvents lblTimPembalap As Label
    Friend WithEvents cbTim As ComboBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents picFotoPembalap As PictureBox
    Friend WithEvents btnPilihFoto As Button
    Friend WithEvents pnlAction As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvPembalap As DataGridView
End Class