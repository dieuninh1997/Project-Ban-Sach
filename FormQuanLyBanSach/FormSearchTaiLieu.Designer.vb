<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearchTaiLieu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearchTaiLieu))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnThuNho = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuFlatButton2)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnThuNho)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Cyan
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Cyan
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(649, 51)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'btnThuNho
        '
        Me.btnThuNho.Activecolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnThuNho.BackColor = System.Drawing.Color.Cyan
        Me.btnThuNho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThuNho.BorderRadius = 0
        Me.btnThuNho.ButtonText = ""
        Me.btnThuNho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThuNho.DisabledColor = System.Drawing.Color.Gray
        Me.btnThuNho.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThuNho.Iconimage = CType(resources.GetObject("btnThuNho.Iconimage"), System.Drawing.Image)
        Me.btnThuNho.Iconimage_right = Nothing
        Me.btnThuNho.Iconimage_right_Selected = Nothing
        Me.btnThuNho.Iconimage_Selected = Nothing
        Me.btnThuNho.IconMarginLeft = 0
        Me.btnThuNho.IconMarginRight = 0
        Me.btnThuNho.IconRightVisible = True
        Me.btnThuNho.IconRightZoom = 0R
        Me.btnThuNho.IconVisible = True
        Me.btnThuNho.IconZoom = 40.0R
        Me.btnThuNho.IsTab = False
        Me.btnThuNho.Location = New System.Drawing.Point(609, 5)
        Me.btnThuNho.Name = "btnThuNho"
        Me.btnThuNho.Normalcolor = System.Drawing.Color.Cyan
        Me.btnThuNho.OnHovercolor = System.Drawing.Color.WhiteSmoke
        Me.btnThuNho.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThuNho.selected = False
        Me.btnThuNho.Size = New System.Drawing.Size(30, 30)
        Me.btnThuNho.TabIndex = 2
        Me.btnThuNho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThuNho.Textcolor = System.Drawing.Color.Black
        Me.btnThuNho.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.HintText = "Tìm kiếm ..."
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(24, 9)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(519, 32)
        Me.BunifuMaterialTextbox1.TabIndex = 6
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Cyan
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuFlatButton2.ButtonText = ""
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 40.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(550, 9)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Cyan
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.WhiteSmoke
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(32, 32)
        Me.BunifuFlatButton2.TabIndex = 7
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(649, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 86)
        Me.Panel1.TabIndex = 9
        '
        'FormSearchTaiLieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormSearchTaiLieu"
        Me.Size = New System.Drawing.Size(650, 86)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnThuNho As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
End Class
