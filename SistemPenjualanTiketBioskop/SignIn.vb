Public Class SignIn
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim masuk = New JadwalTayang()
        masuk.Show()
        Me.Hide()
    End Sub
End Class
