'Shaw, Doyle
'RCET0265
'Fall 2020
'Diner Menu Program
'https://github.com/shawdoyl/DinerMenu.git

Public Class Form1



    Public displayText As String
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FishButton_MouseHover(sender As Object, e As EventArgs) Handles FishButton.MouseHover
        displayText = "~Fish of the Day~" & vbNewLine & vbNewLine & "A Herring seasoned with coconut" &
            "milk. Hand delivered by a African or European Swallow of your choice. Coconut shells are" &
            "given to poor squires in need of them for their knights."
        DisplaySpecialLabel.Text = displayText
        My.Computer.Audio.Play(My.Resources.Resource1.migrate,
            AudioPlayMode.Background)
    End Sub

    Private Sub SaladButton_MouseHover(sender As Object, e As EventArgs) Handles SaladButton.MouseHover
        displayText = "~Salad of the Day~" & vbNewLine & vbNewLine & "A beautiful Caeser's salad, " &
            "prepared by the Knights Who Say Ni! Garnished with a branch from the shrubbery gifted to" &
            " them by King Arthur himself."
        DisplaySpecialLabel.Text = displayText
        My.Computer.Audio.Play(My.Resources.Resource1.ni,
            AudioPlayMode.Background)
    End Sub

    Private Sub SoupButton_MouseHover(sender As Object, e As EventArgs) Handles SoupButton.MouseHover
        displayText = "~Soup of the Day~" & vbNewLine & vbNewLine & "Rabbit Stew from Caerbonnig."
        WarningLabel.ForeColor = Color.Red
        WarningLabel.Text = "WARNING! May still have bits of the Holy Hand Grenade of Antioch"
        DisplaySpecialLabel.Text = displayText
        My.Computer.Audio.Play(My.Resources.Resource1.HolyHandGrenade,
            AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MouseLeave_Button(sender As Object, e As EventArgs) Handles SaladButton.MouseLeave, SoupButton.MouseLeave, FishButton.MouseLeave
        displayText = ""
        DisplaySpecialLabel.Text = displayText
        WarningLabel.Text = displayText
        My.Computer.Audio.Stop()
    End Sub

End Class
