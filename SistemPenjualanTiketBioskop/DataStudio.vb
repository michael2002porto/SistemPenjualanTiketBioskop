Imports System.Text
Imports MySql.Data.MySqlClient
Public Class DataStudio
    Private id_studio As Integer
    Private nama_studio As String
    Private jenis_studio As String
    Private kapasitas_studio As Integer
    Private harga_kursi As Integer
    Private list_studio As New List(Of String)
    Private ListStudioDataTable As New ArrayList()

    ' Database Global
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "bioskop"

    Public Property GSId() As Integer
        Get
            Return id_studio
        End Get
        Set(value As Integer)
            id_studio = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return nama_studio
        End Get
        Set(value As String)
            nama_studio = value
        End Set
    End Property

    Public Property GSJenis() As String
        Get
            Return jenis_studio
        End Get
        Set(value As String)
            jenis_studio = value
        End Set
    End Property

    Public Property GSKapasitas() As Integer
        Get
            Return kapasitas_studio
        End Get
        Set(value As Integer)
            kapasitas_studio = value
        End Set
    End Property

    Public Property GSHarga() As Integer
        Get
            Return harga_kursi
        End Get
        Set(value As Integer)
            harga_kursi = value
        End Set
    End Property

    'Public Property GSList_Studio() As List(Of String)
    '    Get
    '        Return list_studio
    '    End Get
    '    Set(value As List(Of String))
    '        list_studio = value
    '    End Set
    'End Property
    '' koleksi arraylist
    'Public Function AddStudio(value As String)
    '    GSList_Studio.Add(value)
    '    Return ""
    'End Function
    'Public ReadOnly Property getStudio() As List(Of String)
    '    Get
    '        Return GSList_Studio
    '    End Get
    'End Property

    ' koleksi database

    'Public Function AddListStudioDataTable(id_studio As Integer,
    '                                      nama_studio As String,
    '                                      jenis_studio As String,
    '                                      kapasitas_studio As Integer,
    '                                      harga_kursi As Integer)
    '    ListStudioDataTable.Add({id_studio, nama_studio, jenis_studio, kapasitas_studio, harga_kursi})
    'End Function

    'Public Function RemoveListStudioDatabase(index As Integer)
    '    ListStudioDataTable.RemoveAt(index)
    'End Function

    'Public ReadOnly Property GetListStudioDatabase() As ArrayList
    '    Get
    '        Return ListStudioDataTable
    '    End Get
    'End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to string.
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        ' Convert to list.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataStudioDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_studio AS 'ID', 
                                 nama_studio AS 'Nama Koleksi',
                                 jenis_studio AS 'Jenis Koleksi', 
                                 kapasitas AS 'Kapasitas Studio', 
                                 harga_kursi AS 'Harga Studio',  
                                 FROM studio "

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataStudioDatabase(id_studio As Integer,
                                          nama_studio As String,
                                          jenis_studio As String,
                                          kapasitas_studio As Integer,
                                          harga_kursi As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO STUDIO(id, nama_studio, jenis_studio, kapasitas, harga_kursi)
                        VALUE('" _
                                    & id_studio & "', '" _
                                    & nama_studio & "', '" _
                                    & jenis_studio & "', '" _
                                    & kapasitas_studio & "', '" _
                                    & harga_kursi & "')"
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

    Public Function UpdateDataStudioByIDDatabase(id_studio As Integer,
                                                nama_studio As String,
                                                jenis_studio As String,
                                                kapasitas_studio As Integer,
                                                harga_kursi As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE studio SET " &
                        "id='" & id_studio & "', " &
                        "nama_studio='" & nama_studio & "', " &
                        "jenis_studio='" & jenis_studio & "', " &
                        "kapasitas='" & kapasitas_studio & "', " &
                        "harga_kursi='" & harga_kursi & "'"

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

    Public Function GetDataStudioByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id, 
                                  nama_studio, 
                                  jenis_studio, 
                                  kapasitas, 
                                  harga_kursi
                                  FROM studio 
                                  WHERE id='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function DeleteDataStudioByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM studio " &
                        "WHERE id='" & ID & "'"
            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
