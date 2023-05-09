Public Class Register
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click



        If tempPassword.Text = password.Text Then

            'Open file for appending data
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("userDB.txt", True)

            'Write user data to file
            file.WriteLine(userName.Text & ", " & password.Text & ", " & email.Text)

            'Close file
            file.Close()

            'Clear textboxes and display success message
            userName.Clear()
            tempPassword.Clear()
            password.Clear()
            email.Clear()
            MessageBox.Show("Registration successful!")


            Login.Show()
            Me.Hide()



        Else
            MessageBox.Show("Password does not match")
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Application.Exit()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        Login.Show()
        Me.Hide()

    End Sub


End Class