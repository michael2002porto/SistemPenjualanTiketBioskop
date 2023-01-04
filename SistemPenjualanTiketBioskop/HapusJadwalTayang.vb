Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HapusJadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared c_film As Film
    Public Shared data_film As DataFilm
    Public Shared data_studio As DataStudio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        c_film = New Film()
        data_film = New DataFilm()
        data_studio = New DataStudio()
        ComboBoxFilm.DataSource = data_film.GetDataFilmDatabaseList()
        ComboBoxStudio.DataSource = data_studio.GetDataStudioDatabaseList()

        ComboBoxFilm.SelectedItem() = LihatSemuaJadwalTayang.data_jadwal_tayang.GSIdFilm.ToString + " | " + LihatSemuaJadwalTayang.data_film.GSNamaFilm
        ComboBoxStudio.SelectedItem() = LihatSemuaJadwalTayang.data_jadwal_tayang.GSIdStudio.ToString + " | " + LihatSemuaJadwalTayang.data_studio.GSNama

        DateTimePickerTanggal.Format = DateTimePickerFormat.Short
        DateTimePickerTanggal.Value = LihatSemuaJadwalTayang.data_jadwal_tayang.GSTanggal
        DateTimePickerWaktuMulai.Format = DateTimePickerFormat.Time
        DateTimePickerWaktuMulai.Value = DateTime.Parse(LihatSemuaJadwalTayang.data_jadwal_tayang.GSTanggal).Add(TimeSpan.Parse(LihatSemuaJadwalTayang.data_jadwal_tayang.GSWaktuMulai))
        DateTimePickerWaktuSelesai.Format = DateTimePickerFormat.Time
        DateTimePickerWaktuSelesai.Value = DateTime.Parse(LihatSemuaJadwalTayang.data_jadwal_tayang.GSTanggal).Add(TimeSpan.Parse(LihatSemuaJadwalTayang.data_jadwal_tayang.GSWaktuSelesai))

        'Disabled all user input
        ComboBoxFilm.Enabled = False
        ComboBoxStudio.Enabled = False
        DateTimePickerTanggal.Enabled = False
        DateTimePickerWaktuMulai.Enabled = False
        DateTimePickerWaktuSelesai.Enabled = False
    End Sub

    Private Sub BtnLihatDetailFilm_Click(sender As Object, e As EventArgs) Handles BtnLihatDetailFilm.Click
        Dim selectedComboBoxFilm = Integer.Parse(ComboBoxFilm.SelectedItem().Split(" | ")(0))
        Try
            Dim selectedFilm As List(Of String) = data_film.GetDataFilmByIDDatabase(selectedComboBoxFilm)

            c_film.dataFilm.GSFoto = selectedFilm(10)
            c_film.dataFilm.GSNamaFilm = selectedFilm(1)
            c_film.dataFilm.GSRatingUsia = selectedFilm(2)
            c_film.dataFilm.GSDeskripsi = selectedFilm(4)
            c_film.dataFilm.GSDirector = selectedFilm(5)
            c_film.dataFilm.GSDateRelease = selectedFilm(7)
            c_film.dataFilm.GSDuration = selectedFilm(6)
            c_film.dataFilm.GSHargaFilm = selectedFilm(9)
            c_film.dataFilm.GSBahasa = selectedFilm(8)
            c_film.dataFilm.GSGenre = data_film.ConvertStringToGenre(selectedFilm(3))

            Dim selectFilm = New InfoFilm()
            selectFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try
    End Sub

    Private Sub BtnLihatDetailStudio_Click(sender As Object, e As EventArgs) Handles BtnLihatDetailStudio.Click
        Dim selectedComboBoxStudio = Integer.Parse(ComboBoxStudio.SelectedItem().Split(" | ")(0))
        Try
            Dim selectedStudio As List(Of String) = data_studio.GetDataStudioByIDDatabase(selectedComboBoxStudio)

            data_studio.GSNama = selectedStudio(1)
            data_studio.GSKapasitas = selectedStudio(2)
            data_studio.GSHarga = selectedStudio(3)

            MsgBox(
                "Jenis Studio: " + selectedStudio(2) + Environment.NewLine +
                "Kapasitas: " + selectedStudio(3) + Environment.NewLine +
                "Harga Kursi: " + selectedStudio(4) + Environment.NewLine,
                MsgBoxStyle.Information,
                selectedStudio(1)
            )
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        LihatSemuaJadwalTayang.data_jadwal_tayang.DeleteDataJadwalTayangByIDDatabase(
            LihatSemuaJadwalTayang.selectedIdJadwalTayang
        )

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class