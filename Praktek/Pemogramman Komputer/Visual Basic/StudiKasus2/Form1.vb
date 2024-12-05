Imports System.IO
Imports System.Linq.Expressions
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Function PyramidMaker(userInput As Integer) As String

        Dim decrementUserInput As Integer = 0
        Dim strRes As String = ""





        For i As Integer = 1 To userInput



            For j As Integer = 1 To userInput



                If j > Math.Floor(userInput - 0.1 / 2 - decrementUserInput) Then

                    strRes &= " * "
                Else

                    strRes &= "  "

                End If

            Next

            decrementUserInput += 1

            strRes &= vbCrLf

        Next


        Return strRes

    End Function

    Private Sub ForEachBtn_Click(sender As Object, e As EventArgs) Handles ForEachBtn.Click

        Dim strHold = ""


        Try

            If ForEachTxt.Text.Trim.StartsWith("{"c) AndAlso ForEachTxt.Text.Trim.EndsWith("}"c) Then

                Dim strTrim = ForEachTxt.Text.Trim("{"c, "}"c)
                Dim strArr = strTrim.Trim.Split(","c)

                For Each strItem In strArr

                    strHold &= strItem.Trim & " "

                Next


            Else

                Throw New Exception("Bukan Array!!")

            End If

            MsgBox(strHold)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub WriteBtn_Click(sender As Object, e As EventArgs) Handles WriteBtn.Click

        Dim content As String() = {writeTxt.Text}

        Try

            File.WriteAllLines(".\File.txt", content)
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ReadBtn_Click(sender As Object, e As EventArgs) Handles ReadBtn.Click

        Dim content As String = ""

        Try

            Dim lines As String() = File.ReadAllLines(".\File.txt")

            For Each line As String In lines

                content &= line
            Next

            MsgBox(content)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub MulaiBtn_Click(sender As Object, e As EventArgs)

    '    Dim equality = 1

    '    Do While equality <= 300

    '        equality += equality

    '        If equality <= 300 Then

    '            PertambahanLbl.Text = equality

    '        End If

    '    Loop

    'End Sub

    Private Sub SegitigaBtn_Click(sender As Object, e As EventArgs) Handles SegitigaBtn.Click

        MsgBox(PyramidMaker(SegitigaTxt.Text))

    End Sub
End Class



