﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kodeBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.namaBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.satuan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.stok = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.beli = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jual = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.keterangan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.kategoriID = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.submit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.namaKategori = New System.Windows.Forms.ComboBox()
        Me.tanggalInput = New System.Windows.Forms.TextBox()
        Me.tanggalUpdate = New System.Windows.Forms.TextBox()
        Me.namaAdmin = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ppn = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.MidnightBlue
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 51
        Me.LineShape1.X2 = 955
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1019, 599)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Form Barang"
        '
        'kodeBarang
        '
        Me.kodeBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kodeBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.kodeBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kodeBarang.HintForeColor = System.Drawing.Color.Empty
        Me.kodeBarang.HintText = "Kode Barang"
        Me.kodeBarang.isPassword = False
        Me.kodeBarang.LineFocusedColor = System.Drawing.Color.Blue
        Me.kodeBarang.LineIdleColor = System.Drawing.Color.Gray
        Me.kodeBarang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.kodeBarang.LineThickness = 3
        Me.kodeBarang.Location = New System.Drawing.Point(89, 153)
        Me.kodeBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.kodeBarang.Name = "kodeBarang"
        Me.kodeBarang.Size = New System.Drawing.Size(114, 44)
        Me.kodeBarang.TabIndex = 1
        Me.kodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'namaBarang
        '
        Me.namaBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namaBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.namaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.namaBarang.HintForeColor = System.Drawing.Color.Empty
        Me.namaBarang.HintText = "Nama Barang"
        Me.namaBarang.isPassword = False
        Me.namaBarang.LineFocusedColor = System.Drawing.Color.Blue
        Me.namaBarang.LineIdleColor = System.Drawing.Color.Gray
        Me.namaBarang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.namaBarang.LineThickness = 3
        Me.namaBarang.Location = New System.Drawing.Point(89, 223)
        Me.namaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(353, 44)
        Me.namaBarang.TabIndex = 2
        Me.namaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'satuan
        '
        Me.satuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.satuan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.satuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.satuan.HintForeColor = System.Drawing.Color.Empty
        Me.satuan.HintText = "Satuan"
        Me.satuan.isPassword = False
        Me.satuan.LineFocusedColor = System.Drawing.Color.Blue
        Me.satuan.LineIdleColor = System.Drawing.Color.Gray
        Me.satuan.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.satuan.LineThickness = 3
        Me.satuan.Location = New System.Drawing.Point(89, 300)
        Me.satuan.Margin = New System.Windows.Forms.Padding(4)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(166, 44)
        Me.satuan.TabIndex = 3
        Me.satuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'stok
        '
        Me.stok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stok.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.stok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stok.HintForeColor = System.Drawing.Color.Empty
        Me.stok.HintText = "Stok"
        Me.stok.isPassword = False
        Me.stok.LineFocusedColor = System.Drawing.Color.Blue
        Me.stok.LineIdleColor = System.Drawing.Color.Gray
        Me.stok.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.stok.LineThickness = 3
        Me.stok.Location = New System.Drawing.Point(594, 153)
        Me.stok.Margin = New System.Windows.Forms.Padding(4)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(79, 44)
        Me.stok.TabIndex = 5
        Me.stok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'beli
        '
        Me.beli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beli.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.beli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.beli.HintForeColor = System.Drawing.Color.Empty
        Me.beli.HintText = "Harga Beli"
        Me.beli.isPassword = False
        Me.beli.LineFocusedColor = System.Drawing.Color.Blue
        Me.beli.LineIdleColor = System.Drawing.Color.Gray
        Me.beli.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.beli.LineThickness = 3
        Me.beli.Location = New System.Drawing.Point(594, 223)
        Me.beli.Margin = New System.Windows.Forms.Padding(4)
        Me.beli.Name = "beli"
        Me.beli.Size = New System.Drawing.Size(209, 44)
        Me.beli.TabIndex = 6
        Me.beli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'jual
        '
        Me.jual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jual.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.jual.HintForeColor = System.Drawing.Color.Empty
        Me.jual.HintText = "Harga Jual"
        Me.jual.isPassword = False
        Me.jual.LineFocusedColor = System.Drawing.Color.Blue
        Me.jual.LineIdleColor = System.Drawing.Color.Gray
        Me.jual.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.jual.LineThickness = 3
        Me.jual.Location = New System.Drawing.Point(594, 300)
        Me.jual.Margin = New System.Windows.Forms.Padding(4)
        Me.jual.Name = "jual"
        Me.jual.Size = New System.Drawing.Size(209, 44)
        Me.jual.TabIndex = 7
        Me.jual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'keterangan
        '
        Me.keterangan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.keterangan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.keterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.keterangan.HintForeColor = System.Drawing.Color.Empty
        Me.keterangan.HintText = "Keterangan"
        Me.keterangan.isPassword = False
        Me.keterangan.LineFocusedColor = System.Drawing.Color.Blue
        Me.keterangan.LineIdleColor = System.Drawing.Color.Gray
        Me.keterangan.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.keterangan.LineThickness = 3
        Me.keterangan.Location = New System.Drawing.Point(89, 457)
        Me.keterangan.Margin = New System.Windows.Forms.Padding(4)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(714, 44)
        Me.keterangan.TabIndex = 9
        Me.keterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(947, 187)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(35, 26)
        Me.id.TabIndex = 10
        Me.id.Visible = False
        '
        'kategoriID
        '
        Me.kategoriID.Enabled = False
        Me.kategoriID.Location = New System.Drawing.Point(947, 241)
        Me.kategoriID.Name = "kategoriID"
        Me.kategoriID.Size = New System.Drawing.Size(35, 26)
        Me.kategoriID.TabIndex = 11
        Me.kategoriID.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.submit
        '
        'submit
        '
        Me.submit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.submit.BorderRadius = 0
        Me.submit.ButtonText = "Submit"
        Me.submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit.DisabledColor = System.Drawing.Color.Gray
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Iconcolor = System.Drawing.Color.Transparent
        Me.submit.Iconimage = Nothing
        Me.submit.Iconimage_right = Nothing
        Me.submit.Iconimage_right_Selected = Nothing
        Me.submit.Iconimage_Selected = Nothing
        Me.submit.IconMarginLeft = 0
        Me.submit.IconMarginRight = 0
        Me.submit.IconRightVisible = True
        Me.submit.IconRightZoom = 0.0R
        Me.submit.IconVisible = True
        Me.submit.IconZoom = 90.0R
        Me.submit.IsTab = False
        Me.submit.Location = New System.Drawing.Point(112, 529)
        Me.submit.Margin = New System.Windows.Forms.Padding(5)
        Me.submit.Name = "submit"
        Me.submit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.submit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.submit.OnHoverTextColor = System.Drawing.Color.White
        Me.submit.selected = False
        Me.submit.Size = New System.Drawing.Size(91, 35)
        Me.submit.TabIndex = 17
        Me.submit.Text = "Submit"
        Me.submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.submit.Textcolor = System.Drawing.Color.White
        Me.submit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.cancel
        '
        'cancel
        '
        Me.cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancel.BorderRadius = 0
        Me.cancel.ButtonText = "Cancel"
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.DisabledColor = System.Drawing.Color.Gray
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Iconcolor = System.Drawing.Color.Transparent
        Me.cancel.Iconimage = Nothing
        Me.cancel.Iconimage_right = Nothing
        Me.cancel.Iconimage_right_Selected = Nothing
        Me.cancel.Iconimage_Selected = Nothing
        Me.cancel.IconMarginLeft = 0
        Me.cancel.IconMarginRight = 0
        Me.cancel.IconRightVisible = True
        Me.cancel.IconRightZoom = 0.0R
        Me.cancel.IconVisible = True
        Me.cancel.IconZoom = 90.0R
        Me.cancel.IsTab = False
        Me.cancel.Location = New System.Drawing.Point(213, 529)
        Me.cancel.Margin = New System.Windows.Forms.Padding(5)
        Me.cancel.Name = "cancel"
        Me.cancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cancel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.cancel.selected = False
        Me.cancel.Size = New System.Drawing.Size(91, 35)
        Me.cancel.TabIndex = 18
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cancel.Textcolor = System.Drawing.Color.White
        Me.cancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'namaKategori
        '
        Me.namaKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaKategori.FormattingEnabled = True
        Me.namaKategori.Location = New System.Drawing.Point(81, 404)
        Me.namaKategori.Name = "namaKategori"
        Me.namaKategori.Size = New System.Drawing.Size(205, 26)
        Me.namaKategori.TabIndex = 4
        '
        'tanggalInput
        '
        Me.tanggalInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalInput.Location = New System.Drawing.Point(829, 300)
        Me.tanggalInput.Name = "tanggalInput"
        Me.tanggalInput.Size = New System.Drawing.Size(154, 20)
        Me.tanggalInput.TabIndex = 19
        Me.tanggalInput.Visible = False
        '
        'tanggalUpdate
        '
        Me.tanggalUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggalUpdate.Location = New System.Drawing.Point(829, 332)
        Me.tanggalUpdate.Name = "tanggalUpdate"
        Me.tanggalUpdate.Size = New System.Drawing.Size(154, 20)
        Me.tanggalUpdate.TabIndex = 20
        Me.tanggalUpdate.Visible = False
        '
        'namaAdmin
        '
        Me.namaAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaAdmin.Location = New System.Drawing.Point(829, 364)
        Me.namaAdmin.Name = "namaAdmin"
        Me.namaAdmin.Size = New System.Drawing.Size(154, 20)
        Me.namaAdmin.TabIndex = 21
        Me.namaAdmin.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AplikasiPenjualan.My.Resources.Resources.box_edit_1_100px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(89, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ppn
        '
        Me.ppn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppn.FormattingEnabled = True
        Me.ppn.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.ppn.Location = New System.Drawing.Point(594, 404)
        Me.ppn.Name = "ppn"
        Me.ppn.Size = New System.Drawing.Size(93, 26)
        Me.ppn.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "PPN"
        '
        'FormAddBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 599)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ppn)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.namaAdmin)
        Me.Controls.Add(Me.tanggalUpdate)
        Me.Controls.Add(Me.tanggalInput)
        Me.Controls.Add(Me.namaKategori)
        Me.Controls.Add(Me.kategoriID)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.beli)
        Me.Controls.Add(Me.namaBarang)
        Me.Controls.Add(Me.jual)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.kodeBarang)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormAddBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kodeBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents namaBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents satuan As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents stok As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents beli As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jual As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents keterangan As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents kategoriID As System.Windows.Forms.TextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents namaKategori As System.Windows.Forms.ComboBox
    Friend WithEvents tanggalInput As System.Windows.Forms.TextBox
    Friend WithEvents tanggalUpdate As System.Windows.Forms.TextBox
    Friend WithEvents namaAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents submit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ppn As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
End Class
