<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahStudio
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtHargaKursiValue = New System.Windows.Forms.TextBox()
        Me.CbxJenisStudio = New System.Windows.Forms.ComboBox()
        Me.TxtNamaStudioValue = New System.Windows.Forms.TextBox()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.LblNamaStudio = New System.Windows.Forms.Label()
        Me.LblJudulCreate = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(482, 250)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(113, 34)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtHargaKursiValue
        '
        Me.TxtHargaKursiValue.Location = New System.Drawing.Point(220, 200)
        Me.TxtHargaKursiValue.Name = "TxtHargaKursiValue"
        Me.TxtHargaKursiValue.Size = New System.Drawing.Size(375, 31)
        Me.TxtHargaKursiValue.TabIndex = 14
        '
        'CbxJenisStudio
        '
        Me.CbxJenisStudio.FormattingEnabled = True
        Me.CbxJenisStudio.Items.AddRange(New Object() {"Deluxe", "Dolby Atmos", "IMAX", "The Premiere"})
        Me.CbxJenisStudio.Location = New System.Drawing.Point(220, 160)
        Me.CbxJenisStudio.Name = "CbxJenisStudio"
        Me.CbxJenisStudio.Size = New System.Drawing.Size(375, 33)
        Me.CbxJenisStudio.TabIndex = 13
        '
        'TxtNamaStudioValue
        '
        Me.TxtNamaStudioValue.Location = New System.Drawing.Point(220, 80)
        Me.TxtNamaStudioValue.Name = "TxtNamaStudioValue"
        Me.TxtNamaStudioValue.Size = New System.Drawing.Size(375, 31)
        Me.TxtNamaStudioValue.TabIndex = 12
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.Location = New System.Drawing.Point(70, 200)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(132, 25)
        Me.LblHarga.TabIndex = 11
        Me.LblHarga.Text = "Harga Kursi     :"
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Location = New System.Drawing.Point(70, 160)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(134, 25)
        Me.LblJenis.TabIndex = 10
        Me.LblJenis.Text = "Jenis Studio     :"
        '
        'LblNamaStudio
        '
        Me.LblNamaStudio.AutoSize = True
        Me.LblNamaStudio.Location = New System.Drawing.Point(70, 80)
        Me.LblNamaStudio.Name = "LblNamaStudio"
        Me.LblNamaStudio.Size = New System.Drawing.Size(134, 25)
        Me.LblNamaStudio.TabIndex = 9
        Me.LblNamaStudio.Text = "Nama Studio   :"
        '
        'LblJudulCreate
        '
        Me.LblJudulCreate.AutoSize = True
        Me.LblJudulCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJudulCreate.Location = New System.Drawing.Point(30, 20)
        Me.LblJudulCreate.Name = "LblJudulCreate"
        Me.LblJudulCreate.Size = New System.Drawing.Size(243, 32)
        Me.LblJudulCreate.TabIndex = 8
        Me.LblJudulCreate.Text = "Tambah Data Studio"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(220, 120)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(375, 31)
        Me.TxtId.TabIndex = 19
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(70, 120)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(134, 25)
        Me.LblId.TabIndex = 18
        Me.LblId.Text = "ID                    :"
        '
        'TambahStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 303)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtHargaKursiValue)
        Me.Controls.Add(Me.CbxJenisStudio)
        Me.Controls.Add(Me.TxtNamaStudioValue)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.LblNamaStudio)
        Me.Controls.Add(Me.LblJudulCreate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TambahStudio"
        Me.Text = "Tambah Studio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtHargaKursiValue As TextBox
    Friend WithEvents CbxJenisStudio As ComboBox
    Friend WithEvents TxtNamaStudioValue As TextBox
    Friend WithEvents LblHarga As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents LblNamaStudio As Label
    Friend WithEvents LblJudulCreate As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblId As Label
End Class
