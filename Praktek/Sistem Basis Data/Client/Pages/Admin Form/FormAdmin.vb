Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class FormAdmin
    Dim request As New HttpRequestHandler()
    Dim currentValue As String = ""

    Private Async Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ControlBox = False
        Me.CenterToScreen()

        Dim dataTable As DataTable = Await GetTableRequest()
        Dim list As List(Of String) = Await GetListRequest()

        If dataTable IsNot Nothing AndAlso list IsNot Nothing Then
            NIMCmbBox.Items.AddRange(list.ToArray())
            ConfigureUI(True)
            RiwayatSP.DataSource = dataTable
        Else
            Label5.Text = "Gagal mengambil data!!"
        End If

        Me.ControlBox = True
        Me.MinimizeBox = False
        Me.MaximizeBox = False

    End Sub

    Private Async Function GetListRequest() As Task(Of List(Of String))
        Try
            Dim response As Dictionary(Of String, Object) = Await request.GetJsonAsync(Path.Combine(ConstantManager.URL_BASE, "get_student"))
            Return JArray.Parse(response("value").ToString()) _
                .Cast(Of JObject)() _
                .Where(Function(item) item("nim") IsNot Nothing) _
                .Select(Function(item) item("nim").ToString()).ToList()
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Async Function DeleteRequest(warn_code As String) As Task(Of DataTable)
        Try
            Dim response As Boolean = Await request.DeleteAsync(Path.Combine(ConstantManager.URL_BASE, "sp_delete"),
                New List(Of Dictionary(Of String, Object)) From {New Dictionary(Of String, Object) From {{"warn_code", warn_code}}})

            Return If(response, Await GetTableRequest(), Nothing)
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Async Function GetTableRequest() As Task(Of DataTable)
        Try
            Dim response As Dictionary(Of String, Object) = Await request.GetJsonAsync(Path.Combine(ConstantManager.URL_BASE, "get_warn"))
            Dim jArray As JArray = JArray.Parse(response("value").ToString())

            Dim dataTable As New DataTable()
            Dim columnOrder = {"kd_peringatan", "nim", "nama", "kelas", "jurusan", "kode_etik",
                               "laporan", "jenis_peringatan", "link_surat", "diterima",
                               "waktu_peringatan", "waktu_diterima"}

            For Each column In columnOrder
                dataTable.Columns.Add(column)
            Next

            For Each item As JObject In jArray
                Dim row = dataTable.NewRow()
                For Each column In columnOrder
                    row(column) = If(column = "diterima", If(item(column)?.ToString() = "0", "belum", "sudah"),
                        If(item(column)?.ToString() = Nothing, "tidak ada", item(column)?.ToString()))
                Next
                dataTable.Rows.Add(row)
            Next

            Return dataTable
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Async Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        ToggleControls(False)
        RiwayatSP.DataSource = Await GetTableRequest()
        ToggleControls(True)
    End Sub

    Private Async Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Not String.IsNullOrEmpty(currentValue) AndAlso MessageBox.Show("Are you sure you want to delete this record?",
            "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ToggleControls(False)
            Dim dataTable = Await DeleteRequest(currentValue)
            RiwayatSP.DataSource = If(dataTable, RiwayatSP.DataSource)
            MsgBox(If(dataTable IsNot Nothing, "Data berhasil dihapus", "Error: Data tidak berhasil dihapus"))
            ToggleControls(True)
        Else
            MsgBox("Please select the row first")
        End If
    End Sub

    Private Async Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        If NIMCmbBox.SelectedIndex < 0 OrElse String.IsNullOrEmpty(LaporanSPTxtBox.Text) OrElse
           String.IsNullOrEmpty(KDEtikTxtBox.Text) OrElse JenisPeringatanCmbBox.SelectedIndex < 0 Then
            MsgBox("Tidak boleh ada yang kosong!!")
            Return
        End If

        ToggleControls(False)
        If Await InsertSP() Then
            ResetInputFields()
            RiwayatSP.DataSource = Await GetTableRequest()
            MsgBox("Data berhasil dimasukan")
        Else
            MsgBox("Gagal dalam memasukan data")
        End If
        ToggleControls(True)
    End Sub

    Public Async Function InsertSP() As Task(Of Boolean)
        Try
            Dim payload = New Dictionary(Of String, Object) From {
                {"nim", NIMCmbBox.SelectedItem.ToString()},
                {"kode_etik", KDEtikTxtBox.Text},
                {"laporan", LaporanSPTxtBox.Text},
                {"jenis_peringatan", JenisPeringatanCmbBox.SelectedItem.ToString()}
            }
            Dim response As Dictionary(Of String, Object) = Await request.PostJsonAsync(Path.Combine(ConstantManager.URL_BASE, "sp_insert"), payload)
            Return Not response.ContainsKey("error")
        Catch ex As Exception
            Debug.WriteLine($"Exception: {ex.Message}")
            Return False
        End Try
    End Function

    Private Sub RiwayatSP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RiwayatSP.CellClick
        If e.RowIndex >= 0 Then
            If RiwayatSP.Columns(e.ColumnIndex).Name = "link_surat" Then

                Dim value As String = RiwayatSP.Rows(e.RowIndex).Cells("link_surat").Value?.ToString()
                Dim formInformation As String = RiwayatSP.Rows(e.RowIndex).Cells("diterima").Value?.ToString()
                Dim warnCode As String = RiwayatSP.Rows(e.RowIndex).Cells("kd_peringatan").Value?.ToString()

                ' Debugging to check values
                MsgBox("Form Information: " & formInformation & vbCrLf & "Warn Code: " & warnCode)

                If value <> "tidak ada" AndAlso Not String.IsNullOrEmpty(warnCode) Then
                    ' Show the form if conditions are met
                    Dim spConfirmForm As New SPConfirmation(warnCode, formInformation)
                    spConfirmForm.ShowDialog()  ' Use ShowDialog for a modal form
                Else
                    ' If condition fails, show a message box to help debugging
                    MsgBox("Conditions not met for form display.")
                End If

            End If

        End If

    End Sub

    Private Sub FormUser_Exit(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

            UserBundle.Destroy()

            Dim loginForm As New LoginForm()
            loginForm.Show()

            Me.Dispose()
        End If
    End Sub

    Private Sub ConfigureUI(showData As Boolean)
        NIMCmbBox.Visible = showData
        RiwayatSP.Visible = showData
        Label1.Visible = showData
        Label2.Visible = showData
        Label3.Visible = showData
        Label4.Visible = showData
        Label5.Visible = Not showData
        KDEtikTxtBox.Visible = showData
        LaporanSPTxtBox.Visible = showData
        JenisPeringatanCmbBox.Visible = showData
        InsertBtn.Visible = showData
        DeleteBtn.Visible = showData
        RefreshBtn.Visible = showData
    End Sub

    Private Sub ToggleControls(enabled As Boolean)
        NIMCmbBox.Enabled = enabled
        LaporanSPTxtBox.Enabled = enabled
        KDEtikTxtBox.Enabled = enabled
        JenisPeringatanCmbBox.Enabled = enabled
        InsertBtn.Enabled = enabled
        DeleteBtn.Enabled = enabled
        RefreshBtn.Enabled = enabled
    End Sub

    Private Sub ResetInputFields()
        NIMCmbBox.SelectedIndex = -1
        JenisPeringatanCmbBox.SelectedIndex = -1
        LaporanSPTxtBox.Clear()
        KDEtikTxtBox.Clear()
    End Sub
End Class
