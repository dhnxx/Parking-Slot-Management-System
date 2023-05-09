Public Class Login

    Public username, uEmail
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click




        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader("userDB.txt")
        Dim line As String
        Dim userFound As Boolean = False
        While Not file.EndOfStream
            line = file.ReadLine()
            Dim userFields As String() = line.Split(", ")
            If userFields(2) = email.Text AndAlso userFields(1) = password.Text Then
                userFound = True
                uemail = userFields(2)
                username = userFields(0)
                Exit While
            End If
        End While
        file.Close()

        'If credentials matched, display success message
        If userFound Then
            MessageBox.Show("Login successful!")
            userMainMenu.Panel1.Visible = False
            userMainMenu.Show()
            Me.Hide()

        ElseIf email.Text = "admin" AndAlso password.Text = "123" Then

            MessageBox.Show("Admin Login successful!")
            userMainMenu.Panel1.Visible = True
            userMainMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid email or password.")
        End If

        'Clear password textbox
        password.Clear()





    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Application.Exit()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Register.Show()
        Me.Hide()

    End Sub

End Class