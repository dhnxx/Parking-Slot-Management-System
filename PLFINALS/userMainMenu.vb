Public Class userMainMenu
    Dim parkingfloor = 1
    Dim totalprice = 0
    Dim hours = 0

    Public Sub selectviewparking()

        viewParking.BackColor = Color.FromArgb(155, 89, 182)
        availTicket.BackColor = Color.Transparent
        latestReceipt.BackColor = Color.Transparent
        parkingPanel.Show()
        availPanel.Hide()
        displayPanel.Hide()

    End Sub

    Public Sub selectviewparking2()

        viewParking.BackColor = Color.FromArgb(155, 89, 182)
        availTicket.BackColor = Color.Transparent
        latestReceipt.BackColor = Color.Transparent

        parkingPanel.Hide()

        availPanel.Hide()
        displayPanel.Hide()

    End Sub

    Public Sub selectviewparking3()

        viewParking.BackColor = Color.FromArgb(155, 89, 182)
        availTicket.BackColor = Color.Transparent
        latestReceipt.BackColor = Color.Transparent

        parkingPanel.Hide()

        availPanel.Hide()
        displayPanel.Hide()

    End Sub

    Public Sub selectviewparking4()

        viewParking.BackColor = Color.FromArgb(155, 89, 182)
        availTicket.BackColor = Color.Transparent
        latestReceipt.BackColor = Color.Transparent
        parkingPanel.Hide()
        availPanel.Hide()
        displayPanel.Hide()

    End Sub

    Public Sub selectviewparking5()

        viewParking.BackColor = Color.FromArgb(155, 89, 182)
        availTicket.BackColor = Color.Transparent
        latestReceipt.BackColor = Color.Transparent
        parkingPanel.Hide()
        availPanel.Hide()
        displayPanel.Hide()

    End Sub

    Public Sub selectavailticket()

        viewParking.BackColor = Color.Transparent
        availTicket.BackColor = Color.FromArgb(155, 89, 182)
        latestReceipt.BackColor = Color.Transparent
        parkingPanel.Hide()
        availPanel.Show()
        displayPanel.Hide()

    End Sub
    Public Sub selectlatestreceipt()

        viewParking.BackColor = Color.Transparent
        availTicket.BackColor = Color.Transparent
        latestReceipt.BackColor = Color.FromArgb(155, 89, 182)

        parkingPanel.Hide()

        availPanel.Hide()
        displayPanel.Show()

    End Sub

    Private Sub userMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        selectviewparking()
        Me.DoubleBuffered = True

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

        Application.Exit()

    End Sub

    Private Sub viewParking_Click(sender As Object, e As EventArgs) Handles viewParking.Click

        selectviewparking()

    End Sub

    Private Sub availTicket_Click(sender As Object, e As EventArgs) Handles availTicket.Click

        selectavailticket()

    End Sub

    Private Sub latestReceipt_Click(sender As Object, e As EventArgs) Handles latestReceipt.Click

        selectlatestreceipt()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        selectviewparking()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        selectavailticket()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        selectlatestreceipt()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged 'Clear the options in ComboBox2
        ComboBox2.Items.Clear()

        'Add options to ComboBox2 based on the selected item in ComboBox1
        Select Case ComboBox1.SelectedItem.ToString()
            Case "1"
                ComboBox2.Items.Add("A")
                ComboBox2.Items.Add("B")
                ComboBox2.Items.Add("C")
                ComboBox2.Items.Add("D")
                ComboBox2.Items.Add("E")
            Case "2"
                ComboBox2.Items.Add("F")
                ComboBox2.Items.Add("G")
                ComboBox2.Items.Add("H")
                ComboBox2.Items.Add("I")
                ComboBox2.Items.Add("J")
            Case "3"
                ComboBox2.Items.Add("K")
                ComboBox2.Items.Add("L")
                ComboBox2.Items.Add("M")
                ComboBox2.Items.Add("N")
                ComboBox2.Items.Add("O")
            Case "4"
                ComboBox2.Items.Add("P")
                ComboBox2.Items.Add("Q")
                ComboBox2.Items.Add("R")
                ComboBox2.Items.Add("S")
                ComboBox2.Items.Add("T")
            Case "5"
                ComboBox2.Items.Add("U")
                ComboBox2.Items.Add("V")
                ComboBox2.Items.Add("W")
                ComboBox2.Items.Add("X")
                ComboBox2.Items.Add("Y")
            Case Else
                'No options available
        End Select
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Try

            hours = Integer.Parse(TextBox2.Text)
            totalprice = hours * 50

        Catch ex As Exception

        End Try

        Label15.Text = "Total amount: Php " & totalprice.ToString

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

        Label27.Text = Login.username
        Label26.Text = Login.uEmail
        Label28.Text = "Php. " & totalprice
        totaltime.Text = hours & " hours"
        Label25.Text = ComboBox1.SelectedItem.ToString
        Label24.Text = ComboBox2.SelectedItem.ToString
        Label22.Text = ComboBox3.SelectedItem.ToString

        'change the backcolor the string combined of combobox2.selecteditem and combobox3.selecteditem
        ' Get the selected items from the two comboboxes
        Dim comboBox1SelectedItem As String = ComboBox2.SelectedItem.ToString()
        Dim comboBox2SelectedItem As String = ComboBox3.SelectedItem.ToString()

        ' Combine the selected items into a single string to form the control name
        Dim controlName As String = comboBox1SelectedItem & comboBox2SelectedItem

        ' Find the control with the specified name
        Dim controlArray() As Control = Me.Controls.Find(controlName, True)

        ' Check if the control is found
        If controlArray.Length > 0 AndAlso TypeOf controlArray(0) Is Label Then ' Cast the control to a Label object
            Dim labelControl As Label = CType(controlArray(0), Label)

            ' Change the background color of the label
            labelControl.BackColor = Color.FromArgb(155, 89, 182)

        End If

        selectlatestreceipt()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        admin.Show()

    End Sub
End Class