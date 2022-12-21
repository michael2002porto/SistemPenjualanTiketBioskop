Public Class TambahStudio
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Studio.data_studio.GSId =
        Studio.data_studio.GSNama = TxtNamaStudioValue.Text
        Studio.data_studio.GSJenis = CbxJenisStudio.SelectedItem()
        If CbxJenisStudio.SelectedItem = "Deluxe" Then
            Studio.data_studio.GSKapasitas = 259
            Studio.data_studio.GSHarga = 30000
        ElseIf CbxJenisStudio.SelectedItem = "Dolby Atmos" Then
            Studio.data_studio.GSKapasitas = 200
            Studio.data_studio.GSHarga = 50000
        ElseIf CbxJenisStudio.SelectedItem = "Dolby Atmos" Then
            Studio.data_studio.GSKapasitas = 146
            Studio.data_studio.GSHarga = 75000
        ElseIf CbxJenisStudio.SelectedItem = "Dolby Atmos" Then
            Studio.data_studio.GSKapasitas = 136
            Studio.data_studio.GSHarga = 100000
        End If

        Studio.data_studio.AddDataStudioDatabase(Studio.data_studio.GSId,
                                                 Studio.data_studio.GSNama,
                                                 Studio.data_studio.GSJenis,
                                                 Studio.data_studio.GSKapasitas,
                                                 Studio.data_studio.GSHarga)
        'Dim infoTambah = New Studio()
        'infoTambah.Show()
        Me.Close()
    End Sub
End Class