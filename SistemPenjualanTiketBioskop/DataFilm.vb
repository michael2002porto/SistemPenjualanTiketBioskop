Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataFilm
    Private foto As String
    Private film As String
    Private genre As New List(Of String)
    Private deskripsi
    Private director As String
    Private duration As String
    Private date_release
    Private bahasa As String
    Private harga_film As String
    Private rating_usia As String

    Private validateJudulFilm As String

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    ' Getter And Setter
    ' Foto
    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property

    ' Nama
    Public Property GSNamaFilm() As String
        Get
            Return film
        End Get
        Set(ByVal value As String)
            film = value
        End Set
    End Property

    ' Genre
    Public Property GSGenre() As List(Of String)
        Get
            Return genre
        End Get
        Set(ByVal value As List(Of String))
            genre = value
        End Set
    End Property

    ' Deskripsi
    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public ReadOnly Property getDeskripsiProperty() As String
        Get
            Return deskripsi
        End Get
    End Property

    ' Director
    Public Property GSDirector() As String
        Get
            Return director
        End Get
        Set(ByVal value As String)
            director = value
        End Set
    End Property

    ' Duration
    Public Property GSDuration() As String
        Get
            Return duration
        End Get
        Set(ByVal value As String)
            duration = value
        End Set
    End Property

    ' Date Release
    Public Property GSDateRelease() As String
        Get
            Return date_release
        End Get
        Set(ByVal value As String)
            date_release = value
        End Set
    End Property

    ' Bahasa
    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    ' Harga
    Public Property GSHargaFilm() As String
        Get
            Return harga_film
        End Get
        Set(ByVal value As String)
            harga_film = value
        End Set
    End Property

    ' Rating Usia
    Public Property GSRatingUsia() As String
        Get
            Return rating_usia
        End Get
        Set(ByVal value As String)
            rating_usia = value
        End Set
    End Property

    Public Function AddGenre(value As String)
        genre.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getGenreItem() As List(Of String)
        Get
            Return genre
        End Get
    End Property

    Public Function resetGenre()
        genre.Clear()
    End Function

    Public Function ConvertGenreToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append(",")
        Next

        ' Convert to string.
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToGenre(value As String)
        Dim arr() As String = value.Split(",")

        ' Convert to List.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    'Menampilkan data di data grid view
    Public Function DBConnection()
        dbConn.ConnectionString = "server =" + server + ";" _
                                   + "user id=" + username + ";" _
                                   + "password=" + password + ";" _
                                   + "database =" + database
    End Function

    '' Function untuk mengambil data film di database
    Public Function GetDataFilmDatabase() As DataTable
        Dim result As New DataTable

        Try
            DBConnection()

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id AS 'ID',
                                      nama_film AS 'Film',
                                      rating_usia AS 'Rating Usia',
                                      genre AS 'Genre',
                                      deskripsi AS 'Deskripsi',
                                      director AS 'Director',
                                      duration AS 'Duration',
                                      date_release AS 'Date Release',
                                      bahasa AS 'Bahasa',
                                      harga_film AS 'Harga'
                                      From film"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            'Return result

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function


    '' Function untuk menambahkan data film di database
    Public Function AddDataFilmDatabase(film As String,
                                        rating_usia As String,
                                        genre As String,
                                        deskripsi As String,
                                        director As String,
                                        duration As String,
                                        date_release As Date,
                                        bahasa As String,
                                        harga_film As Integer,
                                        foto As String)

        DBConnection()

        Try

            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "INSERT INTO FILM(nama_film, rating_usia,
                        genre, deskripsi, director, duration, 
                        date_release, bahasa, harga_film,
                        foto) VALUE('" _
                        & film & "', '" _
                        & rating_usia & "', '" _
                        & genre & "', '" _
                        & deskripsi & "', '" _
                        & director & "', '" _
                        & duration & "', '" _
                        & date_release.ToString("yyyy/MM/dd") & "', '" _
                        & bahasa & "', '" _
                        & harga_film & "', '" _
                        & foto & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Data Added")
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    '' Function untuk mengambil data film di database berdasarkan id
    Public Function GetDataFilmByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            DBConnection()

            dbConn.Open()

            'MessageBox.Show(ID)

            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, 
                                      nama_film, 
                                      rating_usia,
                                      genre, 
                                      deskripsi, 
                                      director, 
                                      duration, 
                                      date_release, 
                                      bahasa, 
                                      harga_film,
                                      foto
                                      FROM film
                                      WHERE id='" & ID & "'"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                ' MessageBox.Show(sqlRead.GetString(2).ToString())
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
            End While

            'Return result
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Function

    '' Function untuk update data film di database
    Public Function UpdateDataFilmByIDDatabase(id_film As Integer,
                                               film As String,
                                               rating_usia As String,
                                               genre As String,
                                               deskripsi_film As String,
                                               director As String,
                                               duration As String,
                                               date_release As String,
                                               bahasa As String,
                                               harga_film As Integer,
                                               foto As String)

        date_release = date_release.ToString()

        Try
            DBConnection()

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE film SET nama_film='" & film & "', " &
                       "rating_usia='" & rating_usia & "', " &
                       "foto='" & foto & "', " &
                       "genre='" & genre & "', " &
                       "deskripsi='" & deskripsi_film & "', " &
                       "director='" & director & "', " &
                       "duration='" & duration & "', " &
                       "date_release='" & date_release & "', " &
                       "bahasa='" & bahasa & "', " &
                       "harga_film='" & harga_film & "' " &
                       "WHERE id='" & id_film & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Data Updated")
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try

    End Function

    '' Function untuk delete data film di database
    Public Function DeleteDataFilmByIDDatabase(id_film As Integer)

        DBConnection()

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM film " &
                       "WHERE id='" & id_film & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Data Deleted")
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function GetDataFilmDatabaseList() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id AS 'ID',
                                      nama_film AS 'Film',
                                      genre AS 'Genre',
                                      director AS 'Director',
                                      duration AS 'Duration',
                                      date_release AS 'Date Release',
                                      bahasa AS 'Bahasa',
                                      harga_film AS 'Harga'
                                      From film"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString() & " | " & sqlRead.GetString(1).ToString())
            End While
            'Return result

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckJudulFilm(judulFilm As String) As List(Of String)
        Dim result As New List(Of String)

        Try
            DBConnection()

            dbConn.Open()

            sqlCommand.Connection = dbConn
            validateJudulFilm = "SELECT nama_film FROM film WHERE nama_film='" & judulFilm & "'"

            sqlCommand.CommandText = validateJudulFilm
            Debug.WriteLine(validateJudulFilm)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
            End While

            'Return result
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Function

End Class
