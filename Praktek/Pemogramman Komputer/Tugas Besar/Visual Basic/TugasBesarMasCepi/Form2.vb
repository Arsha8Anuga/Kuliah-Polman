

Imports System.Windows.Documents

Public Class Form2

    Private userId As String = "1"
    'Private bgTask As SessionTask
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim session As New SessionManager()



        '' Create dummy dictionaries
        'Dim dict1 As New Dictionary(Of String, Object) From {
        '    {"Name", "John Doe"},
        '    {"Age", 30},
        '    {"IsEmployed", True},
        '    {"Salary", 50000.5}
        '}

        'dummyDataList.Add(dict1)

        'Dim result As Boolean = session.GenerateSession(dummyDataList)

        Dim sessionRead = session.ReadSession()
        Dim sessionData = sessionRead(0)("email").ToString()



        Label1.Text = sessionData


        'Dim myObject As New Form1()
        'Dim instanceType As Type = myObject.GetType()

        'Label1.Text = instanceType.ToString()

        'Dim loginForm As Form = CType(Activator.CreateInstance(Type.GetType(ConstantManagement.LOGIN_CLASS)), Form)
        'loginForm.Show()

        'bgTask = New SessionTask()
        'bgTask.StartSessionChecker()

        'Dim result As KeyValuePair(Of Integer, Object) = DBReadUser(userId)

        'If result.Key = 0 Then
        '    Dim userData As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))


        '    Dim user As Dictionary(Of String, Object) = userData.FirstOrDefault()

        '    If user IsNot Nothing Then
        '        Dim userInfo As String = $"ID: {user("id")}, Email: {user("email")}, Username: {user("username")}, Password: {user("user_password")}"
        '        Label1.Text = userInfo
        '    End If
        'Else
        '    Label1.Text = $"Error: {result.Value}"
        'End If

    End Sub

    Private Sub Form2_exit(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub
End Class