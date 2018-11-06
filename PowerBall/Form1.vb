Public Class PowerBall

    Public Main As MainDrum
    Public Power As PowerBallDrum

    Public Sub PowerBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main = New MainDrum
        Power = New PowerBallDrum
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Label1.Text = Main.Dispense().Number()
        Label2.Text = Main.Dispense().Number()
        Label3.Text = Main.Dispense().Number()
        Label4.Text = Main.Dispense().Number()
        Label5.Text = Main.Dispense().Number()
        Label6.Text = Power.Dispense().Number()
    End Sub

End Class
