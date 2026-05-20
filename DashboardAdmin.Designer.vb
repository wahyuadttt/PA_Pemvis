<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardAdmin
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
        pnlSidebar = New Panel()
        pnlSidebarAccent = New Panel()
        lblLogoMark = New Label()
        lblMenuLabel = New Label()
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        btnNavHasil = New Button()
        pnlSidebarDiv = New Panel()
        btnNavKlasemen = New Button()
        pnlSidebarFoot = New Panel()
        btnKeluar = New Button()
        pnlContent = New Panel()
        pnlSidebar.SuspendLayout()
        pnlSidebarFoot.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(pnlSidebarAccent)
        pnlSidebar.Controls.Add(lblLogoMark)
        pnlSidebar.Controls.Add(lblMenuLabel)
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(btnNavHasil)
        pnlSidebar.Controls.Add(pnlSidebarDiv)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Controls.Add(pnlSidebarFoot)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(4, 4, 4, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(269, 1000)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlSidebarAccent
        ' 
        pnlSidebarAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarAccent.Dock = DockStyle.Left
        pnlSidebarAccent.Location = New Point(0, 0)
        pnlSidebarAccent.Margin = New Padding(4, 4, 4, 4)
        pnlSidebarAccent.Name = "pnlSidebarAccent"
        pnlSidebarAccent.Size = New Size(4, 938)
        pnlSidebarAccent.TabIndex = 0
        ' 
        ' lblLogoMark
        ' 
        lblLogoMark.AutoSize = True
        lblLogoMark.BackColor = Color.Transparent
        lblLogoMark.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblLogoMark.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblLogoMark.Location = New Point(18, 25)
        lblLogoMark.Margin = New Padding(4, 0, 4, 0)
        lblLogoMark.Name = "lblLogoMark"
        lblLogoMark.Size = New Size(240, 36)
        lblLogoMark.TabIndex = 1
        lblLogoMark.Text = "F1 MANAGEMENT"
        ' 
        ' lblMenuLabel
        ' 
        lblMenuLabel.AutoSize = True
        lblMenuLabel.BackColor = Color.Transparent
        lblMenuLabel.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblMenuLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(130))
        lblMenuLabel.Location = New Point(18, 75)
        lblMenuLabel.Margin = New Padding(4, 0, 4, 0)
        lblMenuLabel.Name = "lblMenuLabel"
        lblMenuLabel.Size = New Size(151, 20)
        lblMenuLabel.TabIndex = 2
        lblMenuLabel.Text = "MANAJEMEN DATA"
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
        btnNavPembalap.Location = New Point(0, 100)
        btnNavPembalap.Margin = New Padding(4, 4, 4, 4)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(250, 50)
        btnNavPembalap.TabIndex = 3
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
        btnNavTim.Location = New Point(0, 151)
        btnNavTim.Margin = New Padding(4, 4, 4, 4)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(250, 50)
        btnNavTim.TabIndex = 4
        btnNavTim.Text = "  🏁  Tim / Konstruktor"
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
        btnNavRace.Location = New Point(0, 202)
        btnNavRace.Margin = New Padding(4, 4, 4, 4)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(250, 50)
        btnNavRace.TabIndex = 5
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
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
        btnNavHasil.Location = New Point(0, 254)
        btnNavHasil.Margin = New Padding(4, 4, 4, 4)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(250, 50)
        btnNavHasil.TabIndex = 6
        btnNavHasil.Text = "  📊  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDiv
        ' 
        pnlSidebarDiv.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDiv.Location = New Point(18, 315)
        pnlSidebarDiv.Margin = New Padding(4, 4, 4, 4)
        pnlSidebarDiv.Name = "pnlSidebarDiv"
        pnlSidebarDiv.Size = New Size(215, 1)
        pnlSidebarDiv.TabIndex = 7
        ' 
        ' btnNavKlasemen
        ' 
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(50), CByte(12), CByte(10))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(18), CByte(14))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavKlasemen.Location = New Point(12, 319)
        btnNavKlasemen.Margin = New Padding(4, 4, 4, 4)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(250, 50)
        btnNavKlasemen.TabIndex = 8
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarFoot
        ' 
        pnlSidebarFoot.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        pnlSidebarFoot.Controls.Add(btnKeluar)
        pnlSidebarFoot.Dock = DockStyle.Bottom
        pnlSidebarFoot.Location = New Point(0, 938)
        pnlSidebarFoot.Margin = New Padding(4, 4, 4, 4)
        pnlSidebarFoot.Name = "pnlSidebarFoot"
        pnlSidebarFoot.Padding = New Padding(0, 12, 0, 12)
        pnlSidebarFoot.Size = New Size(269, 62)
        pnlSidebarFoot.TabIndex = 9
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.Dock = DockStyle.Fill
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9.5F)
        btnKeluar.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(175))
        btnKeluar.Location = New Point(0, 12)
        btnKeluar.Margin = New Padding(4, 4, 4, 4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(269, 38)
        btnKeluar.TabIndex = 0
        btnKeluar.Text = "  ✕  Keluar / Logout"
        btnKeluar.TextAlign = ContentAlignment.MiddleLeft
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(269, 0)
        pnlContent.Margin = New Padding(4, 4, 4, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(25, 0, 0, 0)
        pnlContent.Size = New Size(1331, 1000)
        pnlContent.TabIndex = 1
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1600, 1000)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Margin = New Padding(4, 4, 4, 4)
        MinimumSize = New Size(1274, 861)
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Admin Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlSidebarFoot.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarAccent As Panel
    Friend WithEvents lblLogoMark As Label
    Friend WithEvents lblMenuLabel As Label
    Friend WithEvents btnNavPembalap As Button
    Friend WithEvents btnNavTim As Button
    Friend WithEvents btnNavRace As Button
    Friend WithEvents btnNavHasil As Button
    Friend WithEvents pnlSidebarDiv As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents pnlSidebarFoot As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pnlContent As Panel
End Class