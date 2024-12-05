Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Web
Imports HttpMultipartParser
Imports System.IO
Public Class HttpRequestHandler
    Private ReadOnly client As HttpClient

    Public Sub New()
        client = New HttpClient()
    End Sub


    Public Async Function GetJsonAsync(ByVal url As String, Optional ByVal queryParameter As List(Of Dictionary(Of String, Object)) = Nothing) As Task(Of Dictionary(Of String, Object))

        Dim queryString As New StringBuilder()

        If queryParameter IsNot Nothing AndAlso queryParameter.Count > 0 Then
            For Each item As Dictionary(Of String, Object) In queryParameter
                For Each kvp As KeyValuePair(Of String, Object) In item
                    queryString.Append($"{HttpUtility.UrlEncode(kvp.Key)}={HttpUtility.UrlEncode(kvp.Value.ToString())}&")
                Next
            Next

            If queryString.Length > 0 Then
                queryString.Length -= 1
            End If
        End If

        Dim mergeUrl As String = If(queryString.Length > 0, $"{url}?{queryString}", url)

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(mergeUrl)
            response.EnsureSuccessStatusCode()

            Dim responseContent As String = Await response.Content.ReadAsStringAsync()
            Dim jsonData As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseContent)

            Return jsonData
        Catch ex As Exception
            Throw New Exception($"Error during HTTP GET: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Async Function GetMultipartJsonAsync(ByVal url As String, ByVal queryParameter As List(Of Dictionary(Of String, Object))) As Task(Of Tuple(Of Stream, Dictionary(Of String, Object)))

        Dim queryString As StringBuilder = New StringBuilder()

        For Each item As Dictionary(Of String, Object) In queryParameter
            For Each kvp As KeyValuePair(Of String, Object) In item
                queryString.Append($"{HttpUtility.UrlEncode(kvp.Key)}={HttpUtility.UrlEncode(kvp.Value.ToString())}&")
            Next
        Next

        If queryString.Length > 0 Then
            queryString.Length -= 1
        End If

        Dim mergeUrl As String = $"{url}?{queryString.ToString()}"

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(mergeUrl)
            response.EnsureSuccessStatusCode()

            Dim contentStream As Stream = Await response.Content.ReadAsStreamAsync()

            Dim parser As MultipartFormDataParser = MultipartFormDataParser.Parse(contentStream)

            Dim jsonData As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()

            If parser.Parameters.Any() Then
                For Each param In parser.Parameters
                    Try
                        jsonData(param.Name) = JsonConvert.DeserializeObject(Of Object)(param.Data)
                    Catch ex As Exception
                        Debug.WriteLine("Error parsing JSON: " & ex.Message)
                    End Try
                Next
            End If

            Dim file = parser.Files.FirstOrDefault()
            If file IsNot Nothing Then
                Dim fileStream As Stream = file.Data
                Return Tuple.Create(fileStream, jsonData)
            End If

            Return Nothing

        Catch ex As Exception
            Debug.WriteLine("An error occurred: " & ex.Message)
        End Try

        Return Nothing
    End Function

    Public Async Function PostJsonAsync(ByVal url As String, ByVal payload As Object) As Task(Of Dictionary(Of String, Object))
        Try

            Dim jsonPayload As String = JsonConvert.SerializeObject(payload)

            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
            response.EnsureSuccessStatusCode()

            Dim responseContent As String = Await response.Content.ReadAsStringAsync()
            Dim jsonData As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseContent)
            Return jsonData
        Catch ex As Exception

            Return New Dictionary(Of String, Object) From {
                {"error", $"Error during HTTP POST: {ex.Message}"}
            }
        End Try
    End Function

    Public Async Function PostMultipartJsonAsync(ByVal url As String, ByVal Data As Tuple(Of Stream, String, Dictionary(Of String, Object))) As Task(Of Dictionary(Of String, Object))
        Try
            Using Form As New MultipartFormDataContent()

                Dim fileStream As Stream = Data.Item1
                Dim fileName As String = Data.Item2

                Dim fileContent As New StreamContent(fileStream)
                fileContent.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/octet-stream")
                Form.Add(fileContent, "data_file", fileName)

                Dim json As String = JsonConvert.SerializeObject(Data.Item3)
                Dim jsonContent As New StringContent(json, Encoding.UTF8, "text/plain")
                Form.Add(jsonContent, "data_json")

                Dim response As HttpResponseMessage = Await client.PostAsync(url, Form)

                If response.IsSuccessStatusCode Then

                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Return JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseContent)
                Else

                    Throw New Exception($"Request failed with status: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            Throw New Exception($"Error during HTTP POST: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Async Function PatchJsonAsync(ByVal url As String, ByVal payload As Object) As Task(Of Dictionary(Of String, Object))
        Try

            Dim jsonPayload As String = JsonConvert.SerializeObject(payload)


            Dim request As New HttpRequestMessage(HttpMethod.Patch, url) With {
                .Content = New StringContent(jsonPayload, Encoding.UTF8, "application/json")
            }

            Dim response As HttpResponseMessage = Await client.SendAsync(request)
            response.EnsureSuccessStatusCode()

            Dim responseContent As String = Await response.Content.ReadAsStringAsync()
            Dim jsonData As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseContent)
            Return jsonData
        Catch ex As Exception

            Console.WriteLine($"Error during HTTP PATCH: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Async Function PatchMultipartJsonAsync(ByVal url As String, ByVal Data As Tuple(Of Stream, String, Dictionary(Of String, Object))) As Task(Of Dictionary(Of String, Object))
        Try
            Using Form As New MultipartFormDataContent()

                Dim fileStream As Stream = Data.Item1
                Dim fileName As String = Data.Item2

                Dim fileContent As New StreamContent(fileStream)
                fileContent.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/octet-stream")
                Form.Add(fileContent, "data_file", fileName)

                Dim json As String = JsonConvert.SerializeObject(Data.Item3)
                Dim jsonContent As New StringContent(json, Encoding.UTF8, "application/json")
                Form.Add(jsonContent, "data_json")


                Dim response As HttpResponseMessage = Await client.PatchAsync(url, Form)


                If response.IsSuccessStatusCode Then

                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Return JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseContent)
                Else

                    Throw New Exception($"Request failed with status: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception

            Throw New Exception($"Error during HTTP PATCH: {ex.Message}")

            Return Nothing
        End Try
    End Function

    Public Async Function DeleteAsync(ByVal url As String, Optional ByVal queryParameter As List(Of Dictionary(Of String, Object)) = Nothing) As Task(Of Boolean)
        ' If the queryParameter is Nothing or empty, return False immediately
        If queryParameter Is Nothing OrElse queryParameter.Count = 0 Then
            Console.WriteLine("No query parameters provided.")
            Return False
        End If

        ' Build the query string from the provided query parameters
        Dim queryString As New StringBuilder()

        If queryParameter.Count > 0 Then
            For Each item As Dictionary(Of String, Object) In queryParameter
                For Each kvp As KeyValuePair(Of String, Object) In item
                    queryString.Append($"{HttpUtility.UrlEncode(kvp.Key)}={HttpUtility.UrlEncode(kvp.Value.ToString())}&")
                Next
            Next

            If queryString.Length > 0 Then
                queryString.Length -= 1 ' Remove the last '&'
            End If
        End If

        Dim mergeUrl As String = If(queryString.Length > 0, $"{url}?{queryString}", url)

        Try
            ' Send the DELETE request with the query parameters
            Dim request As New HttpRequestMessage(HttpMethod.Delete, mergeUrl)

            ' Send the request and wait for the response
            Dim response As HttpResponseMessage = Await client.SendAsync(request)
            response.EnsureSuccessStatusCode()

            ' Return True if the delete request was successful
            Return True

        Catch ex As Exception
            ' Log the error and return False if there was a problem with the request
            Console.WriteLine($"Error during HTTP DELETE: {ex.Message}")
            Return False
        End Try
    End Function

End Class
