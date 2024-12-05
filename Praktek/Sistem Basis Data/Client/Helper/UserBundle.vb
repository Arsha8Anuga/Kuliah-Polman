Public Class UserBundle
    Private Shared singleton As UserBundle

    Public Property userData As Dictionary(Of String, Object)

    Private Sub New(data As Dictionary(Of String, Object))
        userData = data
    End Sub

    Public Shared Sub Initialize(data As Dictionary(Of String, Object))
        If singleton Is Nothing Then
            singleton = New UserBundle(data)
        Else
            Throw New InvalidOperationException("UserBundle has already been initialized.")
        End If
    End Sub

    Public Shared ReadOnly Property Instance As UserBundle
        Get
            If singleton Is Nothing Then
                Throw New InvalidOperationException("UserBundle has not been initialized.")
            End If
            Return singleton
        End Get
    End Property

    Public Shared Sub Destroy()
        If singleton IsNot Nothing Then
            singleton = Nothing
        Else
            Throw New InvalidOperationException("UserBundle is already destroyed or has not been initialized.")
        End If
    End Sub
End Class