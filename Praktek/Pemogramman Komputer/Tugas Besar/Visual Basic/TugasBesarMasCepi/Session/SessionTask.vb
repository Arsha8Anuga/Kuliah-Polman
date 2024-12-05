Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO
Imports OxyPlot

Public Class SessionTask

    Private cts As CancellationTokenSource
    Private sessionCheckerTask As Task
    Private isStopped As Boolean = False
    Public sessionData As List(Of Dictionary(Of String, Object))
    

    Private ReadOnly LoginFormClass As String = ConstantManagement.LOGIN_CLASS


    Public Sub StartSessionChecker()

        cts = New CancellationTokenSource()
        Dim token As CancellationToken = cts.Token

        sessionCheckerTask = Task.Run(Sub() SessionChecker(token), token)

    End Sub

    Public Sub StopSessionChecker()

        If isStopped Then
            Return
        End If

        isStopped = True
        If cts IsNot Nothing Then
            cts.Cancel()
        End If

        If sessionCheckerTask IsNot Nothing Then
            Try
                sessionCheckerTask.Wait()
            Catch ex As AggregateException
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Function SessionChecker(token As CancellationToken) As Integer

        Dim session As New SessionManager()

        While Not token.IsCancellationRequested
            Dim sessionDataFromFile = session.ReadSession()

            If Not File.Exists(ConstantManagement.SESSION_FILE_PATH) OrElse sessionDataFromFile Is Nothing Then

                Dim result As Integer = ShowLoginForm()


                If result = 1 Then

                    StopSessionChecker()

                End If

                sessionData = Nothing

                Exit While

            Else

                sessionData = sessionDataFromFile

            End If

            Thread.Sleep(2000)

        End While

        Return -1

    End Function

    Private Function ShowLoginForm() As Integer

        Dim result As Integer = 0

        Try


            If Form.ActiveForm IsNot Nothing Then

                Form.ActiveForm.Invoke(Sub()

                                           CloseAllFormsExceptMain()

                                           Dim loginType As Type = Type.GetType(LoginFormClass)

                                           If loginType IsNot Nothing Then

                                               Dim loginForm As Form = CType(Activator.CreateInstance(loginType), Form)

                                               If loginForm.ShowDialog() = DialogResult.OK Then

                                                   result = 1

                                               End If

                                           Else

                                               MsgBox("Login form type not found: " & LoginFormClass)

                                           End If

                                       End Sub)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

            Application.Exit()

        End Try


        Return 1

    End Function

    Private Sub CloseAllFormsExceptMain()

        Dim formsToClose As New List(Of Form)()


        For Each form As Form In Application.OpenForms

            If form.Name <> DatabaseVerification.Name Then

                formsToClose.Add(form)

            End If

        Next


        For Each form As Form In formsToClose

            form.Close()

        Next

    End Sub

End Class