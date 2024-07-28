Public Class UpdateBookings
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Gathers general booking information.

    Private Sub UpdateBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hides up and down arrows from numeric up and down to prevent confusion
        RemoveArrows(nudPhone)

    End Sub

    Private Sub btnUpdateSeats_Click(sender As Object, e As EventArgs) Handles btnUpdateSeats.Click
        txtFName.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtFName.Text.Trim.ToLower)
        txtLName.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtLName.Text.Trim.ToLower)
        'Converts the text so that the first letter of every word is capitalised and every other letter is lowercase.


        If txtFName.TextLength <= 2 Or txtLName.TextLength <= 2 Or dtpDOB.Value <= #1/1/1900# Then 'maybe add a phone number check later
            MessageBox.Show("Invalid or incomplete information has been inputted. Try again with complete information.")

        Else
            FName = txtFName.Text
            LName = txtLName.Text
            DOB = dtpDOB.Value
            Phone = nudPhone.Value

            Me.Close()
            UpdateSeats.Show()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        UpdateRecord.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
