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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembalap))
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
        txtSearchPembalap = New TextBox()
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
        btnPrintPembalap = New Button()
        btnSimpanPembalap = New Button()
        btnUbahPembalap = New Button()
        btnHapusPembalap = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlInput.SuspendLayout()
        CType(picFotoPembalap, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Controls.Add(lblAdminBadge)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1600, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 73)
        pnlHeaderAccent.Margin = New Padding(4)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1600, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(19, 10)
        lblHeaderTitle.Margin = New Padding(4, 0, 4, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(388, 45)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(21, 50)
        lblHeaderSub.Margin = New Padding(4, 0, 4, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(164, 21)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Pembalap"
        ' 
        ' lblAdminBadge
        ' 
        lblAdminBadge.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        lblAdminBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Location = New Point(431, 24)
        lblAdminBadge.Margin = New Padding(4, 0, 4, 0)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(100, 32)
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
        pnlSidebar.Location = New Point(0, 75)
        pnlSidebar.Margin = New Padding(4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(225, 835)
        pnlSidebar.TabIndex = 1
        ' 
        ' pnlSidebarAccent
        ' 
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Left
        pnlSidebarAccent.Location = New Point(0, 0)
        pnlSidebarAccent.Margin = New Padding(4)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(4, 835)
        pnlSidebarAccent.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(18, 22)
        lblMenuTitle.Margin = New Padding(4, 0, 4, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(113, 21)
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
        btnNavPembalap.Location = New Point(0, 52)
        btnNavPembalap.Margin = New Padding(4)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(225, 45)
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
        btnNavTim.Location = New Point(0, 99)
        btnNavTim.Margin = New Padding(4)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(225, 45)
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
        btnNavRace.Location = New Point(0, 145)
        btnNavRace.Margin = New Padding(4)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(225, 45)
        btnNavRace.TabIndex = 4
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDivider
        ' 
        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDivider.Location = New Point(18, 200)
        pnlSidebarDivider.Margin = New Padding(4)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(190, 1)
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
        btnNavKlasemen.Location = New Point(0, 206)
        btnNavKlasemen.Margin = New Padding(4)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(225, 45)
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
        btnNavHasil.Location = New Point(0, 252)
        btnNavHasil.Margin = New Padding(4)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(225, 45)
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
        btnKeluar.Location = New Point(0, 788)
        btnKeluar.Margin = New Padding(4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(225, 45)
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
        pnlContent.Location = New Point(225, 75)
        pnlContent.Margin = New Padding(4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20, 15, 20, 15)
        pnlContent.Size = New Size(1375, 835)
        pnlContent.TabIndex = 2
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearchPembalap)
        pnlGrid.Controls.Add(dgvPembalap)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(445, 15)
        pnlGrid.Margin = New Padding(4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(18, 15, 18, 15)
        pnlGrid.Size = New Size(910, 805)
        pnlGrid.TabIndex = 1
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchPembalap.Location = New Point(18, 15)
        txtSearchPembalap.Margin = New Padding(4)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(1100, 34)
        txtSearchPembalap.TabIndex = 0
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
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
        dgvPembalap.Location = New Point(18, 62)
        dgvPembalap.Margin = New Padding(4)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.ReadOnly = True
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowHeadersWidth = 51
        dgvPembalap.RowTemplate.Height = 34
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(1760, 1418)
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
        pnlInput.Location = New Point(20, 15)
        pnlInput.Margin = New Padding(4)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(425, 805)
        pnlInput.TabIndex = 0
        ' 
        ' pnlInputAccent
        ' 
        pnlInputAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlInputAccent.Dock = DockStyle.Top
        pnlInputAccent.Location = New Point(0, 0)
        pnlInputAccent.Margin = New Padding(4)
        pnlInputAccent.Name = "pnlInputAccent"
        pnlInputAccent.Size = New Size(425, 4)
        pnlInputAccent.TabIndex = 0
        ' 
        ' lblPanelInput
        ' 
        lblPanelInput.AutoSize = True
        lblPanelInput.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblPanelInput.ForeColor = Color.White
        lblPanelInput.Location = New Point(18, 20)
        lblPanelInput.Margin = New Padding(4, 0, 4, 0)
        lblPanelInput.Name = "lblPanelInput"
        lblPanelInput.Size = New Size(190, 30)
        lblPanelInput.TabIndex = 1
        lblPanelInput.Text = "DATA PEMBALAP"
        ' 
        ' lblNamaPembalap
        ' 
        lblNamaPembalap.AutoSize = True
        lblNamaPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNamaPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNamaPembalap.Location = New Point(18, 65)
        lblNamaPembalap.Margin = New Padding(4, 0, 4, 0)
        lblNamaPembalap.Name = "lblNamaPembalap"
        lblNamaPembalap.Size = New Size(148, 21)
        lblNamaPembalap.TabIndex = 2
        lblNamaPembalap.Text = "NAMA PEMBALAP"
        ' 
        ' txtNamaPembalap
        ' 
        txtNamaPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNamaPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNamaPembalap.Font = New Font("Segoe UI", 10F)
        txtNamaPembalap.ForeColor = Color.White
        txtNamaPembalap.Location = New Point(18, 88)
        txtNamaPembalap.Margin = New Padding(4)
        txtNamaPembalap.Name = "txtNamaPembalap"
        txtNamaPembalap.Size = New Size(390, 34)
        txtNamaPembalap.TabIndex = 3
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNomor.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNomor.Location = New Point(18, 140)
        lblNomor.Margin = New Padding(4, 0, 4, 0)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(126, 21)
        lblNomor.TabIndex = 4
        lblNomor.Text = "NOMOR BALAP"
        ' 
        ' txtNomor
        ' 
        txtNomor.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNomor.BorderStyle = BorderStyle.FixedSingle
        txtNomor.Font = New Font("Segoe UI", 10F)
        txtNomor.ForeColor = Color.White
        txtNomor.Location = New Point(18, 162)
        txtNomor.Margin = New Padding(4)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(390, 34)
        txtNomor.TabIndex = 5
        ' 
        ' lblNegaraPembalap
        ' 
        lblNegaraPembalap.AutoSize = True
        lblNegaraPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNegaraPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNegaraPembalap.Location = New Point(18, 215)
        lblNegaraPembalap.Margin = New Padding(4, 0, 4, 0)
        lblNegaraPembalap.Name = "lblNegaraPembalap"
        lblNegaraPembalap.Size = New Size(118, 21)
        lblNegaraPembalap.TabIndex = 6
        lblNegaraPembalap.Text = "NEGARA ASAL"
        ' 
        ' txtNegaraPembalap
        ' 
        txtNegaraPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNegaraPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNegaraPembalap.Font = New Font("Segoe UI", 10F)
        txtNegaraPembalap.ForeColor = Color.White
        txtNegaraPembalap.Location = New Point(18, 238)
        txtNegaraPembalap.Margin = New Padding(4)
        txtNegaraPembalap.Name = "txtNegaraPembalap"
        txtNegaraPembalap.Size = New Size(390, 34)
        txtNegaraPembalap.TabIndex = 7
        ' 
        ' lblTimPembalap
        ' 
        lblTimPembalap.AutoSize = True
        lblTimPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblTimPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblTimPembalap.Location = New Point(18, 290)
        lblTimPembalap.Margin = New Padding(4, 0, 4, 0)
        lblTimPembalap.Name = "lblTimPembalap"
        lblTimPembalap.Size = New Size(169, 21)
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
        cbTim.Location = New Point(18, 312)
        cbTim.Margin = New Padding(4)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(389, 36)
        cbTim.TabIndex = 9
        ' 
        ' lblFoto
        ' 
        lblFoto.AutoSize = True
        lblFoto.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblFoto.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblFoto.Location = New Point(18, 368)
        lblFoto.Margin = New Padding(4, 0, 4, 0)
        lblFoto.Name = "lblFoto"
        lblFoto.Size = New Size(137, 21)
        lblFoto.TabIndex = 10
        lblFoto.Text = "FOTO PEMBALAP"
        ' 
        ' picFotoPembalap
        ' 
        picFotoPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        picFotoPembalap.BorderStyle = BorderStyle.FixedSingle
        picFotoPembalap.Location = New Point(18, 390)
        picFotoPembalap.Margin = New Padding(4)
        picFotoPembalap.Name = "picFotoPembalap"
        picFotoPembalap.Size = New Size(200, 200)
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
        btnPilihFoto.Location = New Point(231, 390)
        btnPilihFoto.Margin = New Padding(4)
        btnPilihFoto.Name = "btnPilihFoto"
        btnPilihFoto.Size = New Size(176, 45)
        btnPilihFoto.TabIndex = 12
        btnPilihFoto.Text = "📁  Pilih Foto..."
        btnPilihFoto.UseVisualStyleBackColor = False
        ' 
        ' pnlAction
        ' 
        pnlAction.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlAction.Controls.Add(btnPrintPembalap)
        pnlAction.Controls.Add(btnSimpanPembalap)
        pnlAction.Controls.Add(btnUbahPembalap)
        pnlAction.Controls.Add(btnHapusPembalap)
        pnlAction.Controls.Add(btnBatal)
        pnlAction.Dock = DockStyle.Bottom
        pnlAction.Location = New Point(0, 695)
        pnlAction.Margin = New Padding(4)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(15, 12, 15, 12)
        pnlAction.Size = New Size(425, 110)
        pnlAction.TabIndex = 13
        ' 
        ' btnPrintPembalap
        ' 
        btnPrintPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrintPembalap.Cursor = Cursors.Hand
        btnPrintPembalap.FlatAppearance.BorderSize = 0
        btnPrintPembalap.FlatStyle = FlatStyle.Flat
        btnPrintPembalap.Font = New Font("Segoe UI", 9F)
        btnPrintPembalap.ForeColor = Color.White
        btnPrintPembalap.Location = New Point(19, 56)
        btnPrintPembalap.Margin = New Padding(4)
        btnPrintPembalap.Name = "btnPrintPembalap"
        btnPrintPembalap.Size = New Size(348, 38)
        btnPrintPembalap.TabIndex = 4
        btnPrintPembalap.Text = "🖨  Cetak Laporan Pembalap"
        btnPrintPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanPembalap
        ' 
        btnSimpanPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanPembalap.Cursor = Cursors.Hand
        btnSimpanPembalap.FlatAppearance.BorderSize = 0
        btnSimpanPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnSimpanPembalap.FlatStyle = FlatStyle.Flat
        btnSimpanPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanPembalap.ForeColor = Color.White
        btnSimpanPembalap.Location = New Point(15, 12)
        btnSimpanPembalap.Margin = New Padding(4)
        btnSimpanPembalap.Name = "btnSimpanPembalap"
        btnSimpanPembalap.Size = New Size(92, 38)
        btnSimpanPembalap.TabIndex = 0
        btnSimpanPembalap.Text = "Simpan"
        btnSimpanPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnUbahPembalap
        ' 
        btnUbahPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnUbahPembalap.Cursor = Cursors.Hand
        btnUbahPembalap.FlatAppearance.BorderSize = 0
        btnUbahPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnUbahPembalap.FlatStyle = FlatStyle.Flat
        btnUbahPembalap.Font = New Font("Segoe UI", 9F)
        btnUbahPembalap.ForeColor = Color.White
        btnUbahPembalap.Location = New Point(115, 12)
        btnUbahPembalap.Margin = New Padding(4)
        btnUbahPembalap.Name = "btnUbahPembalap"
        btnUbahPembalap.Size = New Size(78, 38)
        btnUbahPembalap.TabIndex = 1
        btnUbahPembalap.Text = "Ubah"
        btnUbahPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnHapusPembalap
        ' 
        btnHapusPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnHapusPembalap.Cursor = Cursors.Hand
        btnHapusPembalap.FlatAppearance.BorderSize = 0
        btnHapusPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnHapusPembalap.FlatStyle = FlatStyle.Flat
        btnHapusPembalap.Font = New Font("Segoe UI", 9F)
        btnHapusPembalap.ForeColor = Color.White
        btnHapusPembalap.Location = New Point(200, 12)
        btnHapusPembalap.Margin = New Padding(4)
        btnHapusPembalap.Name = "btnHapusPembalap"
        btnHapusPembalap.Size = New Size(78, 38)
        btnHapusPembalap.TabIndex = 2
        btnHapusPembalap.Text = "Hapus"
        btnHapusPembalap.UseVisualStyleBackColor = False
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
        btnBatal.Location = New Point(285, 12)
        btnBatal.Margin = New Padding(4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(78, 38)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
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
        ' FormPembalap
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        ClientSize = New Size(1600, 910)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Margin = New Padding(4)
        MinimumSize = New Size(1274, 736)
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
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSimpanPembalap As Button
    Friend WithEvents btnUbahPembalap As Button
    Friend WithEvents btnHapusPembalap As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPrintPembalap As Button
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents dgvPembalap As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class