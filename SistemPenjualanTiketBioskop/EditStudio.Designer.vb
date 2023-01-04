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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxHargaKursi = New System.Windows.Forms.ComboBox()
        Me.LblHargaKursi = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CbxKapasitasStudio = New System.Windows.Forms.ComboBox()
        Me.TxtNamaStudioValue = New System.Windows.Forms.TextBox()
        Me.LblKapasitas = New System.Windows.Forms.Label()
        Me.LblNamaStudio = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 68)
        Me.Panel1.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(378, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Edit Studio"
        '
        'CbxHargaKursi
        '
        Me.CbxHargaKursi.FormattingEnabled = True
        Me.CbxHargaKursi.Items.AddRange(New Object() {"30000", "50000", "75000", "100000"})
        Me.CbxHargaKursi.Location = New System.Drawing.Point(362, 210)
        Me.CbxHargaKursi.Name = "CbxHargaKursi"
        Me.CbxHargaKursi.Size = New System.Drawing.Size(506, 33)
        Me.CbxHargaKursi.TabIndex = 63
        '
        'LblHargaKursi
        '
        Me.LblHargaKursi.AutoSize = True
        Me.LblHargaKursi.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblHargaKursi.Location = New System.Drawing.Point(146, 210)
        Me.LblHargaKursi.Name = "LblHargaKursi"
        Me.LblHargaKursi.Size = New System.Drawing.Size(178, 25)
        Me.LblHargaKursi.TabIndex = 62
        Me.LblHargaKursi.Text = "Harga Kursi         :"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Teal
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(425, 275)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(148, 34)
        Me.BtnSave.TabIndex = 61
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'CbxKapasitasStudio
        '
        Me.CbxKapasitasStudio.FormattingEnabled = True
        Me.CbxKapasitasStudio.Items.AddRange(New Object() {"136", "146", "200", "259"})
        Me.CbxKapasitasStudio.Location = New System.Drawing.Point(362, 160)
        Me.CbxKapasitasStudio.Name = "CbxKapasitasStudio"
        Me.CbxKapasitasStudio.Size = New System.Drawing.Size(506, 33)
        Me.CbxKapasitasStudio.TabIndex = 60
        '
        'TxtNamaStudioValue
        '
        Me.TxtNamaStudioValue.Location = New System.Drawing.Point(362, 110)
        Me.TxtNamaStudioValue.Name = "TxtNamaStudioValue"
        Me.TxtNamaStudioValue.Size = New System.Drawing.Size(506, 31)
        Me.TxtNamaStudioValue.TabIndex = 59
        '
        'LblKapasitas
        '
        Me.LblKapasitas.AutoSize = True
        Me.LblKapasitas.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKapasitas.Location = New System.Drawing.Point(146, 160)
        Me.LblKapasitas.Name = "LblKapasitas"
        Me.LblKapasitas.Size = New System.Drawing.Size(179, 25)
        Me.LblKapasitas.TabIndex = 58
        Me.LblKapasitas.Text = "Kapasitas Studio  :"
        '
        'LblNamaStudio
        '
        Me.LblNamaStudio.AutoSize = True
        Me.LblNamaStudio.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaStudio.Location = New System.Drawing.Point(146, 110)
        Me.LblNamaStudio.Name = "LblNamaStudio"
        Me.LblNamaStudio.Size = New System.Drawing.Size(181, 25)
        Me.LblNamaStudio.TabIndex = 57
        Me.LblNamaStudio.Text = "Nama Studio        :"
        '
        'EditStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 332)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbxHargaKursi)
        Me.Controls.Add(Me.LblHargaKursi)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CbxKapasitasStudio)
        Me.Controls.Add(Me.TxtNamaStudioValue)
        Me.Controls.Add(Me.LblKapasitas)
        Me.Controls.Add(Me.LblNamaStudio)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditStudio"
        Me.Text = "Edit Studio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxHargaKursi As ComboBox
    Friend WithEvents LblHargaKursi As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents CbxKapasitasStudio As ComboBox
    Friend WithEvents TxtNamaStudioValue As TextBox
    Friend WithEvents LblKapasitas As Label
    Friend WithEvents LblNamaStudio As Label
End Class
