<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_RaceUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_RaceUser))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ErrorProvider1 = New ErrorProvider(components)
        PrintDocument1 = New Printing.PrintDocument()
        txtSearchRace = New TextBox()
        pnlGrid = New Panel()
        dgvRace = New DataGridView()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        lblBadge = New Label()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        pnlGrid.SuspendLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).BeginInit()
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
        ' txtSearchRace
        ' 
        txtSearchRace.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchRace.BorderStyle = BorderStyle.FixedSingle
        txtSearchRace.Font = New Font("Segoe UI", 10.0F)
        txtSearchRace.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchRace.Location = New Point(14, 12)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(1302, 30)
        txtSearchRace.TabIndex = 0
        txtSearchRace.Text = "🔍  Cari jadwal race..."
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearchRace)
        pnlGrid.Controls.Add(dgvRace)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(16, 12)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(14, 12, 14, 12)
        pnlGrid.Size = New Size(1325, 849)
        pnlGrid.TabIndex = 1
        ' 
        ' dgvRace
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvRace.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvRace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvRace.BorderStyle = BorderStyle.None
        dgvRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvRace.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvRace.ColumnHeadersHeight = 36
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvRace.DefaultCellStyle = DataGridViewCellStyle3
        dgvRace.EnableHeadersVisualStyles = False
        dgvRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvRace.Location = New Point(14, 52)
        dgvRace.Name = "dgvRace"
        dgvRace.ReadOnly = True
        dgvRace.RowHeadersVisible = False
        dgvRace.RowHeadersWidth = 51
        dgvRace.RowTemplate.Height = 34
        dgvRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRace.Size = New Size(1302, 766)
        dgvRace.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlGrid)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 60)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(16, 12, 16, 12)
        pnlContent.Size = New Size(1357, 873)
        pnlContent.TabIndex = 5
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(lblBadge)
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1357, 60)
        pnlHeader.TabIndex = 3
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(15), CByte(40), CByte(15))
        lblBadge.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(80), CByte(210), CByte(80))
        lblBadge.Location = New Point(1251, 19)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(90, 26)
        lblBadge.TabIndex = 10
        lblBadge.Text = "● READ ONLY"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1357, 2)
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
        lblHeaderSub.Size = New Size(144, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Jadwal Race / Grand Prix"
        ' 
        ' UC_RaceUser
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(20, 15, 20, 15)
        Name = "UC_RaceUser"
        Size = New Size(1357, 933)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtSearchRace As TextBox
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents dgvRace As DataGridView
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblBadge As Label
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
End Class
