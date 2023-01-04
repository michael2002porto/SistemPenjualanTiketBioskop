<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJadwalTayang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLihatDetailStudio = New System.Windows.Forms.Button()
        Me.BtnLihatDetailFilm = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ComboBoxStudio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFilm = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerWaktuSelesai = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerWaktuMulai = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 68)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Edit Jadwal Tayang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLihatDetailStudio
        '
        Me.BtnLihatDetailStudio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLihatDetailStudio.BackColor = System.Drawing.Color.Teal
        Me.BtnLihatDetailStudio.FlatAppearance.BorderSize = 0
        Me.BtnLihatDetailStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLihatDetailStudio.Font = New System.Drawing.Font("Times New Roman", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLihatDetailStudio.ForeColor = System.Drawing.Color.White
        Me.BtnLihatDetailStudio.Location = New System.Drawing.Point(796, 224)
        Me.BtnLihatDetailStudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLihatDetailStudio.Name = "BtnLihatDetailStudio"
        Me.BtnLihatDetailStudio.Size = New System.Drawing.Size(163, 40)
        Me.BtnLihatDetailStudio.TabIndex = 84
        Me.BtnLihatDetailStudio.Text = "Lihat Detail"
        Me.BtnLihatDetailStudio.UseVisualStyleBackColor = False
        '
        'BtnLihatDetailFilm
        '
        Me.BtnLihatDetailFilm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLihatDetailFilm.BackColor = System.Drawing.Color.Teal
        Me.BtnLihatDetailFilm.FlatAppearance.BorderSize = 0
        Me.BtnLihatDetailFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLihatDetailFilm.Font = New System.Drawing.Font("Times New Roman", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLihatDetailFilm.ForeColor = System.Drawing.Color.White
        Me.BtnLihatDetailFilm.Location = New System.Drawing.Point(796, 124)
        Me.BtnLihatDetailFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLihatDetailFilm.Name = "BtnLihatDetailFilm"
        Me.BtnLihatDetailFilm.Size = New System.Drawing.Size(163, 40)
        Me.BtnLihatDetailFilm.TabIndex = 83
        Me.BtnLihatDetailFilm.Text = "Lihat Detail"
        Me.BtnLihatDetailFilm.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(302, 651)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(389, 64)
        Me.ButtonEdit.TabIndex = 82
        Me.ButtonEdit.Text = "Edit Jadwal Tayang"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ComboBoxStudio
        '
        Me.ComboBoxStudio.FormattingEnabled = True
        Me.ComboBoxStudio.Location = New System.Drawing.Point(302, 224)
        Me.ComboBoxStudio.Name = "ComboBoxStudio"
        Me.ComboBoxStudio.Size = New System.Drawing.Size(477, 40)
        Me.ComboBoxStudio.TabIndex = 81
        '
        'ComboBoxFilm
        '
        Me.ComboBoxFilm.FormattingEnabled = True
        Me.ComboBoxFilm.Location = New System.Drawing.Point(302, 124)
        Me.ComboBoxFilm.Name = "ComboBoxFilm"
        Me.ComboBoxFilm.Size = New System.Drawing.Size(477, 40)
        Me.ComboBoxFilm.TabIndex = 80
        '
        'DateTimePickerWaktuSelesai
        '
        Me.DateTimePickerWaktuSelesai.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerWaktuSelesai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerWaktuSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerWaktuSelesai.Location = New System.Drawing.Point(302, 519)
        Me.DateTimePickerWaktuSelesai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerWaktuSelesai.Name = "DateTimePickerWaktuSelesai"
        Me.DateTimePickerWaktuSelesai.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerWaktuSelesai.TabIndex = 79
        '
        'DateTimePickerWaktuMulai
        '
        Me.DateTimePickerWaktuMulai.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerWaktuMulai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerWaktuMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerWaktuMulai.Location = New System.Drawing.Point(302, 419)
        Me.DateTimePickerWaktuMulai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerWaktuMulai.Name = "DateTimePickerWaktuMulai"
        Me.DateTimePickerWaktuMulai.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerWaktuMulai.TabIndex = 78
        '
        'DateTimePickerTanggal
        '
        Me.DateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTanggal.Location = New System.Drawing.Point(302, 319)
        Me.DateTimePickerTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerTanggal.Name = "DateTimePickerTanggal"
        Me.DateTimePickerTanggal.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerTanggal.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(37, 527)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 34)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Waktu Selesai"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(37, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 34)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Waktu Mulai"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 34)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Tanggal Tayang"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 34)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Pilih Studio"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 34)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Pilih Film"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 68)
        Me.Panel1.TabIndex = 71
        '
        'EditJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 733)
        Me.Controls.Add(Me.BtnLihatDetailStudio)
        Me.Controls.Add(Me.BtnLihatDetailFilm)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ComboBoxStudio)
        Me.Controls.Add(Me.ComboBoxFilm)
        Me.Controls.Add(Me.DateTimePickerWaktuSelesai)
        Me.Controls.Add(Me.DateTimePickerWaktuMulai)
        Me.Controls.Add(Me.DateTimePickerTanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditJadwalTayang"
        Me.Text = "Edit Jadwal Tayang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLihatDetailStudio As Button
    Friend WithEvents BtnLihatDetailFilm As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ComboBoxStudio As ComboBox
    Friend WithEvents ComboBoxFilm As ComboBox
    Friend WithEvents DateTimePickerWaktuSelesai As DateTimePicker
    Friend WithEvents DateTimePickerWaktuMulai As DateTimePicker
    Friend WithEvents DateTimePickerTanggal As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
