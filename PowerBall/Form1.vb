Public Class PowerBall

    Private Sub PowerBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MainDrum As MainDrum
        Dim PowerBallDrum As PowerBallDrum
    End Sub


    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Label1.Text =
        Label2.Text = Rnd.Next(69)
        Label3.Text = rnd.Next(69)
        Label4.Text = rnd.Next(69)
        Label5.Text = rnd.Next(69)
        Label6.Text = rnd.Next(26)
    End Sub


End Class
