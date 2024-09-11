Public Class studiKasus1Kalkulator

    ' Stacks for numbers and operators
    Private numberStack As New Stack(Of String)()
    Private operatorStack As New Stack(Of String)()
    Private infixExpression As String

    ' StringBuilder to build numbers
    Private sb As New System.Text.StringBuilder()

    ' Temporary value for current input
    Private currentInput As String = ""

    Private Sub studiKasus1Kalkulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the calculator on load if needed
    End Sub

    ' Handles numeric button clicks
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        Dim btn As Button = CType(sender, Button)

        If sb.Length = 0 AndAlso btn.Text <> "0"c Then
            sb.Append(btn.Text)
        ElseIf sb.Length > 0 Then
            sb.Append(btn.Text)
        End If

        UpdateInputDisplay()
    End Sub

    ' Handles operator button clicks
    Private Sub addition_Click(sender As Object, e As EventArgs) Handles addition.Click
        operatorStack.Push("+")
        ProcessOperator()
    End Sub

    ' Handles subtraction functionality
    Private Sub subtraction_Click(sender As Object, e As EventArgs) Handles substraction.Click
        operatorStack.Push("-")
        ProcessOperator()
    End Sub

    ' Handles multiplication functionality
    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplier.Click
        operatorStack.Push("*")
        ProcessOperator()
    End Sub

    ' Handles division functionality
    Private Sub division_Click(sender As Object, e As EventArgs) Handles divisor.Click
        operatorStack.Push("/")
        ProcessOperator()
    End Sub

    ' Handles modulus functionality
    Private Sub modulus_Click(sender As Object, e As EventArgs) Handles modulus.Click
        operatorStack.Push("%")
        ProcessOperator()
    End Sub

    ' Handles exponentiation functionality
    Private Sub exponent_Click(sender As Object, e As EventArgs) Handles exponent.Click
        operatorStack.Push("^")
        ProcessOperator()
    End Sub

    ' Handles square root functionality
    Private Sub squareRoot_Click(sender As Object, e As EventArgs) Handles radical.Click
        operatorStack.Push("√")
        ProcessOperator()
    End Sub

    ' Handles quadratic functionality
    Private Sub quadratic_Click(sender As Object, e As EventArgs) Handles quadratic.Click
        operatorStack.Push("^2")
        ProcessOperator()
    End Sub

    ' Append current input to the number stack
    Private Sub ProcessOperator()
        If sb.Length = 0 Then
            numberStack.Push("0")
        Else
            numberStack.Push(sb.ToString())
        End If

        sb.Clear()
        currentInput = ""

        UpdatePreviousDisplay()
        TextBox1.Text = ""
    End Sub

    ' Updates the display with the current input
    Private Sub UpdateInputDisplay()
        currentInput = sb.ToString()

        If sb.Length = 0 Then
            currentInput = "0"
        End If

        TextBox1.Text = currentInput
    End Sub

    ' Updates the previous number and operator display
    Private Sub UpdatePreviousDisplay()
        If numberStack.Count > 0 Then
            prevNum.Text = numberStack.Peek()
        Else
            prevNum.Text = ""
        End If

        If operatorStack.Count > 0 Then
            oprLabel.Text = operatorStack.Peek()
        Else
            oprLabel.Text = ""
        End If
    End Sub

    ' Handles backspace functionality
    Private Sub sbBackspace()
        If sb.Length > 0 Then
            sb.Length -= 1
            UpdateInputDisplay()
        ElseIf numberStack.Count > 0 Then
            sb.Clear()
            sb.Append(numberStack.Pop())
            If operatorStack.Count > 0 Then
                operatorStack.Pop()
            End If
            UpdateInputDisplay()
            UpdatePreviousDisplay()
        End If
    End Sub

    Private Sub backspaceBtn_Click(sender As Object, e As EventArgs) Handles backspaceBtn.Click
        sbBackspace()
    End Sub

    ' Handles negation functionality (+/-)
    Private Sub plusMinusBtn_Click(sender As Object, e As EventArgs) Handles plusMinusBtn.Click
        If sb.Length > 0 AndAlso sb(0) <> "-"c Then
            sb.Insert(0, "-")
        ElseIf sb.Length > 0 Then
            sb.Remove(0, 1)
        End If

        UpdateInputDisplay()
    End Sub

    ' Clears the input and reset the calculator
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        sb.Clear()
        numberStack.Clear()
        operatorStack.Clear()
        TextBox1.Text = "0"
        prevNum.Text = ""
        oprLabel.Text = ""
    End Sub

    ' Converts stack contents to infix string
    Private Sub infixSort()
        If sb.Length = 0 Then
            numberStack.Push("0")
        Else
            numberStack.Push(currentInput)
        End If

        Dim infixBuilder As New System.Text.StringBuilder()
        Dim reversedOperators As New Stack(Of String)(operatorStack.Reverse())
        Dim reversedNumbers As New Stack(Of String)(numberStack.Reverse())

        While reversedNumbers.Count > 0
            infixBuilder.Append(reversedNumbers.Pop())
            If reversedOperators.Count > 0 Then
                infixBuilder.Append(" " & reversedOperators.Pop() & " ")
            End If
        End While

        infixExpression = infixBuilder.ToString()
    End Sub

    ' Converts infix expression to postfix
    Private Function infixToPostfix() As String
        Dim postfixExpr As New List(Of String)()
        Dim opStack As New Stack(Of String)()
        Dim tokens As String() = infixExpression.Split(" "c)
        Dim precedence As New Dictionary(Of String, Integer) From {
        {"+", 1}, {"-", 1}, {"*", 2}, {"/", 2}, {"%", 2}, {"^", 3}, {"√", 4}, {"^2", 4}
    }

        For Each token As String In tokens
            If IsNumeric(token) Then
                postfixExpr.Add(token)
            ElseIf precedence.ContainsKey(token) Then
                While opStack.Count > 0 AndAlso precedence(opStack.Peek()) >= precedence(token)
                    postfixExpr.Add(opStack.Pop())
                End While
                opStack.Push(token)
            End If
        Next

        While opStack.Count > 0
            postfixExpr.Add(opStack.Pop())
        End While

        Return String.Join(" ", postfixExpr)
    End Function

    ' Evaluates the postfix expression
    Private Function EvaluatePostfix(postfixExpr As String) As Double
        Dim operandStack As New Stack(Of Double)()
        Dim tokens As String() = postfixExpr.Split(" "c)

        For Each token As String In tokens
            If IsNumeric(token) Then
                Dim number As Double = Double.Parse(token, System.Globalization.CultureInfo.InvariantCulture)
                operandStack.Push(number)
            Else
                Dim result As Double
                Select Case token
                    Case "+"
                        result = operandStack.Pop() + operandStack.Pop()
                    Case "-"
                        Dim operand2 As Double = operandStack.Pop()
                        Dim operand1 As Double = operandStack.Pop()
                        result = operand1 - operand2
                    Case "*"
                        result = operandStack.Pop() * operandStack.Pop()
                    Case "/"
                        Dim operand2 As Double = operandStack.Pop()
                        Dim operand1 As Double = operandStack.Pop()
                        If operand2 = 0 Then
                            Return Double.NaN
                        End If
                        result = operand1 / operand2
                    Case "%"
                        Dim operand2 As Double = operandStack.Pop()
                        Dim operand1 As Double = operandStack.Pop()
                        result = operand1 Mod operand2
                    Case "^"
                        result = Math.Pow(operandStack.Pop(), operandStack.Pop())
                    Case "√"
                        result = Math.Sqrt(operandStack.Pop())
                    Case "^2"
                        result = Math.Pow(operandStack.Pop(), 2)
                End Select

                operandStack.Push(result)
            End If
        Next

        Return operandStack.Pop()
    End Function

    ' Handles equation evaluation
    Private Sub equations_Click(sender As Object, e As EventArgs) Handles equations.Click

        Dim postfixExpr As String
        Dim result As Double

        infixSort()

        postfixExpr = infixToPostfix()

        If postfixExpr <> "" Then
            result = EvaluatePostfix(postfixExpr)
        End If

        numberStack.Clear()
        operatorStack.Clear()
        sb.Clear()
        currentInput = ""
        UpdatePreviousDisplay()


        If (infixExpression <> "0") Then
            sb.Append(result.ToString())
        End If


        TextBox1.Text = If(sb.Length > 0, sb.ToString(), "0")

    End Sub

    Private Sub decimalBtn_Click(sender As Object, e As EventArgs) Handles decimalBtn.Click
        If Not (sb.ToString().Contains(decimalBtn.Text)) Then
            sb.Append(decimalBtn.Text)
        End If

        UpdateInputDisplay()
    End Sub

    Function ContainsDot(array As String()) As Boolean
        For Each item As String In array
            If item.Contains(".") Then
                Return True
            End If
        Next
        Return False
    End Function


End Class