Public Class Form3

    Public Shared mainForm As Form3
    Private bgTask As SessionTask

    Private Async Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainForm = Me


        Dim form2 As New Form2()
        form2.Show() ' Show form2 first

        '' Hide Form3 after a short delay to ensure form2 is fully initialized
        Await Task.Delay(10)

        bgTask = New SessionTask()
        bgTask.StartSessionChecker()

        Hide()
    End Sub

End Class