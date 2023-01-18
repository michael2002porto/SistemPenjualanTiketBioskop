Imports System.Net.Mail
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class SignUp
    Public Shared jadwalTayang As JadwalTayang
    Public Shared data_user As List(Of String)

    Dim max_char_username = 30
    Dim min_char_username = 6
    Dim max_char_password = 100
    Dim min_char_password = 8

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jadwalTayang = New JadwalTayang()
    End Sub

    Private Sub SignUp_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblEmail.Visible = False
        LblCheckUsername.Visible = False
        LblRePassword.Visible = False
        TxtPassword.UseSystemPasswordChar = True
        TxtRePassword.UseSystemPasswordChar = True
    End Sub

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles TxtEmail.Leave
        Try
            Dim testEmail = New MailAddress(TxtEmail.Text)
            LblEmail.Visible = False
        Catch ex As Exception
            LblEmail.Visible = True
        End Try
    End Sub

    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        LblCheckUsername.Visible = False

        Dim username As String = TxtUsername.Text
        data_user = SignIn.users.CheckUsername(username)

        ' Validasi username, jika username sudah ada sebelumnya atau terdaftar
        If data_user.Count > 0 Then
            SignIn.users.GSUsername = data_user(0)
            LblCheckUsername.Visible = True
        End If
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String or Number or Combine String and Number Only")
        End If

        If TxtUsername.Text.Length >= max_char_username Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If TxtPassword.Text.Length >= max_char_password Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If CheckPassword.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
            TxtRePassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
            TxtRePassword.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub TxtRePassword_Leave(sender As Object, e As EventArgs) Handles TxtRePassword.Leave
        If TxtPassword.Text = TxtRePassword.Text Then
            LblRePassword.Visible = False
        Else
            LblRePassword.Visible = True
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim form_SignIn = New SignIn()
        form_SignIn.Show()
        Me.Close()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim username As String = TxtUsername.Text
        data_user = SignIn.users.CheckUsername(username)

        If data_user.Count > 0 Then
            SignIn.users.GSUsername = data_user(0)
            MessageBox.Show("username sudah terdaftar")

        Else
            If TxtUsername.Text.Length >= min_char_username And TxtUsername.Text.Length <= max_char_username And TxtPassword.Text.Length >= min_char_password And TxtPassword.Text.Length <= max_char_password Then
                If TxtPassword.Text = TxtRePassword.Text Then
                    SignIn.users.AddUsersDatabase(TxtEmail.Text, TxtUsername.Text, TxtPassword.Text)
                    SignIn.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Password doesn't match")
                End If

            Else
                MessageBox.Show("Please enter a username with a minimum length of 6 characters, a maximum of 30 characters. Password with a minimum length of 8 characters, a maximum of 100 characters.")
            End If
        End If

    End Sub

End Class