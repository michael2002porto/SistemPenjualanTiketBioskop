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
        Me.LblIDTiket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(960, 109)
        Me.Panel1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(960, 49)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Hapus Tiket"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIDTiket
        '
        Me.LblIDTiket.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblIDTiket.ForeColor = System.Drawing.Color.Firebrick
        Me.LblIDTiket.Location = New System.Drawing.Point(0, 268)
        Me.LblIDTiket.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblIDTiket.Name = "LblIDTiket"
        Me.LblIDTiket.Size = New System.Drawing.Size(960, 78)
        Me.LblIDTiket.TabIndex = 63
        Me.LblIDTiket.Text = "Label3"
        Me.LblIDTiket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(960, 42)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Apakah Anda ingin menghapus jadwal tayang berikut?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHapus.BackColor = System.Drawing.Color.Teal
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(224, 404)
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
        Me.Button1.Location = New System.Drawing.Point(562, 404)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 59)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HapusJadwalTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 498)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblIDTiket)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusJadwalTayang"
        Me.Text = "Hapus Jadwal Tayang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LblIDTiket As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Button1 As Button
End Class
