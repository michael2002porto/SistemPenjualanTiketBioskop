Public Class EditStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNamaStudioValue.Text = Studio.data_studio.GSNama
        CbxKapasitasStudio.SelectedItem() = Studio.data_studio.GSKapasitas
        CbxHargaKursi.SelectedItem() = Studio.data_studio.GSHarga
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Studio.data_studio.GSNama = TxtNamaStudioValue.Text.ToString()
        Studio.data_studio.GSKapasitas = CbxKapasitasStudio.SelectedItem()
        Studio.data_studio.GSHarga = CbxHargaKursi.SelectedItem()

        Studio.data_studio.AddStudio(TxtNamaStudioValue.Text.ToString())
        Studio.data_studio.UpdateDataStudioByIDDatabase(Studio.SelectedTableStudio,
                                                                Studio.data_studio.GSNama,
                                                                Studio.data_studio.GSKapasitas,
                                                                Studio.data_studio.GSHarga)
        Me.Close()
    End Sub
End Class