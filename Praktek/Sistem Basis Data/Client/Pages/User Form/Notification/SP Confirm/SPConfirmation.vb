Imports System.IO
Imports System.Reflection.Emit

Public Class SPConfirmation
    Dim request As New HttpRequestHandler()

    Public Property warn_code As String
    Public Property diterima As String

    Private diterima_bool As Boolean

    ' Constructor
    Public Sub New(ByVal warn_code As String, ByVal diterima As String)
        InitializeComponent()
        Me.warn_code = warn_code
        Me.diterima = diterima
    End Sub

    Private Async Sub SPConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await UseGetMultipartJsonAsync()

        WaitLbl.Visible = False
        ConfirmBtn.Visible = True
        CancelBtn.Visible = True
        ImageHolder.Visible = True


    End Sub

    Private Sub SPConfirm_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub

    Private Sub SetButtonsEnabled(ByVal isEnabled As Boolean)

        ConfirmBtn.Enabled = isEnabled
        CancelBtn.Enabled = isEnabled

    End Sub

    Private Sub SetOneButtonEnabled()

        If diterima = "sudah" Then
            CancelBtn.Enabled = True
        Else
            ConfirmBtn.Enabled = True
        End If

    End Sub

    Public Async Function UseGetMultipartJsonAsync() As Task
        Dim url As String = Path.Combine(ConstantManager.URL_BASE, "get_warn_image")

        If String.IsNullOrEmpty(warn_code) Then
            MessageBox.Show("Warning code is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim queryParameters As New List(Of Dictionary(Of String, Object)) From {
            New Dictionary(Of String, Object) From {{"warn_code", warn_code}}
        }

        Try

            Dim result As Tuple(Of Stream, Dictionary(Of String, Object)) = Await request.GetMultipartJsonAsync(url, queryParameters)

            If result IsNot Nothing AndAlso result.Item1 IsNot Nothing Then

                Dim fileStream As Stream = result.Item1
                If ImageHolder IsNot Nothing Then
                    ImageHolder.Image = Image.FromStream(fileStream)
                End If
                If diterima = "sudah" Then
                    CancelBtn.Enabled = True
                Else
                    ConfirmBtn.Enabled = True
                End If
            Else
                MsgBox("Gambar tidak ditemukan")
                ConfirmBtn.Enabled = False
                CancelBtn.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Async Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        ' Disable buttons during processing
        SetButtonsEnabled(False)

        ' Set diterima_bool to True for Confirm action
        diterima_bool = True

        ' Create the payload
        Dim payload As New Dictionary(Of String, Object) From {
            {"warn_code", warn_code},
            {"diterima", diterima_bool}
        }

        Try
            ' Send the payload using an HTTP PATCH request
            Dim url As String = Path.Combine(ConstantManager.URL_BASE, "update_warn_status")
            Dim response As Dictionary(Of String, Object) = Await request.PatchJsonAsync(url, payload)

            ' Handle the response
            If response IsNot Nothing Then
                MessageBox.Show("Status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Re-enable buttons
            SetOneButtonEnabled()
        End Try

    End Sub

    Private Async Sub EditBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        ' Disable buttons during processing
        SetButtonsEnabled(False)

        ' Set diterima_bool to False for Cancel action
        diterima_bool = False

        ' Create the payload
        Dim payload As New Dictionary(Of String, Object) From {
            {"warn_code", warn_code},
            {"diterima", diterima_bool}
        }

        Try
            ' Send the payload using an HTTP PATCH request
            Dim url As String = Path.Combine(ConstantManager.URL_BASE, "update_warn_status")
            Dim response As Dictionary(Of String, Object) = Await request.PatchJsonAsync(url, payload)

            ' Handle the response
            If response IsNot Nothing Then
                MessageBox.Show("Status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Re-enable buttons
            SetOneButtonEnabled()
        End Try

    End Sub
End Class