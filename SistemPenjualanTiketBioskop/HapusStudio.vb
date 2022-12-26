
Public Class HapusStudio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelKonfirmasi.Text = Studio.SelectedTableNamaStudio
    End Sub
    Private Sub BtnHapusDataStudio_Click(sender As Object, e As EventArgs) Handles BtnHapusDataStudio.Click
        Studio.data_studio.DeleteDataStudioByIDDatabase(Studio.SelectedTableStudio)
        Me.Close()
    End Sub
End Class