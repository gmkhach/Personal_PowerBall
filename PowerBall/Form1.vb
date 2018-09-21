Public Class PowerBall
    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Dim rnd As New Random()
        Label2.Text = rnd.Next(69)
        Label3.Text = rnd.Next(69)
        Label4.Text = rnd.Next(69)
        Label1.Text = rnd.Next(69)
        Label5.Text = rnd.Next(69)
        Label6.Text = rnd.Next(26)
    End Sub
End Class
