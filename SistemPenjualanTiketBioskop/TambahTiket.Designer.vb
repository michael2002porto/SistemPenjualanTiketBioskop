<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahTiket
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
        Me.CbBoxFilm = New System.Windows.Forms.ComboBox()
        Me.DataGridJadwal = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnBuy = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.DataGridJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(102, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul Film:"
        '
        'CbBoxFilm
        '
        Me.CbBoxFilm.FormattingEnabled = True
        Me.CbBoxFilm.Location = New System.Drawing.Point(258, 110)
        Me.CbBoxFilm.Name = "CbBoxFilm"
        Me.CbBoxFilm.Size = New System.Drawing.Size(359, 28)
        Me.CbBoxFilm.TabIndex = 1
        '
        'DataGridJadwal
        '
        Me.DataGridJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJadwal.Location = New System.Drawing.Point(102, 176)
        Me.DataGridJadwal.Name = "DataGridJadwal"
        Me.DataGridJadwal.RowHeadersWidth = 51
        Me.DataGridJadwal.RowTemplate.Height = 29
        Me.DataGridJadwal.Size = New System.Drawing.Size(625, 188)
        Me.DataGridJadwal.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 68)
        Me.Panel1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(329, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Tambah Tiket"
        '
        'BtnSelect
        '
        Me.BtnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSelect.BackColor = System.Drawing.Color.Teal
        Me.BtnSelect.FlatAppearance.BorderSize = 0
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelect.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSelect.ForeColor = System.Drawing.Color.White
        Me.BtnSelect.Location = New System.Drawing.Point(634, 106)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(93, 37)
        Me.BtnSelect.TabIndex = 57
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'BtnBuy
        '
        Me.BtnBuy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBuy.BackColor = System.Drawing.Color.Teal
        Me.BtnBuy.FlatAppearance.BorderSize = 0
        Me.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBuy.ForeColor = System.Drawing.Color.White
        Me.BtnBuy.Location = New System.Drawing.Point(641, 17)
        Me.BtnBuy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBuy.Name = "BtnBuy"
        Me.BtnBuy.Size = New System.Drawing.Size(125, 37)
        Me.BtnBuy.TabIndex = 58
        Me.BtnBuy.Text = "Beli Tiket"
        Me.BtnBuy.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnBack)
        Me.Panel2.Controls.Add(Me.BtnBuy)
        Me.Panel2.Location = New System.Drawing.Point(0, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 68)
        Me.Panel2.TabIndex = 59
        '
        'BtnBack
        '
        Me.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBack.BackColor = System.Drawing.Color.Teal
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(33, 17)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(125, 37)
        Me.BtnBack.TabIndex = 59
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'TambahTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 457)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridJadwal)
        Me.Controls.Add(Me.CbBoxFilm)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TambahTiket"
        Me.Text = "Tambah Tiket"
        CType(Me.DataGridJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbBoxFilm As ComboBox
    Friend WithEvents DataGridJadwal As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnBuy As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnBack As Button
End Class
