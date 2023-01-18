Public Class EditFilm
    Public Shared data_film As List(Of String)

    Dim max_char_deskripsi = 268
    Dim panjang_karakter = max_char_deskripsi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            If Not String.IsNullOrEmpty(Film.dataFilm.GSFoto) Then
                PicFoto.Load(Film.dataFilm.GSFoto)
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception

        End Try

        DateTimePickerRelease.Format = DateTimePickerFormat.Custom
        DateTimePickerRelease.CustomFormat = "yyyy/MM/dd"
        TxtFilm.Text = Film.dataFilm.GSNamaFilm
        ComboBoxRatingUsia.SelectedItem() = Film.dataFilm.GSRatingUsia
        RichDeskripsiFilm.Text = Film.dataFilm.GSDeskripsi
        TxtDirector.Text = Film.dataFilm.GSDirector
        TxtDuration.Text = Film.dataFilm.GSDuration
        DateTimePickerRelease.Value = Film.dataFilm.GSDateRelease
        ComboBoxBahasa.SelectedItem() = Film.dataFilm.GSBahasa
        TxtHargaFilm.Text = Film.dataFilm.GSHargaFilm

        For Each genreItem In Film.dataFilm.GSGenre

            If String.Compare(genreItem, "Drama") = 0 Then
                ChckDrama.Checked = True

            ElseIf String.Compare(genreItem, "Comedy") = 0 Then
                ChckComedy.Checked = True

            ElseIf String.Compare(genreItem, "Horor") = 0 Then
                ChckHoror.Checked = True

            ElseIf String.Compare(genreItem, "Adventure") = 0 Then
                ChckAdventure.Checked = True

            ElseIf String.Compare(genreItem, "Action") = 0 Then
                ChckAction.Checked = True

            ElseIf String.Compare(genreItem, "Animation") = 0 Then
                ChckAnimation.Checked = True

            ElseIf String.Compare(genreItem, "Documenter") = 0 Then
                ChckDocumenter.Checked = True

            ElseIf String.Compare(genreItem, "Romance") = 0 Then
                ChckRomance.Checked = True

            ElseIf String.Compare(genreItem, "Sci-fi") = 0 Then
                ChckScifi.Checked = True

            ElseIf String.Compare(genreItem, "Thriller") = 0 Then
                ChckThriller.Checked = True

            ElseIf String.Compare(genreItem, "Mistery") = 0 Then
                ChckMistery.Checked = True

            ElseIf String.Compare(genreItem, "Biografi") = 0 Then
                ChckBiografi.Checked = True

            ElseIf String.Compare(genreItem, "Musical") = 0 Then
                ChckMusical.Checked = True

            ElseIf String.Compare(genreItem, "Crime") = 0 Then
                ChckCrime.Checked = True

            End If

        Next
        Film.dataFilm.resetGenre()

        LblValueDeskripsi.Text = max_char_deskripsi - RichDeskripsiFilm.Text.Length
    End Sub

    Private Sub BtnEditGambar_Click(sender As Object, e As EventArgs) Handles BtnEditGambar.Click
        Try
            OpenFileDialog1.Title = "Open Gambar Koleksi"
            OpenFileDialog1.Filter = "All format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
            OpenFileDialog1.ShowDialog()

            Dim picKoleksiDir As String = OpenFileDialog1.FileName

            PicFoto.Load(picKoleksiDir)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            Film.dataFilm.GSFoto = picKoleksiDir.ToString()
            Film.dataFilm.GSFoto = Film.dataFilm.GSFoto.Replace("\", "/")
        Catch ex As Exception

        End Try
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

    Private Sub RichDeskripsiFilm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichDeskripsiFilm.KeyPress
        LblValueDeskripsi.Text = max_char_deskripsi - RichDeskripsiFilm.Text.Length

        If RichDeskripsiFilm.Text.Length >= max_char_deskripsi Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub BtnEditFilm_Click(sender As Object, e As EventArgs) Handles BtnEditFilm.Click
        Try
            Film.dataFilm.GSNamaFilm = TxtFilm.Text.ToString()
            Film.dataFilm.GSRatingUsia = ComboBoxRatingUsia.SelectedItem().ToString()
            Film.dataFilm.GSDeskripsi = RichDeskripsiFilm.Text.ToString()
            Film.dataFilm.GSDirector = TxtDirector.Text.ToString()
            Film.dataFilm.GSDuration = TxtDuration.Text.ToString()
            Film.dataFilm.GSDateRelease = DateTimePickerRelease.Value.ToString("yyyy/MM/dd")
            Film.dataFilm.GSBahasa = ComboBoxBahasa.SelectedItem().ToString()
            Film.dataFilm.GSHargaFilm = Integer.Parse(TxtHargaFilm.Text)

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

            If Film.dataFilm.GSDeskripsi = "" Or Film.dataFilm.GSDirector = "" Or Film.dataFilm.GSDuration = "" Or convertedGenre = "" Or Film.dataFilm.GSBahasa = "" Or Film.dataFilm.GSHargaFilm = "" Then
                MessageBox.Show("Harap isi semua data")

            Else
                Film.dataFilm.UpdateDataFilmByIDDatabase(Film.selectedTableFilm,
                                                         Film.dataFilm.GSNamaFilm,
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