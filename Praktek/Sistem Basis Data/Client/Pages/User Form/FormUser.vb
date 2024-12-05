Imports System.Drawing.Drawing2D
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class FormUser

    Dim request As New HttpRequestHandler()
    Private Async Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim userInstance = UserBundle.Instance

        Dim suratPeringatan = PerhitunganSuratPeringatan(userInstance)

        Me.ControlBox = False
        Me.CenterToScreen()

        Dim jurusan As String = userInstance.userData("jurusan")
        Dim kelas As String = userInstance.userData("kelas")


        Dim alphabetPart As String = kelas.Split("-"c)(0)

        Dim numericPart As String = kelas.Split("-"c)(1)

        Dim formattedString As String = numericPart(0) & jurusan & alphabetPart & "-" & numericPart(1)


        NamaLbl.Text = userInstance.userData("nama")
        NimLbl.Text = userInstance.userData("nim")
        KelasLbl.Text = formattedString
        JurusanLbl.Text = jurusan

        SPTulisLbl.Text = suratPeringatan(0)

        SPLisanLbl.Text = suratPeringatan(1)




        Dim dataTable As DataTable = Await GetTableRequest(userInstance)

        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then

            Label1.Visible = False

            RiwayatPeringatan.DataSource = dataTable

            RiwayatPeringatan.Visible = True

            RefreshBtn.Visible = True

        Else

            Label1.Text = "Kamu Tidak Memiliki Riwayat Peringatan, Yey!!"

        End If


        Me.ControlBox = True
        Me.MinimizeBox = False
        Me.MaximizeBox = False


    End Sub

    Private Function PerhitunganSuratPeringatan(userInstance As UserBundle) As List(Of Integer)


        Dim jumlahSp As Integer = userInstance.userData("jumlah_sp")

        Dim spTulis As Integer = Math.Floor(jumlahSp / 4)

        Dim spLisan As Integer = jumlahSp Mod 4

        Return New List(Of Integer) From {spTulis, spLisan}

    End Function

    Private Async Function GetTableRequest(userInstance As UserBundle) As Task(Of DataTable)

        Dim url As String = Path.Combine(ConstantManager.URL_BASE, "get_warn")

        Dim queryArgs As New List(Of Dictionary(Of String, Object)) From {
        New Dictionary(Of String, Object) From {{"nim", userInstance.userData("nim")}}
    }

        Try
            ' Get the JSON response from the API
            Dim response As Dictionary(Of String, Object) = Await request.GetJsonAsync(url, queryArgs)

            ' Parse the response value into a JArray
            Dim jArray As JArray = JArray.Parse(response("value").ToString())

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()
            Dim specificColumns As List(Of String) = New List(Of String)({"kd_peringatan", "kode_etik", "laporan", "jenis_peringatan", "waktu_peringatan", "link_surat", "diterima"})
            Dim header As List(Of String) = New List(Of String)({"Kode Peringatan", "Kode Etik", "Laporan", "Jenis Peringatan", "Waktu Peringatan", "Link Surat", "Diterima"})

            ' Get the column names from the first item in the JArray
            If jArray.Count > 0 Then
                For Each column As String In specificColumns
                    dataTable.Columns.Add(column)
                Next

                For Each item As JObject In jArray
                    Dim row As DataRow = dataTable.NewRow()
                    For Each column As String In specificColumns
                        If column = "diterima" Then
                            ' Check the value as a string and set "belum" or "sudah"
                            row(column) = If(item(column).ToString() = "0", "belum", "sudah")
                        ElseIf column = "link_surat" Then
                            row(column) = If(item(column).ToString() = Nothing, "tidak ada", "ada")
                        Else
                            ' For other columns, use the original value
                            row(column) = item(column)
                        End If
                    Next
                    dataTable.Rows.Add(row)
                Next
            End If

            Return dataTable

        Catch ex As Exception
            ' Handle any errors
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Private Sub RiwayatPeringatan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RiwayatPeringatan.CellContentClick
        If e.RowIndex >= 0 Then
            If RiwayatPeringatan.Columns(e.ColumnIndex).Name = "link_surat" Then

                Dim value As String = RiwayatPeringatan.Rows(e.RowIndex).Cells("link_surat").Value?.ToString()
                Dim formInformation As String = RiwayatPeringatan.Rows(e.RowIndex).Cells("diterima").Value?.ToString()
                Dim warnCode As String = RiwayatPeringatan.Rows(e.RowIndex).Cells("kd_peringatan").Value?.ToString()

                ' Debugging to check values
                MsgBox("Form Information: " & formInformation & vbCrLf & "Warn Code: " & warnCode)

                If formInformation <> "sudah" AndAlso Not String.IsNullOrEmpty(warnCode) Then
                    ' Show the form if conditions are met
                    Dim spConfirmForm As New SPConfirm(warnCode)
                    spConfirmForm.ShowDialog()  ' Use ShowDialog for a modal form
                Else
                    ' If condition fails, show a message box to help debugging
                    MsgBox("Conditions not met for form display.")
                End If

            End If
        End If
    End Sub

    Private Async Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click

        Dim userInstance = UserBundle.Instance
        RefreshBtn.Enabled = False


        Dim dataTable As DataTable = Await GetTableRequest(userInstance)

        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            Label1.Visible = False
            RiwayatPeringatan.DataSource = dataTable
            RiwayatPeringatan.Visible = True


        Else
            RiwayatPeringatan.Visible = False
            Label1.Enabled = True
            Label1.Text = "Kamu Tidak Memiliki Riwayat Peringatan, Yey!!"

        End If

        RefreshBtn.Enabled = True
    End Sub

    Private Sub FormUser_Exit(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            ' Destroy the UserBundle instance
            UserBundle.Destroy()

            ' Show the login form
            Dim loginForm As New LoginForm()
            loginForm.Show()

            ' Dispose of the current form
            Me.Dispose()
        End If
    End Sub

End Class