Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports Microsoft.VisualBasic.Logging
Imports Mysqlx.XDevAPI.Common

Public Class LihatSemuaJadwalTayang
    Public Shared data_jadwal_tayang As DataJadwalTayang
    Public Shared data_film As DataFilm
    Public Shared data_studio As DataStudio
    Public Shared selectedIdJadwalTayang, selectedIdFilm, selectedIdStudio As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_jadwal_tayang = New DataJadwalTayang()
        data_film = New DataFilm()
        data_studio = New DataStudio()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah_jadwal_tayang = New TambahJadwalTayang()
        tambah_jadwal_tayang.Show()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            If selectedIdJadwalTayang Is Nothing Then
                Throw New System.Exception("Please select data grid")
            End If
            Dim selectedJadwalTayang As List(Of String) = data_jadwal_tayang.GetDataJadwalTayangByIDDatabase(selectedIdJadwalTayang)

            data_jadwal_tayang.GSIdJadwalTayang = selectedJadwalTayang(0)
            data_jadwal_tayang.GSIdFilm = selectedJadwalTayang(1)
            data_jadwal_tayang.GSIdStudio = selectedJadwalTayang(4)
            data_jadwal_tayang.GSTanggal = selectedJadwalTayang(8)
            data_jadwal_tayang.GSWaktuMulai = selectedJadwalTayang(9)
            data_jadwal_tayang.GSWaktuSelesai = selectedJadwalTayang(10)
            data_film.GSNamaFilm = selectedJadwalTayang(2)
            data_studio.GSNama = selectedJadwalTayang(5)

            Dim edit_jadwal_tayang = New EditJadwalTayang()
            edit_jadwal_tayang.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim jadwal_tayang = New JadwalTayang()
        jadwal_tayang.Show()
        Me.Close()
    End Sub

    Private Sub DataGridViewJadwalTayangAll_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJadwalTayangAll.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJadwalTayangAll.Rows(index)

        selectedIdJadwalTayang = selectedRow.Cells(0).Value
        selectedIdFilm = selectedRow.Cells(1).Value
        selectedIdStudio = selectedRow.Cells(2).Value
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            If selectedIdJadwalTayang Is Nothing Then
                Throw New System.Exception("Please select data grid")
            End If
            Dim selectedJadwalTayang As List(Of String) = data_jadwal_tayang.GetDataJadwalTayangByIDDatabase(selectedIdJadwalTayang)

            data_jadwal_tayang.GSIdJadwalTayang = selectedJadwalTayang(0)
            data_jadwal_tayang.GSIdFilm = selectedJadwalTayang(1)
            data_jadwal_tayang.GSIdStudio = selectedJadwalTayang(4)
            data_jadwal_tayang.GSTanggal = selectedJadwalTayang(8)
            data_jadwal_tayang.GSWaktuMulai = selectedJadwalTayang(9)
            data_jadwal_tayang.GSWaktuSelesai = selectedJadwalTayang(10)
            data_film.GSNamaFilm = selectedJadwalTayang(2)
            data_studio.GSNama = selectedJadwalTayang(5)

            Dim hapus_jadwal_tayang = New HapusJadwalTayang()
            hapus_jadwal_tayang.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ReloadDataTableDatabase()
        'DataGridViewJadwalTayang.DataSource = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        DataGridViewJadwalTayangAll.Rows.Clear()
        DataGridViewJadwalTayangAll.RowTemplate.Height = 100
        Dim source = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        For Each rowJadwalTayang In source
            Dim dataTable = {
                rowJadwalTayang(0), 'Id Jadwal Tayang
                rowJadwalTayang(1), 'Id Film
                rowJadwalTayang(4), 'Id Studio
                Image.FromFile(rowJadwalTayang(3)), 'Foto Film
                rowJadwalTayang(2), 'Nama Film
                rowJadwalTayang(5) + " (" + "Kapasitas = " + rowJadwalTayang(6) + ", " + "Harga = Rp " + rowJadwalTayang(7) + ")", 'Studio
                Convert.ToDateTime(rowJadwalTayang(8)).ToString("dd/MM/yyyy"), 'Tanggal Tayang
                Convert.ToDateTime(rowJadwalTayang(9)).ToString("HH:mm"), 'Mulai Tayang
                Convert.ToDateTime(rowJadwalTayang(10)).ToString("HH:mm") 'Selesai Tayang
            }
            DataGridViewJadwalTayangAll.Rows.Add(dataTable)
        Next

        selectedIdJadwalTayang = Nothing
        selectedIdFilm = Nothing
        selectedIdStudio = Nothing
    End Sub

    Private Sub LihatSemuaJadwalTayang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
        LblUsername.Text = SignIn.data_user(1).ToString()
        Lblid.Text = SignIn.data_user(0).ToString()
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
        Dim tiket = New Tiket()
        tiket.Show()
        Me.Close()
    End Sub
End Class