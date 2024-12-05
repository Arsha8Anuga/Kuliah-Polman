Imports MySql.Data.MySqlClient


Module DatabaseConnect
    Function DBConnect() As Boolean
        Dim connectString As String = "Server=DESKTOP-61NEHKH;Database=tugas_besar_mas_cepi;User ID=Guest;Password=guest;"
        Dim connection As New MySqlConnection(connectString)

        Try
            connection.Open()
            Return True
        Catch ex As MySqlException
            ' Optionally log the exception or display error message
            Console.WriteLine("Connection failed: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function
End Module