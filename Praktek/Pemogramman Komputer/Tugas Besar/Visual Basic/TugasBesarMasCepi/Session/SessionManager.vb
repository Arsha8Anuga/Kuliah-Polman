Imports System.IO
Imports System.Text.Json

Public Class SessionManager

    Public Function GenerateSession(userData As List(Of Dictionary(Of String, Object))) As Boolean

        If Not File.Exists(ConstantManagement.SESSION_FILE_PATH) Then

            Try

                Dim sessionData As New Dictionary(Of String, Object)()

                sessionData.Add("userData", userData)
                sessionData.Add("expirationTime", DateTime.Now.AddMinutes(ConstantManagement.SESSION_TIME))


                Dim jsonString As String = JsonSerializer.Serialize(sessionData)


                File.WriteAllText(ConstantManagement.SESSION_FILE_PATH, jsonString)

                Return True
            Catch ex As Exception

                MsgBox("Error :" & ex.Message)

                Return False

            End Try

        Else
            Return True
        End If

    End Function


    Public Function ReadSession() As List(Of Dictionary(Of String, Object))
        Dim sessionData As New Dictionary(Of String, Object)()

        If Not File.Exists(SESSION_FILE_PATH) Then
            Return Nothing
        End If

        Try
            Dim jsonString As String = File.ReadAllText(ConstantManagement.SESSION_FILE_PATH)
            sessionData = JsonSerializer.Deserialize(Of Dictionary(Of String, Object))(jsonString)

            If Not IsSessionValid(sessionData) Then
                Return Nothing
            End If

            Return GetUserData(sessionData)
        Catch ex As Exception
            MsgBox("Error reading session: " & ex.Message)
        End Try

        Return Nothing
    End Function

    Public Function DestroySession() As Boolean
        Try
            If File.Exists(ConstantManagement.SESSION_FILE_PATH) Then
                File.Delete(ConstantManagement.SESSION_FILE_PATH)
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox("Error deleting session: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function IsSessionValid(sessionData As Dictionary(Of String, Object)) As Boolean
        Dim expirationElement As JsonElement = CType(sessionData("expirationTime"), JsonElement)
        Dim expirationTimeString As String = expirationElement.GetString()
        Dim expirationTime As DateTime

        If Not DateTime.TryParse(expirationTimeString, expirationTime) Then
            Throw New Exception("Invalid expiration time format.")
        End If

        If DateTime.Now >= expirationTime Then
            File.Delete(ConstantManagement.SESSION_FILE_PATH)
            MessageBox.Show("Your Session has expired!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function GetUserData(sessionData As Dictionary(Of String, Object)) As List(Of Dictionary(Of String, Object))
        If sessionData.ContainsKey("userData") AndAlso TypeOf sessionData("userData") Is JsonElement Then
            Dim userDataElement As JsonElement = CType(sessionData("userData"), JsonElement)
            Return JsonSerializer.Deserialize(Of List(Of Dictionary(Of String, Object)))(userDataElement.ToString())
        End If

        Return Nothing
    End Function


End Class
