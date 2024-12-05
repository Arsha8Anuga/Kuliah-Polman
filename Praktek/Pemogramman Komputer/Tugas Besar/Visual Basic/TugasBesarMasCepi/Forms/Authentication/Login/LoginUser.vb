Imports System.Reflection

Public Class LoginUser

    Private bgTask As SessionTask
    Private session As New SessionManager()

    Private Sub LoginUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub

    Private Async Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim username As String = UsernameText.Text
        Dim password As String = PasswordText.Text

        Dim filters As New Dictionary(Of String, Object) From {
        {"username", username},
        {"user_password", password}
    }

        Dim columns As String() = {"id", "username", "email"}

        Dim result As KeyValuePair(Of Integer, Object) = DBProcessor.DBReadUser(filters, columns)

        If result.Key = 0 Then
            Dim userInfo As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))

            If session.GenerateSession(userInfo) Then

                Dim menuForm As New Menu()
                bgTask = New SessionTask()
                bgTask.StartSessionChecker()

                Await Task.Delay(10)

                menuForm.Show()

                Close()

            Else
                MsgBox("Failed to generate session.")
            End If
        Else
            MsgBox("Error: " & result.Value.ToString())
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click

        Application.Exit()

    End Sub

    Private Sub RegisterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLink.LinkClicked

        Dim register As New Register()
        register.Show()


        Close()

    End Sub


End Class