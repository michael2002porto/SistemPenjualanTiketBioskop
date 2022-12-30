<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tiket
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
        Me.DataGridTiket = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTiket = New System.Windows.Forms.Button()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.BtnJadwalTayang = New System.Windows.Forms.Button()
        Me.BtnStudio = New System.Windows.Forms.Button()
        Me.BtnFilm = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        CType(Me.DataGridTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridTiket
        '
        Me.DataGridTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTiket.Location = New System.Drawing.Point(253, 136)
        Me.DataGridTiket.Name = "DataGridTiket"
        Me.DataGridTiket.RowHeadersWidth = 51
        Me.DataGridTiket.RowTemplate.Height = 29
        Me.DataGridTiket.Size = New System.Drawing.Size(618, 239)
        Me.DataGridTiket.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnTiket)
        Me.Panel1.Controls.Add(Me.BtnSignOut)
        Me.Panel1.Controls.Add(Me.BtnJadwalTayang)
        Me.Panel1.Controls.Add(Me.BtnStudio)
        Me.Panel1.Controls.Add(Me.BtnFilm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 74)
        Me.Panel1.TabIndex = 16
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(955, 14)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(120, 37)
        Me.BtnLogout.TabIndex = 18
        Me.BtnLogout.Text = "Sign Out"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 48)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bioscoop"
        '
        'BtnTiket
        '
        Me.BtnTiket.AutoSize = True
        Me.BtnTiket.FlatAppearance.BorderSize = 0
        Me.BtnTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTiket.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BtnTiket.Location = New System.Drawing.Point(799, 1)
        Me.BtnTiket.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTiket.Name = "BtnTiket"
        Me.BtnTiket.Size = New System.Drawing.Size(90, 72)
        Me.BtnTiket.TabIndex = 3
        Me.BtnTiket.Text = "Tiket"
        Me.BtnTiket.UseVisualStyleBackColor = True
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BtnSignOut.FlatAppearance.BorderSize = 0
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignOut.ForeColor = System.Drawing.Color.White
        Me.BtnSignOut.Location = New System.Drawing.Point(2124, 19)
        Me.BtnSignOut.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(120, 37)
        Me.BtnSignOut.TabIndex = 14
        Me.BtnSignOut.Text = "Sign Out"
        Me.BtnSignOut.UseVisualStyleBackColor = False
        '
        'BtnJadwalTayang
        '
        Me.BtnJadwalTayang.FlatAppearance.BorderSize = 0
        Me.BtnJadwalTayang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJadwalTayang.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnJadwalTayang.ForeColor = System.Drawing.Color.White
        Me.BtnJadwalTayang.Location = New System.Drawing.Point(394, 1)
        Me.BtnJadwalTayang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJadwalTayang.Name = "BtnJadwalTayang"
        Me.BtnJadwalTayang.Size = New System.Drawing.Size(161, 72)
        Me.BtnJadwalTayang.TabIndex = 2
        Me.BtnJadwalTayang.Text = "Jadwal Tayang"
        Me.BtnJadwalTayang.UseVisualStyleBackColor = True
        '
        'BtnStudio
        '
        Me.BtnStudio.FlatAppearance.BorderSize = 0
        Me.BtnStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudio.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnStudio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnStudio.Location = New System.Drawing.Point(667, 1)
        Me.BtnStudio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnStudio.Name = "BtnStudio"
        Me.BtnStudio.Size = New System.Drawing.Size(90, 70)
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
        Me.BtnFilm.Location = New System.Drawing.Point(559, 1)
        Me.BtnFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFilm.Name = "BtnFilm"
        Me.BtnFilm.Size = New System.Drawing.Size(90, 70)
        Me.BtnFilm.TabIndex = 0
        Me.BtnFilm.Text = "Film"
        Me.BtnFilm.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(729, 399)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(142, 40)
        Me.BtnAdd.TabIndex = 17
        Me.BtnAdd.Text = "Tambah Tiket"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnDel.FlatAppearance.BorderSize = 0
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDel.ForeColor = System.Drawing.Color.White
        Me.BtnDel.Location = New System.Drawing.Point(887, 399)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(142, 40)
        Me.BtnDel.TabIndex = 18
        Me.BtnDel.Text = "Hapus Tiket"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'Tiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 457)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridTiket)
        Me.Name = "Tiket"
        Me.Text = "Tiket"
        CType(Me.DataGridTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridTiket As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTiket As Button
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents BtnJadwalTayang As Button
    Friend WithEvents BtnStudio As Button
    Friend WithEvents BtnFilm As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDel As Button
End Class
