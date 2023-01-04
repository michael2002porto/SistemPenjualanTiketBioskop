Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports Microsoft.Win32
Imports Mysqlx.XDevAPI.Common

Public Class JadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared selectedTableKoleksi, selectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_jadwal_tayang = New DataJadwalTayang()
        ReloadDataTableDatabaseNowPlaying()
        ReloadDataTableDatabaseUpcoming()
    End Sub

    Private Sub ButtonViewAll_Click(sender As Object, e As EventArgs) Handles ButtonViewAll.Click
        Dim lihat_semua_jadwal_tayang = New LihatSemuaJadwalTayang()
        lihat_semua_jadwal_tayang.Show()
        Me.Hide()
    End Sub

    Private Sub ReloadDataTableDatabaseNowPlaying()
        'DataGridViewJadwalTayang.DataSource = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        DataGridViewJadwalTayangNowPlaying.Rows.Clear()
        DataGridViewJadwalTayangNowPlaying.RowTemplate.Height = 100
        Dim source = data_jadwal_tayang.GetDataJadwalTayangDatabase("WHERE DATE(tanggal) = CURDATE()")
        For Each rowJadwalTayang In source
            Dim dataTable = {
                Image.FromFile(rowJadwalTayang(3)), 'Foto Film
                rowJadwalTayang(2), 'Nama Film
                rowJadwalTayang(5), 'Studio
                Convert.ToDateTime(rowJadwalTayang(9)).ToString("HH:mm"), 'Mulai Tayang
                Convert.ToDateTime(rowJadwalTayang(10)).ToString("HH:mm") 'Selesai Tayang
            }
            DataGridViewJadwalTayangNowPlaying.Rows.Add(dataTable)
        Next
        selectedTableKoleksi = Nothing
    End Sub

    Private Sub ReloadDataTableDatabaseUpcoming()
        'DataGridViewJadwalTayang.DataSource = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        DataGridViewJadwalTayangUpcoming.Rows.Clear()
        DataGridViewJadwalTayangUpcoming.RowTemplate.Height = 100
        Dim source = data_jadwal_tayang.GetDataJadwalTayangDatabase("WHERE DATE(tanggal) > CURDATE()")
        For Each rowJadwalTayang In source
            Dim dataTable = {
                Image.FromFile(rowJadwalTayang(3)), 'Foto Film
                rowJadwalTayang(2), 'Nama Film
                rowJadwalTayang(5), 'Studio
                Convert.ToDateTime(rowJadwalTayang(8)).ToString("dd/MM/yyyy"), 'Tanggal Tayang
                Convert.ToDateTime(rowJadwalTayang(9)).ToString("HH:mm"), 'Mulai Tayang
                Convert.ToDateTime(rowJadwalTayang(10)).ToString("HH:mm") 'Selesai Tayang
            }
            DataGridViewJadwalTayangUpcoming.Rows.Add(dataTable)
        Next
        selectedTableKoleksi = Nothing
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Dim signIn = New SignIn()
        signIn.Show()
        Me.Close()
    End Sub

    Private Sub BtnFilm_Click(sender As Object, e As EventArgs) Handles BtnFilm.Click
        Dim film = New Film()
        film.Show()
        Me.Close()
    End Sub

    Private Sub BtnStudio_Click(sender As Object, e As EventArgs) Handles BtnStudio.Click
        Dim studio = New Studio()
        studio.Show()
        Me.Close()
    End Sub

    Private Sub BtnJadwalTayang_Click(sender As Object, e As EventArgs) Handles BtnJadwalTayang.Click
        Dim jadwalTayang = New JadwalTayang()
        jadwalTayang.Show()
        Me.Close()
    End Sub

    Private Sub BtnTiket_Click(sender As Object, e As EventArgs) Handles BtnTiket.Click

        Dim tiket_form = New Tiket()
        tiket_form.Show()
        Me.Close()
    End Sub
End Class