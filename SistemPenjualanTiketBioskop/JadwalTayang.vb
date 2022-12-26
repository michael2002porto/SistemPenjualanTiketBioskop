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
                Image.FromFile(rowJadwalTayang(3)), 'Foto FIlm
                rowJadwalTayang(2), 'Nama Film
                rowJadwalTayang(5), 'Studio
                Convert.ToDateTime(rowJadwalTayang(8)).ToString("HH:mm"), 'Mulai Tayang
                Convert.ToDateTime(rowJadwalTayang(9)).ToString("HH:mm") 'Selesai Tayang
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
                Image.FromFile(rowJadwalTayang(3)), 'Foto FIlm
                rowJadwalTayang(2), 'Nama Film
                rowJadwalTayang(5), 'Studio
                Convert.ToDateTime(rowJadwalTayang(7)).ToString("dd/MM/yyyy"), 'Tanggal Tayang
                Convert.ToDateTime(rowJadwalTayang(8)).ToString("HH:mm"), 'Mulai Tayang
                Convert.ToDateTime(rowJadwalTayang(9)).ToString("HH:mm") 'Selesai Tayang
            }
            DataGridViewJadwalTayangUpcoming.Rows.Add(dataTable)
        Next
        selectedTableKoleksi = Nothing
    End Sub
End Class