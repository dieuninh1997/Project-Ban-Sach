<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTaiLieu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTaiLieu))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.trans1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnTimKiem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnThemMoi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tab1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgTaiLieu = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lb_soSach = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTimKiem = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tran1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XemChiTiếtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SửaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.dgTaiLieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.trans1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnTimKiem)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuFlatButton4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuGradientPanel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnThemMoi)
        Me.BunifuGradientPanel1.Controls.Add(Me.tab1)
        Me.BunifuGradientPanel1.Controls.Add(Me.tab2)
        Me.BunifuGradientPanel1.Controls.Add(Me.tab3)
        Me.BunifuGradientPanel1.Controls.Add(Me.tab4)
        Me.BunifuGradientPanel1.Controls.Add(Me.tab5)
        Me.tran1.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(844, 57)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'trans1
        '
        Me.trans1.BackColor = System.Drawing.Color.Transparent
        Me.tran1.SetDecoration(Me.trans1, BunifuAnimatorNS.DecorationType.None)
        Me.trans1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.trans1.LineThickness = 5
        Me.trans1.Location = New System.Drawing.Point(22, 52)
        Me.trans1.Name = "trans1"
        Me.trans1.Size = New System.Drawing.Size(75, 5)
        Me.trans1.TabIndex = 18
        Me.trans1.Transparency = 255
        Me.trans1.Vertical = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimKiem.BorderRadius = 0
        Me.btnTimKiem.ButtonText = ""
        Me.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tran1.SetDecoration(Me.btnTimKiem, BunifuAnimatorNS.DecorationType.None)
        Me.btnTimKiem.DisabledColor = System.Drawing.Color.Gray
        Me.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTimKiem.Iconimage = CType(resources.GetObject("btnTimKiem.Iconimage"), System.Drawing.Image)
        Me.btnTimKiem.Iconimage_right = Nothing
        Me.btnTimKiem.Iconimage_right_Selected = Nothing
        Me.btnTimKiem.Iconimage_Selected = Nothing
        Me.btnTimKiem.IconMarginLeft = 0
        Me.btnTimKiem.IconMarginRight = 0
        Me.btnTimKiem.IconRightVisible = True
        Me.btnTimKiem.IconRightZoom = 0R
        Me.btnTimKiem.IconVisible = True
        Me.btnTimKiem.IconZoom = 40.0R
        Me.btnTimKiem.IsTab = False
        Me.btnTimKiem.Location = New System.Drawing.Point(781, 18)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Normalcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTimKiem.OnHovercolor = System.Drawing.Color.WhiteSmoke
        Me.btnTimKiem.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnTimKiem.selected = False
        Me.btnTimKiem.Size = New System.Drawing.Size(30, 30)
        Me.btnTimKiem.TabIndex = 17
        Me.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimKiem.Textcolor = System.Drawing.Color.Black
        Me.btnTimKiem.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = ""
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tran1.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 40.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(735, 18)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(30, 30)
        Me.BunifuFlatButton4.TabIndex = 16
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tran1.SetDecoration(Me.BunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(436, 99)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(8, 8)
        Me.BunifuGradientPanel2.TabIndex = 0
        '
        'btnThemMoi
        '
        Me.btnThemMoi.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnThemMoi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnThemMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThemMoi.BorderRadius = 0
        Me.btnThemMoi.ButtonText = ""
        Me.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tran1.SetDecoration(Me.btnThemMoi, BunifuAnimatorNS.DecorationType.None)
        Me.btnThemMoi.DisabledColor = System.Drawing.Color.Gray
        Me.btnThemMoi.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThemMoi.Iconimage = CType(resources.GetObject("btnThemMoi.Iconimage"), System.Drawing.Image)
        Me.btnThemMoi.Iconimage_right = Nothing
        Me.btnThemMoi.Iconimage_right_Selected = Nothing
        Me.btnThemMoi.Iconimage_Selected = Nothing
        Me.btnThemMoi.IconMarginLeft = 0
        Me.btnThemMoi.IconMarginRight = 0
        Me.btnThemMoi.IconRightVisible = True
        Me.btnThemMoi.IconRightZoom = 0R
        Me.btnThemMoi.IconVisible = True
        Me.btnThemMoi.IconZoom = 40.0R
        Me.btnThemMoi.IsTab = False
        Me.btnThemMoi.Location = New System.Drawing.Point(688, 18)
        Me.btnThemMoi.Name = "btnThemMoi"
        Me.btnThemMoi.Normalcolor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnThemMoi.OnHovercolor = System.Drawing.Color.WhiteSmoke
        Me.btnThemMoi.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThemMoi.selected = False
        Me.btnThemMoi.Size = New System.Drawing.Size(30, 30)
        Me.btnThemMoi.TabIndex = 15
        Me.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThemMoi.Textcolor = System.Drawing.Color.Black
        Me.btnThemMoi.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tab1
        '
        Me.tran1.SetDecoration(Me.tab1, BunifuAnimatorNS.DecorationType.None)
        Me.tab1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1.Location = New System.Drawing.Point(22, 29)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(75, 28)
        Me.tab1.TabIndex = 19
        Me.tab1.Text = "Tất cả"
        Me.tab1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tab2
        '
        Me.tran1.SetDecoration(Me.tab2, BunifuAnimatorNS.DecorationType.None)
        Me.tab2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2.Location = New System.Drawing.Point(103, 29)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(75, 28)
        Me.tab2.TabIndex = 21
        Me.tab2.Text = "Tác giả"
        Me.tab2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tab3
        '
        Me.tran1.SetDecoration(Me.tab3, BunifuAnimatorNS.DecorationType.None)
        Me.tab3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3.Location = New System.Drawing.Point(184, 29)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(75, 28)
        Me.tab3.TabIndex = 22
        Me.tab3.Text = "Thể loại"
        Me.tab3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tab4
        '
        Me.tran1.SetDecoration(Me.tab4, BunifuAnimatorNS.DecorationType.None)
        Me.tab4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4.Location = New System.Drawing.Point(265, 29)
        Me.tab4.Name = "tab4"
        Me.tab4.Size = New System.Drawing.Size(110, 28)
        Me.tab4.TabIndex = 23
        Me.tab4.Text = "Nhà xuất bản"
        Me.tab4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tab5
        '
        Me.tran1.SetDecoration(Me.tab5, BunifuAnimatorNS.DecorationType.None)
        Me.tab5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab5.Location = New System.Drawing.Point(381, 29)
        Me.tab5.Name = "tab5"
        Me.tab5.Size = New System.Drawing.Size(110, 28)
        Me.tab5.TabIndex = 24
        Me.tab5.Text = "Phiếu nhập"
        Me.tab5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BunifuCustomLabel1
        '
        Me.tran1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(20, 72)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(257, 35)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Danh sách tài liệu"
        '
        'dgTaiLieu
        '
        Me.dgTaiLieu.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgTaiLieu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTaiLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTaiLieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTaiLieu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dgTaiLieu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTaiLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTaiLieu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tran1.SetDecoration(Me.dgTaiLieu, BunifuAnimatorNS.DecorationType.None)
        Me.dgTaiLieu.DoubleBuffered = True
        Me.dgTaiLieu.EnableHeadersVisualStyles = False
        Me.dgTaiLieu.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgTaiLieu.HeaderForeColor = System.Drawing.Color.Black
        Me.dgTaiLieu.Location = New System.Drawing.Point(25, 137)
        Me.dgTaiLieu.Name = "dgTaiLieu"
        Me.dgTaiLieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgTaiLieu.Size = New System.Drawing.Size(786, 457)
        Me.dgTaiLieu.TabIndex = 3
        '
        'lb_soSach
        '
        Me.lb_soSach.AutoSize = True
        Me.tran1.SetDecoration(Me.lb_soSach, BunifuAnimatorNS.DecorationType.None)
        Me.lb_soSach.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_soSach.Location = New System.Drawing.Point(24, 107)
        Me.lb_soSach.Name = "lb_soSach"
        Me.lb_soSach.Size = New System.Drawing.Size(154, 15)
        Me.lb_soSach.TabIndex = 4
        Me.lb_soSach.Text = "(Có 15 đầu tài liệu) "
        '
        'txtTimKiem
        '
        Me.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tran1.SetDecoration(Me.txtTimKiem, BunifuAnimatorNS.DecorationType.None)
        Me.txtTimKiem.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTimKiem.ForeColor = System.Drawing.Color.Black
        Me.txtTimKiem.HintForeColor = System.Drawing.Color.Gray
        Me.txtTimKiem.HintText = "Tìm kiếm ..."
        Me.txtTimKiem.isPassword = False
        Me.txtTimKiem.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtTimKiem.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtTimKiem.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtTimKiem.LineThickness = 3
        Me.txtTimKiem.Location = New System.Drawing.Point(374, 75)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(437, 32)
        Me.txtTimKiem.TabIndex = 7
        Me.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tran1
        '
        Me.tran1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.tran1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 20
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.tran1.DefaultAnimation = Animation1
        '
        'ContextMenuStrip1
        '
        Me.tran1.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XemChiTiếtToolStripMenuItem, Me.XóaToolStripMenuItem, Me.SửaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'XemChiTiếtToolStripMenuItem
        '
        Me.XemChiTiếtToolStripMenuItem.Name = "XemChiTiếtToolStripMenuItem"
        Me.XemChiTiếtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.XemChiTiếtToolStripMenuItem.Text = "Xem chi tiết"
        '
        'XóaToolStripMenuItem
        '
        Me.XóaToolStripMenuItem.Name = "XóaToolStripMenuItem"
        Me.XóaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.XóaToolStripMenuItem.Text = "Xóa"
        '
        'SửaToolStripMenuItem
        '
        Me.SửaToolStripMenuItem.Name = "SửaToolStripMenuItem"
        Me.SửaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SửaToolStripMenuItem.Text = "Sửa"
        '
        'FormTaiLieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.lb_soSach)
        Me.Controls.Add(Me.dgTaiLieu)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.tran1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "FormTaiLieu"
        Me.Size = New System.Drawing.Size(844, 619)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.dgTaiLieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgTaiLieu As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnTimKiem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThemMoi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents trans1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents tab1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_soSach As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTimKiem As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tran1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tab5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents XemChiTiếtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XóaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SửaToolStripMenuItem As ToolStripMenuItem
End Class
