Imports System.IO

Public Class SPConfirm

    Dim request As New HttpRequestHandler()

    Public Property warn_code As String
    Dim currentImagePath As String = String.Empty

    ' Constructor
    Public Sub New(ByVal warn_code As String)
        InitializeComponent()
        Me.warn_code = warn_code
    End Sub

    Private Async Sub SPConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await UseGetMultipartJsonAsync()

        WaitLbl.Visible = False
        InsertBtn.Visible = True
        EditBtn.Visible = True
        BrowseBtn.Visible = True
        Label1.Visible = True
        ImageHolder.Visible = True


    End Sub

    Private Sub SPConfirm_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub

    Private Sub SetButtonsEnabled(ByVal isEnabled As Boolean)
        ' Enable or disable buttons
        InsertBtn.Enabled = isEnabled
        EditBtn.Enabled = isEnabled
        BrowseBtn.Enabled = isEnabled
        ' Add any other buttons you want to disable or enable here
    End Sub

    Public Async Function UseGetMultipartJsonAsync() As Task
        Dim url As String = Path.Combine(ConstantManager.URL_BASE, "get_warn_image")

        ' Ensure warn_code is not Nothing before proceeding
        If String.IsNullOrEmpty(warn_code) Then
            MessageBox.Show("Warning code is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim queryParameters As New List(Of Dictionary(Of String, Object)) From {
            New Dictionary(Of String, Object) From {{"warn_code", warn_code}}
        }

        Try
            ' Ensure that the response is valid and non-null
            Dim result As Tuple(Of Stream, Dictionary(Of String, Object)) = Await request.GetMultipartJsonAsync(url, queryParameters)

            If result IsNot Nothing AndAlso result.Item1 IsNot Nothing Then
                ' Handle image stream if not Nothing
                Dim fileStream As Stream = result.Item1
                If ImageHolder IsNot Nothing Then
                    ImageHolder.Image = Image.FromStream(fileStream)
                End If
                InsertBtn.Enabled = False
            Else
                Debug.WriteLine("No data received.")
                EditBtn.Enabled = False
            End If
        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Using openFileDialog As New OpenFileDialog()

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Select an Image"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    currentImagePath = openFileDialog.FileName
                    Label1.Text = currentImagePath

                    Dim filePath As String = openFileDialog.FileName


                    If ImageHolder IsNot Nothing Then

                        Using imageStream As Stream = New FileStream(filePath, FileMode.Open, FileAccess.Read)

                            ImageHolder.Image = Image.FromStream(imageStream)
                        End Using
                    End If
                Catch ex As Exception

                    MessageBox.Show("An error occurred while opening the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Async Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        Try
            ' Disable all buttons
            SetButtonsEnabled(False)

            ' Check if a valid image is loaded in the PictureBox
            If ImageHolder.Image IsNot Nothing AndAlso Not String.IsNullOrEmpty(currentImagePath) Then
                ' Get the file stream and file name from the PictureBox
                Dim fileStream As Stream = New FileStream(currentImagePath, FileMode.Open, FileAccess.Read)
                Dim fileName As String = Path.GetFileName(currentImagePath)

                Dim url As String = Path.Combine(ConstantManager.URL_BASE, "upload/sp_photo")

                ' Prepare additional JSON data (adjust based on your form fields)
                Dim jsonData As New Dictionary(Of String, Object) From {
                    {"warn_code", warn_code}
                }

                ' Create a Tuple with the file stream, file name, and additional JSON data
                Dim data As New Tuple(Of Stream, String, Dictionary(Of String, Object))(fileStream, fileName, jsonData)

                Dim response As Dictionary(Of String, Object) = Await request.PostMultipartJsonAsync(url, data)

                ' Handle the response after the request completes
                If response IsNot Nothing Then
                    ' Process the response (example: show a success message)
                    MessageBox.Show("File uploaded and data updated successfully.")
                    Close()
                End If
            Else
                MessageBox.Show("No image loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Handle any errors (network issues, file access problems, etc.)
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Re-enable buttons after operation
            SetButtonsEnabled(True)
            EditBtn.Enabled = False
        End Try
    End Sub

    Private Async Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            ' Disable all buttons
            SetButtonsEnabled(False)

            ' Check if a valid image is loaded in the PictureBox
            If ImageHolder.Image IsNot Nothing AndAlso Not String.IsNullOrEmpty(currentImagePath) Then
                ' Get the file stream and file name from the PictureBox
                Dim fileStream As Stream = New FileStream(currentImagePath, FileMode.Open, FileAccess.Read)
                Dim fileName As String = Path.GetFileName(currentImagePath)

                Dim url As String = Path.Combine(ConstantManager.URL_BASE, "update/sp_photo")

                ' Prepare additional JSON data (adjust based on your form fields)
                Dim jsonData As New Dictionary(Of String, Object) From {
                    {"warn_code", warn_code}
                }

                ' Create a Tuple with the file stream, file name, and additional JSON data
                Dim data As New Tuple(Of Stream, String, Dictionary(Of String, Object))(fileStream, fileName, jsonData)

                ' Use PatchMultipartJsonAsync instead of PostMultipartJsonAsync
                Dim response As Dictionary(Of String, Object) = Await request.PatchMultipartJsonAsync(url, data)

                ' Handle the response after the request completes
                If response IsNot Nothing Then
                    ' Process the response (example: show a success message)
                    MessageBox.Show("File updated and data patched successfully.")
                    Close()
                End If
            Else
                MessageBox.Show("No image loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Handle any errors (network issues, file access problems, etc.)
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Re-enable buttons after operation
            SetButtonsEnabled(True)
            InsertBtn.Enabled = False
        End Try
    End Sub
End Class
