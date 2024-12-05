Imports System.IO

Module FileHandler

    Public Function IniReader(filePath As String, ParamArray fileHeader As String()) As Dictionary(Of String, List(Of String))

        Dim fileChecker As New FileInfo(filePath)
        Dim dataHolder As New Dictionary(Of String, List(Of String))()

        If fileChecker.Exists Then

            Dim lines As String() = File.ReadAllLines(filePath)



            Dim currentHeader As String = Nothing

            For Each line As String In lines

                line = line.Trim()


                If line.StartsWith("["c) AndAlso line.EndsWith("]"c) Then
                    currentHeader = line.Trim("["c, "]"c)
                    If Not dataHolder.ContainsKey(currentHeader) Then
                        dataHolder(currentHeader) = New List(Of String)()
                    End If

                ElseIf Not String.IsNullOrWhiteSpace(line) AndAlso currentHeader IsNot Nothing Then

                    Dim parts As String() = line.Split("="c, 2)

                    If parts.Length = 2 Then

                        Dim value As String = parts(1).Trim()

                        dataHolder(currentHeader).Add(value)
                    End If
                End If
            Next
        End If

        Return dataHolder

    End Function


End Module
