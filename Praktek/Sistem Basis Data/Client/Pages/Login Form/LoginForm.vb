Imports System.IO
Imports System.Threading
Imports Newtonsoft.Json

Public Class LoginForm

    Dim clients As New HttpRequestHandler()
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            Password_TextBox.UseSystemPasswordChar = False
        Else
            Password_TextBox.UseSystemPasswordChar = True
        End If

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Username_TextBox.Text = "" Or Password_TextBox.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong")
        Else
            Button1.Enabled = False

            Dim url As String = Path.Combine(ConstantManager.URL_BASE, "user_account") ' Replace with your actual URL
            Dim payload As New Dictionary(Of String, Object) From {
                {"username", Username_TextBox.Text},
                {"password", Password_TextBox.Text}
            }

            Try
                Dim result As Dictionary(Of String, Object) = Await clients.PostJsonAsync(url, payload)

                If result.ContainsKey("error") Then

                    MsgBox(result("error"))

                    Username_TextBox.Text = ""
                    Password_TextBox.Text = ""
                Else

                    Dim userData = CType(result("user"), Newtonsoft.Json.Linq.JObject).ToObject(Of Dictionary(Of String, Object))()

                    UserBundle.Initialize(userData)

                    If userData("id_role") = "2" Then
                        Dim form As New FormUser()

                        form.Show()

                        Me.Dispose()
                    Else
                        Dim form As New FormAdmin()

                        form.Show()

                        Me.Dispose()
                    End If

                End If

            Catch ex As Exception
                Console.WriteLine($"Error: {ex.Message}")
            Finally

                Button1.Enabled = True
            End Try

        End If
    End Sub

    Private Sub FormAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class