'Brandon Barrera
'RCET0265
'Spring 2025
'https://github.com/BrandLeBar/DinerMenu.git

Option Explicit On
Option Strict On
Option Compare Text

Public Class DinerMenuForm

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = ("~ Soup of the day ~" & vbNewLine &
             vbNewLine & "This is my special soup made with the broth of" & vbNewLine _
             & "a thousand burgers with tiny burgers floating around in it")
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = ("~ The Primordial Salad  ~" & vbNewLine &
             vbNewLine & "This salad was created from the same event that kick started" & vbNewLine _
             & "the universe, the big bang. Hence the name" &
             vbNewLine & "its flavors' are indiscernible")
    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = ("~ Frank's Funky Fish ~" & vbNewLine &
             vbNewLine & "Our head chef Frank has his own hatchary, this is the result" &
             vbNewLine & "of years of hard work, blood, sweat, and" &
             vbNewLine & "not tears but even more sweat")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
