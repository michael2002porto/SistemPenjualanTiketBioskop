Imports Org.BouncyCastle.Asn1.Ocsp

Public Class Studio
    Public Shared data_studio As DataStudio
    Public Shared SelectedTableStudio As Integer
    Public Shared SelectedTableNamaStudio As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_studio = New DataStudio()
        ReloadDataStudioDatabase()
    End Sub

    Private Sub ReloadDataStudioDatabase()
        DataGridStudio.DataSource = data_studio.GetDataStudioDatabase()
    End Sub

    Private Sub studio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataStudioDatabase()
        LblUsername.Text = SignIn.data_user(1).ToString()

    End Sub

    Private Sub DataGridStudio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStudio.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        Try
            selectedRow = DataGridStudio.Rows(index)
            SelectedTableStudio = selectedRow.Cells(0).Value
            SelectedTableNamaStudio = selectedRow.Cells(1).Value
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try
    End Sub

    'Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
    '    Dim SelectedStudio As List(Of String) = data_studio.GetDataStudioByIDDatabase(SelectedTableStudio)

    '    data_studio.GSNama = SelectedStudio(1)
    '    data_studio.GSKapasitas = SelectedStudio(3)
    '    data_studio.GSHarga = SelectedStudio(4)

    '    'Dim formInfo = New info_tambah_koleksi()
    '    'formInfo.Show()
    'End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click


        Try
            Dim selectedStudio As List(Of String) = data_studio.GetDataStudioByIDDatabase(SelectedTableStudio)
            data_studio.GSNama = selectedStudio(1)
            data_studio.GSKapasitas = selectedStudio(2)
            data_studio.GSHarga = selectedStudio(3)

            Dim formUpdate = New EditStudio()
            formUpdate.Show()

        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formhapus = New HapusStudio()
        formhapus.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtambah = New TambahStudio()
        formtambah.Show()
    End Sub


    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim signIn = New SignIn()
        signIn.Show()
        Me.Close()
    End Sub
    Private Sub ReloadDataTableDatabase(Optional search As String = "")
        'DataGridViewJadwalTayang.DataSource = data_jadwal_tayang.GetDataJadwalTayangDatabase()
        'DataGridStudio.Rows.Clear()
        'DataGridStudio.RowTemplate.Height = 100

        'Dim source
        'If search.Length > 0 Then
        '    source = data_studio.GetDataStudioDatabaseList(
        '        "WHERE s.nama_studio LIKE '%" + search + "%'
        '        OR s.kapasitas LIKE '%" + search + "%'
        '        OR s.harga_kursi LIKE '%" + search + "%'"
        '    )
        'Else
        '    source = data_studio.GetDataStudioDatabaseList()
        'End If

        'For Each rowJadwalTayang In source
        '    Dim dataTable = {
        '        rowJadwalTayang(0), 'Id Studio
        '        rowJadwalTayang(1), 'Nama Studio
        '        rowJadwalTayang(2), 'Jenis Studio
        '        rowJadwalTayang(3), 'Kapasitas Studio
        '        rowJadwalTayang(4) 'Harga Kursi
        '    }
        '    DataGridStudio.Rows.Add(dataTable)
        'Next

        'SelectedTableStudio = Nothing
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        'ReloadDataTableDatabase(TextBoxSearch.Text)
    End Sub
End Class