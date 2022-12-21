<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiket))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnDel = New System.Windows.Forms.ToolStripButton()
        Me.DataGridTiket = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnAdd, Me.ToolStripBtnDel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(612, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnAdd
        '
        Me.ToolStripBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnAdd.Image = CType(resources.GetObject("ToolStripBtnAdd.Image"), System.Drawing.Image)
        Me.ToolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnAdd.Name = "ToolStripBtnAdd"
        Me.ToolStripBtnAdd.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripBtnAdd.Text = "ToolStripButton1"
        '
        'ToolStripBtnDel
        '
        Me.ToolStripBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnDel.Image = CType(resources.GetObject("ToolStripBtnDel.Image"), System.Drawing.Image)
        Me.ToolStripBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnDel.Name = "ToolStripBtnDel"
        Me.ToolStripBtnDel.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripBtnDel.Text = "ToolStripButton1"
        '
        'DataGridTiket
        '
        Me.DataGridTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTiket.Location = New System.Drawing.Point(12, 55)
        Me.DataGridTiket.Name = "DataGridTiket"
        Me.DataGridTiket.RowHeadersWidth = 51
        Me.DataGridTiket.RowTemplate.Height = 29
        Me.DataGridTiket.Size = New System.Drawing.Size(588, 323)
        Me.DataGridTiket.TabIndex = 1
        '
        'Tiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 450)
        Me.Controls.Add(Me.DataGridTiket)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Tiket"
        Me.Text = "Tiket"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnAdd As ToolStripButton
    Friend WithEvents ToolStripBtnDel As ToolStripButton
    Friend WithEvents DataGridTiket As DataGridView
End Class
