Public Class PowerBall
    Dim rnd As New Random()
    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Label1.Text = rnd.Next(69)
        Label2.Text = rnd.Next(69)
        Label3.Text = rnd.Next(69)
        Label4.Text = rnd.Next(69)
        Label5.Text = rnd.Next(69)
        Label6.Text = rnd.Next(26)
    End Sub
End Class
