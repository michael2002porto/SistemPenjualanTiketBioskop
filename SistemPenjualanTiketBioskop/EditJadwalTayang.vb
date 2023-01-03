Public Class EditJadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared data_film As DataFilm
    Public Shared data_studio As DataStudio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_film = New DataFilm()
        data_studio = New DataStudio()
        ComboBoxFilm.DataSource = data_film.GetDataFilmDatabaseList()
        ComboBoxStudio.DataSource = data_studio.GetDataStudioDatabaseList()


    End Sub
End Class