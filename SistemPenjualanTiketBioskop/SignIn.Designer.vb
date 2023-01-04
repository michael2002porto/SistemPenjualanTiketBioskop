<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.BtnSignIn = New System.Windows.Forms.Button()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.SistemPenjualanTiketBioskop.My.Resources.Resources.background_signIn
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 576)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(209, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 48)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Bioscoop"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.BtnSignUp)
        Me.Panel2.Controls.Add(Me.BtnSignIn)
        Me.Panel2.Controls.Add(Me.CheckPassword)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(482, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 576)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(265, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Or"
        '
        'BtnSignUp
        '
        Me.BtnSignUp.FlatAppearance.BorderSize = 0
        Me.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignUp.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignUp.ForeColor = System.Drawing.Color.Gold
        Me.BtnSignUp.Location = New System.Drawing.Point(230, 512)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(104, 34)
        Me.BtnSignUp.TabIndex = 11
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'BtnSignIn
        '
        Me.BtnSignIn.BackColor = System.Drawing.Color.Gold
        Me.BtnSignIn.FlatAppearance.BorderSize = 0
        Me.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignIn.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BtnSignIn.Location = New System.Drawing.Point(28, 405)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(507, 39)
        Me.BtnSignIn.TabIndex = 10
        Me.BtnSignIn.Text = "Sign In"
        Me.BtnSignIn.UseVisualStyleBackColor = False
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckPassword.ForeColor = System.Drawing.Color.White
        Me.CheckPassword.Location = New System.Drawing.Point(28, 323)
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
        Me.Panel4.Location = New System.Drawing.Point(28, 256)
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
        Me.Label3.Location = New System.Drawing.Point(28, 228)
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
        Me.Label2.Location = New System.Drawing.Point(28, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TxtUsername)
        Me.Panel3.Location = New System.Drawing.Point(28, 132)
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
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 576)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckPassword As CheckBox
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents Label4 As Label
End Class
