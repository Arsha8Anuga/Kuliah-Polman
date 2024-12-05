Imports System.Text
Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series

Public Class TableAndVisualization

    Private ReadOnly DEFAULT_BTN_VALUE As String = "Pemasukan"
    Private ReadOnly DEFAULT_CB_INDEX As Integer = 1
    Private ReadOnly DEFAULT_DATETIME As DateTime = DateTime.Now

    Private typeStr As String = DEFAULT_BTN_VALUE

    Private Sub TableAndVisualization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        CBTime.SelectedIndex = DEFAULT_CB_INDEX

        DateTimePicker.Value = DEFAULT_DATETIME

        TableData.ReadOnly = True

        TableData.AllowUserToAddRows = False

        TableData.AllowUserToResizeColumns = False

        TableData.AllowUserToResizeRows = False

        TableData.AutoGenerateColumns = False

        TableData.SelectionMode = False

        DataGraph.Enabled = False


        loadData()


    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged

        loadData()

    End Sub

    Private Sub loadData()

        Dim session As New SessionManager()
        Dim sessionRawData = session.ReadSession()
        Dim sessionId = sessionRawData(0)("id").ToString()

        Dim filters As New Dictionary(Of String, Object)()
        filters.Add("user_id", sessionId)


        Dim selectedDate As DateTime = DateTimePicker.Value


        Dim startDate As DateTime
        Dim endDate As DateTime = DateTimePicker.Value

        Dim graphStartDate As DateTime = DateTime.Now.AddMonths(-1).Date

        Dim isDay As Boolean = False

        Select Case CBTime.SelectedIndex
            Case 0
                startDate = selectedDate.AddMonths(-1).Date
            Case 1
                startDate = selectedDate.AddMonths(-1).Date
                isDay = False
            Case Else
                startDate = selectedDate.AddMonths(-1).Date
                isDay = False
        End Select

        filters.Add("create_at ::StrtDT", startDate)
        filters.Add("create_at ::EndDT", endDate)

        ' Add finance type filter
        If typeStr = "Pemasukan" Then
            filters.Add("finance_type", "Pemasukan")
        ElseIf typeStr = "Pengeluaran" Then
            filters.Add("finance_type", "Pengeluaran")
        End If

        Dim columns As String() = {"finance_type", "method", "nominal", "details", "create_at"}
        Dim result As KeyValuePair(Of Integer, Object) = DBReadFinance(filters, columns)

        If result.Key = 0 Then
            Dim results As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))

            results = results.OrderBy(Function(record) Convert.ToDateTime(record("create_at"))).ToList()

            Dim dataTable As New DataTable()
            dataTable.Columns.Add("Finance Type")
            dataTable.Columns.Add("Method")
            dataTable.Columns.Add("Nominal")
            dataTable.Columns.Add("Details")
            dataTable.Columns.Add("Create At")

            For Each record As Dictionary(Of String, Object) In results

                Dim row As DataRow = dataTable.NewRow()
                row("Finance Type") = record("finance_type")
                row("Method") = record("method")
                row("Nominal") = Convert.ToDecimal(record("nominal")).ToString("N0")
                row("Details") = record("details")
                row("Create At") = Convert.ToDateTime(record("create_at")).ToString("g")
                dataTable.Rows.Add(row)

            Next

            dataTable.DefaultView.Sort = "Create At ASC"
            TableData.DataSource = dataTable

            Dim plotModel As New PlotModel()


            Dim lineSeries As New LineSeries With {
                    .Color = If(typeStr = "Pemasukan", OxyColors.Green, OxyColors.Red),
                    .Title = "Monthly Data"
                }

            Dim scatterSeries As New ScatterSeries With {
                    .MarkerType = MarkerType.Circle,
                    .MarkerFill = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .MarkerSize = 2
                }

            Dim pointCount As Integer = 0


            For Each record As Dictionary(Of String, Object) In results
                Dim createAt As Date = Convert.ToDateTime(record("create_at"))
                Dim nominal As Decimal = Convert.ToDecimal(record("nominal"))

                lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(createAt), nominal))


                scatterSeries.Points.Add(New ScatterPoint(DateTimeAxis.ToDouble(createAt), nominal))


            Next

            plotModel.Series.Add(lineSeries)

            plotModel.Series.Add(scatterSeries)


            plotModel.Axes.Add(New DateTimeAxis() With {
                    .Position = AxisPosition.Bottom,
                    .Title = "Date",
                    .TextColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .AxislineColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .TitleColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .TicklineColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .ExtraGridlineColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .MajorGridlineColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217))
                })
            plotModel.Axes.Add(New LinearAxis() With {
                    .Position = AxisPosition.Left,
                    .Title = "Nominal",
                    .TextColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .AxislineColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217)),
                    .TitleColor = OxyColor.FromRgb(CByte(215), CByte(216), CByte(217))
                })


            DataGraph.Model = plotModel

        Else
            MessageBox.Show(result.Value.ToString())
        End If
    End Sub

    Private Function GatherGridViewValues(Optional sortBy As String = "Create At") As List(Of Dictionary(Of String, Object))
        Dim result As New List(Of Dictionary(Of String, Object))()

        For Each row As DataGridViewRow In TableData.Rows
            If Not row.IsNewRow Then
                Dim rowDict As New Dictionary(Of String, Object)()


                For Each cell As DataGridViewCell In row.Cells
                    Dim columnName As String = TableData.Columns(cell.ColumnIndex).HeaderText
                    rowDict(columnName) = cell.Value
                Next

                result.Add(rowDict)
            End If
        Next


        result = result.OrderBy(Function(dict) dict(sortBy)).ToList()

        Return result
    End Function

    Private Sub CBTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTime.SelectedIndexChanged
        loadData()
    End Sub

    Private Sub PemasukanBtn_Click(sender As Object, e As EventArgs) Handles PemasukanBtn.Click
        Dim Pemasukan As String = "Pemasukan"

        If typeStr <> Pemasukan Then

            typeStr = Pemasukan
            loadData()

        End If
    End Sub

    Private Sub PengeluaranBtn_Click(sender As Object, e As EventArgs) Handles PengeluaranBtn.Click
        Dim pengeluaran As String = "Pengeluaran"

        If typeStr <> pengeluaran Then

            typeStr = pengeluaran
            loadData()

        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        Dim menu As New Menu()
        menu.Show()

        Close()

    End Sub
End Class