Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class TambahTiket
    Public Shared selectedTableJadwal As Integer
    Public Shared data_tiket As DataTiket
    Private namaFilm As String
    Private idFilm As Integer
    Private id_jadwal_tayang As Integer
    Private total_harga As Integer
    Private harga_kursi As Integer
    Private harga_film As Integer
    Private sqlQuery As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_tiket = New DataTiket
        ReloadDataTableDatabase()
    End Sub

    Private Sub TambahTiket_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJadwal.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        Try
            selectedrow = DataGridJadwal.Rows(index)
            selectedTableJadwal = selectedrow.Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim tiket = New Tiket()
        tiket.Show()
        Me.Close()
    End Sub

    Private Sub TambahTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbConn As New MySqlConnection
        Dim sqlRead As MySqlDataReader
        Dim sqlCommand As New MySqlCommand
        dbConn.ConnectionString = "server = localhost; user id = root; password = ''; database = bioskop"

        Try
            dbConn.Open()
            Dim Query As String
            Query = "SELECT * FROM bioskop.film"
            sqlCommand = New MySqlCommand(Query, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                Dim judul = sqlRead.GetString("nama_film")
                CbBoxFilm.Items.Add(judul)
            End While

            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

        Try
            namaFilm = CbBoxFilm.SelectedItem()

            Dim dbConn As New MySqlConnection
            Dim sqlRead As MySqlDataReader
            Dim sqlCommand As New MySqlCommand
            dbConn.ConnectionString = "server = localhost; user id = root; password = ''; database = bioskop"
            dbConn.Open()
            Dim Query As String = "SELECT id FROM film WHERE nama_film = '" & namaFilm & "'"
            sqlCommand = New MySqlCommand(Query, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read()
                If sqlRead.HasRows Then
                    idFilm = sqlRead.Item("id")
                End If
            End While

            dbConn.Close()
            ReloadDataTableDatabase()
        Catch ex As Exception
            MessageBox.Show("Please select the movie title")
        End Try

    End Sub

    Public Function GetDataJadwalDatabase() As DataTable
        Dim result As New DataTable

        Dim dbConn As New MySqlConnection
        Dim sqlRead As MySqlDataReader
        Dim sqlCommand As New MySqlCommand
        dbConn.ConnectionString = "server = localhost; user id = root; password = ''; database = bioskop"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT jadwal_tayang.id_jadwal_tayang AS 'ID Jadwal Tayang',
                                   studio.nama_studio AS 'Nama Studio',
                                   film.harga_film AS 'Harga Film', 
                                   studio.harga_kursi AS 'Harga Kursi',
                                   jadwal_tayang.waktu_mulai AS 'Waktu Mulai'
                                   FROM ((jadwal_tayang
                                   INNER JOIN film ON jadwal_tayang.id_film = film.id)
                                   INNER JOIN studio ON jadwal_tayang.id_studio = studio.id) WHERE id_film = '" & idFilm & "'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Private Sub ReloadDataTableDatabase()
        DataGridJadwal.DataSource = GetDataJadwalDatabase()
    End Sub

    Private Sub BtnBuy_Click(sender As Object, e As EventArgs) Handles BtnBuy.Click
        Dim dbConn As New MySqlConnection
        Dim sqlRead As MySqlDataReader
        Dim sqlCommand As New MySqlCommand
        Try
            Dim selectedJadwal As List(Of String) = data_tiket.GetDataJadwalByIDDatabase(selectedTableJadwal)
            id_jadwal_tayang = selectedJadwal(0)
            harga_film = selectedJadwal(2)
            harga_kursi = selectedJadwal(3)

            dbConn.ConnectionString = "server = localhost; user id = root; password = ''; database = bioskop"

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO TIKET(id_jadwal_tayang, total_harga) VALUE('" _
                                    & id_jadwal_tayang & "', '" _
                                    & (harga_film + harga_kursi) & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Tiket berhasil ditambahkan")
            dbConn.Close()

            sqlRead.Close()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        Finally
            dbConn.Dispose()
        End Try

        Dim tiket = New Tiket()
        tiket.Show()
        Me.Close()
    End Sub


End Class