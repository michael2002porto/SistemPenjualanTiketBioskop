<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusStudio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnHapusDataStudio = New System.Windows.Forms.Button()
        Me.LabelKonfirmasi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapusDataStudio
        '
        Me.BtnHapusDataStudio.BackColor = System.Drawing.Color.Teal
        Me.BtnHapusDataStudio.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusDataStudio.ForeColor = System.Drawing.Color.White
        Me.BtnHapusDataStudio.Location = New System.Drawing.Point(242, 165)
        Me.BtnHapusDataStudio.Name = "BtnHapusDataStudio"
        Me.BtnHapusDataStudio.Size = New System.Drawing.Size(127, 43)
        Me.BtnHapusDataStudio.TabIndex = 3
        Me.BtnHapusDataStudio.Text = "Hapus"
        Me.BtnHapusDataStudio.UseVisualStyleBackColor = False
        '
        'LabelKonfirmasi
        '
        Me.LabelKonfirmasi.AutoSize = True
        Me.LabelKonfirmasi.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKonfirmasi.ForeColor = System.Drawing.Color.Black
        Me.LabelKonfirmasi.Location = New System.Drawing.Point(99, 39)
        Me.LabelKonfirmasi.Name = "LabelKonfirmasi"
        Me.LabelKonfirmasi.Size = New System.Drawing.Size(424, 25)
        Me.LabelKonfirmasi.TabIndex = 4
        Me.LabelKonfirmasi.Text = "Apakah anda ingin menghapus data studio?"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(591, 54)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Studio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HapusStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelKonfirmasi)
        Me.Controls.Add(Me.BtnHapusDataStudio)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HapusStudio"
        Me.Text = "Hapus Studio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnHapusDataStudio As Button
    Friend WithEvents LabelKonfirmasi As Label
    Friend WithEvents Label1 As Label
End Class
