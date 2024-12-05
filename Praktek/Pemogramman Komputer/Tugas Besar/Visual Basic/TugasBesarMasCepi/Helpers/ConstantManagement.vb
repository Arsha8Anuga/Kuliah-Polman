Module ConstantManagement

    Public ReadOnly SETTING_FILE_PATH As String = "..\..\..\settings.ini"
    Public ReadOnly SESSION_FILE_PATH As String = "..\..\..\Session\Temp\temp_ses.file"
    Public ReadOnly SESSION_TIME As Integer = 3
    Public ReadOnly LOGIN_CLASS As String = "TugasBesarMasCepi.LoginUser"

    Public ReadOnly UserTableColumn As KeyValuePair(Of String, String()) = New KeyValuePair(Of String, String())("user_table", New String() {"id", "email", "username", "user_password"})
    Public ReadOnly FinanceTableColumn As KeyValuePair(Of String, String()) = New KeyValuePair(Of String, String())("finance_table", New String() {"id", "finance_type", "user_id", "nominal", "method", "details", "create_at"})

End Module
