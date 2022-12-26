Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports Mysqlx.XDevAPI.Common

Public Class LihatSemuaJadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared selectedTableKoleksi, selectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_jadwal_tayang = New DataJadwalTayang()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah_jadwal_tayang = New TambahJadwalTayang()
        tambah_jadwal_tayang.Show()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            If selectedTableKoleksi Is Nothing Or selectedTableKoleksiNama Is Nothing Then
                Throw New System.Exception("Please select data grid")
            End If
            Dim selectedKoleksi As List(Of String) = data_jadwal_tayang.GetDataJadwalTayangByIDDatabase(selectedTableKoleksi)

            data_jadwal_tayang.GSIdFilm = selectedKoleksi(1)
            data_jadwal_tayang.GSIdStudio = selectedKoleksi(2)
            data_jadwal_tayang.GSTanggal = selectedKoleksi(3)
            data_jadwal_tayang.GSWaktuMulai = selectedKoleksi(4)
            data_jadwal_tayang.GSWaktuSelesai = selectedKoleksi(5)

            Dim edit_jadwal_tayang = New EditJadwalTayang()
            edit_jadwal_tayang.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ButtonDetailFilm_Click(sender As Object, e As EventArgs) Handles ButtonDetailFilm.Click

    End Sub

    Private Sub ReloadDataTableDatabase()
        'DataGridViewJadwalTayang.DataSource = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        DataGridViewJadwalTayangAll.Rows.Clear()
        DataGridViewJadwalTayangAll.RowTemplate.Height = 100
        Dim source = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        For Each rowKoleksi In source
            Dim dataTable = {
                Image.FromFile(rowKoleksi(3)), 'Foto FIlm
                rowKoleksi(2), 'Nama Film
                rowKoleksi(5), 'Studio
                Convert.ToDateTime(rowKoleksi(7)).ToString("dd/MM/yyyy"), 'Tanggal Tayang
                Convert.ToDateTime(rowKoleksi(8)).ToString("HH:mm"), 'Mulai Tayang
                Convert.ToDateTime(rowKoleksi(9)).ToString("HH:mm") 'Selesai Tayang
            }
            DataGridViewJadwalTayangAll.Rows.Add(dataTable)
        Next
        selectedTableKoleksi = Nothing
    End Sub
End Class