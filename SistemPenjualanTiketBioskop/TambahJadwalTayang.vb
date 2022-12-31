Imports Google.Protobuf.WellKnownTypes

Public Class TambahJadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared data_film As DataFilm
    Public Shared data_studio As DataStudio
    Dim layanan As New List(Of String) From {"Rawat Jalan", "Umum"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_film = New DataFilm()
        data_studio = New DataStudio()
        ComboBoxFilm.DataSource = data_film.GetDataFilmDatabaseList()
        ComboBoxStudio.DataSource = data_studio.GetDataStudioDatabaseList()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxFilm.Text.Length < 1 Then
            ComboBoxFilm.Select()
            MessageBox.Show("Please select film")
            Return
        End If

        If ComboBoxStudio.Text.Length < 1 Then
            ComboBoxStudio.Select()
            MessageBox.Show("Please select studio")
            Return
        End If

        JadwalTayang.data_jadwal_tayang.GSIdFilm = Integer.Parse(ComboBoxFilm.SelectedItem().Split(" | ")(0))
        JadwalTayang.data_jadwal_tayang.GSIdStudio = Integer.Parse(ComboBoxStudio.SelectedItem().Split(" | ")(0))
        JadwalTayang.data_jadwal_tayang.GSTanggal = DateTimePickerTanggal.Value.ToString("yyyy-MM-dd")
        JadwalTayang.data_jadwal_tayang.GSWaktuMulai = DateTimePickerWaktuMulai.Value.ToString("HH:mm:ss")
        JadwalTayang.data_jadwal_tayang.GSWaktuSelesai = DateTimePickerWaktuSelesai.Value.ToString("HH:mm:ss")

        JadwalTayang.data_jadwal_tayang.AddDataJadwalTayangDatabase(
            JadwalTayang.data_jadwal_tayang.GSIdFilm,
            JadwalTayang.data_jadwal_tayang.GSIdStudio,
            JadwalTayang.data_jadwal_tayang.GSTanggal,
            JadwalTayang.data_jadwal_tayang.GSWaktuMulai,
            JadwalTayang.data_jadwal_tayang.GSWaktuSelesai
        )

        Me.Close()
    End Sub

    Private Sub BtnLihatDetailFilm_Click(sender As Object, e As EventArgs) Handles BtnLihatDetailFilm.Click
        Integer.Parse(ComboBoxFilm.SelectedItem().Split(" | ")(0))
    End Sub
End Class