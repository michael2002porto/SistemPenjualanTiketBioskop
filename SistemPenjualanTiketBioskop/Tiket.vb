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

    Private Sub ToolStripBtnAdd_Click(sender As Object, e As EventArgs) Handles ToolStripBtnAdd.Click
        Dim tambah_tiket = New TambahTiket()
        tambah_tiket.Show()
    End Sub

    Private Sub ToolStripBtnDel_Click(sender As Object, e As EventArgs) Handles ToolStripBtnDel.Click
        Dim formHapus = New HapusTiket()
        formHapus.Show()
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
End Class