<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJadwalTayang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnLihatDetailStudio = New System.Windows.Forms.Button()
        Me.BtnLihatDetailFilm = New System.Windows.Forms.Button()
        Me.ComboBoxStudio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFilm = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerWaktuSelesai = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerWaktuMulai = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 109)
        Me.Panel1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1000, 49)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Hapus Jadwal Tayang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(0, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 42)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Apakah Anda ingin menghapus jadwal tayang berikut?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHapus.BackColor = System.Drawing.Color.Firebrick
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(247, 781)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(151, 59)
        Me.BtnHapus.TabIndex = 64
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(598, 781)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 59)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnLihatDetailStudio
        '
        Me.BtnLihatDetailStudio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLihatDetailStudio.BackColor = System.Drawing.Color.Teal
        Me.BtnLihatDetailStudio.FlatAppearance.BorderSize = 0
        Me.BtnLihatDetailStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLihatDetailStudio.Font = New System.Drawing.Font("Times New Roman", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLihatDetailStudio.ForeColor = System.Drawing.Color.White
        Me.BtnLihatDetailStudio.Location = New System.Drawing.Point(801, 360)
        Me.BtnLihatDetailStudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLihatDetailStudio.Name = "BtnLihatDetailStudio"
        Me.BtnLihatDetailStudio.Size = New System.Drawing.Size(163, 42)
        Me.BtnLihatDetailStudio.TabIndex = 82
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
        Me.BtnLihatDetailFilm.Location = New System.Drawing.Point(801, 260)
        Me.BtnLihatDetailFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLihatDetailFilm.Name = "BtnLihatDetailFilm"
        Me.BtnLihatDetailFilm.Size = New System.Drawing.Size(163, 42)
        Me.BtnLihatDetailFilm.TabIndex = 81
        Me.BtnLihatDetailFilm.Text = "Lihat Detail"
        Me.BtnLihatDetailFilm.UseVisualStyleBackColor = False
        '
        'ComboBoxStudio
        '
        Me.ComboBoxStudio.FormattingEnabled = True
        Me.ComboBoxStudio.Location = New System.Drawing.Point(307, 360)
        Me.ComboBoxStudio.Name = "ComboBoxStudio"
        Me.ComboBoxStudio.Size = New System.Drawing.Size(477, 40)
        Me.ComboBoxStudio.TabIndex = 80
        '
        'ComboBoxFilm
        '
        Me.ComboBoxFilm.FormattingEnabled = True
        Me.ComboBoxFilm.Location = New System.Drawing.Point(307, 260)
        Me.ComboBoxFilm.Name = "ComboBoxFilm"
        Me.ComboBoxFilm.Size = New System.Drawing.Size(477, 40)
        Me.ComboBoxFilm.TabIndex = 79
        '
        'DateTimePickerWaktuSelesai
        '
        Me.DateTimePickerWaktuSelesai.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerWaktuSelesai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerWaktuSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerWaktuSelesai.Location = New System.Drawing.Point(307, 655)
        Me.DateTimePickerWaktuSelesai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerWaktuSelesai.Name = "DateTimePickerWaktuSelesai"
        Me.DateTimePickerWaktuSelesai.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerWaktuSelesai.TabIndex = 78
        '
        'DateTimePickerWaktuMulai
        '
        Me.DateTimePickerWaktuMulai.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerWaktuMulai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerWaktuMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerWaktuMulai.Location = New System.Drawing.Point(307, 555)
        Me.DateTimePickerWaktuMulai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerWaktuMulai.Name = "DateTimePickerWaktuMulai"
        Me.DateTimePickerWaktuMulai.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerWaktuMulai.TabIndex = 77
        '
        'DateTimePickerTanggal
        '
        Me.DateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTanggal.Location = New System.Drawing.Point(307, 455)
        Me.DateTimePickerTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerTanggal.Name = "DateTimePickerTanggal"
        Me.DateTimePickerTanggal.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerTanggal.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(42, 663)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 34)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Waktu Selesai"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(42, 563)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 34)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Waktu Mulai"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(42, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 34)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Tanggal Tayang"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(42, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 34)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Studio"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(42, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 34)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Film"
        '
        'HapusJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 880)
        Me.Controls.Add(Me.BtnLihatDetailStudio)
        Me.Controls.Add(Me.BtnLihatDetailFilm)
        Me.Controls.Add(Me.ComboBoxStudio)
        Me.Controls.Add(Me.ComboBoxFilm)
        Me.Controls.Add(Me.DateTimePickerWaktuSelesai)
        Me.Controls.Add(Me.DateTimePickerWaktuMulai)
        Me.Controls.Add(Me.DateTimePickerTanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusJadwalTayang"
        Me.Text = "Hapus Jadwal Tayang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnLihatDetailStudio As Button
    Friend WithEvents BtnLihatDetailFilm As Button
    Friend WithEvents ComboBoxStudio As ComboBox
    Friend WithEvents ComboBoxFilm As ComboBox
    Friend WithEvents DateTimePickerWaktuSelesai As DateTimePicker
    Friend WithEvents DateTimePickerWaktuMulai As DateTimePicker
    Friend WithEvents DateTimePickerTanggal As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
End Class
