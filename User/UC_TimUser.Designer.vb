<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_TimUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_TimUser))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ErrorProvider1 = New ErrorProvider(components)
        PrintDocument1 = New Printing.PrintDocument()
        txtSearchTim = New TextBox()
        pnlGrid = New Panel()
        dgvTim = New DataGridView()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        lblBadge = New Label()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' txtSearchTim
        ' 
        txtSearchTim.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        txtSearchTim.BorderStyle = BorderStyle.FixedSingle
        txtSearchTim.Font = New Font("Segoe UI", 10F)
        txtSearchTim.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchTim.Location = New Point(18, 15)
        txtSearchTim.Margin = New Padding(4, 4, 4, 4)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(1350, 34)
        txtSearchTim.TabIndex = 0
        txtSearchTim.Text = "🔍  Cari tim / konstruktor..."
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlGrid.Controls.Add(txtSearchTim)
        pnlGrid.Controls.Add(dgvTim)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(20, 15)
        pnlGrid.Margin = New Padding(4, 4, 4, 4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(18, 15, 18, 15)
        pnlGrid.Size = New Size(1396, 1023)
        pnlGrid.TabIndex = 1
        ' 
        ' dgvTim
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvTim.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvTim.DefaultCellStyle = DataGridViewCellStyle6
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvTim.Location = New Point(18, 60)
        dgvTim.Margin = New Padding(4, 4, 4, 4)
        dgvTim.Name = "dgvTim"
        dgvTim.ReadOnly = True
        dgvTim.RowHeadersVisible = False
        dgvTim.RowHeadersWidth = 51
        dgvTim.RowTemplate.Height = 34
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Size = New Size(1358, 944)
        dgvTim.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(36))
        pnlContent.Controls.Add(pnlGrid)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(25, 94)
        pnlContent.Margin = New Padding(4, 4, 4, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(20, 15, 20, 15)
        pnlContent.Size = New Size(1436, 1053)
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
        pnlHeader.Location = New Point(25, 19)
        pnlHeader.Margin = New Padding(4, 4, 4, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1436, 75)
        pnlHeader.TabIndex = 3
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(15), CByte(40), CByte(15))
        lblBadge.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(80), CByte(210), CByte(80))
        lblBadge.Location = New Point(1275, 24)
        lblBadge.Margin = New Padding(4, 0, 4, 0)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(112, 32)
        lblBadge.TabIndex = 9
        lblBadge.Text = "● READ ONLY"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 73)
        pnlHeaderAccent.Margin = New Padding(4, 4, 4, 4)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1436, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(19, 10)
        lblHeaderTitle.Margin = New Padding(4, 0, 4, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(388, 45)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(21, 50)
        lblHeaderSub.Margin = New Padding(4, 0, 4, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(218, 21)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Manajemen Tim / Konstruktor"
        ' 
        ' UC_TimUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UC_TimUser"
        Padding = New Padding(25, 19, 25, 19)
        Size = New Size(1486, 1166)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSearchTim As TextBox
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lblBadge As Label
End Class
