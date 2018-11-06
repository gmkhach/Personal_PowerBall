Public Class Drum

    Public Sub New(ByVal size As Integer)
        drum = New Ball(size) {}
        Me.size = size
        For i = 0 To size - 1
            drum(i) = New Ball(i + 1)
        Next
    End Sub

    Private drum() As Ball
    Private size As Integer

    Dim rnd As New Random()

    Public Function Dispense() As Ball
        Dim i As Integer
        Dim dispensedBall As Ball = Nothing

        'Randomly select a ball from the drum
        Do While IsNothing(dispensedBall)
            i = rnd.Next(0, size - 1)
            'Check if the ball has already been selected
            If Not IsNothing(drum(i)) Then
                dispensedBall = drum(i)
            End If
        Loop

        'Remove the selected ball form the drum
        drum(i) = Nothing

        'Return the selected ball
        Return dispensedBall
    End Function

End Class
