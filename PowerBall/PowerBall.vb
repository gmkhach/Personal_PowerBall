Public Class PowerBall

    Public Main As MainDrum
    Public Power As PowerBallDrum

    Public Sub PowerBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main = New MainDrum
        Power = New PowerBallDrum
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click

        For Each myLabel As Label In MainNumbers.Controls
            myLabel.Text = Main.Dispense().Number()
        Next

        Label6.Text = Power.Dispense().Number()
    End Sub

End Class
