Imports System.IO

Public Class Film

    Public Shared dataFilm As DataFilm

    Public Shared selectedTableKoleksi As Integer
    Public Shared selectedTableKoleksiFilm As String
    Private selectedRow As DataGridViewRow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataFilm = New DataFilm()

        ReloadDataTableDatabaseFilm()
    End Sub

    Private Sub Film_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabaseFilm()
        'LblUsername.Text = SignIn.data_user(1).toString()
        'Lblid.Text = SignIn.data_user(0).toString()
    End Sub

    Private Sub ReloadDataTableDatabaseFilm()
        DGFilm.DataSource = dataFilm.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
        Dim tambahFilm = New TambahFilm()
        tambahFilm.Show()
    End Sub

    Private Sub BtnUpdateFilm_Click(sender As Object, e As EventArgs) Handles BtnUpdateFilm.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataFilm.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            dataFilm.GSFoto = selectedKoleksi(9)

            dataFilm.GSNamaFilm = selectedKoleksi(1)
            dataFilm.GSDeskripsi = selectedKoleksi(3)
            dataFilm.GSDirector = selectedKoleksi(4)
            dataFilm.GSDateRelease = selectedKoleksi(6)
            dataFilm.GSDuration = selectedKoleksi(5)
            dataFilm.GSHargaFilm = selectedKoleksi(8)
            dataFilm.GSBahasa = selectedKoleksi(7)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedKoleksi(2))

            Dim updateFilm = New EditFilm()
            updateFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub BtnRemoveFilm_Click(sender As Object, e As EventArgs) Handles BtnRemoveFilm.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataFilm.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            dataFilm.GSFoto = selectedKoleksi(9)

            dataFilm.GSNamaFilm = selectedKoleksi(1)
            dataFilm.GSDeskripsi = selectedKoleksi(3)
            dataFilm.GSDirector = selectedKoleksi(4)
            dataFilm.GSDateRelease = selectedKoleksi(6)
            dataFilm.GSDuration = selectedKoleksi(5)
            dataFilm.GSHargaFilm = selectedKoleksi(8)
            dataFilm.GSBahasa = selectedKoleksi(7)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedKoleksi(2))

            Dim removeFilm = New HapusFilm()
            removeFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub DGFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFilm.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        Try
            selectedRow = DGFilm.Rows(index)
            'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiFilm = selectedRow.Cells(1).Value
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            MessageBox.Show("Please select data")
        End Try
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