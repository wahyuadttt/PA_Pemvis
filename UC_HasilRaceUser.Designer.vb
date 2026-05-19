<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HasilRaceUser
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
        pnlPageTitle = New Panel()
        lblPageTitle = New Label()
        pnlMain = New Panel()
        pnlSearchSection = New Panel()
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvHasilRace = New DataGridView()
        pnlPageTitle.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlSearchSection.SuspendLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlPageTitle
        '
        pnlPageTitle.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlPageTitle.Controls.Add(lblPageTitle)
        pnlPageTitle.Dock = DockStyle.Top
        pnlPageTitle.Location = New Point(0, 0)
        pnlPageTitle.Name = "pnlPageTitle"
        pnlPageTitle.Padding = New Padding(15, 15, 15, 15)
        pnlPageTitle.Size = New Size(1000, 60)
        pnlPageTitle.TabIndex = 0
        '
        ' lblPageTitle
        '
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.White
        lblPageTitle.Location = New Point(15, 15)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(296, 41)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Hasil Balapan F1"
        '
        ' pnlMain
        '
        pnlMain.Controls.Add(dgvHasilRace)
        pnlMain.Controls.Add(pnlSearchSection)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 60)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(15)
        pnlMain.Size = New Size(1000, 640)
        pnlMain.TabIndex = 1
        '
        ' pnlSearchSection
        '
        pnlSearchSection.Controls.Add(lblSearch)
        pnlSearchSection.Controls.Add(txtSearch)
        pnlSearchSection.Dock = DockStyle.Top
        pnlSearchSection.Location = New Point(15, 15)
        pnlSearchSection.Name = "pnlSearchSection"
        pnlSearchSection.Padding = New Padding(0, 0, 0, 10)
        pnlSearchSection.Size = New Size(970, 50)
        pnlSearchSection.TabIndex = 0
        '
        ' lblSearch
        '
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 9.75F)
        lblSearch.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        lblSearch.Location = New Point(0, 8)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(54, 23)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Cari:"
        '
        ' txtSearch
        '
        txtSearch.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.75F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(60, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari sirkuit atau pembalap..."
        txtSearch.Size = New Size(900, 27)
        txtSearch.TabIndex = 1
        '
        ' dgvHasilRace
        '
        dgvHasilRace.AllowUserToAddRows = False
        dgvHasilRace.AllowUserToDeleteRows = False
        dgvHasilRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvHasilRace.BorderStyle = BorderStyle.None
        dgvHasilRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(70))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        dgvHasilRace.DefaultCellStyle = DataGridViewCellStyle1
        dgvHasilRace.Dock = DockStyle.Fill
        dgvHasilRace.EnableHeadersVisualStyles = False
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(70))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        dgvHasilRace.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvHasilRace.ColumnHeadersHeight = 30
        dgvHasilRace.Location = New Point(15, 65)
        dgvHasilRace.Name = "dgvHasilRace"
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(70))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        dgvHasilRace.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvHasilRace.RowHeadersWidth = 51
        dgvHasilRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHasilRace.Size = New Size(970, 575)
        dgvHasilRace.TabIndex = 1
        '
        ' UC_HasilRaceUser
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlMain)
        Controls.Add(pnlPageTitle)
        Name = "UC_HasilRaceUser"
        Size = New Size(1000, 700)
        pnlPageTitle.ResumeLayout(False)
        pnlPageTitle.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlSearchSection.ResumeLayout(False)
        pnlSearchSection.PerformLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlPageTitle As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSearchSection As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvHasilRace As DataGridView
End Class
