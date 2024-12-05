Public Class LogActivity
    Private Sub LogActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        Dim session As New SessionManager()
        Dim sessionRawData = session.ReadSession()
        Dim sessionId = sessionRawData(0)("id").ToString()

        Dim filters As New Dictionary(Of String, Object)
        filters.Add("user_id", sessionId)

        Dim result As KeyValuePair(Of Integer, Object) = DBReadFinance(filters)



        If result.Key = 0 Then

            Dim financeData As List(Of Dictionary(Of String, Object)) = CType(result.Value, List(Of Dictionary(Of String, Object)))

            For Each record In financeData
                Dim metode As String = record("method").ToString()
                Dim dateTimeStr As String = Convert.ToDateTime(record("create_at")).ToString("dd-MMM-yyyy HH:mm:ss")
                Dim amount As String = "Rp. " & If(record("finance_type") = "Pengeluaran", "- ", "") & Decimal.Parse(record("nominal").ToString()).ToString("N0")
                Dim type As String = record("finance_type").ToString()


                AddDynamicPanel(metode, dateTimeStr, amount, type)
            Next

        ElseIf result.Key = 404 Then
            MessageBox.Show(result.Value.ToString())

        Else
            MessageBox.Show("Failed to load data: " & result.Value.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim menu As New Menu()
            menu.Show()

            Close()
        End If
    End Sub

    Private Sub AddDynamicPanel(metodeText As String, dateText As String, nominalText As String, financeType As String)


        Dim MethodeLabel As New Label()
        MethodeLabel.Font = New Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MethodeLabel.Location = New Point(16, 14)
        MethodeLabel.Margin = New Padding(4)
        MethodeLabel.Name = "Label1"
        MethodeLabel.Size = New Size(101, 23)
        MethodeLabel.TabIndex = 0
        MethodeLabel.Text = metodeText


        Dim Label2 As New Label()
        Label2.Font = New Font("Adobe Fan Heiti Std B", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(16, 45)
        Label2.Margin = New Padding(4)
        Label2.Name = "Label2"
        Label2.AutoSize = True
        Label2.TabIndex = 1
        Label2.Text = dateText


        Dim Label3 As New Label()
        Label3.Font = New Font("Adobe Fan Heiti Std B", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label3.ImageAlign = ContentAlignment.MiddleLeft
        Label3.Location = New Point(240, 15)
        Label3.Margin = New Padding(4)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 18)
        Label3.TabIndex = 2
        Label3.ForeColor = If(financeType = "Pemasukan", Color.Green, Color.Red)
        Label3.Text = nominalText
        Label3.TextAlign = ContentAlignment.MiddleRight


        Dim Panel2 As New Panel()
        Panel2.Location = New Point(0, (Panel1.Controls.Count * 100))
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 93)
        Panel2.TabIndex = 0


        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(MethodeLabel)

        Panel1.Controls.Add(Panel2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim menu As New Menu()
        menu.Show()

        Close()

    End Sub
End Class