Public Class SelectCase

    Private Sub NilaiBtn_Click(sender As Object, e As EventArgs) Handles NilaiBtn.Click
        Dim inputValue As String = TextBox1.Text.Trim()
        Dim result As String = ""


        Select Case inputValue
            Case "A"
                result = "Nilai Anda Sangat Baik"
            Case "B"
                result = "Nilai Anda Baik"
            Case "C"
                result = "Nilai Anda Cukup"
            Case "D"
                result = "Nilai Anda Kurang"
            Case "E"
                result = "Nilai Anda Sangat Kurang"
            Case Else
                result = "Input tidak valid"
        End Select


        nilaiLbl.Text = result
    End Sub
End Class