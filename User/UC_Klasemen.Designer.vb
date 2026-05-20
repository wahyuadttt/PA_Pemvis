<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Klasemen
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
        pnlTabIndicator = New Panel()
        pnlTabs = New Panel()
        btnTabPembalap = New Button()
        pnlTitleAccent = New Panel()
        lblKlasemenTitle = New Label()
        lblSeasonLabel = New Label()
        lblSeasonValue = New Label()
        lblLastUpdate = New Label()
        pnlTitleBar = New Panel()
        pnlKlasemenWrap = New Panel()
        dgvKlasemen = New DataGridView()
        pnlContent = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblBadge = New Label()
        pnlHeader = New Panel()
        pnlTabs.SuspendLayout()
        pnlTitleBar.SuspendLayout()
        pnlKlasemenWrap.SuspendLayout()
        CType(dgvKlasemen, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTabIndicator
        ' 
        pnlTabIndicator.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlTabIndicator.Location = New Point(0, 31)
        pnlTabIndicator.Margin = New Padding(3, 2, 3, 2)
        pnlTabIndicator.Name = "pnlTabIndicator"
        pnlTabIndicator.Size = New Size(140, 2)
        pnlTabIndicator.TabIndex = 2
        ' 
        ' pnlTabs
        ' 
        pnlTabs.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(26))
        pnlTabs.Controls.Add(btnTabPembalap)
        pnlTabs.Controls.Add(pnlTabIndicator)
        pnlTabs.Dock = DockStyle.Top
        pnlTabs.Location = New Point(0, 0)
        pnlTabs.Margin = New Padding(3, 2, 3, 2)
        pnlTabs.Name = "pnlTabs"
        pnlTabs.Size = New Size(922, 33)
        pnlTabs.TabIndex = 1
        ' 
        ' btnTabPembalap
        ' 
        btnTabPembalap.BackColor = Color.Transparent
        btnTabPembalap.Cursor = Cursors.Hand
        btnTabPembalap.FlatAppearance.BorderSize = 0
        btnTabPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(35), CByte(35), CByte(48))
        btnTabPembalap.FlatStyle = FlatStyle.Flat
        btnTabPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTabPembalap.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnTabPembalap.Location = New Point(0, 0)
        btnTabPembalap.Margin = New Padding(3, 2, 3, 2)
        btnTabPembalap.Name = "btnTabPembalap"
        btnTabPembalap.Size = New Size(140, 32)
        btnTabPembalap.TabIndex = 0
        btnTabPembalap.Text = "KLASEMEN PEMBALAP"
        btnTabPembalap.UseVisualStyleBackColor = False
        ' 
        ' pnlTitleAccent
        ' 
        pnlTitleAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlTitleAccent.Dock = DockStyle.Bottom
        pnlTitleAccent.Location = New Point(0, 50)
        pnlTitleAccent.Margin = New Padding(3, 2, 3, 2)
        pnlTitleAccent.Name = "pnlTitleAccent"
        pnlTitleAccent.Size = New Size(922, 2)
        pnlTitleAccent.TabIndex = 0
        ' 
        ' lblKlasemenTitle
        ' 
        lblKlasemenTitle.AutoSize = True
        lblKlasemenTitle.BackColor = Color.Transparent
        lblKlasemenTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblKlasemenTitle.ForeColor = Color.White
        lblKlasemenTitle.Location = New Point(16, 9)
        lblKlasemenTitle.Name = "lblKlasemenTitle"
        lblKlasemenTitle.Size = New Size(143, 25)
        lblKlasemenTitle.TabIndex = 1
        lblKlasemenTitle.Text = "🏆  KLASEMEN"
        ' 
        ' lblSeasonLabel
        ' 
        lblSeasonLabel.AutoSize = True
        lblSeasonLabel.BackColor = Color.Transparent
        lblSeasonLabel.Font = New Font("Segoe UI", 8F)
        lblSeasonLabel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblSeasonLabel.Location = New Point(18, 34)
        lblSeasonLabel.Name = "lblSeasonLabel"
        lblSeasonLabel.Size = New Size(44, 13)
        lblSeasonLabel.TabIndex = 2
        lblSeasonLabel.Text = "MUSIM"
        ' 
        ' lblSeasonValue
        ' 
        lblSeasonValue.AutoSize = True
        lblSeasonValue.BackColor = Color.Transparent
        lblSeasonValue.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblSeasonValue.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblSeasonValue.Location = New Point(57, 34)
        lblSeasonValue.Name = "lblSeasonValue"
        lblSeasonValue.Size = New Size(31, 13)
        lblSeasonValue.TabIndex = 3
        lblSeasonValue.Text = "2025"
        ' 
        ' lblLastUpdate
        ' 
        lblLastUpdate.AutoSize = True
        lblLastUpdate.BackColor = Color.Transparent
        lblLastUpdate.Font = New Font("Segoe UI", 8F, FontStyle.Italic)
        lblLastUpdate.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblLastUpdate.Location = New Point(788, 34)
        lblLastUpdate.Name = "lblLastUpdate"
        lblLastUpdate.Size = New Size(103, 13)
        lblLastUpdate.TabIndex = 4
        lblLastUpdate.Text = "Diperbarui otomatis"
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
        pnlTitleBar.Location = New Point(0, 33)
        pnlTitleBar.Margin = New Padding(3, 2, 3, 2)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(922, 52)
        pnlTitleBar.TabIndex = 0
        ' 
        ' pnlKlasemenWrap
        ' 
        pnlKlasemenWrap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlKlasemenWrap.Controls.Add(pnlTitleBar)
        pnlKlasemenWrap.Controls.Add(pnlTabs)
        pnlKlasemenWrap.Controls.Add(dgvKlasemen)
        pnlKlasemenWrap.Dock = DockStyle.Fill
        pnlKlasemenWrap.Location = New Point(21, 15)
        pnlKlasemenWrap.Margin = New Padding(3, 2, 3, 2)
        pnlKlasemenWrap.Name = "pnlKlasemenWrap"
        pnlKlasemenWrap.Size = New Size(922, 603)
        pnlKlasemenWrap.TabIndex = 0
        ' 
        ' dgvKlasemen
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvKlasemen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvKlasemen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKlasemen.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvKlasemen.BorderStyle = BorderStyle.None
        dgvKlasemen.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvKlasemen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvKlasemen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvKlasemen.ColumnHeadersHeight = 42
        dgvKlasemen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(6)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvKlasemen.DefaultCellStyle = DataGridViewCellStyle3
        dgvKlasemen.Dock = DockStyle.Fill
        dgvKlasemen.EnableHeadersVisualStyles = False
        dgvKlasemen.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvKlasemen.Location = New Point(0, 0)
        dgvKlasemen.Margin = New Padding(3, 2, 3, 2)
        dgvKlasemen.Name = "dgvKlasemen"
        dgvKlasemen.ReadOnly = True
        dgvKlasemen.RowHeadersVisible = False
        dgvKlasemen.RowHeadersWidth = 51
        dgvKlasemen.RowTemplate.Height = 40
        dgvKlasemen.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKlasemen.Size = New Size(922, 603)
        dgvKlasemen.TabIndex = 2
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlKlasemenWrap)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(18, 56)
        pnlContent.Margin = New Padding(3, 2, 3, 2)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(21, 15, 21, 15)
        pnlContent.Size = New Size(964, 633)
        pnlContent.TabIndex = 5
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 43)
        pnlHeaderAccent.Margin = New Padding(3, 2, 3, 2)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(964, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(13, 1)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(263, 30)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(15, 30)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(84, 13)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Klasemen & Poin"
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(15), CByte(40), CByte(15))
        lblBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(80), CByte(210), CByte(80))
        lblBadge.Location = New Point(302, 15)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(79, 20)
        lblBadge.TabIndex = 3
        lblBadge.Text = "● READ ONLY"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblBadge)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(18, 11)
        pnlHeader.Margin = New Padding(3, 2, 3, 2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(964, 45)
        pnlHeader.TabIndex = 3
        ' 
        ' UC_Klasemen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(18, 11, 18, 11)
        Name = "UC_Klasemen"
        Padding = New Padding(18, 11, 18, 11)
        Size = New Size(1000, 700)
        pnlTabs.ResumeLayout(False)
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBar.PerformLayout()
        pnlKlasemenWrap.ResumeLayout(False)
        CType(dgvKlasemen, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTabIndicator As Panel
    Friend WithEvents pnlTabs As Panel
    Friend WithEvents btnTabPembalap As Button
    Friend WithEvents pnlTitleAccent As Panel
    Friend WithEvents lblKlasemenTitle As Label
    Friend WithEvents lblSeasonLabel As Label
    Friend WithEvents lblSeasonValue As Label
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents pnlKlasemenWrap As Panel
    Friend WithEvents dgvKlasemen As DataGridView
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblBadge As Label
    Friend WithEvents pnlHeader As Panel
End Class
