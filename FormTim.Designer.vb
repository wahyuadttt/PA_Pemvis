<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTim
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
<<<<<<< HEAD
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
=======
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTim))
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
<<<<<<< HEAD
=======
        lblAdminBadge = New Label()
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
        dgvTim = New DataGridView()
        pnlInput = New Panel()
        pnlInputAccent = New Panel()
        lblPanelInput = New Label()
        lblNamaTim = New Label()
        txtNamaTim = New TextBox()
        lblNegaraTim = New Label()
        txtNegaraTim = New TextBox()
        lblMesin = New Label()
        txtMesin = New TextBox()
        lblChasis = New Label()
        txtChasis = New TextBox()
        lblLogo = New Label()
        picLogoTim = New PictureBox()
        btnPilihLogo = New Button()
        pnlAction = New Panel()
        btnSimpanTim = New Button()
        btnUbahTim = New Button()
        btnHapusTim = New Button()
        btnBatal = New Button()
        btnPrintTim = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
        pnlInput.SuspendLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).BeginInit()
        pnlAction.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
<<<<<<< HEAD
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1280, 60)
=======
        pnlHeader.Margin = New Padding(4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1600, 75)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlHeader.TabIndex = 0
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
<<<<<<< HEAD
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1280, 2)
=======
        pnlHeaderAccent.Location = New Point(0, 73)
        pnlHeaderAccent.Margin = New Padding(4)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1600, 2)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
<<<<<<< HEAD
        lblHeaderTitle.Location = New Point(15, 8)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(324, 37)
=======
        lblHeaderTitle.Location = New Point(19, 10)
        lblHeaderTitle.Margin = New Padding(4, 0, 4, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(388, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
<<<<<<< HEAD
        lblHeaderSub.Location = New Point(17, 40)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(193, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Tim / Konstruktor"
        ' 
=======
        lblHeaderSub.Location = New Point(21, 50)
        lblHeaderSub.Margin = New Padding(4, 0, 4, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(218, 21)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Tim / Konstruktor"
        ' 
        ' lblAdminBadge
        ' 
        lblAdminBadge.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        lblAdminBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Location = New Point(19, 15)
        lblAdminBadge.Margin = New Padding(4, 0, 4, 0)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(189, 32)
        lblAdminBadge.TabIndex = 3
        lblAdminBadge.Text = "● ADMIN"
        lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(pnlSidebarAccent)
        pnlSidebar.Controls.Add(lblMenuTitle)
        pnlSidebar.Controls.Add(btnNavPembalap)
<<<<<<< HEAD
=======
        pnlSidebar.Controls.Add(lblAdminBadge)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(pnlSidebarDivider)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(btnNavHasil)
        pnlSidebar.Controls.Add(btnKeluar)
        pnlSidebar.Dock = DockStyle.Left
<<<<<<< HEAD
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(180, 668)
=======
        pnlSidebar.Location = New Point(0, 75)
        pnlSidebar.Margin = New Padding(4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(225, 835)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlSidebar.TabIndex = 1
        ' 
        ' pnlSidebarAccent
        ' 
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Left
        pnlSidebarAccent.Location = New Point(0, 0)
<<<<<<< HEAD
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(3, 668)
=======
        pnlSidebarAccent.Margin = New Padding(4)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(4, 835)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlSidebarAccent.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
<<<<<<< HEAD
        lblMenuTitle.Location = New Point(17, 4)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(100, 19)
=======
        lblMenuTitle.Location = New Point(18, 66)
        lblMenuTitle.Margin = New Padding(4, 0, 4, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(113, 21)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblMenuTitle.TabIndex = 1
        lblMenuTitle.Text = "KELOLA DATA"
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
<<<<<<< HEAD
        btnNavPembalap.Location = New Point(3, 28)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(180, 36)
=======
        btnNavPembalap.Location = New Point(0, 96)
        btnNavPembalap.Margin = New Padding(4)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(225, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavPembalap.TabIndex = 2
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnNavTim
        ' 
        btnNavTim.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        btnNavTim.Cursor = Cursors.Hand
        btnNavTim.FlatAppearance.BorderSize = 0
        btnNavTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(18), CByte(14))
        btnNavTim.FlatStyle = FlatStyle.Flat
        btnNavTim.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnNavTim.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
<<<<<<< HEAD
        btnNavTim.Location = New Point(3, 65)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(180, 36)
=======
        btnNavTim.Location = New Point(0, 142)
        btnNavTim.Margin = New Padding(4)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(225, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
<<<<<<< HEAD
        btnNavRace.Location = New Point(3, 102)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(180, 36)
=======
        btnNavRace.Location = New Point(0, 189)
        btnNavRace.Margin = New Padding(4)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(225, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnNavRace.TabIndex = 4
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDivider
        ' 
        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
<<<<<<< HEAD
        pnlSidebarDivider.Location = New Point(17, 146)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(152, 1)
=======
        pnlSidebarDivider.Location = New Point(18, 244)
        pnlSidebarDivider.Margin = New Padding(4)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(190, 1)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
<<<<<<< HEAD
        btnNavKlasemen.Location = New Point(3, 151)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(180, 36)
=======
        btnNavKlasemen.Location = New Point(0, 250)
        btnNavKlasemen.Margin = New Padding(4)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(225, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
<<<<<<< HEAD
        btnNavHasil.Location = New Point(3, 188)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(180, 36)
=======
        btnNavHasil.Location = New Point(0, 296)
        btnNavHasil.Margin = New Padding(4)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(225, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
<<<<<<< HEAD
        btnKeluar.Location = New Point(0, 630)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(180, 36)
=======
        btnKeluar.Location = New Point(0, 788)
        btnKeluar.Margin = New Padding(4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(225, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
<<<<<<< HEAD
        pnlContent.Location = New Point(180, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(16, 12, 16, 12)
        pnlContent.Size = New Size(1100, 668)
=======
        pnlContent.Location = New Point(225, 75)
        pnlContent.Margin = New Padding(4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20, 15, 20, 15)
        pnlContent.Size = New Size(1375, 835)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlContent.TabIndex = 2
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(dgvTim)
        pnlGrid.Dock = DockStyle.Fill
<<<<<<< HEAD
        pnlGrid.Location = New Point(356, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.Size = New Size(728, 644)
=======
        pnlGrid.Location = New Point(445, 15)
        pnlGrid.Margin = New Padding(4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(18, 15, 18, 15)
        pnlGrid.Size = New Size(910, 805)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlGrid.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
<<<<<<< HEAD
        txtSearch.Location = New Point(14, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(880, 30)
=======
        txtSearch.Location = New Point(18, 15)
        txtSearch.Margin = New Padding(4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1100, 34)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        txtSearch.TabIndex = 0
        txtSearch.Text = "🔍  Cari tim / konstruktor..."
        ' 
        ' dgvTim
        ' 
<<<<<<< HEAD
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
=======
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        dgvTim.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
<<<<<<< HEAD
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
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
        dgvTim.Location = New Point(14, 50)
=======
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTim.DefaultCellStyle = DataGridViewCellStyle3
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvTim.Location = New Point(18, 62)
        dgvTim.Margin = New Padding(4)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        dgvTim.Name = "dgvTim"
        dgvTim.ReadOnly = True
        dgvTim.RowHeadersVisible = False
        dgvTim.RowHeadersWidth = 51
        dgvTim.RowTemplate.Height = 34
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
<<<<<<< HEAD
        dgvTim.Size = New Size(1408, 1134)
=======
        dgvTim.Size = New Size(1760, 1418)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        dgvTim.TabIndex = 1
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlInput.Controls.Add(pnlInputAccent)
        pnlInput.Controls.Add(lblPanelInput)
        pnlInput.Controls.Add(lblNamaTim)
        pnlInput.Controls.Add(txtNamaTim)
        pnlInput.Controls.Add(lblNegaraTim)
        pnlInput.Controls.Add(txtNegaraTim)
        pnlInput.Controls.Add(lblMesin)
        pnlInput.Controls.Add(txtMesin)
        pnlInput.Controls.Add(lblChasis)
        pnlInput.Controls.Add(txtChasis)
        pnlInput.Controls.Add(lblLogo)
        pnlInput.Controls.Add(picLogoTim)
        pnlInput.Controls.Add(btnPilihLogo)
        pnlInput.Controls.Add(pnlAction)
        pnlInput.Dock = DockStyle.Left
<<<<<<< HEAD
        pnlInput.Location = New Point(16, 12)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(340, 644)
=======
        pnlInput.Location = New Point(20, 15)
        pnlInput.Margin = New Padding(4)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(425, 805)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlInput.TabIndex = 0
        ' 
        ' pnlInputAccent
        ' 
        pnlInputAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlInputAccent.Dock = DockStyle.Top
        pnlInputAccent.Location = New Point(0, 0)
<<<<<<< HEAD
        pnlInputAccent.Name = "pnlInputAccent"
        pnlInputAccent.Size = New Size(340, 3)
=======
        pnlInputAccent.Margin = New Padding(4)
        pnlInputAccent.Name = "pnlInputAccent"
        pnlInputAccent.Size = New Size(425, 4)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlInputAccent.TabIndex = 0
        ' 
        ' lblPanelInput
        ' 
        lblPanelInput.AutoSize = True
        lblPanelInput.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblPanelInput.ForeColor = Color.White
<<<<<<< HEAD
        lblPanelInput.Location = New Point(14, 16)
        lblPanelInput.Name = "lblPanelInput"
        lblPanelInput.Size = New Size(101, 25)
=======
        lblPanelInput.Location = New Point(18, 20)
        lblPanelInput.Margin = New Padding(4, 0, 4, 0)
        lblPanelInput.Name = "lblPanelInput"
        lblPanelInput.Size = New Size(115, 30)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblPanelInput.TabIndex = 1
        lblPanelInput.Text = "DATA TIM"
        ' 
        ' lblNamaTim
        ' 
        lblNamaTim.AutoSize = True
        lblNamaTim.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNamaTim.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
<<<<<<< HEAD
        lblNamaTim.Location = New Point(14, 52)
        lblNamaTim.Name = "lblNamaTim"
        lblNamaTim.Size = New Size(82, 19)
=======
        lblNamaTim.Location = New Point(18, 65)
        lblNamaTim.Margin = New Padding(4, 0, 4, 0)
        lblNamaTim.Name = "lblNamaTim"
        lblNamaTim.Size = New Size(93, 21)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblNamaTim.TabIndex = 2
        lblNamaTim.Text = "NAMA TIM"
        ' 
        ' txtNamaTim
        ' 
        txtNamaTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNamaTim.BorderStyle = BorderStyle.FixedSingle
        txtNamaTim.Font = New Font("Segoe UI", 10F)
        txtNamaTim.ForeColor = Color.White
<<<<<<< HEAD
        txtNamaTim.Location = New Point(14, 70)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(312, 30)
=======
        txtNamaTim.Location = New Point(18, 88)
        txtNamaTim.Margin = New Padding(4)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(390, 34)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        txtNamaTim.TabIndex = 3
        ' 
        ' lblNegaraTim
        ' 
        lblNegaraTim.AutoSize = True
        lblNegaraTim.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNegaraTim.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
<<<<<<< HEAD
        lblNegaraTim.Location = New Point(14, 112)
        lblNegaraTim.Name = "lblNegaraTim"
        lblNegaraTim.Size = New Size(109, 19)
=======
        lblNegaraTim.Location = New Point(18, 140)
        lblNegaraTim.Margin = New Padding(4, 0, 4, 0)
        lblNegaraTim.Name = "lblNegaraTim"
        lblNegaraTim.Size = New Size(123, 21)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblNegaraTim.TabIndex = 4
        lblNegaraTim.Text = "NEGARA BASIS"
        ' 
        ' txtNegaraTim
        ' 
        txtNegaraTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNegaraTim.BorderStyle = BorderStyle.FixedSingle
        txtNegaraTim.Font = New Font("Segoe UI", 10F)
        txtNegaraTim.ForeColor = Color.White
<<<<<<< HEAD
        txtNegaraTim.Location = New Point(14, 130)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(312, 30)
=======
        txtNegaraTim.Location = New Point(18, 162)
        txtNegaraTim.Margin = New Padding(4)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(390, 34)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        txtNegaraTim.TabIndex = 5
        ' 
        ' lblMesin
        ' 
        lblMesin.AutoSize = True
        lblMesin.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMesin.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
<<<<<<< HEAD
        lblMesin.Location = New Point(14, 172)
        lblMesin.Name = "lblMesin"
        lblMesin.Size = New Size(52, 19)
=======
        lblMesin.Location = New Point(18, 215)
        lblMesin.Margin = New Padding(4, 0, 4, 0)
        lblMesin.Name = "lblMesin"
        lblMesin.Size = New Size(61, 21)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblMesin.TabIndex = 6
        lblMesin.Text = "MESIN"
        ' 
        ' txtMesin
        ' 
        txtMesin.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtMesin.BorderStyle = BorderStyle.FixedSingle
        txtMesin.Font = New Font("Segoe UI", 10F)
        txtMesin.ForeColor = Color.White
<<<<<<< HEAD
        txtMesin.Location = New Point(14, 190)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(312, 30)
=======
        txtMesin.Location = New Point(18, 238)
        txtMesin.Margin = New Padding(4)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(390, 34)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        txtMesin.TabIndex = 7
        ' 
        ' lblChasis
        ' 
        lblChasis.AutoSize = True
        lblChasis.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblChasis.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
<<<<<<< HEAD
        lblChasis.Location = New Point(14, 232)
        lblChasis.Name = "lblChasis"
        lblChasis.Size = New Size(59, 19)
=======
        lblChasis.Location = New Point(18, 290)
        lblChasis.Margin = New Padding(4, 0, 4, 0)
        lblChasis.Name = "lblChasis"
        lblChasis.Size = New Size(66, 21)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblChasis.TabIndex = 8
        lblChasis.Text = "CHASIS"
        ' 
        ' txtChasis
        ' 
        txtChasis.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtChasis.BorderStyle = BorderStyle.FixedSingle
        txtChasis.Font = New Font("Segoe UI", 10F)
        txtChasis.ForeColor = Color.White
<<<<<<< HEAD
        txtChasis.Location = New Point(14, 250)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(312, 30)
=======
        txtChasis.Location = New Point(18, 312)
        txtChasis.Margin = New Padding(4)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(390, 34)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        txtChasis.TabIndex = 9
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLogo.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
<<<<<<< HEAD
        lblLogo.Location = New Point(14, 294)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(77, 19)
=======
        lblLogo.Location = New Point(18, 368)
        lblLogo.Margin = New Padding(4, 0, 4, 0)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(86, 21)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        lblLogo.TabIndex = 10
        lblLogo.Text = "LOGO TIM"
        ' 
        ' picLogoTim
        ' 
        picLogoTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        picLogoTim.BorderStyle = BorderStyle.FixedSingle
<<<<<<< HEAD
        picLogoTim.Location = New Point(14, 312)
        picLogoTim.Name = "picLogoTim"
        picLogoTim.Size = New Size(160, 160)
=======
        picLogoTim.Location = New Point(18, 390)
        picLogoTim.Margin = New Padding(4)
        picLogoTim.Name = "picLogoTim"
        picLogoTim.Size = New Size(200, 200)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        picLogoTim.SizeMode = PictureBoxSizeMode.Zoom
        picLogoTim.TabIndex = 11
        picLogoTim.TabStop = False
        ' 
        ' btnPilihLogo
        ' 
        btnPilihLogo.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPilihLogo.Cursor = Cursors.Hand
        btnPilihLogo.FlatAppearance.BorderColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnPilihLogo.FlatStyle = FlatStyle.Flat
        btnPilihLogo.Font = New Font("Segoe UI", 9F)
        btnPilihLogo.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(215))
<<<<<<< HEAD
        btnPilihLogo.Location = New Point(185, 312)
        btnPilihLogo.Name = "btnPilihLogo"
        btnPilihLogo.Size = New Size(141, 36)
=======
        btnPilihLogo.Location = New Point(231, 390)
        btnPilihLogo.Margin = New Padding(4)
        btnPilihLogo.Name = "btnPilihLogo"
        btnPilihLogo.Size = New Size(176, 45)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnPilihLogo.TabIndex = 12
        btnPilihLogo.Text = "📁  Pilih Logo..."
        btnPilihLogo.UseVisualStyleBackColor = False
        ' 
        ' pnlAction
        ' 
        pnlAction.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlAction.Controls.Add(btnSimpanTim)
        pnlAction.Controls.Add(btnUbahTim)
        pnlAction.Controls.Add(btnHapusTim)
        pnlAction.Controls.Add(btnBatal)
        pnlAction.Controls.Add(btnPrintTim)
        pnlAction.Dock = DockStyle.Bottom
<<<<<<< HEAD
        pnlAction.Location = New Point(0, 556)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(12, 10, 12, 10)
        pnlAction.Size = New Size(340, 88)
=======
        pnlAction.Location = New Point(0, 695)
        pnlAction.Margin = New Padding(4)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(15, 12, 15, 12)
        pnlAction.Size = New Size(425, 110)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        pnlAction.TabIndex = 13
        ' 
        ' btnSimpanTim
        ' 
        btnSimpanTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanTim.Cursor = Cursors.Hand
        btnSimpanTim.FlatAppearance.BorderSize = 0
        btnSimpanTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnSimpanTim.FlatStyle = FlatStyle.Flat
        btnSimpanTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanTim.ForeColor = Color.White
<<<<<<< HEAD
        btnSimpanTim.Location = New Point(12, 10)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(74, 30)
=======
        btnSimpanTim.Location = New Point(15, 12)
        btnSimpanTim.Margin = New Padding(4)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(92, 38)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnSimpanTim.TabIndex = 0
        btnSimpanTim.Text = "Simpan"
        btnSimpanTim.UseVisualStyleBackColor = False
        ' 
        ' btnUbahTim
        ' 
        btnUbahTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnUbahTim.Cursor = Cursors.Hand
        btnUbahTim.FlatAppearance.BorderSize = 0
        btnUbahTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnUbahTim.FlatStyle = FlatStyle.Flat
        btnUbahTim.Font = New Font("Segoe UI", 9F)
        btnUbahTim.ForeColor = Color.White
<<<<<<< HEAD
        btnUbahTim.Location = New Point(92, 10)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(62, 30)
=======
        btnUbahTim.Location = New Point(115, 12)
        btnUbahTim.Margin = New Padding(4)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(78, 38)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnUbahTim.TabIndex = 1
        btnUbahTim.Text = "Ubah"
        btnUbahTim.UseVisualStyleBackColor = False
        ' 
        ' btnHapusTim
        ' 
        btnHapusTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnHapusTim.Cursor = Cursors.Hand
        btnHapusTim.FlatAppearance.BorderSize = 0
        btnHapusTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnHapusTim.FlatStyle = FlatStyle.Flat
        btnHapusTim.Font = New Font("Segoe UI", 9F)
        btnHapusTim.ForeColor = Color.White
<<<<<<< HEAD
        btnHapusTim.Location = New Point(160, 10)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(62, 30)
=======
        btnHapusTim.Location = New Point(200, 12)
        btnHapusTim.Margin = New Padding(4)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(78, 38)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnHapusTim.TabIndex = 2
        btnHapusTim.Text = "Hapus"
        btnHapusTim.UseVisualStyleBackColor = False
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
<<<<<<< HEAD
        btnBatal.Location = New Point(228, 10)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(62, 30)
=======
        btnBatal.Location = New Point(285, 12)
        btnBatal.Margin = New Padding(4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(78, 38)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnPrintTim
        ' 
        btnPrintTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrintTim.Cursor = Cursors.Hand
        btnPrintTim.FlatAppearance.BorderSize = 0
        btnPrintTim.FlatStyle = FlatStyle.Flat
        btnPrintTim.Font = New Font("Segoe UI", 9F)
        btnPrintTim.ForeColor = Color.White
<<<<<<< HEAD
        btnPrintTim.Location = New Point(12, 46)
        btnPrintTim.Name = "btnPrintTim"
        btnPrintTim.Size = New Size(278, 30)
=======
        btnPrintTim.Location = New Point(15, 58)
        btnPrintTim.Margin = New Padding(4)
        btnPrintTim.Name = "btnPrintTim"
        btnPrintTim.Size = New Size(348, 38)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        btnPrintTim.TabIndex = 4
        btnPrintTim.Text = "🖨  Cetak Laporan Tim"
        btnPrintTim.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' FormTim
        ' 
<<<<<<< HEAD
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        ClientSize = New Size(1280, 728)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(1023, 598)
=======
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        ClientSize = New Size(1600, 910)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Margin = New Padding(4)
        MinimumSize = New Size(1274, 736)
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
        Name = "FormTim"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Manajemen Tim"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).EndInit()
        pnlAction.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
<<<<<<< HEAD
=======
    Friend WithEvents lblAdminBadge As Label
>>>>>>> 929940e1962ded39aa7db0384f7a7f6f9ec51b0d
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
    Friend WithEvents lblNamaTim As Label
    Friend WithEvents txtNamaTim As TextBox
    Friend WithEvents lblNegaraTim As Label
    Friend WithEvents txtNegaraTim As TextBox
    Friend WithEvents lblMesin As Label
    Friend WithEvents txtMesin As TextBox
    Friend WithEvents lblChasis As Label
    Friend WithEvents txtChasis As TextBox
    Friend WithEvents lblLogo As Label
    Friend WithEvents picLogoTim As PictureBox
    Friend WithEvents btnPilihLogo As Button
    Friend WithEvents pnlAction As Panel
    Friend WithEvents btnSimpanTim As Button
    Friend WithEvents btnUbahTim As Button
    Friend WithEvents btnHapusTim As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPrintTim As Button
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class