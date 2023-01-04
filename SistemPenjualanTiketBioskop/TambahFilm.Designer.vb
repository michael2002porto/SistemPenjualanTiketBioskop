<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahFilm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.LblValueDeskripsi = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahFilm = New System.Windows.Forms.Button()
        Me.ChckAdventure = New System.Windows.Forms.CheckBox()
        Me.ChckHoror = New System.Windows.Forms.CheckBox()
        Me.ChckComedy = New System.Windows.Forms.CheckBox()
        Me.ChckDrama = New System.Windows.Forms.CheckBox()
        Me.GroupGenre = New System.Windows.Forms.GroupBox()
        Me.ChckCrime = New System.Windows.Forms.CheckBox()
        Me.ChckMistery = New System.Windows.Forms.CheckBox()
        Me.ChckBiografi = New System.Windows.Forms.CheckBox()
        Me.ChckMusical = New System.Windows.Forms.CheckBox()
        Me.ChckThriller = New System.Windows.Forms.CheckBox()
        Me.ChckScifi = New System.Windows.Forms.CheckBox()
        Me.ChckRomance = New System.Windows.Forms.CheckBox()
        Me.ChckDocumenter = New System.Windows.Forms.CheckBox()
        Me.ChckAnimation = New System.Windows.Forms.CheckBox()
        Me.ChckAction = New System.Windows.Forms.CheckBox()
        Me.TxtHargaFilm = New System.Windows.Forms.TextBox()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.RichDeskripsiFilm = New System.Windows.Forms.RichTextBox()
        Me.DateTimePickerRelease = New System.Windows.Forms.DateTimePicker()
        Me.TxtFilm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxRatingUsia = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBahasa = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGenre.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblValueDeskripsi
        '
        Me.LblValueDeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblValueDeskripsi.AutoSize = True
        Me.LblValueDeskripsi.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblValueDeskripsi.Location = New System.Drawing.Point(909, 401)
        Me.LblValueDeskripsi.Name = "LblValueDeskripsi"
        Me.LblValueDeskripsi.Size = New System.Drawing.Size(60, 34)
        Me.LblValueDeskripsi.TabIndex = 53
        Me.LblValueDeskripsi.Text = "268"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicFoto
        '
        Me.PicFoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFoto.Location = New System.Drawing.Point(37, 106)
        Me.PicFoto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(231, 279)
        Me.PicFoto.TabIndex = 51
        Me.PicFoto.TabStop = False
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnTambahFilm.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahFilm.FlatAppearance.BorderSize = 0
        Me.BtnTambahFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahFilm.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahFilm.ForeColor = System.Drawing.Color.White
        Me.BtnTambahFilm.Location = New System.Drawing.Point(411, 929)
        Me.BtnTambahFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(208, 37)
        Me.BtnTambahFilm.TabIndex = 50
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = False
        '
        'ChckAdventure
        '
        Me.ChckAdventure.AutoSize = True
        Me.ChckAdventure.Location = New System.Drawing.Point(7, 119)
        Me.ChckAdventure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckAdventure.Name = "ChckAdventure"
        Me.ChckAdventure.Size = New System.Drawing.Size(171, 38)
        Me.ChckAdventure.TabIndex = 3
        Me.ChckAdventure.Text = "Adventure"
        Me.ChckAdventure.UseVisualStyleBackColor = True
        '
        'ChckHoror
        '
        Me.ChckHoror.AutoSize = True
        Me.ChckHoror.Location = New System.Drawing.Point(7, 88)
        Me.ChckHoror.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckHoror.Name = "ChckHoror"
        Me.ChckHoror.Size = New System.Drawing.Size(119, 38)
        Me.ChckHoror.TabIndex = 2
        Me.ChckHoror.Text = "Horor"
        Me.ChckHoror.UseVisualStyleBackColor = True
        '
        'ChckComedy
        '
        Me.ChckComedy.AutoSize = True
        Me.ChckComedy.Location = New System.Drawing.Point(7, 57)
        Me.ChckComedy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckComedy.Name = "ChckComedy"
        Me.ChckComedy.Size = New System.Drawing.Size(112, 29)
        Me.ChckComedy.TabIndex = 1
        Me.ChckComedy.Text = "Comedy"
        Me.ChckComedy.UseVisualStyleBackColor = True
        '
        'ChckDrama
        '
        Me.ChckDrama.AutoSize = True
        Me.ChckDrama.Location = New System.Drawing.Point(7, 26)
        Me.ChckDrama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckDrama.Name = "ChckDrama"
        Me.ChckDrama.Size = New System.Drawing.Size(128, 38)
        Me.ChckDrama.TabIndex = 0
        Me.ChckDrama.Text = "Drama"
        Me.ChckDrama.UseVisualStyleBackColor = True
        '
        'GroupGenre
        '
        Me.GroupGenre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupGenre.Controls.Add(Me.ChckCrime)
        Me.GroupGenre.Controls.Add(Me.ChckMistery)
        Me.GroupGenre.Controls.Add(Me.ChckBiografi)
        Me.GroupGenre.Controls.Add(Me.ChckMusical)
        Me.GroupGenre.Controls.Add(Me.ChckThriller)
        Me.GroupGenre.Controls.Add(Me.ChckScifi)
        Me.GroupGenre.Controls.Add(Me.ChckRomance)
        Me.GroupGenre.Controls.Add(Me.ChckDocumenter)
        Me.GroupGenre.Controls.Add(Me.ChckAnimation)
        Me.GroupGenre.Controls.Add(Me.ChckAction)
        Me.GroupGenre.Controls.Add(Me.ChckAdventure)
        Me.GroupGenre.Controls.Add(Me.ChckHoror)
        Me.GroupGenre.Controls.Add(Me.ChckComedy)
        Me.GroupGenre.Controls.Add(Me.ChckDrama)
        Me.GroupGenre.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupGenre.Location = New System.Drawing.Point(521, 661)
        Me.GroupGenre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupGenre.Name = "GroupGenre"
        Me.GroupGenre.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupGenre.Size = New System.Drawing.Size(382, 252)
        Me.GroupGenre.TabIndex = 49
        Me.GroupGenre.TabStop = False
        Me.GroupGenre.Text = "Genre"
        '
        'ChckCrime
        '
        Me.ChckCrime.AutoSize = True
        Me.ChckCrime.Location = New System.Drawing.Point(232, 211)
        Me.ChckCrime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckCrime.Name = "ChckCrime"
        Me.ChckCrime.Size = New System.Drawing.Size(92, 29)
        Me.ChckCrime.TabIndex = 14
        Me.ChckCrime.Text = "Crime"
        Me.ChckCrime.UseVisualStyleBackColor = True
        '
        'ChckMistery
        '
        Me.ChckMistery.AutoSize = True
        Me.ChckMistery.Location = New System.Drawing.Point(232, 119)
        Me.ChckMistery.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckMistery.Name = "ChckMistery"
        Me.ChckMistery.Size = New System.Drawing.Size(137, 38)
        Me.ChckMistery.TabIndex = 12
        Me.ChckMistery.Text = "Mistery"
        Me.ChckMistery.UseVisualStyleBackColor = True
        '
        'ChckBiografi
        '
        Me.ChckBiografi.AutoSize = True
        Me.ChckBiografi.Location = New System.Drawing.Point(232, 150)
        Me.ChckBiografi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckBiografi.Name = "ChckBiografi"
        Me.ChckBiografi.Size = New System.Drawing.Size(143, 38)
        Me.ChckBiografi.TabIndex = 11
        Me.ChckBiografi.Text = "Biografi"
        Me.ChckBiografi.UseVisualStyleBackColor = True
        '
        'ChckMusical
        '
        Me.ChckMusical.AutoSize = True
        Me.ChckMusical.Location = New System.Drawing.Point(232, 180)
        Me.ChckMusical.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckMusical.Name = "ChckMusical"
        Me.ChckMusical.Size = New System.Drawing.Size(140, 38)
        Me.ChckMusical.TabIndex = 10
        Me.ChckMusical.Text = "Musical"
        Me.ChckMusical.UseVisualStyleBackColor = True
        '
        'ChckThriller
        '
        Me.ChckThriller.AutoSize = True
        Me.ChckThriller.Location = New System.Drawing.Point(232, 88)
        Me.ChckThriller.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckThriller.Name = "ChckThriller"
        Me.ChckThriller.Size = New System.Drawing.Size(135, 38)
        Me.ChckThriller.TabIndex = 9
        Me.ChckThriller.Text = "Thriller"
        Me.ChckThriller.UseVisualStyleBackColor = True
        '
        'ChckScifi
        '
        Me.ChckScifi.AutoSize = True
        Me.ChckScifi.Location = New System.Drawing.Point(232, 57)
        Me.ChckScifi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckScifi.Name = "ChckScifi"
        Me.ChckScifi.Size = New System.Drawing.Size(111, 38)
        Me.ChckScifi.TabIndex = 8
        Me.ChckScifi.Text = "Sci-fi"
        Me.ChckScifi.UseVisualStyleBackColor = True
        '
        'ChckRomance
        '
        Me.ChckRomance.AutoSize = True
        Me.ChckRomance.Location = New System.Drawing.Point(232, 26)
        Me.ChckRomance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckRomance.Name = "ChckRomance"
        Me.ChckRomance.Size = New System.Drawing.Size(159, 38)
        Me.ChckRomance.TabIndex = 7
        Me.ChckRomance.Text = "Romance"
        Me.ChckRomance.UseVisualStyleBackColor = True
        '
        'ChckDocumenter
        '
        Me.ChckDocumenter.AutoSize = True
        Me.ChckDocumenter.Location = New System.Drawing.Point(7, 211)
        Me.ChckDocumenter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckDocumenter.Name = "ChckDocumenter"
        Me.ChckDocumenter.Size = New System.Drawing.Size(145, 29)
        Me.ChckDocumenter.TabIndex = 6
        Me.ChckDocumenter.Text = "Documenter"
        Me.ChckDocumenter.UseVisualStyleBackColor = True
        '
        'ChckAnimation
        '
        Me.ChckAnimation.AutoSize = True
        Me.ChckAnimation.Location = New System.Drawing.Point(7, 180)
        Me.ChckAnimation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckAnimation.Name = "ChckAnimation"
        Me.ChckAnimation.Size = New System.Drawing.Size(129, 29)
        Me.ChckAnimation.TabIndex = 5
        Me.ChckAnimation.Text = "Animation"
        Me.ChckAnimation.UseVisualStyleBackColor = True
        '
        'ChckAction
        '
        Me.ChckAction.AutoSize = True
        Me.ChckAction.Location = New System.Drawing.Point(7, 150)
        Me.ChckAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckAction.Name = "ChckAction"
        Me.ChckAction.Size = New System.Drawing.Size(126, 38)
        Me.ChckAction.TabIndex = 4
        Me.ChckAction.Text = "Action"
        Me.ChckAction.UseVisualStyleBackColor = True
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtHargaFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtHargaFilm.Location = New System.Drawing.Point(521, 548)
        Me.TxtHargaFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(382, 44)
        Me.TxtHargaFilm.TabIndex = 46
        '
        'TxtDuration
        '
        Me.TxtDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDuration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDuration.Location = New System.Drawing.Point(521, 444)
        Me.TxtDuration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(382, 44)
        Me.TxtDuration.TabIndex = 44
        '
        'RichDeskripsiFilm
        '
        Me.RichDeskripsiFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichDeskripsiFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichDeskripsiFilm.Location = New System.Drawing.Point(521, 259)
        Me.RichDeskripsiFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichDeskripsiFilm.Name = "RichDeskripsiFilm"
        Me.RichDeskripsiFilm.Size = New System.Drawing.Size(382, 167)
        Me.RichDeskripsiFilm.TabIndex = 43
        Me.RichDeskripsiFilm.Text = ""
        '
        'DateTimePickerRelease
        '
        Me.DateTimePickerRelease.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerRelease.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerRelease.Location = New System.Drawing.Point(521, 496)
        Me.DateTimePickerRelease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerRelease.Name = "DateTimePickerRelease"
        Me.DateTimePickerRelease.Size = New System.Drawing.Size(382, 44)
        Me.DateTimePickerRelease.TabIndex = 42
        '
        'TxtFilm
        '
        Me.TxtFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilm.Location = New System.Drawing.Point(521, 106)
        Me.TxtFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFilm.Name = "TxtFilm"
        Me.TxtFilm.Size = New System.Drawing.Size(382, 44)
        Me.TxtFilm.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(301, 671)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 34)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Genre"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(301, 614)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 34)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Bahasa"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(301, 552)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 34)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Harga Film"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(301, 503)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 34)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Date Release"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(301, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 34)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Duration"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnTambahGambar.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 0
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.Color.White
        Me.BtnTambahGambar.Location = New System.Drawing.Point(37, 389)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(231, 37)
        Me.BtnTambahGambar.TabIndex = 33
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(301, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 34)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(301, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 34)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Director"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(378, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 49)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tambah Film"
        '
        'TxtDirector
        '
        Me.TxtDirector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDirector.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDirector.Location = New System.Drawing.Point(521, 207)
        Me.TxtDirector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(382, 44)
        Me.TxtDirector.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(301, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 34)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Film"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 68)
        Me.Panel1.TabIndex = 55
        '
        'ComboBoxRatingUsia
        '
        Me.ComboBoxRatingUsia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxRatingUsia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRatingUsia.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxRatingUsia.FormattingEnabled = True
        Me.ComboBoxRatingUsia.Items.AddRange(New Object() {"SU", "R13+", "D17+"})
        Me.ComboBoxRatingUsia.Location = New System.Drawing.Point(521, 157)
        Me.ComboBoxRatingUsia.Name = "ComboBoxRatingUsia"
        Me.ComboBoxRatingUsia.Size = New System.Drawing.Size(382, 33)
        Me.ComboBoxRatingUsia.TabIndex = 56
        '
        'ComboBoxBahasa
        '
        Me.ComboBoxBahasa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxBahasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBahasa.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxBahasa.FormattingEnabled = True
        Me.ComboBoxBahasa.Items.AddRange(New Object() {"Bahasa Indonesia", "Bahasa Inggris", "Bahasa Jepang", "Bahasa Korea", "Bahasa Mandarin"})
        Me.ComboBoxBahasa.Location = New System.Drawing.Point(521, 611)
        Me.ComboBoxBahasa.Name = "ComboBoxBahasa"
        Me.ComboBoxBahasa.Size = New System.Drawing.Size(382, 33)
        Me.ComboBoxBahasa.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(297, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Rating Usia"
        '
        'TambahFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 978)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxBahasa)
        Me.Controls.Add(Me.ComboBoxRatingUsia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.LblValueDeskripsi)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnTambahFilm)
        Me.Controls.Add(Me.GroupGenre)
        Me.Controls.Add(Me.TxtHargaFilm)
        Me.Controls.Add(Me.TxtDuration)
        Me.Controls.Add(Me.RichDeskripsiFilm)
        Me.Controls.Add(Me.DateTimePickerRelease)
        Me.Controls.Add(Me.TxtFilm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TambahFilm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Film"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGenre.ResumeLayout(False)
        Me.GroupGenre.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblValueDeskripsi As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnTambahFilm As Button
    Friend WithEvents ChckAdventure As CheckBox
    Friend WithEvents ChckHoror As CheckBox
    Friend WithEvents ChckComedy As CheckBox
    Friend WithEvents ChckDrama As CheckBox
    Friend WithEvents GroupGenre As GroupBox
    Friend WithEvents TxtHargaFilm As TextBox
    Friend WithEvents TxtDuration As TextBox
    Friend WithEvents RichDeskripsiFilm As RichTextBox
    Friend WithEvents DateTimePickerRelease As DateTimePicker
    Friend WithEvents TxtFilm As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents ChckAction As CheckBox
    Friend WithEvents ChckDocumenter As CheckBox
    Friend WithEvents ChckAnimation As CheckBox
    Friend WithEvents ChckRomance As CheckBox
    Friend WithEvents ChckScifi As CheckBox
    Friend WithEvents ChckThriller As CheckBox
    Friend WithEvents ChckMusical As CheckBox
    Friend WithEvents ChckMistery As CheckBox
    Friend WithEvents ChckBiografi As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxRatingUsia As ComboBox
    Friend WithEvents ComboBoxBahasa As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ChckCrime As CheckBox
End Class
