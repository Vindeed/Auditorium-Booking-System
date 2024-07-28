Public Class UpdateTransaction
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Gathers transaction information then finalises the updated booking by saving it into the array.

    Private Sub UpdateTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPaymentValue.Text = Payment
        dtpExpiry.CustomFormat = "MM, yyyy"
        dtpExpiry.Format = DateTimePickerFormat.Custom

        'Hides up and down arrows from numeric up and down to prevent confusion
        RemoveArrows(nudCCNumber)
        RemoveArrows(nudSecurity)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        txtName.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.Trim.ToLower)

        If MsgBox("Would you like to confirm the client's information?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            AppendArray()

            'Writing to file - save for final product or testing
            Kill("Bookings.dat")
            FileOpen(1, "Bookings.dat", OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite, shRecClientSize)

            For i = 0 To arrCurrentMaxValue - 1
                FilePut(1, arrClients(i), i + 1)
            Next

            FileClose(1)

            Home.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        UpdateSeats.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub


    Private Sub AppendArray()
        arrClients(bytRecToBeUpdated).FName = FName
        arrClients(bytRecToBeUpdated).LName = LName
        arrClients(bytRecToBeUpdated).DOB = DOB
        arrClients(bytRecToBeUpdated).Phone = Phone
        arrClients(bytRecToBeUpdated).SeatsBooked = SeatsBooked
        arrClients(bytRecToBeUpdated).Payment = Payment
        arrClients(bytRecToBeUpdated).ccNumber = nudCCNumber.Value
        arrClients(bytRecToBeUpdated).ccName = txtName.Text
        arrClients(bytRecToBeUpdated).ccPin = nudSecurity.Value
        arrClients(bytRecToBeUpdated).ccExpiry = dtpExpiry.Value

    End Sub

End Class
