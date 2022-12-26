Public Class TambahStudio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Studio.data_studio.GSNama = TxtNamaStudioValue.Text
        Studio.data_studio.GSKapasitas = CbxKapasitasStudio.SelectedItem()
        Studio.data_studio.GSHarga = CbxHargaKursi.SelectedItem()


        Studio.data_studio.AddDataStudioDatabase(Studio.data_studio.GSNama,
                                                 Studio.data_studio.GSKapasitas,
                                                 Studio.data_studio.GSHarga)
        Me.Close()
    End Sub
    Private Sub TxtNamaStudio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaStudioValue.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Just insert string or number only")
        End If
    End Sub

End Class