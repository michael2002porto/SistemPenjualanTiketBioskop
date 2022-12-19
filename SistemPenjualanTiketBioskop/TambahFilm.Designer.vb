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
        Me.ChckKomedi = New System.Windows.Forms.CheckBox()
        Me.ChckDrama = New System.Windows.Forms.CheckBox()
        Me.GroupGenre = New System.Windows.Forms.GroupBox()
        Me.ChckMistery = New System.Windows.Forms.CheckBox()
        Me.ChckBiografi = New System.Windows.Forms.CheckBox()
        Me.ChckMusical = New System.Windows.Forms.CheckBox()
        Me.ChckThriller = New System.Windows.Forms.CheckBox()
        Me.ChckScifi = New System.Windows.Forms.CheckBox()
        Me.ChckRomance = New System.Windows.Forms.CheckBox()
        Me.ChckDokumenter = New System.Windows.Forms.CheckBox()
        Me.ChckAnimasi = New System.Windows.Forms.CheckBox()
        Me.ChckAction = New System.Windows.Forms.CheckBox()
        Me.RdBInggris = New System.Windows.Forms.RadioButton()
        Me.RdBIndonesia = New System.Windows.Forms.RadioButton()
        Me.GroupBahasa = New System.Windows.Forms.GroupBox()
        Me.RdBKorea = New System.Windows.Forms.RadioButton()
        Me.RdBJepang = New System.Windows.Forms.RadioButton()
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
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGenre.SuspendLayout()
        Me.GroupBahasa.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblValueDeskripsi
        '
        Me.LblValueDeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblValueDeskripsi.AutoSize = True
        Me.LblValueDeskripsi.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblValueDeskripsi.Location = New System.Drawing.Point(909, 350)
        Me.LblValueDeskripsi.Name = "LblValueDeskripsi"
        Me.LblValueDeskripsi.Size = New System.Drawing.Size(45, 25)
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
        Me.PicFoto.Size = New System.Drawing.Size(231, 255)
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
        Me.ChckAdventure.Size = New System.Drawing.Size(130, 29)
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
        Me.ChckHoror.Size = New System.Drawing.Size(89, 29)
        Me.ChckHoror.TabIndex = 2
        Me.ChckHoror.Text = "Horor"
        Me.ChckHoror.UseVisualStyleBackColor = True
        '
        'ChckKomedi
        '
        Me.ChckKomedi.AutoSize = True
        Me.ChckKomedi.Location = New System.Drawing.Point(7, 57)
        Me.ChckKomedi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckKomedi.Name = "ChckKomedi"
        Me.ChckKomedi.Size = New System.Drawing.Size(107, 29)
        Me.ChckKomedi.TabIndex = 1
        Me.ChckKomedi.Text = "Komedi"
        Me.ChckKomedi.UseVisualStyleBackColor = True
        '
        'ChckDrama
        '
        Me.ChckDrama.AutoSize = True
        Me.ChckDrama.Location = New System.Drawing.Point(7, 26)
        Me.ChckDrama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckDrama.Name = "ChckDrama"
        Me.ChckDrama.Size = New System.Drawing.Size(97, 29)
        Me.ChckDrama.TabIndex = 0
        Me.ChckDrama.Text = "Drama"
        Me.ChckDrama.UseVisualStyleBackColor = True
        '
        'GroupGenre
        '
        Me.GroupGenre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupGenre.Controls.Add(Me.ChckMistery)
        Me.GroupGenre.Controls.Add(Me.ChckBiografi)
        Me.GroupGenre.Controls.Add(Me.ChckMusical)
        Me.GroupGenre.Controls.Add(Me.ChckThriller)
        Me.GroupGenre.Controls.Add(Me.ChckScifi)
        Me.GroupGenre.Controls.Add(Me.ChckRomance)
        Me.GroupGenre.Controls.Add(Me.ChckDokumenter)
        Me.GroupGenre.Controls.Add(Me.ChckAnimasi)
        Me.GroupGenre.Controls.Add(Me.ChckAction)
        Me.GroupGenre.Controls.Add(Me.ChckAdventure)
        Me.GroupGenre.Controls.Add(Me.ChckHoror)
        Me.GroupGenre.Controls.Add(Me.ChckKomedi)
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
        'ChckMistery
        '
        Me.ChckMistery.AutoSize = True
        Me.ChckMistery.Location = New System.Drawing.Point(232, 119)
        Me.ChckMistery.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckMistery.Name = "ChckMistery"
        Me.ChckMistery.Size = New System.Drawing.Size(106, 29)
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
        Me.ChckBiografi.Size = New System.Drawing.Size(109, 29)
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
        Me.ChckMusical.Size = New System.Drawing.Size(109, 29)
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
        Me.ChckThriller.Size = New System.Drawing.Size(104, 29)
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
        Me.ChckScifi.Size = New System.Drawing.Size(86, 29)
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
        Me.ChckRomance.Size = New System.Drawing.Size(119, 29)
        Me.ChckRomance.TabIndex = 7
        Me.ChckRomance.Text = "Romance"
        Me.ChckRomance.UseVisualStyleBackColor = True
        '
        'ChckDokumenter
        '
        Me.ChckDokumenter.AutoSize = True
        Me.ChckDokumenter.Location = New System.Drawing.Point(7, 211)
        Me.ChckDokumenter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckDokumenter.Name = "ChckDokumenter"
        Me.ChckDokumenter.Size = New System.Drawing.Size(146, 29)
        Me.ChckDokumenter.TabIndex = 6
        Me.ChckDokumenter.Text = "Dokumenter"
        Me.ChckDokumenter.UseVisualStyleBackColor = True
        '
        'ChckAnimasi
        '
        Me.ChckAnimasi.AutoSize = True
        Me.ChckAnimasi.Location = New System.Drawing.Point(7, 180)
        Me.ChckAnimasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckAnimasi.Name = "ChckAnimasi"
        Me.ChckAnimasi.Size = New System.Drawing.Size(111, 29)
        Me.ChckAnimasi.TabIndex = 5
        Me.ChckAnimasi.Text = "Animasi"
        Me.ChckAnimasi.UseVisualStyleBackColor = True
        '
        'ChckAction
        '
        Me.ChckAction.AutoSize = True
        Me.ChckAction.Location = New System.Drawing.Point(7, 150)
        Me.ChckAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckAction.Name = "ChckAction"
        Me.ChckAction.Size = New System.Drawing.Size(97, 29)
        Me.ChckAction.TabIndex = 4
        Me.ChckAction.Text = "Action"
        Me.ChckAction.UseVisualStyleBackColor = True
        '
        'RdBInggris
        '
        Me.RdBInggris.AutoSize = True
        Me.RdBInggris.Location = New System.Drawing.Point(7, 57)
        Me.RdBInggris.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdBInggris.Name = "RdBInggris"
        Me.RdBInggris.Size = New System.Drawing.Size(95, 29)
        Me.RdBInggris.TabIndex = 1
        Me.RdBInggris.TabStop = True
        Me.RdBInggris.Text = "Inggris"
        Me.RdBInggris.UseVisualStyleBackColor = True
        '
        'RdBIndonesia
        '
        Me.RdBIndonesia.AutoSize = True
        Me.RdBIndonesia.Location = New System.Drawing.Point(7, 26)
        Me.RdBIndonesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdBIndonesia.Name = "RdBIndonesia"
        Me.RdBIndonesia.Size = New System.Drawing.Size(120, 29)
        Me.RdBIndonesia.TabIndex = 0
        Me.RdBIndonesia.TabStop = True
        Me.RdBIndonesia.Text = "Indonesia"
        Me.RdBIndonesia.UseVisualStyleBackColor = True
        '
        'GroupBahasa
        '
        Me.GroupBahasa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBahasa.Controls.Add(Me.RdBKorea)
        Me.GroupBahasa.Controls.Add(Me.RdBJepang)
        Me.GroupBahasa.Controls.Add(Me.RdBInggris)
        Me.GroupBahasa.Controls.Add(Me.RdBIndonesia)
        Me.GroupBahasa.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBahasa.Location = New System.Drawing.Point(521, 547)
        Me.GroupBahasa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBahasa.Name = "GroupBahasa"
        Me.GroupBahasa.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBahasa.Size = New System.Drawing.Size(382, 98)
        Me.GroupBahasa.TabIndex = 48
        Me.GroupBahasa.TabStop = False
        Me.GroupBahasa.Text = "Bahasa"
        '
        'RdBKorea
        '
        Me.RdBKorea.AutoSize = True
        Me.RdBKorea.Location = New System.Drawing.Point(232, 57)
        Me.RdBKorea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdBKorea.Name = "RdBKorea"
        Me.RdBKorea.Size = New System.Drawing.Size(90, 29)
        Me.RdBKorea.TabIndex = 3
        Me.RdBKorea.TabStop = True
        Me.RdBKorea.Text = "Korea"
        Me.RdBKorea.UseVisualStyleBackColor = True
        '
        'RdBJepang
        '
        Me.RdBJepang.AutoSize = True
        Me.RdBJepang.Location = New System.Drawing.Point(232, 26)
        Me.RdBJepang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdBJepang.Name = "RdBJepang"
        Me.RdBJepang.Size = New System.Drawing.Size(97, 29)
        Me.RdBJepang.TabIndex = 2
        Me.RdBJepang.TabStop = True
        Me.RdBJepang.Text = "Jepang"
        Me.RdBJepang.UseVisualStyleBackColor = True
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtHargaFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtHargaFilm.Location = New System.Drawing.Point(521, 497)
        Me.TxtHargaFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(382, 35)
        Me.TxtHargaFilm.TabIndex = 46
        '
        'TxtDuration
        '
        Me.TxtDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDuration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDuration.Location = New System.Drawing.Point(521, 393)
        Me.TxtDuration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(382, 35)
        Me.TxtDuration.TabIndex = 44
        '
        'RichDeskripsiFilm
        '
        Me.RichDeskripsiFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichDeskripsiFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichDeskripsiFilm.Location = New System.Drawing.Point(521, 208)
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
        Me.DateTimePickerRelease.Location = New System.Drawing.Point(521, 445)
        Me.DateTimePickerRelease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerRelease.Name = "DateTimePickerRelease"
        Me.DateTimePickerRelease.Size = New System.Drawing.Size(382, 35)
        Me.DateTimePickerRelease.TabIndex = 42
        '
        'TxtFilm
        '
        Me.TxtFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilm.Location = New System.Drawing.Point(521, 106)
        Me.TxtFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFilm.Name = "TxtFilm"
        Me.TxtFilm.Size = New System.Drawing.Size(382, 35)
        Me.TxtFilm.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(301, 671)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 25)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Genre"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(301, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 25)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Bahasa"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(301, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Harga Film"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(301, 452)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Date Release"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(301, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
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
        Me.BtnTambahGambar.Location = New System.Drawing.Point(37, 377)
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
        Me.Label4.Location = New System.Drawing.Point(301, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(301, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
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
        Me.Label1.Size = New System.Drawing.Size(201, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tambah Film"
        '
        'TxtDirector
        '
        Me.TxtDirector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDirector.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDirector.Location = New System.Drawing.Point(521, 156)
        Me.TxtDirector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(382, 35)
        Me.TxtDirector.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(301, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
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
        'TambahFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 967)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.LblValueDeskripsi)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnTambahFilm)
        Me.Controls.Add(Me.GroupGenre)
        Me.Controls.Add(Me.GroupBahasa)
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
        Me.GroupBahasa.ResumeLayout(False)
        Me.GroupBahasa.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblValueDeskripsi As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnTambahFilm As Button
    Friend WithEvents ChckAdventure As CheckBox
    Friend WithEvents ChckHoror As CheckBox
    Friend WithEvents ChckKomedi As CheckBox
    Friend WithEvents ChckDrama As CheckBox
    Friend WithEvents GroupGenre As GroupBox
    Friend WithEvents RdBInggris As RadioButton
    Friend WithEvents RdBIndonesia As RadioButton
    Friend WithEvents GroupBahasa As GroupBox
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
    Friend WithEvents ChckDokumenter As CheckBox
    Friend WithEvents ChckAnimasi As CheckBox
    Friend WithEvents ChckRomance As CheckBox
    Friend WithEvents ChckScifi As CheckBox
    Friend WithEvents ChckThriller As CheckBox
    Friend WithEvents ChckMusical As CheckBox
    Friend WithEvents ChckMistery As CheckBox
    Friend WithEvents ChckBiografi As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RdBJepang As RadioButton
    Friend WithEvents RdBKorea As RadioButton
End Class
