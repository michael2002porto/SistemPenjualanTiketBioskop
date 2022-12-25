Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports Mysqlx.XDevAPI.Common

Public Class JadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared selectedTableKoleksi, selectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_jadwal_tayang = New DataJadwalTayang()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        'DataGridViewJadwalTayang.DataSource = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        DataGridViewJadwalTayang.Rows.Clear()
        DataGridViewJadwalTayang.RowTemplate.Height = 100
        Dim source = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        For Each rowKoleksi In source
            Dim dataTable = {
                Image.FromFile(rowKoleksi(3)), 'Foto FIlm
                rowKoleksi(2), 'Nama Film
                rowKoleksi(5), 'Studio
                rowKoleksi(8), 'Mulai Tayang
                rowKoleksi(9) 'Selesai Tayang
            }
            DataGridViewJadwalTayang.Rows.Add(dataTable)
        Next
        selectedTableKoleksi = Nothing
    End Sub
End Class