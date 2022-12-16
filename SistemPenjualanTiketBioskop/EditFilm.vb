Public Class EditFilm

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
        RichDeskripsiFilm.Text = Film.dataFilm.GSDeskripsi
        TxtDirector.Text = Film.dataFilm.GSDirector
        TxtDuration.Text = Film.dataFilm.GSDuration
        DateTimePickerRelease.Value = Film.dataFilm.GSDateRelease
        TxtHargaFilm.Text = Film.dataFilm.GSHargaFilm

        If String.Compare(Film.dataFilm.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdBIndonesia.Checked = True
        ElseIf String.Compare(Film.dataFilm.GSBahasa, "Bahasa Inggris") = 0 Then
            RdBInggris.Checked = True
        End If

        For Each genreItem In Film.dataFilm.GSGenre

            If String.Compare(genreItem, "Action") = 0 Then
                ChckAction.Checked = True

            ElseIf String.Compare(genreItem, "Komedi") = 0 Then
                ChckKomedi.Checked = True

            ElseIf String.Compare(genreItem, "Horor") = 0 Then
                ChckHoror.Checked = True

            ElseIf String.Compare(genreItem, "Adventure") = 0 Then
                ChckAdventure.Checked = True

            ElseIf String.Compare(genreItem, "Romace") = 0 Then
                ChckRomance.Checked = True

            ElseIf String.Compare(genreItem, "Sci-fi") = 0 Then
                ChckScifi.Checked = True

            ElseIf String.Compare(genreItem, "Thriller") = 0 Then
                ChckThriller.Checked = True
            End If



        Next
        Film.dataFilm.resetGenre()
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
        Film.dataFilm.GSNamaFilm = TxtFilm.Text.ToString()
        Film.dataFilm.GSDeskripsi = RichDeskripsiFilm.Text.ToString()
        Film.dataFilm.GSDirector = TxtDirector.Text.ToString()

        Film.dataFilm.GSDuration = TxtDuration.Text.ToString()
        Film.dataFilm.GSDateRelease = DateTimePickerRelease.Value.ToString("yyyy/MM/dd")
        Film.dataFilm.GSHargaFilm = Integer.Parse(TxtHargaFilm.Text)

        If RdBIndonesia.Checked = True Then
            Film.dataFilm.GSBahasa = "Bahasa Indonesia"
        ElseIf RdBInggris.Checked = True Then
            Film.dataFilm.GSBahasa = "Bahasa Inggris"
        End If

        If ChckAction.Checked = True Then
            Film.dataFilm.AddGenre("Action")
        End If

        If ChckKomedi.Checked = True Then
            Film.dataFilm.AddGenre("Komedi")
        End If

        If ChckHoror.Checked = True Then
            Film.dataFilm.AddGenre("Horor")
        End If

        If ChckAdventure.Checked = True Then
            Film.dataFilm.AddGenre("Adventure")
        End If

        If ChckRomance.Checked = True Then
            Film.dataFilm.AddGenre("Romance")
        End If

        If ChckScifi.Checked = True Then
            Film.dataFilm.AddGenre("Sci-fi")
        End If

        If ChckThriller.Checked = True Then
            Film.dataFilm.AddGenre("Thriller")
        End If

        Dim convertedGenre = Film.dataFilm.ConvertGenreToString(Film.dataFilm.getGenreItem)

        Film.dataFilm.UpdateDataKoleksiByIDDatabase(Film.selectedTableKoleksi,
                                                    Film.dataFilm.GSNamaFilm,
                                                    convertedGenre,
                                                    Film.dataFilm.GSDeskripsi,
                                                    Film.dataFilm.GSDirector,
                                                    Film.dataFilm.GSDuration,
                                                    Film.dataFilm.GSDateRelease,
                                                    Film.dataFilm.GSBahasa,
                                                    Film.dataFilm.GSHargaFilm,
                                                    Film.dataFilm.GSFoto)

        'Dim infoFilm = New InfoFilm()
        'infoFilm.Show()

        Me.Close()
    End Sub
End Class