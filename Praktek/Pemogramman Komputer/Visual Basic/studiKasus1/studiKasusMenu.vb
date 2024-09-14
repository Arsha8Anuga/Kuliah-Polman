Public Class studiKasusMenu

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles loginPageForm.Click
        Dim Login As New studiKasus1Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub kalkulator_Click(sender As Object, e As EventArgs) Handles kalkulator.Click
        Dim kalkulator As New studiKasus1Kalkulator()
        kalkulator.Show()
        Me.Hide()
    End Sub

    Private Sub bangunDatar1_Click(sender As Object, e As EventArgs) Handles bangunDatar1.Click
        Dim bd1 As New studiKasus1BangunDatar1()
        bd1.Show()
        Me.Hide()
    End Sub

    Private Sub bangunDatar2_Click(sender As Object, e As EventArgs) Handles bangunDatar2.Click
        Dim bd2 As New studiKasus1BangunDatar2()
        bd2.Show()
        Me.Hide()
    End Sub

    Private Sub games_Click(sender As Object, e As EventArgs) Handles games.Click
        Dim tebak As New studikasus1TebakHuruf()
        tebak.Show()
        Me.Hide()
    End Sub

    Private Sub studiKasusMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
End Class
