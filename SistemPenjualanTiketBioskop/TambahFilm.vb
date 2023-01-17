Public Class TambahFilm

    Public Shared data_film As List(Of String)

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
        LblValidateNamaFilm.Visible = False
    End Sub

    Private Sub TxtFilm_Leave(sender As Object, e As EventArgs) Handles TxtFilm.Leave
        LblValidateNamaFilm.Visible = False

        If TxtFilm.Text.Length < 1 Then
            TxtFilm.Select()
            MessageBox.Show("Please add At least 1 String")
        End If

        Dim judulFilm As String = TxtFilm.Text
        data_film = Film.dataFilm.CheckJudulFilm(judulFilm)

        ' Validasi nama film, jika nama film sudah ada sebelumnya
        If data_film.Count > 0 Then
            Film.dataFilm.GSNamaFilm = data_film(0)
            LblValidateNamaFilm.Visible = True
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
        Try
            Film.dataFilm.GSNamaFilm = TxtFilm.Text
            Film.dataFilm.GSRatingUsia = ComboBoxRatingUsia.SelectedItem()
            Film.dataFilm.GSDeskripsi = RichDeskripsiFilm.Text
            Film.dataFilm.GSDirector = TxtDirector.Text
            Film.dataFilm.GSDuration = TxtDuration.Text
            Film.dataFilm.GSDateRelease = DateTimePickerRelease.Value.ToLongDateString
            Film.dataFilm.GSBahasa = ComboBoxBahasa.SelectedItem()
            Film.dataFilm.GSHargaFilm = TxtHargaFilm.Text

            Film.dataFilm.resetGenre()

            If ChckDrama.Checked() Then
                Film.dataFilm.AddGenre("Drama")
            End If

            If ChckComedy.Checked() Then
                Film.dataFilm.AddGenre("Comedy")
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

            If ChckAnimation.Checked() Then
                Film.dataFilm.AddGenre("Animation")
            End If

            If ChckDocumenter.Checked() Then
                Film.dataFilm.AddGenre("Documenter")
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

            If ChckCrime.Checked() Then
                Film.dataFilm.AddGenre("Crime")
            End If

            Dim convertedGenre = Film.dataFilm.ConvertGenreToString(Film.dataFilm.getGenreItem)

            Dim judulFilm As String = TxtFilm.Text
            data_film = Film.dataFilm.CheckJudulFilm(judulFilm)

            If data_film.Count > 0 Then
                Film.dataFilm.GSNamaFilm = data_film(0)
                MessageBox.Show("film sudah ada")

            ElseIf Film.dataFilm.GSFoto = "" Or Film.dataFilm.GSRatingUsia = "" Or Film.dataFilm.GSBahasa = "" Or convertedGenre = "" Then
                MessageBox.Show("Harap isi semua data")
            Else
                Film.dataFilm.AddDataFilmDatabase(Film.dataFilm.GSNamaFilm,
                                              Film.dataFilm.GSRatingUsia,
                                              convertedGenre,
                                              Film.dataFilm.GSDeskripsi,
                                              Film.dataFilm.GSDirector,
                                              Film.dataFilm.GSDuration,
                                              Film.dataFilm.GSDateRelease,
                                              Film.dataFilm.GSBahasa,
                                              Film.dataFilm.GSHargaFilm,
                                              Film.dataFilm.GSFoto)

                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Harap isi semua data")
        End Try
    End Sub

End Class