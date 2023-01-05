<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatSemuaJadwalTayang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LihatSemuaJadwalTayang))
        Me.DataGridViewJadwalTayangAll = New System.Windows.Forms.DataGridView()
        Me.IdJadwalTayang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFilm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdStudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoFilm = New System.Windows.Forms.DataGridViewImageColumn()
        Me.JudulFilm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Studio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalTayang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktuMulai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktuSelesai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTiket = New System.Windows.Forms.Button()
        Me.BtnJadwalTayang = New System.Windows.Forms.Button()
        Me.BtnStudio = New System.Windows.Forms.Button()
        Me.BtnFilm = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonLihat = New System.Windows.Forms.Button()
        CType(Me.DataGridViewJadwalTayangAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewJadwalTayangAll
        '
        Me.DataGridViewJadwalTayangAll.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DataGridViewJadwalTayangAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJadwalTayangAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdJadwalTayang, Me.IdFilm, Me.IdStudio, Me.FotoFilm, Me.JudulFilm, Me.Studio, Me.TanggalTayang, Me.WaktuMulai, Me.WaktuSelesai})
        Me.DataGridViewJadwalTayangAll.Location = New System.Drawing.Point(85, 370)
        Me.DataGridViewJadwalTayangAll.Name = "DataGridViewJadwalTayangAll"
        Me.DataGridViewJadwalTayangAll.RowHeadersWidth = 82
        Me.DataGridViewJadwalTayangAll.RowTemplate.Height = 41
        Me.DataGridViewJadwalTayangAll.Size = New System.Drawing.Size(2056, 413)
        Me.DataGridViewJadwalTayangAll.TabIndex = 40
        '
        'IdJadwalTayang
        '
        Me.IdJadwalTayang.HeaderText = "Id Jadwal Tayang"
        Me.IdJadwalTayang.MinimumWidth = 10
        Me.IdJadwalTayang.Name = "IdJadwalTayang"
        Me.IdJadwalTayang.ReadOnly = True
        Me.IdJadwalTayang.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdJadwalTayang.Visible = False
        Me.IdJadwalTayang.Width = 200
        '
        'IdFilm
        '
        Me.IdFilm.HeaderText = "Id Film"
        Me.IdFilm.MinimumWidth = 10
        Me.IdFilm.Name = "IdFilm"
        Me.IdFilm.ReadOnly = True
        Me.IdFilm.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdFilm.Visible = False
        Me.IdFilm.Width = 200
        '
        'IdStudio
        '
        Me.IdStudio.HeaderText = "Id Studio"
        Me.IdStudio.MinimumWidth = 10
        Me.IdStudio.Name = "IdStudio"
        Me.IdStudio.ReadOnly = True
        Me.IdStudio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdStudio.Visible = False
        Me.IdStudio.Width = 200
        '
        'FotoFilm
        '
        Me.FotoFilm.HeaderText = "Foto Film"
        Me.FotoFilm.MinimumWidth = 10
        Me.FotoFilm.Name = "FotoFilm"
        Me.FotoFilm.Width = 260
        '
        'JudulFilm
        '
        Me.JudulFilm.HeaderText = "Judul Film"
        Me.JudulFilm.MinimumWidth = 10
        Me.JudulFilm.Name = "JudulFilm"
        Me.JudulFilm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JudulFilm.Width = 700
        '
        'Studio
        '
        Me.Studio.HeaderText = "Studio"
        Me.Studio.MinimumWidth = 10
        Me.Studio.Name = "Studio"
        Me.Studio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Studio.Width = 570
        '
        'TanggalTayang
        '
        Me.TanggalTayang.HeaderText = "Tanggal Tayang"
        Me.TanggalTayang.MinimumWidth = 10
        Me.TanggalTayang.Name = "TanggalTayang"
        Me.TanggalTayang.Width = 180
        '
        'WaktuMulai
        '
        Me.WaktuMulai.HeaderText = "Mulai Tayang"
        Me.WaktuMulai.MinimumWidth = 10
        Me.WaktuMulai.Name = "WaktuMulai"
        Me.WaktuMulai.Width = 110
        '
        'WaktuSelesai
        '
        Me.WaktuSelesai.HeaderText = "Selesai Tayang"
        Me.WaktuSelesai.MinimumWidth = 10
        Me.WaktuSelesai.Name = "WaktuSelesai"
        Me.WaktuSelesai.Width = 110
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Foto Film"
        Me.DataGridViewImageColumn1.MinimumWidth = 10
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nama Film"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 685
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Studio"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Algerian", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2228, 53)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "===================================  All Movie Showtimes  =======================" &
    "============" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lblid.Location = New System.Drawing.Point(2045, 152)
        Me.Lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(34, 36)
        Me.Lblid.TabIndex = 36
        Me.Lblid.Text = "1"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.Location = New System.Drawing.Point(58, 152)
        Me.LblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(170, 36)
        Me.LblUsername.TabIndex = 34
        Me.LblUsername.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1972, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 36)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "ID :"
        '
        'ButtonBack
        '
        Me.ButtonBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(13, 22)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(230, 64)
        Me.ButtonBack.TabIndex = 39
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonLihat)
        Me.Panel2.Controls.Add(Me.ButtonHapus)
        Me.Panel2.Controls.Add(Me.ButtonBack)
        Me.Panel2.Controls.Add(Me.ButtonEdit)
        Me.Panel2.Controls.Add(Me.ButtonTambah)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 830)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2228, 99)
        Me.Panel2.TabIndex = 41
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonHapus.FlatAppearance.BorderSize = 0
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonHapus.ForeColor = System.Drawing.Color.White
        Me.ButtonHapus.Location = New System.Drawing.Point(1985, 22)
        Me.ButtonHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(230, 64)
        Me.ButtonHapus.TabIndex = 29
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(1731, 22)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(230, 64)
        Me.ButtonEdit.TabIndex = 30
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTambah.ForeColor = System.Drawing.Color.White
        Me.ButtonTambah.Location = New System.Drawing.Point(1472, 22)
        Me.ButtonTambah.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(230, 64)
        Me.ButtonTambah.TabIndex = 31
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnSignOut)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnTiket)
        Me.Panel1.Controls.Add(Me.BtnJadwalTayang)
        Me.Panel1.Controls.Add(Me.BtnStudio)
        Me.Panel1.Controls.Add(Me.BtnFilm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2228, 118)
        Me.Panel1.TabIndex = 42
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BtnSignOut.FlatAppearance.BorderSize = 0
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignOut.ForeColor = System.Drawing.Color.White
        Me.BtnSignOut.Location = New System.Drawing.Point(1985, 33)
        Me.BtnSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(195, 59)
        Me.BtnSignOut.TabIndex = 27
        Me.BtnSignOut.Text = "Sign Out"
        Me.BtnSignOut.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(58, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 77)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Bioscoop"
        '
        'BtnTiket
        '
        Me.BtnTiket.AutoSize = True
        Me.BtnTiket.FlatAppearance.BorderSize = 0
        Me.BtnTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTiket.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTiket.ForeColor = System.Drawing.Color.White
        Me.BtnTiket.Location = New System.Drawing.Point(1346, 3)
        Me.BtnTiket.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTiket.Name = "BtnTiket"
        Me.BtnTiket.Size = New System.Drawing.Size(148, 115)
        Me.BtnTiket.TabIndex = 3
        Me.BtnTiket.Text = "Tiket"
        Me.BtnTiket.UseVisualStyleBackColor = True
        '
        'BtnJadwalTayang
        '
        Me.BtnJadwalTayang.FlatAppearance.BorderSize = 0
        Me.BtnJadwalTayang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJadwalTayang.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnJadwalTayang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BtnJadwalTayang.Location = New System.Drawing.Point(670, 0)
        Me.BtnJadwalTayang.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnJadwalTayang.Name = "BtnJadwalTayang"
        Me.BtnJadwalTayang.Size = New System.Drawing.Size(294, 115)
        Me.BtnJadwalTayang.TabIndex = 2
        Me.BtnJadwalTayang.Text = "Jadwal Tayang"
        Me.BtnJadwalTayang.UseVisualStyleBackColor = True
        '
        'BtnStudio
        '
        Me.BtnStudio.FlatAppearance.BorderSize = 0
        Me.BtnStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudio.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnStudio.ForeColor = System.Drawing.Color.White
        Me.BtnStudio.Location = New System.Drawing.Point(1173, 3)
        Me.BtnStudio.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStudio.Name = "BtnStudio"
        Me.BtnStudio.Size = New System.Drawing.Size(146, 111)
        Me.BtnStudio.TabIndex = 1
        Me.BtnStudio.Text = "Studio"
        Me.BtnStudio.UseVisualStyleBackColor = True
        '
        'BtnFilm
        '
        Me.BtnFilm.FlatAppearance.BorderSize = 0
        Me.BtnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFilm.ForeColor = System.Drawing.Color.White
        Me.BtnFilm.Location = New System.Drawing.Point(984, 3)
        Me.BtnFilm.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFilm.Name = "BtnFilm"
        Me.BtnFilm.Size = New System.Drawing.Size(146, 111)
        Me.BtnFilm.TabIndex = 0
        Me.BtnFilm.Text = "Film"
        Me.BtnFilm.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxSearch.Location = New System.Drawing.Point(44, 2)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.PlaceholderText = "Search..."
        Me.TextBoxSearch.Size = New System.Drawing.Size(1989, 32)
        Me.TextBoxSearch.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBoxSearch)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(85, 308)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2056, 39)
        Me.Panel3.TabIndex = 45
        '
        'ButtonLihat
        '
        Me.ButtonLihat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLihat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonLihat.FlatAppearance.BorderSize = 0
        Me.ButtonLihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLihat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonLihat.ForeColor = System.Drawing.Color.White
        Me.ButtonLihat.Location = New System.Drawing.Point(1213, 22)
        Me.ButtonLihat.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLihat.Name = "ButtonLihat"
        Me.ButtonLihat.Size = New System.Drawing.Size(230, 64)
        Me.ButtonLihat.TabIndex = 40
        Me.ButtonLihat.Text = "Lihat"
        Me.ButtonLihat.UseVisualStyleBackColor = False
        '
        'LihatSemuaJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2228, 929)
        Me.Controls.Add(Me.DataGridViewJadwalTayangAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblid)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "LihatSemuaJadwalTayang"
        Me.Text = "LihatSemuaJadwalTayang"
        CType(Me.DataGridViewJadwalTayangAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewJadwalTayangAll As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblid As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTiket As Button
    Friend WithEvents BtnJadwalTayang As Button
    Friend WithEvents BtnStudio As Button
    Friend WithEvents BtnFilm As Button
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IdJadwalTayang As DataGridViewTextBoxColumn
    Friend WithEvents IdFilm As DataGridViewTextBoxColumn
    Friend WithEvents IdStudio As DataGridViewTextBoxColumn
    Friend WithEvents FotoFilm As DataGridViewImageColumn
    Friend WithEvents JudulFilm As DataGridViewTextBoxColumn
    Friend WithEvents Studio As DataGridViewTextBoxColumn
    Friend WithEvents TanggalTayang As DataGridViewTextBoxColumn
    Friend WithEvents WaktuMulai As DataGridViewTextBoxColumn
    Friend WithEvents WaktuSelesai As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLihat As Button
End Class
