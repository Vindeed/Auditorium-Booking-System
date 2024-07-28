Public Class Home
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Hub where the user can choose what action they need to complete.

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempArrClients(39) As sClient
        arrClients = tempArrClients
        'Resetting the array of records to read/put new records into it from the file

        FileOpen(1, "Bookings.dat", OpenMode.Random, OpenAccess.Read, OpenShare.LockRead, shRecClientSize)
        Dim shFileLength As Short = FileLen("Bookings.dat")
        Dim bytTotalRecs As Integer = Convert.ToInt32(shFileLength / shRecClientSize)

        'Putting records from file into the array of records
        For RecNum = 0 To bytTotalRecs - 1
            FileGet(1, arrClients(RecNum), RecNum + 1)

        Next

        FileClose(1)

        arrCurrentMaxValue = bytTotalRecs

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Me.Close()
        Input.Show()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Close()
        Delete.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Close()
        UpdateRecord.Show()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.Close()
        Search.Show()

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Me.Close()
        Sort.Show()

    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Close()
        Help.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
