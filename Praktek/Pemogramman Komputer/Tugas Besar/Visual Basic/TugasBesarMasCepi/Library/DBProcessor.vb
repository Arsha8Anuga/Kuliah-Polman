Imports MySql.Data.MySqlClient

Module DBProcessor

    Public Function DBReadUser(filters As Dictionary(Of String, Object), Optional columns As String() = Nothing) As KeyValuePair(Of Integer, Object)
        Dim tableColumn As New List(Of String)()


        If columns IsNot Nothing Then
            For Each col In columns
                If ConstantManagement.UserTableColumn.Value.Contains(col) Then
                    tableColumn.Add(col)
                End If
            Next
        End If

        If tableColumn.Count = 0 Then
            tableColumn.Add("*")
        End If


        Dim query As String = $"SELECT {String.Join(", ", tableColumn)} FROM user_table"


        Dim whereClauses As New List(Of String)()
        Dim parameters As New List(Of MySqlParameter)()

        For Each fltr In filters

            whereClauses.Add($"{fltr.Key} = @{fltr.Key}")
            parameters.Add(New MySqlParameter($"@{fltr.Key}", fltr.Value))
        Next


        If whereClauses.Count > 0 Then
            query &= " WHERE " & String.Join(" AND ", whereClauses)
        End If


        Dim result As KeyValuePair(Of Integer, Object) = DBConnector.DBStartUp(ConstantManagement.SETTING_FILE_PATH, query, parameters)

        If result.Key = 0 Then
            Dim results As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))

            If results.Count = 0 Then
                Return New KeyValuePair(Of Integer, Object)(404, "User not found.")
            End If

            Return New KeyValuePair(Of Integer, Object)(0, results)

        Else
            Return New KeyValuePair(Of Integer, Object)(result.Key, result.Value)
        End If
    End Function

    Public Function DBInsertUser(parameters As Dictionary(Of String, Object)) As KeyValuePair(Of Integer, String)

        Dim columns As New List(Of String)()
        Dim parameterNames As New List(Of String)()
        Dim sqlParams As New List(Of MySqlParameter)()

        For Each column As String In UserTableColumn.Value
            If parameters.ContainsKey(column) Then
                columns.Add(column)
                parameterNames.Add("@" & column)
                sqlParams.Add(New MySqlParameter("@" & column, parameters(column)))
            End If
        Next

        Dim query As String = $"INSERT INTO {UserTableColumn.Key} ({String.Join(", ", columns)}) VALUES ({String.Join(", ", parameterNames)})"

        Dim result As KeyValuePair(Of Integer, Object) = DBConnector.DBStartUp(ConstantManagement.SETTING_FILE_PATH, query, sqlParams)

        If result.Key = 0 Then
            Return New KeyValuePair(Of Integer, String)(0, "User data inserted successfully!")
        Else
            Return New KeyValuePair(Of Integer, String)(result.Key, "Error inserting user data: " & result.Value.ToString())
        End If

    End Function

    Public Function DBInsertFinance(parameters As Dictionary(Of String, Object)) As KeyValuePair(Of Integer, String)

        Dim columns As New List(Of String)()
        Dim parameterNames As New List(Of String)()
        Dim sqlParams As New List(Of MySqlParameter)()

        For Each column As String In FinanceTableColumn.Value
            If parameters.ContainsKey(column) Then
                columns.Add(column)
                parameterNames.Add("@" & column)
                sqlParams.Add(New MySqlParameter("@" & column, parameters(column)))
            End If
        Next

        Dim query As String = $"INSERT INTO {FinanceTableColumn.Key} ({String.Join(", ", columns)}) VALUES ({String.Join(", ", parameterNames)})"


        Dim result As KeyValuePair(Of Integer, Object) = DBConnector.DBStartUp(ConstantManagement.SETTING_FILE_PATH, query, sqlParams)


        If result.Key = 0 Then
            Return New KeyValuePair(Of Integer, String)(0, "Data inserted successfully!")
        Else
            Return New KeyValuePair(Of Integer, String)(result.Key, "Error inserting data: " & result.Value.ToString())
        End If
    End Function

    Public Function DBReadFinance(filters As Dictionary(Of String, Object), Optional columns As String() = Nothing) As KeyValuePair(Of Integer, Object)
        Dim tableColumn As New List(Of String)()

        If columns IsNot Nothing Then
            For Each col In columns
                If FinanceTableColumn.Value.Contains(col) Then
                    tableColumn.Add(col)
                End If
            Next
        End If

        If tableColumn.Count = 0 Then
            tableColumn.Add("*")
        End If

        Dim query As String = $"SELECT {String.Join(", ", tableColumn)} FROM {FinanceTableColumn.Key}"

        Dim whereClauses As New List(Of String)()
        Dim parameters As New List(Of MySqlParameter)()

        For Each fltr In filters
            If fltr.Key.Contains("::StrtDT") Then
                whereClauses.Add("create_at >= @startDate")
                parameters.Add(New MySqlParameter("@startDate", fltr.Value))
            ElseIf fltr.Key.Contains("::EndDT") Then
                whereClauses.Add("create_at <= @endDate")
                parameters.Add(New MySqlParameter("@endDate", fltr.Value))
            Else
                whereClauses.Add($"{fltr.Key} = @{fltr.Key}")
                parameters.Add(New MySqlParameter($"@{fltr.Key}", fltr.Value))
            End If
        Next

        If whereClauses.Count > 0 Then
            query &= " WHERE " & String.Join(" AND ", whereClauses)
        End If

        Dim result As KeyValuePair(Of Integer, Object) = DBConnector.DBStartUp(ConstantManagement.SETTING_FILE_PATH, query, parameters)

        If result.Key = 0 Then
            Dim results As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))


            If results.Count = 0 Then
                Return New KeyValuePair(Of Integer, Object)(404, "No finance data found.")
            End If

            Return New KeyValuePair(Of Integer, Object)(0, results)
        Else

            Return New KeyValuePair(Of Integer, Object)(result.Key, result.Value)
        End If
    End Function

End Module
