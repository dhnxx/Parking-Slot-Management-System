<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        PictureBox1 = New PictureBox()
        pss = New Label()
        email = New TextBox()
        tempPassword = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        userName = New TextBox()
        password = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.quinta
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(506, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 45)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' pss
        ' 
        pss.AutoSize = True
        pss.BackColor = Color.Transparent
        pss.Font = New Font("Product Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        pss.ForeColor = Color.White
        pss.Location = New Point(104, 60)
        pss.Name = "pss"
        pss.Size = New Size(113, 34)
        pss.TabIndex = 2
        pss.Text = "Register"
        ' 
        ' email
        ' 
        email.BackColor = Color.White
        email.BorderStyle = BorderStyle.FixedSingle
        email.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        email.Location = New Point(296, 248)
        email.Name = "email"
        email.PlaceholderText = "Email"
        email.Size = New Size(188, 27)
        email.TabIndex = 3
        ' 
        ' tempPassword
        ' 
        tempPassword.BackColor = Color.White
        tempPassword.BorderStyle = BorderStyle.FixedSingle
        tempPassword.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tempPassword.Location = New Point(296, 338)
        tempPassword.Name = "tempPassword"
        tempPassword.PlaceholderText = "Password"
        tempPassword.Size = New Size(188, 27)
        tempPassword.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(130, 539)
        Label1.Name = "Label1"
        Label1.Size = New Size(14, 24)
        Label1.TabIndex = 5
        Label1.Text = " "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(369, 597)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(112, 47)
        Panel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Product Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(14, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 26)
        Label3.TabIndex = 0
        Label3.Text = "Register"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Product Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(550, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 26)
        Label4.TabIndex = 1
        Label4.Text = "X"
        ' 
        ' userName
        ' 
        userName.BackColor = Color.White
        userName.BorderStyle = BorderStyle.FixedSingle
        userName.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        userName.Location = New Point(296, 160)
        userName.Name = "userName"
        userName.PlaceholderText = "Username"
        userName.Size = New Size(188, 27)
        userName.TabIndex = 8
        ' 
        ' password
        ' 
        password.BackColor = Color.White
        password.BorderStyle = BorderStyle.FixedSingle
        password.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        password.Location = New Point(296, 431)
        password.Name = "password"
        password.PlaceholderText = "Confirm Password"
        password.Size = New Size(188, 27)
        password.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        Label6.Font = New Font("Product Sans", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(31, 47)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 47)
        Label6.TabIndex = 33
        Label6.Text = "<"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(104, 163)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 24)
        Label5.TabIndex = 36
        Label5.Text = "Username:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(104, 251)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 24)
        Label7.TabIndex = 37
        Label7.Text = "Email:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(104, 341)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 24)
        Label8.TabIndex = 38
        Label8.Text = "Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(104, 434)
        Label9.Margin = New Padding(0)
        Label9.Name = "Label9"
        Label9.Size = New Size(164, 24)
        Label9.TabIndex = 39
        Label9.Text = "Confirm Password"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Group_7
        ClientSize = New Size(587, 718)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(password)
        Controls.Add(userName)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(tempPassword)
        Controls.Add(email)
        Controls.Add(pss)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pss As Label
    Friend WithEvents email As TextBox
    Friend WithEvents tempPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents userName As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
