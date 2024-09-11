Public Class Test

    Dim DB_USER() As String = {"Waluwigi", "Ballade"}


    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles nameInput.TextChanged

    End Sub

    Private Sub passInput_TextChanged(sender As Object, e As EventArgs) Handles passInput.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (nameInput.Text = DB_USER(0) And passInput.Text = DB_USER(1)) Then
            Label1.Text = "You are in"
            Label1.ForeColor = Color.Green
        Else
            Label1.Text = "Your name and password are invalid!!"
            Label1.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
