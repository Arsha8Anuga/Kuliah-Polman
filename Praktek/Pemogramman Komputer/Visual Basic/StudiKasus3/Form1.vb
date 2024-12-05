Public Class Form1
    Private Sub PerkalianBtn_Click(sender As Object, e As EventArgs) Handles PerkalianBtn.Click

        PerkalianVarHasil.Text = 0

        If PerkalianVar1.Text = Nothing Then

            PerkalianVar1.Text = 0

        End If

        If PerkalianVar2.Text = Nothing Then

            PerkalianVar2.Text = 0

        End If

        Perkalian(PerkalianVar1.Text, PerkalianVar2.Text, PerkalianVarHasil.Text)

    End Sub

    Private Sub Perkalian(args1 As Integer, args2 As Integer, args3 As Integer)

        If args2 <> 0 Then
            args2 -= 1

            args3 += args1

            Perkalian(args1, args2, args3)

        Else

            PerkalianVarHasil.Text = args3


        End If

    End Sub

    Private Sub PerpangkatanBtn_Click(sender As Object, e As EventArgs) Handles PerpangkatanBtn.Click

        If PerpangkatanVar1.Text = Nothing Then

            PerpangkatanVar1.Text = 0

        End If

        If PerpangkatanVar2.Text = Nothing Then

            PerpangkatanVar2.Text = 0

        End If

        PerpangkatanHasil.Text = Perpangkatan(PerpangkatanVar1.Text, PerpangkatanVar2.Text)

    End Sub

    Private Function Perpangkatan(args1 As Integer, args2 As Integer) As Integer

        If args2 <> 0 Then


            Return args1 * Perpangkatan(args1, args2 - 1)

        Else

            Return 1


        End If

    End Function


    Private Function Akar(radicand As Double, index As Double) As Double

        If index Mod 2 = 0 AndAlso radicand < 0 Then
            MsgBox("Radicand cannot be negative for even roots.")
            Return Double.NaN
        End If

        Dim numberRange As Double() = GuestNumber(radicand, index)
        Dim upperBound As Double = numberRange(0)
        Dim lowerBound As Double = numberRange(1)

        Dim midPoint As Double
        Dim tolerance As Double = 0.000001
        Dim maxIterations As Integer = 1000
        Dim iterationCount As Integer = 0


        If radicand = 0 Then
            Return 0
        End If


        While iterationCount < maxIterations
            midPoint = (upperBound + lowerBound) / 2
            Dim midPointPower As Double = Perpangkatan(midPoint, index)


            Debug.WriteLine($"Iteration: {iterationCount}, MidPoint: {midPoint}, MidPointPower: {midPointPower}, LowerBound: {lowerBound}, UpperBound: {upperBound}")

            If Math.Abs(midPointPower - radicand) < tolerance Then
                Return midPoint
            ElseIf midPointPower < radicand Then
                lowerBound = midPoint
            Else
                upperBound = midPoint
            End If


            If Math.Abs(upperBound - lowerBound) < tolerance Then
                Return midPoint
            End If

            iterationCount += 1
        End While


        Return midPoint
    End Function

    Private Function GuestNumber(patokan As Double, index As Double) As Double()
        Dim lowerBound As Double = 0
        Dim upperBound As Double = 1


        If patokan < 0 Then
            Return New Double() {0, 0}
        End If


        If patokan > 1 Then
            While Perpangkatan(upperBound, index) < patokan
                upperBound *= 2
            End While
        Else
            upperBound = 1
        End If


        Return New Double() {upperBound, lowerBound}
    End Function


    Private Function Logarithm(value As Double, base As Double) As Double

        If value <= 0 Or base <= 0 Then
            MsgBox("Value dan base harus lebih besar dari 0.")
            Return 0
        End If


        If base = 1 Then
            MsgBox("Basis tidak boleh sama dengan 1.")
            Return 0
        End If

        Dim low As Double = 0
        Dim high As Double = value
        Dim midPoint As Double
        Dim tolerance As Double = 0.00001
        Dim maxIterations As Integer = 1000
        Dim iterationCount As Integer = 0

        While True
            midPoint = (low + high) / 2
            Dim midPointPower As Double = Perpangkatan(base, midPoint)

            If Math.Abs(midPointPower - value) < tolerance Then
                Exit While
            ElseIf midPointPower < value Then
                low = midPoint
            Else
                high = midPoint
            End If

            iterationCount += 1
        End While

        Return midPoint
    End Function

    Private Function Faktorial(n As Integer) As Long

        If n < 0 Then
            MsgBox("Faktorial tidak terdefinisi untuk bilangan negatif.")
            Return 0
        End If

        If n = 0 Then
            Return 1
        Else

            Return n * Faktorial(n - 1)
        End If
    End Function

    Private Sub AkarBtn_Click(sender As Object, e As EventArgs) Handles AkarBtn.Click

        AkarHasil.Text = Akar(AkarVar2.Text, AkarVar1.Text)

    End Sub

    Private Sub LogBtn_Click(sender As Object, e As EventArgs) Handles LogBtn.Click
        LogHasil.Text = Logarithm(LogVar2.Text, LogVar1.Text)
    End Sub

    Private Sub FactorBtn_Click(sender As Object, e As EventArgs) Handles FactorBtn.Click

        FactorHasil.Text = Faktorial(FactorVar1.Text)

    End Sub
End Class
