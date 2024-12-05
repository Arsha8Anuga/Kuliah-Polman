Imports System.IO

Public Class MainApp

    Private Async Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await Task.Delay(1)

        Me.Hide()

        Dim form As New LoginForm()

        form.Show()

    End Sub
End Class
