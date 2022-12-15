Imports System.IO

Public Class Film

    Public Shared dataFilm As DataFilm

    Public Shared selectedTableKoleksi As Integer
    Public Shared selectedTableKoleksiFilm As String
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
    End Sub

    Private Sub ReloadDataTableDatabaseFilm()
        DGFilm.DataSource = dataFilm.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
        Dim tambahFilm = New TambahFilm()
        tambahFilm.Show()
    End Sub

    Private Sub BtnUpdateFilm_Click(sender As Object, e As EventArgs) Handles BtnUpdateFilm.Click
        Dim updateFilm = New EditFilm()
        updateFilm.Show()
    End Sub

    Private Sub BtnRemoveFilm_Click(sender As Object, e As EventArgs) Handles BtnRemoveFilm.Click
        Dim removeFilm = New HapusFilm()
        removeFilm.Show()
    End Sub

    Private Sub DGFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFilm.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        Try
            selectedRow = DGFilm.Rows(index)
            'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiFilm = selectedRow.Cells(1).Value
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            MessageBox.Show("Please select data")
        End Try
    End Sub
End Class