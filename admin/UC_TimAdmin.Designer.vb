<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_TimAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_TimAdmin))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ErrorProvider1 = New ErrorProvider(components)
        btnSimpanTim = New Button()
        btnUbahTim = New Button()
        btnHapusTim = New Button()
        btnBatal = New Button()
        btnPrintTim = New Button()
        PrintDocument1 = New Printing.PrintDocument()
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
        txtSearch = New TextBox()
        pnlGrid = New Panel()
        dgvTim = New DataGridView()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        pnlInput.SuspendLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).BeginInit()
        pnlAction.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
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
        ' btnSimpanTim
        ' 
        btnSimpanTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanTim.Cursor = Cursors.Hand
        btnSimpanTim.FlatAppearance.BorderSize = 0
        btnSimpanTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnSimpanTim.FlatStyle = FlatStyle.Flat
        btnSimpanTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanTim.ForeColor = Color.White
        btnSimpanTim.Location = New Point(12, 10)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(74, 30)
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
        btnUbahTim.Location = New Point(92, 10)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(62, 30)
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
        btnHapusTim.Location = New Point(160, 10)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(62, 30)
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
        btnBatal.Location = New Point(228, 10)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(62, 30)
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
        btnPrintTim.Location = New Point(12, 46)
        btnPrintTim.Name = "btnPrintTim"
        btnPrintTim.Size = New Size(278, 30)
        btnPrintTim.TabIndex = 4
        btnPrintTim.Text = "🖨  Cetak Laporan Tim"
        btnPrintTim.UseVisualStyleBackColor = False
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
        lblPanelInput.Size = New Size(101, 25)
        lblPanelInput.TabIndex = 1
        lblPanelInput.Text = "DATA TIM"
        ' 
        ' lblNamaTim
        ' 
        lblNamaTim.AutoSize = True
        lblNamaTim.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNamaTim.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNamaTim.Location = New Point(14, 52)
        lblNamaTim.Name = "lblNamaTim"
        lblNamaTim.Size = New Size(82, 19)
        lblNamaTim.TabIndex = 2
        lblNamaTim.Text = "NAMA TIM"
        ' 
        ' txtNamaTim
        ' 
        txtNamaTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNamaTim.BorderStyle = BorderStyle.FixedSingle
        txtNamaTim.Font = New Font("Segoe UI", 10F)
        txtNamaTim.ForeColor = Color.White
        txtNamaTim.Location = New Point(14, 70)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(312, 30)
        txtNamaTim.TabIndex = 3
        ' 
        ' lblNegaraTim
        ' 
        lblNegaraTim.AutoSize = True
        lblNegaraTim.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNegaraTim.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNegaraTim.Location = New Point(14, 112)
        lblNegaraTim.Name = "lblNegaraTim"
        lblNegaraTim.Size = New Size(109, 19)
        lblNegaraTim.TabIndex = 4
        lblNegaraTim.Text = "NEGARA BASIS"
        ' 
        ' txtNegaraTim
        ' 
        txtNegaraTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNegaraTim.BorderStyle = BorderStyle.FixedSingle
        txtNegaraTim.Font = New Font("Segoe UI", 10F)
        txtNegaraTim.ForeColor = Color.White
        txtNegaraTim.Location = New Point(14, 130)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(312, 30)
        txtNegaraTim.TabIndex = 5
        ' 
        ' lblMesin
        ' 
        lblMesin.AutoSize = True
        lblMesin.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMesin.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblMesin.Location = New Point(14, 172)
        lblMesin.Name = "lblMesin"
        lblMesin.Size = New Size(52, 19)
        lblMesin.TabIndex = 6
        lblMesin.Text = "MESIN"
        ' 
        ' txtMesin
        ' 
        txtMesin.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtMesin.BorderStyle = BorderStyle.FixedSingle
        txtMesin.Font = New Font("Segoe UI", 10F)
        txtMesin.ForeColor = Color.White
        txtMesin.Location = New Point(14, 190)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(312, 30)
        txtMesin.TabIndex = 7
        ' 
        ' lblChasis
        ' 
        lblChasis.AutoSize = True
        lblChasis.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblChasis.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblChasis.Location = New Point(14, 232)
        lblChasis.Name = "lblChasis"
        lblChasis.Size = New Size(59, 19)
        lblChasis.TabIndex = 8
        lblChasis.Text = "CHASIS"
        ' 
        ' txtChasis
        ' 
        txtChasis.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtChasis.BorderStyle = BorderStyle.FixedSingle
        txtChasis.Font = New Font("Segoe UI", 10F)
        txtChasis.ForeColor = Color.White
        txtChasis.Location = New Point(14, 250)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(312, 30)
        txtChasis.TabIndex = 9
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLogo.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblLogo.Location = New Point(14, 294)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(77, 19)
        lblLogo.TabIndex = 10
        lblLogo.Text = "LOGO TIM"
        ' 
        ' picLogoTim
        ' 
        picLogoTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        picLogoTim.BorderStyle = BorderStyle.FixedSingle
        picLogoTim.Location = New Point(14, 312)
        picLogoTim.Name = "picLogoTim"
        picLogoTim.Size = New Size(160, 160)
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
        btnPilihLogo.Location = New Point(185, 312)
        btnPilihLogo.Name = "btnPilihLogo"
        btnPilihLogo.Size = New Size(141, 36)
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
        pnlAction.Location = New Point(0, 761)
        pnlAction.Name = "pnlAction"
        pnlAction.Padding = New Padding(12, 10, 12, 10)
        pnlAction.Size = New Size(340, 88)
        pnlAction.TabIndex = 13
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
        txtSearch.Text = "🔍  Cari tim / konstruktor..."
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearch)
        pnlGrid.Controls.Add(dgvTim)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(356, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.Size = New Size(771, 849)
        pnlGrid.TabIndex = 1
        ' 
        ' dgvTim
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTim.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
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
        dgvTim.Location = New Point(28, 62)
        dgvTim.Name = "dgvTim"
        dgvTim.ReadOnly = True
        dgvTim.RowHeadersVisible = False
        dgvTim.RowHeadersWidth = 51
        dgvTim.RowTemplate.Height = 34
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Size = New Size(1951, 1859)
        dgvTim.TabIndex = 1
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
        lblHeaderSub.Size = New Size(193, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Tim / Konstruktor"
        ' 
        ' UC_TimAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_TimAdmin"
        Size = New Size(1143, 933)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).EndInit()
        pnlAction.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvTim As DataGridView
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
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
