Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim plotModel As New PlotModel With {.Title = "Graph from 15 August to 15 September"}

        ' Define a DateTimeAxis for the X-Axis to represent dates
        Dim dateAxis As New DateTimeAxis With {
            .Position = AxisPosition.Bottom,
            .StringFormat = "dd MMM", ' Format the date as day and month
            .Title = "Date",
            .Minimum = DateTimeAxis.ToDouble(New DateTime(2024, 8, 15)), ' Start date (15 August)
            .Maximum = DateTimeAxis.ToDouble(New DateTime(2024, 9, 15))  ' End date (15 September)
        }
        plotModel.Axes.Add(dateAxis)

        ' Define a LinearAxis for the Y-Axis (for numerical values)
        Dim valueAxis As New LinearAxis With {
            .Position = AxisPosition.Left,
            .Title = "Value",
            .Minimum = 0,  ' Adjust based on your data
            .MajorGridlineStyle = LineStyle.Solid, ' Solid major gridlines
            .MinorGridlineStyle = LineStyle.Dot   ' Dotted minor gridlines
        }
        plotModel.Axes.Add(valueAxis)

        ' Create a LineSeries to represent the data
        Dim lineSeries As New LineSeries With {.Title = "Sample Data"}

        ' Add data points with DateTime converted to OxyPlot's double format for dates
        lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(New DateTime(2024, 8, 15)), 10)) ' 15 August
        lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(New DateTime(2024, 8, 20)), 20)) ' 20 August
        lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(New DateTime(2024, 8, 25)), 15)) ' 25 August
        lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(New DateTime(2024, 9, 1)), 25))  ' 1 September
        lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(New DateTime(2024, 9, 10)), 30)) ' 10 September
        lineSeries.Points.Add(New DataPoint(DateTimeAxis.ToDouble(New DateTime(2024, 9, 15)), 20)) ' 15 September

        ' Add the series to the plot model
        plotModel.Series.Add(lineSeries)

        ' Set the PlotView's model to the created model
        PlotView1.Model = plotModel

        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Name"
        DataGridView1.Columns(2).Name = "Age"

        ' Add rows
        Dim row1 As String() = {"1", "Alice", "25"}
        Dim row2 As String() = {"2", "Bob", "30"}
        Dim row3 As String() = {"3", "Charlie", "22"}

        DataGridView1.Rows.Add(row1)
        DataGridView1.Rows.Add(row2)
        DataGridView1.Rows.Add(row3)
        DataGridView1.Rows.Add(row1)
        DataGridView1.Rows.Add(row2)
        DataGridView1.Rows.Add(row1)
        DataGridView1.Rows.Add(row2)
        DataGridView1.Rows.Add(row1)
        DataGridView1.Rows.Add(row2)
        DataGridView1.Rows.Add(row3)
        DataGridView1.Rows.Add(row3)
        DataGridView1.Rows.Add(row3)

        DataGridView1.AllowUserToAddRows = False


        AddHandler DataGridView1.CellClick, AddressOf dgv_CellClick
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Check if the clicked cell is in the third column (index 2 because column index is zero-based)
        If e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then
            ' Get the value from the row
            Dim dgv As DataGridView = CType(sender, DataGridView)
            Dim rowValue As String = dgv.Rows(e.RowIndex).Cells(2).Value.ToString()

            ' Show the message box with the value from the row
            MessageBox.Show("Value of Age (Column 3) in this row: " & rowValue)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class