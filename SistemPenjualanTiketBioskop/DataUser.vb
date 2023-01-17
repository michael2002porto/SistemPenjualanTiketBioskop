Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class DataUser
    Private username As String
    Private email As String

    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private queryAuth As String
    Private validateUsername As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "bioskop"

    Public Property GSUsername() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property GSEmail() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Function EncryptData(ByVal plaintext As String) As String
        ' Convert the plaintext string to a byte array
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream
        Dim ms As New System.IO.MemoryStream

        ' Create the encoder to write to the stream
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function DBConnection()
        dbConn.ConnectionString = "server =" + server + ";" _
                                   + "user id=" + username_db + ";" _
                                   + "password=" + password_db + ";" _
                                   + "database =" + database
    End Function

    '' Function Sign Up
    Public Function AddUsersDatabase(email_regist As String, username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            DBConnection()

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USER( email, username, password, registered_at) VALUE ('" _
                        & email_regist & "', '" _
                        & username_regist & "', '" _
                        & EncryptMD5(password_regist) & "', '" _
                        & today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    '' Function Sign In
    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            DBConnection()

            dbConn.Open()

            sqlCommand.Connection = dbConn
            queryAuth = "SELECT id, username FROM user WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read()
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckUsername(username As String) As List(Of String)
        Dim result As New List(Of String)

        Try
            DBConnection()

            dbConn.Open()

            sqlCommand.Connection = dbConn
            validateUsername = "SELECT username FROM user WHERE username='" & username & "'"

            sqlCommand.CommandText = validateUsername
            Debug.WriteLine(validateUsername)
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