<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahFilm
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
        Me.LblValueDeskripsi = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahFilm = New System.Windows.Forms.Button()
        Me.ChckAdventure = New System.Windows.Forms.CheckBox()
        Me.ChckHoror = New System.Windows.Forms.CheckBox()
        Me.ChckKomedi = New System.Windows.Forms.CheckBox()
        Me.ChckAction = New System.Windows.Forms.CheckBox()
        Me.GroupGenre = New System.Windows.Forms.GroupBox()
        Me.ChckThriller = New System.Windows.Forms.CheckBox()
        Me.ChckScifi = New System.Windows.Forms.CheckBox()
        Me.ChckRomance = New System.Windows.Forms.CheckBox()
        Me.RdBInggris = New System.Windows.Forms.RadioButton()
        Me.RdBIndonesia = New System.Windows.Forms.RadioButton()
        Me.GroupBahasa = New System.Windows.Forms.GroupBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGenre.SuspendLayout()
        Me.GroupBahasa.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblValueDeskripsi
        '
        Me.LblValueDeskripsi.AutoSize = True
        Me.LblValueDeskripsi.Location = New System.Drawing.Point(773, 358)
        Me.LblValueDeskripsi.Name = "LblValueDeskripsi"
        Me.LblValueDeskripsi.Size = New System.Drawing.Size(42, 25)
        Me.LblValueDeskripsi.TabIndex = 53
        Me.LblValueDeskripsi.Text = "268"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicFoto
        '
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFoto.Location = New System.Drawing.Point(12, 97)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(210, 250)
        Me.PicFoto.TabIndex = 51
        Me.PicFoto.TabStop = False
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahFilm.FlatAppearance.BorderSize = 0
        Me.BtnTambahFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahFilm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahFilm.ForeColor = System.Drawing.Color.White
        Me.BtnTambahFilm.Location = New System.Drawing.Point(331, 1004)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(189, 34)
        Me.BtnTambahFilm.TabIndex = 50
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = False
        '
        'ChckAdventure
        '
        Me.ChckAdventure.AutoSize = True
        Me.ChckAdventure.Location = New System.Drawing.Point(6, 135)
        Me.ChckAdventure.Name = "ChckAdventure"
        Me.ChckAdventure.Size = New System.Drawing.Size(120, 29)
        Me.ChckAdventure.TabIndex = 3
        Me.ChckAdventure.Text = "Adventure"
        Me.ChckAdventure.UseVisualStyleBackColor = True
        '
        'ChckHoror
        '
        Me.ChckHoror.AutoSize = True
        Me.ChckHoror.Location = New System.Drawing.Point(6, 100)
        Me.ChckHoror.Name = "ChckHoror"
        Me.ChckHoror.Size = New System.Drawing.Size(85, 29)
        Me.ChckHoror.TabIndex = 2
        Me.ChckHoror.Text = "Horor"
        Me.ChckHoror.UseVisualStyleBackColor = True
        '
        'ChckKomedi
        '
        Me.ChckKomedi.AutoSize = True
        Me.ChckKomedi.Location = New System.Drawing.Point(6, 65)
        Me.ChckKomedi.Name = "ChckKomedi"
        Me.ChckKomedi.Size = New System.Drawing.Size(99, 29)
        Me.ChckKomedi.TabIndex = 1
        Me.ChckKomedi.Text = "Komedi"
        Me.ChckKomedi.UseVisualStyleBackColor = True
        '
        'ChckAction
        '
        Me.ChckAction.AutoSize = True
        Me.ChckAction.Location = New System.Drawing.Point(6, 30)
        Me.ChckAction.Name = "ChckAction"
        Me.ChckAction.Size = New System.Drawing.Size(89, 29)
        Me.ChckAction.TabIndex = 0
        Me.ChckAction.Text = "Action"
        Me.ChckAction.UseVisualStyleBackColor = True
        '
        'GroupGenre
        '
        Me.GroupGenre.Controls.Add(Me.ChckThriller)
        Me.GroupGenre.Controls.Add(Me.ChckScifi)
        Me.GroupGenre.Controls.Add(Me.ChckRomance)
        Me.GroupGenre.Controls.Add(Me.ChckAdventure)
        Me.GroupGenre.Controls.Add(Me.ChckHoror)
        Me.GroupGenre.Controls.Add(Me.ChckKomedi)
        Me.GroupGenre.Controls.Add(Me.ChckAction)
        Me.GroupGenre.Location = New System.Drawing.Point(467, 694)
        Me.GroupGenre.Name = "GroupGenre"
        Me.GroupGenre.Size = New System.Drawing.Size(300, 286)
        Me.GroupGenre.TabIndex = 49
        Me.GroupGenre.TabStop = False
        Me.GroupGenre.Text = "Genre"
        '
        'ChckThriller
        '
        Me.ChckThriller.AutoSize = True
        Me.ChckThriller.Location = New System.Drawing.Point(6, 240)
        Me.ChckThriller.Name = "ChckThriller"
        Me.ChckThriller.Size = New System.Drawing.Size(90, 29)
        Me.ChckThriller.TabIndex = 6
        Me.ChckThriller.Text = "Thriller"
        Me.ChckThriller.UseVisualStyleBackColor = True
        '
        'ChckScifi
        '
        Me.ChckScifi.AutoSize = True
        Me.ChckScifi.Location = New System.Drawing.Point(6, 205)
        Me.ChckScifi.Name = "ChckScifi"
        Me.ChckScifi.Size = New System.Drawing.Size(77, 29)
        Me.ChckScifi.TabIndex = 5
        Me.ChckScifi.Text = "Sci-fi"
        Me.ChckScifi.UseVisualStyleBackColor = True
        '
        'ChckRomance
        '
        Me.ChckRomance.AutoSize = True
        Me.ChckRomance.Location = New System.Drawing.Point(6, 170)
        Me.ChckRomance.Name = "ChckRomance"
        Me.ChckRomance.Size = New System.Drawing.Size(111, 29)
        Me.ChckRomance.TabIndex = 4
        Me.ChckRomance.Text = "Romance"
        Me.ChckRomance.UseVisualStyleBackColor = True
        '
        'RdBInggris
        '
        Me.RdBInggris.AutoSize = True
        Me.RdBInggris.Location = New System.Drawing.Point(6, 65)
        Me.RdBInggris.Name = "RdBInggris"
        Me.RdBInggris.Size = New System.Drawing.Size(152, 29)
        Me.RdBInggris.TabIndex = 1
        Me.RdBInggris.TabStop = True
        Me.RdBInggris.Text = "Bahasa Inggris"
        Me.RdBInggris.UseVisualStyleBackColor = True
        '
        'RdBIndonesia
        '
        Me.RdBIndonesia.AutoSize = True
        Me.RdBIndonesia.Location = New System.Drawing.Point(6, 30)
        Me.RdBIndonesia.Name = "RdBIndonesia"
        Me.RdBIndonesia.Size = New System.Drawing.Size(174, 29)
        Me.RdBIndonesia.TabIndex = 0
        Me.RdBIndonesia.TabStop = True
        Me.RdBIndonesia.Text = "Bahasa Indonesia"
        Me.RdBIndonesia.UseVisualStyleBackColor = True
        '
        'GroupBahasa
        '
        Me.GroupBahasa.Controls.Add(Me.RdBInggris)
        Me.GroupBahasa.Controls.Add(Me.RdBIndonesia)
        Me.GroupBahasa.Location = New System.Drawing.Point(467, 564)
        Me.GroupBahasa.Name = "GroupBahasa"
        Me.GroupBahasa.Size = New System.Drawing.Size(300, 111)
        Me.GroupBahasa.TabIndex = 48
        Me.GroupBahasa.TabStop = False
        Me.GroupBahasa.Text = "Bahasa"
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Location = New System.Drawing.Point(467, 505)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(300, 31)
        Me.TxtHargaFilm.TabIndex = 46
        '
        'TxtDuration
        '
        Me.TxtDuration.Location = New System.Drawing.Point(467, 404)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(300, 31)
        Me.TxtDuration.TabIndex = 44
        '
        'RichDeskripsiFilm
        '
        Me.RichDeskripsiFilm.Location = New System.Drawing.Point(467, 194)
        Me.RichDeskripsiFilm.Name = "RichDeskripsiFilm"
        Me.RichDeskripsiFilm.Size = New System.Drawing.Size(300, 189)
        Me.RichDeskripsiFilm.TabIndex = 43
        Me.RichDeskripsiFilm.Text = ""
        '
        'DateTimePickerRelease
        '
        Me.DateTimePickerRelease.Location = New System.Drawing.Point(467, 455)
        Me.DateTimePickerRelease.Name = "DateTimePickerRelease"
        Me.DateTimePickerRelease.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePickerRelease.TabIndex = 42
        '
        'TxtFilm
        '
        Me.TxtFilm.Location = New System.Drawing.Point(467, 94)
        Me.TxtFilm.Name = "TxtFilm"
        Me.TxtFilm.Size = New System.Drawing.Size(300, 31)
        Me.TxtFilm.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 694)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 25)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Genre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 564)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Bahasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 508)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Harga Film"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Date Release"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Duration"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 0
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.Color.White
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 353)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(210, 34)
        Me.BtnTambahGambar.TabIndex = 33
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Director"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(362, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 32)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tambah Film"
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(467, 143)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(300, 31)
        Me.TxtDirector.TabIndex = 54
        '
        'TambahFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(850, 688)
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
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TambahFilm"
        Me.Text = "Tambah Film"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGenre.ResumeLayout(False)
        Me.GroupGenre.PerformLayout()
        Me.GroupBahasa.ResumeLayout(False)
        Me.GroupBahasa.PerformLayout()
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
    Friend WithEvents ChckAction As CheckBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents ChckRomance As CheckBox
    Friend WithEvents ChckThriller As CheckBox
    Friend WithEvents ChckScifi As CheckBox
End Class
