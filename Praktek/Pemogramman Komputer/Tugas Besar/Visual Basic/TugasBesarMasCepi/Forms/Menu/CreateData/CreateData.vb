Public Class CreateData

    Private ReadOnly DEFAULT_BTN_VALUE As String = "Pemasukan"
    Private ReadOnly DEFAULT_CB_BOX_VALUE As Integer = 0
    Private financeType As String

    Private Sub CreateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        FormGroupBox.Text = DEFAULT_BTN_VALUE
        financeType = DEFAULT_BTN_VALUE

        MetodeCB.SelectedIndex = DEFAULT_CB_BOX_VALUE

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        Dim menu As New Menu()
        menu.Show()

        Close()

    End Sub

    Private Sub PemasukanBtn_Click(sender As Object, e As EventArgs) Handles PemasukanBtn.Click

        Dim pemasukan As String = "Pemasukan"

        If FormGroupBox.Text <> pemasukan Then

            FormGroupBox.Text = pemasukan
            financeType = pemasukan

        End If

    End Sub

    Private Sub PengeluaranBtn_Click(sender As Object, e As EventArgs) Handles PengeluaranBtn.Click

        Dim pengeluaran As String = "Pengeluaran"

        If FormGroupBox.Text <> pengeluaran Then

            FormGroupBox.Text = pengeluaran
            financeType = pengeluaran

        End If

    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        Dim session As New SessionManager()
        Dim sessionRawData = session.ReadSession()
        Dim sessionId = sessionRawData(0)("id").ToString()

        Dim parsingInteger As Boolean = Integer.TryParse(NominalText.Text, 0)

        If Not parsingInteger Then

            MsgBox("Error : Invalid Number!!")

            NominalText.Text = ""
            MetodeCB.SelectedIndex = DEFAULT_CB_BOX_VALUE
            PerincianText.Text = ""


            Return

        End If


        Dim parameters As New Dictionary(Of String, Object) From {
            {"finance_type", financeType},
            {"user_id", sessionId},
            {"nominal", NominalText.Text},
            {"method", MetodeCB.SelectedItem.ToString()},
            {"details", PerincianText.Text},
            {"create_at", DateTime.Now}
        }


        Dim result As KeyValuePair(Of Integer, String) = DBInsertFinance(parameters)


        If result.Key = 0 Then
            NominalText.Text = ""
            MetodeCB.SelectedIndex = DEFAULT_CB_BOX_VALUE
            PerincianText.Text = ""

            MsgBox(result.Value)
        Else
            MsgBox(result.Value)
        End If
    End Sub
End Class