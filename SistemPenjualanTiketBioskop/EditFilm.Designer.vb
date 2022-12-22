<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditFilm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEditGambar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePickerRelease = New System.Windows.Forms.DateTimePicker()
        Me.RichDeskripsiFilm = New System.Windows.Forms.RichTextBox()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtFilm = New System.Windows.Forms.TextBox()
        Me.TxtHargaFilm = New System.Windows.Forms.TextBox()
        Me.BtnEditFilm = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.LblValueDeskripsi = New System.Windows.Forms.Label()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
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
        Me.ChckAdventure = New System.Windows.Forms.CheckBox()
        Me.ChckHoror = New System.Windows.Forms.CheckBox()
        Me.ChckKomedi = New System.Windows.Forms.CheckBox()
        Me.ChckDrama = New System.Windows.Forms.CheckBox()
        Me.ComboBoxBahasa = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxRatingUsia = New System.Windows.Forms.ComboBox()
        Me.ChckCrime = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGenre.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 59)
        Me.Panel1.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(429, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 36)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Edit Film"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(301, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Film"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(301, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Director"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(301, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Deskripsi"
        '
        'BtnEditGambar
        '
        Me.BtnEditGambar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditGambar.BackColor = System.Drawing.Color.Teal
        Me.BtnEditGambar.FlatAppearance.BorderSize = 0
        Me.BtnEditGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditGambar.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditGambar.ForeColor = System.Drawing.Color.White
        Me.BtnEditGambar.Location = New System.Drawing.Point(37, 399)
        Me.BtnEditGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditGambar.Name = "BtnEditGambar"
        Me.BtnEditGambar.Size = New System.Drawing.Size(231, 37)
        Me.BtnEditGambar.TabIndex = 59
        Me.BtnEditGambar.Text = "Edit Gambar"
        Me.BtnEditGambar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(301, 458)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Duration"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(301, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Date Release"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(301, 562)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 25)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Harga Film"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(301, 614)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 25)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Bahasa"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(301, 671)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 25)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Genre"
        '
        'DateTimePickerRelease
        '
        Me.DateTimePickerRelease.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerRelease.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerRelease.Location = New System.Drawing.Point(521, 506)
        Me.DateTimePickerRelease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerRelease.Name = "DateTimePickerRelease"
        Me.DateTimePickerRelease.Size = New System.Drawing.Size(382, 33)
        Me.DateTimePickerRelease.TabIndex = 66
        '
        'RichDeskripsiFilm
        '
        Me.RichDeskripsiFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RichDeskripsiFilm.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichDeskripsiFilm.Location = New System.Drawing.Point(521, 269)
        Me.RichDeskripsiFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichDeskripsiFilm.Name = "RichDeskripsiFilm"
        Me.RichDeskripsiFilm.Size = New System.Drawing.Size(382, 167)
        Me.RichDeskripsiFilm.TabIndex = 67
        Me.RichDeskripsiFilm.Text = ""
        '
        'TxtDuration
        '
        Me.TxtDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDuration.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDuration.Location = New System.Drawing.Point(521, 454)
        Me.TxtDuration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(382, 33)
        Me.TxtDuration.TabIndex = 68
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtFilm
        '
        Me.TxtFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFilm.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilm.Location = New System.Drawing.Point(521, 106)
        Me.TxtFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFilm.Name = "TxtFilm"
        Me.TxtFilm.Size = New System.Drawing.Size(382, 33)
        Me.TxtFilm.TabIndex = 65
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtHargaFilm.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtHargaFilm.Location = New System.Drawing.Point(521, 558)
        Me.TxtHargaFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(382, 33)
        Me.TxtHargaFilm.TabIndex = 69
        '
        'BtnEditFilm
        '
        Me.BtnEditFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditFilm.BackColor = System.Drawing.Color.Teal
        Me.BtnEditFilm.FlatAppearance.BorderSize = 0
        Me.BtnEditFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditFilm.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditFilm.ForeColor = System.Drawing.Color.White
        Me.BtnEditFilm.Location = New System.Drawing.Point(411, 929)
        Me.BtnEditFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditFilm.Name = "BtnEditFilm"
        Me.BtnEditFilm.Size = New System.Drawing.Size(208, 37)
        Me.BtnEditFilm.TabIndex = 72
        Me.BtnEditFilm.Text = "Edit Film"
        Me.BtnEditFilm.UseVisualStyleBackColor = False
        '
        'PicFoto
        '
        Me.PicFoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFoto.Location = New System.Drawing.Point(37, 106)
        Me.PicFoto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(231, 289)
        Me.PicFoto.TabIndex = 73
        Me.PicFoto.TabStop = False
        '
        'LblValueDeskripsi
        '
        Me.LblValueDeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblValueDeskripsi.AutoSize = True
        Me.LblValueDeskripsi.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblValueDeskripsi.Location = New System.Drawing.Point(909, 350)
        Me.LblValueDeskripsi.Name = "LblValueDeskripsi"
        Me.LblValueDeskripsi.Size = New System.Drawing.Size(45, 25)
        Me.LblValueDeskripsi.TabIndex = 74
        Me.LblValueDeskripsi.Text = "268"
        '
        'TxtDirector
        '
        Me.TxtDirector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDirector.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDirector.Location = New System.Drawing.Point(521, 207)
        Me.TxtDirector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(382, 33)
        Me.TxtDirector.TabIndex = 75
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
        Me.GroupGenre.TabIndex = 77
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
        'ComboBoxBahasa
        '
        Me.ComboBoxBahasa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxBahasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBahasa.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxBahasa.FormattingEnabled = True
        Me.ComboBoxBahasa.Items.AddRange(New Object() {"Indonesia", "Inggris", "Jepang", "Korea", "Mandarin"})
        Me.ComboBoxBahasa.Location = New System.Drawing.Point(521, 611)
        Me.ComboBoxBahasa.Name = "ComboBoxBahasa"
        Me.ComboBoxBahasa.Size = New System.Drawing.Size(382, 33)
        Me.ComboBoxBahasa.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(301, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Rating Usia"
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
        Me.ComboBoxRatingUsia.TabIndex = 79
        '
        'ChckCrime
        '
        Me.ChckCrime.AutoSize = True
        Me.ChckCrime.Location = New System.Drawing.Point(232, 211)
        Me.ChckCrime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChckCrime.Name = "ChckCrime"
        Me.ChckCrime.Size = New System.Drawing.Size(92, 29)
        Me.ChckCrime.TabIndex = 13
        Me.ChckCrime.Text = "Crime"
        Me.ChckCrime.UseVisualStyleBackColor = True
        '
        'EditFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 967)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxRatingUsia)
        Me.Controls.Add(Me.ComboBoxBahasa)
        Me.Controls.Add(Me.GroupGenre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.LblValueDeskripsi)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnEditFilm)
        Me.Controls.Add(Me.TxtHargaFilm)
        Me.Controls.Add(Me.TxtFilm)
        Me.Controls.Add(Me.TxtDuration)
        Me.Controls.Add(Me.RichDeskripsiFilm)
        Me.Controls.Add(Me.DateTimePickerRelease)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnEditGambar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditFilm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Film"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGenre.ResumeLayout(False)
        Me.GroupGenre.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEditGambar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePickerRelease As DateTimePicker
    Friend WithEvents RichDeskripsiFilm As RichTextBox
    Friend WithEvents TxtDuration As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtFilm As TextBox
    Friend WithEvents TxtHargaFilm As TextBox
    Friend WithEvents BtnEditFilm As Button
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents LblValueDeskripsi As Label
    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents GroupGenre As GroupBox
    Friend WithEvents ChckMistery As CheckBox
    Friend WithEvents ChckBiografi As CheckBox
    Friend WithEvents ChckMusical As CheckBox
    Friend WithEvents ChckThriller As CheckBox
    Friend WithEvents ChckScifi As CheckBox
    Friend WithEvents ChckRomance As CheckBox
    Friend WithEvents ChckDokumenter As CheckBox
    Friend WithEvents ChckAnimasi As CheckBox
    Friend WithEvents ChckAction As CheckBox
    Friend WithEvents ChckAdventure As CheckBox
    Friend WithEvents ChckHoror As CheckBox
    Friend WithEvents ChckKomedi As CheckBox
    Friend WithEvents ChckDrama As CheckBox
    Friend WithEvents ComboBoxBahasa As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxRatingUsia As ComboBox
    Friend WithEvents ChckCrime As CheckBox
End Class
