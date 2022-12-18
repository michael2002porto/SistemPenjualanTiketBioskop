Public Class TambahFilm

    Dim max_char_deskripsi_film = 268
    Dim panjang_karakter = max_char_deskripsi_film

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerRelease.Format = DateTimePickerFormat.Custom
        DateTimePickerRelease.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub TambahFilm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub TxtFilm_Leave(sender As Object, e As EventArgs) Handles TxtFilm.Leave
        If TxtFilm.Text.Length < 1 Then
            TxtFilm.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub TxtDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDuration.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtHargaFilm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaFilm.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub RdBIndonesia_CheckedChanged(sender As Object, e As EventArgs) Handles RdBIndonesia.CheckedChanged
        Film.dataFilm.GSBahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RdBInggris_CheckedChanged(sender As Object, e As EventArgs) Handles RdBInggris.CheckedChanged
        Film.dataFilm.GSBahasa = "Bahasa Inggris"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        Try
            OpenFileDialog1.Title = "Open Foto"
            OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
            OpenFileDialog1.ShowDialog()

            Dim picKoleksiDir As String = OpenFileDialog1.FileName

            PicFoto.Load(picKoleksiDir)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            Film.dataFilm.GSFoto = picKoleksiDir.ToString()
            Film.dataFilm.GSFoto = Film.dataFilm.GSFoto.Replace("\", "/")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RichDeskripsiFilm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichDeskripsiFilm.KeyPress
        LblValueDeskripsi.Text = max_char_deskripsi_film - RichDeskripsiFilm.Text.Length

        If RichDeskripsiFilm.Text.Length >= max_char_deskripsi_film Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
        Film.dataFilm.GSNamaFilm = TxtFilm.Text
        Film.dataFilm.GSDeskripsi = RichDeskripsiFilm.Text
        Film.dataFilm.GSDirector = TxtDirector.Text
        Film.dataFilm.GSDuration = TxtDuration.Text
        Film.dataFilm.GSDateRelease = DateTimePickerRelease.Value.ToLongDateString
        Film.dataFilm.GSHargaFilm = TxtHargaFilm.Text

        Film.dataFilm.resetGenre()

        If ChckDrama.Checked() Then
            Film.dataFilm.AddGenre("Drama")
        End If

        If ChckKomedi.Checked() Then
            Film.dataFilm.AddGenre("Komedi")
        End If

        If ChckHoror.Checked() Then
            Film.dataFilm.AddGenre("Horor")
        End If

        If ChckAdventure.Checked() Then
            Film.dataFilm.AddGenre("Adventure")
        End If

        If ChckAction.Checked() Then
            Film.dataFilm.AddGenre("Action")
        End If

        If ChckAnimasi.Checked() Then
            Film.dataFilm.AddGenre("Animasi")
        End If

        If ChckDokumenter.Checked() Then
            Film.dataFilm.AddGenre("Dokumenter")
        End If

        If ChckRomance.Checked() Then
            Film.dataFilm.AddGenre("Romance")
        End If

        If ChckScifi.Checked() Then
            Film.dataFilm.AddGenre("Sci-fi")
        End If

        If ChckThriller.Checked() Then
            Film.dataFilm.AddGenre("Thriller")
        End If

        If ChckMistery.Checked() Then
            Film.dataFilm.AddGenre("Mistery")
        End If

        If ChckBiografi.Checked() Then
            Film.dataFilm.AddGenre("Biografi")
        End If

        If ChckMusical.Checked() Then
            Film.dataFilm.AddGenre("Musical")
        End If

        Dim convertedGenre = Film.dataFilm.ConvertGenreToString(Film.dataFilm.getGenreItem)

        Film.dataFilm.AddDataFilmDatabase(Film.dataFilm.GSNamaFilm,
                                          convertedGenre,
                                          Film.dataFilm.GSDeskripsi,
                                          Film.dataFilm.GSDirector,
                                          Film.dataFilm.GSDuration,
                                          Film.dataFilm.GSDateRelease,
                                          Film.dataFilm.GSBahasa,
                                          Film.dataFilm.GSHargaFilm,
                                          Film.dataFilm.GSFoto)

        'Dim form_infoFilm = New InfoFilm()
        'form_infoFilm.Show()

        Me.Close()

    End Sub
End Class