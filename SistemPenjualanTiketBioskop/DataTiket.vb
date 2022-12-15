Imports System.Numerics
Imports MySql.Data.MySqlClient

Public Class DataTiket
    Private total_harga
    Private id_jadwal_tayang As Integer
    Private harga_kursi As BigInteger
    Private harga_film As BigInteger

    'Database Global Variable
    Private tiketDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    Public Function HitungTotalHarga()
        Return harga_film + harga_kursi
    End Function

    Public Function AddTiketDataTable(id_jadwal_tayang As Integer,
                                      total_harga As String)
        tiketDataTable.Add({id_jadwal_tayang,
                           total_harga})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        tiketDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getTiketDataTable() As ArrayList
        Get
            Return tiketDataTable
        End Get
    End Property

    Public Function GetDataTiketDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                  + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jadwal_tayang AS 'ID Jadwal Tayang',
                                  total_harga AS 'Total Harga'
                                  FROM tiket"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataTiketDatabase(id_jadwal_tayang As Integer,
                                           total_harga As BigInteger)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                  + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO TIKET(id_jadwal_tayang, total_harga) VALUE('" _
                        & id_jadwal_tayang & "', '" _
                        & total_harga.ToString() & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataTiketByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                  + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id,
                                  id_jadwal_tayang,
                                  total_harga
                                  FROM tiket
                                  WHERE id = '" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function DeleteDataTiketByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                  + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM tiket " &
                       "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
