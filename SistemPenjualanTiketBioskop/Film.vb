﻿Imports System.IO

Public Class Film

    Public Shared dataFilm As DataFilm

    Public Shared selectedTableFilm As Integer
    Public Shared selectedTableNamaFilm As String
    Private selectedRow As DataGridViewRow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataFilm = New DataFilm()

        ReloadDataTableDatabaseFilm()
    End Sub

    Private Sub Film_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabaseFilm()
        'LblUsername.Text = SignIn.data_user(1).toString()
        'Lblid.Text = SignIn.data_user(0).toString()
    End Sub

    Private Sub ReloadDataTableDatabaseFilm()
        DGFilm.DataSource = dataFilm.GetDataFilmDatabase()
    End Sub

    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
        Dim tambahFilm = New TambahFilm()
        tambahFilm.Show()
    End Sub

    Private Sub BtnUpdateFilm_Click(sender As Object, e As EventArgs) Handles BtnUpdateFilm.Click
        Try
            Dim selectedFilm As List(Of String) = dataFilm.GetDataFilmByIDDatabase(selectedTableFilm)

            dataFilm.GSFoto = selectedFilm(9)

            dataFilm.GSNamaFilm = selectedFilm(1)
            dataFilm.GSDeskripsi = selectedFilm(3)
            dataFilm.GSDirector = selectedFilm(4)
            dataFilm.GSDateRelease = selectedFilm(6)
            dataFilm.GSDuration = selectedFilm(5)
            dataFilm.GSHargaFilm = selectedFilm(8)
            dataFilm.GSBahasa = selectedFilm(7)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedFilm(2))
            Dim updateFilm = New EditFilm()
            updateFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub BtnRemoveFilm_Click(sender As Object, e As EventArgs) Handles BtnRemoveFilm.Click
        Try
            Dim selectedFilm As List(Of String) = dataFilm.GetDataFilmByIDDatabase(selectedTableFilm)

            dataFilm.GSFoto = selectedFilm(9)

            dataFilm.GSNamaFilm = selectedFilm(1)
            dataFilm.GSDeskripsi = selectedFilm(3)
            dataFilm.GSDirector = selectedFilm(4)
            dataFilm.GSDateRelease = selectedFilm(6)
            dataFilm.GSDuration = selectedFilm(5)
            dataFilm.GSHargaFilm = selectedFilm(8)
            dataFilm.GSBahasa = selectedFilm(7)
            dataFilm.GSGenre = dataFilm.ConvertStringToGenre(selectedFilm(2))

            Dim removeFilm = New HapusFilm()
            removeFilm.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub DGFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFilm.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        Try
            selectedRow = DGFilm.Rows(index)
            selectedTableFilm = selectedRow.Cells(0).Value
            selectedTableNamaFilm = selectedRow.Cells(1).Value
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Dim signIn = New SignIn()
        signIn.Show()
        Me.Close()
    End Sub

    Private Sub BtnFilm_Click(sender As Object, e As EventArgs) Handles BtnFilm.Click
        Dim film = New Film()
        film.Show()
        Me.Close()
    End Sub

    Private Sub BtnStudio_Click(sender As Object, e As EventArgs) Handles BtnStudio.Click
        Dim studio = New Studio()
        studio.Show()
        Me.Close()
    End Sub

    Private Sub BtnJadwalTayang_Click(sender As Object, e As EventArgs) Handles BtnJadwalTayang.Click
        Dim jadwalTayang = New JadwalTayang()
        jadwalTayang.Show()
        Me.Close()
    End Sub

    Private Sub BtnTiket_Click(sender As Object, e As EventArgs) Handles BtnTiket.Click
        Dim tiket = New Tiket()
        tiket.Show()
        Me.Close()
    End Sub

End Class