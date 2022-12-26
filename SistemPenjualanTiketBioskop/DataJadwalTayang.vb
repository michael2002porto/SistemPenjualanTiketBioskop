Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class DataJadwalTayang
    Private id_jadwal_tayang As Integer
    Private id_film As Integer
    Private id_studio As Integer
    Private tanggal As DateOnly
    Private waktu_mulai As TimeOnly
    Private waktu_selesai As TimeOnly

    'Database Global Variable
    Private jadwalTayangDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    Public Property GSIdJadwalTayang() As Integer
        Get
            Return id_jadwal_tayang
        End Get
        Set(ByVal value As Integer)
            id_jadwal_tayang = value
        End Set
    End Property
    Public Property GSIdFilm() As Integer
        Get
            Return id_film
        End Get
        Set(ByVal value As Integer)
            id_film = value
        End Set
    End Property
    Public Property GSIdStudio() As Integer
        Get
            Return id_studio
        End Get
        Set(ByVal value As Integer)
            id_studio = value
        End Set
    End Property
    Public Property GSTanggal()
        Get
            Return tanggal
        End Get
        Set(ByVal value)
            tanggal = value
        End Set
    End Property
    Public Property GSWaktuMulai()
        Get
            Return waktu_mulai
        End Get
        Set(ByVal value)
            waktu_mulai = value
        End Set
    End Property
    Public Property GSWaktuSelesai()
        Get
            Return waktu_selesai
        End Get
        Set(ByVal value)
            waktu_selesai = value
        End Set
    End Property

    Public Function GetDataJadwalTayangDatabase(Optional where As String = "")
        Dim result As New ArrayList()

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText =
            "SELECT jt.id_jadwal_tayang,
            jt.id_film, f.film, f.foto,
            jt.id_studio, s.nama_studio, s.kapasitas, s.harga_kursi,
            jt.tanggal, jt.waktu_mulai, jt.waktu_selesai
            FROM jadwal_tayang jt
            LEFT JOIN film f ON f.id = jt.id_film
            LEFT JOIN studio s ON s.id = jt.id_studio " + where

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(
                {
                    sqlRead.GetString(0).ToString(), 'id_jadwal_tayang
                    sqlRead.GetString(1).ToString(), 'id_film
                    sqlRead.GetString(2).ToString(), 'film
                    sqlRead.GetString(3).ToString(), 'foto
                    sqlRead.GetString(4).ToString(), 'id_studio
                    sqlRead.GetString(5).ToString(), 'nama_studio
                    sqlRead.GetString(6).ToString(), 'kapasitas
                    sqlRead.GetString(7).ToString(), 'harga_kursi
                    sqlRead.GetString(8).ToString(), 'tanggal
                    sqlRead.GetString(9).ToString(), 'waktu_mulai
                    sqlRead.GetString(10).ToString() 'waktu_selesai
                }
            )
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataJadwalTayangDatabase(
        dir_gambar As String,
        nama_koleksi As String,
        jenis_koleksi As String,
        penerbit_koleksi As String,
        deskripsi_koleksi As String,
        tahun_terbit As Integer,
        lokasi_rak As String,
        tanggal_masuk As Date,
        stock_koleksi As Integer,
        bahasa_koleksi As String,
        kategori_koleksi As String
    )
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery =
                "INSERT INTO KOLEKSI(nama_koleksi, dir_gambar, deskripsi, penerbit, jenis_koleksi,
                tahun_terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori) VALUE('" _
                & nama_koleksi & "', '" _
                & dir_gambar & "', '" _
                & deskripsi_koleksi & "', '" _
                & penerbit_koleksi & "', '" _
                & jenis_koleksi & "', '" _
                & tahun_terbit & "', '" _
                & lokasi_rak & "', '" _
                & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                & stock_koleksi & "', '" _
                & bahasa_koleksi & "', '" _
                & kategori_koleksi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataJadwalTayangByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText =
            "SELECT id_koleksi,
            nama_koleksi,
            dir_gambar,
            deskripsi,
            penerbit,
            jenis_koleksi,
            tahun_terbit,
            lokasi,
            tanggal_masuk_koleksi,
            stock,
            bahasa,
            kategori
            FROM koleksi
            WHERE id_koleksi='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataJadwalTayangByIDDatabase(
        ID As Integer,
        dir_gambar As String,
        nama_koleksi As String,
        jenis_koleksi As String,
        penerbit_koleksi As String,
        deskripsi_koleksi As String,
        tahun_terbit As String,
        lokasi_rak As String,
        tanggal_masuk As String,
        stock_koleksi As Integer,
        bahasa_koleksi As String,
        kategori_koleksi As String
    )
        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery =
                "UPDATE koleksi SET " &
                "nama_koleksi='" & nama_koleksi & "', " &
                "dir_gambar='" & dir_gambar & "', " &
                "deskripsi='" & deskripsi_koleksi & "', " &
                "penerbit='" & penerbit_koleksi & "', " &
                "jenis_koleksi='" & jenis_koleksi & "', " &
                "tahun_terbit='" & tahun_terbit & "', " &
                "lokasi='" & lokasi_rak & "', " &
                "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
                "stock='" & stock_koleksi & "', " &
                "bahasa='" & bahasa_koleksi & "', " &
                "kategori='" & kategori_koleksi & "' " &
                "WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataJadwalTayangByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery =
                "DELETE FROM koleksi " &
                "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
