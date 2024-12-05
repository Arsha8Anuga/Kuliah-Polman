Public Class Form2
    Dim tanggal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Nama Peminjam", 150)
        ListView1.Columns.Add("Barang Pinjaman", 150)
        ListView1.Columns.Add("Waktu Peminjaman", 150)
        TextBox1.Focus()

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = Format(Now)

        Dim a As Integer
        For a = 0 To 100 Step +1
            Me.Opacity = a / 100
            Me.Refresh()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tanggal = DateAdd(DateInterval.Day, 3, DateTimePicker1.Value)
        Label4.Text = "Tanggal Pengembalian adalah " + Format(tanggal, "dd/MM/yyy")

        Dim Arr(3) As String
        Arr(0) = TextBox1.Text
        Arr(1) = TextBox2.Text
        Arr(2) = DateTimePicker1.Text



        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()

    End Sub
End Class