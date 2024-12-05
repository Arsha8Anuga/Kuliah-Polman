Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim loginUser As New LoginUser()
        loginUser.Show()

        Close()

    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        Dim username As String = UernameTxt.Text.Trim()
        Dim email As String = EmailTxt.Text.Trim()
        Dim password As String = PasswordTxt.Text.Trim()

        If String.IsNullOrEmpty(username) Then
            MsgBox("Username is required.", MsgBoxStyle.Critical)
            Return
        End If

        If String.IsNullOrEmpty(email) OrElse Not IsValidEmail(email) Then
            MsgBox("Please enter a valid email address.", MsgBoxStyle.Critical)
            Return
        End If

        If String.IsNullOrEmpty(password) OrElse password.Length < 6 Then
            MsgBox("Password must be at least 6 characters long.", MsgBoxStyle.Critical)
            Return
        End If

        Dim userData As New Dictionary(Of String, Object)()
        userData.Add("username", username)
        userData.Add("email", email)
        userData.Add("user_password", password)

        Dim result As KeyValuePair(Of Integer, String) = DBInsertUser(userData)

        If result.Key = 0 Then
            MsgBox("Registration successful!", MsgBoxStyle.Information)
            UernameTxt.Clear()
            EmailTxt.Clear()
            PasswordTxt.Clear()

            Dim loginUser As New LoginUser()
            loginUser.Show()

            Close()
        Else
            MsgBox("Error during registration: " & result.Value, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

End Class