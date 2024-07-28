Public Class Delete

    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description:

    'maybe have a delete all button

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hides up and down arrows from numeric up and down to prevent confusion
        RemoveArrows(nudDelete)
        nudDelete.Maximum = arrCurrentMaxValue + 1
        nudDelete.Minimum = 1

        Dim i As Integer = 0

        'Populates DataGridView with array of records from the random file
        PopulateDGV(dgvDisplay)

        'Disables sorting when clicking on a header
        DisableSorting(dgvDisplay)

        'Changes row height
        ChangeHeight(dgvDisplay)

        'Excludes time from the date
        ChangeDateFormat(dgvDisplay)


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim bytRecToBeDeleted = nudDelete.Value - 1

        Dim tempArrClients(39) As sClient
        Dim counter As Byte = 0
        Dim index As Byte = 0

        'Confirmation
        If MsgBox("Would you like to delete the client's information?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            'Skipping adding the deleted record
            While counter <= arrCurrentMaxValue
                If counter = bytRecToBeDeleted Then
                    counter += 1

                Else
                    tempArrClients(Index) = arrClients(counter)

                    counter += 1
                    Index += 1

                End If

            End While

            ReDim arrClients(39)

            arrClients = tempArrClients
            ReDim tempArrClients(39)

            dgvDisplay.Rows.Clear()
            For i = 0 To arrCurrentMaxValue - 2 '-2 because last value will be null
                dgvDisplay.Rows.Add(arrClients(i).FName, arrClients(i).LName, arrClients(i).DOB, arrClients(i).Phone, arrClients(i).Payment)

            Next
            ChangeHeight(dgvDisplay)

            Call CheckForLastRecord()

            nudDelete.Maximum = arrCurrentMaxValue

        End If

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        'Writing to file - save for final product or testing
        Kill("Bookings.dat")
        FileOpen(1, "Bookings.dat", OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite, shRecClientSize)
        For i = 0 To arrCurrentMaxValue - 1
            FilePut(1, arrClients(i), i + 1)
        Next
        FileClose(1)

        Me.Close()
        Home.Show()

    End Sub

    Private Sub btnEnd_Click_1(sender As Object, e As EventArgs) Handles btnEnd.Click
        'Writing to file - save for final product or testing
        Kill("Bookings.dat")
        FileOpen(1, "Bookings.dat", OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite, shRecClientSize)
        For i = 0 To arrCurrentMaxValue - 1
            FilePut(1, arrClients(i), i + 1)
        Next
        FileClose(1)

        End

    End Sub

    Private Sub CheckForLastRecord()
        If arrCurrentMaxValue = 1 Then
            MessageBox.Show("There a no more clients in the file.")
            btnDelete.Enabled = False
            arrCurrentMaxValue -= 1

        Else
            arrCurrentMaxValue -= 1

        End If

    End Sub

End Class
