Public Class admin
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Get a reference to the other form
        Dim otherForm As Form = userMainMenu ' Replace "userMainMenu" with the name of your other form

        ' Create the control name using the selected text from the combobox
        Dim controlName As String = X.Text

        ' Find the control with the specified name on the other form
        Dim controlArray() As Control = otherForm.Controls.Find(controlName, True)

        ' Check if the control is found
        If controlArray.Length > 0 AndAlso TypeOf controlArray(0) Is Label Then
            ' Cast the control to a Label object
            Dim labelControl As Label = CType(controlArray(0), Label)

            ' Change the background color of the label
            labelControl.BackColor = Color.White
        End If

        Me.Close()

    End Sub
End Class