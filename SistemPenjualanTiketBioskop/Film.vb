Imports System.IO
Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Film

    Public Shared dataFilm As DataFilm

    Public Shared selectedTableFilm As Integer
    Public Shared selectedTableNamaFilm As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataFilm = New DataFilm()

        ReloadDataTableDatabaseFilm()
    End Sub

    Private Sub Film_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabaseFilm()
        LblUsername.Text = SignIn.data_user(1).ToString()
        Lblid.Text = SignIn.data_user(0).ToString()
    End Sub

    Private Sub ReloadDataTableDatabaseFilm()
        DGFilm.DataSource = dataFilm.GetDataFilmDatabase()
    End Sub

    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
        Dim tambahFilm = New TambahFilm()
        tambahFilm.Show()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try
            Dim selectedFilm As List(Of String) = dataFilm.GetDataFilmByIDDatabase(selectedTableFilm)

            dataFilm.GSFoto = selectedFilm(10)

            dataFilm.GSNamaFilm = selectedFilm(1)
            dataFilm.GSRatingUsia = selectedFilm(2)
            dataFilm.GSDeskripsi = selectedFilm(4)
            dataFilm.GSDirector = selectedFilm(5)
            dataFilm.GSDateRelease = selectedFilm(7)
            dataFilm.GSDuration = selectedFilm(6)
            dataFilm.GSHargaFilm = selectedFilm(9)
            dataFilm.GSBahasa = selectedFilm(8)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedFilm(3))
            Dim selectFilm = New InfoFilm()
            selectFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try
    End Sub

    Private Sub BtnUpdateFilm_Click(sender As Object, e As EventArgs) Handles BtnUpdateFilm.Click
        Try
            Dim selectedFilm As List(Of String) = dataFilm.GetDataFilmByIDDatabase(selectedTableFilm)

            dataFilm.GSFoto = selectedFilm(10)

            dataFilm.GSNamaFilm = selectedFilm(1)
            dataFilm.GSRatingUsia = selectedFilm(2)
            dataFilm.GSDeskripsi = selectedFilm(4)
            dataFilm.GSDirector = selectedFilm(5)
            dataFilm.GSDateRelease = selectedFilm(7)
            dataFilm.GSDuration = selectedFilm(6)
            dataFilm.GSHargaFilm = selectedFilm(9)
            dataFilm.GSBahasa = selectedFilm(8)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedFilm(3))
            Dim updateFilm = New EditFilm()
            updateFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub BtnRemoveFilm_Click(sender As Object, e As EventArgs) Handles BtnRemoveFilm.Click
        Try
            Dim selectedFilm As List(Of String) = dataFilm.GetDataFilmByIDDatabase(selectedTableFilm)

            dataFilm.GSFoto = selectedFilm(10)

            dataFilm.GSNamaFilm = selectedFilm(1)
            dataFilm.GSRatingUsia = selectedFilm(2)
            dataFilm.GSDeskripsi = selectedFilm(4)
            dataFilm.GSDirector = selectedFilm(5)
            dataFilm.GSDateRelease = selectedFilm(7)
            dataFilm.GSDuration = selectedFilm(6)
            dataFilm.GSHargaFilm = selectedFilm(9)
            dataFilm.GSBahasa = selectedFilm(8)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedFilm(3))

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
            selectedTableFilm = selectedRow.Cells(0).Value
            selectedTableNamaFilm = selectedRow.Cells(1).Value
        Catch ex As Exception
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
    Public Sub FilterData(valueToSearch As String)
        Dim connection As New MySqlConnection

        connection.ConnectionString = "server =" + server + ";" _
                                   + "user id=" + username + ";" _
                                   + "password=" + password + ";" _
                                   + "database =" + database

        Dim searchQuery As String = "SELECT id, nama_film, genre, director, duration, date_release, bahasa, harga_film, rating_usia FROM FILM WHERE nama_film like '%" & TxtSearch.Text & "%'
                                     OR genre like '%" & TxtSearch.Text & "%' OR director like '%" & TxtSearch.Text & "%' OR duration like '%" & TxtSearch.Text & "%' 
                                     OR bahasa like '%" & TxtSearch.Text & "%' OR harga_film like '%" & TxtSearch.Text & "%' OR rating_usia like '%" & TxtSearch.Text & "%' 
                                     OR id like '%" & TxtSearch.Text & "%'"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        DGFilm.DataSource = table
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        FilterData(TxtSearch.Text)
    End Sub

    Private Sub Film_Load(sender As Object, e As EventArgs) Handles Me.Load
        FilterData("")
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        FilterData(TxtSearch.Text)
    End Sub
End Class