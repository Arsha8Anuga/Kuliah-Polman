Imports System.IO

Public Class DatabaseVerification

    Public Shared mainForm As DatabaseVerification
    Private bgTask As SessionTask
    Private session As New SessionManager()

    Private Async Sub DatabaseVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mainForm = Me

        Dim dbChecking As KeyValuePair(Of Integer, Object) = DBConnector.DBStartUp(ConstantManagement.SETTING_FILE_PATH)

        If dbChecking.Key = 0 Then
            Dim sessionData = session.ReadSession()

            If sessionData IsNot Nothing AndAlso sessionData.Count > 0 Then
                Dim sessionUser = sessionData(0)

                If DBProcessor.DBReadUser(sessionUser).Key = 0 Then
                    Dim form2 As New Menu()
                    form2.Show()
                    Await Task.Delay(10)

                    bgTask = New SessionTask()
                    bgTask.StartSessionChecker()

                    Hide()
                Else

                    MsgBox("No valid session data found.")

                End If
            Else

                Dim form1 As New LoginUser()
                form1.Show()

                Await Task.Delay(10)
                Hide()

            End If

        Else
            MsgBox(dbChecking.Value.ToString())
            Application.Exit()
        End If

    End Sub

    Private Sub DatabaseVerification_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing

        bgTask.StopSessionChecker()

    End Sub


End Class