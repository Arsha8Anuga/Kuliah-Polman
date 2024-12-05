Public Class Menu

    Private session As New SessionManager()
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click

        session.DestroySession()

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim sessionManager As New SessionManager()

        Dim userData As List(Of Dictionary(Of String, Object)) = sessionManager.ReadSession()

        If userData IsNot Nothing AndAlso userData.Count > 0 Then

            UserLabel.Text = "Hi, " & userData(0)("username").ToString()

        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click

        Application.Exit()

    End Sub

    Private Sub CreateDataBtn_Click(sender As Object, e As EventArgs) Handles CreateDataBtn.Click

        Dim createData As New CreateData()
        createData.Show()

        Close()

    End Sub

    Private Sub LogActivityBtn_Click(sender As Object, e As EventArgs) Handles LogActivityBtn.Click
        Dim logActivity As New LogActivity()
        logActivity.Show()

        Close()
    End Sub

    Private Sub TableAndVisualizationBtn_Click(sender As Object, e As EventArgs) Handles TableAndVisualizationBtn.Click

        Dim tableAndVisualization As New TableAndVisualization()
        tableAndVisualization.Show()

        Close()

    End Sub
End Class