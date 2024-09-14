Public Class Form1

    Dim username As String = ""

    Public Sub dataSet(data As String)
        username = data
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        congrats.Text = $"Selamat Datang {username}!!"

    End Sub

    Private Sub backOpt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backOpt.LinkClicked

        If studiKasus1Login.loginForm IsNot Nothing Then
            studiKasus1Login.loginForm.Show()
        Else
            Application.Exit()
        End If

        Me.Close()

    End Sub
End Class