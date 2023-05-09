<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        pss = New Label()
        Label4 = New Label()
        X = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pss
        ' 
        pss.AutoSize = True
        pss.BackColor = Color.Transparent
        pss.Font = New Font("Product Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        pss.ForeColor = Color.White
        pss.Location = New Point(12, 9)
        pss.Name = "pss"
        pss.Size = New Size(110, 34)
        pss.TabIndex = 3
        pss.Text = "Remove"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Product Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(370, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 26)
        Label4.TabIndex = 4
        Label4.Text = "X"
        ' 
        ' X
        ' 
        X.BackColor = Color.White
        X.BorderStyle = BorderStyle.FixedSingle
        X.Font = New Font("Product Sans Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        X.Location = New Point(69, 82)
        X.Name = "X"
        X.PlaceholderText = "Pillar and Slot"
        X.Size = New Size(253, 27)
        X.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(155, 89, 182)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(141, 144)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(112, 47)
        Panel1.TabIndex = 8
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
        Label3.Text = "Confirm"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(21, 26, 35)
        ClientSize = New Size(407, 214)
        Controls.Add(Panel1)
        Controls.Add(X)
        Controls.Add(Label4)
        Controls.Add(pss)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pss As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents X As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
