Public Class Login
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Provides a login interface for a set username and random password. If the username and password are correct then the user may go to the information screen.

    'DECLARATION
    Dim intNumber As Integer 'Using to create random password

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        btnCreate.Select()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        intNumber = CInt(Int(10000 * Rnd() + 1000))
        'Creates a random number password that is at least above 1000 and below 100000

        MessageBox.Show("You username is 'username' and password is " & "'" & intNumber & "'.")

        btnCreate.Enabled = False

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "username" And txtPassword.Text = intNumber.ToString Then
            Welcome.Show()
            Me.Hide()

        Else
            MessageBox.Show("The username or password that has been entered is incorrect. Please try again.")

        End If

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
