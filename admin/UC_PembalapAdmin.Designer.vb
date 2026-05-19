<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_PembalapAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_PembalapAdmin))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ErrorProvider1 = New ErrorProvider(components)
        btnPrintPembalap = New Button()
        btnSimpanPembalap = New Button()
        btnUbahPembalap = New Button()
        btnHapusPembalap = New Button()
        btnBatal = New Button()
        PrintDocument1 = New Printing.PrintDocument()
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
        txtSearchPembalap = New TextBox()
        pnlGrid = New Panel()
        dgvPembalap = New DataGridView()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        pnlInput.SuspendLayout()
        CType(picFotoPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlAction.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlHeader.SuspendLayout()
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
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnPrintPembalap
        ' 
        btnPrintPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrintPembalap.Cursor = Cursors.Hand
        btnPrintPembalap.FlatAppearance.BorderSize = 0
        btnPrintPembalap.FlatStyle = FlatStyle.Flat
        btnPrintPembalap.Font = New Font("Segoe UI", 9F)
        btnPrintPembalap.ForeColor = Color.White
        btnPrintPembalap.Location = New Point(15, 45)
        btnPrintPembalap.Name = "btnPrintPembalap"
        btnPrintPembalap.Size = New Size(278, 30)
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
        btnSimpanPembalap.Location = New Point(12, 10)
        btnSimpanPembalap.Name = "btnSimpanPembalap"
        btnSimpanPembalap.Size = New Size(74, 30)
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
        btnUbahPembalap.Location = New Point(92, 10)
        btnUbahPembalap.Name = "btnUbahPembalap"
        btnUbahPembalap.Size = New Size(62, 30)
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
        btnHapusPembalap.Location = New Point(160, 10)
        btnHapusPembalap.Name = "btnHapusPembalap"
        btnHapusPembalap.Size = New Size(62, 30)
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
        btnBatal.Location = New Point(228, 10)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(62, 30)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
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
        pnlInput.Size = New Size(340, 849)
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
        pnlAction.Controls.Add(btnPrintPembalap)
        pnlAction.Controls.Add(btnSimpanPembalap)
        pnlAction.Controls.Add(btnUbahPembalap)
        pnlAction.Controls.Add(btnHapusPembalap)
        pnlAction.Controls.Add(btnBatal)
        pnlAction.Dock = DockStyle.Bottom
        pnlAction.Location = New Point(0, 761)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(12, 10, 12, 10)
        pnlAction.Size = New Size(340, 88)
        pnlAction.TabIndex = 13
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchPembalap.Location = New Point(14, 12)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(880, 30)
        txtSearchPembalap.TabIndex = 0
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearchPembalap)
        pnlGrid.Controls.Add(dgvPembalap)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(356, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.Size = New Size(771, 849)
        pnlGrid.TabIndex = 1
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
        dgvPembalap.Location = New Point(28, 62)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.ReadOnly = True
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowHeadersWidth = 51
        dgvPembalap.RowTemplate.Height = 34
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(1951, 1859)
        dgvPembalap.TabIndex = 1
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
        ' UC_PembalapAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_PembalapAdmin"
        Size = New Size(1143, 933)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(picFotoPembalap, ComponentModel.ISupportInitialize).EndInit()
        pnlAction.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents dgvPembalap As DataGridView
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
    Friend WithEvents btnPrintPembalap As Button
    Friend WithEvents btnSimpanPembalap As Button
    Friend WithEvents btnUbahPembalap As Button
    Friend WithEvents btnHapusPembalap As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
