<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_RaceAdmin
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        lblBadge = New Label()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        pnlInputRace = New Panel()
        lblPanelRace = New Label()
        lblNamaRace = New Label()
        txtNamaRace = New TextBox()
        lblLokasi = New Label()
        txtLokasi = New TextBox()
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
        DataGridView2 = New DataGridView()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        pnlContent.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlInputRace.SuspendLayout()
        pnlActionRace.SuspendLayout()
        pnlGridRace.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlHeader)
        pnlContent.Controls.Add(pnlInputRace)
        pnlContent.Controls.Add(pnlGridRace)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20, 0, 0, 0)
        pnlContent.Size = New Size(1143, 933)
        pnlContent.TabIndex = 3
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(lblBadge)
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1123, 60)
        pnlHeader.TabIndex = 8
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(15), CByte(40), CByte(15))
        lblBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(80), CByte(210), CByte(80))
        lblBadge.Location = New Point(1196, 19)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(90, 26)
        lblBadge.TabIndex = 4
        lblBadge.Text = "● READ ONLY"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1123, 2)
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
        lblHeaderSub.Size = New Size(146, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Data Race"
        ' 
        ' pnlInputRace
        ' 
        pnlInputRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputRace.Controls.Add(lblPanelRace)
        pnlInputRace.Controls.Add(lblNamaRace)
        pnlInputRace.Controls.Add(txtNamaRace)
        pnlInputRace.Controls.Add(lblLokasi)
        pnlInputRace.Controls.Add(txtLokasi)
        pnlInputRace.Controls.Add(lblTanggal)
        pnlInputRace.Controls.Add(dtpTanggal)
        pnlInputRace.Controls.Add(lblPutaran)
        pnlInputRace.Controls.Add(txtPutaran)
        pnlInputRace.Controls.Add(pnlActionRace)
        pnlInputRace.Location = New Point(20, 65)
        pnlInputRace.Margin = New Padding(2)
        pnlInputRace.Name = "pnlInputRace"
        pnlInputRace.Size = New Size(192, 512)
        pnlInputRace.TabIndex = 6
        ' 
        ' lblPanelRace
        ' 
        lblPanelRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelRace.Dock = DockStyle.Top
        lblPanelRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPanelRace.ForeColor = Color.White
        lblPanelRace.Location = New Point(0, 0)
        lblPanelRace.Margin = New Padding(2, 0, 2, 0)
        lblPanelRace.Name = "lblPanelRace"
        lblPanelRace.Size = New Size(192, 26)
        lblPanelRace.TabIndex = 0
        lblPanelRace.Text = "  DATA RACE"
        lblPanelRace.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNamaRace
        ' 
        lblNamaRace.AutoSize = True
        lblNamaRace.Font = New Font("Segoe UI", 8F)
        lblNamaRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaRace.Location = New Point(10, 40)
        lblNamaRace.Margin = New Padding(2, 0, 2, 0)
        lblNamaRace.Name = "lblNamaRace"
        lblNamaRace.Size = New Size(133, 19)
        lblNamaRace.TabIndex = 1
        lblNamaRace.Text = "NAMA GRAND PRIX"
        ' 
        ' txtNamaRace
        ' 
        txtNamaRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaRace.BorderStyle = BorderStyle.FixedSingle
        txtNamaRace.Font = New Font("Segoe UI", 10F)
        txtNamaRace.ForeColor = Color.White
        txtNamaRace.Location = New Point(10, 54)
        txtNamaRace.Margin = New Padding(2)
        txtNamaRace.Name = "txtNamaRace"
        txtNamaRace.Size = New Size(172, 30)
        txtNamaRace.TabIndex = 1
        ' 
        ' lblLokasi
        ' 
        lblLokasi.AutoSize = True
        lblLokasi.Font = New Font("Segoe UI", 8F)
        lblLokasi.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblLokasi.Location = New Point(10, 91)
        lblLokasi.Margin = New Padding(2, 0, 2, 0)
        lblLokasi.Name = "lblLokasi"
        lblLokasi.Size = New Size(116, 19)
        lblLokasi.TabIndex = 2
        lblLokasi.Text = "SIRKUIT / LOKASI"
        ' 
        ' txtLokasi
        ' 
        txtLokasi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtLokasi.BorderStyle = BorderStyle.FixedSingle
        txtLokasi.Font = New Font("Segoe UI", 10F)
        txtLokasi.ForeColor = Color.White
        txtLokasi.Location = New Point(10, 106)
        txtLokasi.Margin = New Padding(2)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(172, 30)
        txtLokasi.TabIndex = 2
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 8F)
        lblTanggal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTanggal.Location = New Point(10, 142)
        lblTanggal.Margin = New Padding(2, 0, 2, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(70, 19)
        lblTanggal.TabIndex = 3
        lblTanggal.Text = "TANGGAL"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        dtpTanggal.CalendarForeColor = Color.White
        dtpTanggal.CalendarMonthBackground = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dtpTanggal.CalendarTitleBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        dtpTanggal.CalendarTitleForeColor = Color.White
        dtpTanggal.Font = New Font("Segoe UI", 10F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(10, 157)
        dtpTanggal.Margin = New Padding(2)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(173, 30)
        dtpTanggal.TabIndex = 3
        ' 
        ' lblPutaran
        ' 
        lblPutaran.AutoSize = True
        lblPutaran.Font = New Font("Segoe UI", 8F)
        lblPutaran.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblPutaran.Location = New Point(10, 194)
        lblPutaran.Margin = New Padding(2, 0, 2, 0)
        lblPutaran.Name = "lblPutaran"
        lblPutaran.Size = New Size(130, 19)
        lblPutaran.TabIndex = 4
        lblPutaran.Text = "PUTARAN (ROUND)"
        ' 
        ' txtPutaran
        ' 
        txtPutaran.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtPutaran.BorderStyle = BorderStyle.FixedSingle
        txtPutaran.Font = New Font("Segoe UI", 10F)
        txtPutaran.ForeColor = Color.White
        txtPutaran.Location = New Point(10, 208)
        txtPutaran.Margin = New Padding(2)
        txtPutaran.Name = "txtPutaran"
        txtPutaran.Size = New Size(172, 30)
        txtPutaran.TabIndex = 4
        ' 
        ' pnlActionRace
        ' 
        pnlActionRace.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionRace.Controls.Add(btnSimpanRace)
        pnlActionRace.Controls.Add(btnUbahRace)
        pnlActionRace.Controls.Add(btnHapusRace)
        pnlActionRace.Controls.Add(btnBatalRace)
        pnlActionRace.Controls.Add(btnPrintRace)
        pnlActionRace.Location = New Point(0, 352)
        pnlActionRace.Margin = New Padding(2)
        pnlActionRace.Name = "pnlActionRace"
        pnlActionRace.Size = New Size(192, 160)
        pnlActionRace.TabIndex = 10
        ' 
        ' btnSimpanRace
        ' 
        btnSimpanRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanRace.Cursor = Cursors.Hand
        btnSimpanRace.FlatAppearance.BorderSize = 0
        btnSimpanRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanRace.FlatStyle = FlatStyle.Flat
        btnSimpanRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanRace.ForeColor = Color.White
        btnSimpanRace.Location = New Point(8, 8)
        btnSimpanRace.Margin = New Padding(2)
        btnSimpanRace.Name = "btnSimpanRace"
        btnSimpanRace.Size = New Size(80, 27)
        btnSimpanRace.TabIndex = 5
        btnSimpanRace.Text = "SIMPAN"
        btnSimpanRace.UseVisualStyleBackColor = False
        ' 
        ' btnUbahRace
        ' 
        btnUbahRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahRace.Cursor = Cursors.Hand
        btnUbahRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahRace.FlatStyle = FlatStyle.Flat
        btnUbahRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbahRace.ForeColor = Color.White
        btnUbahRace.Location = New Point(100, 8)
        btnUbahRace.Margin = New Padding(2)
        btnUbahRace.Name = "btnUbahRace"
        btnUbahRace.Size = New Size(80, 27)
        btnUbahRace.TabIndex = 6
        btnUbahRace.Text = "UBAH"
        btnUbahRace.UseVisualStyleBackColor = False
        ' 
        ' btnHapusRace
        ' 
        btnHapusRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusRace.Cursor = Cursors.Hand
        btnHapusRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusRace.FlatStyle = FlatStyle.Flat
        btnHapusRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusRace.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusRace.Location = New Point(8, 43)
        btnHapusRace.Margin = New Padding(2)
        btnHapusRace.Name = "btnHapusRace"
        btnHapusRace.Size = New Size(80, 27)
        btnHapusRace.TabIndex = 7
        btnHapusRace.Text = "HAPUS"
        btnHapusRace.UseVisualStyleBackColor = False
        ' 
        ' btnBatalRace
        ' 
        btnBatalRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalRace.Cursor = Cursors.Hand
        btnBatalRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalRace.FlatStyle = FlatStyle.Flat
        btnBatalRace.Font = New Font("Segoe UI", 9F)
        btnBatalRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalRace.Location = New Point(100, 43)
        btnBatalRace.Margin = New Padding(2)
        btnBatalRace.Name = "btnBatalRace"
        btnBatalRace.Size = New Size(80, 27)
        btnBatalRace.TabIndex = 8
        btnBatalRace.Text = "BATAL"
        btnBatalRace.UseVisualStyleBackColor = False
        ' 
        ' btnPrintRace
        ' 
        btnPrintRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintRace.Cursor = Cursors.Hand
        btnPrintRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatStyle = FlatStyle.Flat
        btnPrintRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrintRace.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.Location = New Point(8, 80)
        btnPrintRace.Margin = New Padding(2)
        btnPrintRace.Name = "btnPrintRace"
        btnPrintRace.Size = New Size(172, 27)
        btnPrintRace.TabIndex = 9
        btnPrintRace.Text = "🖨  PRINT DOKUMEN"
        btnPrintRace.UseVisualStyleBackColor = False
        ' 
        ' pnlGridRace
        ' 
        pnlGridRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridRace.Controls.Add(DataGridView2)
        pnlGridRace.Controls.Add(TextBox1)
        pnlGridRace.Controls.Add(DataGridView1)
        pnlGridRace.Location = New Point(222, 65)
        pnlGridRace.Margin = New Padding(2)
        pnlGridRace.Name = "pnlGridRace"
        pnlGridRace.Size = New Size(904, 512)
        pnlGridRace.TabIndex = 7
        ' 
        ' DataGridView2
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView2.ColumnHeadersHeight = 36
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        DataGridView2.Location = New Point(16, 54)
        DataGridView2.Margin = New Padding(2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 32
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(873, 450)
        DataGridView2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        TextBox1.Location = New Point(16, 8)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(873, 30)
        TextBox1.TabIndex = 0
        TextBox1.Text = "🔍  Cari jadwal race..."
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.ColumnHeadersHeight = 36
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        DataGridView1.Location = New Point(8, 40)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 32
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(627, 464)
        DataGridView1.TabIndex = 1
        ' 
        ' UC_RaceAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_RaceAdmin"
        Size = New Size(1143, 933)
        pnlContent.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlInputRace.ResumeLayout(False)
        pnlInputRace.PerformLayout()
        pnlActionRace.ResumeLayout(False)
        pnlGridRace.ResumeLayout(False)
        pnlGridRace.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlInputRace As Panel
    Friend WithEvents lblPanelRace As Label
    Friend WithEvents lblNamaRace As Label
    Friend WithEvents txtNamaRace As TextBox
    Friend WithEvents lblLokasi As Label
    Friend WithEvents txtLokasi As TextBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblBadge As Label
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
End Class
