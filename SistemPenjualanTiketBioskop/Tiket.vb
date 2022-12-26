Public Class Tiket
    Public Shared selectedTableTiket As Integer
    Public Shared data_tiket As DataTiket

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_tiket = New DataTiket
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridTiket_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridTiket.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridTiket.Rows(index)

        selectedTableTiket = selectedrow.Cells(0).Value
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridTiket.DataSource = data_tiket.GetDataTiketDatabase()
    End Sub

    Private Sub Tiket_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnJadwalTayang_Click(sender As Object, e As EventArgs) Handles BtnJadwalTayang.Click
        Dim jadwalTayang = New JadwalTayang()
        jadwalTayang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnFilm_Click(sender As Object, e As EventArgs) Handles BtnFilm.Click
        Dim film = New Film()
        film.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTiket_Click(sender As Object, e As EventArgs) Handles BtnTiket.Click
        Dim tiket = New Tiket()
        tiket.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim tambah_tiket = New TambahTiket()
        tambah_tiket.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim formHapus = New HapusTiket()
        formHapus.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnStudio_Click(sender As Object, e As EventArgs) Handles BtnStudio.Click
        Dim studio = New Studio()
        studio.Show()
        Me.Close()
    End Sub
End Class