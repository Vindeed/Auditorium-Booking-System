Public Class UpdateRecord
    'Date Last Edited: 26/06/26
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Allows the user to choose a record to update.

    Private Sub UpdateRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudUpdate.Minimum = 1
        nudUpdate.Maximum = arrCurrentMaxValue

        'Hides up and down arrows from numeric up and down to prevent confusion
        RemoveArrows(nudUpdate)

        'Disables sorting when clicking on a header
        DisableSorting(dgvDisplay)

        'Excludes time from the date
        ChangeDateFormat(dgvDisplay)

        'Changes height of the rows
        ChangeHeight(dgvDisplay)

        'Populates DataGridView with array of records from the random file
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub btnUpdateSeats_Click(sender As Object, e As EventArgs) Handles btnUpdateSeats.Click
        bytRecToBeUpdated = nudUpdate.Value - 1

        Me.Close()
        UpdateBookings.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()

    End Sub
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
