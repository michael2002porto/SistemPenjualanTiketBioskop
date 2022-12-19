﻿Public Class HapusFilm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblFilm.Text = Film.selectedTableNamaFilm
    End Sub

    Private Sub BtnHapusFilm_Click(sender As Object, e As EventArgs) Handles BtnHapusFilm.Click
        Try
            Film.dataFilm.DeleteDataFilmByIDDatabase(Film.selectedTableFilm)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Select Data")
        End Try
    End Sub
End Class