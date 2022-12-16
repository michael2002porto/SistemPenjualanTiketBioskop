<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFilm
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
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.RdBInggris = New System.Windows.Forms.RadioButton()
        Me.RdBIndonesia = New System.Windows.Forms.RadioButton()
        Me.ChckThriller = New System.Windows.Forms.CheckBox()
        Me.ChckScifi = New System.Windows.Forms.CheckBox()
        Me.ChckRomance = New System.Windows.Forms.CheckBox()
        Me.ChckAction = New System.Windows.Forms.CheckBox()
        Me.LblValueDeskripsi = New System.Windows.Forms.Label()
        Me.GroupGenre = New System.Windows.Forms.GroupBox()
        Me.ChckAdventure = New System.Windows.Forms.CheckBox()
        Me.ChckHoror = New System.Windows.Forms.CheckBox()
        Me.ChckKomedi = New System.Windows.Forms.CheckBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnEditFilm = New System.Windows.Forms.Button()
        Me.GroupBahasa = New System.Windows.Forms.GroupBox()
        Me.TxtHargaFilm = New System.Windows.Forms.TextBox()
        Me.TxtFilm = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.RichDeskripsiFilm = New System.Windows.Forms.RichTextBox()
        Me.DateTimePickerRelease = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEditGambar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupGenre.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBahasa.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(467, 149)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(300, 31)
        Me.TxtDirector.TabIndex = 75
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
        'LblValueDeskripsi
        '
        Me.LblValueDeskripsi.AutoSize = True
        Me.LblValueDeskripsi.Location = New System.Drawing.Point(773, 364)
        Me.LblValueDeskripsi.Name = "LblValueDeskripsi"
        Me.LblValueDeskripsi.Size = New System.Drawing.Size(42, 25)
        Me.LblValueDeskripsi.TabIndex = 74
        Me.LblValueDeskripsi.Text = "268"
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
        Me.GroupGenre.Location = New System.Drawing.Point(467, 700)
        Me.GroupGenre.Name = "GroupGenre"
        Me.GroupGenre.Size = New System.Drawing.Size(300, 286)
        Me.GroupGenre.TabIndex = 71
        Me.GroupGenre.TabStop = False
        Me.GroupGenre.Text = "Genre"
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
        'PicFoto
        '
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFoto.Location = New System.Drawing.Point(12, 103)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(210, 250)
        Me.PicFoto.TabIndex = 73
        Me.PicFoto.TabStop = False
        '
        'BtnEditFilm
        '
        Me.BtnEditFilm.BackColor = System.Drawing.Color.Teal
        Me.BtnEditFilm.FlatAppearance.BorderSize = 0
        Me.BtnEditFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditFilm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditFilm.ForeColor = System.Drawing.Color.White
        Me.BtnEditFilm.Location = New System.Drawing.Point(331, 1010)
        Me.BtnEditFilm.Name = "BtnEditFilm"
        Me.BtnEditFilm.Size = New System.Drawing.Size(189, 34)
        Me.BtnEditFilm.TabIndex = 72
        Me.BtnEditFilm.Text = "Edit Film"
        Me.BtnEditFilm.UseVisualStyleBackColor = False
        '
        'GroupBahasa
        '
        Me.GroupBahasa.Controls.Add(Me.RdBInggris)
        Me.GroupBahasa.Controls.Add(Me.RdBIndonesia)
        Me.GroupBahasa.Location = New System.Drawing.Point(467, 570)
        Me.GroupBahasa.Name = "GroupBahasa"
        Me.GroupBahasa.Size = New System.Drawing.Size(300, 111)
        Me.GroupBahasa.TabIndex = 70
        Me.GroupBahasa.TabStop = False
        Me.GroupBahasa.Text = "Bahasa"
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Location = New System.Drawing.Point(467, 511)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(300, 31)
        Me.TxtHargaFilm.TabIndex = 69
        '
        'TxtFilm
        '
        Me.TxtFilm.Location = New System.Drawing.Point(467, 100)
        Me.TxtFilm.Name = "TxtFilm"
        Me.TxtFilm.Size = New System.Drawing.Size(300, 31)
        Me.TxtFilm.TabIndex = 65
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtDuration
        '
        Me.TxtDuration.Location = New System.Drawing.Point(467, 410)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(300, 31)
        Me.TxtDuration.TabIndex = 68
        '
        'RichDeskripsiFilm
        '
        Me.RichDeskripsiFilm.Location = New System.Drawing.Point(467, 200)
        Me.RichDeskripsiFilm.Name = "RichDeskripsiFilm"
        Me.RichDeskripsiFilm.Size = New System.Drawing.Size(300, 189)
        Me.RichDeskripsiFilm.TabIndex = 67
        Me.RichDeskripsiFilm.Text = ""
        '
        'DateTimePickerRelease
        '
        Me.DateTimePickerRelease.Location = New System.Drawing.Point(467, 461)
        Me.DateTimePickerRelease.Name = "DateTimePickerRelease"
        Me.DateTimePickerRelease.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePickerRelease.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 700)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 25)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Genre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 570)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Bahasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 514)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Harga Film"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Date Release"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Duration"
        '
        'BtnEditGambar
        '
        Me.BtnEditGambar.BackColor = System.Drawing.Color.Teal
        Me.BtnEditGambar.FlatAppearance.BorderSize = 0
        Me.BtnEditGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditGambar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditGambar.ForeColor = System.Drawing.Color.White
        Me.BtnEditGambar.Location = New System.Drawing.Point(12, 359)
        Me.BtnEditGambar.Name = "BtnEditGambar"
        Me.BtnEditGambar.Size = New System.Drawing.Size(210, 34)
        Me.BtnEditGambar.TabIndex = 59
        Me.BtnEditGambar.Text = "Edit Gambar"
        Me.BtnEditGambar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Director"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(373, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 32)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Edit Film"
        '
        'EditFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(847, 701)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.LblValueDeskripsi)
        Me.Controls.Add(Me.GroupGenre)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnEditFilm)
        Me.Controls.Add(Me.GroupBahasa)
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
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditFilm"
        Me.Text = "Edit Film"
        Me.GroupGenre.ResumeLayout(False)
        Me.GroupGenre.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBahasa.ResumeLayout(False)
        Me.GroupBahasa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents RdBInggris As RadioButton
    Friend WithEvents RdBIndonesia As RadioButton
    Friend WithEvents ChckThriller As CheckBox
    Friend WithEvents ChckScifi As CheckBox
    Friend WithEvents ChckRomance As CheckBox
    Friend WithEvents ChckAction As CheckBox
    Friend WithEvents LblValueDeskripsi As Label
    Friend WithEvents GroupGenre As GroupBox
    Friend WithEvents ChckAdventure As CheckBox
    Friend WithEvents ChckHoror As CheckBox
    Friend WithEvents ChckKomedi As CheckBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnEditFilm As Button
    Friend WithEvents GroupBahasa As GroupBox
    Friend WithEvents TxtHargaFilm As TextBox
    Friend WithEvents TxtFilm As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtDuration As TextBox
    Friend WithEvents RichDeskripsiFilm As RichTextBox
    Friend WithEvents DateTimePickerRelease As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnEditGambar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
