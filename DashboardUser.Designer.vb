<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardUser
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblViewerBadge = New Label()
        btnLoginAdmin = New Button()
        pnlSidebar = New Panel()
        btnNavHasil = New Button()
        pnlSidebarAccent = New Panel()
        lblMenuTitle = New Label()
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        pnlDivider = New Panel()
        btnNavKlasemen = New Button()
        lblReadOnly = New Label()
        pnlContent = New Panel()
        tabMain = New TabControl()
        tpPembalap = New TabPage()
        txtSearchPembalap = New TextBox()
        dgvPembalap = New DataGridView()
        tpTim = New TabPage()
        txtSearchTim = New TextBox()
        dgvTim = New DataGridView()
        tpRace = New TabPage()
        txtSearchRace = New TextBox()
        dgvRace = New DataGridView()
        tpHasil = New TabPage()
        dgvHasilRace = New DataGridView()
        Label1 = New Label()
        cbPilihRace = New ComboBox()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
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
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblViewerBadge)
        pnlHeader.Controls.Add(btnLoginAdmin)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1024, 56)
        pnlHeader.TabIndex = 0
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 54)
        pnlHeaderAccent.Margin = New Padding(2)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1024, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(10, 0)
        lblHeaderTitle.Margin = New Padding(2, 0, 2, 0)
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
        lblHeaderSub.Location = New Point(12, 33)
        lblHeaderSub.Margin = New Padding(2, 0, 2, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(245, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Dashboard Publik — Hanya Lihat Data"
        ' 
        ' lblViewerBadge
        ' 
        lblViewerBadge.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        lblViewerBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblViewerBadge.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(180))
        lblViewerBadge.Location = New Point(730, 15)
        lblViewerBadge.Margin = New Padding(2, 0, 2, 0)
        lblViewerBadge.Name = "lblViewerBadge"
        lblViewerBadge.Size = New Size(70, 26)
        lblViewerBadge.TabIndex = 3
        lblViewerBadge.Text = "● PUBLIC"
        lblViewerBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLoginAdmin
        ' 
        btnLoginAdmin.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnLoginAdmin.Cursor = Cursors.Hand
        btnLoginAdmin.FlatAppearance.BorderColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnLoginAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnLoginAdmin.FlatStyle = FlatStyle.Flat
        btnLoginAdmin.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnLoginAdmin.ForeColor = Color.White
        btnLoginAdmin.Location = New Point(814, 13)
        btnLoginAdmin.Margin = New Padding(2)
        btnLoginAdmin.Name = "btnLoginAdmin"
        btnLoginAdmin.Size = New Size(196, 30)
        btnLoginAdmin.TabIndex = 10
        btnLoginAdmin.Text = " ADMIN LOGIN"
        btnLoginAdmin.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(btnNavHasil)
        pnlSidebar.Controls.Add(pnlSidebarAccent)
        pnlSidebar.Controls.Add(lblMenuTitle)
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(pnlDivider)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(lblReadOnly)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 56)
        pnlSidebar.Margin = New Padding(2)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(160, 552)
        pnlSidebar.TabIndex = 1
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
        btnNavHasil.Location = New Point(7, 198)
        btnNavHasil.Margin = New Padding(2)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(141, 35)
        btnNavHasil.TabIndex = 8
        btnNavHasil.Text = "  📅  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarAccent
        ' 
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Location = New Point(0, 0)
        pnlSidebarAccent.Margin = New Padding(2)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(3, 552)
        pnlSidebarAccent.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(12, 16)
        lblMenuTitle.Margin = New Padding(2, 0, 2, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(88, 19)
        lblMenuTitle.TabIndex = 1
        lblMenuTitle.Text = "LIHAT DATA"
        ' 
        ' btnNavPembalap
        ' 
        btnNavPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavPembalap.Cursor = Cursors.Hand
        btnNavPembalap.FlatAppearance.BorderSize = 0
        btnNavPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavPembalap.FlatStyle = FlatStyle.Flat
        btnNavPembalap.Font = New Font("Segoe UI", 10F)
        btnNavPembalap.ForeColor = Color.White
        btnNavPembalap.Location = New Point(0, 38)
        btnNavPembalap.Margin = New Padding(2)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(160, 35)
        btnNavPembalap.TabIndex = 1
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
        btnNavTim.Location = New Point(0, 74)
        btnNavTim.Margin = New Padding(2)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(160, 35)
        btnNavTim.TabIndex = 2
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
        btnNavRace.Location = New Point(0, 109)
        btnNavRace.Margin = New Padding(2)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(160, 35)
        btnNavRace.TabIndex = 3
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlDivider.Location = New Point(12, 154)
        pnlDivider.Margin = New Padding(2)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(136, 1)
        pnlDivider.TabIndex = 4
        ' 
        ' btnNavKlasemen
        ' 
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavKlasemen.Location = New Point(0, 159)
        btnNavKlasemen.Margin = New Padding(2)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(160, 35)
        btnNavKlasemen.TabIndex = 5
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        ' 
        ' lblReadOnly
        ' 
        lblReadOnly.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        lblReadOnly.Font = New Font("Segoe UI", 7F, FontStyle.Italic)
        lblReadOnly.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblReadOnly.Location = New Point(8, 520)
        lblReadOnly.Margin = New Padding(2, 0, 2, 0)
        lblReadOnly.Name = "lblReadOnly"
        lblReadOnly.Size = New Size(144, 24)
        lblReadOnly.TabIndex = 6
        lblReadOnly.Text = "Mode: Hanya Lihat Data"
        lblReadOnly.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlContent.Controls.Add(tabMain)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(160, 56)
        pnlContent.Margin = New Padding(2)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(864, 552)
        pnlContent.TabIndex = 2
        ' 
        ' tabMain
        ' 
        tabMain.Appearance = TabAppearance.FlatButtons
        tabMain.Controls.Add(tpPembalap)
        tabMain.Controls.Add(tpTim)
        tabMain.Controls.Add(tpRace)
        tabMain.Controls.Add(tpHasil)
        tabMain.Dock = DockStyle.Fill
        tabMain.ItemSize = New Size(130, 36)
        tabMain.Location = New Point(0, 0)
        tabMain.Margin = New Padding(2)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(864, 552)
        tabMain.TabIndex = 0
        ' 
        ' tpPembalap
        ' 
        tpPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpPembalap.Controls.Add(txtSearchPembalap)
        tpPembalap.Controls.Add(dgvPembalap)
        tpPembalap.Location = New Point(4, 40)
        tpPembalap.Margin = New Padding(2)
        tpPembalap.Name = "tpPembalap"
        tpPembalap.Size = New Size(856, 508)
        tpPembalap.TabIndex = 0
        tpPembalap.Text = "  Pembalap  "
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchPembalap.Location = New Point(8, 8)
        txtSearchPembalap.Margin = New Padding(2)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(840, 30)
        txtSearchPembalap.TabIndex = 0
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
        ' 
        ' dgvPembalap
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvPembalap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
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
        dgvPembalap.Location = New Point(9, 42)
        dgvPembalap.Margin = New Padding(2)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.ReadOnly = True
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowHeadersWidth = 51
        dgvPembalap.RowTemplate.Height = 34
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(840, 462)
        dgvPembalap.TabIndex = 1
        ' 
        ' tpTim
        ' 
        tpTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpTim.Controls.Add(txtSearchTim)
        tpTim.Controls.Add(dgvTim)
        tpTim.Location = New Point(4, 40)
        tpTim.Margin = New Padding(2)
        tpTim.Name = "tpTim"
        tpTim.Size = New Size(856, 508)
        tpTim.TabIndex = 1
        tpTim.Text = "  Konstruktor  "
        ' 
        ' txtSearchTim
        ' 
        txtSearchTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchTim.BorderStyle = BorderStyle.FixedSingle
        txtSearchTim.Font = New Font("Segoe UI", 10F)
        txtSearchTim.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchTim.Location = New Point(8, 8)
        txtSearchTim.Margin = New Padding(2)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(840, 30)
        txtSearchTim.TabIndex = 0
        txtSearchTim.Text = "🔍  Cari tim..."
        ' 
        ' dgvTim
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvTim.DefaultCellStyle = DataGridViewCellStyle6
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvTim.Location = New Point(8, 44)
        dgvTim.Margin = New Padding(2)
        dgvTim.Name = "dgvTim"
        dgvTim.ReadOnly = True
        dgvTim.RowHeadersVisible = False
        dgvTim.RowHeadersWidth = 51
        dgvTim.RowTemplate.Height = 34
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Size = New Size(840, 462)
        dgvTim.TabIndex = 1
        ' 
        ' tpRace
        ' 
        tpRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpRace.Controls.Add(txtSearchRace)
        tpRace.Controls.Add(dgvRace)
        tpRace.Location = New Point(4, 40)
        tpRace.Margin = New Padding(2)
        tpRace.Name = "tpRace"
        tpRace.Size = New Size(856, 508)
        tpRace.TabIndex = 2
        tpRace.Text = "  Jadwal Race  "
        ' 
        ' txtSearchRace
        ' 
        txtSearchRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchRace.BorderStyle = BorderStyle.FixedSingle
        txtSearchRace.Font = New Font("Segoe UI", 10F)
        txtSearchRace.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchRace.Location = New Point(8, 8)
        txtSearchRace.Margin = New Padding(2)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(840, 30)
        txtSearchRace.TabIndex = 0
        txtSearchRace.Text = "🔍  Cari jadwal race..."
        ' 
        ' dgvRace
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvRace.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvRace.BorderStyle = BorderStyle.None
        dgvRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvRace.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvRace.ColumnHeadersHeight = 36
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.Padding = New Padding(4)
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvRace.DefaultCellStyle = DataGridViewCellStyle9
        dgvRace.EnableHeadersVisualStyles = False
        dgvRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvRace.Location = New Point(8, 44)
        dgvRace.Margin = New Padding(2)
        dgvRace.Name = "dgvRace"
        dgvRace.ReadOnly = True
        dgvRace.RowHeadersVisible = False
        dgvRace.RowHeadersWidth = 51
        dgvRace.RowTemplate.Height = 34
        dgvRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRace.Size = New Size(840, 462)
        dgvRace.TabIndex = 1
        ' 
        ' tpHasil
        ' 
        tpHasil.Controls.Add(dgvHasilRace)
        tpHasil.Controls.Add(Label1)
        tpHasil.Controls.Add(cbPilihRace)
        tpHasil.Location = New Point(4, 40)
        tpHasil.Margin = New Padding(2)
        tpHasil.Name = "tpHasil"
        tpHasil.Padding = New Padding(2)
        tpHasil.Size = New Size(856, 508)
        tpHasil.TabIndex = 3
        tpHasil.Text = "Hasil"
        tpHasil.UseVisualStyleBackColor = True
        ' 
        ' dgvHasilRace
        ' 
        dgvHasilRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHasilRace.Location = New Point(23, 77)
        dgvHasilRace.Margin = New Padding(2)
        dgvHasilRace.Name = "dgvHasilRace"
        dgvHasilRace.RowHeadersWidth = 62
        dgvHasilRace.Size = New Size(739, 381)
        dgvHasilRace.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 4
        Label1.Text = "Pilih Race"
        ' 
        ' cbPilihRace
        ' 
        cbPilihRace.FormattingEnabled = True
        cbPilihRace.Location = New Point(23, 42)
        cbPilihRace.Margin = New Padding(2)
        cbPilihRace.Name = "cbPilihRace"
        cbPilihRace.Size = New Size(274, 28)
        cbPilihRace.TabIndex = 3
        ' 
        ' DashboardUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1024, 608)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Margin = New Padding(2)
        MinimumSize = New Size(884, 527)
        Name = "DashboardUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Dashboard Publik"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
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

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblViewerBadge As Label
    Friend WithEvents btnLoginAdmin As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarAccent As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnNavPembalap As Button
    Friend WithEvents btnNavTim As Button
    Friend WithEvents btnNavRace As Button
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents lblReadOnly As Label
    Friend WithEvents pnlContent As Panel
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
    Friend WithEvents dgvHasilRace As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPilihRace As ComboBox
    Friend WithEvents btnNavHasil As Button
End Class