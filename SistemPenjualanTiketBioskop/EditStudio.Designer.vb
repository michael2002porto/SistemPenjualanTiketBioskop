<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStudio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CbxHargaKursi = New System.Windows.Forms.ComboBox()
        Me.LblHargaKursi = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CbxKapasitasStudio = New System.Windows.Forms.ComboBox()
        Me.TxtNamaStudioValue = New System.Windows.Forms.TextBox()
        Me.LblKapasitas = New System.Windows.Forms.Label()
        Me.LblNamaStudio = New System.Windows.Forms.Label()
        Me.LblJudulCreate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CbxHargaKursi
        '
        Me.CbxHargaKursi.FormattingEnabled = True
        Me.CbxHargaKursi.Items.AddRange(New Object() {"30000", "50000", "75000", "100000"})
        Me.CbxHargaKursi.Location = New System.Drawing.Point(230, 180)
        Me.CbxHargaKursi.Name = "CbxHargaKursi"
        Me.CbxHargaKursi.Size = New System.Drawing.Size(375, 33)
        Me.CbxHargaKursi.TabIndex = 25
        '
        'LblHargaKursi
        '
        Me.LblHargaKursi.AutoSize = True
        Me.LblHargaKursi.Location = New System.Drawing.Point(70, 180)
        Me.LblHargaKursi.Name = "LblHargaKursi"
        Me.LblHargaKursi.Size = New System.Drawing.Size(152, 25)
        Me.LblHargaKursi.TabIndex = 24
        Me.LblHargaKursi.Text = "Harga Kursi         :"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(492, 230)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(113, 34)
        Me.BtnSave.TabIndex = 23
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CbxKapasitasStudio
        '
        Me.CbxKapasitasStudio.FormattingEnabled = True
        Me.CbxKapasitasStudio.Items.AddRange(New Object() {"136", "146", "200", "259"})
        Me.CbxKapasitasStudio.Location = New System.Drawing.Point(230, 130)
        Me.CbxKapasitasStudio.Name = "CbxKapasitasStudio"
        Me.CbxKapasitasStudio.Size = New System.Drawing.Size(375, 33)
        Me.CbxKapasitasStudio.TabIndex = 22
        '
        'TxtNamaStudioValue
        '
        Me.TxtNamaStudioValue.Location = New System.Drawing.Point(230, 80)
        Me.TxtNamaStudioValue.Name = "TxtNamaStudioValue"
        Me.TxtNamaStudioValue.Size = New System.Drawing.Size(375, 31)
        Me.TxtNamaStudioValue.TabIndex = 21
        '
        'LblKapasitas
        '
        Me.LblKapasitas.AutoSize = True
        Me.LblKapasitas.Location = New System.Drawing.Point(70, 130)
        Me.LblKapasitas.Name = "LblKapasitas"
        Me.LblKapasitas.Size = New System.Drawing.Size(151, 25)
        Me.LblKapasitas.TabIndex = 20
        Me.LblKapasitas.Text = "Kapasitas Studio :"
        '
        'LblNamaStudio
        '
        Me.LblNamaStudio.AutoSize = True
        Me.LblNamaStudio.Location = New System.Drawing.Point(70, 80)
        Me.LblNamaStudio.Name = "LblNamaStudio"
        Me.LblNamaStudio.Size = New System.Drawing.Size(134, 25)
        Me.LblNamaStudio.TabIndex = 19
        Me.LblNamaStudio.Text = "Nama Studio   :"
        '
        'LblJudulCreate
        '
        Me.LblJudulCreate.AutoSize = True
        Me.LblJudulCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJudulCreate.Location = New System.Drawing.Point(30, 20)
        Me.LblJudulCreate.Name = "LblJudulCreate"
        Me.LblJudulCreate.Size = New System.Drawing.Size(243, 32)
        Me.LblJudulCreate.TabIndex = 18
        Me.LblJudulCreate.Text = "Tambah Data Studio"
        '
        'EditStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 275)
        Me.Controls.Add(Me.CbxHargaKursi)
        Me.Controls.Add(Me.LblHargaKursi)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CbxKapasitasStudio)
        Me.Controls.Add(Me.TxtNamaStudioValue)
        Me.Controls.Add(Me.LblKapasitas)
        Me.Controls.Add(Me.LblNamaStudio)
        Me.Controls.Add(Me.LblJudulCreate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditStudio"
        Me.Text = "Edit Studio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbxHargaKursi As ComboBox
    Friend WithEvents LblHargaKursi As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents CbxKapasitasStudio As ComboBox
    Friend WithEvents TxtNamaStudioValue As TextBox
    Friend WithEvents LblKapasitas As Label
    Friend WithEvents LblNamaStudio As Label
    Friend WithEvents LblJudulCreate As Label
End Class
