Public Class SeatPlan
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Allows the user to select seats for bookings.

    'DECLARATIONS
    Dim c As Control

    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim selectedIcon As New System.Drawing.Bitmap(My.Resources.Selected)
    Dim reservedIcon As New System.Drawing.Bitmap(My.Resources.Reserved)

    Private Sub SeatPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).SizeMode = PictureBoxSizeMode.Zoom
                CType(c, PictureBox).Image = availableIcon 'Changes every picturebox to an available icon

                AddHandler c.Click, AddressOf pictureboxClick 'adds a link between every picturebox and the click event

                'Changing reserved seats to reserved icons by comparing AcessibleName to the SeatsBooked in the array of recorrds
                For i = 0 To 39
                    For j = 0 To 39
                        If (arrClients(i).SeatsBooked IsNot Nothing AndAlso arrClients(i).SeatsBooked.Count > 0) Then
                            If arrClients(i).SeatsBooked(j) = CType(c, PictureBox).AccessibleName Then
                                CType(c, PictureBox).Image = reservedIcon

                            End If

                        End If

                    Next

                Next

            End If

        Next

    End Sub

    Private Sub pictureboxClick(sender As Object, e As EventArgs)
        'Click event which turns available seats to selected seats and vice versa
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = selectedIcon

        ElseIf CType(sender, PictureBox).Image Is selectedIcon Then
            CType(sender, PictureBox).Image = availableIcon

        End If

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim index As Byte = 0
        Dim pboxCheck As Byte = 0
        Dim arrSeatsBooked(39) As Byte

        If MsgBox("Would you like to confirm the client's seats?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each c In Me.Controls 'This for loop will check if the user has selected any picture boxes
                If TypeOf (c) Is PictureBox Then
                    If CType(c, PictureBox).Image Is selectedIcon Then
                        pboxCheck += 1

                    End If

                End If

            Next

            If pboxCheck > 0 Then 'Checking if a seat has been selected
                For Each c In Me.Controls
                    If TypeOf (c) Is PictureBox Then
                        If CType(c, PictureBox).Image Is selectedIcon Then
                            arrSeatsBooked(index) = CType(c, PictureBox).AccessibleName

                            index += 1

                        End If

                    End If

                Next

                SeatsBooked = arrSeatsBooked
                Payment = index * 50.99

                'Confirmation messagebox
                MessageBox.Show("You will now be taken to a payment screen. The cost will be " & Payment & ".")
                Me.Close()
                Transaction.Show()


            Else
                MessageBox.Show("No seats have been selected. Select a seat to continue to payment.")

            End If

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Input.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
