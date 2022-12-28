Public Class HapusTiket
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblIDTiket.Text = Tiket.selectedTableTiket
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Tiket.data_tiket.DeleteDataTiketByIDDatabase(Tiket.selectedTableTiket)

        Dim ticket = New Tiket()
        ticket.Show()
        Me.Close()
    End Sub
End Class