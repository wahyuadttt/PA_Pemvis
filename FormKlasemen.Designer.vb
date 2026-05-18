<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKlasemen
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblBadge = New Label()
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
        pnlKlasemenWrap = New Panel()
        pnlTitleBar = New Panel()
        pnlTitleAccent = New Panel()
        lblKlasemenTitle = New Label()
        lblSeasonLabel = New Label()
        lblSeasonValue = New Label()
        lblLastUpdate = New Label()
        pnlTabs = New Panel()
        btnTabPembalap = New Button()
        pnlTabIndicator = New Panel()
        dgvKlasemen = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlKlasemenWrap.SuspendLayout()
        pnlTitleBar.SuspendLayout()
        pnlTabs.SuspendLayout()
        CType(dgvKlasemen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblBadge)
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
        lblHeaderTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
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
        lblHeaderSub.Font = New Font("Segoe UI", 8.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(17, 40)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(101, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Klasemen & Poin"
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(15), CByte(40), CByte(15))
        lblBadge.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(80), CByte(210), CByte(80))
        lblBadge.Location = New Point(1150, 17)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(90, 26)
        lblBadge.TabIndex = 3
        lblBadge.Text = "● READ ONLY"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
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
        lblMenuTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(14, 18)
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
        btnNavPembalap.Font = New Font("Segoe UI", 10.0F)
        btnNavPembalap.ForeColor = Color.White
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
        btnNavTim.Font = New Font("Segoe UI", 10.0F)
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
        btnNavRace.Font = New Font("Segoe UI", 10.0F)
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
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(18), CByte(14))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
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
        btnNavHasil.Font = New Font("Segoe UI", 10.0F)
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
        btnKeluar.Font = New Font("Segoe UI", 9.0F)
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
        pnlContent.Controls.Add(pnlKlasemenWrap)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(180, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(24, 20, 24, 20)
        pnlContent.Size = New Size(1100, 668)
        pnlContent.TabIndex = 2
        ' 
        ' pnlKlasemenWrap
        ' 
        pnlKlasemenWrap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlKlasemenWrap.Controls.Add(pnlTitleBar)
        pnlKlasemenWrap.Controls.Add(pnlTabs)
        pnlKlasemenWrap.Controls.Add(dgvKlasemen)
        pnlKlasemenWrap.Dock = DockStyle.Fill
        pnlKlasemenWrap.Location = New Point(24, 20)
        pnlKlasemenWrap.Name = "pnlKlasemenWrap"
        pnlKlasemenWrap.Size = New Size(1052, 628)
        pnlKlasemenWrap.TabIndex = 0
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlTitleBar.Controls.Add(pnlTitleAccent)
        pnlTitleBar.Controls.Add(lblKlasemenTitle)
        pnlTitleBar.Controls.Add(lblSeasonLabel)
        pnlTitleBar.Controls.Add(lblSeasonValue)
        pnlTitleBar.Controls.Add(lblLastUpdate)
        pnlTitleBar.Dock = DockStyle.Top
        pnlTitleBar.Location = New Point(0, 44)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1052, 70)
        pnlTitleBar.TabIndex = 0
        ' 
        ' pnlTitleAccent
        ' 
        pnlTitleAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlTitleAccent.Dock = DockStyle.Bottom
        pnlTitleAccent.Location = New Point(0, 68)
        pnlTitleAccent.Name = "pnlTitleAccent"
        pnlTitleAccent.Size = New Size(1052, 2)
        pnlTitleAccent.TabIndex = 0
        ' 
        ' lblKlasemenTitle
        ' 
        lblKlasemenTitle.AutoSize = True
        lblKlasemenTitle.BackColor = Color.Transparent
        lblKlasemenTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblKlasemenTitle.ForeColor = Color.White
        lblKlasemenTitle.Location = New Point(18, 12)
        lblKlasemenTitle.Name = "lblKlasemenTitle"
        lblKlasemenTitle.Size = New Size(189, 32)
        lblKlasemenTitle.TabIndex = 1
        lblKlasemenTitle.Text = "🏆  KLASEMEN"
        ' 
        ' lblSeasonLabel
        ' 
        lblSeasonLabel.AutoSize = True
        lblSeasonLabel.BackColor = Color.Transparent
        lblSeasonLabel.Font = New Font("Segoe UI", 8.0F)
        lblSeasonLabel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblSeasonLabel.Location = New Point(20, 46)
        lblSeasonLabel.Name = "lblSeasonLabel"
        lblSeasonLabel.Size = New Size(56, 19)
        lblSeasonLabel.TabIndex = 2
        lblSeasonLabel.Text = "MUSIM"
        ' 
        ' lblSeasonValue
        ' 
        lblSeasonValue.AutoSize = True
        lblSeasonValue.BackColor = Color.Transparent
        lblSeasonValue.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblSeasonValue.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblSeasonValue.Location = New Point(65, 46)
        lblSeasonValue.Name = "lblSeasonValue"
        lblSeasonValue.Size = New Size(41, 19)
        lblSeasonValue.TabIndex = 3
        lblSeasonValue.Text = "2025"
        ' 
        ' lblLastUpdate
        ' 
        lblLastUpdate.AutoSize = True
        lblLastUpdate.BackColor = Color.Transparent
        lblLastUpdate.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblLastUpdate.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblLastUpdate.Location = New Point(900, 46)
        lblLastUpdate.Name = "lblLastUpdate"
        lblLastUpdate.Size = New Size(136, 19)
        lblLastUpdate.TabIndex = 4
        lblLastUpdate.Text = "Diperbarui otomatis"
        ' 
        ' pnlTabs
        ' 
        pnlTabs.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        pnlTabs.Controls.Add(btnTabPembalap)
        pnlTabs.Controls.Add(pnlTabIndicator)
        pnlTabs.Dock = DockStyle.Top
        pnlTabs.Location = New Point(0, 0)
        pnlTabs.Name = "pnlTabs"
        pnlTabs.Size = New Size(1052, 44)
        pnlTabs.TabIndex = 1
        ' 
        ' btnTabPembalap
        ' 
        btnTabPembalap.BackColor = Color.Transparent
        btnTabPembalap.Cursor = Cursors.Hand
        btnTabPembalap.FlatAppearance.BorderSize = 0
        btnTabPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(35), CByte(35), CByte(48))
        btnTabPembalap.FlatStyle = FlatStyle.Flat
        btnTabPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTabPembalap.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnTabPembalap.Location = New Point(0, 0)
        btnTabPembalap.Name = "btnTabPembalap"
        btnTabPembalap.Size = New Size(160, 42)
        btnTabPembalap.TabIndex = 0
        btnTabPembalap.Text = "KLASEMEN PEMBALAP"
        btnTabPembalap.UseVisualStyleBackColor = False
        ' 
        ' pnlTabIndicator
        ' 
        pnlTabIndicator.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlTabIndicator.Location = New Point(0, 41)
        pnlTabIndicator.Name = "pnlTabIndicator"
        pnlTabIndicator.Size = New Size(160, 3)
        pnlTabIndicator.TabIndex = 2
        ' 
        ' dgvKlasemen
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvKlasemen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvKlasemen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKlasemen.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvKlasemen.BorderStyle = BorderStyle.None
        dgvKlasemen.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvKlasemen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvKlasemen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvKlasemen.ColumnHeadersHeight = 42
        dgvKlasemen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.Padding = New Padding(6)
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvKlasemen.DefaultCellStyle = DataGridViewCellStyle9
        dgvKlasemen.Dock = DockStyle.Fill
        dgvKlasemen.EnableHeadersVisualStyles = False
        dgvKlasemen.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvKlasemen.Location = New Point(0, 0)
        dgvKlasemen.Name = "dgvKlasemen"
        dgvKlasemen.ReadOnly = True
        dgvKlasemen.RowHeadersVisible = False
        dgvKlasemen.RowHeadersWidth = 51
        dgvKlasemen.RowTemplate.Height = 40
        dgvKlasemen.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKlasemen.Size = New Size(1052, 628)
        dgvKlasemen.TabIndex = 2
        ' 
        ' FormKlasemen
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        ClientSize = New Size(1280, 728)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(900, 600)
        Name = "FormKlasemen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Klasemen"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlKlasemenWrap.ResumeLayout(False)
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBar.PerformLayout()
        pnlTabs.ResumeLayout(False)
        CType(dgvKlasemen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblBadge As Label
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
    Friend WithEvents pnlKlasemenWrap As Panel
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents pnlTitleAccent As Panel
    Friend WithEvents lblKlasemenTitle As Label
    Friend WithEvents lblSeasonLabel As Label
    Friend WithEvents lblSeasonValue As Label
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents pnlTabs As Panel
    Friend WithEvents btnTabPembalap As Button
    Friend WithEvents pnlTabIndicator As Panel
    Friend WithEvents dgvKlasemen As DataGridView
End Class