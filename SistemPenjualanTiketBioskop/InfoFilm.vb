Public Class InfoFilm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            PicFoto.Load(Film.dataFilm.GSFoto)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LblFilm.Text = Film.dataFilm.GSNamaFilm
        LblRatingUsia.Text = Film.dataFilm.GSRatingUsia
        LblDirector.Text = Film.dataFilm.GSDirector
        LblDeskripsi.Text = Film.dataFilm.GSDeskripsi
        LblDuration.Text = Film.dataFilm.GSDuration
        LblDateRelease.Text = Film.dataFilm.GSDateRelease
        LblHargaFilm.Text = Film.dataFilm.GSHargaFilm
        LblBahasa.Text = Film.dataFilm.GSBahasa

        For Each genre In Film.dataFilm.GSGenre
            ListBoxGenre.Items.Add(genre)
        Next
        Film.dataFilm.GSGenre.Clear()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Hide()
    End Sub
End Class