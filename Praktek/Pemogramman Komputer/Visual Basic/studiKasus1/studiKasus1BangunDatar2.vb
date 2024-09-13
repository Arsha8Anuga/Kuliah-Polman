Public Class studiKasus1BangunDatar2


    Private Sub studiKasus1BangunDatar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bsBtn_Click(sender As Object, e As EventArgs) Handles bsBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("bs") ' Pass "bs" (Bujur Sangkar - Square) as the shape
        template.Show()
    End Sub

    Private Sub ppBtn_Click(sender As Object, e As EventArgs) Handles ppBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("pp") ' Pass "pp" (Persegi Panjang - Rectangle) as the shape
        template.Show()
    End Sub

    Private Sub bkBtn_Click(sender As Object, e As EventArgs) Handles bkBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("bk") ' Pass "bk" (Belah Ketupat - Rhombus) as the shape
        template.Show()
    End Sub

    Private Sub jgBtn_Click(sender As Object, e As EventArgs) Handles jgBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("jg") ' Pass "jg" (Jajar Genjang - Parallelogram) as the shape
        template.Show()
    End Sub

    Private Sub tBtn_Click(sender As Object, e As EventArgs) Handles tBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("t") ' Pass "t" (Trapesium - Trapezium) as the shape
        template.Show()
    End Sub

    Private Sub llBtn_Click(sender As Object, e As EventArgs) Handles llBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("ll") ' Pass "ll" (Layang-Layang - Kite) as the shape
        template.Show()
    End Sub

    Private Sub sBtn_Click(sender As Object, e As EventArgs) Handles sBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("s") ' Pass "s" (Segitiga - Triangle) as the shape
        template.Show()
    End Sub

    Private Sub lBtn_Click(sender As Object, e As EventArgs) Handles lBtn.Click
        Dim template As New studiKasus1BangunDatarTemplate
        template.SetData("l") ' Pass "l" (Lingkaran - Circle) as the shape
        template.Show()
    End Sub




End Class