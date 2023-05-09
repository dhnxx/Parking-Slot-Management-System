<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        PictureBox1 = New PictureBox()
        pss = New Label()
        email = New TextBox()
        password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
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
        PictureBox1.Location = New Point(237, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 108)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' pss
        ' 
        pss.AutoSize = True
        pss.BackColor = Color.Transparent
        pss.Font = New Font("Product Sans", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point)
        pss.ForeColor = Color.White
        pss.Location = New Point(116, 196)
        pss.Name = "pss"
        pss.Size = New Size(355, 47)
        pss.TabIndex = 2
        pss.Text = "Parking Slot System"
        ' 
        ' email
        ' 
        email.BackColor = Color.White
        email.BorderStyle = BorderStyle.FixedSingle
        email.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        email.Location = New Point(104, 329)
        email.Name = "email"
        email.PlaceholderText = "Email"
        email.Size = New Size(377, 27)
        email.TabIndex = 3
        ' 
        ' password
        ' 
        password.BackColor = Color.White
        password.BorderStyle = BorderStyle.FixedSingle
        password.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        password.Location = New Point(104, 423)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(377, 27)
        password.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(130, 539)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 24)
        Label1.TabIndex = 5
        Label1.Text = "Don't have an account?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        Label2.Location = New Point(329, 539)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 24)
        Label2.TabIndex = 6
        Label2.Text = "Register here"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(237, 597)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(112, 47)
        Panel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Product Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(25, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 26)
        Label3.TabIndex = 0
        Label3.Text = "Login"
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(100, 302)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 24)
        Label5.TabIndex = 37
        Label5.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Product Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(99, 396)
        Label6.Margin = New Padding(0)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 24)
        Label6.TabIndex = 38
        Label6.Text = "Password:"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Group_7
        ClientSize = New Size(587, 718)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password)
        Controls.Add(email)
        Controls.Add(pss)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
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
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
