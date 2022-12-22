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
    End Sub

    Private Sub DataGridStudio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStudio.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridStudio.Rows(index)

        SelectedTableStudio = selectedRow.Cells(0).Value
        SelectedTableNamaStudio = selectedRow.Cells(1).Value
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
        Dim SelectedStudio As List(Of String) = data_studio.GetDataStudioByIDDatabase(SelectedTableStudio)

        data_studio.GSNama = SelectedStudio(1)
        data_studio.GSKapasitas = SelectedStudio(2)
        data_studio.GSHarga = SelectedStudio(3)

        Dim formUpdate = New EditStudio()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formhapus = New HapusStudio()
        formhapus.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtambah = New TambahStudio()
        formtambah.Show()
    End Sub
End Class