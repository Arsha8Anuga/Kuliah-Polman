Public Class Form3
    Dim G1, G2, G3, HASIL As Double
    Dim toleransi As String

    Private Sub RESISTOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nilaires.Enabled = False
    End Sub

    Private Sub g1box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g1box.SelectedIndexChanged
        If g1box.Text = "HITAM" Then
            G1 = 0
        ElseIf g1box.Text = "COKELAT" Then
            G1 = 1
        ElseIf g1box.Text = "MERAH" Then
            G1 = 2
        ElseIf g1box.Text = "ORANYE" Then
            G1 = 3
        ElseIf g1box.Text = "KUNING" Then
            G1 = 4
        ElseIf g1box.Text = "HIJAU" Then
            G1 = 5
        ElseIf g1box.Text = "BIRU" Then
            G1 = 6
        ElseIf g1box.Text = "UNGU" Then
            G1 = 7
        ElseIf g1box.Text = "ABU" Then
            G1 = 8
        ElseIf g1box.Text = "PUTIH" Then
            G1 = 9
        End If
    End Sub

    Private Sub g2box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g2box.SelectedIndexChanged
        If g2box.Text = "HITAM" Then
            G2 = 0
        ElseIf g2box.Text = "COKELAT" Then
            G2 = 1
        ElseIf g2box.Text = "MERAH" Then
            G2 = 2
        ElseIf g2box.Text = "ORANYE" Then
            G2 = 3
        ElseIf g2box.Text = "KUNING" Then
            G2 = 4
        ElseIf g2box.Text = "HIJAU" Then
            G2 = 5
        ElseIf g2box.Text = "BIRU" Then
            G2 = 6
        ElseIf g2box.Text = "UNGU" Then
            G2 = 7
        ElseIf g2box.Text = "ABU" Then
            G2 = 8
        ElseIf g2box.Text = "PUTIH" Then
            G2 = 9
        End If
    End Sub

    Private Sub g3box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g3box.SelectedIndexChanged
        Select Case g3box.Text
            Case "HITAM"
                G3 = Math.Pow(10, 0) ' 10^0 = 1
            Case "COKELAT"
                G3 = Math.Pow(10, 1) ' 10^1 = 10
            Case "MERAH"
                G3 = Math.Pow(10, 2) ' 10^2 = 100
            Case "ORANYE"
                G3 = Math.Pow(10, 3) ' 10^3 = 1000
            Case "KUNING"
                G3 = Math.Pow(10, 4) ' 10^4 = 10000
            Case "HIJAU"
                G3 = Math.Pow(10, 5) ' 10^5 = 100000
            Case "BIRU"
                G3 = Math.Pow(10, 6) ' 10^6 = 1000000
            Case "UNGU"
                G3 = Math.Pow(10, 7) ' 10^7 = 10000000
            Case "ABU"
                G3 = Math.Pow(10, 8) ' 10^8 = 100000000
            Case "PUTIH"
                G3 = Math.Pow(10, 9) ' 10^9 = 1000000000
            Case Else
                G3 = 0 ' Default case if none matches
        End Select
    End Sub


    Private Sub g4box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g4box.SelectedIndexChanged
        If g4box.Text = "EMAS" Then
            toleransi = "5 %"
        ElseIf g4box.Text = "PERAK" Then
            toleransi = "10 %"
        ElseIf g4box.Text = "COKELAT" Then
            toleransi = "1 %"
        ElseIf g4box.Text = "MERAH" Then
            toleransi = "2 %"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        HASIL = (G1 * 10 + G2) * G3
        nilaires.Text = HASIL & " OHM" & " dengan toleransi " & toleransi
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Ulang.Click
        g1box.Text = ""
        g2box.Text = ""
        g3box.Text = ""
        g4box.Text = ""
        nilaires.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Kembali.Click
        Me.Close()
    End Sub
End Class