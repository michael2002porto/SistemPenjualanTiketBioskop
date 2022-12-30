<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahJadwalTayang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePickerRelease = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Label1.Text = "Tambah Jadwal Tayang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 68)
        Me.Panel1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 34)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Pilih Film"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 34)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Pilih Studio"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 34)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Tanggal Tayang"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(37, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 34)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Waktu Mulai"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(37, 510)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 34)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Waktu Selesai"
        '
        'DateTimePickerRelease
        '
        Me.DateTimePickerRelease.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerRelease.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerRelease.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerRelease.Location = New System.Drawing.Point(302, 302)
        Me.DateTimePickerRelease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerRelease.Name = "DateTimePickerRelease"
        Me.DateTimePickerRelease.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePickerRelease.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(302, 402)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePicker1.TabIndex = 63
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(302, 502)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(477, 44)
        Me.DateTimePicker2.TabIndex = 64
        '
        'ComboBoxJenisKoleksi
        '
        Me.ComboBoxJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.ComboBoxJenisKoleksi.Location = New System.Drawing.Point(302, 107)
        Me.ComboBoxJenisKoleksi.Name = "ComboBoxJenisKoleksi"
        Me.ComboBoxJenisKoleksi.Size = New System.Drawing.Size(477, 40)
        Me.ComboBoxJenisKoleksi.TabIndex = 65
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.ComboBox1.Location = New System.Drawing.Point(302, 207)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(477, 40)
        Me.ComboBox1.TabIndex = 66
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(302, 634)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(389, 64)
        Me.ButtonBack.TabIndex = 67
        Me.ButtonBack.Text = "Tambah Jadwal Tayang"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnTambahGambar.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 0
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Times New Roman", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.Color.White
        Me.BtnTambahGambar.Location = New System.Drawing.Point(796, 107)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(163, 40)
        Me.BtnTambahGambar.TabIndex = 68
        Me.BtnTambahGambar.Text = "Lihat Detail"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(796, 207)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 40)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Lihat Detail"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TambahJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 733)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBoxJenisKoleksi)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePickerRelease)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TambahJadwalTayang"
        Me.Text = "Tambah Jadwal Tayang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePickerRelease As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBoxJenisKoleksi As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButtonBack As Button
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Button2 As Button
End Class
