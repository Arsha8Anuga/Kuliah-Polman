Public Class studikasus1TebakHuruf

    Dim rand As New Random()

    Dim strLetters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopkrstuvwxyz"

    Dim randChar As Char

    Private Sub studikasus1TebakHuruf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim randomIndex As Integer = rand.Next(strLetters.Length)

        randChar = strLetters(randomIndex)

    End Sub

    Private Sub TebakBtn_Click(sender As Object, e As EventArgs) Handles TebakBtn.Click

        Dim guessChar As Char = Tebak.Text(0)

        If (guessChar = randChar) Then
            Hasil.Text = "KAmU BerHaSiL BanH!!"
        Else
            Hasil.Text = "Ahaha CoBa LAgI!!"
        End If

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim back As New studiKasusMenu()

        back.Show()

        Me.Close()
    End Sub
End Class