Public Class studiKasus1BangunDatarTemplate


    Dim yAxis As Integer = 40
    Dim yStart As Integer
    Dim xAxis As Integer = 10
    Dim acronym As String = ""
    Dim calcVarCount As Integer
    Dim calcResCount As Integer
    Dim endPosition As New Point()
    Private shape As String

    Public Sub SetData(shapeData As String)
        shape = shapeData
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        yStart = titleName.Bottom

        Select Case shape
            Case "bs" ' Bujur Sangkar (Square)
                acronym = "bujur sangkar"
                titleName.Text = acronym
                endPosition = createCalcVar("sisi")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "bs")

            Case "pp" ' Persegi Panjang (Rectangle)
                acronym = "persegi panjang"
                titleName.Text = acronym
                endPosition = createCalcVar("panjang", "lebar")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "pp")

            Case "bk" ' Belah Ketupat (Rhombus)
                acronym = "belah ketupat"
                titleName.Text = acronym
                endPosition = createCalcVar("diagonal 1", "diagonal 2", "sisi")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "bk")

            Case "jg" ' Jajar Genjang (Parallelogram)
                acronym = "jajar genjang"
                titleName.Text = acronym
                endPosition = createCalcVar("alas", "tinggi", "sisi 1", "sisi 2")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "jg")

            Case "t" ' Trapesium (Trapezium)
                acronym = "trapesium"
                titleName.Text = acronym
                endPosition = createCalcVar("alas a", "alas b", "tinggi", "sisi 1", "sisi 2", "sisi 3", "sisi 4")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "t")

            Case "ll" ' Layang-Layang (Kite)
                acronym = "layang-layang"
                titleName.Text = acronym
                endPosition = createCalcVar("diagonal 1", "diagonal 2", "sisi 1", "sisi 2")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "ll")

            Case "s" ' Segitiga (Triangle)
                acronym = "segitiga"
                titleName.Text = acronym
                endPosition = createCalcVar("alas", "tinggi", "sisi 1", "sisi 2", "sisi 3")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "s")

            Case "l" ' Lingkaran (Circle)
                acronym = "lingkaran"
                titleName.Text = acronym
                endPosition = createCalcVar("jari-jari")
                createResVal(endPosition.X, "luas", "keliling")
                createCalcBtn(endPosition.Y, " = ", "l")

        End Select



    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()

    End Sub

    Private Function createCalcVar(ParamArray nameLbl() As String) As Point

        Dim botMargin As Integer = 0
        Dim leftMargin As Integer = 0

        For i As Integer = 0 To nameLbl.Length - 1
            Dim lbl As New Label()
            lbl.Text = nameLbl(i) & ": "
            lbl.Location = New Point(xAxis, titleName.Bottom + (i * yAxis))
            lbl.AutoSize = True

            Dim txt As New TextBox()
            txt.Name = "txtInput" & i
            txt.Location = New Point(xAxis + (lbl.Width / 2) + 20, lbl.Top)

            botMargin = lbl.Bottom
            leftMargin = txt.Right

            calcVarCount += 1

            Me.Controls.Add(lbl)
            Me.Controls.Add(txt)

        Next


        Return New Point(leftMargin, botMargin)
    End Function

    Private Sub createResVal(xPos As Integer, ParamArray nameLbl() As String)

        Dim botMargin As Integer = 0

        For i As Integer = 0 To nameLbl.Length - 1
            Dim lbl As New Label()
            lbl.Text = nameLbl(i) & ": "
            lbl.Location = New Point(xPos + 70, titleName.Bottom + (i * yAxis))
            lbl.AutoSize = True

            Dim txt As New TextBox()
            txt.Name = "txtCalc" & i
            txt.Location = New Point(xPos + lbl.Width + 20, lbl.Top)

            botMargin = lbl.Bottom

            calcResCount += 1


            Me.Controls.Add(lbl)
            Me.Controls.Add(txt)
        Next

    End Sub


    Private Sub createCalcBtn(yPos As Integer, strText As String, strName As String)

        Dim btn As New Button()
        btn.Text = strText
        btn.Name = strName
        btn.Location = New Point(xAxis, yPos + 50)
        btn.AutoSize = True
        btn.Padding = New Padding(7)

        Me.Controls.Add(btn)

        AddHandler btn.Click, AddressOf calcBtn_Click

    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs)

        Dim calcBtn As Button = CType(sender, Button)
        Dim valueContainer As New Queue(Of String)()
        Dim resultContainer As New Queue(Of Double)()
        Dim value As Double

        For i As Integer = 0 To calcVarCount - 1
            Dim txt As TextBox = CType(Me.Controls("txtInput" & i), TextBox)

            If Not String.IsNullOrWhiteSpace(txt.Text) AndAlso Double.TryParse(txt.Text, value) Then
                valueContainer.Enqueue(txt.Text)
            Else
                valueContainer.Enqueue("0")
            End If
        Next


        Select Case calcBtn.Name
            Case "bs"
                If valueContainer.Count >= 1 Then
                    Dim value1 As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue(Math.Pow(value1, 2))
                    resultContainer.Enqueue(4 * value1)
                End If

            Case "pp"
                If valueContainer.Count >= 2 Then
                    Dim length As Double = Double.Parse(valueContainer.Dequeue())
                    Dim width As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue(length * width)
                    resultContainer.Enqueue(2 * (length + width))
                End If

            Case "bk"
                If valueContainer.Count >= 2 Then
                    Dim d1 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim d2 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue((d1 * d2) / 2)
                    resultContainer.Enqueue(4 * side)
                End If

            Case "jg"
                If valueContainer.Count >= 2 Then
                    Dim baseLength As Double = Double.Parse(valueContainer.Dequeue())
                    Dim height As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue(baseLength * height)

                    Dim side1 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side2 As Double = Double.Parse(valueContainer.Dequeue())
                    resultContainer.Enqueue(2 * (side1 + side2))
                End If

            Case "t"
                If valueContainer.Count >= 4 Then
                    Dim a As Double = Double.Parse(valueContainer.Dequeue())
                    Dim b As Double = Double.Parse(valueContainer.Dequeue())
                    Dim h As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side1 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side2 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side3 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side4 As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue(((a + b) / 2) * h)
                    resultContainer.Enqueue(side1 + side2 + side3 + side4)
                End If

            Case "ll"
                If valueContainer.Count >= 2 Then
                    Dim d1 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim d2 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side1 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side2 As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue((d1 * d2) / 2)
                    resultContainer.Enqueue(2 * (side1 + side2))
                End If

            Case "s"
                If valueContainer.Count >= 3 Then
                    Dim baseLength As Double = Double.Parse(valueContainer.Dequeue())
                    Dim height As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side1 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side2 As Double = Double.Parse(valueContainer.Dequeue())
                    Dim side3 As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue(0.5 * baseLength * height)
                    resultContainer.Enqueue(side1 + side2 + side3)
                End If

            Case "l"
                If valueContainer.Count >= 1 Then
                    Dim radius As Double = Double.Parse(valueContainer.Dequeue())

                    resultContainer.Enqueue(Math.PI * Math.Pow(radius, 2))
                    resultContainer.Enqueue(2 * Math.PI * radius)
                End If
        End Select

        For i As Integer = 0 To calcResCount - 1
            Dim txt As TextBox = CType(Me.Controls("txtCalc" & i), TextBox)
            If txt IsNot Nothing AndAlso resultContainer.Count > 0 Then
                Dim res As Double = resultContainer.Dequeue()
                txt.Text = res.ToString()
            End If
        Next

    End Sub
End Class