Public Class PowerBall

    Public Main As Drum
    Public Power As Drum

    Public Sub PowerBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main = New Drum(69)
        Power = New Drum(26)
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click

        'Populating the Main numbers' labels
        For Each myLabel As Label In MainNumbers.Controls
            myLabel.Text = Main.Dispense().Number()
        Next

        'Populating the powerball label
        Label6.Text = Power.Dispense().Number()

    End Sub

End Class
