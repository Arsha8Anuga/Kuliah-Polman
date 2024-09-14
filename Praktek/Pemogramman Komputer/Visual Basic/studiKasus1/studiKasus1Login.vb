Public Class studiKasus1Login

    Dim DB_DATA() As String = {"Anugrah", "Ballas"}
    Public Shared loginForm As studiKasus1Login

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Dim congratsForm As New Form1()


        If txtBoxUser.Text = DB_DATA(0) AndAlso txtBoxPass.Text = DB_DATA(1) Then

            lblChecker.Text = "You're in!!"
            lblChecker.ForeColor = Color.Green

        Else

            lblChecker.Text = "invalid credetials!!"
            lblChecker.ForeColor = Color.Red

        End If

        congratsForm.dataSet(DB_DATA(0))

        congratsForm.Show()

        Me.Hide()



    End Sub

    Private Sub regLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles regLink.LinkClicked
        Dim register As New studiKasus1Register

        register.Show()

        Hide()
    End Sub

    Private Sub studiKasus1Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginForm = Me
    End Sub
End Class