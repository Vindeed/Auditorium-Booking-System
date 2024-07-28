Public Class Sort
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Allows the user to sort bookings and save their sorted arrays.

    'DECLARATIONS
    Dim sortTypeFName As Boolean = False
    Dim sortTypeLName As Boolean = False
    Dim sortTypeDOB As Boolean = False
    Dim sortTypePhone As Boolean = False
    Dim sortTypePayment As Boolean = False

    Dim Sorted As Integer = 0
    Dim Unsorted As Integer = arrCurrentMaxValue - 1
    Dim bytMaxPosition As Byte
    Dim bytMinPosition As Byte


    Private Sub Sort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Excludes time from the date
        ChangeDateFormat(dgvDisplay)

        'Disables sorting when clicking on a header
        DisableSorting(dgvDisplay)

        'Populates DataGridView with array of records
        PopulateDGV(dgvDisplay)

        'Allows headers to have different visual styles
        dgvDisplay.EnableHeadersVisualStyles = False

    End Sub

    Private Sub dgvDisplay_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDisplay.ColumnHeaderMouseClick
        'Upon clicking on the header, sorts the data then switches the sort for the next time
        'The boolean value of True indicates an Ascending sort and vice versa
        Call SortMethod(e.ColumnIndex)

        'Changing backcolour of sorted column header for user input feedback
        For i = 0 To 4
            Me.dgvDisplay.Columns(i).HeaderCell.Style.BackColor = Color.White

        Next

        Me.dgvDisplay.Columns(e.ColumnIndex).HeaderCell.Style.BackColor = Color.AliceBlue

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Would you like the database to remain sorted?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            'Saving the array of records to the file
            Kill("Bookings.dat")
            FileOpen(1, "Bookings.dat", OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite, shRecClientSize)

            For i = 0 To arrCurrentMaxValue - 1
                FilePut(1, arrClients(i), i + 1)
            Next

            FileClose(1)

            Home.Show()
            Me.Close()

        Else
            Home.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        If MsgBox("Would you like the database to remain in this sorted after you end the application?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            'Saving the array of records to the file
            Kill("Bookings.dat")
            FileOpen(1, "Bookings.dat", OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite, shRecClientSize)

            For i = 0 To arrCurrentMaxValue - 1
                FilePut(1, arrClients(i), i + 1)
            Next

            FileClose(1)

            End

        Else
            End

        End If

    End Sub


    Private Sub SortMethod(columnIndex As Integer)
        Select Case columnIndex
            Case 0
                If sortTypeFName = True Then
                    Call AscendSortFName()
                    sortTypeFName = False

                Else
                    Call DescendSortFName()
                    sortTypeFName = True

                End If

            Case 1
                If sortTypeLName = True Then
                    Call AscendSortLName()
                    sortTypeLName = False

                Else
                    Call DescendSortLName()
                    sortTypeLName = True

                End If

            Case 2
                If sortTypeDOB = True Then
                    Call AscendSortDOB()
                    sortTypeDOB = False

                Else
                    Call DescendSortDOB()
                    sortTypeDOB = True

                End If

            Case 3
                If sortTypePhone = True Then
                    Call AscendSortPhone()
                    sortTypePhone = False

                Else
                    Call DescendSortPhone()
                    sortTypePhone = True

                End If

            Case 4
                If sortTypePayment = True Then
                    Call AscendSortPayment()
                    sortTypePayment = False

                Else
                    Call DescendSortPayment()
                    sortTypePayment = True

                End If

        End Select

    End Sub

    Private Sub AscendSortFName()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim maxString As String

        While Sorted <> arrCurrentMaxValue
            maxString = arrClients(0).FName
            bytMaxPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).FName > maxString Then
                    maxString = arrClients(count).FName
                    bytMaxPosition = count

                End If

            Next

            If bytMaxPosition <> Unsorted Then
                temp = arrClients(bytMaxPosition)
                arrClients(bytMaxPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1


        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub AscendSortLName()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim maxString As String

        While Sorted <> arrCurrentMaxValue
            maxString = arrClients(0).LName
            bytMaxPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).LName > maxString Then
                    maxString = arrClients(count).LName
                    bytMaxPosition = count

                End If

            Next

            If bytMaxPosition <> Unsorted Then
                temp = arrClients(bytMaxPosition)
                arrClients(bytMaxPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub AscendSortDOB()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim maxDate As Date

        While Sorted <> arrCurrentMaxValue
            maxDate = arrClients(0).DOB
            bytMaxPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).DOB > maxDate Then
                    maxDate = arrClients(count).DOB
                    bytMaxPosition = count

                End If

            Next

            If bytMaxPosition <> Unsorted Then
                temp = arrClients(bytMaxPosition)
                arrClients(bytMaxPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub AscendSortPhone()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim maxValue As Long

        While Sorted <> arrCurrentMaxValue
            maxValue = arrClients(0).Phone
            bytMaxPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).Phone > maxValue Then
                    maxValue = arrClients(count).Phone
                    bytMaxPosition = count

                End If

            Next

            If bytMaxPosition <> Unsorted Then
                temp = arrClients(bytMaxPosition)
                arrClients(bytMaxPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub AscendSortPayment()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim maxValue As Decimal

        While Sorted <> arrCurrentMaxValue
            maxValue = arrClients(0).Payment
            bytMaxPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).Payment > maxValue Then
                    maxValue = arrClients(count).Payment
                    bytMaxPosition = count

                End If

            Next

            If bytMaxPosition <> Unsorted Then
                temp = arrClients(bytMaxPosition)
                arrClients(bytMaxPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub DescendSortFName()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim minValue As String

        While Sorted <> arrCurrentMaxValue
            minValue = arrClients(0).FName
            bytMinPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).FName < minValue Then
                    minValue = arrClients(count).FName
                    bytMinPosition = count

                End If

            Next

            If bytMinPosition <> Unsorted Then
                temp = arrClients(bytMinPosition)
                arrClients(bytMinPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub DescendSortLName()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim minValue As String

        While Sorted <> arrCurrentMaxValue
            minValue = arrClients(0).LName
            bytMinPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).LName < minValue Then
                    minValue = arrClients(count).LName
                    bytMinPosition = count

                End If

            Next

            If bytMinPosition <> Unsorted Then
                temp = arrClients(bytMinPosition)
                arrClients(bytMinPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub DescendSortDOB()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim minDate As Date

        While Sorted <> arrCurrentMaxValue
            minDate = arrClients(0).DOB
            bytMinPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).DOB < minDate Then
                    minDate = arrClients(count).DOB
                    bytMinPosition = count

                End If

            Next

            If bytMinPosition <> Unsorted Then
                temp = arrClients(bytMinPosition)
                arrClients(bytMinPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub DescendSortPhone()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim minValue As Long

        While Sorted <> arrCurrentMaxValue
            minValue = arrClients(0).Phone
            bytMinPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).Phone < minValue Then
                    minValue = arrClients(count).Phone
                    bytMinPosition = count

                End If

            Next

            If bytMinPosition <> Unsorted Then
                temp = arrClients(bytMinPosition)
                arrClients(bytMinPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

    Private Sub DescendSortPayment()
        'Selection Sort
        Dim temp As New sClient
        Sorted = 0
        Unsorted = arrCurrentMaxValue - 1

        Dim minValue As String

        While Sorted <> arrCurrentMaxValue
            minValue = arrClients(0).Payment
            bytMinPosition = 0

            For count = 1 To Unsorted
                If arrClients(count).Payment < minValue Then
                    minValue = arrClients(count).Payment
                    bytMinPosition = count

                End If

            Next

            If bytMinPosition <> Unsorted Then
                temp = arrClients(bytMinPosition)
                arrClients(bytMinPosition) = arrClients(Unsorted)
                arrClients(Unsorted) = temp

            End If

            Sorted += 1
            Unsorted -= 1

        End While

        dgvDisplay.Rows.Clear()
        PopulateDGV(dgvDisplay)

    End Sub

End Class
