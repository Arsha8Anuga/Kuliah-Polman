Public Class studiKasusMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginPageForm.MouseEnter
        loginPageForm.Size = New Size(loginPageForm.Width + 30, loginPageForm.Height + 30)

    End Sub

    Private Sub Button1_Click1(sender As Object, e As EventArgs) Handles loginPageForm.MouseLeave

        loginPageForm.Size = New Size(loginPageForm.Width - 30, loginPageForm.Height - 30)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles loginPageForm.Click
        Dim Login As New studiKasus1Kalkulator()

        Login.Show()
    End Sub
End Class
