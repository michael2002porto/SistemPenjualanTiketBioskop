<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusFilm
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
        Me.BtnHapusFilm = New System.Windows.Forms.Button()
        Me.LblFilm = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapusFilm
        '
        Me.BtnHapusFilm.BackColor = System.Drawing.Color.Teal
        Me.BtnHapusFilm.FlatAppearance.BorderSize = 0
        Me.BtnHapusFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusFilm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusFilm.ForeColor = System.Drawing.Color.White
        Me.BtnHapusFilm.Location = New System.Drawing.Point(338, 284)
        Me.BtnHapusFilm.Name = "BtnHapusFilm"
        Me.BtnHapusFilm.Size = New System.Drawing.Size(112, 34)
        Me.BtnHapusFilm.TabIndex = 5
        Me.BtnHapusFilm.Text = "Hapus"
        Me.BtnHapusFilm.UseVisualStyleBackColor = False
        '
        'LblFilm
        '
        Me.LblFilm.AutoSize = True
        Me.LblFilm.ForeColor = System.Drawing.Color.DarkRed
        Me.LblFilm.Location = New System.Drawing.Point(323, 143)
        Me.LblFilm.Name = "LblFilm"
        Me.LblFilm.Size = New System.Drawing.Size(19, 25)
        Me.LblFilm.TabIndex = 4
        Me.LblFilm.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah ingin menghapus koleksi"
        '
        'HapusFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 352)
        Me.Controls.Add(Me.BtnHapusFilm)
        Me.Controls.Add(Me.LblFilm)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "HapusFilm"
        Me.Text = "Hapus Film"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapusFilm As Button
    Friend WithEvents LblFilm As Label
    Friend WithEvents Label1 As Label
End Class
