Public Class SignIn
    Public Shared jadwalTayang As JadwalTayang
    Public Shared film As Film
    Public Shared users As DataUser

    Public Shared data_user As List(Of String)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jadwalTayang = New JadwalTayang()
        users = New DataUser()
    End Sub

    Private Sub SignIn_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim signUp = New SignUp()
        signUp.Show()
        Me.Hide()
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If CheckPassword.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Try
            Dim plainUsername As String = TxtUsername.Text
            Dim plainPassword As String = TxtPassword.Text

            data_user = users.CheckAuthDatabase(plainUsername, plainPassword)

            If data_user.Count > 0 Then
                users.GSUsername = data_user(1)
                Dim jadwalTayang = New JadwalTayang()
                jadwalTayang.Show()
                Me.Hide()

            ElseIf plainUsername = "" Or plainPassword = "" Then
                MessageBox.Show("Lengkapi Data")

            Else
                'MessageBox.Show("Salah Password")
                MessageBox.Show("Username or Password incorrect")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class