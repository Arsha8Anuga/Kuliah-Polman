<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studiKasus1Kalkulator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        absVal = New Button()
        quadratic = New Button()
        clearBtn = New Button()
        backspaceBtn = New Button()
        divisor = New Button()
        modulus = New Button()
        radical = New Button()
        exponent = New Button()
        multiplier = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        substraction = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        equations = New Button()
        decimalBtn = New Button()
        btn0 = New Button()
        plusMinusBtn = New Button()
        addition = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        oprLabel = New Label()
        prevNum = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Adobe Fan Heiti Std B", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(377, 61)
        TextBox1.TabIndex = 0
        ' 
        ' absVal
        ' 
        absVal.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        absVal.Location = New Point(12, 137)
        absVal.Name = "absVal"
        absVal.Size = New Size(83, 62)
        absVal.TabIndex = 1
        absVal.Text = "|x|"
        absVal.UseVisualStyleBackColor = True
        ' 
        ' quadratic
        ' 
        quadratic.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        quadratic.Location = New Point(108, 137)
        quadratic.Name = "quadratic"
        quadratic.Size = New Size(83, 62)
        quadratic.TabIndex = 2
        quadratic.Text = "x^2"
        quadratic.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clearBtn.Location = New Point(207, 137)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(83, 62)
        clearBtn.TabIndex = 3
        clearBtn.Text = "C"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' backspaceBtn
        ' 
        backspaceBtn.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        backspaceBtn.Location = New Point(306, 137)
        backspaceBtn.Name = "backspaceBtn"
        backspaceBtn.Size = New Size(83, 62)
        backspaceBtn.TabIndex = 4
        backspaceBtn.Text = "BS"
        backspaceBtn.UseVisualStyleBackColor = True
        ' 
        ' divisor
        ' 
        divisor.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        divisor.Location = New Point(306, 215)
        divisor.Name = "divisor"
        divisor.Size = New Size(83, 62)
        divisor.TabIndex = 8
        divisor.Text = "/"
        divisor.UseVisualStyleBackColor = True
        ' 
        ' modulus
        ' 
        modulus.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        modulus.Location = New Point(207, 215)
        modulus.Name = "modulus"
        modulus.Size = New Size(83, 62)
        modulus.TabIndex = 7
        modulus.Text = "%"
        modulus.UseVisualStyleBackColor = True
        ' 
        ' radical
        ' 
        radical.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radical.Location = New Point(108, 215)
        radical.Name = "radical"
        radical.Size = New Size(83, 62)
        radical.TabIndex = 6
        radical.Text = "√"
        radical.UseVisualStyleBackColor = True
        ' 
        ' exponent
        ' 
        exponent.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exponent.Location = New Point(12, 215)
        exponent.Name = "exponent"
        exponent.Size = New Size(83, 62)
        exponent.TabIndex = 5
        exponent.Text = "x^y"
        exponent.UseVisualStyleBackColor = True
        ' 
        ' multiplier
        ' 
        multiplier.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        multiplier.Location = New Point(306, 294)
        multiplier.Name = "multiplier"
        multiplier.Size = New Size(83, 62)
        multiplier.TabIndex = 12
        multiplier.Text = "x"
        multiplier.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Location = New Point(207, 294)
        btn3.Name = "btn3"
        btn3.Size = New Size(83, 62)
        btn3.TabIndex = 11
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(108, 294)
        btn2.Name = "btn2"
        btn2.Size = New Size(83, 62)
        btn2.TabIndex = 10
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(12, 294)
        btn1.Name = "btn1"
        btn1.Size = New Size(83, 62)
        btn1.TabIndex = 9
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' substraction
        ' 
        substraction.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        substraction.Location = New Point(306, 371)
        substraction.Name = "substraction"
        substraction.Size = New Size(83, 62)
        substraction.TabIndex = 16
        substraction.Text = "-"
        substraction.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(207, 371)
        btn6.Name = "btn6"
        btn6.Size = New Size(83, 62)
        btn6.TabIndex = 15
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(108, 371)
        btn5.Name = "btn5"
        btn5.Size = New Size(83, 62)
        btn5.TabIndex = 14
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(12, 371)
        btn4.Name = "btn4"
        btn4.Size = New Size(83, 62)
        btn4.TabIndex = 13
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' equations
        ' 
        equations.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        equations.Location = New Point(306, 525)
        equations.Name = "equations"
        equations.Size = New Size(83, 62)
        equations.TabIndex = 24
        equations.Text = "="
        equations.UseVisualStyleBackColor = True
        ' 
        ' decimalBtn
        ' 
        decimalBtn.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        decimalBtn.Location = New Point(207, 525)
        decimalBtn.Name = "decimalBtn"
        decimalBtn.Size = New Size(83, 62)
        decimalBtn.TabIndex = 23
        decimalBtn.Text = "."
        decimalBtn.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn0.Location = New Point(108, 525)
        btn0.Name = "btn0"
        btn0.Size = New Size(83, 62)
        btn0.TabIndex = 22
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' plusMinusBtn
        ' 
        plusMinusBtn.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plusMinusBtn.Location = New Point(12, 525)
        plusMinusBtn.Name = "plusMinusBtn"
        plusMinusBtn.Size = New Size(83, 62)
        plusMinusBtn.TabIndex = 21
        plusMinusBtn.Text = "+/-"
        plusMinusBtn.UseVisualStyleBackColor = True
        ' 
        ' addition
        ' 
        addition.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addition.Location = New Point(306, 448)
        addition.Name = "addition"
        addition.Size = New Size(83, 62)
        addition.TabIndex = 20
        addition.Text = "+"
        addition.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(207, 448)
        btn9.Name = "btn9"
        btn9.Size = New Size(83, 62)
        btn9.TabIndex = 19
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(108, 448)
        btn8.Name = "btn8"
        btn8.Size = New Size(83, 62)
        btn8.TabIndex = 18
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(12, 448)
        btn7.Name = "btn7"
        btn7.Size = New Size(83, 62)
        btn7.TabIndex = 17
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' oprLabel
        ' 
        oprLabel.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        oprLabel.Location = New Point(12, 23)
        oprLabel.Name = "oprLabel"
        oprLabel.Size = New Size(35, 23)
        oprLabel.TabIndex = 25
        ' 
        ' prevNum
        ' 
        prevNum.Font = New Font("Adobe Fan Heiti Std B", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        prevNum.Location = New Point(53, 23)
        prevNum.Name = "prevNum"
        prevNum.Size = New Size(336, 23)
        prevNum.TabIndex = 26
        ' 
        ' studiKasus1Kalkulator
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(401, 601)
        Controls.Add(prevNum)
        Controls.Add(oprLabel)
        Controls.Add(equations)
        Controls.Add(decimalBtn)
        Controls.Add(btn0)
        Controls.Add(plusMinusBtn)
        Controls.Add(addition)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(substraction)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(multiplier)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(divisor)
        Controls.Add(modulus)
        Controls.Add(radical)
        Controls.Add(exponent)
        Controls.Add(backspaceBtn)
        Controls.Add(clearBtn)
        Controls.Add(quadratic)
        Controls.Add(absVal)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "studiKasus1Kalkulator"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents absVal As Button
    Friend WithEvents quadratic As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents backspaceBtn As Button
    Friend WithEvents divisor As Button
    Friend WithEvents modulus As Button
    Friend WithEvents radical As Button
    Friend WithEvents exponent As Button
    Friend WithEvents multiplier As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents substraction As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents equations As Button
    Friend WithEvents decimalBtn As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents plusMinusBtn As Button
    Friend WithEvents addition As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents oprLabel As Label
    Friend WithEvents prevNum As Label
End Class
