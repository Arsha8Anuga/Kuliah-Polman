Imports System.Linq
Imports MySql.Data.MySqlClient

Module DBConnector

    Private ReadOnly envSearch As String = "database"
    Public Function DBStartUp(filePath As String, Optional query As String = Nothing, Optional parameters As List(Of MySqlParameter) = Nothing) As KeyValuePair(Of Integer, Object)

        Dim dbEnv As Dictionary(Of String, List(Of String)) = FileHandler.IniReader(filePath, envSearch)

        If dbEnv.Count > 0 AndAlso dbEnv.ContainsKey(envSearch) Then

            Dim dbKeyVal As KeyValuePair(Of String, List(Of String)) = dbEnv.First()

            If dbKeyVal.Value.Count = 4 Then

                Dim connectionStr As String = $"Server={dbKeyVal.Value(0)};Database={dbKeyVal.Value(1)};User ID={dbKeyVal.Value(2)};Password={dbKeyVal.Value(3)};"

                Using getConnection As New MySqlConnection(connectionStr)

                    Try
                        getConnection.Open()

                        If Not String.IsNullOrWhiteSpace(query) Then

                            Using command As New MySqlCommand(query, getConnection)


                                If parameters IsNot Nothing Then
                                    For Each param As MySqlParameter In parameters
                                        command.Parameters.Add(param)
                                    Next
                                End If

                                If query.Trim().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase) Then

                                    Using reader As MySqlDataReader = command.ExecuteReader()
                                        Dim results As New List(Of Dictionary(Of String, Object))
                                        While reader.Read()
                                            Dim row As New Dictionary(Of String, Object)
                                            For i As Integer = 0 To reader.FieldCount - 1
                                                row.Add(reader.GetName(i), reader.GetValue(i))
                                            Next
                                            results.Add(row)
                                        End While
                                        Return New KeyValuePair(Of Integer, Object)(0, results)
                                    End Using
                                Else

                                    command.ExecuteNonQuery()
                                    Return New KeyValuePair(Of Integer, Object)(0, "Success")
                                End If

                            End Using
                        End If

                        Return New KeyValuePair(Of Integer, Object)(0, "Success")

                    Catch ex As MySqlException
                        Return New KeyValuePair(Of Integer, Object)(ex.Number, ex.Message)
                    End Try
                End Using

            End If

        End If

        Return New KeyValuePair(Of Integer, Object)(-1, "Configuration not valid or not found.")

    End Function


End Module
