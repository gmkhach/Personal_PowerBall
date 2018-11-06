Public Class PowerBallDrum

    Public Sub New()
        For i As Integer = 0 To 25
            Drum(i) = New Ball(i + 1)
        Next
    End Sub

    Public Drum(26) As Ball
    Dim rnd As New Random()

    Public Function Dispense()
        Dim i As Integer
        Dim dispensedBall As Ball = Nothing

        'Randomly select a ball from the drum
        Do While IsNothing(dispensedBall)
            i = rnd.Next(0, 25)
            'Check if the ball has already been selected
            If Not IsNothing(Drum(i)) Then
                dispensedBall = Drum(i)
            End If
        Loop

        'Remove the selected ball form the drum
        Drum(i) = Nothing

        'Return the selected ball
        Return dispensedBall
    End Function

End Class
