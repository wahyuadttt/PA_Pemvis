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
        pnlGridRace = New Panel()
        TextBox1 = New TextBox()
        DataGridView2 = New DataGridView()
        DataGridView1 = New DataGridView()
        pnlInputRace = New Panel()
        pnlInputAccent = New Panel()
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
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        pnlContent.SuspendLayout()
        pnlGridRace.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlInputRace.SuspendLayout()
        pnlActionRace.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlGridRace)
        pnlContent.Controls.Add(pnlInputRace)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(16, 12, 16, 12)
        pnlContent.Size = New Size(1143, 873)
        pnlContent.TabIndex = 5
        ' 
        ' pnlGridRace
        ' 
        pnlGridRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGridRace.Controls.Add(TextBox1)
        pnlGridRace.Controls.Add(DataGridView2)
        pnlGridRace.Controls.Add(DataGridView1)
        pnlGridRace.Dock = DockStyle.Fill
        pnlGridRace.Location = New Point(356, 12)
        pnlGridRace.Name = "pnlGridRace"
        pnlGridRace.Padding = New Padding(14, 12, 14, 12)
        pnlGridRace.Size = New Size(771, 849)
        pnlGridRace.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        TextBox1.Location = New Point(14, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(743, 30)
        TextBox1.TabIndex = 0
        TextBox1.Text = "🔍  Cari jadwal race..."
        ' 
        ' DataGridView2
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
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
        DataGridView2.Location = New Point(14, 52)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 34
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(743, 785)
        DataGridView2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
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
        DataGridView1.Location = New Point(14, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 34
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(743, 785)
        DataGridView1.TabIndex = 2
        ' 
        ' pnlInputRace
        ' 
        pnlInputRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlInputRace.Controls.Add(pnlInputAccent)
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
        pnlInputRace.Dock = DockStyle.Left
        pnlInputRace.Location = New Point(16, 12)
        pnlInputRace.Name = "pnlInputRace"
        pnlInputRace.Size = New Size(340, 849)
        pnlInputRace.TabIndex = 0
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
        ' lblPanelRace
        ' 
        lblPanelRace.AutoSize = True
        lblPanelRace.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblPanelRace.ForeColor = Color.White
        lblPanelRace.Location = New Point(14, 16)
        lblPanelRace.Name = "lblPanelRace"
        lblPanelRace.Size = New Size(113, 25)
        lblPanelRace.TabIndex = 1
        lblPanelRace.Text = "DATA RACE"
        ' 
        ' lblNamaRace
        ' 
        lblNamaRace.AutoSize = True
        lblNamaRace.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblNamaRace.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblNamaRace.Location = New Point(14, 52)
        lblNamaRace.Name = "lblNamaRace"
        lblNamaRace.Size = New Size(142, 19)
        lblNamaRace.TabIndex = 2
        lblNamaRace.Text = "NAMA GRAND PRIX"
        ' 
        ' txtNamaRace
        ' 
        txtNamaRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtNamaRace.BorderStyle = BorderStyle.FixedSingle
        txtNamaRace.Font = New Font("Segoe UI", 10F)
        txtNamaRace.ForeColor = Color.White
        txtNamaRace.Location = New Point(14, 70)
        txtNamaRace.Name = "txtNamaRace"
        txtNamaRace.Size = New Size(312, 30)
        txtNamaRace.TabIndex = 1
        ' 
        ' lblLokasi
        ' 
        lblLokasi.AutoSize = True
        lblLokasi.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLokasi.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblLokasi.Location = New Point(14, 112)
        lblLokasi.Name = "lblLokasi"
        lblLokasi.Size = New Size(124, 19)
        lblLokasi.TabIndex = 3
        lblLokasi.Text = "SIRKUIT / LOKASI"
        ' 
        ' txtLokasi
        ' 
        txtLokasi.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtLokasi.BorderStyle = BorderStyle.FixedSingle
        txtLokasi.Font = New Font("Segoe UI", 10F)
        txtLokasi.ForeColor = Color.White
        txtLokasi.Location = New Point(14, 130)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(312, 30)
        txtLokasi.TabIndex = 2
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblTanggal.Location = New Point(14, 172)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(74, 19)
        lblTanggal.TabIndex = 4
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
        dtpTanggal.Location = New Point(14, 190)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(312, 30)
        dtpTanggal.TabIndex = 3
        ' 
        ' lblPutaran
        ' 
        lblPutaran.AutoSize = True
        lblPutaran.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblPutaran.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        lblPutaran.Location = New Point(14, 232)
        lblPutaran.Name = "lblPutaran"
        lblPutaran.Size = New Size(140, 19)
        lblPutaran.TabIndex = 5
        lblPutaran.Text = "PUTARAN (ROUND)"
        ' 
        ' txtPutaran
        ' 
        txtPutaran.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtPutaran.BorderStyle = BorderStyle.FixedSingle
        txtPutaran.Font = New Font("Segoe UI", 10F)
        txtPutaran.ForeColor = Color.White
        txtPutaran.Location = New Point(14, 250)
        txtPutaran.Name = "txtPutaran"
        txtPutaran.Size = New Size(312, 30)
        txtPutaran.TabIndex = 4
        ' 
        ' pnlActionRace
        ' 
        pnlActionRace.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlActionRace.Controls.Add(btnSimpanRace)
        pnlActionRace.Controls.Add(btnUbahRace)
        pnlActionRace.Controls.Add(btnHapusRace)
        pnlActionRace.Controls.Add(btnBatalRace)
        pnlActionRace.Controls.Add(btnPrintRace)
        pnlActionRace.Dock = DockStyle.Bottom
        pnlActionRace.Location = New Point(0, 761)
        pnlActionRace.Name = "pnlActionRace"
        pnlActionRace.Padding = New Padding(12, 10, 12, 10)
        pnlActionRace.Size = New Size(340, 88)
        pnlActionRace.TabIndex = 13
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
        btnSimpanRace.Location = New Point(12, 10)
        btnSimpanRace.Name = "btnSimpanRace"
        btnSimpanRace.Size = New Size(74, 30)
        btnSimpanRace.TabIndex = 5
        btnSimpanRace.Text = "SIMPAN"
        btnSimpanRace.UseVisualStyleBackColor = False
        ' 
        ' btnUbahRace
        ' 
        btnUbahRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnUbahRace.Cursor = Cursors.Hand
        btnUbahRace.FlatAppearance.BorderSize = 0
        btnUbahRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahRace.FlatStyle = FlatStyle.Flat
        btnUbahRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbahRace.ForeColor = Color.White
        btnUbahRace.Location = New Point(92, 10)
        btnUbahRace.Name = "btnUbahRace"
        btnUbahRace.Size = New Size(62, 30)
        btnUbahRace.TabIndex = 6
        btnUbahRace.Text = "UBAH"
        btnUbahRace.UseVisualStyleBackColor = False
        ' 
        ' btnHapusRace
        ' 
        btnHapusRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnHapusRace.Cursor = Cursors.Hand
        btnHapusRace.FlatAppearance.BorderSize = 0
        btnHapusRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusRace.FlatStyle = FlatStyle.Flat
        btnHapusRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusRace.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusRace.Location = New Point(160, 10)
        btnHapusRace.Name = "btnHapusRace"
        btnHapusRace.Size = New Size(62, 30)
        btnHapusRace.TabIndex = 7
        btnHapusRace.Text = "HAPUS"
        btnHapusRace.UseVisualStyleBackColor = False
        ' 
        ' btnBatalRace
        ' 
        btnBatalRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnBatalRace.Cursor = Cursors.Hand
        btnBatalRace.FlatAppearance.BorderSize = 0
        btnBatalRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalRace.FlatStyle = FlatStyle.Flat
        btnBatalRace.Font = New Font("Segoe UI", 9F)
        btnBatalRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalRace.Location = New Point(228, 10)
        btnBatalRace.Name = "btnBatalRace"
        btnBatalRace.Size = New Size(62, 30)
        btnBatalRace.TabIndex = 8
        btnBatalRace.Text = "BATAL"
        btnBatalRace.UseVisualStyleBackColor = False
        ' 
        ' btnPrintRace
        ' 
        btnPrintRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        btnPrintRace.Cursor = Cursors.Hand
        btnPrintRace.FlatAppearance.BorderSize = 0
        btnPrintRace.FlatStyle = FlatStyle.Flat
        btnPrintRace.Font = New Font("Segoe UI", 9F)
        btnPrintRace.ForeColor = Color.White
        btnPrintRace.Location = New Point(12, 46)
        btnPrintRace.Name = "btnPrintRace"
        btnPrintRace.Size = New Size(278, 30)
        btnPrintRace.TabIndex = 9
        btnPrintRace.Text = "🖨  PRINT DOKUMEN"
        btnPrintRace.UseVisualStyleBackColor = False
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
        lblHeaderTitle.Location = New Point(15, 3)
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
        ' UC_RaceAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_RaceAdmin"
        Size = New Size(1143, 933)
        pnlContent.ResumeLayout(False)
        pnlGridRace.ResumeLayout(False)
        pnlGridRace.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlInputRace.ResumeLayout(False)
        pnlInputRace.PerformLayout()
        pnlActionRace.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblBadge As Label
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlInputRace As Panel
    Friend WithEvents pnlInputAccent As Panel
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
End Class