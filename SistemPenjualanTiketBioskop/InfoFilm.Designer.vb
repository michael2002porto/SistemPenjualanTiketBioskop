<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoFilm
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
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.ListBoxGenre = New System.Windows.Forms.ListBox()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblHargaFilm = New System.Windows.Forms.Label()
        Me.LblDateRelease = New System.Windows.Forms.Label()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblDirector = New System.Windows.Forms.Label()
        Me.LblFilm = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Teal
        Me.BtnTutup.FlatAppearance.BorderSize = 0
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTutup.ForeColor = System.Drawing.Color.White
        Me.BtnTutup.Location = New System.Drawing.Point(389, 728)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(112, 34)
        Me.BtnTutup.TabIndex = 71
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'ListBoxGenre
        '
        Me.ListBoxGenre.FormattingEnabled = True
        Me.ListBoxGenre.ItemHeight = 25
        Me.ListBoxGenre.Location = New System.Drawing.Point(447, 487)
        Me.ListBoxGenre.Name = "ListBoxGenre"
        Me.ListBoxGenre.Size = New System.Drawing.Size(180, 204)
        Me.ListBoxGenre.TabIndex = 70
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblBahasa.Location = New System.Drawing.Point(447, 439)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(19, 25)
        Me.LblBahasa.TabIndex = 69
        Me.LblBahasa.Text = "-"
        '
        'LblHargaFilm
        '
        Me.LblHargaFilm.AutoSize = True
        Me.LblHargaFilm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHargaFilm.Location = New System.Drawing.Point(447, 386)
        Me.LblHargaFilm.Name = "LblHargaFilm"
        Me.LblHargaFilm.Size = New System.Drawing.Size(19, 25)
        Me.LblHargaFilm.TabIndex = 67
        Me.LblHargaFilm.Text = "-"
        '
        'LblDateRelease
        '
        Me.LblDateRelease.AutoSize = True
        Me.LblDateRelease.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDateRelease.Location = New System.Drawing.Point(447, 342)
        Me.LblDateRelease.Name = "LblDateRelease"
        Me.LblDateRelease.Size = New System.Drawing.Size(19, 25)
        Me.LblDateRelease.TabIndex = 66
        Me.LblDateRelease.Text = "-"
        '
        'LblDuration
        '
        Me.LblDuration.AutoSize = True
        Me.LblDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDuration.Location = New System.Drawing.Point(447, 299)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(19, 25)
        Me.LblDuration.TabIndex = 65
        Me.LblDuration.Text = "-"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDeskripsi.Location = New System.Drawing.Point(447, 85)
        Me.LblDeskripsi.MaximumSize = New System.Drawing.Size(370, 370)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(19, 25)
        Me.LblDeskripsi.TabIndex = 64
        Me.LblDeskripsi.Text = "-"
        '
        'LblDirector
        '
        Me.LblDirector.AutoSize = True
        Me.LblDirector.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDirector.Location = New System.Drawing.Point(447, 47)
        Me.LblDirector.Name = "LblDirector"
        Me.LblDirector.Size = New System.Drawing.Size(19, 25)
        Me.LblDirector.TabIndex = 63
        Me.LblDirector.Text = "-"
        '
        'LblFilm
        '
        Me.LblFilm.AutoSize = True
        Me.LblFilm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblFilm.Location = New System.Drawing.Point(447, 12)
        Me.LblFilm.Name = "LblFilm"
        Me.LblFilm.Size = New System.Drawing.Size(19, 25)
        Me.LblFilm.TabIndex = 62
        Me.LblFilm.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 535)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 25)
        Me.Label11.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 487)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Genre :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Bahasa :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Harga Film :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Date Release :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Duration :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Deskripsi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Director :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Film:"
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(12, 12)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(159, 231)
        Me.PicFoto.TabIndex = 49
        Me.PicFoto.TabStop = False
        '
        'InfoFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 786)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.ListBoxGenre)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblHargaFilm)
        Me.Controls.Add(Me.LblDateRelease)
        Me.Controls.Add(Me.LblDuration)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblDirector)
        Me.Controls.Add(Me.LblFilm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicFoto)
        Me.Name = "InfoFilm"
        Me.Text = "Info Film"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents ListBoxGenre As ListBox
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblHargaFilm As Label
    Friend WithEvents LblDateRelease As Label
    Friend WithEvents LblDuration As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblDirector As Label
    Friend WithEvents LblFilm As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicFoto As PictureBox
End Class
