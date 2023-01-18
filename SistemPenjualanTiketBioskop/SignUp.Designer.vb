<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblRePassword = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtRePassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.BtnJadwalTayang = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCheckUsername = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblCheckUsername)
        Me.Panel2.Controls.Add(Me.LblRePassword)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.LblEmail)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.BtnBack)
        Me.Panel2.Controls.Add(Me.BtnSignUp)
        Me.Panel2.Controls.Add(Me.CheckPassword)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.BtnJadwalTayang)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 829)
        Me.Panel2.TabIndex = 3
        '
        'LblRePassword
        '
        Me.LblRePassword.AutoSize = True
        Me.LblRePassword.ForeColor = System.Drawing.Color.Gold
        Me.LblRePassword.Location = New System.Drawing.Point(311, 526)
        Me.LblRePassword.Name = "LblRePassword"
        Me.LblRePassword.Size = New System.Drawing.Size(220, 25)
        Me.LblRePassword.TabIndex = 18
        Me.LblRePassword.Text = "* password doesn't match"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel5.Controls.Add(Me.TxtRePassword)
        Me.Panel5.Location = New System.Drawing.Point(24, 479)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(507, 44)
        Me.Panel5.TabIndex = 17
        '
        'TxtRePassword
        '
        Me.TxtRePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TxtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRePassword.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtRePassword.ForeColor = System.Drawing.Color.White
        Me.TxtRePassword.Location = New System.Drawing.Point(22, 10)
        Me.TxtRePassword.Name = "TxtRePassword"
        Me.TxtRePassword.Size = New System.Drawing.Size(461, 26)
        Me.TxtRePassword.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Re-Password"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.ForeColor = System.Drawing.Color.Gold
        Me.LblEmail.Location = New System.Drawing.Point(408, 182)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(123, 25)
        Me.LblEmail.TabIndex = 15
        Me.LblEmail.Text = "* email invalid"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Location = New System.Drawing.Point(24, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 44)
        Me.Panel1.TabIndex = 14
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtEmail.ForeColor = System.Drawing.Color.White
        Me.TxtEmail.Location = New System.Drawing.Point(22, 10)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(461, 26)
        Me.TxtEmail.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(252, 701)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Or"
        '
        'BtnBack
        '
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.Color.Gold
        Me.BtnBack.Location = New System.Drawing.Point(222, 750)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(104, 34)
        Me.BtnBack.TabIndex = 11
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.Gold
        Me.BtnSignUp.FlatAppearance.BorderSize = 0
        Me.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignUp.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnSignUp.Location = New System.Drawing.Point(24, 642)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(507, 39)
        Me.BtnSignUp.TabIndex = 10
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckPassword.ForeColor = System.Drawing.Color.White
        Me.CheckPassword.Location = New System.Drawing.Point(24, 571)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckPassword.Size = New System.Drawing.Size(176, 29)
        Me.CheckPassword.TabIndex = 9
        Me.CheckPassword.Text = "Show Password"
        Me.CheckPassword.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TxtPassword)
        Me.Panel4.Location = New System.Drawing.Point(24, 360)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(507, 44)
        Me.Panel4.TabIndex = 8
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPassword.ForeColor = System.Drawing.Color.White
        Me.TxtPassword.Location = New System.Drawing.Point(22, 10)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(461, 26)
        Me.TxtPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TxtUsername)
        Me.Panel3.Location = New System.Drawing.Point(24, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(507, 44)
        Me.Panel3.TabIndex = 4
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtUsername.ForeColor = System.Drawing.Color.White
        Me.TxtUsername.Location = New System.Drawing.Point(22, 10)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(461, 26)
        Me.TxtUsername.TabIndex = 6
        '
        'BtnJadwalTayang
        '
        Me.BtnJadwalTayang.FlatAppearance.BorderSize = 0
        Me.BtnJadwalTayang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJadwalTayang.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnJadwalTayang.ForeColor = System.Drawing.Color.White
        Me.BtnJadwalTayang.Location = New System.Drawing.Point(24, 25)
        Me.BtnJadwalTayang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJadwalTayang.Name = "BtnJadwalTayang"
        Me.BtnJadwalTayang.Size = New System.Drawing.Size(137, 48)
        Me.BtnJadwalTayang.TabIndex = 3
        Me.BtnJadwalTayang.Text = "Sign Up"
        Me.BtnJadwalTayang.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackgroundImage = Global.SistemPenjualanTiketBioskop.My.Resources.Resources.background_signIn
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(562, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(561, 829)
        Me.Panel6.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(190, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 58)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Bioscoop"
        '
        'LblCheckUsername
        '
        Me.LblCheckUsername.AutoSize = True
        Me.LblCheckUsername.ForeColor = System.Drawing.Color.Gold
        Me.LblCheckUsername.Location = New System.Drawing.Point(342, 296)
        Me.LblCheckUsername.Name = "LblCheckUsername"
        Me.LblCheckUsername.Size = New System.Drawing.Size(189, 25)
        Me.LblCheckUsername.TabIndex = 19
        Me.LblCheckUsername.Text = "* username sudah ada"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 829)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents CheckPassword As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents BtnJadwalTayang As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtRePassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblRePassword As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LblCheckUsername As Label
End Class
