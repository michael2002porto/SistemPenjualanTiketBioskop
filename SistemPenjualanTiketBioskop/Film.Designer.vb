﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Film
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
        Me.BtnUpdateFilm = New System.Windows.Forms.Button()
        Me.BtnRemoveFilm = New System.Windows.Forms.Button()
        Me.DGFilm = New System.Windows.Forms.DataGridView()
        Me.BtnTambahFilm = New System.Windows.Forms.Button()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTiket = New System.Windows.Forms.Button()
        Me.BtnJadwalTayang = New System.Windows.Forms.Button()
        Me.BtnStudio = New System.Windows.Forms.Button()
        Me.BtnFilm = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblid = New System.Windows.Forms.Label()
        CType(Me.DGFilm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdateFilm
        '
        Me.BtnUpdateFilm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdateFilm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnUpdateFilm.FlatAppearance.BorderSize = 0
        Me.BtnUpdateFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateFilm.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateFilm.Location = New System.Drawing.Point(1290, 7)
        Me.BtnUpdateFilm.Name = "BtnUpdateFilm"
        Me.BtnUpdateFilm.Size = New System.Drawing.Size(177, 50)
        Me.BtnUpdateFilm.TabIndex = 12
        Me.BtnUpdateFilm.Text = "Edit Film"
        Me.BtnUpdateFilm.UseVisualStyleBackColor = False
        '
        'BtnRemoveFilm
        '
        Me.BtnRemoveFilm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemoveFilm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnRemoveFilm.FlatAppearance.BorderSize = 0
        Me.BtnRemoveFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRemoveFilm.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveFilm.Location = New System.Drawing.Point(1490, 7)
        Me.BtnRemoveFilm.Name = "BtnRemoveFilm"
        Me.BtnRemoveFilm.Size = New System.Drawing.Size(177, 50)
        Me.BtnRemoveFilm.TabIndex = 10
        Me.BtnRemoveFilm.Text = "Hapus Film"
        Me.BtnRemoveFilm.UseVisualStyleBackColor = False
        '
        'DGFilm
        '
        Me.DGFilm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFilm.Location = New System.Drawing.Point(45, 166)
        Me.DGFilm.Name = "DGFilm"
        Me.DGFilm.RowHeadersWidth = 62
        Me.DGFilm.RowTemplate.Height = 33
        Me.DGFilm.Size = New System.Drawing.Size(1622, 546)
        Me.DGFilm.TabIndex = 9
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambahFilm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnTambahFilm.FlatAppearance.BorderSize = 0
        Me.BtnTambahFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahFilm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahFilm.ForeColor = System.Drawing.Color.White
        Me.BtnTambahFilm.Location = New System.Drawing.Point(1095, 7)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(177, 50)
        Me.BtnTambahFilm.TabIndex = 13
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = False
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BtnSignOut.FlatAppearance.BorderSize = 0
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignOut.ForeColor = System.Drawing.Color.White
        Me.BtnSignOut.Location = New System.Drawing.Point(1517, 24)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(150, 46)
        Me.BtnSignOut.TabIndex = 14
        Me.BtnSignOut.Text = "Sign Out"
        Me.BtnSignOut.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnTiket)
        Me.Panel1.Controls.Add(Me.BtnSignOut)
        Me.Panel1.Controls.Add(Me.BtnJadwalTayang)
        Me.Panel1.Controls.Add(Me.BtnStudio)
        Me.Panel1.Controls.Add(Me.BtnFilm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1714, 92)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 58)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bioscoop"
        '
        'BtnTiket
        '
        Me.BtnTiket.AutoSize = True
        Me.BtnTiket.FlatAppearance.BorderSize = 0
        Me.BtnTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTiket.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTiket.ForeColor = System.Drawing.Color.White
        Me.BtnTiket.Location = New System.Drawing.Point(1035, 3)
        Me.BtnTiket.Name = "BtnTiket"
        Me.BtnTiket.Size = New System.Drawing.Size(112, 88)
        Me.BtnTiket.TabIndex = 3
        Me.BtnTiket.Text = "Tiket"
        Me.BtnTiket.UseVisualStyleBackColor = True
        '
        'BtnJadwalTayang
        '
        Me.BtnJadwalTayang.FlatAppearance.BorderSize = 0
        Me.BtnJadwalTayang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJadwalTayang.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnJadwalTayang.ForeColor = System.Drawing.Color.White
        Me.BtnJadwalTayang.Location = New System.Drawing.Point(541, 2)
        Me.BtnJadwalTayang.Name = "BtnJadwalTayang"
        Me.BtnJadwalTayang.Size = New System.Drawing.Size(201, 87)
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
        Me.BtnStudio.Location = New System.Drawing.Point(902, 3)
        Me.BtnStudio.Name = "BtnStudio"
        Me.BtnStudio.Size = New System.Drawing.Size(112, 86)
        Me.BtnStudio.TabIndex = 1
        Me.BtnStudio.Text = "Studio"
        Me.BtnStudio.UseVisualStyleBackColor = True
        '
        'BtnFilm
        '
        Me.BtnFilm.FlatAppearance.BorderSize = 0
        Me.BtnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFilm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BtnFilm.Location = New System.Drawing.Point(757, 3)
        Me.BtnFilm.Name = "BtnFilm"
        Me.BtnFilm.Size = New System.Drawing.Size(112, 86)
        Me.BtnFilm.TabIndex = 0
        Me.BtnFilm.Text = "Film"
        Me.BtnFilm.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnRemoveFilm)
        Me.Panel2.Controls.Add(Me.BtnUpdateFilm)
        Me.Panel2.Controls.Add(Me.BtnTambahFilm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 732)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1714, 77)
        Me.Panel2.TabIndex = 16
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.Location = New System.Drawing.Point(45, 112)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(130, 28)
        Me.LblUsername.TabIndex = 17
        Me.LblUsername.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1517, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID :"
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lblid.Location = New System.Drawing.Point(1573, 112)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(27, 28)
        Me.Lblid.TabIndex = 19
        Me.Lblid.Text = "1"
        '
        'Film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1714, 809)
        Me.Controls.Add(Me.Lblid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGFilm)
        Me.Name = "Film"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Film"
        CType(Me.DGFilm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdateFilm As Button
    Friend WithEvents BtnRemoveFilm As Button
    Friend WithEvents DGFilm As DataGridView
    Friend WithEvents BtnTambahFilm As Button
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnFilm As Button
    Friend WithEvents BtnTiket As Button
    Friend WithEvents BtnJadwalTayang As Button
    Friend WithEvents BtnStudio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblid As Label
End Class
