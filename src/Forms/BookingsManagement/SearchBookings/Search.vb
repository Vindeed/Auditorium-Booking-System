Public Class Search
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Finds information from the array of records based off user inputs

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disables sorting when clicking on a header
        DisableSorting(dgvDisplay)

        'Excludes time from the date
        ChangeDateFormat(dgvDisplay)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Make a function later
        'Add searches for other fields
        If txtSearch.Text.Trim = "" Then
            dgvDisplay.Rows.Clear()
            MessageBox.Show("The search criteria is empty. Enter a name to search.")

        ElseIf txtSearch.Text.Trim.Length < 3 Then
            dgvDisplay.Rows.Clear()
            MessageBox.Show("The search criteria is too short for a name. Enter a name to search.")

        Else
            dgvDisplay.Rows.Clear()
            Call Search()

            If dgvDisplay.RowCount = 0 Then
                MessageBox.Show("There was no result for the search criteria. Make sure your spelling is correct.")
                'If there is no addition, the system will provide a message to the user telling them there is no such member based on their search criteria

            End If

            'Changes height of the rows
            ChangeHeight(dgvDisplay)

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub Search()
        For i = 0 To arrCurrentMaxValue - 1 Step 1
            If txtSearch.Text.ToLower.Trim = arrClients(i).FName.ToLower Or txtSearch.Text.ToLower.Trim = arrClients(i).LName.ToLower Then
                dgvDisplay.Rows.Add(arrClients(i).FName, arrClients(i).LName, arrClients(i).DOB, arrClients(i).Phone, arrClients(i).Payment)
                'If there is an exact match between the trimmed search criteria and the array then it will add the member's information to the DataGridView

            ElseIf arrClients(i).FName.ToLower.Contains(txtSearch.Text.ToLower.Trim) Or arrClients(i).LName.ToLower.Contains(txtSearch.Text.ToLower.Trim) Then
                dgvDisplay.Rows.Add(arrClients(i).FName, arrClients(i).LName, arrClients(i).DOB, arrClients(i).Phone, arrClients(i).Payment)
                'Looks if the search criteria is anywhere in the array then if true adds

            End If

        Next i

    End Sub

End Class
