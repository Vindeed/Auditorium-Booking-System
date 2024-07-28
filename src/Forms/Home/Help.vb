Public Class Help
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Provides help for the user.

    Private Sub tvwScreens_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwScreens.AfterSelect
        Select Case e.Node.Name
            Case "nodeAdd"
                Call addBookingText()

            Case "nodeUpdate"
                Call updateBookingText()

            Case "nodeDelete"
                Call deleteBookingText()

            Case "nodeSearch"
                Call searchBookingText()

            Case "nodeSort"
                Call sortBookingText()

        End Select

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    'The formatting on the strings below is the only simple way to format them correct on the rtb.
    Private Sub addBookingText()
        rtbHelp.Text = "Once you have clicked the 'ADD BOOKING' button you will be taken to another screen. This screen is the first of 4 that are required to add a booking. From here, input the necessary information into its respective input control. The control will be next to a label listing the type of information that you need to insert. Click on the 'CANCEL' button if you wish to remove all the current information from the input fields 
                                
Once the necessary information has been inputted, click on the 'CHOOSE SEATS' button to choose the seats that the client will occupy during the performance.
If incorrect information has been inputted, the system will ask you to reconsider your choices and not take you to the next screen.

If all the information is correct, you will be taken to a seating screen.

On this screen, you can click on the reserve that the client wishes. There are 40 circles that can each individually be clicked to reserve a seat. These seats are in the same arrangement as the symposium with the rows and headers listing their position where 'A' seats are closest to the stage and 'D' seats are the furthest. 

Already reserved seats will be shown as red circles and free seats are listed as white circles.
 Once you click on a free seat, the colour will change to green indicating that the seat will be reserved by the client once the payment has been initiated. You can reserve as many seats as there are available provided that you at least select one seat. If you do not select a seat then you will not be able to progress.
Once the client’s desired seats are selected, you will be notified of the cost and be taken to the payment screen. 

The payment will be listed above the input fields. You will be directed to input the client’s credit card details including their name on the credit card, the credit card number, the expiry date of the credit card, and the credit card’s pin. The input control will be next to a label that describes the data that needs to be inputted into the control. 

Once the correct information has been inputted, you can click on the 'CONFIRM' button. This initiates a confirmation pop-up which if you confirm will take you back to the home screen with a new booking.
If you decline the pop-up, you will be taken back to the payment screen.

If the information does not comply with credit card conventions then the system will notify you and ask you to complete the inputs again."
    End Sub

    Private Sub updateBookingText()
        rtbHelp.Text = "Once you have clicked the 'UPDATE' button you will be taken to another screen.

From here you can view the table to find a record number that you wish to update.
The table is a display of the current bookings in the system with headers for all of the client’s information except for their seat number/s or their credit card information.

Find the record number of the client’s booking that you wish to update then input that record number into the control next to the label that reads 'RECORD NUMBER:'.

Click on the 'UPDATE SEATS' button to be taken to the next screen.

This screen is the first of 4 that are required to update a booking.
From here, input the necessary information into its respective input control. The control will be next to a label listing the type of information that you need to insert.
Click on the 'CANCEL' button if you wish to remove all the current information from the input fields

Once the necessary information has been inputted, click on the 'CHOOSE SEATS' button to choose the seats that the client will occupy during the performance.
If incorrect information has been inputted, the system will ask you to reconsider your choices and not take you to the next screen.

If all the information is correct, you will be taken to the next screen.

In this screen, you can click on the reserve that the client wishes. There are 40 circles that each can individually be clicked on that can reserve a seat. These seats are in the same arrangement as the symposium with the rows and headers listing their position where 'A' seats are closest to the stage and 'D' seats are the furthest. 

Already reserved seats will be shown as red circles and free seats are listed as white circles.
Once you click on a free seat, the colour will change to green indicating that the seat will be reserved by the client once the payment has been initiated. You can reserve as many seats as there are available provided that you at least select one seat. If you do not select a seat then you will not be able to progress.
Once the client’s desired seats are selected, you will be notified of the cost and be taken to the payment screen.

The payment will be listed above the input fields. You will be directed to input the client’s credit card details including their name on the credit card, the credit card number, the expiry date of the credit card, and the credit card’s pin. The input control will be next to a label that describes the data that needs to be inputted into the control. 

Once the correct information has been inputted, you can click on the 'CONFIRM' button. This initiates a confirmation pop-up which if you confirm will take you back to the home screen with a new booking.
If you decline the pop-up, you will be taken back to the payment screen.

If the information does not comply with credit card conventions then the system will notify you and ask you to complete the inputs again."

    End Sub

    Private Sub deleteBookingText()
        rtbHelp.Text = "Once you have clicked the 'DELETE' button you will be taken to another screen.

The table is a display of the current bookings in the system with headers for all of the client’s information except for their seat number/s or their credit card information.

Find the record number of the client’s booking that you wish to delete. The top row will have the booking with a record number of 1.
Input that record number into the control next to the label that reads 'RECORD NUMBER:'.
Click on the 'DELETE' button to delete the desired client’s booking. 
Once you have clicked on the button and confirmed your choice, you can either delete more clients’ bookings from the system, return to the home screen with the 'HOME' button, or end the program with the 'END' button. 

A deleted booking will free up space in the system for another booking."

    End Sub

    Private Sub searchBookingText()
        rtbHelp.Text = "Once you have clicked the 'Search' button you will be taken to another screen.
There will be a search bar and a table.

Input a search term into the textbox that has the icon of a magnifying glass to the right of it. The system searches for only the first and last names of clients and only each of them individually so factor that into your search term. Your search term must be at least 3 characters long. 

If there are results for your search term, the table will be filled with the bookings that fit your search term.
If there are no search results or there has been an error in your search term, the system will ask you to search again.

To leave this screen either click on the 'END' button or the 'BACK' button.
You are permitted to make more than one search on opening this screen."

    End Sub

    Private Sub sortBookingText()
        rtbHelp.Text = "Once you have clicked the 'Search' button you will be taken to another screen.
The table is a display of the current bookings in the system with headers for all of the client’s information except for their seat number/s or their credit card information.

To sort the bookings, click on a header such as 'First Name' or 'Phone Number.' When you click on the header, the entire table will be sorted by the field that the header lists. The first time you click on the header the sort will be descending and on the second it will be ascending. From then this will alternate each time you click.

The 'BACK' and 'END' buttons are slightly different on this screen. If you click on either of these, a confirmation box will pop up asking you if you want the information to be sorted when you leave the screen. Either accept or deny depending on your preference."
    End Sub

End Class
