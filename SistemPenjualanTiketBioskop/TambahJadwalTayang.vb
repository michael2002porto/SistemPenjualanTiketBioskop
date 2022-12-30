Public Class TambahJadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared data_film As DataFilm
    Public Shared data_studio As DataStudio
    Dim layanan As New List(Of String) From {"Rawat Jalan", "Umum"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_jadwal_tayang = New DataJadwalTayang()
        Dim data = data_jadwal_tayang.GetDataFilmDatabase()
        ComboBoxFilm.DataSource = data_jadwal_tayang.GetDataFilmDatabase()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        JadwalTayang.data_jadwal_tayang.GSIdFilm = ComboBoxFilm.SelectedItem()
        JadwalTayang.data_jadwal_tayang.GSIdStudio = ComboBoxStudio.SelectedItem()
        JadwalTayang.data_jadwal_tayang.GSTanggal = DateTimePickerTanggal.Value.ToShortDateString
        JadwalTayang.data_jadwal_tayang.GSWaktuMulai = DateTimePickerWaktuMulai.Value.ToShortTimeString
        JadwalTayang.data_jadwal_tayang.GSWaktuSelesai = DateTimePickerWaktuSelesai.Value.ToShortTimeString

        JadwalTayang.data_jadwal_tayang.AddDataJadwalTayangDatabase(
            JadwalTayang.data_jadwal_tayang.GSIdFilm,
            JadwalTayang.data_jadwal_tayang.GSIdStudio,
            JadwalTayang.data_jadwal_tayang.GSTanggal,
            JadwalTayang.data_jadwal_tayang.GSWaktuMulai,
            JadwalTayang.data_jadwal_tayang.GSWaktuSelesai
        )

        Me.Close()
    End Sub
End Class