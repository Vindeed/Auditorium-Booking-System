Public Class Welcome
    'Date Last Edited: 26/06/22
    'Software Engineer: Vince Shrestha
    'Team: 12SDD05
    'Description: Interface that welcomes the client to the program

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

End Class
