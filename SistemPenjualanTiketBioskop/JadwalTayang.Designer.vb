<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JadwalTayang
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
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnTiket = New System.Windows.Forms.Button()
        Me.BtnJadwalTayang = New System.Windows.Forms.Button()
        Me.BtnStudio = New System.Windows.Forms.Button()
        Me.BtnFilm = New System.Windows.Forms.Button()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonViewAll = New System.Windows.Forms.Button()
        Me.DataGridViewJadwalTayangNowPlaying = New System.Windows.Forms.DataGridView()
        Me.FotoFilm = New System.Windows.Forms.DataGridViewImageColumn()
        Me.JudulFilm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Studio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktuMulai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktuSelesai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewJadwalTayangUpcoming = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.JudulFilm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalTayang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewJadwalTayangNowPlaying, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewJadwalTayangUpcoming, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 77)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bioscoop"
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BtnSignOut.FlatAppearance.BorderSize = 0
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignOut.ForeColor = System.Drawing.Color.White
        Me.BtnSignOut.Location = New System.Drawing.Point(4000, 31)
        Me.BtnSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(195, 59)
        Me.BtnSignOut.TabIndex = 14
        Me.BtnSignOut.Text = "Sign Out"
        Me.BtnSignOut.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnTiket)
        Me.Panel1.Controls.Add(Me.BtnSignOut)
        Me.Panel1.Controls.Add(Me.BtnJadwalTayang)
        Me.Panel1.Controls.Add(Me.BtnStudio)
        Me.Panel1.Controls.Add(Me.BtnFilm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2228, 118)
        Me.Panel1.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1972, 30)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 59)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Sign Out"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BtnTiket
        '
        Me.BtnTiket.AutoSize = True
        Me.BtnTiket.FlatAppearance.BorderSize = 0
        Me.BtnTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTiket.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTiket.ForeColor = System.Drawing.Color.White
        Me.BtnTiket.Location = New System.Drawing.Point(1346, 3)
        Me.BtnTiket.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTiket.Name = "BtnTiket"
        Me.BtnTiket.Size = New System.Drawing.Size(148, 115)
        Me.BtnTiket.TabIndex = 3
        Me.BtnTiket.Text = "Tiket"
        Me.BtnTiket.UseVisualStyleBackColor = True
        '
        'BtnJadwalTayang
        '
        Me.BtnJadwalTayang.FlatAppearance.BorderSize = 0
        Me.BtnJadwalTayang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJadwalTayang.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnJadwalTayang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BtnJadwalTayang.Location = New System.Drawing.Point(658, 0)
        Me.BtnJadwalTayang.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnJadwalTayang.Name = "BtnJadwalTayang"
        Me.BtnJadwalTayang.Size = New System.Drawing.Size(306, 115)
        Me.BtnJadwalTayang.TabIndex = 2
        Me.BtnJadwalTayang.Text = "Jadwal Tayang"
        Me.BtnJadwalTayang.UseVisualStyleBackColor = True
        '
        'BtnStudio
        '
        Me.BtnStudio.FlatAppearance.BorderSize = 0
        Me.BtnStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudio.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnStudio.ForeColor = System.Drawing.Color.White
        Me.BtnStudio.Location = New System.Drawing.Point(1173, 3)
        Me.BtnStudio.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStudio.Name = "BtnStudio"
        Me.BtnStudio.Size = New System.Drawing.Size(146, 111)
        Me.BtnStudio.TabIndex = 1
        Me.BtnStudio.Text = "Studio"
        Me.BtnStudio.UseVisualStyleBackColor = True
        '
        'BtnFilm
        '
        Me.BtnFilm.FlatAppearance.BorderSize = 0
        Me.BtnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFilm.ForeColor = System.Drawing.Color.White
        Me.BtnFilm.Location = New System.Drawing.Point(984, 3)
        Me.BtnFilm.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFilm.Name = "BtnFilm"
        Me.BtnFilm.Size = New System.Drawing.Size(146, 111)
        Me.BtnFilm.TabIndex = 0
        Me.BtnFilm.Text = "Film"
        Me.BtnFilm.UseVisualStyleBackColor = True
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lblid.Location = New System.Drawing.Point(2045, 143)
        Me.Lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(34, 36)
        Me.Lblid.TabIndex = 25
        Me.Lblid.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1972, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 36)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ID :"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.Location = New System.Drawing.Point(58, 143)
        Me.LblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(170, 36)
        Me.LblUsername.TabIndex = 23
        Me.LblUsername.Text = "Username"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Algerian", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(0, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2228, 53)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "==============================  Now Playing  ==============================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Algerian", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(0, 676)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(2228, 53)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "===============================  Upcoming  ================================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonViewAll
        '
        Me.ButtonViewAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonViewAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ButtonViewAll.FlatAppearance.BorderSize = 0
        Me.ButtonViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonViewAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonViewAll.ForeColor = System.Drawing.Color.White
        Me.ButtonViewAll.Location = New System.Drawing.Point(1000, 19)
        Me.ButtonViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonViewAll.Name = "ButtonViewAll"
        Me.ButtonViewAll.Size = New System.Drawing.Size(230, 64)
        Me.ButtonViewAll.TabIndex = 29
        Me.ButtonViewAll.Text = "View All"
        Me.ButtonViewAll.UseVisualStyleBackColor = False
        '
        'DataGridViewJadwalTayangNowPlaying
        '
        Me.DataGridViewJadwalTayangNowPlaying.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DataGridViewJadwalTayangNowPlaying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJadwalTayangNowPlaying.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FotoFilm, Me.JudulFilm, Me.Studio, Me.WaktuMulai, Me.WaktuSelesai})
        Me.DataGridViewJadwalTayangNowPlaying.Location = New System.Drawing.Point(281, 277)
        Me.DataGridViewJadwalTayangNowPlaying.Name = "DataGridViewJadwalTayangNowPlaying"
        Me.DataGridViewJadwalTayangNowPlaying.RowHeadersWidth = 82
        Me.DataGridViewJadwalTayangNowPlaying.RowTemplate.Height = 41
        Me.DataGridViewJadwalTayangNowPlaying.Size = New System.Drawing.Size(1661, 335)
        Me.DataGridViewJadwalTayangNowPlaying.TabIndex = 30
        '
        'FotoFilm
        '
        Me.FotoFilm.HeaderText = "Foto Film"
        Me.FotoFilm.MinimumWidth = 10
        Me.FotoFilm.Name = "FotoFilm"
        Me.FotoFilm.Width = 250
        '
        'JudulFilm
        '
        Me.JudulFilm.HeaderText = "Judul Film"
        Me.JudulFilm.MinimumWidth = 10
        Me.JudulFilm.Name = "JudulFilm"
        Me.JudulFilm.Width = 685
        '
        'Studio
        '
        Me.Studio.HeaderText = "Studio"
        Me.Studio.MinimumWidth = 10
        Me.Studio.Name = "Studio"
        Me.Studio.Width = 200
        '
        'WaktuMulai
        '
        Me.WaktuMulai.HeaderText = "Mulai Tayang"
        Me.WaktuMulai.MinimumWidth = 10
        Me.WaktuMulai.Name = "WaktuMulai"
        Me.WaktuMulai.Width = 220
        '
        'WaktuSelesai
        '
        Me.WaktuSelesai.HeaderText = "Selesai Tayang"
        Me.WaktuSelesai.MinimumWidth = 10
        Me.WaktuSelesai.Name = "WaktuSelesai"
        Me.WaktuSelesai.Width = 220
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Foto Film"
        Me.DataGridViewImageColumn1.MinimumWidth = 10
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nama Film"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 685
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Studio"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewJadwalTayangUpcoming
        '
        Me.DataGridViewJadwalTayangUpcoming.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DataGridViewJadwalTayangUpcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJadwalTayangUpcoming.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn2, Me.JudulFilm1, Me.DataGridViewTextBoxColumn4, Me.TanggalTayang, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridViewJadwalTayangUpcoming.Location = New System.Drawing.Point(281, 732)
        Me.DataGridViewJadwalTayangUpcoming.Name = "DataGridViewJadwalTayangUpcoming"
        Me.DataGridViewJadwalTayangUpcoming.RowHeadersWidth = 82
        Me.DataGridViewJadwalTayangUpcoming.RowTemplate.Height = 41
        Me.DataGridViewJadwalTayangUpcoming.Size = New System.Drawing.Size(1661, 335)
        Me.DataGridViewJadwalTayangUpcoming.TabIndex = 31
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Foto Film"
        Me.DataGridViewImageColumn2.MinimumWidth = 10
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 250
        '
        'JudulFilm1
        '
        Me.JudulFilm1.HeaderText = "Judul Film"
        Me.JudulFilm1.MinimumWidth = 10
        Me.JudulFilm1.Name = "JudulFilm1"
        Me.JudulFilm1.Width = 685
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Studio"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'TanggalTayang
        '
        Me.TanggalTayang.HeaderText = "Tanggal Tayang"
        Me.TanggalTayang.MinimumWidth = 10
        Me.TanggalTayang.Name = "TanggalTayang"
        Me.TanggalTayang.Width = 220
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mulai Tayang"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Selesai Tayang"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonViewAll)
        Me.Panel2.Location = New System.Drawing.Point(0, 1177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2228, 100)
        Me.Panel2.TabIndex = 32
        '
        'JadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2228, 1273)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridViewJadwalTayangUpcoming)
        Me.Controls.Add(Me.DataGridViewJadwalTayangNowPlaying)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lblid)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Label2)
        Me.Name = "JadwalTayang"
        Me.Text = "Jadwal Tayang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewJadwalTayangNowPlaying, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewJadwalTayangUpcoming, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnTiket As Button
    Friend WithEvents BtnJadwalTayang As Button
    Friend WithEvents BtnStudio As Button
    Friend WithEvents BtnFilm As Button
    Friend WithEvents Lblid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonViewAll As Button
    Friend WithEvents DataGridViewJadwalTayangNowPlaying As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewJadwalTayangUpcoming As DataGridView
    Friend WithEvents FotoFilm As DataGridViewImageColumn
    Friend WithEvents JudulFilm As DataGridViewTextBoxColumn
    Friend WithEvents Studio As DataGridViewTextBoxColumn
    Friend WithEvents WaktuMulai As DataGridViewTextBoxColumn
    Friend WithEvents WaktuSelesai As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents JudulFilm1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TanggalTayang As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
End Class
