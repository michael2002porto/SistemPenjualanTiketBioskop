<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Studio
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
        Me.DataGridStudio = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.LblDataStudio = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        CType(Me.DataGridStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridStudio
        '
        Me.DataGridStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridStudio.Location = New System.Drawing.Point(12, 80)
        Me.DataGridStudio.Name = "DataGridStudio"
        Me.DataGridStudio.RowHeadersWidth = 62
        Me.DataGridStudio.RowTemplate.Height = 33
        Me.DataGridStudio.Size = New System.Drawing.Size(664, 292)
        Me.DataGridStudio.TabIndex = 0
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(430, 390)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(550, 390)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(112, 34)
        Me.BtnRemove.TabIndex = 3
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'LblDataStudio
        '
        Me.LblDataStudio.AutoSize = True
        Me.LblDataStudio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDataStudio.Location = New System.Drawing.Point(244, 27)
        Me.LblDataStudio.Name = "LblDataStudio"
        Me.LblDataStudio.Size = New System.Drawing.Size(171, 32)
        Me.LblDataStudio.TabIndex = 4
        Me.LblDataStudio.Text = "DATA STUDIO"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(310, 390)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(112, 34)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "Add"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 440)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LblDataStudio)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridStudio)
        Me.Name = "Studio"
        Me.Text = "Studio"
        CType(Me.DataGridStudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridStudio As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents LblDataStudio As Label
    Friend WithEvents BtnTambah As Button
End Class
