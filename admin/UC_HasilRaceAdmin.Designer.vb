<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HasilRaceAdmin
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_HasilRaceAdmin))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        btnSimpanHasil = New Button()
        btnUbahHasil = New Button()
        btnHapusHasil = New Button()
        btnBatal = New Button()
        btnPrintHasil = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        txtPoinHasil = New TextBox()
        pnlInput = New Panel()
        txtTimHasil = New TextBox()
        pnlInputAccent = New Panel()
        lblPanelInput = New Label()
        lblSirkuit = New Label()
        cbRaceHasil = New ComboBox()
        pnlInputSep = New Panel()
        lblInputDetail = New Label()
        lblPembalap = New Label()
        cbPembalapHasil = New ComboBox()
        lblTim = New Label()
        lblPosisi = New Label()
        nudPosisi = New NumericUpDown()
        lblPoin = New Label()
        lblGap = New Label()
        txtGap = New TextBox()
        lblStatus = New Label()
        cbStatusFinish = New ComboBox()
        chkFastestLap = New CheckBox()
        pnlAction = New Panel()
        txtSearch = New TextBox()
        lblGridTitle = New Label()
        lblGridSub = New Label()
        pnlGridHeader = New Panel()
        pnlGrid = New Panel()
        dgvHasilRace = New DataGridView()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        pnlInput.SuspendLayout()
        CType(nudPosisi, ComponentModel.ISupportInitialize).BeginInit()
        pnlAction.SuspendLayout()
        pnlGridHeader.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' btnSimpanHasil
        ' 
        btnSimpanHasil.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanHasil.Cursor = Cursors.Hand
        btnSimpanHasil.FlatAppearance.BorderSize = 0
        btnSimpanHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnSimpanHasil.FlatStyle = FlatStyle.Flat
        btnSimpanHasil.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanHasil.ForeColor = Color.White
        btnSimpanHasil.Location = New Point(12, 10)
        btnSimpanHasil.Name = "btnSimpanHasil"
        btnSimpanHasil.Size = New Size(78, 30)
        btnSimpanHasil.TabIndex = 0
        btnSimpanHasil.Text = "Simpan"
        btnSimpanHasil.UseVisualStyleBackColor = False
        ' 
        ' btnUbahHasil
        ' 
        btnUbahHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnUbahHasil.Cursor = Cursors.Hand
        btnUbahHasil.FlatAppearance.BorderSize = 0
        btnUbahHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnUbahHasil.FlatStyle = FlatStyle.Flat
        btnUbahHasil.Font = New Font("Segoe UI", 9F)
        btnUbahHasil.ForeColor = Color.White
        btnUbahHasil.Location = New Point(96, 10)
        btnUbahHasil.Name = "btnUbahHasil"
        btnUbahHasil.Size = New Size(66, 30)
        btnUbahHasil.TabIndex = 1
        btnUbahHasil.Text = "Ubah"
        btnUbahHasil.UseVisualStyleBackColor = False
        ' 
        ' btnHapusHasil
        ' 
        btnHapusHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnHapusHasil.Cursor = Cursors.Hand
        btnHapusHasil.FlatAppearance.BorderSize = 0
        btnHapusHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(55), CByte(55), CByte(70))
        btnHapusHasil.FlatStyle = FlatStyle.Flat
        btnHapusHasil.Font = New Font("Segoe UI", 9F)
        btnHapusHasil.ForeColor = Color.White
        btnHapusHasil.Location = New Point(168, 10)
        btnHapusHasil.Name = "btnHapusHasil"
        btnHapusHasil.Size = New Size(66, 30)
        btnHapusHasil.TabIndex = 2
        btnHapusHasil.Text = "Hapus"
        btnHapusHasil.UseVisualStyleBackColor = False
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
        btnBatal.Location = New Point(240, 10)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(66, 30)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnPrintHasil
        ' 
        btnPrintHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrintHasil.Cursor = Cursors.Hand
        btnPrintHasil.FlatAppearance.BorderSize = 0
        btnPrintHasil.FlatStyle = FlatStyle.Flat
        btnPrintHasil.Font = New Font("Segoe UI", 9F)
        btnPrintHasil.ForeColor = Color.White
        btnPrintHasil.Location = New Point(12, 46)
        btnPrintHasil.Name = "btnPrintHasil"
        btnPrintHasil.Size = New Size(294, 30)
        btnPrintHasil.TabIndex = 4
        btnPrintHasil.Text = "🖨  Cetak Laporan Hasil Race"
        btnPrintHasil.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' txtPoinHasil
        ' 
        txtPoinHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtPoinHasil.ForeColor = Color.White
        txtPoinHasil.Location = New Point(190, 285)
        txtPoinHasil.Margin = New Padding(2)
        txtPoinHasil.Name = "txtPoinHasil"
        txtPoinHasil.ReadOnly = True
        txtPoinHasil.Size = New Size(121, 27)
        txtPoinHasil.TabIndex = 21
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlInput.Controls.Add(txtPoinHasil)
        pnlInput.Controls.Add(txtTimHasil)
        pnlInput.Controls.Add(pnlInputAccent)
        pnlInput.Controls.Add(lblPanelInput)
        pnlInput.Controls.Add(lblSirkuit)
        pnlInput.Controls.Add(cbRaceHasil)
        pnlInput.Controls.Add(pnlInputSep)
        pnlInput.Controls.Add(lblInputDetail)
        pnlInput.Controls.Add(lblPembalap)
        pnlInput.Controls.Add(cbPembalapHasil)
        pnlInput.Controls.Add(lblTim)
        pnlInput.Controls.Add(lblPosisi)
        pnlInput.Controls.Add(nudPosisi)
        pnlInput.Controls.Add(lblPoin)
        pnlInput.Controls.Add(lblGap)
        pnlInput.Controls.Add(txtGap)
        pnlInput.Controls.Add(lblStatus)
        pnlInput.Controls.Add(cbStatusFinish)
        pnlInput.Controls.Add(chkFastestLap)
        pnlInput.Controls.Add(pnlAction)
        pnlInput.Dock = DockStyle.Left
        pnlInput.Location = New Point(16, 12)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(376, 849)
        pnlInput.TabIndex = 0
        ' 
        ' txtTimHasil
        ' 
        txtTimHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtTimHasil.ForeColor = Color.White
        txtTimHasil.Location = New Point(14, 219)
        txtTimHasil.Margin = New Padding(2)
        txtTimHasil.Name = "txtTimHasil"
        txtTimHasil.ReadOnly = True
        txtTimHasil.Size = New Size(332, 27)
        txtTimHasil.TabIndex = 20
        ' 
        ' pnlInputAccent
        ' 
        pnlInputAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlInputAccent.Dock = DockStyle.Top
        pnlInputAccent.Location = New Point(0, 0)
        pnlInputAccent.Name = "pnlInputAccent"
        pnlInputAccent.Size = New Size(376, 3)
        pnlInputAccent.TabIndex = 0
        ' 
        ' lblPanelInput
        ' 
        lblPanelInput.AutoSize = True
        lblPanelInput.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblPanelInput.ForeColor = Color.White
        lblPanelInput.Location = New Point(14, 16)
        lblPanelInput.Name = "lblPanelInput"
        lblPanelInput.Size = New Size(182, 25)
        lblPanelInput.TabIndex = 1
        lblPanelInput.Text = "INPUT HASIL RACE"
        ' 
        ' lblSirkuit
        ' 
        lblSirkuit.AutoSize = True
        lblSirkuit.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblSirkuit.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblSirkuit.Location = New Point(14, 52)
        lblSirkuit.Name = "lblSirkuit"
        lblSirkuit.Size = New Size(110, 19)
        lblSirkuit.TabIndex = 2
        lblSirkuit.Text = "SIRKUIT / RACE"
        ' 
        ' cbRaceHasil
        ' 
        cbRaceHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbRaceHasil.DropDownStyle = ComboBoxStyle.DropDownList
        cbRaceHasil.FlatStyle = FlatStyle.Flat
        cbRaceHasil.Font = New Font("Segoe UI", 10F)
        cbRaceHasil.ForeColor = Color.White
        cbRaceHasil.Location = New Point(14, 70)
        cbRaceHasil.Name = "cbRaceHasil"
        cbRaceHasil.Size = New Size(332, 31)
        cbRaceHasil.TabIndex = 3
        ' 
        ' pnlInputSep
        ' 
        pnlInputSep.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlInputSep.Location = New Point(14, 114)
        pnlInputSep.Name = "pnlInputSep"
        pnlInputSep.Size = New Size(332, 1)
        pnlInputSep.TabIndex = 4
        ' 
        ' lblInputDetail
        ' 
        lblInputDetail.AutoSize = True
        lblInputDetail.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblInputDetail.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblInputDetail.Location = New Point(14, 122)
        lblInputDetail.Name = "lblInputDetail"
        lblInputDetail.Size = New Size(147, 15)
        lblInputDetail.TabIndex = 5
        lblInputDetail.Text = "DETAIL HASIL PEMBALAP"
        ' 
        ' lblPembalap
        ' 
        lblPembalap.AutoSize = True
        lblPembalap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblPembalap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPembalap.Location = New Point(14, 140)
        lblPembalap.Name = "lblPembalap"
        lblPembalap.Size = New Size(83, 19)
        lblPembalap.TabIndex = 6
        lblPembalap.Text = "PEMBALAP"
        ' 
        ' cbPembalapHasil
        ' 
        cbPembalapHasil.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbPembalapHasil.DropDownStyle = ComboBoxStyle.DropDownList
        cbPembalapHasil.FlatStyle = FlatStyle.Flat
        cbPembalapHasil.Font = New Font("Segoe UI", 10F)
        cbPembalapHasil.ForeColor = Color.White
        cbPembalapHasil.Location = New Point(14, 158)
        cbPembalapHasil.Name = "cbPembalapHasil"
        cbPembalapHasil.Size = New Size(332, 31)
        cbPembalapHasil.TabIndex = 7
        ' 
        ' lblTim
        ' 
        lblTim.AutoSize = True
        lblTim.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblTim.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblTim.Location = New Point(14, 200)
        lblTim.Name = "lblTim"
        lblTim.Size = New Size(150, 19)
        lblTim.TabIndex = 8
        lblTim.Text = "TIM / KONSTRUKTOR"
        ' 
        ' lblPosisi
        ' 
        lblPosisi.AutoSize = True
        lblPosisi.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblPosisi.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPosisi.Location = New Point(14, 262)
        lblPosisi.Name = "lblPosisi"
        lblPosisi.Size = New Size(102, 19)
        lblPosisi.TabIndex = 10
        lblPosisi.Text = "POSISI FINISH"
        ' 
        ' nudPosisi
        ' 
        nudPosisi.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        nudPosisi.BorderStyle = BorderStyle.FixedSingle
        nudPosisi.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        nudPosisi.ForeColor = Color.White
        nudPosisi.Location = New Point(14, 280)
        nudPosisi.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudPosisi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudPosisi.Name = "nudPosisi"
        nudPosisi.Size = New Size(156, 32)
        nudPosisi.TabIndex = 11
        nudPosisi.TextAlign = HorizontalAlignment.Center
        nudPosisi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblPoin
        ' 
        lblPoin.AutoSize = True
        lblPoin.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblPoin.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPoin.Location = New Point(190, 262)
        lblPoin.Name = "lblPoin"
        lblPoin.Size = New Size(107, 19)
        lblPoin.TabIndex = 12
        lblPoin.Text = "POIN DIDAPAT"
        ' 
        ' lblGap
        ' 
        lblGap.AutoSize = True
        lblGap.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblGap.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblGap.Location = New Point(14, 328)
        lblGap.Name = "lblGap"
        lblGap.Size = New Size(156, 19)
        lblGap.TabIndex = 14
        lblGap.Text = "GAP / SELISIH WAKTU"
        ' 
        ' txtGap
        ' 
        txtGap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtGap.BorderStyle = BorderStyle.FixedSingle
        txtGap.Font = New Font("Segoe UI", 10F)
        txtGap.ForeColor = Color.White
        txtGap.Location = New Point(14, 346)
        txtGap.Name = "txtGap"
        txtGap.PlaceholderText = "Contoh: +1.234s / WINNER"
        txtGap.Size = New Size(332, 30)
        txtGap.TabIndex = 15
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblStatus.Location = New Point(14, 390)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(108, 19)
        lblStatus.TabIndex = 16
        lblStatus.Text = "STATUS FINISH"
        ' 
        ' cbStatusFinish
        ' 
        cbStatusFinish.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        cbStatusFinish.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatusFinish.FlatStyle = FlatStyle.Flat
        cbStatusFinish.Font = New Font("Segoe UI", 10F)
        cbStatusFinish.ForeColor = Color.White
        cbStatusFinish.Items.AddRange(New Object() {"Finish", "DNF", "DNS", "DSQ", "Retired"})
        cbStatusFinish.Location = New Point(14, 408)
        cbStatusFinish.Name = "cbStatusFinish"
        cbStatusFinish.Size = New Size(332, 31)
        cbStatusFinish.TabIndex = 17
        ' 
        ' chkFastestLap
        ' 
        chkFastestLap.BackColor = Color.Transparent
        chkFastestLap.Font = New Font("Segoe UI", 9F)
        chkFastestLap.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(215))
        chkFastestLap.Location = New Point(14, 450)
        chkFastestLap.Name = "chkFastestLap"
        chkFastestLap.Size = New Size(200, 24)
        chkFastestLap.TabIndex = 18
        chkFastestLap.Text = "  ⚡ Fastest Lap (+1 Poin)"
        chkFastestLap.UseVisualStyleBackColor = False
        ' 
        ' pnlAction
        ' 
        pnlAction.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlAction.Controls.Add(btnSimpanHasil)
        pnlAction.Controls.Add(btnUbahHasil)
        pnlAction.Controls.Add(btnHapusHasil)
        pnlAction.Controls.Add(btnBatal)
        pnlAction.Controls.Add(btnPrintHasil)
        pnlAction.Dock = DockStyle.Bottom
        pnlAction.Location = New Point(0, 761)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(12, 10, 12, 10)
        pnlAction.Size = New Size(376, 88)
        pnlAction.TabIndex = 19
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearch.Location = New Point(14, 66)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "🔍  Cari pembalap / tim..."
        txtSearch.Size = New Size(723, 30)
        txtSearch.TabIndex = 1
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.BackColor = Color.Transparent
        lblGridTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGridTitle.ForeColor = Color.White
        lblGridTitle.Location = New Point(10, 6)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(159, 25)
        lblGridTitle.TabIndex = 0
        lblGridTitle.Text = "HASIL BALAPAN"
        ' 
        ' lblGridSub
        ' 
        lblGridSub.AutoSize = True
        lblGridSub.BackColor = Color.Transparent
        lblGridSub.Font = New Font("Segoe UI", 8F)
        lblGridSub.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblGridSub.Location = New Point(12, 28)
        lblGridSub.Name = "lblGridSub"
        lblGridSub.Size = New Size(245, 19)
        lblGridSub.TabIndex = 1
        lblGridSub.Text = "Pilih sirkuit di kiri untuk memfilter data"
        ' 
        ' pnlGridHeader
        ' 
        pnlGridHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlGridHeader.Controls.Add(lblGridTitle)
        pnlGridHeader.Controls.Add(lblGridSub)
        pnlGridHeader.Dock = DockStyle.Top
        pnlGridHeader.Location = New Point(14, 12)
        pnlGridHeader.Name = "pnlGridHeader"
        pnlGridHeader.Size = New Size(707, 46)
        pnlGridHeader.TabIndex = 0
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(pnlGridHeader)
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(dgvHasilRace)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(392, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.Size = New Size(735, 849)
        pnlGrid.TabIndex = 1
        ' 
        ' dgvHasilRace
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvHasilRace.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvHasilRace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHasilRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHasilRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvHasilRace.BorderStyle = BorderStyle.None
        dgvHasilRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvHasilRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvHasilRace.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvHasilRace.ColumnHeadersHeight = 36
        dgvHasilRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvHasilRace.DefaultCellStyle = DataGridViewCellStyle6
        dgvHasilRace.EnableHeadersVisualStyles = False
        dgvHasilRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvHasilRace.Location = New Point(14, 114)
        dgvHasilRace.Name = "dgvHasilRace"
        dgvHasilRace.ReadOnly = True
        dgvHasilRace.RowHeadersVisible = False
        dgvHasilRace.RowHeadersWidth = 51
        dgvHasilRace.RowTemplate.Height = 34
        dgvHasilRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHasilRace.Size = New Size(704, 1285)
        dgvHasilRace.TabIndex = 2
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlGrid)
        pnlContent.Controls.Add(pnlInput)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(16, 12, 16, 12)
        pnlContent.Size = New Size(1143, 873)
        pnlContent.TabIndex = 5
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1143, 60)
        pnlHeader.TabIndex = 3
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1143, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(15, -1)
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
        lblHeaderSub.Location = New Point(17, 38)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(184, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Input Tampilan Hasil Balapan"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' UC_HasilRaceAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_HasilRaceAdmin"
        Size = New Size(1143, 933)
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(nudPosisi, ComponentModel.ISupportInitialize).EndInit()
        pnlAction.ResumeLayout(False)
        pnlGridHeader.ResumeLayout(False)
        pnlGridHeader.PerformLayout()
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnSimpanHasil As Button
    Friend WithEvents btnUbahHasil As Button
    Friend WithEvents btnHapusHasil As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPrintHasil As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtPoinHasil As TextBox
    Friend WithEvents pnlInput As Panel
    Friend WithEvents txtTimHasil As TextBox
    Friend WithEvents pnlInputAccent As Panel
    Friend WithEvents lblPanelInput As Label
    Friend WithEvents lblSirkuit As Label
    Friend WithEvents cbRaceHasil As ComboBox
    Friend WithEvents pnlInputSep As Panel
    Friend WithEvents lblInputDetail As Label
    Friend WithEvents lblPembalap As Label
    Friend WithEvents cbPembalapHasil As ComboBox
    Friend WithEvents lblTim As Label
    Friend WithEvents lblPosisi As Label
    Friend WithEvents nudPosisi As NumericUpDown
    Friend WithEvents lblPoin As Label
    Friend WithEvents lblGap As Label
    Friend WithEvents txtGap As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatusFinish As ComboBox
    Friend WithEvents chkFastestLap As CheckBox
    Friend WithEvents pnlAction As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents lblGridSub As Label
    Friend WithEvents pnlGridHeader As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents dgvHasilRace As DataGridView
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblAdminBadge As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
